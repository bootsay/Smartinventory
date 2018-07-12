<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcheckstockoption
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcheckstockoption))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnreporttotalmoney = New DevComponents.DotNetBar.ButtonX()
        Me.cbsupcategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbcategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnreport = New DevComponents.DotNetBar.ButtonX()
        Me.btnshow = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvproduct = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dgvinstock = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dgvstockout = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dgvsaleout = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.rdall = New System.Windows.Forms.RadioButton()
        Me.rdstock = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.dgvinstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.dgvstockout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.dgvsaleout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvproduct, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1284, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdstock)
        Me.Panel1.Controls.Add(Me.rdall)
        Me.Panel1.Controls.Add(Me.btnreporttotalmoney)
        Me.Panel1.Controls.Add(Me.cbsupcategory)
        Me.Panel1.Controls.Add(Me.cbcategory)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnreport)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dt1)
        Me.Panel1.Controls.Add(Me.dt2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 76)
        Me.Panel1.TabIndex = 0
        '
        'btnreporttotalmoney
        '
        Me.btnreporttotalmoney.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreporttotalmoney.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreporttotalmoney.Image = Global.Smartinventory.My.Resources.Resources.Report
        Me.btnreporttotalmoney.Location = New System.Drawing.Point(879, 7)
        Me.btnreporttotalmoney.Name = "btnreporttotalmoney"
        Me.btnreporttotalmoney.Size = New System.Drawing.Size(170, 58)
        Me.btnreporttotalmoney.TabIndex = 265
        Me.btnreporttotalmoney.Text = "ລາຍງານມູນຄ່າສີນຄ້າ"
        '
        'cbsupcategory
        '
        Me.cbsupcategory.DisplayMember = "Text"
        Me.cbsupcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsupcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsupcategory.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsupcategory.ForeColor = System.Drawing.Color.Blue
        Me.cbsupcategory.FormattingEnabled = True
        Me.cbsupcategory.ItemHeight = 29
        Me.cbsupcategory.Location = New System.Drawing.Point(345, 39)
        Me.cbsupcategory.Name = "cbsupcategory"
        Me.cbsupcategory.Size = New System.Drawing.Size(165, 35)
        Me.cbsupcategory.TabIndex = 263
        '
        'cbcategory
        '
        Me.cbcategory.DisplayMember = "Text"
        Me.cbcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcategory.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcategory.ForeColor = System.Drawing.Color.Blue
        Me.cbcategory.FormattingEnabled = True
        Me.cbcategory.ItemHeight = 29
        Me.cbcategory.Location = New System.Drawing.Point(345, 3)
        Me.cbcategory.Name = "cbcategory"
        Me.cbcategory.Size = New System.Drawing.Size(165, 35)
        Me.cbcategory.TabIndex = 261
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(260, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 24)
        Me.Label14.TabIndex = 264
        Me.Label14.Text = "ປະເພດຍ່ອຍ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(258, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "ປະເພດຫລັກ:"
        '
        'btnreport
        '
        Me.btnreport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreport.Image = Global.Smartinventory.My.Resources.Resources.Report
        Me.btnreport.Location = New System.Drawing.Point(736, 7)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(138, 58)
        Me.btnreport.TabIndex = 5
        Me.btnreport.Text = "ລາຍງານຈໍານວນ"
        '
        'btnshow
        '
        Me.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshow.Image = Global.Smartinventory.My.Resources.Resources.Search
        Me.btnshow.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnshow.Location = New System.Drawing.Point(636, 7)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(93, 58)
        Me.btnshow.TabIndex = 4
        Me.btnshow.Text = "ສະແດງ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ເລືອກວັນທີ:"
        '
        'dt1
        '
        '
        '
        '
        Me.dt1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt1.ButtonDropDown.Visible = True
        Me.dt1.Location = New System.Drawing.Point(96, 0)
        '
        '
        '
        Me.dt1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dt1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt1.MonthCalendar.DisplayMonth = New Date(2017, 10, 1, 0, 0, 0, 0)
        Me.dt1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt1.MonthCalendar.TodayButtonVisible = True
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(160, 35)
        Me.dt1.TabIndex = 1
        '
        'dt2
        '
        '
        '
        '
        Me.dt2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt2.ButtonDropDown.Visible = True
        Me.dt2.Location = New System.Drawing.Point(96, 36)
        '
        '
        '
        Me.dt2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt2.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dt2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt2.MonthCalendar.DisplayMonth = New Date(2017, 10, 1, 0, 0, 0, 0)
        Me.dt2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt2.MonthCalendar.TodayButtonVisible = True
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(160, 35)
        Me.dt2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ຫາ:"
        '
        'dgvproduct
        '
        Me.dgvproduct.AllowUserToAddRows = False
        Me.dgvproduct.AllowUserToDeleteRows = False
        Me.dgvproduct.AllowUserToResizeColumns = False
        Me.dgvproduct.AllowUserToResizeRows = False
        Me.dgvproduct.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvproduct.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvproduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvproduct.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvproduct.Location = New System.Drawing.Point(3, 87)
        Me.dgvproduct.Name = "dgvproduct"
        Me.dgvproduct.ReadOnly = True
        Me.dgvproduct.RowHeadersVisible = False
        Me.dgvproduct.RowTemplate.Height = 28
        Me.dgvproduct.Size = New System.Drawing.Size(1278, 389)
        Me.dgvproduct.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 482)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1278, 244)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.dgvinstock)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1278, 206)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'dgvinstock
        '
        Me.dgvinstock.AllowUserToAddRows = False
        Me.dgvinstock.AllowUserToDeleteRows = False
        Me.dgvinstock.AllowUserToResizeColumns = False
        Me.dgvinstock.AllowUserToResizeRows = False
        Me.dgvinstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvinstock.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvinstock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvinstock.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvinstock.Location = New System.Drawing.Point(1, 1)
        Me.dgvinstock.Name = "dgvinstock"
        Me.dgvinstock.ReadOnly = True
        Me.dgvinstock.RowHeadersVisible = False
        Me.dgvinstock.RowTemplate.Height = 28
        Me.dgvinstock.Size = New System.Drawing.Size(1276, 204)
        Me.dgvinstock.TabIndex = 0
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "ລາຍລະອຽດສີນຄ້າເຂົ້າສາງ   ."
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.dgvstockout)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(1278, 206)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'dgvstockout
        '
        Me.dgvstockout.AllowUserToAddRows = False
        Me.dgvstockout.AllowUserToDeleteRows = False
        Me.dgvstockout.AllowUserToResizeColumns = False
        Me.dgvstockout.AllowUserToResizeRows = False
        Me.dgvstockout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvstockout.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvstockout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvstockout.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvstockout.Location = New System.Drawing.Point(1, 1)
        Me.dgvstockout.Name = "dgvstockout"
        Me.dgvstockout.ReadOnly = True
        Me.dgvstockout.RowHeadersVisible = False
        Me.dgvstockout.RowTemplate.Height = 28
        Me.dgvstockout.Size = New System.Drawing.Size(1276, 204)
        Me.dgvstockout.TabIndex = 0
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "ລາຍລະອຽດການເບີກຈ່າຍສີນຄ້າ"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.dgvsaleout)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1278, 206)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'dgvsaleout
        '
        Me.dgvsaleout.AllowUserToAddRows = False
        Me.dgvsaleout.AllowUserToDeleteRows = False
        Me.dgvsaleout.AllowUserToResizeColumns = False
        Me.dgvsaleout.AllowUserToResizeRows = False
        Me.dgvsaleout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsaleout.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvsaleout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvsaleout.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvsaleout.Location = New System.Drawing.Point(1, 1)
        Me.dgvsaleout.Name = "dgvsaleout"
        Me.dgvsaleout.ReadOnly = True
        Me.dgvsaleout.RowHeadersVisible = False
        Me.dgvsaleout.RowTemplate.Height = 25
        Me.dgvsaleout.Size = New System.Drawing.Size(1276, 204)
        Me.dgvsaleout.TabIndex = 0
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "ລາຍລະອຽດການຂາຍອອກ"
        '
        'rdall
        '
        Me.rdall.AutoSize = True
        Me.rdall.ForeColor = System.Drawing.Color.Blue
        Me.rdall.Location = New System.Drawing.Point(517, 4)
        Me.rdall.Name = "rdall"
        Me.rdall.Size = New System.Drawing.Size(116, 28)
        Me.rdall.TabIndex = 266
        Me.rdall.TabStop = True
        Me.rdall.Text = "ສະເພາະມີສາງ"
        Me.rdall.UseVisualStyleBackColor = True
        '
        'rdstock
        '
        Me.rdstock.AutoSize = True
        Me.rdstock.ForeColor = System.Drawing.Color.Blue
        Me.rdstock.Location = New System.Drawing.Point(517, 36)
        Me.rdstock.Name = "rdstock"
        Me.rdstock.Size = New System.Drawing.Size(72, 28)
        Me.rdstock.TabIndex = 267
        Me.rdstock.TabStop = True
        Me.rdstock.Text = "ທັງໝົດ"
        Me.rdstock.UseVisualStyleBackColor = True
        '
        'frmcheckstockoption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmcheckstockoption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ເລືອກ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.dgvinstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.dgvstockout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.dgvsaleout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvproduct As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dt1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dt2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnshow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnreport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents dgvinstock As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dgvsaleout As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cbsupcategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbcategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents dgvstockout As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents btnreporttotalmoney As DevComponents.DotNetBar.ButtonX
    Friend WithEvents rdstock As System.Windows.Forms.RadioButton
    Friend WithEvents rdall As System.Windows.Forms.RadioButton
End Class
