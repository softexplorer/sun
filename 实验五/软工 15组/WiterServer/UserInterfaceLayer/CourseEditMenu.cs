using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DataAccessLayer;

namespace UserInterfaceLayer
{
    public partial class CourseEditMenu : Form
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CourseEditMenu()
        {
            InitializeComponent();
            this.Load += new EventHandler(CourseEditMenu_Load);
            this.dgvCourses.CellClick += new DataGridViewCellEventHandler(dgvCourses_CellClick);
            this.btnSelect.Click += new EventHandler(btnSelect_Click);
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            this.btnDelete.Click += new EventHandler(btnDelete_Click);
        }
        
        private void CourseEditMenu_Load(object sender, EventArgs e)
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
        private void dgvCourses_CellClick(object sender, EventArgs e)
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
                for (int i = 0; i < dgvCourses.Rows.Count; i++)
                {
                    temp = dgvCourses.Rows[i];
                    if (((string)temp.Cells["courseNumber"].Value).Contains(txtCourseNumber.Text) &&
                        ((string)temp.Cells["courseName"].Value).Contains(txtCourseName.Text) &&
                        ((string)temp.Cells["courseMessage"].Value).Contains(txtCourseMessage.Text))
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
                DBHelper.AddCourse(CreateACourse());
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
                DBHelper.UpdateCourse(CreateACourse());
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
                DBHelper.DeleteCourse(txtCourseNumber.Text);
                Refreshdgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 制造一个课程对象
        /// </summary>
        /// <returns></returns>
        private Course CreateACourse()
        {
            Course course = new Course(txtCourseNumber.Text);
            course.Name = txtCourseName.Text;
            course.Message = txtCourseMessage.Text;
            return course;
        }
        /// <summary>
        /// 刷新DataGridView控件
        /// </summary>
        private void Refreshdgv()
        {
            this.dgvCourses.DataSource = DBHelper.GetCourseDataSet("").Tables[0];

            //this.dgvHall.DataSource = HallManagingHelper.HallDataSet.Tables["Hall"];
            //this.dgvHall.DataSource = DBHelper.GetHallList(" HallNumber like '" + txtHallNumber.Text + "%' and " + "HallName like '" + txtHallName.Text + "%' ").Tables[0];
        }

        /// <summary>
        /// 刷新TextBox控件
        /// </summary>
        private void Refreshtxt()
        {
            this.txtCourseNumber.Text = (string)dgvCourses.SelectedRows[0].Cells["courseNumber"].Value;
            this.txtCourseName.Text = (string)dgvCourses.SelectedRows[0].Cells["courseName"].Value;
            this.txtCourseMessage.Text = (string)dgvCourses.SelectedRows[0].Cells["courseMessage"].Value;
        }
    }
}
