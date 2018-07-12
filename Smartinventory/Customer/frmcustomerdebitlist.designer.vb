<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcustomerdebitlist
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btntransaction = New DevComponents.DotNetBar.ButtonX()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cbstatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnclose = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rdall = New System.Windows.Forms.RadioButton()
        Me.rdcusname = New System.Windows.Forms.RadioButton()
        Me.rdid = New System.Windows.Forms.RadioButton()
        Me.rddate = New System.Windows.Forms.RadioButton()
        Me.btnreport = New DevComponents.DotNetBar.ButtonX()
        Me.btnpaymoney = New DevComponents.DotNetBar.ButtonX()
        Me.btnshow = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dgvshow = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1276, 709)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "ລາຍຊື້ລູກຄ້າຕິດໜີ້"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1270, 678)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btntransaction)
        Me.Panel2.Controls.Add(Me.txtsearch)
        Me.Panel2.Controls.Add(Me.cbstatus)
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.GroupPanel3)
        Me.Panel2.Controls.Add(Me.btnreport)
        Me.Panel2.Controls.Add(Me.btnpaymoney)
        Me.Panel2.Controls.Add(Me.btnshow)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dt2)
        Me.Panel2.Controls.Add(Me.dt1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1262, 52)
        Me.Panel2.TabIndex = 1
        '
        'btntransaction
        '
        Me.btntransaction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btntransaction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btntransaction.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransaction.ForeColor = System.Drawing.Color.Blue
        Me.btntransaction.Image = Global.Smartinventory.My.Resources.Resources.admin_settings1
        Me.btntransaction.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btntransaction.Location = New System.Drawing.Point(813, 4)
        Me.btntransaction.Margin = New System.Windows.Forms.Padding(4)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(130, 40)
        Me.btntransaction.TabIndex = 23
        Me.btntransaction.Text = "ການເຄືອນໄຫວ"
        Me.btntransaction.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(315, 9)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(367, 35)
        Me.txtsearch.TabIndex = 22
        '
        'cbstatus
        '
        Me.cbstatus.DisplayMember = "Text"
        Me.cbstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbstatus.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.ItemHeight = 29
        Me.cbstatus.Location = New System.Drawing.Point(315, 9)
        Me.cbstatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(367, 35)
        Me.cbstatus.TabIndex = 21
        '
        'btnclose
        '
        Me.btnclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclose.Image = Global.Smartinventory.My.Resources.Resources._1489493744_exit
        Me.btnclose.Location = New System.Drawing.Point(1200, 4)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(40, 40)
        Me.btnclose.TabIndex = 20
        Me.btnclose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.rdall)
        Me.GroupPanel3.Controls.Add(Me.rdcusname)
        Me.GroupPanel3.Controls.Add(Me.rdid)
        Me.GroupPanel3.Controls.Add(Me.rddate)
        Me.GroupPanel3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(303, 42)
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
        Me.GroupPanel3.TabIndex = 19
        '
        'rdall
        '
        Me.rdall.AutoSize = True
        Me.rdall.BackColor = System.Drawing.Color.Transparent
        Me.rdall.Location = New System.Drawing.Point(67, 2)
        Me.rdall.Margin = New System.Windows.Forms.Padding(4)
        Me.rdall.Name = "rdall"
        Me.rdall.Size = New System.Drawing.Size(72, 28)
        Me.rdall.TabIndex = 8
        Me.rdall.TabStop = True
        Me.rdall.Text = "ທັງໜົດ"
        Me.rdall.UseVisualStyleBackColor = False
        '
        'rdcusname
        '
        Me.rdcusname.AutoSize = True
        Me.rdcusname.BackColor = System.Drawing.Color.Transparent
        Me.rdcusname.Location = New System.Drawing.Point(212, 3)
        Me.rdcusname.Margin = New System.Windows.Forms.Padding(4)
        Me.rdcusname.Name = "rdcusname"
        Me.rdcusname.Size = New System.Drawing.Size(76, 28)
        Me.rdcusname.TabIndex = 7
        Me.rdcusname.TabStop = True
        Me.rdcusname.Text = "ຊື່ລູກຄ້າ"
        Me.rdcusname.UseVisualStyleBackColor = False
        '
        'rdid
        '
        Me.rdid.AutoSize = True
        Me.rdid.BackColor = System.Drawing.Color.Transparent
        Me.rdid.Location = New System.Drawing.Point(143, 3)
        Me.rdid.Margin = New System.Windows.Forms.Padding(4)
        Me.rdid.Name = "rdid"
        Me.rdid.Size = New System.Drawing.Size(69, 28)
        Me.rdid.TabIndex = 6
        Me.rdid.TabStop = True
        Me.rdid.Text = "ລະຫັດ"
        Me.rdid.UseVisualStyleBackColor = False
        '
        'rddate
        '
        Me.rddate.AutoSize = True
        Me.rddate.BackColor = System.Drawing.Color.Transparent
        Me.rddate.Location = New System.Drawing.Point(4, 2)
        Me.rddate.Margin = New System.Windows.Forms.Padding(4)
        Me.rddate.Name = "rddate"
        Me.rddate.Size = New System.Drawing.Size(59, 28)
        Me.rddate.TabIndex = 4
        Me.rddate.TabStop = True
        Me.rddate.Text = "ວັນທີ"
        Me.rddate.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreport.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.Blue
        Me.btnreport.Image = Global.Smartinventory.My.Resources.Resources.Report
        Me.btnreport.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnreport.Location = New System.Drawing.Point(1072, 4)
        Me.btnreport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(120, 40)
        Me.btnreport.TabIndex = 15
        Me.btnreport.Text = "ລາຍລະອຽດ"
        '
        'btnpaymoney
        '
        Me.btnpaymoney.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnpaymoney.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnpaymoney.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaymoney.ForeColor = System.Drawing.Color.Blue
        Me.btnpaymoney.Image = Global.Smartinventory.My.Resources.Resources.money1
        Me.btnpaymoney.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnpaymoney.Location = New System.Drawing.Point(951, 4)
        Me.btnpaymoney.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpaymoney.Name = "btnpaymoney"
        Me.btnpaymoney.Size = New System.Drawing.Size(113, 40)
        Me.btnpaymoney.TabIndex = 14
        Me.btnpaymoney.Text = "ສຳລະເງີນ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnshow
        '
        Me.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshow.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Image = Global.Smartinventory.My.Resources.Resources.Search
        Me.btnshow.Location = New System.Drawing.Point(690, 4)
        Me.btnshow.Margin = New System.Windows.Forms.Padding(4)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(115, 40)
        Me.btnshow.TabIndex = 13
        Me.btnshow.Text = "ສະແດງ"
        Me.btnshow.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ຫາ"
        '
        'dt2
        '
        Me.dt2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt2.Location = New System.Drawing.Point(490, 9)
        Me.dt2.Margin = New System.Windows.Forms.Padding(4)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(192, 35)
        Me.dt2.TabIndex = 11
        '
        'dt1
        '
        Me.dt1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt1.Location = New System.Drawing.Point(316, 9)
        Me.dt1.Margin = New System.Windows.Forms.Padding(4)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(134, 35)
        Me.dt1.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(4, 64)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1262, 610)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.dgvshow)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1262, 572)
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
        'dgvshow
        '
        Me.dgvshow.AllowUserToAddRows = False
        Me.dgvshow.AllowUserToDeleteRows = False
        Me.dgvshow.AllowUserToResizeColumns = False
        Me.dgvshow.AllowUserToResizeRows = False
        Me.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvshow.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvshow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvshow.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvshow.Location = New System.Drawing.Point(1, 1)
        Me.dgvshow.Name = "dgvshow"
        Me.dgvshow.ReadOnly = True
        Me.dgvshow.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvshow.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvshow.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvshow.RowTemplate.Height = 28
        Me.dgvshow.Size = New System.Drawing.Size(1260, 570)
        Me.dgvshow.TabIndex = 0
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "ລາຍຊື່ລູກຄ້າຕິດໜີ້"
        '
        'frmcustomerdebitlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1276, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmcustomerdebitlist"
        Me.GroupPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnpaymoney As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnshow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents btnreport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdid As System.Windows.Forms.RadioButton
    Friend WithEvents rddate As System.Windows.Forms.RadioButton
    Friend WithEvents rdcusname As System.Windows.Forms.RadioButton
    Friend WithEvents btnclose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents cbstatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents rdall As System.Windows.Forms.RadioButton
    Friend WithEvents dgvshow As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btntransaction As DevComponents.DotNetBar.ButtonX
End Class
