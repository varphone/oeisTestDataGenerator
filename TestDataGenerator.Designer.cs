namespace oeisTestDataGenerator
{
    partial class TestDataGenerator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDataGenerator));
            this.editUrl = new System.Windows.Forms.TextBox();
            this.dtTs = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.editUid = new System.Windows.Forms.TextBox();
            this.editVa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.editOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbClearOutput = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // editUrl
            // 
            this.editUrl.Location = new System.Drawing.Point(77, 12);
            this.editUrl.Name = "editUrl";
            this.editUrl.Size = new System.Drawing.Size(321, 21);
            this.editUrl.TabIndex = 1;
            this.editUrl.Text = "http://192.168.123.2:8080/oeis/v1";
            this.toolTip1.SetToolTip(this.editUrl, "接收数据的服务器地址。");
            // 
            // dtTs
            // 
            this.dtTs.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtTs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTs.Location = new System.Drawing.Point(77, 66);
            this.dtTs.Name = "dtTs";
            this.dtTs.Size = new System.Drawing.Size(224, 21);
            this.dtTs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "接入地址：";
            // 
            // editUid
            // 
            this.editUid.Location = new System.Drawing.Point(77, 39);
            this.editUid.Name = "editUid";
            this.editUid.Size = new System.Drawing.Size(321, 21);
            this.editUid.TabIndex = 2;
            this.toolTip1.SetToolTip(this.editUid, "用于区分设备的唯一标识，由大写字母及数字组成。");
            // 
            // editVa
            // 
            this.editVa.Location = new System.Drawing.Point(77, 93);
            this.editVa.Multiline = true;
            this.editVa.Name = "editVa";
            this.editVa.Size = new System.Drawing.Size(321, 146);
            this.editVa.TabIndex = 5;
            this.toolTip1.SetToolTip(this.editVa, "可以接受多个数据。\r\n可以接受数字及字符串输入。\r\n每个数据作为单独一行输入。\r\n输入的字符串需要加上双引号(\"\")。\r\n");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "唯一标识：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "数据时戳：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "数据内容：";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(413, 93);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(128, 68);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "发送(&S)";
            this.toolTip1.SetToolTip(this.btnSend, "立即发送数据到服务器。");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 1000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "提示";
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Location = new System.Drawing.Point(309, 69);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(72, 16);
            this.chkAutoUpdate.TabIndex = 4;
            this.chkAutoUpdate.Text = "自动更新";
            this.toolTip1.SetToolTip(this.chkAutoUpdate, "数据发送后，自动将时戳更新为当前时间。");
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // editOutput
            // 
            this.editOutput.Location = new System.Drawing.Point(14, 282);
            this.editOutput.Multiline = true;
            this.editOutput.Name = "editOutput";
            this.editOutput.ReadOnly = true;
            this.editOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.editOutput.Size = new System.Drawing.Size(527, 101);
            this.editOutput.TabIndex = 7;
            this.toolTip1.SetToolTip(this.editOutput, "显示发送及接收到的数据。");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.llbClearOutput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(14, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 31);
            this.panel1.TabIndex = 10;
            // 
            // llbClearOutput
            // 
            this.llbClearOutput.AutoSize = true;
            this.llbClearOutput.Location = new System.Drawing.Point(488, 9);
            this.llbClearOutput.Name = "llbClearOutput";
            this.llbClearOutput.Size = new System.Drawing.Size(29, 12);
            this.llbClearOutput.TabIndex = 6;
            this.llbClearOutput.TabStop = true;
            this.llbClearOutput.Text = "清除";
            this.toolTip1.SetToolTip(this.llbClearOutput, "清除所有输出日志。");
            this.llbClearOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbClearOutput_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "输出日志";
            // 
            // picLoading
            // 
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(428, 14);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(100, 50);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 12;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // TestDataGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(553, 395);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.chkAutoUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editOutput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editVa);
            this.Controls.Add(this.editUid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTs);
            this.Controls.Add(this.editUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestDataGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OEIS 测试数据生成器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editUrl;
        private System.Windows.Forms.DateTimePicker dtTs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editUid;
        private System.Windows.Forms.TextBox editVa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox editOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        private System.Windows.Forms.LinkLabel llbClearOutput;
        private System.Windows.Forms.PictureBox picLoading;
    }
}

