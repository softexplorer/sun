using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

using BusinessLogicLayer;
using DataAccessLayer;

namespace UserInterfaceLayer
{
    public partial class MainMenu : Form
    {
        private Socket serverSocket;   //服务端socket
        private Stack<Thread> threadStack; //所有线程栈
        private static string pattern = @"^(\d+),(\w+),([\w:]*)$";   //正则表达式规范
        private static bool startServe;   //是否开启服务
        private Course recentCourse; //当前课程

        /// <summary>
        /// 主界面构造函数
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            threadStack = new Stack<Thread>();
            startServe = false;
            ThreadPool.SetMaxThreads(10, 10);
            recentCourse = DBHelper.GetCourseList()[0];
            this.Shown += new System.EventHandler(this.MainLayer_Shown);
            this.btnStartServe.Click += new System.EventHandler(this.btnStartServe_Click);
            this.btnImportList.Click += new EventHandler(btnImportList_Click);
            this.学生编辑ToolStripMenuItem.Click += new System.EventHandler(this.学生编辑ToolStripMenuItem_Click);
            this.课程编辑ToolStripMenuItem.Click += new System.EventHandler(this.课程编辑ToolStripMenuItem_Click);
            this.当前课程ToolStripMenuItem.Click += new System.EventHandler(this.当前课程ToolStripMenuItem_Click);
            this.签到记录ToolStripMenuItem.Click += new System.EventHandler(this.签到记录ToolStripMenuItem_Click);
        }

        /// <summary>
        /// 界面显示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainLayer_Shown(object sender, EventArgs e)
        {
            this.lvwMessage.Columns.Add("学号", 120, HorizontalAlignment.Left);
            this.lvwMessage.Columns.Add("姓名", 120, HorizontalAlignment.Left);
            this.lvwMessage.Columns.Add("附加信息", 120, HorizontalAlignment.Left);
        }

        /// <summary>
        /// 开启服务按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartServe_Click(object sender, EventArgs e)
        {
            try
            {
                if (startServe == false)
                {
                    IPAddress ip = IPAddress.Parse(txtIP.Text);//服务器IP
                    serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    serverSocket.Bind(new IPEndPoint(ip, int.Parse(txtPort.Text)));//绑定IP地址和端口
                    serverSocket.Listen(10);//设定最多10个排队连接请求
                    txtStatement.Text += "启动监听成功\r\n当前是" + recentCourse.Number + "  " +
                         recentCourse.Name + "  " + recentCourse.Message + "\r\n";
                    btnStartServe.Text = "关闭服务";
                    startServe = true;
                    Thread thread = new Thread(ListenClientConnect);
                    thread.IsBackground = true;
                    threadStack.Push(thread);
                    thread.Start();
                }
                else
                {
                    Thread thread = null;
                    for (int i = 0; i < threadStack.Count; i++)
                    {
                        thread = threadStack.Pop();
                        thread.Abort();
                    }
                    serverSocket.Close();
                    serverSocket = null;
                    txtStatement.Text += "监听关闭\r\n";
                    btnStartServe.Text = "开启服务";
                    startServe = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 导入名单按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportList_Click(object sender, EventArgs e)
        {
            List<Student> studentlist = DBHelper.GetStudentList();  //从数据库中读出的所有学生列表
            for (int i = 0; i < studentlist.Count; i++)
            {
                string number = studentlist[i].Number;
                string name = studentlist[i].Name;
                string extra = studentlist[i].Extra;
                //往ListView控件中添加学生信息
                this.lvwMessage.BeginUpdate();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = number;
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(extra);
                this.lvwMessage.Items.Add(lvi);
                this.lvwMessage.EndUpdate();
            }
        }


        /// <summary>
        /// 监听客户端连接
        /// </summary>
        private void ListenClientConnect()
        {
            for (int i = 0; startServe && i < 20; i++)
            {
                if (serverSocket != null)
                {
                    serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), serverSocket);
                    Thread.Sleep(10000);
                }
            }
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            if (serverSocket != null)
            {
                Socket listener = ar.AsyncState as Socket;
                Socket clientSocket = listener.EndAccept(ar);
                Thread sendThread = new Thread(SendMessage);
                sendThread.IsBackground = true;
                threadStack.Push(sendThread);
                sendThread.Start(clientSocket);
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.IsBackground = true;
                threadStack.Push(receiveThread);
                receiveThread.Start(clientSocket);
            }
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="clientSocket"></param>
        private void SendMessage(object clientSocket)
        {
            byte[] result = null;
            Socket myClientSocket = (Socket)clientSocket;
            while (startServe)
            {
                //根据选项发送不同信息
                //获取信息
                string send = recentCourse.Name + "  " + txtInfo.Text + "\r\n";
                int sendBufferSize = Encoding.UTF8.GetByteCount(send);
                result = new byte[sendBufferSize];
                result = Encoding.UTF8.GetBytes(send);
                myClientSocket.Send(result, result.Length, 0);
                Thread.Sleep(1000);
                break;
                //case 1:
                //    {
                //        int sendBufferSize = Encoding.Unicode.GetByteCount("fail,not in list" + "\r\n");
                //        result = new byte[sendBufferSize];
                //        result = Encoding.Unicode.GetBytes(txtInfo.Text + "\r\n");
                //        myClientSocket.Send(result, result.Length, 0);
                //        break;
                //    }
                //case 2:
                //    {
                //        int sendBufferSize = Encoding.Unicode.GetByteCount("fail,don't match MAC" + "\r\n");
                //        result = new byte[sendBufferSize];
                //        result = Encoding.Unicode.GetBytes(txtInfo.Text + "\r\n");
                //        myClientSocket.Send(result, result.Length, 0);
                //        break;
                //    }

            }
        }

        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="clientSocket"></param>
        private void ReceiveMessage(object clientSocket)
        {
            byte[] result = new byte[1024];
            String message = null;
            Socket myClientSocket = (Socket)clientSocket;
            while (startServe)
            {
                try
                {
                    int resultNumber = myClientSocket.Receive(result, result.Length, 0);
                    message = Encoding.ASCII.GetString(result, 0, resultNumber);
                    if (message != "")
                    {
                        //MessageBox.Show(message);
                        if (SetListCheck(message))
                        {
                        }
                        else
                        {
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// 设置listview控件的内容
        /// </summary>
        /// <param name="message"></param>
        /// <returns>返回是否存在符合条件的条目</returns>
        public delegate bool SetListHandler(string message);
        private bool SetListCheck(string message)
        {
            bool depend = false;  //用于返回值，判断是否存在符合条件的条目
            if (this.InvokeRequired == true)
            {
                this.BeginInvoke(new SetListHandler(this.SetListCheck), new object[] { message });
            }
            else
            {
                this.lvwMessage.BeginUpdate();
                Regex rx = new Regex(pattern);
                Match m = rx.Match(message);
                if (depend = m.Success)
                {
                    string number = m.Result("$1");
                    string name = m.Result("$2");
                    string extra = m.Result("$3");
                    //MessageBox.Show(message);
                    int index = FindItemInListView(number, name, extra);
                    if (index >= 0 && this.lvwMessage.Items[index].ForeColor != Color.Green &&
                       this.lvwMessage.Items[index].BackColor != Color.Gold)
                    {
                        this.lvwMessage.Items[index].ForeColor = Color.Green;
                        this.lvwMessage.Items[index].BackColor = Color.Gold;
                        this.txtStatement.Text += number + "号" + name + "签到" + "    " + extra + "\r\n";
                        DBHelper.AddRecord(number, recentCourse.Number, DateTime.Now);
                    }
                }
                this.lvwMessage.EndUpdate();
            }
            return depend;
        }

        /// <summary>
        /// 从ListView控件中搜索特定条目
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private int FindItemInListView(string number, string name, string extra)
        {
            int index = -1;  //用于指向符合条件的条目
            for (int i = 0; i < lvwMessage.Items.Count; i++)
            {
                if (lvwMessage.Items[i].Text == number && lvwMessage.Items[i].SubItems[1].Text == name &&
                lvwMessage.Items[i].SubItems[2].Text == extra)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private void 学生编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentEditMenu studentEditMenu = new StudentEditMenu();
            studentEditMenu.ShowDialog();
        }

        private void 课程编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseEditMenu courseEditMenu = new CourseEditMenu();
            courseEditMenu.ShowDialog();
        }

        private void 当前课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecentCourseMenu recentCourseMenu = new RecentCourseMenu();
            recentCourseMenu.GetValue += new EventHandler(SendValue);
            recentCourseMenu.ShowDialog();

        }

        /// <summary>
        /// 操作recentCourseMenu传来的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendValue(object sender, EventArgs e)
        {
            recentCourse = sender as Course;
        }

        private void 签到记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterRecordMenu registerRecordMenu = new RegisterRecordMenu();
            registerRecordMenu.ShowDialog();
        }

    }
}
