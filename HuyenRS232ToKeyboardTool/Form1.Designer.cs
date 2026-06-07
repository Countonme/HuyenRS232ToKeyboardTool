namespace HuyenRS232ToKeyboardTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSendMsgTest = new Sunny.UI.UISymbolButton();
            this.btnStart = new Sunny.UI.UITurnSwitch();
            this.txtwindownTitle = new Sunny.UI.UITextBox();
            this.uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            this.readTimeout = new Sunny.UI.UIIntegerUpDown();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.proName = new Sunny.UI.UILine();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.checkBoxCarriageReturn = new Sunny.UI.UICheckBox();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.checkBoxLineFeed = new Sunny.UI.UICheckBox();
            this.btnRefresh = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.btnOpen = new Sunny.UI.UISymbolButton();
            this.btnFindWindow = new Sunny.UI.UISymbolButton();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.cobChannel12 = new System.Windows.Forms.ComboBox();
            this.cobChannel11 = new System.Windows.Forms.ComboBox();
            this.cobChannel10 = new System.Windows.Forms.ComboBox();
            this.cobChannel9 = new System.Windows.Forms.ComboBox();
            this.cobChannel8 = new System.Windows.Forms.ComboBox();
            this.cobChannel7 = new System.Windows.Forms.ComboBox();
            this.checkBoxChannel12 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel11 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel10 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel9 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel8 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel7 = new Sunny.UI.UICheckBox();
            this.cobChannel6 = new System.Windows.Forms.ComboBox();
            this.cobChannel5 = new System.Windows.Forms.ComboBox();
            this.cobChannel4 = new System.Windows.Forms.ComboBox();
            this.cobChannel3 = new System.Windows.Forms.ComboBox();
            this.cobChannel2 = new System.Windows.Forms.ComboBox();
            this.cobChannel1 = new System.Windows.Forms.ComboBox();
            this.checkBoxChannel6 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel5 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel4 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel3 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel2 = new Sunny.UI.UICheckBox();
            this.checkBoxChannel1 = new Sunny.UI.UICheckBox();
            this.uiGroupBox1.SuspendLayout();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiRichTextBox1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 494);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(723, 156);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "🌼 Logs ()";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiRichTextBox1.Location = new System.Drawing.Point(0, 32);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.ShowText = false;
            this.uiRichTextBox1.Size = new System.Drawing.Size(723, 124);
            this.uiRichTextBox1.TabIndex = 1;
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 35);
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(723, 459);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(522, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSendMsgTest);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.txtwindownTitle);
            this.tabPage2.Controls.Add(this.uiTitlePanel2);
            this.tabPage2.Controls.Add(this.uiSymbolButton1);
            this.tabPage2.Controls.Add(this.proName);
            this.tabPage2.Controls.Add(this.uiGroupBox2);
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnOpen);
            this.tabPage2.Controls.Add(this.btnFindWindow);
            this.tabPage2.Controls.Add(this.uiGroupBox4);
            this.tabPage2.Location = new System.Drawing.Point(201, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(522, 459);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSendMsgTest
            // 
            this.btnSendMsgTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMsgTest.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSendMsgTest.ForePressColor = System.Drawing.Color.Red;
            this.btnSendMsgTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMsgTest.LightColor = System.Drawing.Color.Blue;
            this.btnSendMsgTest.Location = new System.Drawing.Point(423, 8);
            this.btnSendMsgTest.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSendMsgTest.Name = "btnSendMsgTest";
            this.btnSendMsgTest.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnSendMsgTest.Size = new System.Drawing.Size(94, 35);
            this.btnSendMsgTest.Style = Sunny.UI.UIStyle.Custom;
            this.btnSendMsgTest.StyleCustomMode = true;
            this.btnSendMsgTest.Symbol = 358707;
            this.btnSendMsgTest.TabIndex = 122;
            this.btnSendMsgTest.Text = "信息发送";
            this.btnSendMsgTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMsgTest.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnStart
            // 
            this.btnStart.ActiveAngle = 0;
            this.btnStart.BackInnerSize = 40;
            this.btnStart.BackSize = 60;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.Font = new System.Drawing.Font("宋体", 12F);
            this.btnStart.HandleColor = System.Drawing.Color.Yellow;
            this.btnStart.InActiveAngle = 90;
            this.btnStart.InActiveColor = System.Drawing.Color.Blue;
            this.btnStart.Location = new System.Drawing.Point(6, 7);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 131);
            this.btnStart.TabIndex = 121;
            this.btnStart.Text = "uiTurnSwitch2";
            // 
            // txtwindownTitle
            // 
            this.txtwindownTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtwindownTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtwindownTitle.Location = new System.Drawing.Point(133, 94);
            this.txtwindownTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtwindownTitle.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtwindownTitle.Name = "txtwindownTitle";
            this.txtwindownTitle.Padding = new System.Windows.Forms.Padding(5);
            this.txtwindownTitle.ReadOnly = true;
            this.txtwindownTitle.ShowText = false;
            this.txtwindownTitle.Size = new System.Drawing.Size(384, 29);
            this.txtwindownTitle.TabIndex = 120;
            this.txtwindownTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtwindownTitle.Watermark = "";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.readTimeout);
            this.uiTitlePanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.Location = new System.Drawing.Point(356, 175);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(1, 35, 1, 1);
            this.uiTitlePanel2.ShowText = false;
            this.uiTitlePanel2.Size = new System.Drawing.Size(162, 78);
            this.uiTitlePanel2.TabIndex = 119;
            this.uiTitlePanel2.Text = "读取超时(S)";
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readTimeout
            // 
            this.readTimeout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.readTimeout.Font = new System.Drawing.Font("宋体", 12F);
            this.readTimeout.Location = new System.Drawing.Point(5, 44);
            this.readTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readTimeout.Maximum = 60D;
            this.readTimeout.MaxLength = 6;
            this.readTimeout.Minimum = 1D;
            this.readTimeout.MinimumSize = new System.Drawing.Size(100, 0);
            this.readTimeout.Name = "readTimeout";
            this.readTimeout.Padding = new System.Windows.Forms.Padding(5);
            this.readTimeout.ShowText = false;
            this.readTimeout.Size = new System.Drawing.Size(150, 29);
            this.readTimeout.TabIndex = 104;
            this.readTimeout.Text = "20";
            this.readTimeout.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.readTimeout.Value = 20;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 9F);
            this.uiSymbolButton1.ForePressColor = System.Drawing.Color.Red;
            this.uiSymbolButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton1.LightColor = System.Drawing.Color.Blue;
            this.uiSymbolButton1.Location = new System.Drawing.Point(323, 7);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.uiSymbolButton1.Size = new System.Drawing.Size(94, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.StyleCustomMode = true;
            this.uiSymbolButton1.Symbol = 61481;
            this.uiSymbolButton1.TabIndex = 117;
            this.uiSymbolButton1.Text = "手动扫码";
            this.uiSymbolButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // proName
            // 
            this.proName.BackColor = System.Drawing.Color.Transparent;
            this.proName.Font = new System.Drawing.Font("宋体", 8F);
            this.proName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.proName.Location = new System.Drawing.Point(0, 132);
            this.proName.MinimumSize = new System.Drawing.Size(16, 16);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(517, 20);
            this.proName.TabIndex = 116;
            this.proName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.checkBoxCarriageReturn);
            this.uiGroupBox2.Controls.Add(this.uiRadioButton1);
            this.uiGroupBox2.Controls.Add(this.checkBoxLineFeed);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiGroupBox2.Location = new System.Drawing.Point(356, 263);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(162, 191);
            this.uiGroupBox2.TabIndex = 115;
            this.uiGroupBox2.Text = "Send Mode  Setting";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxCarriageReturn
            // 
            this.checkBoxCarriageReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCarriageReturn.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxCarriageReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxCarriageReturn.Location = new System.Drawing.Point(3, 165);
            this.checkBoxCarriageReturn.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxCarriageReturn.Name = "checkBoxCarriageReturn";
            this.checkBoxCarriageReturn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxCarriageReturn.Size = new System.Drawing.Size(150, 20);
            this.checkBoxCarriageReturn.TabIndex = 58;
            this.checkBoxCarriageReturn.Text = "Carriage Return";
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButton1.Location = new System.Drawing.Point(3, 35);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Size = new System.Drawing.Size(150, 29);
            this.uiRadioButton1.TabIndex = 57;
            this.uiRadioButton1.Text = "SendKeys";
            // 
            // checkBoxLineFeed
            // 
            this.checkBoxLineFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLineFeed.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxLineFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxLineFeed.Location = new System.Drawing.Point(3, 141);
            this.checkBoxLineFeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxLineFeed.Name = "checkBoxLineFeed";
            this.checkBoxLineFeed.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxLineFeed.Size = new System.Drawing.Size(150, 20);
            this.checkBoxLineFeed.TabIndex = 56;
            this.checkBoxLineFeed.Text = "Line Feed";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(271, 8);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.btnRefresh.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnRefresh.Size = new System.Drawing.Size(46, 35);
            this.btnRefresh.Symbol = 361473;
            this.btnRefresh.TabIndex = 107;
            this.btnRefresh.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSave.Location = new System.Drawing.Point(225, 8);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnSave.Size = new System.Drawing.Size(46, 35);
            this.btnSave.Symbol = 61639;
            this.btnSave.TabIndex = 106;
            this.btnSave.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOpen.Location = new System.Drawing.Point(179, 8);
            this.btnOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnOpen.Size = new System.Drawing.Size(46, 35);
            this.btnOpen.Symbol = 261564;
            this.btnOpen.TabIndex = 105;
            this.btnOpen.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnFindWindow
            // 
            this.btnFindWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindWindow.Font = new System.Drawing.Font("宋体", 12F);
            this.btnFindWindow.Location = new System.Drawing.Point(133, 8);
            this.btnFindWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFindWindow.Name = "btnFindWindow";
            this.btnFindWindow.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.btnFindWindow.Size = new System.Drawing.Size(46, 35);
            this.btnFindWindow.Symbol = 361543;
            this.btnFindWindow.TabIndex = 104;
            this.btnFindWindow.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.cobChannel12);
            this.uiGroupBox4.Controls.Add(this.cobChannel11);
            this.uiGroupBox4.Controls.Add(this.cobChannel10);
            this.uiGroupBox4.Controls.Add(this.cobChannel9);
            this.uiGroupBox4.Controls.Add(this.cobChannel8);
            this.uiGroupBox4.Controls.Add(this.cobChannel7);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel12);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel11);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel10);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel9);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel8);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel7);
            this.uiGroupBox4.Controls.Add(this.cobChannel6);
            this.uiGroupBox4.Controls.Add(this.cobChannel5);
            this.uiGroupBox4.Controls.Add(this.cobChannel4);
            this.uiGroupBox4.Controls.Add(this.cobChannel3);
            this.uiGroupBox4.Controls.Add(this.cobChannel2);
            this.uiGroupBox4.Controls.Add(this.cobChannel1);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel6);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel5);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel4);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel3);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel2);
            this.uiGroupBox4.Controls.Add(this.checkBoxChannel1);
            this.uiGroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiGroupBox4.Location = new System.Drawing.Point(4, 159);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(344, 295);
            this.uiGroupBox4.TabIndex = 102;
            this.uiGroupBox4.Text = "Channels  Setting";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cobChannel12
            // 
            this.cobChannel12.FormattingEnabled = true;
            this.cobChannel12.Location = new System.Drawing.Point(230, 257);
            this.cobChannel12.Name = "cobChannel12";
            this.cobChannel12.Size = new System.Drawing.Size(106, 28);
            this.cobChannel12.TabIndex = 75;
            // 
            // cobChannel11
            // 
            this.cobChannel11.FormattingEnabled = true;
            this.cobChannel11.Location = new System.Drawing.Point(230, 214);
            this.cobChannel11.Name = "cobChannel11";
            this.cobChannel11.Size = new System.Drawing.Size(106, 28);
            this.cobChannel11.TabIndex = 74;
            // 
            // cobChannel10
            // 
            this.cobChannel10.FormattingEnabled = true;
            this.cobChannel10.Location = new System.Drawing.Point(230, 171);
            this.cobChannel10.Name = "cobChannel10";
            this.cobChannel10.Size = new System.Drawing.Size(106, 28);
            this.cobChannel10.TabIndex = 73;
            // 
            // cobChannel9
            // 
            this.cobChannel9.FormattingEnabled = true;
            this.cobChannel9.Location = new System.Drawing.Point(230, 128);
            this.cobChannel9.Name = "cobChannel9";
            this.cobChannel9.Size = new System.Drawing.Size(106, 28);
            this.cobChannel9.TabIndex = 72;
            // 
            // cobChannel8
            // 
            this.cobChannel8.FormattingEnabled = true;
            this.cobChannel8.Location = new System.Drawing.Point(230, 85);
            this.cobChannel8.Name = "cobChannel8";
            this.cobChannel8.Size = new System.Drawing.Size(106, 28);
            this.cobChannel8.TabIndex = 71;
            // 
            // cobChannel7
            // 
            this.cobChannel7.FormattingEnabled = true;
            this.cobChannel7.Location = new System.Drawing.Point(230, 42);
            this.cobChannel7.Name = "cobChannel7";
            this.cobChannel7.Size = new System.Drawing.Size(106, 28);
            this.cobChannel7.TabIndex = 70;
            // 
            // checkBoxChannel12
            // 
            this.checkBoxChannel12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel12.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel12.Location = new System.Drawing.Point(176, 254);
            this.checkBoxChannel12.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel12.Name = "checkBoxChannel12";
            this.checkBoxChannel12.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel12.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel12.TabIndex = 69;
            this.checkBoxChannel12.Text = "12";
            // 
            // checkBoxChannel11
            // 
            this.checkBoxChannel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel11.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel11.Location = new System.Drawing.Point(176, 211);
            this.checkBoxChannel11.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel11.Name = "checkBoxChannel11";
            this.checkBoxChannel11.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel11.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel11.TabIndex = 68;
            this.checkBoxChannel11.Text = "11";
            // 
            // checkBoxChannel10
            // 
            this.checkBoxChannel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel10.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel10.Location = new System.Drawing.Point(176, 168);
            this.checkBoxChannel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel10.Name = "checkBoxChannel10";
            this.checkBoxChannel10.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel10.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel10.TabIndex = 67;
            this.checkBoxChannel10.Text = "10";
            // 
            // checkBoxChannel9
            // 
            this.checkBoxChannel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel9.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel9.Location = new System.Drawing.Point(176, 125);
            this.checkBoxChannel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel9.Name = "checkBoxChannel9";
            this.checkBoxChannel9.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel9.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel9.TabIndex = 66;
            this.checkBoxChannel9.Text = "9";
            // 
            // checkBoxChannel8
            // 
            this.checkBoxChannel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel8.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel8.Location = new System.Drawing.Point(176, 82);
            this.checkBoxChannel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel8.Name = "checkBoxChannel8";
            this.checkBoxChannel8.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel8.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel8.TabIndex = 65;
            this.checkBoxChannel8.Text = "8";
            // 
            // checkBoxChannel7
            // 
            this.checkBoxChannel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel7.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel7.Location = new System.Drawing.Point(176, 39);
            this.checkBoxChannel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel7.Name = "checkBoxChannel7";
            this.checkBoxChannel7.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel7.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel7.TabIndex = 64;
            this.checkBoxChannel7.Text = "7";
            // 
            // cobChannel6
            // 
            this.cobChannel6.FormattingEnabled = true;
            this.cobChannel6.Location = new System.Drawing.Point(64, 257);
            this.cobChannel6.Name = "cobChannel6";
            this.cobChannel6.Size = new System.Drawing.Size(106, 28);
            this.cobChannel6.TabIndex = 63;
            // 
            // cobChannel5
            // 
            this.cobChannel5.FormattingEnabled = true;
            this.cobChannel5.Location = new System.Drawing.Point(64, 214);
            this.cobChannel5.Name = "cobChannel5";
            this.cobChannel5.Size = new System.Drawing.Size(106, 28);
            this.cobChannel5.TabIndex = 62;
            // 
            // cobChannel4
            // 
            this.cobChannel4.FormattingEnabled = true;
            this.cobChannel4.Location = new System.Drawing.Point(64, 171);
            this.cobChannel4.Name = "cobChannel4";
            this.cobChannel4.Size = new System.Drawing.Size(106, 28);
            this.cobChannel4.TabIndex = 61;
            // 
            // cobChannel3
            // 
            this.cobChannel3.FormattingEnabled = true;
            this.cobChannel3.Location = new System.Drawing.Point(64, 128);
            this.cobChannel3.Name = "cobChannel3";
            this.cobChannel3.Size = new System.Drawing.Size(106, 28);
            this.cobChannel3.TabIndex = 60;
            // 
            // cobChannel2
            // 
            this.cobChannel2.FormattingEnabled = true;
            this.cobChannel2.Location = new System.Drawing.Point(64, 85);
            this.cobChannel2.Name = "cobChannel2";
            this.cobChannel2.Size = new System.Drawing.Size(106, 28);
            this.cobChannel2.TabIndex = 59;
            // 
            // cobChannel1
            // 
            this.cobChannel1.FormattingEnabled = true;
            this.cobChannel1.Location = new System.Drawing.Point(64, 42);
            this.cobChannel1.Name = "cobChannel1";
            this.cobChannel1.Size = new System.Drawing.Size(106, 28);
            this.cobChannel1.TabIndex = 58;
            // 
            // checkBoxChannel6
            // 
            this.checkBoxChannel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel6.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel6.Location = new System.Drawing.Point(10, 254);
            this.checkBoxChannel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel6.Name = "checkBoxChannel6";
            this.checkBoxChannel6.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel6.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel6.TabIndex = 57;
            this.checkBoxChannel6.Text = "6";
            // 
            // checkBoxChannel5
            // 
            this.checkBoxChannel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel5.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel5.Location = new System.Drawing.Point(10, 211);
            this.checkBoxChannel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel5.Name = "checkBoxChannel5";
            this.checkBoxChannel5.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel5.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel5.TabIndex = 56;
            this.checkBoxChannel5.Text = "5 ";
            // 
            // checkBoxChannel4
            // 
            this.checkBoxChannel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel4.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel4.Location = new System.Drawing.Point(10, 168);
            this.checkBoxChannel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel4.Name = "checkBoxChannel4";
            this.checkBoxChannel4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel4.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel4.TabIndex = 55;
            this.checkBoxChannel4.Text = "4";
            // 
            // checkBoxChannel3
            // 
            this.checkBoxChannel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel3.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel3.Location = new System.Drawing.Point(10, 125);
            this.checkBoxChannel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel3.Name = "checkBoxChannel3";
            this.checkBoxChannel3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel3.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel3.TabIndex = 54;
            this.checkBoxChannel3.Text = "3";
            // 
            // checkBoxChannel2
            // 
            this.checkBoxChannel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel2.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel2.Location = new System.Drawing.Point(10, 82);
            this.checkBoxChannel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel2.Name = "checkBoxChannel2";
            this.checkBoxChannel2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel2.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel2.TabIndex = 53;
            this.checkBoxChannel2.Text = "2";
            // 
            // checkBoxChannel1
            // 
            this.checkBoxChannel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChannel1.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBoxChannel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBoxChannel1.Location = new System.Drawing.Point(10, 39);
            this.checkBoxChannel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxChannel1.Name = "checkBoxChannel1";
            this.checkBoxChannel1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxChannel1.Size = new System.Drawing.Size(46, 35);
            this.checkBoxChannel1.TabIndex = 52;
            this.checkBoxChannel1.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(723, 650);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Controls.Add(this.uiGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Huyèn RS232 To Keyboard Tool";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private System.Windows.Forms.ComboBox cobChannel12;
        private System.Windows.Forms.ComboBox cobChannel11;
        private System.Windows.Forms.ComboBox cobChannel10;
        private System.Windows.Forms.ComboBox cobChannel9;
        private System.Windows.Forms.ComboBox cobChannel8;
        private System.Windows.Forms.ComboBox cobChannel7;
        private Sunny.UI.UICheckBox checkBoxChannel12;
        private Sunny.UI.UICheckBox checkBoxChannel11;
        private Sunny.UI.UICheckBox checkBoxChannel10;
        private Sunny.UI.UICheckBox checkBoxChannel9;
        private Sunny.UI.UICheckBox checkBoxChannel8;
        private Sunny.UI.UICheckBox checkBoxChannel7;
        private System.Windows.Forms.ComboBox cobChannel6;
        private System.Windows.Forms.ComboBox cobChannel5;
        private System.Windows.Forms.ComboBox cobChannel4;
        private System.Windows.Forms.ComboBox cobChannel3;
        private System.Windows.Forms.ComboBox cobChannel2;
        private System.Windows.Forms.ComboBox cobChannel1;
        private Sunny.UI.UICheckBox checkBoxChannel6;
        private Sunny.UI.UICheckBox checkBoxChannel5;
        private Sunny.UI.UICheckBox checkBoxChannel4;
        private Sunny.UI.UICheckBox checkBoxChannel3;
        private Sunny.UI.UICheckBox checkBoxChannel2;
        private Sunny.UI.UICheckBox checkBoxChannel1;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UISymbolButton btnOpen;
        private Sunny.UI.UISymbolButton btnFindWindow;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UICheckBox checkBoxLineFeed;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UILine proName;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UIIntegerUpDown readTimeout;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UICheckBox checkBoxCarriageReturn;
        private Sunny.UI.UITextBox txtwindownTitle;
        private Sunny.UI.UISymbolButton btnSendMsgTest;
        private Sunny.UI.UITurnSwitch btnStart;
    }
}

