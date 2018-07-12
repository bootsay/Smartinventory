<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsale
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
        Dim ComboItem6 As DevComponents.Editors.ComboItem
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsale))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvsale = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtnameaprove = New System.Windows.Forms.Label()
        Me.txtsalenameproduct = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnote = New System.Windows.Forms.TextBox()
        Me.cbprice = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsalename = New DevComponents.DotNetBar.ButtonX()
        Me.cbsalename = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rddebit = New System.Windows.Forms.RadioButton()
        Me.rdcash = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rddolla = New System.Windows.Forms.RadioButton()
        Me.rdbath = New System.Windows.Forms.RadioButton()
        Me.rdkip = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnunapprove = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.txttotallastall = New System.Windows.Forms.TextBox()
        Me.txtcount = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtaprovedate = New System.Windows.Forms.TextBox()
        Me.btncancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnfree = New DevComponents.DotNetBar.ButtonX()
        Me.btnclear = New DevComponents.DotNetBar.ButtonX()
        Me.btnminus = New DevComponents.DotNetBar.ButtonX()
        Me.btnadd = New DevComponents.DotNetBar.ButtonX()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtdaycredit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnapprove = New DevComponents.DotNetBar.ButtonX()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.cbselectbill = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.txttotallast = New System.Windows.Forms.TextBox()
        Me.txtdeposite = New System.Windows.Forms.TextBox()
        Me.btnshowtax = New DevComponents.DotNetBar.ButtonX()
        Me.cbtax = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.txt_dispersent = New System.Windows.Forms.TextBox()
        Me.txttotalsale = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttax = New System.Windows.Forms.TextBox()
        ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvsale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboItem6
        '
        ComboItem6.Text = "ໃບຮັບເງີນສົດ"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvsale, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1206, 662)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvsale
        '
        Me.dgvsale.AllowDrop = True
        Me.dgvsale.AllowUserToAddRows = False
        Me.dgvsale.AllowUserToDeleteRows = False
        Me.dgvsale.AllowUserToResizeColumns = False
        Me.dgvsale.AllowUserToResizeRows = False
        Me.dgvsale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsale.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvsale.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvsale.Location = New System.Drawing.Point(3, 157)
        Me.dgvsale.Name = "dgvsale"
        Me.dgvsale.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvsale.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvsale.RowTemplate.Height = 28
        Me.dgvsale.Size = New System.Drawing.Size(1200, 335)
        Me.dgvsale.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtnameaprove)
        Me.Panel1.Controls.Add(Me.txtsalenameproduct)
        Me.Panel1.Controls.Add(Me.txtlocation)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.GroupPanel3)
        Me.Panel1.Controls.Add(Me.dtsale)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtsupname)
        Me.Panel1.Controls.Add(Me.btnbrown)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtnote)
        Me.Panel1.Controls.Add(Me.cbprice)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnsalename)
        Me.Panel1.Controls.Add(Me.cbsalename)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.GroupPanel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 148)
        Me.Panel1.TabIndex = 1
        '
        'txtnameaprove
        '
        Me.txtnameaprove.AutoSize = True
        Me.txtnameaprove.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtnameaprove.ForeColor = System.Drawing.Color.Red
        Me.txtnameaprove.Location = New System.Drawing.Point(1068, 120)
        Me.txtnameaprove.Name = "txtnameaprove"
        Me.txtnameaprove.Size = New System.Drawing.Size(93, 24)
        Me.txtnameaprove.TabIndex = 36
        Me.txtnameaprove.Text = "ທ່ານ ບຸດວົງ"
        '
        'txtsalenameproduct
        '
        '
        '
        '
        Me.txtsalenameproduct.Border.Class = "TextBoxBorder"
        Me.txtsalenameproduct.Enabled = False
        Me.txtsalenameproduct.Location = New System.Drawing.Point(90, 39)
        Me.txtsalenameproduct.Name = "txtsalenameproduct"
        Me.txtsalenameproduct.Size = New System.Drawing.Size(265, 35)
        Me.txtsalenameproduct.TabIndex = 26
        Me.txtsalenameproduct.WatermarkText = "ຊື່ພະນັກງານຂາຍ"
        '
        'txtlocation
        '
        Me.txtlocation.Location = New System.Drawing.Point(90, 75)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(874, 35)
        Me.txtlocation.TabIndex = 24
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Saysettha OT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX1.Location = New System.Drawing.Point(922, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(42, 35)
        Me.ButtonX1.TabIndex = 23
        Me.ButtonX1.Text = "..."
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
        Me.dtsale.Location = New System.Drawing.Point(468, 40)
        Me.dtsale.Name = "dtsale"
        Me.dtsale.Size = New System.Drawing.Size(175, 35)
        Me.dtsale.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(370, 46)
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
        Me.txtsupname.Location = New System.Drawing.Point(697, 3)
        Me.txtsupname.Name = "txtsupname"
        Me.txtsupname.Size = New System.Drawing.Size(161, 35)
        Me.txtsupname.TabIndex = 19
        Me.txtsupname.WatermarkText = "ເລືອກຜູ້ຊື້"
        '
        'btnbrown
        '
        Me.btnbrown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown.Image = Global.Smartinventory.My.Resources.Resources.folder_customer_icon1
        Me.btnbrown.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown.Location = New System.Drawing.Point(864, 3)
        Me.btnbrown.Name = "btnbrown"
        Me.btnbrown.Size = New System.Drawing.Size(54, 35)
        Me.btnbrown.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ໜາຍເຫດ:"
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(90, 111)
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(874, 35)
        Me.txtnote.TabIndex = 15
        '
        'cbprice
        '
        Me.cbprice.DisplayMember = "Text"
        Me.cbprice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbprice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbprice.FormattingEnabled = True
        Me.cbprice.ItemHeight = 29
        Me.cbprice.Items.AddRange(New Object() {Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5})
        Me.cbprice.Location = New System.Drawing.Point(697, 40)
        Me.cbprice.Name = "cbprice"
        Me.cbprice.Size = New System.Drawing.Size(267, 35)
        Me.cbprice.TabIndex = 14
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "ໜ້າຮ້ານ"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "ລາຄາຊ່າງ"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "ລາຄາຕິດຕັ້ງ"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "ລາຄາສົ່ງ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ລາຄາ:"
        '
        'btnsalename
        '
        Me.btnsalename.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsalename.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsalename.Image = Global.Smartinventory.My.Resources.Resources.Create
        Me.btnsalename.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnsalename.Location = New System.Drawing.Point(305, 40)
        Me.btnsalename.Name = "btnsalename"
        Me.btnsalename.Size = New System.Drawing.Size(50, 28)
        Me.btnsalename.TabIndex = 12
        '
        'cbsalename
        '
        Me.cbsalename.DisplayMember = "Text"
        Me.cbsalename.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsalename.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbsalename.FormattingEnabled = True
        Me.cbsalename.ItemHeight = 22
        Me.cbsalename.Location = New System.Drawing.Point(90, 40)
        Me.cbsalename.Name = "cbsalename"
        Me.cbsalename.Size = New System.Drawing.Size(211, 28)
        Me.cbsalename.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ຜູ້ຂາຍ:"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(90, 3)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(211, 35)
        Me.txtid.TabIndex = 9
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.rddebit)
        Me.GroupPanel2.Controls.Add(Me.rdcash)
        Me.GroupPanel2.Location = New System.Drawing.Point(305, 3)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(160, 35)
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
        'rddebit
        '
        Me.rddebit.AutoSize = True
        Me.rddebit.BackColor = System.Drawing.Color.Transparent
        Me.rddebit.Location = New System.Drawing.Point(13, 1)
        Me.rddebit.Name = "rddebit"
        Me.rddebit.Size = New System.Drawing.Size(63, 28)
        Me.rddebit.TabIndex = 1
        Me.rddebit.TabStop = True
        Me.rddebit.Text = "ຕິດໜີ້"
        Me.rddebit.UseVisualStyleBackColor = False
        '
        'rdcash
        '
        Me.rdcash.AutoSize = True
        Me.rdcash.BackColor = System.Drawing.Color.Transparent
        Me.rdcash.Location = New System.Drawing.Point(82, -2)
        Me.rdcash.Name = "rdcash"
        Me.rdcash.Size = New System.Drawing.Size(48, 28)
        Me.rdcash.TabIndex = 0
        Me.rdcash.TabStop = True
        Me.rdcash.Text = "ສົດ"
        Me.rdcash.UseVisualStyleBackColor = False
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
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rddolla)
        Me.GroupPanel1.Controls.Add(Me.rdbath)
        Me.GroupPanel1.Controls.Add(Me.rdkip)
        Me.GroupPanel1.Location = New System.Drawing.Point(468, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(223, 35)
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 24)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "ສະຖານທີ່:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(970, 121)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 24)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "ອະນຸມັດໂດຍ:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnunapprove)
        Me.Panel2.Controls.Add(Me.ButtonX2)
        Me.Panel2.Controls.Add(Me.txttotallastall)
        Me.Panel2.Controls.Add(Me.txtcount)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtaprovedate)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnfree)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btnminus)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtdaycredit)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.btnapprove)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Controls.Add(Me.cbselectbill)
        Me.Panel2.Controls.Add(Me.txttotallast)
        Me.Panel2.Controls.Add(Me.txtdeposite)
        Me.Panel2.Controls.Add(Me.btnshowtax)
        Me.Panel2.Controls.Add(Me.cbtax)
        Me.Panel2.Controls.Add(Me.txtdiscount)
        Me.Panel2.Controls.Add(Me.txt_dispersent)
        Me.Panel2.Controls.Add(Me.txttotalsale)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txttax)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 498)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 161)
        Me.Panel2.TabIndex = 2
        '
        'btnunapprove
        '
        Me.btnunapprove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnunapprove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnunapprove.Image = Global.Smartinventory.My.Resources.Resources.Open
        Me.btnunapprove.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnunapprove.Location = New System.Drawing.Point(377, 96)
        Me.btnunapprove.Name = "btnunapprove"
        Me.btnunapprove.Size = New System.Drawing.Size(139, 59)
        Me.btnunapprove.TabIndex = 38
        Me.btnunapprove.Text = "ຍົກເລີກການອະນຸມັດ"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.Smartinventory.My.Resources.Resources.add4
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX2.Location = New System.Drawing.Point(388, 3)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(128, 40)
        Me.ButtonX2.TabIndex = 37
        Me.ButtonX2.Text = "ເບີກເຄື່ອງ"
        '
        'txttotallastall
        '
        Me.txttotallastall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotallastall.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotallastall.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttotallastall.ForeColor = System.Drawing.Color.Red
        Me.txttotallastall.Location = New System.Drawing.Point(954, 117)
        Me.txttotallastall.Name = "txttotallastall"
        Me.txttotallastall.ReadOnly = True
        Me.txttotallastall.Size = New System.Drawing.Size(220, 35)
        Me.txttotallastall.TabIndex = 35
        '
        'txtcount
        '
        Me.txtcount.AutoSize = True
        Me.txtcount.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtcount.ForeColor = System.Drawing.Color.Red
        Me.txtcount.Location = New System.Drawing.Point(287, 59)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.Size = New System.Drawing.Size(20, 24)
        Me.txtcount.TabIndex = 34
        Me.txtcount.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(317, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 24)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "ລາຍການ"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(182, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 24)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "ລວມທັງໝົດມີ:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(546, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 24)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "ວັນອະນຸມັດ:"
        '
        'txtaprovedate
        '
        Me.txtaprovedate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaprovedate.Location = New System.Drawing.Point(634, 3)
        Me.txtaprovedate.Name = "txtaprovedate"
        Me.txtaprovedate.ReadOnly = True
        Me.txtaprovedate.Size = New System.Drawing.Size(225, 35)
        Me.txtaprovedate.TabIndex = 30
        '
        'btncancel
        '
        Me.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncancel.Image = Global.Smartinventory.My.Resources.Resources.edit_delete_icon
        Me.btncancel.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btncancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btncancel.Location = New System.Drawing.Point(273, 96)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(98, 59)
        Me.btncancel.TabIndex = 29
        Me.btncancel.Text = "ຍົກເລີກ"
        '
        'btnfree
        '
        Me.btnfree.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnfree.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnfree.Image = Global.Smartinventory.My.Resources.Resources.shopping_cart
        Me.btnfree.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnfree.Location = New System.Drawing.Point(307, 3)
        Me.btnfree.Name = "btnfree"
        Me.btnfree.Size = New System.Drawing.Size(75, 40)
        Me.btnfree.TabIndex = 28
        Me.btnfree.Text = "ແຖມ"
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
        Me.btnminus.Location = New System.Drawing.Point(226, 3)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(75, 40)
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
        Me.btnadd.Size = New System.Drawing.Size(75, 40)
        Me.btnadd.TabIndex = 25
        Me.btnadd.Text = "ເພີ້ມ"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1175, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 24)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "/ມື້"
        '
        'txtdaycredit
        '
        Me.txtdaycredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdaycredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdaycredit.Location = New System.Drawing.Point(1126, 80)
        Me.txtdaycredit.Name = "txtdaycredit"
        Me.txtdaycredit.Size = New System.Drawing.Size(48, 35)
        Me.txtdaycredit.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1078, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "ເຄດີດ:"
        '
        'btnapprove
        '
        Me.btnapprove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnapprove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnapprove.Image = Global.Smartinventory.My.Resources.Resources.Ok
        Me.btnapprove.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnapprove.Location = New System.Drawing.Point(169, 96)
        Me.btnapprove.Name = "btnapprove"
        Me.btnapprove.Size = New System.Drawing.Size(98, 59)
        Me.btnapprove.TabIndex = 21
        Me.btnapprove.Text = "ອະນຸມັດຂາຍ"
        '
        'btnprint
        '
        Me.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnprint.Image = Global.Smartinventory.My.Resources.Resources.print_and_save
        Me.btnprint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnprint.Location = New System.Drawing.Point(5, 96)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(158, 59)
        Me.btnprint.TabIndex = 19
        Me.btnprint.Text = "ພິມບີນ"
        '
        'cbselectbill
        '
        Me.cbselectbill.DisplayMember = "Text"
        Me.cbselectbill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbselectbill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbselectbill.FormattingEnabled = True
        Me.cbselectbill.ItemHeight = 29
        Me.cbselectbill.Items.AddRange(New Object() {ComboItem6, Me.ComboItem7, Me.ComboItem8})
        Me.cbselectbill.Location = New System.Drawing.Point(5, 56)
        Me.cbselectbill.Name = "cbselectbill"
        Me.cbselectbill.Size = New System.Drawing.Size(158, 35)
        Me.cbselectbill.TabIndex = 18
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "ໃບສົ່ງເຄືອງ"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "ໃບສະເໜີລາຄາ"
        '
        'txttotallast
        '
        Me.txttotallast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotallast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotallast.ForeColor = System.Drawing.Color.Black
        Me.txttotallast.Location = New System.Drawing.Point(954, 41)
        Me.txttotallast.Name = "txttotallast"
        Me.txttotallast.ReadOnly = True
        Me.txttotallast.Size = New System.Drawing.Size(220, 35)
        Me.txttotallast.TabIndex = 16
        '
        'txtdeposite
        '
        Me.txtdeposite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdeposite.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdeposite.Location = New System.Drawing.Point(954, 79)
        Me.txtdeposite.MaxLength = 10
        Me.txtdeposite.Name = "txtdeposite"
        Me.txtdeposite.Size = New System.Drawing.Size(123, 35)
        Me.txtdeposite.TabIndex = 15
        '
        'btnshowtax
        '
        Me.btnshowtax.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshowtax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnshowtax.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshowtax.Image = Global.Smartinventory.My.Resources.Resources.Create
        Me.btnshowtax.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnshowtax.Location = New System.Drawing.Point(1115, 2)
        Me.btnshowtax.Name = "btnshowtax"
        Me.btnshowtax.Size = New System.Drawing.Size(58, 35)
        Me.btnshowtax.TabIndex = 13
        '
        'cbtax
        '
        Me.cbtax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbtax.DisplayMember = "Text"
        Me.cbtax.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbtax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtax.FormattingEnabled = True
        Me.cbtax.ItemHeight = 29
        Me.cbtax.Location = New System.Drawing.Point(954, 3)
        Me.cbtax.Name = "cbtax"
        Me.cbtax.Size = New System.Drawing.Size(155, 35)
        Me.cbtax.TabIndex = 10
        '
        'txtdiscount
        '
        Me.txtdiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtdiscount.Location = New System.Drawing.Point(634, 79)
        Me.txtdiscount.MaxLength = 10
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(225, 35)
        Me.txtdiscount.TabIndex = 8
        '
        'txt_dispersent
        '
        Me.txt_dispersent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_dispersent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dispersent.Location = New System.Drawing.Point(634, 117)
        Me.txt_dispersent.Name = "txt_dispersent"
        Me.txt_dispersent.ReadOnly = True
        Me.txt_dispersent.Size = New System.Drawing.Size(225, 35)
        Me.txt_dispersent.TabIndex = 6
        '
        'txttotalsale
        '
        Me.txttotalsale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotalsale.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotalsale.Location = New System.Drawing.Point(634, 41)
        Me.txttotalsale.Name = "txttotalsale"
        Me.txttotalsale.ReadOnly = True
        Me.txttotalsale.Size = New System.Drawing.Size(225, 35)
        Me.txttotalsale.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(549, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ລວມລາຄາ:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(568, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "ສ່ວນລຸດ:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(518, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ລວມຫັກສ່ວນລຸດ:"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(909, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 24)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "ລວມ:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(860, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "ອາກອນ10%:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(876, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ລວມສຸດທິ:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(881, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ຈ່າຍກ່ອນ:"
        '
        'txttax
        '
        Me.txttax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttax.BackColor = System.Drawing.Color.Red
        Me.txttax.ForeColor = System.Drawing.Color.Black
        Me.txttax.Location = New System.Drawing.Point(990, 48)
        Me.txttax.Multiline = True
        Me.txttax.Name = "txttax"
        Me.txttax.ReadOnly = True
        Me.txttax.Size = New System.Drawing.Size(104, 22)
        Me.txttax.TabIndex = 39
        '
        'frmsale
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
        Me.Name = "frmsale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ຂາຍ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvsale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents dgvsale As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rddolla As System.Windows.Forms.RadioButton
    Friend WithEvents rdbath As System.Windows.Forms.RadioButton
    Friend WithEvents rdkip As System.Windows.Forms.RadioButton
    Friend WithEvents cbsalename As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rddebit As System.Windows.Forms.RadioButton
    Friend WithEvents rdcash As System.Windows.Forms.RadioButton
    Friend WithEvents btnsalename As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbprice As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnbrown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txttotalsale As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_dispersent As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbtax As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnshowtax As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents txttotallast As System.Windows.Forms.TextBox
    Friend WithEvents txtdeposite As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsupname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbselectbill As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnapprove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtsale As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtdaycredit As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnnew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnadd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnminus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnclear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnfree As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnedit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnupdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btncancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtaprovedate As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtlocation As System.Windows.Forms.TextBox
    Friend WithEvents txtcount As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents txtsalenameproduct As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtnameaprove As System.Windows.Forms.Label
    Friend WithEvents txttotallastall As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnunapprove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txttax As TextBox
End Class
