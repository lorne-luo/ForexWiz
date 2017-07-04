using System.Windows.Forms;
using System.Drawing;
namespace LeoStudio.ForexWiz.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.最近消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.价格提醒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.integerInput_balloon = new DevComponents.Editors.IntegerInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.integerInput_window = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX_Name = new DevComponents.DotNetBar.LabelX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.labelX_looptime = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.comboBoxEx_tech = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_event = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboBoxEx_news = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.checkBoxX_news = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_tech = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_event = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_Contact = new DevComponents.DotNetBar.ButtonX();
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_price = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel_usdcad = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.doubleInput_usdcaddown = new DevComponents.Editors.DoubleInput();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput_usdcadup = new DevComponents.Editors.DoubleInput();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_usdcad = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel_usdchf = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.doubleInput_usdchfdown = new DevComponents.Editors.DoubleInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput_usdchfup = new DevComponents.Editors.DoubleInput();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_usdchf = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel_audusd = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.doubleInput_audusddown = new DevComponents.Editors.DoubleInput();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput_audusdup = new DevComponents.Editors.DoubleInput();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_audusd = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel_usdjpy = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.doubleInput_usdjpydown = new DevComponents.Editors.DoubleInput();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput_usdjpyup = new DevComponents.Editors.DoubleInput();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_usdjpy = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel_gbpusd = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.doubleInput_gbpdown = new DevComponents.Editors.DoubleInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput_gbpup = new DevComponents.Editors.DoubleInput();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_gbpusd = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel_eurusd = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.doubleInput_eurdown = new DevComponents.Editors.DoubleInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.doubleInput_eurup = new DevComponents.Editors.DoubleInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX_eurusd = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.ribbonTabItem_Alert = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem_Content = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem_Message = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem_About = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_balloon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_window)).BeginInit();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.groupPanel_usdcad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdcaddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdcadup)).BeginInit();
            this.groupPanel_usdchf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdchfdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdchfup)).BeginInit();
            this.groupPanel_audusd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_audusddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_audusdup)).BeginInit();
            this.groupPanel_usdjpy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdjpydown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdjpyup)).BeginInit();
            this.groupPanel_gbpusd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_gbpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_gbpup)).BeginInit();
            this.groupPanel_eurusd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_eurdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_eurup)).BeginInit();
            this.ribbonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最近消息ToolStripMenuItem,
            this.价格提醒ToolStripMenuItem,
            this.设置SToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 114);
            // 
            // 最近消息ToolStripMenuItem
            // 
            this.最近消息ToolStripMenuItem.Name = "最近消息ToolStripMenuItem";
            this.最近消息ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.最近消息ToolStripMenuItem.Text = "最近消息";
            // 
            // 价格提醒ToolStripMenuItem
            // 
            this.价格提醒ToolStripMenuItem.Name = "价格提醒ToolStripMenuItem";
            this.价格提醒ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.价格提醒ToolStripMenuItem.Text = "价格提醒";
            this.价格提醒ToolStripMenuItem.Click += new System.EventHandler(this.价格提醒ToolStripMenuItem_Click);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            this.设置SToolStripMenuItem.Click += new System.EventHandler(this.设置SToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.Class = "";
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(153, 233);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.switchButton1.OffTextColor = System.Drawing.Color.SlateBlue;
            this.switchButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.switchButton1.OnTextColor = System.Drawing.Color.SlateBlue;
            this.switchButton1.Size = new System.Drawing.Size(78, 25);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.SwitchWidth = 30;
            this.switchButton1.TabIndex = 5;
            this.switchButton1.Visible = false;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(24, 236);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(132, 23);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "将邮件提醒转换为弹窗";
            this.labelX4.Visible = false;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(24, 196);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(82, 23);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "提醒邮箱";
            this.labelX3.Visible = false;
            // 
            // textBoxX_email
            // 
            // 
            // 
            // 
            this.textBoxX_email.Border.Class = "TextBoxBorder";
            this.textBoxX_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_email.Location = new System.Drawing.Point(106, 195);
            this.textBoxX_email.Name = "textBoxX_email";
            this.textBoxX_email.Size = new System.Drawing.Size(125, 21);
            this.textBoxX_email.TabIndex = 25;
            this.textBoxX_email.Visible = false;
            // 
            // integerInput_balloon
            // 
            // 
            // 
            // 
            this.integerInput_balloon.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput_balloon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput_balloon.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput_balloon.Location = new System.Drawing.Point(110, 156);
            this.integerInput_balloon.Name = "integerInput_balloon";
            this.integerInput_balloon.ShowUpDown = true;
            this.integerInput_balloon.Size = new System.Drawing.Size(53, 21);
            this.integerInput_balloon.TabIndex = 24;
            this.integerInput_balloon.Value = 10;
            this.integerInput_balloon.ValueChanged += new System.EventHandler(this.integerInput_balloon_ValueChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(24, 156);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(82, 23);
            this.labelX2.TabIndex = 23;
            this.labelX2.Text = "气泡显示时间";
            // 
            // integerInput_window
            // 
            // 
            // 
            // 
            this.integerInput_window.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput_window.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput_window.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput_window.Location = new System.Drawing.Point(110, 126);
            this.integerInput_window.Name = "integerInput_window";
            this.integerInput_window.ShowUpDown = true;
            this.integerInput_window.Size = new System.Drawing.Size(53, 21);
            this.integerInput_window.TabIndex = 22;
            this.integerInput_window.Value = 10;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(24, 126);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(82, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "弹窗显示时间";
            // 
            // labelX_Name
            // 
            this.labelX_Name.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_Name.BackgroundStyle.Class = "";
            this.labelX_Name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_Name.Location = new System.Drawing.Point(20, 5);
            this.labelX_Name.Name = "labelX_Name";
            this.labelX_Name.Size = new System.Drawing.Size(128, 23);
            this.labelX_Name.TabIndex = 41;
            this.labelX_Name.Text = "ForexWiz";
            // 
            // labelX19
            // 
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.Class = "";
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(20, 57);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(87, 23);
            this.labelX19.TabIndex = 37;
            this.labelX19.Text = "QQ:99451121";
            // 
            // labelX18
            // 
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.Class = "";
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(20, 31);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(66, 23);
            this.labelX18.TabIndex = 36;
            this.labelX18.Text = "作者：Leo";
            // 
            // labelX_looptime
            // 
            this.labelX_looptime.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_looptime.BackgroundStyle.Class = "";
            this.labelX_looptime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_looptime.Location = new System.Drawing.Point(244, 231);
            this.labelX_looptime.Name = "labelX_looptime";
            this.labelX_looptime.Size = new System.Drawing.Size(63, 22);
            this.labelX_looptime.TabIndex = 34;
            this.labelX_looptime.Text = "0";
            this.labelX_looptime.Visible = false;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(181, 231);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(66, 23);
            this.labelX5.TabIndex = 33;
            this.labelX5.Text = "查询次数:";
            this.labelX5.Visible = false;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "buttonItem1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "labelItem1";
            // 
            // balloonTip1
            // 
            this.balloonTip1.DefaultBalloonWidth = 180;
            this.balloonTip1.InitialDelay = 300;
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem_Alert,
            this.ribbonTabItem_Content,
            this.ribbonTabItem_Message,
            this.ribbonTabItem_About});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(318, 312);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 4;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.comboBoxEx_tech);
            this.ribbonPanel1.Controls.Add(this.comboBoxEx_event);
            this.ribbonPanel1.Controls.Add(this.comboBoxEx_news);
            this.ribbonPanel1.Controls.Add(this.checkBoxX_news);
            this.ribbonPanel1.Controls.Add(this.checkBoxX_tech);
            this.ribbonPanel1.Controls.Add(this.checkBoxX_event);
            this.ribbonPanel1.Controls.Add(this.labelX23);
            this.ribbonPanel1.Controls.Add(this.labelX22);
            this.ribbonPanel1.Controls.Add(this.switchButton1);
            this.ribbonPanel1.Controls.Add(this.labelX1);
            this.ribbonPanel1.Controls.Add(this.integerInput_window);
            this.ribbonPanel1.Controls.Add(this.labelX4);
            this.ribbonPanel1.Controls.Add(this.labelX2);
            this.ribbonPanel1.Controls.Add(this.labelX3);
            this.ribbonPanel1.Controls.Add(this.integerInput_balloon);
            this.ribbonPanel1.Controls.Add(this.textBoxX_email);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(318, 257);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // comboBoxEx_tech
            // 
            this.comboBoxEx_tech.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_tech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx_tech.FormattingEnabled = true;
            this.comboBoxEx_tech.ItemHeight = 15;
            this.comboBoxEx_tech.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6});
            this.comboBoxEx_tech.Location = new System.Drawing.Point(110, 92);
            this.comboBoxEx_tech.Name = "comboBoxEx_tech";
            this.comboBoxEx_tech.Size = new System.Drawing.Size(88, 21);
            this.comboBoxEx_tech.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_tech.TabIndex = 39;
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "弹窗提醒";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "气泡提醒";
            // 
            // comboBoxEx_event
            // 
            this.comboBoxEx_event.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_event.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx_event.FormattingEnabled = true;
            this.comboBoxEx_event.ItemHeight = 15;
            this.comboBoxEx_event.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4});
            this.comboBoxEx_event.Location = new System.Drawing.Point(110, 55);
            this.comboBoxEx_event.Name = "comboBoxEx_event";
            this.comboBoxEx_event.Size = new System.Drawing.Size(88, 21);
            this.comboBoxEx_event.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_event.TabIndex = 38;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "弹窗提醒";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "气泡提醒";
            // 
            // comboBoxEx_news
            // 
            this.comboBoxEx_news.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_news.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx_news.FormattingEnabled = true;
            this.comboBoxEx_news.ItemHeight = 15;
            this.comboBoxEx_news.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxEx_news.Location = new System.Drawing.Point(110, 17);
            this.comboBoxEx_news.Name = "comboBoxEx_news";
            this.comboBoxEx_news.Size = new System.Drawing.Size(88, 21);
            this.comboBoxEx_news.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_news.TabIndex = 37;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "弹窗提醒";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "气泡提醒";
            // 
            // checkBoxX_news
            // 
            this.checkBoxX_news.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_news.BackgroundStyle.Class = "";
            this.checkBoxX_news.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_news.Checked = true;
            this.checkBoxX_news.CheckSignSize = new System.Drawing.Size(18, 18);
            this.checkBoxX_news.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_news.CheckValue = "Y";
            this.checkBoxX_news.Location = new System.Drawing.Point(24, 16);
            this.checkBoxX_news.Name = "checkBoxX_news";
            this.checkBoxX_news.Size = new System.Drawing.Size(80, 23);
            this.checkBoxX_news.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_news.TabIndex = 35;
            this.checkBoxX_news.Text = "即时新闻";
            // 
            // checkBoxX_tech
            // 
            this.checkBoxX_tech.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_tech.BackgroundStyle.Class = "";
            this.checkBoxX_tech.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_tech.Checked = true;
            this.checkBoxX_tech.CheckSignSize = new System.Drawing.Size(18, 18);
            this.checkBoxX_tech.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_tech.CheckValue = "Y";
            this.checkBoxX_tech.Location = new System.Drawing.Point(23, 92);
            this.checkBoxX_tech.Name = "checkBoxX_tech";
            this.checkBoxX_tech.Size = new System.Drawing.Size(85, 23);
            this.checkBoxX_tech.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_tech.TabIndex = 34;
            this.checkBoxX_tech.Text = "技术分析";
            // 
            // checkBoxX_event
            // 
            this.checkBoxX_event.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_event.BackgroundStyle.Class = "";
            this.checkBoxX_event.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_event.Checked = true;
            this.checkBoxX_event.CheckSignSize = new System.Drawing.Size(18, 18);
            this.checkBoxX_event.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_event.CheckValue = "Y";
            this.checkBoxX_event.Location = new System.Drawing.Point(24, 54);
            this.checkBoxX_event.Name = "checkBoxX_event";
            this.checkBoxX_event.Size = new System.Drawing.Size(83, 23);
            this.checkBoxX_event.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_event.TabIndex = 36;
            this.checkBoxX_event.Text = "财经事件";
            // 
            // labelX23
            // 
            this.labelX23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.Class = "";
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.Location = new System.Drawing.Point(168, 154);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(30, 23);
            this.labelX23.TabIndex = 29;
            this.labelX23.Text = "秒";
            // 
            // labelX22
            // 
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.Class = "";
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Location = new System.Drawing.Point(168, 126);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(30, 23);
            this.labelX22.TabIndex = 28;
            this.labelX22.Text = "秒";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.linkLabel1);
            this.ribbonPanel4.Controls.Add(this.buttonX1);
            this.ribbonPanel4.Controls.Add(this.buttonX_Contact);
            this.ribbonPanel4.Controls.Add(this.labelX24);
            this.ribbonPanel4.Controls.Add(this.labelX_looptime);
            this.ribbonPanel4.Controls.Add(this.labelX_Name);
            this.ribbonPanel4.Controls.Add(this.labelX18);
            this.ribbonPanel4.Controls.Add(this.labelX5);
            this.ribbonPanel4.Controls.Add(this.labelX19);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(318, 257);
            // 
            // 
            // 
            this.ribbonPanel4.Style.Class = "";
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.Class = "";
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.Class = "";
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(20, 109);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(227, 12);
            this.linkLabel1.TabIndex = 48;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "软件主页：http://forexwiz.sinaapp.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.EnableMarkup = false;
            this.buttonX1.EnableMnemonicWithAltKeyOnly = true;
            this.buttonX1.FadeEffect = false;
            this.buttonX1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX1.Location = new System.Drawing.Point(20, 133);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.ShowSubItems = false;
            this.buttonX1.Size = new System.Drawing.Size(280, 66);
            this.buttonX1.TabIndex = 46;
            this.buttonX1.Text = "欢迎您对本软件提出宝贵意见，另外本软件也有Android版，请访问上面的网址下载，或用手机登陆各大应用市场搜索<外汇行家>";
            // 
            // buttonX_Contact
            // 
            this.buttonX_Contact.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Contact.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX_Contact.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonX_Contact.Location = new System.Drawing.Point(20, 210);
            this.buttonX_Contact.Name = "buttonX_Contact";
            this.buttonX_Contact.Size = new System.Drawing.Size(135, 37);
            this.buttonX_Contact.TabIndex = 43;
            this.buttonX_Contact.Text = "报告BUG | 改进建议";
            this.buttonX_Contact.Click += new System.EventHandler(this.buttonX_Contact_Click);
            // 
            // labelX24
            // 
            this.labelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.Class = "";
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Location = new System.Drawing.Point(20, 83);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(169, 23);
            this.labelX24.TabIndex = 42;
            this.labelX24.Text = "Email:99451121@qq.com";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.labelX20);
            this.ribbonPanel2.Controls.Add(this.checkBoxX_price);
            this.ribbonPanel2.Controls.Add(this.groupPanel_usdcad);
            this.ribbonPanel2.Controls.Add(this.groupPanel_usdchf);
            this.ribbonPanel2.Controls.Add(this.groupPanel_audusd);
            this.ribbonPanel2.Controls.Add(this.groupPanel_usdjpy);
            this.ribbonPanel2.Controls.Add(this.groupPanel_gbpusd);
            this.ribbonPanel2.Controls.Add(this.groupPanel_eurusd);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(318, 257);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // labelX20
            // 
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.Class = "";
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(24, 18);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(84, 23);
            this.labelX20.TabIndex = 44;
            this.labelX20.Text = "即时价格提醒";
            // 
            // checkBoxX_price
            // 
            this.checkBoxX_price.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_price.BackgroundStyle.Class = "";
            this.checkBoxX_price.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_price.Checked = true;
            this.checkBoxX_price.CheckSignSize = new System.Drawing.Size(18, 18);
            this.checkBoxX_price.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_price.CheckValue = "Y";
            this.checkBoxX_price.Location = new System.Drawing.Point(110, 16);
            this.checkBoxX_price.Name = "checkBoxX_price";
            this.checkBoxX_price.Size = new System.Drawing.Size(104, 25);
            this.checkBoxX_price.TabIndex = 34;
            this.checkBoxX_price.Text = "即时价格提醒";
            this.checkBoxX_price.Visible = false;
            // 
            // groupPanel_usdcad
            // 
            this.groupPanel_usdcad.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel_usdcad.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_usdcad.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_usdcad.Controls.Add(this.doubleInput_usdcaddown);
            this.groupPanel_usdcad.Controls.Add(this.labelX16);
            this.groupPanel_usdcad.Controls.Add(this.doubleInput_usdcadup);
            this.groupPanel_usdcad.Controls.Add(this.labelX17);
            this.groupPanel_usdcad.Controls.Add(this.checkBoxX_usdcad);
            this.groupPanel_usdcad.Location = new System.Drawing.Point(24, 180);
            this.groupPanel_usdcad.Name = "groupPanel_usdcad";
            this.groupPanel_usdcad.Size = new System.Drawing.Size(265, 31);
            // 
            // 
            // 
            this.groupPanel_usdcad.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_usdcad.Style.BackColorGradientAngle = 90;
            this.groupPanel_usdcad.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_usdcad.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdcad.Style.BorderBottomWidth = 1;
            this.groupPanel_usdcad.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_usdcad.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdcad.Style.BorderLeftWidth = 1;
            this.groupPanel_usdcad.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdcad.Style.BorderRightWidth = 1;
            this.groupPanel_usdcad.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdcad.Style.BorderTopWidth = 1;
            this.groupPanel_usdcad.Style.Class = "";
            this.groupPanel_usdcad.Style.CornerDiameter = 4;
            this.groupPanel_usdcad.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_usdcad.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_usdcad.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_usdcad.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_usdcad.StyleMouseDown.Class = "";
            this.groupPanel_usdcad.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_usdcad.StyleMouseOver.Class = "";
            this.groupPanel_usdcad.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_usdcad.TabIndex = 43;
            this.groupPanel_usdcad.Visible = false;
            // 
            // doubleInput_usdcaddown
            // 
            // 
            // 
            // 
            this.doubleInput_usdcaddown.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_usdcaddown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_usdcaddown.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_usdcaddown.DisplayFormat = "F4";
            this.doubleInput_usdcaddown.Increment = 0.0001;
            this.doubleInput_usdcaddown.Location = new System.Drawing.Point(183, 3);
            this.doubleInput_usdcaddown.Name = "doubleInput_usdcaddown";
            this.doubleInput_usdcaddown.ShowUpDown = true;
            this.doubleInput_usdcaddown.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_usdcaddown.TabIndex = 40;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX16.Location = new System.Drawing.Point(168, 2);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(32, 23);
            this.labelX16.TabIndex = 39;
            this.labelX16.Text = "<";
            // 
            // doubleInput_usdcadup
            // 
            // 
            // 
            // 
            this.doubleInput_usdcadup.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_usdcadup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_usdcadup.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_usdcadup.DisplayFormat = "F4";
            this.doubleInput_usdcadup.Increment = 0.0001;
            this.doubleInput_usdcadup.Location = new System.Drawing.Point(86, 3);
            this.doubleInput_usdcadup.Name = "doubleInput_usdcadup";
            this.doubleInput_usdcadup.ShowUpDown = true;
            this.doubleInput_usdcadup.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_usdcadup.TabIndex = 38;
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX17.Location = new System.Drawing.Point(71, 2);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(32, 23);
            this.labelX17.TabIndex = 37;
            this.labelX17.Text = ">";
            // 
            // checkBoxX_usdcad
            // 
            this.checkBoxX_usdcad.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_usdcad.BackgroundStyle.Class = "";
            this.checkBoxX_usdcad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_usdcad.CheckSignSize = new System.Drawing.Size(15, 15);
            this.checkBoxX_usdcad.Location = new System.Drawing.Point(3, 1);
            this.checkBoxX_usdcad.Name = "checkBoxX_usdcad";
            this.checkBoxX_usdcad.Size = new System.Drawing.Size(64, 25);
            this.checkBoxX_usdcad.TabIndex = 35;
            this.checkBoxX_usdcad.Text = "USDCAD";
            // 
            // groupPanel_usdchf
            // 
            this.groupPanel_usdchf.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel_usdchf.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_usdchf.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_usdchf.Controls.Add(this.doubleInput_usdchfdown);
            this.groupPanel_usdchf.Controls.Add(this.labelX14);
            this.groupPanel_usdchf.Controls.Add(this.doubleInput_usdchfup);
            this.groupPanel_usdchf.Controls.Add(this.labelX15);
            this.groupPanel_usdchf.Controls.Add(this.checkBoxX_usdchf);
            this.groupPanel_usdchf.Location = new System.Drawing.Point(24, 148);
            this.groupPanel_usdchf.Name = "groupPanel_usdchf";
            this.groupPanel_usdchf.Size = new System.Drawing.Size(265, 31);
            // 
            // 
            // 
            this.groupPanel_usdchf.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_usdchf.Style.BackColorGradientAngle = 90;
            this.groupPanel_usdchf.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_usdchf.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdchf.Style.BorderBottomWidth = 1;
            this.groupPanel_usdchf.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_usdchf.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdchf.Style.BorderLeftWidth = 1;
            this.groupPanel_usdchf.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdchf.Style.BorderRightWidth = 1;
            this.groupPanel_usdchf.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdchf.Style.BorderTopWidth = 1;
            this.groupPanel_usdchf.Style.Class = "";
            this.groupPanel_usdchf.Style.CornerDiameter = 4;
            this.groupPanel_usdchf.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_usdchf.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_usdchf.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_usdchf.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_usdchf.StyleMouseDown.Class = "";
            this.groupPanel_usdchf.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_usdchf.StyleMouseOver.Class = "";
            this.groupPanel_usdchf.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_usdchf.TabIndex = 42;
            this.groupPanel_usdchf.Visible = false;
            // 
            // doubleInput_usdchfdown
            // 
            // 
            // 
            // 
            this.doubleInput_usdchfdown.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_usdchfdown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_usdchfdown.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_usdchfdown.DisplayFormat = "F4";
            this.doubleInput_usdchfdown.Increment = 0.0001;
            this.doubleInput_usdchfdown.Location = new System.Drawing.Point(183, 2);
            this.doubleInput_usdchfdown.Name = "doubleInput_usdchfdown";
            this.doubleInput_usdchfdown.ShowUpDown = true;
            this.doubleInput_usdchfdown.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_usdchfdown.TabIndex = 40;
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX14.Location = new System.Drawing.Point(168, 1);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(32, 23);
            this.labelX14.TabIndex = 39;
            this.labelX14.Text = "<";
            // 
            // doubleInput_usdchfup
            // 
            // 
            // 
            // 
            this.doubleInput_usdchfup.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_usdchfup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_usdchfup.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_usdchfup.DisplayFormat = "F4";
            this.doubleInput_usdchfup.Increment = 0.0001;
            this.doubleInput_usdchfup.Location = new System.Drawing.Point(86, 2);
            this.doubleInput_usdchfup.Name = "doubleInput_usdchfup";
            this.doubleInput_usdchfup.ShowUpDown = true;
            this.doubleInput_usdchfup.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_usdchfup.TabIndex = 38;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX15.Location = new System.Drawing.Point(71, 1);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(32, 23);
            this.labelX15.TabIndex = 37;
            this.labelX15.Text = ">";
            // 
            // checkBoxX_usdchf
            // 
            this.checkBoxX_usdchf.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_usdchf.BackgroundStyle.Class = "";
            this.checkBoxX_usdchf.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_usdchf.CheckSignSize = new System.Drawing.Size(15, 15);
            this.checkBoxX_usdchf.Location = new System.Drawing.Point(3, 0);
            this.checkBoxX_usdchf.Name = "checkBoxX_usdchf";
            this.checkBoxX_usdchf.Size = new System.Drawing.Size(64, 25);
            this.checkBoxX_usdchf.TabIndex = 35;
            this.checkBoxX_usdchf.Text = "USDCHF";
            // 
            // groupPanel_audusd
            // 
            this.groupPanel_audusd.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel_audusd.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_audusd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_audusd.Controls.Add(this.doubleInput_audusddown);
            this.groupPanel_audusd.Controls.Add(this.labelX12);
            this.groupPanel_audusd.Controls.Add(this.doubleInput_audusdup);
            this.groupPanel_audusd.Controls.Add(this.labelX13);
            this.groupPanel_audusd.Controls.Add(this.checkBoxX_audusd);
            this.groupPanel_audusd.Location = new System.Drawing.Point(24, 212);
            this.groupPanel_audusd.Name = "groupPanel_audusd";
            this.groupPanel_audusd.Size = new System.Drawing.Size(265, 31);
            // 
            // 
            // 
            this.groupPanel_audusd.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_audusd.Style.BackColorGradientAngle = 90;
            this.groupPanel_audusd.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_audusd.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_audusd.Style.BorderBottomWidth = 1;
            this.groupPanel_audusd.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_audusd.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_audusd.Style.BorderLeftWidth = 1;
            this.groupPanel_audusd.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_audusd.Style.BorderRightWidth = 1;
            this.groupPanel_audusd.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_audusd.Style.BorderTopWidth = 1;
            this.groupPanel_audusd.Style.Class = "";
            this.groupPanel_audusd.Style.CornerDiameter = 4;
            this.groupPanel_audusd.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_audusd.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_audusd.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_audusd.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_audusd.StyleMouseDown.Class = "";
            this.groupPanel_audusd.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_audusd.StyleMouseOver.Class = "";
            this.groupPanel_audusd.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_audusd.TabIndex = 41;
            this.groupPanel_audusd.Visible = false;
            // 
            // doubleInput_audusddown
            // 
            // 
            // 
            // 
            this.doubleInput_audusddown.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_audusddown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_audusddown.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_audusddown.DisplayFormat = "F4";
            this.doubleInput_audusddown.Increment = 0.0001;
            this.doubleInput_audusddown.Location = new System.Drawing.Point(183, 2);
            this.doubleInput_audusddown.Name = "doubleInput_audusddown";
            this.doubleInput_audusddown.ShowUpDown = true;
            this.doubleInput_audusddown.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_audusddown.TabIndex = 40;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX12.Location = new System.Drawing.Point(168, 1);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(32, 23);
            this.labelX12.TabIndex = 39;
            this.labelX12.Text = "<";
            // 
            // doubleInput_audusdup
            // 
            // 
            // 
            // 
            this.doubleInput_audusdup.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_audusdup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_audusdup.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_audusdup.DisplayFormat = "F4";
            this.doubleInput_audusdup.Increment = 0.0001;
            this.doubleInput_audusdup.Location = new System.Drawing.Point(86, 2);
            this.doubleInput_audusdup.Name = "doubleInput_audusdup";
            this.doubleInput_audusdup.ShowUpDown = true;
            this.doubleInput_audusdup.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_audusdup.TabIndex = 38;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX13.Location = new System.Drawing.Point(71, 1);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(32, 23);
            this.labelX13.TabIndex = 37;
            this.labelX13.Text = ">";
            // 
            // checkBoxX_audusd
            // 
            this.checkBoxX_audusd.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_audusd.BackgroundStyle.Class = "";
            this.checkBoxX_audusd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_audusd.CheckSignSize = new System.Drawing.Size(15, 15);
            this.checkBoxX_audusd.Location = new System.Drawing.Point(3, 0);
            this.checkBoxX_audusd.Name = "checkBoxX_audusd";
            this.checkBoxX_audusd.Size = new System.Drawing.Size(64, 25);
            this.checkBoxX_audusd.TabIndex = 35;
            this.checkBoxX_audusd.Text = "AUDUSD";
            // 
            // groupPanel_usdjpy
            // 
            this.groupPanel_usdjpy.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel_usdjpy.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_usdjpy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_usdjpy.Controls.Add(this.doubleInput_usdjpydown);
            this.groupPanel_usdjpy.Controls.Add(this.labelX10);
            this.groupPanel_usdjpy.Controls.Add(this.doubleInput_usdjpyup);
            this.groupPanel_usdjpy.Controls.Add(this.labelX11);
            this.groupPanel_usdjpy.Controls.Add(this.checkBoxX_usdjpy);
            this.groupPanel_usdjpy.DrawTitleBox = false;
            this.groupPanel_usdjpy.Location = new System.Drawing.Point(24, 116);
            this.groupPanel_usdjpy.Name = "groupPanel_usdjpy";
            this.groupPanel_usdjpy.Size = new System.Drawing.Size(265, 31);
            // 
            // 
            // 
            this.groupPanel_usdjpy.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_usdjpy.Style.BackColorGradientAngle = 90;
            this.groupPanel_usdjpy.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_usdjpy.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdjpy.Style.BorderBottomWidth = 1;
            this.groupPanel_usdjpy.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_usdjpy.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdjpy.Style.BorderLeftWidth = 1;
            this.groupPanel_usdjpy.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdjpy.Style.BorderRightWidth = 1;
            this.groupPanel_usdjpy.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_usdjpy.Style.BorderTopWidth = 1;
            this.groupPanel_usdjpy.Style.Class = "";
            this.groupPanel_usdjpy.Style.CornerDiameter = 4;
            this.groupPanel_usdjpy.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_usdjpy.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_usdjpy.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_usdjpy.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_usdjpy.StyleMouseDown.Class = "";
            this.groupPanel_usdjpy.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_usdjpy.StyleMouseOver.Class = "";
            this.groupPanel_usdjpy.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_usdjpy.TabIndex = 41;
            this.groupPanel_usdjpy.Visible = false;
            // 
            // doubleInput_usdjpydown
            // 
            // 
            // 
            // 
            this.doubleInput_usdjpydown.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_usdjpydown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_usdjpydown.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_usdjpydown.DisplayFormat = "F3";
            this.doubleInput_usdjpydown.Increment = 0.001;
            this.doubleInput_usdjpydown.Location = new System.Drawing.Point(183, 2);
            this.doubleInput_usdjpydown.Name = "doubleInput_usdjpydown";
            this.doubleInput_usdjpydown.ShowUpDown = true;
            this.doubleInput_usdjpydown.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_usdjpydown.TabIndex = 40;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX10.Location = new System.Drawing.Point(168, 1);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(32, 23);
            this.labelX10.TabIndex = 39;
            this.labelX10.Text = "<";
            // 
            // doubleInput_usdjpyup
            // 
            // 
            // 
            // 
            this.doubleInput_usdjpyup.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_usdjpyup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_usdjpyup.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_usdjpyup.DisplayFormat = "F3";
            this.doubleInput_usdjpyup.Increment = 0.001;
            this.doubleInput_usdjpyup.Location = new System.Drawing.Point(86, 3);
            this.doubleInput_usdjpyup.Name = "doubleInput_usdjpyup";
            this.doubleInput_usdjpyup.ShowUpDown = true;
            this.doubleInput_usdjpyup.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_usdjpyup.TabIndex = 38;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX11.Location = new System.Drawing.Point(71, 2);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(32, 23);
            this.labelX11.TabIndex = 37;
            this.labelX11.Text = ">";
            // 
            // checkBoxX_usdjpy
            // 
            this.checkBoxX_usdjpy.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_usdjpy.BackgroundStyle.Class = "";
            this.checkBoxX_usdjpy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_usdjpy.CheckSignSize = new System.Drawing.Size(15, 15);
            this.checkBoxX_usdjpy.Location = new System.Drawing.Point(3, 0);
            this.checkBoxX_usdjpy.Name = "checkBoxX_usdjpy";
            this.checkBoxX_usdjpy.Size = new System.Drawing.Size(64, 25);
            this.checkBoxX_usdjpy.TabIndex = 35;
            this.checkBoxX_usdjpy.Text = "USDJPY";
            // 
            // groupPanel_gbpusd
            // 
            this.groupPanel_gbpusd.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel_gbpusd.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_gbpusd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_gbpusd.Controls.Add(this.doubleInput_gbpdown);
            this.groupPanel_gbpusd.Controls.Add(this.labelX8);
            this.groupPanel_gbpusd.Controls.Add(this.doubleInput_gbpup);
            this.groupPanel_gbpusd.Controls.Add(this.labelX9);
            this.groupPanel_gbpusd.Controls.Add(this.checkBoxX_gbpusd);
            this.groupPanel_gbpusd.Location = new System.Drawing.Point(24, 52);
            this.groupPanel_gbpusd.Name = "groupPanel_gbpusd";
            this.groupPanel_gbpusd.Size = new System.Drawing.Size(265, 31);
            // 
            // 
            // 
            this.groupPanel_gbpusd.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_gbpusd.Style.BackColorGradientAngle = 90;
            this.groupPanel_gbpusd.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_gbpusd.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_gbpusd.Style.BorderBottomWidth = 1;
            this.groupPanel_gbpusd.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_gbpusd.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_gbpusd.Style.BorderLeftWidth = 1;
            this.groupPanel_gbpusd.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_gbpusd.Style.BorderRightWidth = 1;
            this.groupPanel_gbpusd.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_gbpusd.Style.BorderTopWidth = 1;
            this.groupPanel_gbpusd.Style.Class = "";
            this.groupPanel_gbpusd.Style.CornerDiameter = 4;
            this.groupPanel_gbpusd.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_gbpusd.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_gbpusd.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_gbpusd.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_gbpusd.StyleMouseDown.Class = "";
            this.groupPanel_gbpusd.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_gbpusd.StyleMouseOver.Class = "";
            this.groupPanel_gbpusd.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_gbpusd.TabIndex = 41;
            this.groupPanel_gbpusd.Visible = false;
            // 
            // doubleInput_gbpdown
            // 
            // 
            // 
            // 
            this.doubleInput_gbpdown.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_gbpdown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_gbpdown.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_gbpdown.DisplayFormat = "F4";
            this.doubleInput_gbpdown.Increment = 0.0001;
            this.doubleInput_gbpdown.Location = new System.Drawing.Point(184, 2);
            this.doubleInput_gbpdown.Name = "doubleInput_gbpdown";
            this.doubleInput_gbpdown.ShowUpDown = true;
            this.doubleInput_gbpdown.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_gbpdown.TabIndex = 40;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(169, 1);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(32, 23);
            this.labelX8.TabIndex = 39;
            this.labelX8.Text = "<";
            // 
            // doubleInput_gbpup
            // 
            // 
            // 
            // 
            this.doubleInput_gbpup.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_gbpup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_gbpup.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_gbpup.DisplayFormat = "F4";
            this.doubleInput_gbpup.Increment = 0.0001;
            this.doubleInput_gbpup.Location = new System.Drawing.Point(87, 2);
            this.doubleInput_gbpup.Name = "doubleInput_gbpup";
            this.doubleInput_gbpup.ShowUpDown = true;
            this.doubleInput_gbpup.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_gbpup.TabIndex = 38;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(72, 1);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(32, 23);
            this.labelX9.TabIndex = 37;
            this.labelX9.Text = ">";
            // 
            // checkBoxX_gbpusd
            // 
            this.checkBoxX_gbpusd.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_gbpusd.BackgroundStyle.Class = "";
            this.checkBoxX_gbpusd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_gbpusd.CheckSignSize = new System.Drawing.Size(15, 15);
            this.checkBoxX_gbpusd.Location = new System.Drawing.Point(5, 0);
            this.checkBoxX_gbpusd.Name = "checkBoxX_gbpusd";
            this.checkBoxX_gbpusd.Size = new System.Drawing.Size(64, 25);
            this.checkBoxX_gbpusd.TabIndex = 35;
            this.checkBoxX_gbpusd.Text = "GBPUSD";
            // 
            // groupPanel_eurusd
            // 
            this.groupPanel_eurusd.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel_eurusd.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_eurusd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_eurusd.Controls.Add(this.doubleInput_eurdown);
            this.groupPanel_eurusd.Controls.Add(this.labelX7);
            this.groupPanel_eurusd.Controls.Add(this.doubleInput_eurup);
            this.groupPanel_eurusd.Controls.Add(this.labelX6);
            this.groupPanel_eurusd.Controls.Add(this.checkBoxX_eurusd);
            this.groupPanel_eurusd.Location = new System.Drawing.Point(24, 84);
            this.groupPanel_eurusd.Name = "groupPanel_eurusd";
            this.groupPanel_eurusd.Size = new System.Drawing.Size(265, 31);
            // 
            // 
            // 
            this.groupPanel_eurusd.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_eurusd.Style.BackColorGradientAngle = 90;
            this.groupPanel_eurusd.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_eurusd.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_eurusd.Style.BorderBottomWidth = 1;
            this.groupPanel_eurusd.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_eurusd.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_eurusd.Style.BorderLeftWidth = 1;
            this.groupPanel_eurusd.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_eurusd.Style.BorderRightWidth = 1;
            this.groupPanel_eurusd.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_eurusd.Style.BorderTopWidth = 1;
            this.groupPanel_eurusd.Style.Class = "";
            this.groupPanel_eurusd.Style.CornerDiameter = 4;
            this.groupPanel_eurusd.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_eurusd.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_eurusd.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_eurusd.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_eurusd.StyleMouseDown.Class = "";
            this.groupPanel_eurusd.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_eurusd.StyleMouseOver.Class = "";
            this.groupPanel_eurusd.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_eurusd.TabIndex = 35;
            this.groupPanel_eurusd.Visible = false;
            // 
            // doubleInput_eurdown
            // 
            // 
            // 
            // 
            this.doubleInput_eurdown.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_eurdown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_eurdown.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_eurdown.DisplayFormat = "F4";
            this.doubleInput_eurdown.Increment = 0.0001;
            this.doubleInput_eurdown.Location = new System.Drawing.Point(183, 2);
            this.doubleInput_eurdown.Name = "doubleInput_eurdown";
            this.doubleInput_eurdown.ShowUpDown = true;
            this.doubleInput_eurdown.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_eurdown.TabIndex = 40;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(168, 1);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(32, 23);
            this.labelX7.TabIndex = 39;
            this.labelX7.Text = "<";
            // 
            // doubleInput_eurup
            // 
            // 
            // 
            // 
            this.doubleInput_eurup.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput_eurup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.doubleInput_eurup.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput_eurup.DisplayFormat = "F4";
            this.doubleInput_eurup.Increment = 0.0001;
            this.doubleInput_eurup.Location = new System.Drawing.Point(86, 2);
            this.doubleInput_eurup.Name = "doubleInput_eurup";
            this.doubleInput_eurup.ShowUpDown = true;
            this.doubleInput_eurup.Size = new System.Drawing.Size(68, 21);
            this.doubleInput_eurup.TabIndex = 38;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(71, 1);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(32, 23);
            this.labelX6.TabIndex = 37;
            this.labelX6.Text = ">";
            // 
            // checkBoxX_eurusd
            // 
            this.checkBoxX_eurusd.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX_eurusd.BackgroundStyle.Class = "";
            this.checkBoxX_eurusd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_eurusd.CheckSignSize = new System.Drawing.Size(15, 15);
            this.checkBoxX_eurusd.Location = new System.Drawing.Point(4, 0);
            this.checkBoxX_eurusd.Name = "checkBoxX_eurusd";
            this.checkBoxX_eurusd.Size = new System.Drawing.Size(64, 25);
            this.checkBoxX_eurusd.TabIndex = 35;
            this.checkBoxX_eurusd.Text = "EURUSD";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.rtb_message);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(318, 257);
            // 
            // 
            // 
            this.ribbonPanel3.Style.Class = "";
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.Class = "";
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.Class = "";
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // rtb_message
            // 
            this.rtb_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.rtb_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_message.Location = new System.Drawing.Point(3, 0);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_message.Size = new System.Drawing.Size(312, 254);
            this.rtb_message.TabIndex = 0;
            this.rtb_message.Text = "";
            // 
            // ribbonTabItem_Alert
            // 
            this.ribbonTabItem_Alert.Name = "ribbonTabItem_Alert";
            this.ribbonTabItem_Alert.Panel = this.ribbonPanel1;
            this.ribbonTabItem_Alert.Text = "提醒方式";
            // 
            // ribbonTabItem_Content
            // 
            this.ribbonTabItem_Content.Name = "ribbonTabItem_Content";
            this.ribbonTabItem_Content.Panel = this.ribbonPanel2;
            this.ribbonTabItem_Content.Text = "价格提醒";
            // 
            // ribbonTabItem_Message
            // 
            this.ribbonTabItem_Message.Name = "ribbonTabItem_Message";
            this.ribbonTabItem_Message.Panel = this.ribbonPanel3;
            this.ribbonTabItem_Message.Text = "最近消息";
            // 
            // ribbonTabItem_About
            // 
            this.ribbonTabItem_About.Checked = true;
            this.ribbonTabItem_About.Name = "ribbonTabItem_About";
            this.ribbonTabItem_About.Panel = this.ribbonPanel4;
            this.ribbonTabItem_About.Text = "关于";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 315);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ForexWiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_balloon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput_window)).EndInit();
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.ribbonPanel4.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.groupPanel_usdcad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdcaddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdcadup)).EndInit();
            this.groupPanel_usdchf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdchfdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdchfup)).EndInit();
            this.groupPanel_audusd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_audusddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_audusdup)).EndInit();
            this.groupPanel_usdjpy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdjpydown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_usdjpyup)).EndInit();
            this.groupPanel_gbpusd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_gbpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_gbpup)).EndInit();
            this.groupPanel_eurusd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_eurdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput_eurup)).EndInit();
            this.ribbonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 最近消息ToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput integerInput_balloon;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ColorPickerButton colorPickerButton1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        public DevComponents.Editors.IntegerInput integerInput_window;
        public DevComponents.DotNetBar.Controls.TextBoxX textBoxX_email;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 价格提醒ToolStripMenuItem;
        private DevComponents.DotNetBar.LabelX labelX_looptime;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.LabelX labelX_Name;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel_usdcad;
        public DevComponents.Editors.DoubleInput doubleInput_usdcaddown;
        private DevComponents.DotNetBar.LabelX labelX16;
        public DevComponents.Editors.DoubleInput doubleInput_usdcadup;
        private DevComponents.DotNetBar.LabelX labelX17;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_usdcad;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel_usdchf;
        public DevComponents.Editors.DoubleInput doubleInput_usdchfdown;
        private DevComponents.DotNetBar.LabelX labelX14;
        public DevComponents.Editors.DoubleInput doubleInput_usdchfup;
        private DevComponents.DotNetBar.LabelX labelX15;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_usdchf;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel_audusd;
        public DevComponents.Editors.DoubleInput doubleInput_audusddown;
        private DevComponents.DotNetBar.LabelX labelX12;
        public DevComponents.Editors.DoubleInput doubleInput_audusdup;
        private DevComponents.DotNetBar.LabelX labelX13;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_audusd;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel_usdjpy;
        public DevComponents.Editors.DoubleInput doubleInput_usdjpydown;
        private DevComponents.DotNetBar.LabelX labelX10;
        public DevComponents.Editors.DoubleInput doubleInput_usdjpyup;
        private DevComponents.DotNetBar.LabelX labelX11;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_usdjpy;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_price;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel_gbpusd;
        public DevComponents.Editors.DoubleInput doubleInput_gbpdown;
        private DevComponents.DotNetBar.LabelX labelX8;
        public DevComponents.Editors.DoubleInput doubleInput_gbpup;
        private DevComponents.DotNetBar.LabelX labelX9;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_gbpusd;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel_eurusd;
        public DevComponents.Editors.DoubleInput doubleInput_eurdown;
        private DevComponents.DotNetBar.LabelX labelX7;
        public DevComponents.Editors.DoubleInput doubleInput_eurup;
        private DevComponents.DotNetBar.LabelX labelX6;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_eurusd;
        public RichTextBox rtb_message;
        public DevComponents.DotNetBar.RibbonControl ribbonControl1;
        public DevComponents.DotNetBar.RibbonTabItem ribbonTabItem_Alert;
        public DevComponents.DotNetBar.RibbonTabItem ribbonTabItem_Content;
        public DevComponents.DotNetBar.RibbonTabItem ribbonTabItem_Message;
        public DevComponents.DotNetBar.RibbonTabItem ribbonTabItem_About;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX24;
        private DevComponents.DotNetBar.ButtonX buttonX_Contact;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_news;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_tech;
        public DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_event;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private LinkLabel linkLabel1;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_news;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_tech;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_event;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;

    }
}

