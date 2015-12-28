namespace UserInterfaceLayer
{
    partial class RecentCourseMenu
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
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.courseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseNumber,
            this.courseName,
            this.courseMessage});
            this.dgvCourses.Location = new System.Drawing.Point(23, 12);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowTemplate.Height = 23;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(345, 165);
            this.dgvCourses.TabIndex = 23;
            // 
            // courseNumber
            // 
            this.courseNumber.DataPropertyName = "Course_Number";
            this.courseNumber.HeaderText = "课程号";
            this.courseNumber.Name = "courseNumber";
            this.courseNumber.ReadOnly = true;
            // 
            // courseName
            // 
            this.courseName.DataPropertyName = "Course_Name";
            this.courseName.HeaderText = "课程名";
            this.courseName.Name = "courseName";
            this.courseName.ReadOnly = true;
            // 
            // courseMessage
            // 
            this.courseMessage.DataPropertyName = "Course_Message";
            this.courseMessage.HeaderText = "课程信息";
            this.courseMessage.Name = "courseMessage";
            this.courseMessage.ReadOnly = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(157, 197);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 24;
            this.btnChoose.Text = "选择";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // RecentCourseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 238);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.dgvCourses);
            this.Name = "RecentCourseMenu";
            this.Text = "当前课程";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseMessage;
        private System.Windows.Forms.Button btnChoose;
    }
}