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
    public partial class RecentCourseMenu : Form
    {
        public event EventHandler GetValue;
        public RecentCourseMenu()
        {
            InitializeComponent();
            this.Load +=new EventHandler(RecentCourseMenu_Load);
            this.btnChoose.Click += new EventHandler(btnChoose_Click);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecentCourseMenu_Load(object sender, EventArgs e)
        {
            Refreshdgv();
        }

        /// <summary>
        /// 选择按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (GetValue != null)
            {
                GetValue(CreateACourse(), e);
                this.Close();
            }
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
        /// 制造一个课程对象
        /// </summary>
        /// <returns></returns>
        private Course CreateACourse()
        {
            Course course = new Course((string)dgvCourses.SelectedRows[0].Cells["courseNumber"].Value);
            course.Name = (string)dgvCourses.SelectedRows[0].Cells["courseName"].Value;
            course.Message = (string)dgvCourses.SelectedRows[0].Cells["courseMessage"].Value;
            return course;
        }
    }
}
