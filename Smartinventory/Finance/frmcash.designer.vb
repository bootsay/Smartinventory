<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcash
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
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvpay = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnsave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnupdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnprint = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtpayperson = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtreceiveperson = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtsacknumber = New System.Windows.Forms.TextBox()
        Me.rdoutcome = New System.Windows.Forms.RadioButton()
        Me.rdincome = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbmainaccount = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtremindmoney = New System.Windows.Forms.TextBox()
        Me.btnaddsource = New DevComponents.DotNetBar.ButtonX()
        Me.cbsource = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtdetail = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnreport = New DevComponents.DotNetBar.ButtonX()
        Me.btnsearch = New DevComponents.DotNetBar.ButtonX()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtt2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtt1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbmainaccountsearch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dgvlist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvpay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1012, 576)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1012, 538)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvpay, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1010, 536)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'dgvpay
        '
        Me.dgvpay.AllowUserToAddRows = False
        Me.dgvpay.AllowUserToDeleteRows = False
        Me.dgvpay.AllowUserToResizeColumns = False
        Me.dgvpay.AllowUserToResizeRows = False
        Me.dgvpay.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvpay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpay.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvpay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvpay.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvpay.Location = New System.Drawing.Point(3, 306)
        Me.dgvpay.Name = "dgvpay"
        Me.dgvpay.ReadOnly = True
        Me.dgvpay.RowHeadersVisible = False
        Me.dgvpay.RowTemplate.Height = 30
        Me.dgvpay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvpay.Size = New System.Drawing.Size(1004, 227)
        Me.dgvpay.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 43)
        Me.Panel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnsave, Me.ToolStripSeparator1, Me.btndelete, Me.ToolStripSeparator4, Me.btnedit, Me.ToolStripSeparator2, Me.btnupdate, Me.ToolStripSeparator3, Me.btnnew, Me.ToolStripButton1, Me.btnprint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1004, 43)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ບັນທືກ"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.Smartinventory.My.Resources.Resources.Save
        Me.btnsave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 40)
        Me.btnsave.Text = "ບັນທຶກ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'btndelete
        '
        Me.btndelete.Image = Global.Smartinventory.My.Resources.Resources.Delete
        Me.btndelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(66, 40)
        Me.btndelete.Text = "ລຶບ"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 43)
        '
        'btnedit
        '
        Me.btnedit.Image = Global.Smartinventory.My.Resources.Resources.Edit_page
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(84, 40)
        Me.btnedit.Text = "ແກ້ໄຂ"
        Me.btnedit.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        Me.ToolStripSeparator2.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnupdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(84, 40)
        Me.btnupdate.Text = "ປັບປຸງ"
        Me.btnupdate.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 43)
        Me.ToolStripSeparator3.Visible = False
        '
        'btnnew
        '
        Me.btnnew.Image = Global.Smartinventory.My.Resources.Resources.New_file
        Me.btnnew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(102, 40)
        Me.btnnew.Text = "ເລີ້ມໃຫ່ມ"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.Smartinventory.My.Resources.Resources.Cancel
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(66, 40)
        Me.ToolStripButton1.Text = "ປິດ"
        '
        'btnprint
        '
        Me.btnprint.Image = Global.Smartinventory.My.Resources.Resources.print_and_save
        Me.btnprint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnprint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(66, 40)
        Me.btnprint.Text = "ພີມ"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtpayperson)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtreceiveperson)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtsacknumber)
        Me.Panel2.Controls.Add(Me.rdoutcome)
        Me.Panel2.Controls.Add(Me.rdincome)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cbmainaccount)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtremindmoney)
        Me.Panel2.Controls.Add(Me.btnaddsource)
        Me.Panel2.Controls.Add(Me.cbsource)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dt1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.txtdetail)
        Me.Panel2.Controls.Add(Me.txtid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 254)
        Me.Panel2.TabIndex = 1
        '
        'txtpayperson
        '
        Me.txtpayperson.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayperson.Location = New System.Drawing.Point(92, 159)
        Me.txtpayperson.Name = "txtpayperson"
        Me.txtpayperson.Size = New System.Drawing.Size(413, 35)
        Me.txtpayperson.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 24)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "ຜູ້ຈ່າຍ:"
        '
        'txtreceiveperson
        '
        Me.txtreceiveperson.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtreceiveperson.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceiveperson.Location = New System.Drawing.Point(565, 159)
        Me.txtreceiveperson.Name = "txtreceiveperson"
        Me.txtreceiveperson.Size = New System.Drawing.Size(423, 35)
        Me.txtreceiveperson.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(510, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 24)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "ຜູ້ຮັບ:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 24)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "ເລກແຊັກ:"
        '
        'txtsacknumber
        '
        Me.txtsacknumber.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsacknumber.Location = New System.Drawing.Point(92, 121)
        Me.txtsacknumber.Name = "txtsacknumber"
        Me.txtsacknumber.Size = New System.Drawing.Size(413, 35)
        Me.txtsacknumber.TabIndex = 7
        '
        'rdoutcome
        '
        Me.rdoutcome.AutoSize = True
        Me.rdoutcome.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoutcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdoutcome.Location = New System.Drawing.Point(181, 84)
        Me.rdoutcome.Name = "rdoutcome"
        Me.rdoutcome.Size = New System.Drawing.Size(90, 28)
        Me.rdoutcome.TabIndex = 5
        Me.rdoutcome.TabStop = True
        Me.rdoutcome.Text = "ລາຍຈ່າຍ"
        Me.rdoutcome.UseVisualStyleBackColor = True
        '
        'rdincome
        '
        Me.rdincome.AutoSize = True
        Me.rdincome.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdincome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdincome.Location = New System.Drawing.Point(97, 84)
        Me.rdincome.Name = "rdincome"
        Me.rdincome.Size = New System.Drawing.Size(81, 28)
        Me.rdincome.TabIndex = 4
        Me.rdincome.TabStop = True
        Me.rdincome.Text = "ລາຍຮັບ"
        Me.rdincome.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ປະເພດ:"
        '
        'cbmainaccount
        '
        Me.cbmainaccount.DisplayMember = "Text"
        Me.cbmainaccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbmainaccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmainaccount.FormattingEnabled = True
        Me.cbmainaccount.ItemHeight = 29
        Me.cbmainaccount.Location = New System.Drawing.Point(95, 46)
        Me.cbmainaccount.Name = "cbmainaccount"
        Me.cbmainaccount.Size = New System.Drawing.Size(401, 35)
        Me.cbmainaccount.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ບັນຊີຫລັກ:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(502, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "ທັງໜົດ:"
        '
        'txtremindmoney
        '
        Me.txtremindmoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtremindmoney.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremindmoney.Location = New System.Drawing.Point(565, 46)
        Me.txtremindmoney.Name = "txtremindmoney"
        Me.txtremindmoney.ReadOnly = True
        Me.txtremindmoney.Size = New System.Drawing.Size(423, 35)
        Me.txtremindmoney.TabIndex = 3
        '
        'btnaddsource
        '
        Me.btnaddsource.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnaddsource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddsource.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnaddsource.Image = Global.Smartinventory.My.Resources.Resources.Create
        Me.btnaddsource.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnaddsource.Location = New System.Drawing.Point(937, 84)
        Me.btnaddsource.Name = "btnaddsource"
        Me.btnaddsource.Size = New System.Drawing.Size(51, 34)
        Me.btnaddsource.TabIndex = 15
        '
        'cbsource
        '
        Me.cbsource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbsource.DisplayMember = "Text"
        Me.cbsource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsource.FormattingEnabled = True
        Me.cbsource.ItemHeight = 29
        Me.cbsource.Location = New System.Drawing.Point(565, 84)
        Me.cbsource.Name = "cbsource"
        Me.cbsource.Size = New System.Drawing.Size(371, 35)
        Me.cbsource.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(435, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ປະເພດບັນຊີຍ່ອຍ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(506, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ວັນທີ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(506, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ມູນຄ່າ:"
        '
        'dt1
        '
        Me.dt1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt1.Location = New System.Drawing.Point(565, 5)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(371, 35)
        Me.dt1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ໜາຍເຫດ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ລະຫັດ:"
        '
        'txttotal
        '
        Me.txttotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotal.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(565, 121)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(423, 35)
        Me.txttotal.TabIndex = 8
        '
        'txtdetail
        '
        Me.txtdetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdetail.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetail.Location = New System.Drawing.Point(93, 197)
        Me.txtdetail.Multiline = True
        Me.txtdetail.Name = "txtdetail"
        Me.txtdetail.Size = New System.Drawing.Size(895, 53)
        Me.txtdetail.TabIndex = 11
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(95, 8)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(401, 35)
        Me.txtid.TabIndex = 0
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "ລາຍຮັບ-ລາຍຈ່າຍ"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 38)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1012, 538)
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvlist, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1010, 536)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnreport)
        Me.Panel3.Controls.Add(Me.btnsearch)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.dtt2)
        Me.Panel3.Controls.Add(Me.dtt1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cbmainaccountsearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1004, 85)
        Me.Panel3.TabIndex = 0
        '
        'btnreport
        '
        Me.btnreport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreport.Image = Global.Smartinventory.My.Resources.Resources.Report
        Me.btnreport.Location = New System.Drawing.Point(830, 47)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(119, 33)
        Me.btnreport.TabIndex = 7
        Me.btnreport.Text = "ລາຍງານ"
        Me.btnreport.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnsearch
        '
        Me.btnsearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsearch.Image = Global.Smartinventory.My.Resources.Resources.Search1
        Me.btnsearch.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnsearch.Location = New System.Drawing.Point(711, 48)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(113, 33)
        Me.btnsearch.TabIndex = 6
        Me.btnsearch.Text = "ສະແດງ"
        Me.btnsearch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(389, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 24)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "ຫາ:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ວັນທີ:"
        '
        'dtt2
        '
        '
        '
        '
        Me.dtt2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtt2.ButtonDropDown.Visible = True
        Me.dtt2.Location = New System.Drawing.Point(429, 47)
        '
        '
        '
        Me.dtt2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtt2.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtt2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtt2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtt2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtt2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtt2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtt2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtt2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtt2.MonthCalendar.DisplayMonth = New Date(2018, 4, 1, 0, 0, 0, 0)
        Me.dtt2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtt2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtt2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtt2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtt2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtt2.MonthCalendar.TodayButtonVisible = True
        Me.dtt2.Name = "dtt2"
        Me.dtt2.Size = New System.Drawing.Size(276, 35)
        Me.dtt2.TabIndex = 3
        '
        'dtt1
        '
        '
        '
        '
        Me.dtt1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtt1.ButtonDropDown.Visible = True
        Me.dtt1.Location = New System.Drawing.Point(88, 47)
        '
        '
        '
        Me.dtt1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtt1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtt1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtt1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtt1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtt1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtt1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtt1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtt1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtt1.MonthCalendar.DisplayMonth = New Date(2018, 4, 1, 0, 0, 0, 0)
        Me.dtt1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtt1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtt1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtt1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtt1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtt1.MonthCalendar.TodayButtonVisible = True
        Me.dtt1.Name = "dtt1"
        Me.dtt1.Size = New System.Drawing.Size(295, 35)
        Me.dtt1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ເລືອກບັນຊີ:"
        '
        'cbmainaccountsearch
        '
        Me.cbmainaccountsearch.DisplayMember = "Text"
        Me.cbmainaccountsearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbmainaccountsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmainaccountsearch.FormattingEnabled = True
        Me.cbmainaccountsearch.ItemHeight = 29
        Me.cbmainaccountsearch.Location = New System.Drawing.Point(88, 10)
        Me.cbmainaccountsearch.Name = "cbmainaccountsearch"
        Me.cbmainaccountsearch.Size = New System.Drawing.Size(295, 35)
        Me.cbmainaccountsearch.TabIndex = 0
        '
        'dgvlist
        '
        Me.dgvlist.AllowUserToAddRows = False
        Me.dgvlist.AllowUserToDeleteRows = False
        Me.dgvlist.AllowUserToResizeColumns = False
        Me.dgvlist.AllowUserToResizeRows = False
        Me.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlist.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlist.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlist.Location = New System.Drawing.Point(3, 94)
        Me.dgvlist.Name = "dgvlist"
        Me.dgvlist.ReadOnly = True
        Me.dgvlist.RowHeadersVisible = False
        Me.dgvlist.RowTemplate.Height = 30
        Me.dgvlist.Size = New System.Drawing.Size(1004, 439)
        Me.dgvlist.TabIndex = 1
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "ການເຄື່ອນໄຫວ"
        '
        'frmcash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1012, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmcash"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvpay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dtt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvpay As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnupdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtremindmoney As System.Windows.Forms.TextBox
    Friend WithEvents btnaddsource As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbsource As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtdetail As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents cbmainaccount As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvlist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnreport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtt2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtt1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbmainaccountsearch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnprint As System.Windows.Forms.ToolStripButton
    Friend WithEvents rdoutcome As System.Windows.Forms.RadioButton
    Friend WithEvents rdincome As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtpayperson As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtreceiveperson As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtsacknumber As System.Windows.Forms.TextBox
End Class
