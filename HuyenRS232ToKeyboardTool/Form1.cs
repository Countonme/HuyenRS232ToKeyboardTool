using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuyenRS232ToKeyboardTool.Model;
using Newtonsoft.Json;
using SNetLogs;
using Sunny.UI;
using Timer = System.Windows.Forms.Timer;

namespace HuyenRS232ToKeyboardTool
{
    public partial class Form1 : UIForm
    {
        private bool _findingWindow = false;
        private Timer _finderTimer = new Timer();
        private WindowInfo _currentWindow;

        // private SerialPort serialPort1, serialPort2, serialPort3, serialPort4, serialPort5, serialPort6, serialPort7, serialPort8;
        private SerialPort[] _serialPortsList = null;
        private SettingConfig _config = new SettingConfig();
        [DllImport("user32.dll", CharSet = CharSet.Unicode)] private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const uint WM_CHAR = 0x0102;

        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;
        private const int VK_RETURN = 0x0D;


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
            btnStart.Click += BtnStart_Click;
            btnSave.Click += BtnSave_Click;
            btnOpen.Click += BtnOpen_Click;
            btnSendMsgTest.Click += BtnSendMsgTest_Click;
        }
        /// <summary>
        /// 发送消息测试按钮点击事件，目前未实现具体功能，后续根据需求添加对应逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnSendMsgTest_Click(object sender, EventArgs e)
        {
            SendBarcode(txtwindownTitle.Text, "Testting..." + Guid.NewGuid().ToString("N"));
        }


        public void SendBarcode(string windowTitle, string barcode)
        {
            IntPtr hwnd = FindWindow(null, windowTitle);

            if (hwnd == IntPtr.Zero)
            {
                ShowLogs($"找不到窗口:{windowTitle}", Color.Red);
                return;
            }

            ShowWindow(hwnd, SW_RESTORE);

            SetForegroundWindow(hwnd);

            Thread.Sleep(100);

            // 模式1：SendKeys
            if (radioSendKeys.Checked)
            {
                SendKeys.SendWait(barcode);

                if (checkBoxCarriageReturn.Checked)
                    SendKeys.SendWait("{ENTER}");

                return;
            }

            // 模式2：Clipboard + Ctrl+V
            if (radioClipboard.Checked)
            {
                Clipboard.SetText(barcode);

                SendKeys.SendWait("^v");

                if (checkBoxCarriageReturn.Checked)
                    SendKeys.SendWait("{ENTER}");

                return;
            }

            // 模式3：PostMessage
            if (radioPostMessage.Checked)
            {
                SendTextByPostMessage(hwnd, barcode);

                SendCRLF(hwnd);

                return;
            }
        }

        /// <summary>
        /// 根据用户选择的回车换行设置，发送对应的消息到目标窗口
        /// </summary>
        /// <param name="hwnd"></param>
        private void SendCRLF(IntPtr hwnd)
        {
            if (checkBoxCarriageReturn.Checked)
            {
                PostMessage(hwnd, WM_KEYDOWN, (IntPtr)VK_RETURN, IntPtr.Zero);
                PostMessage(hwnd, WM_KEYUP, (IntPtr)VK_RETURN, IntPtr.Zero);
            }

            if (checkBoxLineFeed.Checked)
            {
                PostMessage(hwnd, WM_CHAR, (IntPtr)10, IntPtr.Zero);
            }
        }
        /// <summary>
        /// 打开功能按钮点击事件，目前未实现具体功能，后续根据需求添加对应逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            string baseDir = Path.Combine(Application.StartupPath, "proList");

            if (!Directory.Exists(baseDir))
                Directory.CreateDirectory(baseDir);

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = baseDir;
                dlg.Filter = "Config File (*.json)|*.json";
                dlg.Title = "请选择配置文件";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        proName.Text = dlg.FileName;
                        // ✔ 刷新系统
                        LoadConfig();

                        this.ShowSuccessTip("加载成功");
                    }
                    catch (Exception ex)
                    {
                        this.ShowErrorDialog($"加载失败: {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// 保存功能按钮点击事件，目前未实现具体功能，后续根据需求添加对应逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            var conf = new SettingConfig
            {

                channel1ComName = cobChannel1.Text,
                channel2ComName = cobChannel2.Text,
                channel3ComName = cobChannel3.Text,
                channel4ComName = cobChannel4.Text,
                channel5ComName = cobChannel5.Text,
                channel6ComName = cobChannel6.Text,
                channel7ComName = cobChannel7.Text,
                channel8ComName = cobChannel8.Text,
                channel9ComName = cobChannel9.Text,
                channel10ComName = cobChannel10.Text,
                channel11ComName = cobChannel11.Text,
                channel12ComName = cobChannel12.Text,
                channel1Status = checkBoxChannel1.Checked,
                channel2Status = checkBoxChannel2.Checked,
                channel3Status = checkBoxChannel3.Checked,
                channel4Status = checkBoxChannel4.Checked,
                channel5Status = checkBoxChannel5.Checked,
                channel6Status = checkBoxChannel6.Checked,
                channel7Status = checkBoxChannel7.Checked,
                channel8Status = checkBoxChannel8.Checked,
                channel9Status = checkBoxChannel9.Checked,
                channel10Status = checkBoxChannel10.Checked,
                channel11Status = checkBoxChannel11.Checked,
                channel12Status = checkBoxChannel12.Checked,
                readTimeout = readTimeout.Value,
                LineFeedFlag = checkBoxLineFeed.Checked,
                CarriageReturnFlag = checkBoxCarriageReturn.Checked,
                windownTitle = txtwindownTitle.Text,
                sendMode = radioSendKeys.Checked ? "SendKeys" : (radioClipboard.Checked ? "Clipboard" : "PostMessage")

            };

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(conf, Newtonsoft.Json.Formatting.Indented);

            // ✔ 默认目录：程序根目录/proList
            string baseDir = Path.Combine(Application.StartupPath, "proList");

            if (!Directory.Exists(baseDir))
                Directory.CreateDirectory(baseDir);

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.InitialDirectory = baseDir;
                dlg.Filter = "Config File (*.json)|*.json";
                dlg.Title = "请选择保存配置文件位置";

                // 默认文件名
                dlg.FileName = "pro.json";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, json);

                    //  reloadToolStripMenuItem.PerformClick();
                    ShowLogs("配置保存成功", Color.Green);
                    this.ShowSuccessTip("保存成功");
                }
            }
        }
        /// <summary>
        /// 开始功能按钮点击事件，目前未实现具体功能，后续根据需求添加对应逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Active)
            {
                // Start functionality
                ShowLogs("开始功能", Color.Blue);
            }
            else
            {

                ShowLogs("功能尚未实现", Color.Red);
            }
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
                    ShowLogs("未找到窗口", Color.Red);
                    return;
                }
                txtwindownTitle.Text = _currentWindow.Title;
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

        /// <summary>
        /// 加载配方
        /// </summary>
        private void LoadConfig()
        {
            if (File.Exists(proName.Text))
            {
                //关闭串口，避免占用无法读取配置
                btnStart.Active = false;
                CloseAllPorts();

                var configString = File.ReadAllText(proName.Text);
                _config = JsonConvert.DeserializeObject<SettingConfig>(configString) ?? new SettingConfig();
                cobChannel1.Text = _config.channel1ComName;
                cobChannel2.Text = _config.channel2ComName;
                cobChannel3.Text = _config.channel3ComName;
                cobChannel4.Text = _config.channel4ComName;
                cobChannel5.Text = _config.channel5ComName;
                cobChannel6.Text = _config.channel6ComName;
                cobChannel7.Text = _config.channel7ComName;
                cobChannel8.Text = _config.channel8ComName;
                cobChannel9.Text = _config.channel9ComName;
                cobChannel10.Text = _config.channel10ComName;
                cobChannel11.Text = _config.channel11ComName;
                cobChannel12.Text = _config.channel12ComName;



                checkBoxChannel1.Checked = _config.channel1Status;
                checkBoxChannel2.Checked = _config.channel2Status;
                checkBoxChannel3.Checked = _config.channel3Status;
                checkBoxChannel4.Checked = _config.channel4Status;
                checkBoxChannel5.Checked = _config.channel5Status;
                checkBoxChannel6.Checked = _config.channel6Status;
                checkBoxChannel7.Checked = _config.channel7Status;
                checkBoxChannel8.Checked = _config.channel8Status;
                checkBoxChannel9.Checked = _config.channel9Status;
                checkBoxChannel10.Checked = _config.channel10Status;
                checkBoxChannel11.Checked = _config.channel11Status;
                checkBoxChannel12.Checked = _config.channel12Status;

                readTimeout.Value = _config.readTimeout;
                txtwindownTitle.Text = _config.windownTitle;
                checkBoxCarriageReturn.Checked = _config.CarriageReturnFlag;
                checkBoxLineFeed.Checked = _config.LineFeedFlag;
                switch (_config.sendMode)
                {
                    case "SendKeys":
                        radioSendKeys.Checked = true;
                        break;
                    case "Clipboard":
                        radioClipboard.Checked = true;
                        break;
                    case "PostMessage":
                        radioPostMessage.Checked = true;
                        break;
                    default: radioPostMessage.Checked = true;
                        break;
                }
                ShowLogs("配置加载成功", Color.Green);
                this.ShowSuccessNotifier("配置已加载...");
            }
            else
            {
                ShowLogs($"配置文件 {proName.Text} 不存在，请先保存配置", Color.Red);
                this.ShowErrorDialog($"配置文件 {proName.Text} 不存在，请先保存配置");
            }
        }

        /// <summary>
        /// OpenAllPorts 和 CloseAllPorts 方法用于批量打开和关闭串口，确保在加载新配置前先关闭所有串口，避免资源占用问题。
        /// </summary>
        private void CloseAllPorts()
        {
            _serialPortsList.ToList().ForEach(port =>
            {
                TryClose(port);
            });
        }

        /// <summary>
        /// OpenAllPorts 方法用于根据当前配置批量打开串口，确保在加载新配置后能够正确打开所需的串口。
        /// </summary>
        private void OpenAllPorts()
        {
            _serialPortsList.ToList().ForEach(port =>
            {
                TryOpen(port);
            });

        }

        private void TryClose(SerialPort port)
        {
            if (port == null) return;

            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
            }
            catch (Exception ex)
            {
                ShowLogs($"{port.PortName} 关闭失败: {ex.Message}", Color.Red);
                this.ShowErrorNotifier($"{port.PortName} 关闭失败: {ex.Message}");
            }
        }

        private void TryOpen(SerialPort port)
        {
            if (port == null) return;

            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
            }
            catch (Exception ex)
            {
                ShowLogs($"{port.PortName} 打开失败: {ex.Message}", Color.Red);
                this.ShowErrorNotifier($"{port.PortName} 打开失败: {ex.Message}");
            }
        }

        private void SendTextByPostMessage(IntPtr hwnd, string text)
        {
            foreach (char c in text)
            {
                PostMessage(
                    hwnd,
                    WM_CHAR,
                    (IntPtr)c,
                    IntPtr.Zero);
            }
        }
    }
}
