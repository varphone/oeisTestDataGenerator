using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace oeisTestDataGenerator
{
    public partial class TestDataGenerator : Form
    {
        long seq = 0;
        public delegate void AppendLogInvoker(string text);
        public delegate void GenericInvoker();

        public TestDataGenerator()
        {
            InitializeComponent();
        }

        private void AppendLog(string text)
        {
            editOutput.AppendText("\r\n");
            editOutput.AppendText(text);
        }

        private void BlockSend()
        {
            editUrl.Enabled = false;
            editUid.Enabled = false;
            dtTs.Enabled = false;
            editVa.Enabled = false;
            chkAutoUpdate.Enabled = false;
            btnSend.Enabled = false;
            picLoading.Visible = true;
        }

        private void UnblockSend()
        {
            editUrl.Enabled = true;
            editUid.Enabled = true;
            dtTs.Enabled = true;
            editVa.Enabled = true;
            chkAutoUpdate.Enabled = true;
            btnSend.Enabled = true;
            picLoading.Visible = false;
            //
            if (chkAutoUpdate.Checked)
            {
                dtTs.Value = DateTime.Now;
            }
        }

        private static void GetRequestStreamCallback(IAsyncResult asyncResult)
        {
            object[] args = asyncResult.AsyncState as object[];
            HttpWebRequest req = (HttpWebRequest)args[0];
            TestDataGenerator tdg = (TestDataGenerator)args[2];

            try
            {
                // End the operation
                Stream postStream = req.EndGetRequestStream(asyncResult);

                byte[] ba = args[1] as byte[];
                // Write to the request stream.
                postStream.Write(ba, 0, ba.Length);
                postStream.Close();

                // Start the asynchronous operation to get the response
                req.BeginGetResponse(new AsyncCallback(GetResponseCallback), args);
            }
            catch (Exception ex) {
                var f = new AppendLogInvoker(tdg.AppendLog);
                tdg.Invoke(f, ex.Message);
            }
            finally
            {
                tdg.Invoke(new GenericInvoker(tdg.UnblockSend));
            }
        }

        private static void GetResponseCallback(IAsyncResult asyncResult)
        {
            object[] args = asyncResult.AsyncState as object[];
            HttpWebRequest req = (HttpWebRequest)args[0];
            TestDataGenerator tdg = (TestDataGenerator)args[2];

            try
            {
                // End the operation
                HttpWebResponse res = (HttpWebResponse)req.EndGetResponse(asyncResult);
                Stream streamResponse = res.GetResponseStream();
                StreamReader streamRead = new StreamReader(streamResponse);
                string body = streamRead.ReadToEnd();
                streamResponse.Close();
                streamRead.Close();

                tdg.Invoke(new AppendLogInvoker(tdg.AppendLog), "STATUS: " + res.StatusCode);
                tdg.Invoke(new AppendLogInvoker(tdg.AppendLog), body);

                // Release the HttpWebResponse
                res.Close();
            }
            catch (Exception ex)
            {
                tdg.Invoke(new AppendLogInvoker(tdg.AppendLog), ex.Message);
            }
            finally
            {
                tdg.Invoke(new GenericInvoker(tdg.UnblockSend));
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var uid = editUid.Text.Trim();
            var url = editUrl.Text.Trim() + "/data/" + uid + "/save";
            var ts = (long)(dtTs.Value.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalMilliseconds;
            var vas = string.Join(",", Array.FindAll(editVa.Lines, delegate(string s) 
            { 
                return !string.IsNullOrEmpty(s); 
            }));
            var va = "[" + vas + "]";
            string json = string.Format(@"[{{""uid"":""{0}"",""seq"":{1},""ts"":{2},""va"":{3}}}]", uid, seq++, ts, va);
            var utf8 = Encoding.UTF8.GetBytes(json);
            AppendLog("====================================================================");
            AppendLog(url);
            AppendLog(json);
            AppendLog("====================================================================");
            //
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json; charset=utf-8";
            req.ContentLength = utf8.Length;
            req.ReadWriteTimeout = 5000;
            req.Timeout = 5000;
            req.BeginGetRequestStream(new AsyncCallback(GetRequestStreamCallback), new object[]{req, utf8, this});
            //
            BlockSend();
        }

        private void llbClearOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editOutput.Clear();
        }
    }
}
