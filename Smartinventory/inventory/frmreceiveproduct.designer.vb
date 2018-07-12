<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreceiveproduct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreceiveproduct))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvreceive = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.DateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbarcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.productbrowse = New DevComponents.DotNetBar.ButtonX()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtproname = New System.Windows.Forms.TextBox()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtreceivename = New System.Windows.Forms.TextBox()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnsave = New DevComponents.DotNetBar.ButtonX()
        Me.btnnew = New DevComponents.DotNetBar.ButtonX()
        Me.btnedit = New DevComponents.DotNetBar.ButtonX()
        Me.btnupdate = New DevComponents.DotNetBar.ButtonX()
        Me.dtsale = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsupname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnbrown = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rdmanualbill = New System.Windows.Forms.RadioButton()
        Me.rdorderbill = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rddolla = New System.Windows.Forms.RadioButton()
        Me.rdbath = New System.Windows.Forms.RadioButton()
        Me.rdkip = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnfree = New DevComponents.DotNetBar.ButtonX()
        Me.btncancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnclear = New DevComponents.DotNetBar.ButtonX()
        Me.btnminus = New DevComponents.DotNetBar.ButtonX()
        Me.btnadd = New DevComponents.DotNetBar.ButtonX()
        Me.btnreceive = New DevComponents.DotNetBar.ButtonX()
        Me.cbapprove = New System.Windows.Forms.CheckBox()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttotallast = New System.Windows.Forms.TextBox()
        Me.btnshowtax = New DevComponents.DotNetBar.ButtonX()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbtax = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvreceive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvreceive, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1206, 662)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvreceive
        '
        Me.dgvreceive.AllowDrop = True
        Me.dgvreceive.AllowUserToAddRows = False
        Me.dgvreceive.AllowUserToDeleteRows = False
        Me.dgvreceive.AllowUserToResizeColumns = False
        Me.dgvreceive.AllowUserToResizeRows = False
        Me.dgvreceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvreceive.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvreceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvreceive.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvreceive.Location = New System.Drawing.Point(3, 135)
        Me.dgvreceive.Name = "dgvreceive"
        Me.dgvreceive.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvreceive.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvreceive.RowTemplate.Height = 28
        Me.dgvreceive.Size = New System.Drawing.Size(1200, 416)
        Me.dgvreceive.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.DateTimeInput1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtbarcode)
        Me.Panel1.Controls.Add(Me.productbrowse)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtproname)
        Me.Panel1.Controls.Add(Me.txtbillno)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtreceivename)
        Me.Panel1.Controls.Add(Me.GroupPanel3)
        Me.Panel1.Controls.Add(Me.dtsale)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtsupname)
        Me.Panel1.Controls.Add(Me.btnbrown)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.GroupPanel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 126)
        Me.Panel1.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX1.Location = New System.Drawing.Point(909, 41)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(55, 35)
        Me.ButtonX1.TabIndex = 37
        Me.ButtonX1.Text = "..."
        '
        'DateTimeInput1
        '
        '
        '
        '
        Me.DateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput1.ButtonDropDown.Visible = True
        Me.DateTimeInput1.Font = New System.Drawing.Font("Saysettha OT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimeInput1.Location = New System.Drawing.Point(688, 116)
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput1.MonthCalendar.DisplayMonth = New Date(2017, 12, 1, 0, 0, 0, 0)
        Me.DateTimeInput1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimeInput1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput1.Name = "DateTimeInput1"
        Me.DateTimeInput1.Size = New System.Drawing.Size(216, 44)
        Me.DateTimeInput1.TabIndex = 36
        Me.DateTimeInput1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(584, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ວັນໜົດປະກັນ:"
        Me.Label4.Visible = False
        '
        'txtbarcode
        '
        '
        '
        '
        Me.txtbarcode.Border.Class = "TextBoxBorder"
        Me.txtbarcode.FocusHighlightEnabled = True
        Me.txtbarcode.Font = New System.Drawing.Font("Saysettha OT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtbarcode.Location = New System.Drawing.Point(69, 116)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(515, 44)
        Me.txtbarcode.TabIndex = 34
        Me.txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbarcode.Visible = False
        Me.txtbarcode.WatermarkFont = New System.Drawing.Font("Saysettha OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtbarcode.WatermarkText = "ລະຫັດສີນຄ້າ/ບາໂຄດ/ເລກ Serial"
        '
        'productbrowse
        '
        Me.productbrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.productbrowse.AllowDrop = True
        Me.productbrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.productbrowse.Image = Global.Smartinventory.My.Resources.Resources.Search1
        Me.productbrowse.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.productbrowse.Location = New System.Drawing.Point(909, 79)
        Me.productbrowse.Name = "productbrowse"
        Me.productbrowse.Size = New System.Drawing.Size(55, 35)
        Me.productbrowse.TabIndex = 33
        Me.productbrowse.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 24)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "ຊື່ສີນຄ້າ:"
        Me.Label15.Visible = False
        '
        'txtproname
        '
        Me.txtproname.Location = New System.Drawing.Point(69, 78)
        Me.txtproname.Name = "txtproname"
        Me.txtproname.ReadOnly = True
        Me.txtproname.Size = New System.Drawing.Size(835, 35)
        Me.txtproname.TabIndex = 31
        Me.txtproname.Visible = False
        '
        'txtbillno
        '
        Me.txtbillno.Location = New System.Drawing.Point(371, 42)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(211, 35)
        Me.txtbillno.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(305, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 24)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "ເລກບີນ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(584, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ຮັບຈາກ:"
        '
        'txtreceivename
        '
        Me.txtreceivename.Location = New System.Drawing.Point(69, 40)
        Me.txtreceivename.Name = "txtreceivename"
        Me.txtreceivename.ReadOnly = True
        Me.txtreceivename.Size = New System.Drawing.Size(232, 35)
        Me.txtreceivename.TabIndex = 23
        '
        'GroupPanel3
        '
        Me.GroupPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupPanel3.Location = New System.Drawing.Point(970, 3)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(224, 122)
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
        Me.GroupPanel3.TabIndex = 22
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnsave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnnew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnedit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnupdate)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(212, 107)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnsave
        '
        Me.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsave.Image = Global.Smartinventory.My.Resources.Resources.Save_icon
        Me.btnsave.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnsave.Location = New System.Drawing.Point(3, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(95, 45)
        Me.btnsave.TabIndex = 26
        Me.btnsave.Text = "ບັນທືກ"
        '
        'btnnew
        '
        Me.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnnew.Image = Global.Smartinventory.My.Resources.Resources.New_file
        Me.btnnew.Location = New System.Drawing.Point(104, 3)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(103, 45)
        Me.btnnew.TabIndex = 25
        Me.btnnew.Text = "ສ້າງໄຫມ່"
        '
        'btnedit
        '
        Me.btnedit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnedit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnedit.Image = Global.Smartinventory.My.Resources.Resources.Edit_page
        Me.btnedit.Location = New System.Drawing.Point(3, 54)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(95, 45)
        Me.btnedit.TabIndex = 27
        Me.btnedit.Text = "ແກ້ໄຂ"
        '
        'btnupdate
        '
        Me.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnupdate.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnupdate.Location = New System.Drawing.Point(104, 54)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(103, 45)
        Me.btnupdate.TabIndex = 28
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'dtsale
        '
        Me.dtsale.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtsale.Location = New System.Drawing.Point(648, 3)
        Me.dtsale.Name = "dtsale"
        Me.dtsale.Size = New System.Drawing.Size(110, 35)
        Me.dtsale.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(584, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ວັນທີ:"
        '
        'txtsupname
        '
        '
        '
        '
        Me.txtsupname.Border.Class = "TextBoxBorder"
        Me.txtsupname.Location = New System.Drawing.Point(648, 41)
        Me.txtsupname.Name = "txtsupname"
        Me.txtsupname.ReadOnly = True
        Me.txtsupname.Size = New System.Drawing.Size(190, 35)
        Me.txtsupname.TabIndex = 19
        Me.txtsupname.WatermarkText = "ເລືອກຜູ້ສະໜອງສີນຄ້າ"
        '
        'btnbrown
        '
        Me.btnbrown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown.Image = Global.Smartinventory.My.Resources.Resources.folder_customer_icon1
        Me.btnbrown.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown.Location = New System.Drawing.Point(844, 40)
        Me.btnbrown.Name = "btnbrown"
        Me.btnbrown.Size = New System.Drawing.Size(57, 35)
        Me.btnbrown.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ຜູ້ຮັບ:"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(69, 3)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(232, 35)
        Me.txtid.TabIndex = 9
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.rdmanualbill)
        Me.GroupPanel2.Controls.Add(Me.rdorderbill)
        Me.GroupPanel2.Location = New System.Drawing.Point(305, 3)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(279, 35)
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
        Me.GroupPanel2.TabIndex = 8
        '
        'rdmanualbill
        '
        Me.rdmanualbill.AutoSize = True
        Me.rdmanualbill.BackColor = System.Drawing.Color.Transparent
        Me.rdmanualbill.Location = New System.Drawing.Point(131, -1)
        Me.rdmanualbill.Name = "rdmanualbill"
        Me.rdmanualbill.Size = New System.Drawing.Size(96, 28)
        Me.rdmanualbill.TabIndex = 2
        Me.rdmanualbill.TabStop = True
        Me.rdmanualbill.Text = "ຮັບຈາກບີນ"
        Me.rdmanualbill.UseVisualStyleBackColor = False
        Me.rdmanualbill.Visible = False
        '
        'rdorderbill
        '
        Me.rdorderbill.AutoSize = True
        Me.rdorderbill.BackColor = System.Drawing.Color.Transparent
        Me.rdorderbill.Location = New System.Drawing.Point(3, 1)
        Me.rdorderbill.Name = "rdorderbill"
        Me.rdorderbill.Size = New System.Drawing.Size(122, 28)
        Me.rdorderbill.TabIndex = 1
        Me.rdorderbill.TabStop = True
        Me.rdorderbill.Text = "ຮັບຈາກໃບສັ່ງຊື້"
        Me.rdorderbill.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ລະຫັດ:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rddolla)
        Me.GroupPanel1.Controls.Add(Me.rdbath)
        Me.GroupPanel1.Controls.Add(Me.rdkip)
        Me.GroupPanel1.Location = New System.Drawing.Point(763, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(201, 35)
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
        'rddolla
        '
        Me.rddolla.AutoSize = True
        Me.rddolla.BackColor = System.Drawing.Color.Transparent
        Me.rddolla.Location = New System.Drawing.Point(136, 1)
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
        Me.rdbath.Location = New System.Drawing.Point(74, 1)
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
        Me.rdkip.Location = New System.Drawing.Point(10, 1)
        Me.rdkip.Name = "rdkip"
        Me.rdkip.Size = New System.Drawing.Size(48, 28)
        Me.rdkip.TabIndex = 0
        Me.rdkip.TabStop = True
        Me.rdkip.Text = "ກີບ"
        Me.rdkip.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txttax)
        Me.Panel2.Controls.Add(Me.btnfree)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btnminus)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.btnreceive)
        Me.Panel2.Controls.Add(Me.cbapprove)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txttotallast)
        Me.Panel2.Controls.Add(Me.btnshowtax)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cbtax)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtdiscount)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 559)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 100)
        Me.Panel2.TabIndex = 2
        '
        'btnfree
        '
        Me.btnfree.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnfree.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnfree.Image = Global.Smartinventory.My.Resources.Resources.shopping_cart
        Me.btnfree.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnfree.Location = New System.Drawing.Point(360, 3)
        Me.btnfree.Name = "btnfree"
        Me.btnfree.Size = New System.Drawing.Size(109, 40)
        Me.btnfree.TabIndex = 29
        Me.btnfree.Text = "ແຖມ"
        '
        'btncancel
        '
        Me.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncancel.Image = Global.Smartinventory.My.Resources.Resources.edit_delete_icon
        Me.btncancel.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btncancel.Location = New System.Drawing.Point(360, 47)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(109, 45)
        Me.btncancel.TabIndex = 28
        Me.btncancel.Text = "ຍົກເລີກ"
        Me.btncancel.Visible = False
        '
        'btnclear
        '
        Me.btnclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclear.Image = Global.Smartinventory.My.Resources.Resources.Clear
        Me.btnclear.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnclear.Location = New System.Drawing.Point(3, 3)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(136, 40)
        Me.btnclear.TabIndex = 27
        Me.btnclear.Text = "ລ້າງລາຍການ"
        '
        'btnminus
        '
        Me.btnminus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnminus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnminus.Image = Global.Smartinventory.My.Resources.Resources.Cancel
        Me.btnminus.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnminus.Location = New System.Drawing.Point(245, 3)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(109, 40)
        Me.btnminus.TabIndex = 26
        Me.btnminus.Text = "ລົບ"
        '
        'btnadd
        '
        Me.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnadd.Image = Global.Smartinventory.My.Resources.Resources.Create
        Me.btnadd.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnadd.Location = New System.Drawing.Point(145, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(94, 40)
        Me.btnadd.TabIndex = 25
        Me.btnadd.Text = "ເພີ້ມ"
        '
        'btnreceive
        '
        Me.btnreceive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreceive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreceive.Image = Global.Smartinventory.My.Resources.Resources.Ok
        Me.btnreceive.Location = New System.Drawing.Point(245, 47)
        Me.btnreceive.Name = "btnreceive"
        Me.btnreceive.Size = New System.Drawing.Size(109, 45)
        Me.btnreceive.TabIndex = 21
        Me.btnreceive.Text = "ຮັບສີນຄ້າ"
        '
        'cbapprove
        '
        Me.cbapprove.AutoSize = True
        Me.cbapprove.Location = New System.Drawing.Point(11, 59)
        Me.cbapprove.Name = "cbapprove"
        Me.cbapprove.Size = New System.Drawing.Size(87, 28)
        Me.cbapprove.TabIndex = 20
        Me.cbapprove.Text = "ຮັບສີນຄ້າ"
        Me.cbapprove.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnprint.Image = Global.Smartinventory.My.Resources.Resources.print_and_save
        Me.btnprint.Location = New System.Drawing.Point(145, 47)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(94, 45)
        Me.btnprint.TabIndex = 19
        Me.btnprint.Text = "ພິມບີນ"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(829, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ລວມສຸດທິ:"
        '
        'txttotallast
        '
        Me.txttotallast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotallast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotallast.Location = New System.Drawing.Point(915, 43)
        Me.txttotallast.Name = "txttotallast"
        Me.txttotallast.ReadOnly = True
        Me.txttotallast.Size = New System.Drawing.Size(276, 35)
        Me.txttotallast.TabIndex = 16
        Me.txttotallast.Text = "0"
        '
        'btnshowtax
        '
        Me.btnshowtax.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshowtax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnshowtax.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshowtax.Image = Global.Smartinventory.My.Resources.Resources.Create
        Me.btnshowtax.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnshowtax.Location = New System.Drawing.Point(778, 41)
        Me.btnshowtax.Name = "btnshowtax"
        Me.btnshowtax.Size = New System.Drawing.Size(50, 35)
        Me.btnshowtax.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(484, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "ອາກອນ:"
        '
        'cbtax
        '
        Me.cbtax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbtax.DisplayMember = "Text"
        Me.cbtax.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbtax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtax.FormattingEnabled = True
        Me.cbtax.ItemHeight = 29
        Me.cbtax.Location = New System.Drawing.Point(552, 42)
        Me.cbtax.Name = "cbtax"
        Me.cbtax.Size = New System.Drawing.Size(224, 35)
        Me.cbtax.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(847, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "ລຸດ:"
        '
        'txtdiscount
        '
        Me.txtdiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtdiscount.Location = New System.Drawing.Point(915, 5)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(276, 35)
        Me.txtdiscount.TabIndex = 8
        Me.txtdiscount.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(484, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ລວມ:"
        '
        'txttotal
        '
        Me.txttotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotal.Location = New System.Drawing.Point(552, 5)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(224, 35)
        Me.txttotal.TabIndex = 0
        Me.txttotal.Text = "0"
        '
        'txttax
        '
        Me.txttax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttax.Location = New System.Drawing.Point(782, 5)
        Me.txttax.Name = "txttax"
        Me.txttax.ReadOnly = True
        Me.txttax.Size = New System.Drawing.Size(114, 35)
        Me.txttax.TabIndex = 30
        Me.txttax.Text = "0"
        '
        'frmreceiveproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1206, 662)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(1024, 700)
        Me.Name = "frmreceiveproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ຮັບສີນຄ້າເຂົ້າສາງ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvreceive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvreceive As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rddolla As System.Windows.Forms.RadioButton
    Friend WithEvents rdbath As System.Windows.Forms.RadioButton
    Friend WithEvents rdkip As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnbrown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbtax As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnshowtax As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsupname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbapprove As System.Windows.Forms.CheckBox
    Friend WithEvents btnreceive As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtsale As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnnew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnadd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnminus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnclear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnedit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnupdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtreceivename As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdmanualbill As System.Windows.Forms.RadioButton
    Friend WithEvents rdorderbill As System.Windows.Forms.RadioButton
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents productbrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtproname As System.Windows.Forms.TextBox
    Friend WithEvents txtbarcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btncancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnfree As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txttotallast As System.Windows.Forms.TextBox
    Friend WithEvents txttax As TextBox
End Class
