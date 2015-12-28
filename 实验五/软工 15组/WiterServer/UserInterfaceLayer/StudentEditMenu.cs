using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace UserInterfaceLayer
{
    public partial class StudentEditMenu : Form
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public StudentEditMenu()
        {
            InitializeComponent();
            this.Load += new EventHandler(StudentEditMenu_Load);
            this.dgvStudents.CellClick +=new DataGridViewCellEventHandler(dgvStudents_CellClick);
            this.btnSelect.Click += new EventHandler(btnSelect_Click);
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            this.btnDelete.Click += new EventHandler(btnDelete_Click);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentEditMenu_Load(object sender, EventArgs e)
        {
            try
            {
                Refreshdgv();
                Refreshtxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 单元点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudents_CellClick(object sender, EventArgs e)
        {
            try
            {
                Refreshtxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataGridViewRow temp = null;    //存放从dgvHall中读取出来的行数据
            try
            {
                for (int i = 0; i < dgvStudents.Rows.Count; i++)
                {
                    temp = dgvStudents.Rows[i];
                    if (((string)temp.Cells["stuNumber"].Value).Contains(txtStudentNumber.Text) &&
                        ((string)temp.Cells["stuName"].Value).Contains(txtStudentName.Text) &&
                        ((string)temp.Cells["extra"].Value).Contains(txtStudentExtra.Text))
                    {
                        temp.Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.AddStudent(CreateAStudent());
                Refreshdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        /// <summary>
        /// 更新按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.UpdateStudent(CreateAStudent());
                Refreshdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.DeleteStudent(txtStudentNumber.Text);
                Refreshdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 制造一个学生对象
        /// </summary>
        /// <returns></returns>
        private Student CreateAStudent()
        {
            Student student = new Student(txtStudentNumber.Text);
            student.Name = txtStudentName.Text;
            student.Extra = txtStudentExtra.Text;
            return student;
        }
        
        /// <summary>
        /// 刷新DataGridView控件
        /// </summary>
        private void Refreshdgv()
        {
                this.dgvStudents.DataSource = DBHelper.GetStudentDataSet("").Tables[0];

            //this.dgvHall.DataSource = HallManagingHelper.HallDataSet.Tables["Hall"];
            //this.dgvHall.DataSource = DBHelper.GetHallList(" HallNumber like '" + txtHallNumber.Text + "%' and " + "HallName like '" + txtHallName.Text + "%' ").Tables[0];
        }

        /// <summary>
        /// 刷新TextBox控件
        /// </summary>
        private void Refreshtxt()
        {
            this.txtStudentNumber.Text = (string)dgvStudents.SelectedRows[0].Cells["stuNumber"].Value;
            this.txtStudentName.Text = (string)dgvStudents.SelectedRows[0].Cells["stuName"].Value;
            this.txtStudentExtra.Text = (string)dgvStudents.SelectedRows[0].Cells["extra"].Value;
        }
    }
}
