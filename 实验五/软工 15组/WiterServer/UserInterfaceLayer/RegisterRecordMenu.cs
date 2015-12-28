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
    public partial class RegisterRecordMenu : Form
    {
        public RegisterRecordMenu()
        {
            InitializeComponent();
            this.Load +=new EventHandler(RegisterRecordMenu_Load);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterRecordMenu_Load(object sender, EventArgs e)
        {
            this.dgvRecord.DataSource = DBHelper.GetRecordDataSet("").Tables[0];
        }
    }
}
