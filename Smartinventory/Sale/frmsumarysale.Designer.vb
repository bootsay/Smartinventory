<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsumarysale
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dgvbillist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dgvpaylist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dgvmainlist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.reportsumarysale = New DevComponents.DotNetBar.ButtonItem()
        Me.reportsalebycustomer = New DevComponents.DotNetBar.ButtonItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rddolla = New System.Windows.Forms.RadioButton()
        Me.rdbath = New System.Windows.Forms.RadioButton()
        Me.rdkip = New System.Windows.Forms.RadioButton()
        Me.btnshow = New DevComponents.DotNetBar.ButtonX()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnclose = New DevComponents.DotNetBar.ButtonX()
        Me.rdcustomer = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.dgvbillist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.dgvpaylist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.dgvmainlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31262!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.68739!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1224, 552)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.CanReorderTabs = True
        Me.TabControl2.Controls.Add(Me.TabControlPanel2)
        Me.TabControl2.Controls.Add(Me.TabControlPanel3)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 377)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1218, 172)
        Me.TabControl2.TabIndex = 2
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem2)
        Me.TabControl2.Tabs.Add(Me.TabItem3)
        Me.TabControl2.Text = "TabControl2"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.dgvbillist)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1218, 134)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 1
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'dgvbillist
        '
        Me.dgvbillist.AllowUserToAddRows = False
        Me.dgvbillist.AllowUserToDeleteRows = False
        Me.dgvbillist.AllowUserToResizeColumns = False
        Me.dgvbillist.AllowUserToResizeRows = False
        Me.dgvbillist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvbillist.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvbillist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvbillist.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvbillist.Location = New System.Drawing.Point(1, 1)
        Me.dgvbillist.Name = "dgvbillist"
        Me.dgvbillist.ReadOnly = True
        Me.dgvbillist.RowHeadersVisible = False
        Me.dgvbillist.RowTemplate.Height = 28
        Me.dgvbillist.Size = New System.Drawing.Size(1216, 132)
        Me.dgvbillist.TabIndex = 0
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "ລາຍການບີນ"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.dgvpaylist)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(1218, 134)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 2
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'dgvpaylist
        '
        Me.dgvpaylist.AllowUserToAddRows = False
        Me.dgvpaylist.AllowUserToDeleteRows = False
        Me.dgvpaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpaylist.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvpaylist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvpaylist.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvpaylist.Location = New System.Drawing.Point(1, 1)
        Me.dgvpaylist.Name = "dgvpaylist"
        Me.dgvpaylist.ReadOnly = True
        Me.dgvpaylist.RowHeadersVisible = False
        Me.dgvpaylist.RowTemplate.Height = 28
        Me.dgvpaylist.Size = New System.Drawing.Size(1216, 132)
        Me.dgvpaylist.TabIndex = 0
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "ລາຍລະອຽດການຈ່າຍ"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 56)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1218, 315)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1212, 309)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.dgvmainlist)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1212, 271)
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
        'dgvmainlist
        '
        Me.dgvmainlist.AllowUserToAddRows = False
        Me.dgvmainlist.AllowUserToDeleteRows = False
        Me.dgvmainlist.AllowUserToResizeColumns = False
        Me.dgvmainlist.AllowUserToResizeRows = False
        Me.dgvmainlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmainlist.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvmainlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvmainlist.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvmainlist.Location = New System.Drawing.Point(1, 1)
        Me.dgvmainlist.Name = "dgvmainlist"
        Me.dgvmainlist.ReadOnly = True
        Me.dgvmainlist.RowHeadersVisible = False
        Me.dgvmainlist.RowTemplate.Height = 28
        Me.dgvmainlist.Size = New System.Drawing.Size(1210, 269)
        Me.dgvmainlist.TabIndex = 0
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "ສັງລວມການຂາຍທັງໜົດ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.GroupPanel2)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1218, 47)
        Me.Panel1.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.AutoCheckOnClick = True
        Me.ButtonX1.AutoExpandOnClick = True
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Smartinventory.My.Resources.Resources.Report
        Me.ButtonX1.Location = New System.Drawing.Point(900, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(141, 38)
        Me.ButtonX1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.reportsumarysale, Me.reportsalebycustomer})
        Me.ButtonX1.SubItemsExpandWidth = 20
        Me.ButtonX1.TabIndex = 22
        Me.ButtonX1.Text = "ລາຍງານ"
        Me.ButtonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'reportsumarysale
        '
        Me.reportsumarysale.GlobalItem = False
        Me.reportsumarysale.ImagePaddingHorizontal = 8
        Me.reportsumarysale.Name = "reportsumarysale"
        Me.reportsumarysale.Text = "ລາຍງານສັງລວມບີນທັງໜົດ"
        '
        'reportsalebycustomer
        '
        Me.reportsalebycustomer.GlobalItem = False
        Me.reportsalebycustomer.ImagePaddingHorizontal = 8
        Me.reportsalebycustomer.Name = "reportsalebycustomer"
        Me.reportsalebycustomer.Text = "ລາຍງານສັງລວມບີນຕາມຊື່ລູກຄ້າ"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.rddolla)
        Me.GroupPanel2.Controls.Add(Me.rdbath)
        Me.GroupPanel2.Controls.Add(Me.rdkip)
        Me.GroupPanel2.Location = New System.Drawing.Point(9, 2)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(199, 41)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 21
        '
        'rddolla
        '
        Me.rddolla.AutoSize = True
        Me.rddolla.BackColor = System.Drawing.Color.Transparent
        Me.rddolla.Location = New System.Drawing.Point(121, 4)
        Me.rddolla.Name = "rddolla"
        Me.rddolla.Size = New System.Drawing.Size(65, 28)
        Me.rddolla.TabIndex = 2
        Me.rddolla.TabStop = True
        Me.rddolla.Text = "ໂດລາ"
        Me.rddolla.UseVisualStyleBackColor = False
        '
        'rdbath
        '
        Me.rdbath.AutoSize = True
        Me.rdbath.BackColor = System.Drawing.Color.Transparent
        Me.rdbath.Location = New System.Drawing.Point(59, 3)
        Me.rdbath.Name = "rdbath"
        Me.rdbath.Size = New System.Drawing.Size(56, 28)
        Me.rdbath.TabIndex = 1
        Me.rdbath.TabStop = True
        Me.rdbath.Text = "ບາດ"
        Me.rdbath.UseVisualStyleBackColor = False
        '
        'rdkip
        '
        Me.rdkip.AutoSize = True
        Me.rdkip.BackColor = System.Drawing.Color.Transparent
        Me.rdkip.Location = New System.Drawing.Point(6, 3)
        Me.rdkip.Name = "rdkip"
        Me.rdkip.Size = New System.Drawing.Size(48, 28)
        Me.rdkip.TabIndex = 0
        Me.rdkip.TabStop = True
        Me.rdkip.Text = "ກີບ"
        Me.rdkip.UseVisualStyleBackColor = False
        '
        'btnshow
        '
        Me.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshow.Image = Global.Smartinventory.My.Resources.Resources.Search
        Me.btnshow.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnshow.Location = New System.Drawing.Point(743, 5)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(139, 38)
        Me.btnshow.TabIndex = 20
        Me.btnshow.Text = "ສະແດງ"
        Me.btnshow.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(281, 6)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(456, 35)
        Me.txtsearch.TabIndex = 19
        '
        'btnclose
        '
        Me.btnclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclose.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnclose.Image = Global.Smartinventory.My.Resources.Resources._1489493744_exit
        Me.btnclose.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnclose.Location = New System.Drawing.Point(1177, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(41, 43)
        Me.btnclose.TabIndex = 14
        '
        'rdcustomer
        '
        Me.rdcustomer.AutoSize = True
        Me.rdcustomer.BackColor = System.Drawing.Color.Transparent
        Me.rdcustomer.Location = New System.Drawing.Point(3, 3)
        Me.rdcustomer.Name = "rdcustomer"
        Me.rdcustomer.Size = New System.Drawing.Size(48, 28)
        Me.rdcustomer.TabIndex = 3
        Me.rdcustomer.TabStop = True
        Me.rdcustomer.Text = "ຜູ້ຊື້"
        Me.rdcustomer.UseVisualStyleBackColor = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rdcustomer)
        Me.GroupPanel1.Location = New System.Drawing.Point(212, 2)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(63, 41)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 6
        '
        'frmsumarysale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmsumarysale"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.dgvbillist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.dgvpaylist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.dgvmainlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents dgvmainlist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnshow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents dgvbillist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents dgvpaylist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rddolla As System.Windows.Forms.RadioButton
    Friend WithEvents rdbath As System.Windows.Forms.RadioButton
    Friend WithEvents rdkip As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents reportsumarysale As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents reportsalebycustomer As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdcustomer As System.Windows.Forms.RadioButton
End Class
