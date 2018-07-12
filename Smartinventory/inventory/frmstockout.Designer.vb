<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstockout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstockout))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvlist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbstockouttype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
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
        Me.txtstockoutNO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnapprove = New DevComponents.DotNetBar.ButtonX()
        Me.btncancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnclear = New DevComponents.DotNetBar.ButtonX()
        Me.btnminus = New DevComponents.DotNetBar.ButtonX()
        Me.btnadd = New DevComponents.DotNetBar.ButtonX()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.txttotallast = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ລບToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbstockouttype)
        Me.Panel1.Controls.Add(Me.txtordername)
        Me.Panel1.Controls.Add(Me.GroupPanel3)
        Me.Panel1.Controls.Add(Me.dtsale)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtsupname)
        Me.Panel1.Controls.Add(Me.btnbrown)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtorderNote)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtstockoutNO)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 119)
        Me.Panel1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(307, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 24)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ຜູ້ເບີກ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ປະເພດ:"
        '
        'cbstockouttype
        '
        Me.cbstockouttype.DisplayMember = "Text"
        Me.cbstockouttype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbstockouttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbstockouttype.FormattingEnabled = True
        Me.cbstockouttype.ItemHeight = 29
        Me.cbstockouttype.Location = New System.Drawing.Point(398, 3)
        Me.cbstockouttype.Name = "cbstockouttype"
        Me.cbstockouttype.Size = New System.Drawing.Size(566, 35)
        Me.cbstockouttype.TabIndex = 24
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
        Me.dtsale.Location = New System.Drawing.Point(865, 39)
        Me.dtsale.Name = "dtsale"
        Me.dtsale.Size = New System.Drawing.Size(99, 35)
        Me.dtsale.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(786, 46)
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
        Me.txtsupname.Location = New System.Drawing.Point(398, 40)
        Me.txtsupname.Name = "txtsupname"
        Me.txtsupname.ReadOnly = True
        Me.txtsupname.Size = New System.Drawing.Size(327, 35)
        Me.txtsupname.TabIndex = 19
        Me.txtsupname.WatermarkText = "ເລືອກຍືມ"
        '
        'btnbrown
        '
        Me.btnbrown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown.Image = Global.Smartinventory.My.Resources.Resources.folder_customer_icon1
        Me.btnbrown.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown.Location = New System.Drawing.Point(731, 40)
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
        'txtstockoutNO
        '
        Me.txtstockoutNO.Location = New System.Drawing.Point(90, 3)
        Me.txtstockoutNO.Name = "txtstockoutNO"
        Me.txtstockoutNO.ReadOnly = True
        Me.txtstockoutNO.Size = New System.Drawing.Size(211, 35)
        Me.txtstockoutNO.TabIndex = 9
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
        Me.Panel2.Controls.Add(Me.btnapprove)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btnminus)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Controls.Add(Me.txttotallast)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 536)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 123)
        Me.Panel2.TabIndex = 2
        '
        'btnapprove
        '
        Me.btnapprove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnapprove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnapprove.Image = Global.Smartinventory.My.Resources.Resources.Ok
        Me.btnapprove.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnapprove.Location = New System.Drawing.Point(144, 48)
        Me.btnapprove.Name = "btnapprove"
        Me.btnapprove.Size = New System.Drawing.Size(158, 59)
        Me.btnapprove.TabIndex = 30
        Me.btnapprove.Text = "ຮັບສີນຄ້າຄືນ"
        '
        'btncancel
        '
        Me.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncancel.Image = Global.Smartinventory.My.Resources.Resources.edit_delete_icon
        Me.btncancel.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btncancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btncancel.Location = New System.Drawing.Point(307, 48)
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
        Me.btnminus.Location = New System.Drawing.Point(215, 3)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(62, 40)
        Me.btnminus.TabIndex = 26
        Me.btnminus.Text = "ລົບ"
        '
        'btnadd
        '
        Me.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnadd.Image = Global.Smartinventory.My.Resources.Resources.Create
        Me.btnadd.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnadd.Location = New System.Drawing.Point(144, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(66, 40)
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
        Me.btnprint.Size = New System.Drawing.Size(136, 58)
        Me.btnprint.TabIndex = 19
        Me.btnprint.Text = "ພິມບີນ"
        '
        'txttotallast
        '
        Me.txttotallast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotallast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotallast.Font = New System.Drawing.Font("Saysettha OT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttotallast.Location = New System.Drawing.Point(889, 8)
        Me.txttotallast.Name = "txttotallast"
        Me.txttotallast.ReadOnly = True
        Me.txttotallast.Size = New System.Drawing.Size(308, 44)
        Me.txttotallast.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(842, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ລວມ:"
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
        'frmstockout
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
        Me.Name = "frmstockout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ໃບຍືມສີນຄ້າ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvlist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstockoutNO As System.Windows.Forms.TextBox
    Friend WithEvents txtorderNote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnbrown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttotallast As System.Windows.Forms.TextBox
    Friend WithEvents txtsupname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ລບToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbstockouttype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnapprove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
