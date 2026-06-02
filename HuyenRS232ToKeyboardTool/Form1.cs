using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SNetLogs;
using Sunny.UI;

namespace HuyenRS232ToKeyboardTool
{
    public partial class Form1 : UIForm
    {
       // private SerialPort serialPort1, serialPort2, serialPort3, serialPort4, serialPort5, serialPort6, serialPort7, serialPort8;
        private SerialPort[] _serialPortsList = null;
        public Form1()
        {
            InitializeComponent();
            this.Text += $"  Version={Application.ProductVersion}";
            this.Load += Form1_Load;
            this.btnRefresh.Click += BtnRefresh_Click;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            reloadComList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPortsList =new SerialPort[11];
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
