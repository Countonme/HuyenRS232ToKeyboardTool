using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SNetLogs;
using Sunny.UI;

namespace HuyenRS232ToKeyboardTool
{
    public partial class Form1 : UIForm
    {
        private bool _findingWindow = false;
        private Timer _finderTimer = new Timer();
        private WindowInfo _currentWindow;

        // private SerialPort serialPort1, serialPort2, serialPort3, serialPort4, serialPort5, serialPort6, serialPort7, serialPort8;
        private SerialPort[] _serialPortsList = null;

        public Form1()
        {
            InitializeComponent();
            this.Text += $"  Version={Application.ProductVersion}";
            this.Load += Form1_Load;
            this.btnRefresh.Click += BtnRefresh_Click;
            btnFindWindow.MouseDown += BtnFindWindow_MouseDown;
            /// 定时器设置为50ms，持续获取鼠标下的窗口信息
            _finderTimer.Interval = 50;
            _finderTimer.Tick += FinderTimer_Tick;
            /// 订阅鼠标左键抬起事件
            MouseHook.MouseLeftButtonUp += MouseHook_MouseLeftButtonUp;

        }

        /// <summary>
        /// 鼠标左键按下事件，开始寻找窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFindWindow_MouseDown(object sender, MouseEventArgs e)
        {
            _findingWindow = true;

            Cursor = Cursors.Cross;

            _finderTimer.Start();

            MouseHook.Start();

            ShowLogs("拖到目标窗口后松开鼠标", Color.Blue);
        }

        /// <summary>
        /// 定时器事件，持续获取鼠标下的窗口信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinderTimer_Tick(object sender, EventArgs e)
        {
            if (!_findingWindow) return;

            _currentWindow = WindowHelper.GetWindowUnderMouse();
        }

        /// <summary>
        /// 鼠标左键抬起事件，锁定窗口
        /// </summary>
        private void MouseHook_MouseLeftButtonUp()
        {
            if (!_findingWindow) return;

            _findingWindow = false;

            _finderTimer.Stop();

            MouseHook.Stop();

            BeginInvoke(new Action(() =>
            {
                Cursor = Cursors.Default;

                if (_currentWindow == null)
                {
                    ShowLogs(
                        "未找到窗口",
                        Color.Red);
                    return;
                }

                ShowLogs("==========窗口锁定==========", Color.Red);

                ShowLogs($"标题:{_currentWindow.Title}", Color.Green);

                ShowLogs($"类名:{_currentWindow.ClassName}", Color.Green);

                ShowLogs($"进程:{_currentWindow.ProcessName}", Color.Green);

                ShowLogs($"PID:{_currentWindow.PID}", Color.Green);

                ShowLogs($"HWND:0x{_currentWindow.Hwnd.ToInt64():X}", Color.Red);
            }));
        }
        /// <summary>
        /// 窗体关闭事件，停止鼠标钩子
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MouseHook.Stop();

            base.OnFormClosing(e);
        }
        /// <summary>
        /// 刷新串口列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            reloadComList();
        }
        /// <summary>
        /// 窗体加载事件，初始化串口列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPortsList = new SerialPort[11];
        }        /// <summary>
                 /// 重新加载串口
                 /// </summary>
        private void reloadComList()
        {
            var com = SerialPort.GetPortNames();
            cobChannel1.Items.Clear();
            cobChannel2.Items.Clear();
            cobChannel3.Items.Clear();
            cobChannel4.Items.Clear();
            cobChannel5.Items.Clear();
            cobChannel6.Items.Clear();
            cobChannel7.Items.Clear();
            cobChannel8.Items.Clear();
            cobChannel9.Items.Clear();
            cobChannel10.Items.Clear();
            cobChannel11.Items.Clear();
            cobChannel12.Items.Clear();
            foreach (var comName in com)
            {
                cobChannel1.Items.Add(comName);
                cobChannel2.Items.Add(comName);
                cobChannel3.Items.Add(comName);
                cobChannel4.Items.Add(comName);
                cobChannel5.Items.Add(comName);
                cobChannel6.Items.Add(comName);
                cobChannel7.Items.Add(comName);
                cobChannel8.Items.Add(comName);
                cobChannel9.Items.Add(comName);
                cobChannel10.Items.Add(comName);
                cobChannel11.Items.Add(comName);
                cobChannel12.Items.Add(comName);
            }
            ShowLogs($"COM 列表已刷新 共找到{com.Length}个串口", Color.Blue);
        }
        /// <summary>
        /// 显示日志到UI和日志文件
        /// </summary>
        /// <param name="infoLogs"></param>
        /// <param name="color"></param>
        private void ShowLogs(string infoLogs, Color color)
        {
            try
            {
                string msg = $"{DateTime.Now:HH:mm:ss.fff} - {infoLogs}";

                // UI线程安全
                if (uiRichTextBox1.InvokeRequired)
                {
                    uiRichTextBox1.BeginInvoke(new Action(() =>
                    {
                        AppendLogToUi(msg, color);
                    }));
                }
                else
                {
                    AppendLogToUi(msg, color);
                }

                // 写日志文件
                Log.Info(msg);
            }
            catch
            {
                // 日志系统不要抛异常
            }
        }
        /// <summary>
        /// 将日志追加到UI RichTextBox，并设置颜色
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="color"></param>
        private void AppendLogToUi(string msg, Color color)
        {
            try
            {
                // 控制最大长度
                if (uiRichTextBox1.TextLength > 1024 * 500)
                {
                    uiRichTextBox1.Clear();
                }

                uiRichTextBox1.SuspendLayout();

                int start = uiRichTextBox1.TextLength;

                uiRichTextBox1.AppendText(msg);

                uiRichTextBox1.Select(start, msg.Length);

                uiRichTextBox1.SelectionColor = color;
                uiRichTextBox1.SelectionBackColor = uiRichTextBox1.BackColor;

                uiRichTextBox1.AppendText(Environment.NewLine);

                uiRichTextBox1.SelectionLength = 0;
                uiRichTextBox1.ScrollToCaret();

                uiRichTextBox1.ResumeLayout();
            }
            catch
            {
            }
        }

    }
}
