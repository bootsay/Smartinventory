<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrecivelist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rdcustomer = New System.Windows.Forms.RadioButton()
        Me.rid = New System.Windows.Forms.RadioButton()
        Me.rstatus = New System.Windows.Forms.RadioButton()
        Me.rdate = New System.Windows.Forms.RadioButton()
        Me.btnshow = New DevComponents.DotNetBar.ButtonX()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dgvshow = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem5 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.cmsdgvlist = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ລບຂມນToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtshow = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl3 = New DevComponents.DotNetBar.TabControl()
        Me.csmdgvreceive = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel7.SuspendLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsdgvlist.SuspendLayout()
        CType(Me.TabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.csmdgvreceive.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1276, 756)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1276, 718)
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
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(1, 1)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1274, 716)
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
        Me.GroupPanel1.TabIndex = 1
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(1268, 710)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel3.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1262, 704)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbstatus)
        Me.Panel1.Controls.Add(Me.ButtonX4)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.GroupPanel7)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.dt2)
        Me.Panel1.Controls.Add(Me.dt1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 50)
        Me.Panel1.TabIndex = 0
        '
        'cbstatus
        '
        Me.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbstatus.Font = New System.Drawing.Font("Saysettha OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Items.AddRange(New Object() {"ປົກກະຕິ", "ຍົກເລີກ"})
        Me.cbstatus.Location = New System.Drawing.Point(289, 6)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(324, 39)
        Me.cbstatus.TabIndex = 2
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Image = Global.Smartinventory.My.Resources.Resources.list1
        Me.ButtonX4.ImageFixedSize = New System.Drawing.Size(35, 32)
        Me.ButtonX4.Location = New System.Drawing.Point(730, 5)
        Me.ButtonX4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(118, 43)
        Me.ButtonX4.TabIndex = 25
        Me.ButtonX4.Text = "ລາຍລະອຽດ"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Saysettha OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(289, 5)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(324, 41)
        Me.txtsearch.TabIndex = 16
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.Smartinventory.My.Resources.Resources._1489493744_exit
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(852, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(41, 43)
        Me.ButtonX1.TabIndex = 22
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.Controls.Add(Me.rdcustomer)
        Me.GroupPanel7.Controls.Add(Me.rid)
        Me.GroupPanel7.Controls.Add(Me.rstatus)
        Me.GroupPanel7.Controls.Add(Me.rdate)
        Me.GroupPanel7.Location = New System.Drawing.Point(0, 3)
        Me.GroupPanel7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupPanel7.Name = "GroupPanel7"
        Me.GroupPanel7.Size = New System.Drawing.Size(283, 44)
        '
        '
        '
        Me.GroupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel7.TabIndex = 13
        '
        'rdcustomer
        '
        Me.rdcustomer.AutoSize = True
        Me.rdcustomer.BackColor = System.Drawing.Color.Transparent
        Me.rdcustomer.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdcustomer.Location = New System.Drawing.Point(212, 5)
        Me.rdcustomer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdcustomer.Name = "rdcustomer"
        Me.rdcustomer.Size = New System.Drawing.Size(66, 28)
        Me.rdcustomer.TabIndex = 7
        Me.rdcustomer.TabStop = True
        Me.rdcustomer.Text = "ລູກຄ້າ"
        Me.rdcustomer.UseVisualStyleBackColor = False
        '
        'rid
        '
        Me.rid.AutoSize = True
        Me.rid.BackColor = System.Drawing.Color.Transparent
        Me.rid.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rid.Location = New System.Drawing.Point(59, 5)
        Me.rid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rid.Name = "rid"
        Me.rid.Size = New System.Drawing.Size(65, 28)
        Me.rid.TabIndex = 6
        Me.rid.TabStop = True
        Me.rid.Text = "ເລກທີ"
        Me.rid.UseVisualStyleBackColor = False
        '
        'rstatus
        '
        Me.rstatus.AutoSize = True
        Me.rstatus.BackColor = System.Drawing.Color.Transparent
        Me.rstatus.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rstatus.Location = New System.Drawing.Point(126, 5)
        Me.rstatus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rstatus.Name = "rstatus"
        Me.rstatus.Size = New System.Drawing.Size(84, 28)
        Me.rstatus.TabIndex = 5
        Me.rstatus.TabStop = True
        Me.rstatus.Text = "ສະຖານະ"
        Me.rstatus.UseVisualStyleBackColor = False
        '
        'rdate
        '
        Me.rdate.AutoSize = True
        Me.rdate.BackColor = System.Drawing.Color.Transparent
        Me.rdate.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdate.Location = New System.Drawing.Point(2, 5)
        Me.rdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdate.Name = "rdate"
        Me.rdate.Size = New System.Drawing.Size(59, 28)
        Me.rdate.TabIndex = 4
        Me.rdate.TabStop = True
        Me.rdate.Text = "ວັນທີ"
        Me.rdate.UseVisualStyleBackColor = False
        '
        'btnshow
        '
        Me.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshow.Image = Global.Smartinventory.My.Resources.Resources.Search
        Me.btnshow.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnshow.Location = New System.Drawing.Point(616, 4)
        Me.btnshow.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(110, 43)
        Me.btnshow.TabIndex = 6
        Me.btnshow.Text = "ສະແດງ"
        '
        'dt2
        '
        Me.dt2.Font = New System.Drawing.Font("Saysettha OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt2.Location = New System.Drawing.Point(490, 5)
        Me.dt2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(123, 41)
        Me.dt2.TabIndex = 4
        '
        'dt1
        '
        Me.dt1.Font = New System.Drawing.Font("Saysettha OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt1.Location = New System.Drawing.Point(289, 5)
        Me.dt1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(161, 41)
        Me.dt1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(454, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ຫາ"
        '
        'TabControl2
        '
        Me.TabControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl2.CanReorderTabs = True
        Me.TabControl2.Controls.Add(Me.TabControlPanel4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(4, 59)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1254, 642)
        Me.TabControl2.TabIndex = 1
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem4)
        Me.TabControl2.Text = "TabControl2"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.dgvshow)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 37)
        Me.TabControlPanel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(1254, 605)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 1
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'dgvshow
        '
        Me.dgvshow.AllowUserToAddRows = False
        Me.dgvshow.AllowUserToDeleteRows = False
        Me.dgvshow.AllowUserToResizeColumns = False
        Me.dgvshow.AllowUserToResizeRows = False
        Me.dgvshow.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvshow.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvshow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvshow.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvshow.Location = New System.Drawing.Point(1, 1)
        Me.dgvshow.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvshow.Name = "dgvshow"
        Me.dgvshow.ReadOnly = True
        Me.dgvshow.RowHeadersVisible = False
        Me.dgvshow.RowTemplate.Height = 28
        Me.dgvshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvshow.Size = New System.Drawing.Size(1252, 603)
        Me.dgvshow.TabIndex = 0
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        Me.TabItem4.Text = "ລາຍການສັ່ງຊື້"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "ລາຍການສັ່ງຊື້    ."
        '
        'TabItem3
        '
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "ຮັບສີນຄ້າເຂົ້າສາງ   ."
        '
        'TabItem2
        '
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "ສ້າງໃບສັ່ງຊື້     ."
        '
        'TabItem5
        '
        Me.TabItem5.AttachedControl = Me.TabControlPanel5
        Me.TabItem5.Name = "TabItem5"
        Me.TabItem5.Text = "ລາຍລະອຽດການສັ່ງຊື້"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(1374, 274)
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabIndex = 1
        Me.TabControlPanel5.TabItem = Me.TabItem5
        '
        'cmsdgvlist
        '
        Me.cmsdgvlist.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsdgvlist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ລບຂມນToolStripMenuItem})
        Me.cmsdgvlist.Name = "ContextMenuStrip1"
        Me.cmsdgvlist.Size = New System.Drawing.Size(131, 32)
        '
        'ລບຂມນToolStripMenuItem
        '
        Me.ລບຂມນToolStripMenuItem.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ລບຂມນToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ລບຂມນToolStripMenuItem.Name = "ລບຂມນToolStripMenuItem"
        Me.ລບຂມນToolStripMenuItem.Size = New System.Drawing.Size(130, 28)
        Me.ລບຂມນToolStripMenuItem.Text = "ລິບຂໍ້ມູນ"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label8.Location = New System.Drawing.Point(1210, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 24)
        Me.Label8.TabIndex = 2
        '
        'txtshow
        '
        Me.txtshow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtshow.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtshow.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshow.ForeColor = System.Drawing.Color.Red
        Me.txtshow.Location = New System.Drawing.Point(1298, 3)
        Me.txtshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtshow.Name = "txtshow"
        Me.txtshow.Size = New System.Drawing.Size(41, 29)
        Me.txtshow.TabIndex = 3
        Me.txtshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(1339, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 24)
        Me.Label6.TabIndex = 5
        '
        'TabControl3
        '
        Me.TabControl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl3.CanReorderTabs = True
        Me.TabControl3.Controls.Add(Me.TabControlPanel5)
        Me.TabControl3.Controls.Add(Me.Label6)
        Me.TabControl3.Controls.Add(Me.txtshow)
        Me.TabControl3.Controls.Add(Me.Label8)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(4, 478)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedTabFont = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.SelectedTabIndex = -1
        Me.TabControl3.Size = New System.Drawing.Size(1374, 300)
        Me.TabControl3.TabIndex = 2
        Me.TabControl3.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        '
        'csmdgvreceive
        '
        Me.csmdgvreceive.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.csmdgvreceive.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.csmdgvreceive.Name = "ContextMenuStrip1"
        Me.csmdgvreceive.Size = New System.Drawing.Size(131, 32)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 28)
        Me.ToolStripMenuItem1.Text = "ລິບຂໍ້ມູນ"
        '
        'frmrecivelist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 756)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmrecivelist"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel7.ResumeLayout(False)
        Me.GroupPanel7.PerformLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsdgvlist.ResumeLayout(False)
        CType(Me.TabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.TabControl3.PerformLayout()
        Me.csmdgvreceive.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmsdgvlist As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ລບຂມນToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Private WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Private WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Private WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Private WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents TabItem5 As DevComponents.DotNetBar.TabItem
    Private WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Private WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtsearch As TextBox
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rid As RadioButton
    Friend WithEvents rstatus As RadioButton
    Friend WithEvents rdate As RadioButton
    Private WithEvents btnshow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dt2 As DateTimePicker
    Friend WithEvents dt1 As DateTimePicker
    Friend WithEvents cbstatus As ComboBox
    Friend WithEvents Label1 As Label
    Private WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Private WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents dgvshow As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Private WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtshow As Label
    Friend WithEvents Label6 As Label
    Private WithEvents TabControl3 As DevComponents.DotNetBar.TabControl
    Friend WithEvents csmdgvreceive As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rdcustomer As System.Windows.Forms.RadioButton
End Class
