<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcustomer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnsave = New System.Windows.Forms.ToolStripButton()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.btnupdate = New System.Windows.Forms.ToolStripButton()
        Me.btnedit = New System.Windows.Forms.ToolStripButton()
        Me.btnnew = New System.Windows.Forms.ToolStripButton()
        Me.btnclose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnprovince = New System.Windows.Forms.ToolStripButton()
        Me.btndistrict = New System.Windows.Forms.ToolStripButton()
        Me.btnban = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnadd = New DevComponents.DotNetBar.ButtonX()
        Me.cbtype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbvillage = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbdistrict = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbprovience = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtcount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtfax = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.txtcontactname = New System.Windows.Forms.TextBox()
        Me.txtcomname = New System.Windows.Forms.TextBox()
        Me.dgvcustomer = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1008, 605)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "ເພີ້ມລູກຄ້າ / ຮ້ານຄ້າ"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvcustomer, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1002, 574)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(10, 10)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnsave, Me.btndelete, Me.btnupdate, Me.btnedit, Me.btnnew, Me.btnclose, Me.ToolStripSeparator1, Me.btnprovince, Me.btndistrict, Me.btnban})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1002, 55)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.Smartinventory.My.Resources.Resources.Save
        Me.btnsave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsave.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 55)
        Me.btnsave.Text = "ບັນທືກ"
        '
        'btndelete
        '
        Me.btndelete.Image = Global.Smartinventory.My.Resources.Resources.Delete
        Me.btndelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(66, 52)
        Me.btndelete.Text = "ລືບ"
        '
        'btnupdate
        '
        Me.btnupdate.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnupdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(84, 52)
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.Smartinventory.My.Resources.Resources.Edit_page
        Me.btnedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnedit.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(84, 52)
        Me.btnedit.Text = "ແກ້ໄຂ"
        '
        'btnnew
        '
        Me.btnnew.Image = Global.Smartinventory.My.Resources.Resources.New_file
        Me.btnnew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnew.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(102, 52)
        Me.btnnew.Text = "ເພີ້ມໃຫ່ມ"
        '
        'btnclose
        '
        Me.btnclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnclose.Image = Global.Smartinventory.My.Resources.Resources._1489493744_exit
        Me.btnclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(66, 52)
        Me.btnclose.Text = "ປິດ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'btnprovince
        '
        Me.btnprovince.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnprovince.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnprovince.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnprovince.Name = "btnprovince"
        Me.btnprovince.Size = New System.Drawing.Size(78, 52)
        Me.btnprovince.Text = "ເພີ້ມແຂວງ"
        '
        'btndistrict
        '
        Me.btndistrict.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btndistrict.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndistrict.Image = CType(resources.GetObject("btndistrict.Image"), System.Drawing.Image)
        Me.btndistrict.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndistrict.Name = "btndistrict"
        Me.btndistrict.Size = New System.Drawing.Size(74, 52)
        Me.btndistrict.Text = "ເພີ້ມເມືອງ"
        '
        'btnban
        '
        Me.btnban.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnban.Image = CType(resources.GetObject("btnban.Image"), System.Drawing.Image)
        Me.btnban.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnban.Name = "btnban"
        Me.btnban.Size = New System.Drawing.Size(68, 52)
        Me.btnban.Text = "ເພີ້ມບ້ານ"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.cbtype)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cbvillage)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cbdistrict)
        Me.Panel1.Controls.Add(Me.cbprovience)
        Me.Panel1.Controls.Add(Me.txtcount)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txtfax)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txttel)
        Me.Panel1.Controls.Add(Me.txtcontactname)
        Me.Panel1.Controls.Add(Me.txtcomname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(996, 156)
        Me.Panel1.TabIndex = 3
        '
        'btnadd
        '
        Me.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnadd.Image = Global.Smartinventory.My.Resources.Resources.Create
        Me.btnadd.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnadd.Location = New System.Drawing.Point(757, 118)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(41, 33)
        Me.btnadd.TabIndex = 26
        '
        'cbtype
        '
        Me.cbtype.DisplayMember = "Text"
        Me.cbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.ItemHeight = 29
        Me.cbtype.Location = New System.Drawing.Point(461, 116)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(294, 35)
        Me.cbtype.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(778, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 24)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ບ້ານ:"
        '
        'cbvillage
        '
        Me.cbvillage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbvillage.DisplayMember = "Text"
        Me.cbvillage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbvillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbvillage.FormattingEnabled = True
        Me.cbvillage.ItemHeight = 29
        Me.cbvillage.Location = New System.Drawing.Point(824, 42)
        Me.cbvillage.Name = "cbvillage"
        Me.cbvillage.Size = New System.Drawing.Size(166, 35)
        Me.cbvillage.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 24)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ເມືອງ:"
        '
        'cbdistrict
        '
        Me.cbdistrict.DisplayMember = "Text"
        Me.cbdistrict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbdistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdistrict.FormattingEnabled = True
        Me.cbdistrict.ItemHeight = 29
        Me.cbdistrict.Location = New System.Drawing.Point(461, 42)
        Me.cbdistrict.Name = "cbdistrict"
        Me.cbdistrict.Size = New System.Drawing.Size(314, 35)
        Me.cbdistrict.TabIndex = 21
        '
        'cbprovience
        '
        Me.cbprovience.DisplayMember = "Text"
        Me.cbprovience.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbprovience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbprovience.FormattingEnabled = True
        Me.cbprovience.ItemHeight = 29
        Me.cbprovience.Location = New System.Drawing.Point(461, 6)
        Me.cbprovience.Name = "cbprovience"
        Me.cbprovience.Size = New System.Drawing.Size(529, 35)
        Me.cbprovience.TabIndex = 20
        '
        'txtcount
        '
        Me.txtcount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcount.Location = New System.Drawing.Point(899, 116)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.ReadOnly = True
        Me.txtcount.Size = New System.Drawing.Size(94, 35)
        Me.txtcount.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(820, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ຈໍານວນ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ຊື່ຜູ້ຕິດຕໍ່:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ຊື່ບໍລິສັດ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(395, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ປະເພດ:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(403, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ອີເມວ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ເບີແຝກ:"
        '
        'txtemail
        '
        Me.txtemail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtemail.Location = New System.Drawing.Point(461, 79)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(532, 35)
        Me.txtemail.TabIndex = 5
        '
        'txtfax
        '
        Me.txtfax.Location = New System.Drawing.Point(96, 116)
        Me.txtfax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(271, 35)
        Me.txtfax.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ແຂວງ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ເບີໂທ:"
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(96, 79)
        Me.txttel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(271, 35)
        Me.txttel.TabIndex = 2
        '
        'txtcontactname
        '
        Me.txtcontactname.Location = New System.Drawing.Point(96, 42)
        Me.txtcontactname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcontactname.Name = "txtcontactname"
        Me.txtcontactname.Size = New System.Drawing.Size(271, 35)
        Me.txtcontactname.TabIndex = 1
        '
        'txtcomname
        '
        Me.txtcomname.Location = New System.Drawing.Point(96, 5)
        Me.txtcomname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcomname.Name = "txtcomname"
        Me.txtcomname.Size = New System.Drawing.Size(271, 35)
        Me.txtcomname.TabIndex = 0
        '
        'dgvcustomer
        '
        Me.dgvcustomer.AllowUserToAddRows = False
        Me.dgvcustomer.AllowUserToDeleteRows = False
        Me.dgvcustomer.AllowUserToResizeColumns = False
        Me.dgvcustomer.AllowUserToResizeRows = False
        Me.dgvcustomer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcustomer.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcustomer.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvcustomer.Location = New System.Drawing.Point(3, 223)
        Me.dgvcustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvcustomer.Name = "dgvcustomer"
        Me.dgvcustomer.ReadOnly = True
        Me.dgvcustomer.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvcustomer.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcustomer.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvcustomer.RowTemplate.Height = 28
        Me.dgvcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcustomer.Size = New System.Drawing.Size(996, 347)
        Me.dgvcustomer.TabIndex = 4
        '
        'frmcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmcustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnupdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactname As System.Windows.Forms.TextBox
    Friend WithEvents txtcomname As System.Windows.Forms.TextBox
    Friend WithEvents dgvcustomer As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtcount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbvillage As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbdistrict As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbprovience As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnclose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbtype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnprovince As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndistrict As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnban As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnadd As DevComponents.DotNetBar.ButtonX
End Class
