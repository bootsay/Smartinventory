<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreturnproduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreturnproduct))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvreturn = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtadd = New DevComponents.DotNetBar.ButtonX()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtget = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnbrwown = New DevComponents.DotNetBar.ButtonX()
        Me.txtproduct = New System.Windows.Forms.TextBox()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnsave = New DevComponents.DotNetBar.ButtonX()
        Me.btnnew = New DevComponents.DotNetBar.ButtonX()
        Me.btnedit = New DevComponents.DotNetBar.ButtonX()
        Me.btnupdate = New DevComponents.DotNetBar.ButtonX()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsupname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnbrown = New DevComponents.DotNetBar.ButtonX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtproblem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtorderNO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnreceive = New DevComponents.DotNetBar.ButtonX()
        Me.btncancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnclear = New DevComponents.DotNetBar.ButtonX()
        Me.btnminus = New DevComponents.DotNetBar.ButtonX()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttotallast = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ລບToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvreturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvreturn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1206, 662)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvreturn
        '
        Me.dgvreturn.AllowDrop = True
        Me.dgvreturn.AllowUserToAddRows = False
        Me.dgvreturn.AllowUserToDeleteRows = False
        Me.dgvreturn.AllowUserToResizeColumns = False
        Me.dgvreturn.AllowUserToResizeRows = False
        Me.dgvreturn.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvreturn.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvreturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvreturn.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvreturn.Location = New System.Drawing.Point(3, 210)
        Me.dgvreturn.Name = "dgvreturn"
        Me.dgvreturn.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvreturn.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvreturn.RowTemplate.Height = 28
        Me.dgvreturn.Size = New System.Drawing.Size(1200, 331)
        Me.dgvreturn.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtadd)
        Me.Panel1.Controls.Add(Me.txtamount)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtget)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtnote)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnbrwown)
        Me.Panel1.Controls.Add(Me.txtproduct)
        Me.Panel1.Controls.Add(Me.GroupPanel3)
        Me.Panel1.Controls.Add(Me.dt1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtsupname)
        Me.Panel1.Controls.Add(Me.btnbrown)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtproblem)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtorderNO)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 201)
        Me.Panel1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(512, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 24)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "ກີບ"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX1.Location = New System.Drawing.Point(910, 41)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(54, 35)
        Me.ButtonX1.TabIndex = 34
        Me.ButtonX1.Text = "..."
        '
        'txtqty
        '
        Me.txtqty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtqty.Location = New System.Drawing.Point(652, 151)
        Me.txtqty.Multiline = True
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(112, 44)
        Me.txtqty.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(588, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 24)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "ຈໍານວນ:"
        '
        'txtadd
        '
        Me.txtadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.txtadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.txtadd.Image = Global.Smartinventory.My.Resources.Resources.Ok
        Me.txtadd.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.txtadd.Location = New System.Drawing.Point(767, 152)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(139, 45)
        Me.txtadd.TabIndex = 11
        Me.txtadd.Text = "ເພີ້ມລາຍການ"
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtamount.Location = New System.Drawing.Point(107, 151)
        Me.txtamount.Multiline = True
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(405, 44)
        Me.txtamount.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "ຄ່າສ້ອມແປງ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(592, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 24)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "ວັນທີສົ່ງເຄື່ອງ:"
        '
        'dtget
        '
        Me.dtget.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtget.Location = New System.Drawing.Point(694, 3)
        Me.dtget.Name = "dtget"
        Me.dtget.Size = New System.Drawing.Size(212, 35)
        Me.dtget.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 24)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "ໜາຍເຫດ:"
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(107, 114)
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(799, 35)
        Me.txtnote.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ຊື່ສີນຄ້າ:"
        '
        'btnbrwown
        '
        Me.btnbrwown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrwown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrwown.Image = Global.Smartinventory.My.Resources.Resources.Search
        Me.btnbrwown.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrwown.Location = New System.Drawing.Point(583, 41)
        Me.btnbrwown.Name = "btnbrwown"
        Me.btnbrwown.Size = New System.Drawing.Size(54, 35)
        Me.btnbrwown.TabIndex = 4
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(107, 41)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(473, 35)
        Me.txtproduct.TabIndex = 3
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
        Me.GroupPanel3.Size = New System.Drawing.Size(224, 109)
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(212, 100)
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
        Me.btnsave.TabIndex = 0
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
        Me.btnnew.TabIndex = 1
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
        Me.btnedit.TabIndex = 2
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
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'dt1
        '
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt1.Location = New System.Drawing.Point(405, 3)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(175, 35)
        Me.dt1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(306, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ວັນທີອອກບີນ:"
        '
        'txtsupname
        '
        '
        '
        '
        Me.txtsupname.Border.Class = "TextBoxBorder"
        Me.txtsupname.Location = New System.Drawing.Point(694, 40)
        Me.txtsupname.Name = "txtsupname"
        Me.txtsupname.ReadOnly = True
        Me.txtsupname.Size = New System.Drawing.Size(151, 35)
        Me.txtsupname.TabIndex = 5
        Me.txtsupname.WatermarkText = "ລູກຄ້າ"
        '
        'btnbrown
        '
        Me.btnbrown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown.Image = Global.Smartinventory.My.Resources.Resources.folder_customer_icon1
        Me.btnbrown.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown.Location = New System.Drawing.Point(851, 40)
        Me.btnbrown.Name = "btnbrown"
        Me.btnbrown.Size = New System.Drawing.Size(54, 35)
        Me.btnbrown.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ບັນຫາ:"
        '
        'txtproblem
        '
        Me.txtproblem.Location = New System.Drawing.Point(107, 77)
        Me.txtproblem.Name = "txtproblem"
        Me.txtproblem.Size = New System.Drawing.Size(799, 35)
        Me.txtproblem.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(640, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ລູກຄ້າ:"
        '
        'txtorderNO
        '
        Me.txtorderNO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtorderNO.Location = New System.Drawing.Point(107, 3)
        Me.txtorderNO.Name = "txtorderNO"
        Me.txtorderNO.ReadOnly = True
        Me.txtorderNO.Size = New System.Drawing.Size(194, 35)
        Me.txtorderNO.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ລະຫັດ:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnreceive)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btnminus)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Controls.Add(Me.txttotallast)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 547)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 112)
        Me.Panel2.TabIndex = 2
        '
        'btnreceive
        '
        Me.btnreceive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreceive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreceive.Image = Global.Smartinventory.My.Resources.Resources.Ok
        Me.btnreceive.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnreceive.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnreceive.Location = New System.Drawing.Point(330, 48)
        Me.btnreceive.Name = "btnreceive"
        Me.btnreceive.Size = New System.Drawing.Size(98, 59)
        Me.btnreceive.TabIndex = 30
        Me.btnreceive.Text = "ຮັບສີນຄ້າ"
        '
        'btncancel
        '
        Me.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncancel.Image = Global.Smartinventory.My.Resources.Resources.edit_delete_icon
        Me.btncancel.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btncancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btncancel.Location = New System.Drawing.Point(226, 48)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(98, 59)
        Me.btncancel.TabIndex = 29
        Me.btncancel.Text = "ຍົກເລີກ"
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
        Me.btnminus.Location = New System.Drawing.Point(145, 3)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(98, 40)
        Me.btnminus.TabIndex = 26
        Me.btnminus.Text = "ລົບ"
        '
        'btnprint
        '
        Me.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnprint.Image = Global.Smartinventory.My.Resources.Resources.print_and_save
        Me.btnprint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnprint.Location = New System.Drawing.Point(4, 48)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(216, 59)
        Me.btnprint.TabIndex = 19
        Me.btnprint.Text = "ພິມບີນ"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(817, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ລວມສຸດທິ:"
        '
        'txttotallast
        '
        Me.txttotallast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotallast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotallast.Font = New System.Drawing.Font("Saysettha OT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttotallast.Location = New System.Drawing.Point(889, 3)
        Me.txttotallast.Name = "txttotallast"
        Me.txttotallast.ReadOnly = True
        Me.txttotallast.Size = New System.Drawing.Size(308, 42)
        Me.txttotallast.TabIndex = 16
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ລບToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 32)
        Me.ContextMenuStrip1.Text = "ລືບ"
        '
        'ລບToolStripMenuItem
        '
        Me.ລບToolStripMenuItem.Name = "ລບToolStripMenuItem"
        Me.ລບToolStripMenuItem.Size = New System.Drawing.Size(100, 28)
        Me.ລບToolStripMenuItem.Text = "ລືບ"
        '
        'frmreturnproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1206, 662)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(1024, 700)
        Me.Name = "frmreturnproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ໃບຊ້ອມແປງສີນຄ້າ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvreturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvreturn As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtorderNO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtproblem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnbrown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txttotallast As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsupname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ລບToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnnew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnminus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnclear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnedit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnupdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btncancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnbrwown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtproduct As System.Windows.Forms.TextBox
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtget As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtadd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btnreceive As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
