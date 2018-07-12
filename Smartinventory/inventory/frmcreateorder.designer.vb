<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcreateorder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcreateorder))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvlist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncustomer = New DevComponents.DotNetBar.ButtonX()
        Me.txtordername = New System.Windows.Forms.TextBox()
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
        Me.txtorderNote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtorderNO = New System.Windows.Forms.TextBox()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rddebit = New System.Windows.Forms.RadioButton()
        Me.rdcash = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rddolla = New System.Windows.Forms.RadioButton()
        Me.rdbath = New System.Windows.Forms.RadioButton()
        Me.rdkip = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_dispersent = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btncancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnclear = New DevComponents.DotNetBar.ButtonX()
        Me.btnminus = New DevComponents.DotNetBar.ButtonX()
        Me.btnadd = New DevComponents.DotNetBar.ButtonX()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.txttotallast = New System.Windows.Forms.TextBox()
        Me.btnshowtax = New DevComponents.DotNetBar.ButtonX()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbtax = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtcount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.dgvlist, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1206, 662)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvlist
        '
        Me.dgvlist.AllowDrop = True
        Me.dgvlist.AllowUserToAddRows = False
        Me.dgvlist.AllowUserToDeleteRows = False
        Me.dgvlist.AllowUserToResizeColumns = False
        Me.dgvlist.AllowUserToResizeRows = False
        Me.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlist.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlist.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlist.Location = New System.Drawing.Point(3, 128)
        Me.dgvlist.Name = "dgvlist"
        Me.dgvlist.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvlist.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlist.RowTemplate.Height = 28
        Me.dgvlist.Size = New System.Drawing.Size(1200, 402)
        Me.dgvlist.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btncustomer)
        Me.Panel1.Controls.Add(Me.txtordername)
        Me.Panel1.Controls.Add(Me.GroupPanel3)
        Me.Panel1.Controls.Add(Me.dtsale)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtsupname)
        Me.Panel1.Controls.Add(Me.btnbrown)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtorderNote)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtorderNO)
        Me.Panel1.Controls.Add(Me.GroupPanel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 119)
        Me.Panel1.TabIndex = 1
        '
        'btncustomer
        '
        Me.btncustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncustomer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncustomer.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btncustomer.Location = New System.Drawing.Point(650, 40)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(54, 35)
        Me.btncustomer.TabIndex = 24
        Me.btncustomer.Text = "..."
        '
        'txtordername
        '
        Me.txtordername.Location = New System.Drawing.Point(90, 39)
        Me.txtordername.Name = "txtordername"
        Me.txtordername.ReadOnly = True
        Me.txtordername.Size = New System.Drawing.Size(211, 35)
        Me.txtordername.TabIndex = 23
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
        Me.dtsale.Location = New System.Drawing.Point(789, 39)
        Me.dtsale.Name = "dtsale"
        Me.dtsale.Size = New System.Drawing.Size(175, 35)
        Me.dtsale.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(707, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ວັນທີຂາຍ:"
        '
        'txtsupname
        '
        Me.txtsupname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtsupname.Border.Class = "TextBoxBorder"
        Me.txtsupname.Location = New System.Drawing.Point(307, 40)
        Me.txtsupname.Name = "txtsupname"
        Me.txtsupname.ReadOnly = True
        Me.txtsupname.Size = New System.Drawing.Size(278, 35)
        Me.txtsupname.TabIndex = 19
        Me.txtsupname.WatermarkText = "ເລືອກຜູ້ສະໜອງສີນຄ້າ"
        '
        'btnbrown
        '
        Me.btnbrown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown.Image = Global.Smartinventory.My.Resources.Resources.folder_customer_icon1
        Me.btnbrown.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown.Location = New System.Drawing.Point(590, 40)
        Me.btnbrown.Name = "btnbrown"
        Me.btnbrown.Size = New System.Drawing.Size(54, 35)
        Me.btnbrown.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ໜາຍເຫດ:"
        '
        'txtorderNote
        '
        Me.txtorderNote.Location = New System.Drawing.Point(90, 77)
        Me.txtorderNote.Name = "txtorderNote"
        Me.txtorderNote.Size = New System.Drawing.Size(874, 35)
        Me.txtorderNote.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ຜູ້ອອກບີນ:"
        '
        'txtorderNO
        '
        Me.txtorderNO.Location = New System.Drawing.Point(90, 3)
        Me.txtorderNO.Name = "txtorderNO"
        Me.txtorderNO.ReadOnly = True
        Me.txtorderNO.Size = New System.Drawing.Size(211, 35)
        Me.txtorderNO.TabIndex = 9
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
        Me.rddebit.Location = New System.Drawing.Point(74, 1)
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
        Me.rdcash.Location = New System.Drawing.Point(10, 1)
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
        Me.GroupPanel1.Size = New System.Drawing.Size(496, 35)
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
        Me.Panel2.Controls.Add(Me.txt_dispersent)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btnminus)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Controls.Add(Me.txttotallast)
        Me.Panel2.Controls.Add(Me.btnshowtax)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cbtax)
        Me.Panel2.Controls.Add(Me.txtdiscount)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.txtcount)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txttax)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 537)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 122)
        Me.Panel2.TabIndex = 2
        '
        'txt_dispersent
        '
        Me.txt_dispersent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_dispersent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_dispersent.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txt_dispersent.Location = New System.Drawing.Point(533, 81)
        Me.txt_dispersent.Name = "txt_dispersent"
        Me.txt_dispersent.ReadOnly = True
        Me.txt_dispersent.Size = New System.Drawing.Size(276, 35)
        Me.txt_dispersent.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(1074, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 24)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "ລາຍການ"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(939, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 24)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "ລວມທັງໝົດມີ:"
        '
        'btncancel
        '
        Me.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncancel.Image = Global.Smartinventory.My.Resources.Resources.edit_delete_icon
        Me.btncancel.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btncancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btncancel.Location = New System.Drawing.Point(180, 48)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(121, 59)
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
        'btnprint
        '
        Me.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnprint.Image = Global.Smartinventory.My.Resources.Resources.print_and_save
        Me.btnprint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnprint.Location = New System.Drawing.Point(3, 49)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(171, 58)
        Me.btnprint.TabIndex = 19
        Me.btnprint.Text = "ພິມບີນ"
        '
        'txttotallast
        '
        Me.txttotallast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotallast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotallast.Font = New System.Drawing.Font("Saysettha OT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttotallast.Location = New System.Drawing.Point(889, 70)
        Me.txttotallast.Name = "txttotallast"
        Me.txttotallast.ReadOnly = True
        Me.txttotallast.Size = New System.Drawing.Size(308, 44)
        Me.txttotallast.TabIndex = 16
        '
        'btnshowtax
        '
        Me.btnshowtax.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshowtax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnshowtax.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshowtax.Image = Global.Smartinventory.My.Resources.Resources.Create
        Me.btnshowtax.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnshowtax.Location = New System.Drawing.Point(1147, 36)
        Me.btnshowtax.Name = "btnshowtax"
        Me.btnshowtax.Size = New System.Drawing.Size(50, 33)
        Me.btnshowtax.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(821, 36)
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
        Me.cbtax.Location = New System.Drawing.Point(889, 34)
        Me.cbtax.Name = "cbtax"
        Me.cbtax.Size = New System.Drawing.Size(252, 35)
        Me.cbtax.TabIndex = 10
        '
        'txtdiscount
        '
        Me.txtdiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdiscount.Location = New System.Drawing.Point(533, 45)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(276, 35)
        Me.txtdiscount.TabIndex = 8
        '
        'txttotal
        '
        Me.txttotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttotal.Location = New System.Drawing.Point(533, 8)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(276, 35)
        Me.txttotal.TabIndex = 0
        '
        'txtcount
        '
        Me.txtcount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcount.AutoSize = True
        Me.txtcount.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtcount.ForeColor = System.Drawing.Color.Red
        Me.txtcount.Location = New System.Drawing.Point(1044, 6)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.Size = New System.Drawing.Size(20, 24)
        Me.txtcount.TabIndex = 37
        Me.txtcount.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(813, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ລວມສຸດທິ:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(465, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "ສ່ວນລຸດ:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(450, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ລວມລາຄາ:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "ລວມຫັກສ່ວນລຸດ:"
        '
        'txttax
        '
        Me.txttax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttax.Location = New System.Drawing.Point(927, 37)
        Me.txttax.Multiline = True
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(137, 29)
        Me.txttax.TabIndex = 40
        '
        'frmcreateorder
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
        Me.Name = "frmcreateorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ໃບສັ່ງຊື້"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvlist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rddolla As System.Windows.Forms.RadioButton
    Friend WithEvents rdbath As System.Windows.Forms.RadioButton
    Friend WithEvents rdkip As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtorderNO As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rddebit As System.Windows.Forms.RadioButton
    Friend WithEvents rdcash As System.Windows.Forms.RadioButton
    Friend WithEvents txtorderNote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnbrown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbtax As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnshowtax As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txttotallast As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsupname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonX
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
    Friend WithEvents btncancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtordername As System.Windows.Forms.TextBox
    Friend WithEvents btncustomer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtcount As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_dispersent As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttax As TextBox
End Class
