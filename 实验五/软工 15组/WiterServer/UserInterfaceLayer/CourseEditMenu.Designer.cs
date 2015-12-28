namespace UserInterfaceLayer
{
    partial class CourseEditMenu
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCourseMessage = new System.Windows.Forms.Label();
            this.txtCourseMessage = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseNumber = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.courseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(423, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(423, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(423, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblCourseMessage
            // 
            this.lblCourseMessage.AutoSize = true;
            this.lblCourseMessage.Location = new System.Drawing.Point(36, 295);
            this.lblCourseMessage.Name = "lblCourseMessage";
            this.lblCourseMessage.Size = new System.Drawing.Size(53, 12);
            this.lblCourseMessage.TabIndex = 29;
            this.lblCourseMessage.Text = "课程信息";
            // 
            // txtCourseMessage
            // 
            this.txtCourseMessage.Location = new System.Drawing.Point(97, 267);
            this.txtCourseMessage.Multiline = true;
            this.txtCourseMessage.Name = "txtCourseMessage";
            this.txtCourseMessage.Size = new System.Drawing.Size(293, 86);
            this.txtCourseMessage.TabIndex = 28;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(423, 222);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 27;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(243, 226);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(41, 12);
            this.lblCourseName.TabIndex = 26;
            this.lblCourseName.Text = "课程名";
            // 
            // lblCourseNumber
            // 
            this.lblCourseNumber.AutoSize = true;
            this.lblCourseNumber.Location = new System.Drawing.Point(50, 226);
            this.lblCourseNumber.Name = "lblCourseNumber";
            this.lblCourseNumber.Size = new System.Drawing.Size(41, 12);
            this.lblCourseNumber.TabIndex = 25;
            this.lblCourseNumber.Text = "课程号";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(290, 223);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 21);
            this.txtCourseName.TabIndex = 24;
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Location = new System.Drawing.Point(97, 223);
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.Size = new System.Drawing.Size(100, 21);
            this.txtCourseNumber.TabIndex = 23;
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
            this.dgvCourses.Location = new System.Drawing.Point(26, 37);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowTemplate.Height = 23;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(472, 165);
            this.dgvCourses.TabIndex = 22;
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
            // CourseEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 371);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCourseMessage);
            this.Controls.Add(this.txtCourseMessage);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseNumber);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseNumber);
            this.Controls.Add(this.dgvCourses);
            this.Name = "CourseEditMenu";
            this.Text = "课程编辑";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCourseMessage;
        private System.Windows.Forms.TextBox txtCourseMessage;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseNumber;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseNumber;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseMessage;
    }
}