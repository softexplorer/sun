namespace UserInterfaceLayer
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartServe = new System.Windows.Forms.Button();
            this.lvwMessage = new System.Windows.Forms.ListView();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.btnImportList = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.课程安排ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.签到记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartServe
            // 
            this.btnStartServe.Location = new System.Drawing.Point(428, 178);
            this.btnStartServe.Name = "btnStartServe";
            this.btnStartServe.Size = new System.Drawing.Size(75, 23);
            this.btnStartServe.TabIndex = 1;
            this.btnStartServe.Text = "开始签到";
            this.btnStartServe.UseVisualStyleBackColor = true;
            // 
            // lvwMessage
            // 
            this.lvwMessage.Location = new System.Drawing.Point(25, 178);
            this.lvwMessage.Name = "lvwMessage";
            this.lvwMessage.Size = new System.Drawing.Size(381, 151);
            this.lvwMessage.TabIndex = 2;
            this.lvwMessage.UseCompatibleStateImageBehavior = false;
            this.lvwMessage.View = System.Windows.Forms.View.Details;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(380, 52);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 12);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IP";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(368, 98);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(403, 48);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 5;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(403, 94);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 6;
            // 
            // txtStatement
            // 
            this.txtStatement.Location = new System.Drawing.Point(25, 48);
            this.txtStatement.Multiline = true;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.ReadOnly = true;
            this.txtStatement.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatement.Size = new System.Drawing.Size(298, 94);
            this.txtStatement.TabIndex = 7;
            // 
            // btnImportList
            // 
            this.btnImportList.Location = new System.Drawing.Point(428, 219);
            this.btnImportList.Name = "btnImportList";
            this.btnImportList.Size = new System.Drawing.Size(75, 23);
            this.btnImportList.TabIndex = 8;
            this.btnImportList.Text = "导入名单";
            this.btnImportList.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(368, 144);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 12);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "info";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(403, 140);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 21);
            this.txtInfo.TabIndex = 10;
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课程安排ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.签到记录ToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(539, 25);
            this.mnsMain.TabIndex = 11;
            this.mnsMain.Text = "menuStrip1";
            // 
            // 课程安排ToolStripMenuItem
            // 
            this.课程安排ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生编辑ToolStripMenuItem});
            this.课程安排ToolStripMenuItem.Name = "课程安排ToolStripMenuItem";
            this.课程安排ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程安排ToolStripMenuItem.Text = "学生管理";
            // 
            // 学生编辑ToolStripMenuItem
            // 
            this.学生编辑ToolStripMenuItem.Name = "学生编辑ToolStripMenuItem";
            this.学生编辑ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.学生编辑ToolStripMenuItem.Text = "编辑学生";
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课程编辑ToolStripMenuItem,
            this.当前课程ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 课程编辑ToolStripMenuItem
            // 
            this.课程编辑ToolStripMenuItem.Name = "课程编辑ToolStripMenuItem";
            this.课程编辑ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.课程编辑ToolStripMenuItem.Text = "课程编辑";
            // 
            // 当前课程ToolStripMenuItem
            // 
            this.当前课程ToolStripMenuItem.Name = "当前课程ToolStripMenuItem";
            this.当前课程ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.当前课程ToolStripMenuItem.Text = "当前课程";
            // 
            // 签到记录ToolStripMenuItem
            // 
            this.签到记录ToolStripMenuItem.Name = "签到记录ToolStripMenuItem";
            this.签到记录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.签到记录ToolStripMenuItem.Text = "签到记录";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 372);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnImportList);
            this.Controls.Add(this.txtStatement);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lvwMessage);
            this.Controls.Add(this.btnStartServe);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "MainMenu";
            this.Text = "Witer签到界面";
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartServe;
        private System.Windows.Forms.ListView lvwMessage;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtStatement;
        private System.Windows.Forms.Button btnImportList;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem 课程安排ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 签到记录ToolStripMenuItem;
    }
}

