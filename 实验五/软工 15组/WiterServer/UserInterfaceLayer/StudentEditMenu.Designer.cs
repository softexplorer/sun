namespace UserInterfaceLayer
{
    partial class StudentEditMenu
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
            this.lblHallMessage = new System.Windows.Forms.Label();
            this.txtStudentExtra = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblHallName = new System.Windows.Forms.Label();
            this.lblHallNumber = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.stuNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(426, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(426, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(426, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblHallMessage
            // 
            this.lblHallMessage.AutoSize = true;
            this.lblHallMessage.Location = new System.Drawing.Point(39, 288);
            this.lblHallMessage.Name = "lblHallMessage";
            this.lblHallMessage.Size = new System.Drawing.Size(53, 12);
            this.lblHallMessage.TabIndex = 18;
            this.lblHallMessage.Text = "附加信息";
            // 
            // txtStudentExtra
            // 
            this.txtStudentExtra.Location = new System.Drawing.Point(100, 260);
            this.txtStudentExtra.Multiline = true;
            this.txtStudentExtra.Name = "txtStudentExtra";
            this.txtStudentExtra.Size = new System.Drawing.Size(293, 86);
            this.txtStudentExtra.TabIndex = 17;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(426, 215);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // lblHallName
            // 
            this.lblHallName.AutoSize = true;
            this.lblHallName.Location = new System.Drawing.Point(258, 219);
            this.lblHallName.Name = "lblHallName";
            this.lblHallName.Size = new System.Drawing.Size(29, 12);
            this.lblHallName.TabIndex = 15;
            this.lblHallName.Text = "姓名";
            // 
            // lblHallNumber
            // 
            this.lblHallNumber.AutoSize = true;
            this.lblHallNumber.Location = new System.Drawing.Point(63, 219);
            this.lblHallNumber.Name = "lblHallNumber";
            this.lblHallNumber.Size = new System.Drawing.Size(29, 12);
            this.lblHallNumber.TabIndex = 14;
            this.lblHallNumber.Text = "学号";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(293, 216);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 21);
            this.txtStudentName.TabIndex = 13;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(100, 216);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(100, 21);
            this.txtStudentNumber.TabIndex = 12;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuNumber,
            this.stuName,
            this.extra});
            this.dgvStudents.Location = new System.Drawing.Point(29, 30);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowTemplate.Height = 23;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(472, 165);
            this.dgvStudents.TabIndex = 11;
            // 
            // stuNumber
            // 
            this.stuNumber.DataPropertyName = "Stu_Number";
            this.stuNumber.HeaderText = "学号";
            this.stuNumber.Name = "stuNumber";
            this.stuNumber.ReadOnly = true;
            // 
            // stuName
            // 
            this.stuName.DataPropertyName = "Stu_Name";
            this.stuName.HeaderText = "姓名";
            this.stuName.Name = "stuName";
            this.stuName.ReadOnly = true;
            // 
            // extra
            // 
            this.extra.DataPropertyName = "Extra";
            this.extra.HeaderText = "附加信息";
            this.extra.Name = "extra";
            this.extra.ReadOnly = true;
            // 
            // StudentEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 376);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHallMessage);
            this.Controls.Add(this.txtStudentExtra);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblHallName);
            this.Controls.Add(this.lblHallNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.dgvStudents);
            this.Name = "StudentEditMenu";
            this.Text = "编辑学生";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHallMessage;
        private System.Windows.Forms.TextBox txtStudentExtra;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblHallName;
        private System.Windows.Forms.Label lblHallNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra;
    }
}