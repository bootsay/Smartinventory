<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsalesubitem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsalesubitem))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvsub = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtcount = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbprice = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnedit = New DevComponents.DotNetBar.ButtonX()
        Me.btnupdate = New DevComponents.DotNetBar.ButtonX()
        Me.btnsale = New DevComponents.DotNetBar.ButtonX()
        Me.txttotallast = New System.Windows.Forms.TextBox()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.btnclear = New DevComponents.DotNetBar.ButtonX()
        Me.btnminus = New DevComponents.DotNetBar.ButtonX()
        Me.btnadd = New DevComponents.DotNetBar.ButtonX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ລບToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnnew = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvsub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvsub, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.075342!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.92466!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvsub
        '
        Me.dgvsub.AllowUserToAddRows = False
        Me.dgvsub.AllowUserToDeleteRows = False
        Me.dgvsub.AllowUserToResizeColumns = False
        Me.dgvsub.AllowUserToResizeRows = False
        Me.dgvsub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsub.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvsub.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvsub.Location = New System.Drawing.Point(3, 58)
        Me.dgvsub.Name = "dgvsub"
        Me.dgvsub.ReadOnly = True
        Me.dgvsub.RowHeadersVisible = False
        Me.dgvsub.RowTemplate.Height = 28
        Me.dgvsub.Size = New System.Drawing.Size(1002, 547)
        Me.dgvsub.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtitemid)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 47)
        Me.Panel1.TabIndex = 1
        '
        'txtitemid
        '
        Me.txtitemid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtitemid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtitemid.Location = New System.Drawing.Point(457, 4)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.ReadOnly = True
        Me.txtitemid.Size = New System.Drawing.Size(536, 35)
        Me.txtitemid.TabIndex = 3
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(379, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 37)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "ລາຍການ:"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(75, 3)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(276, 35)
        Me.txtid.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(10, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 37)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "ບີນເລກທີ:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnnew)
        Me.Panel2.Controls.Add(Me.txtcount)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.cbprice)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnedit)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.btnsale)
        Me.Panel2.Controls.Add(Me.txttotallast)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btnminus)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 611)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 115)
        Me.Panel2.TabIndex = 2
        '
        'txtcount
        '
        Me.txtcount.AutoSize = True
        Me.txtcount.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtcount.ForeColor = System.Drawing.Color.Red
        Me.txtcount.Location = New System.Drawing.Point(250, 68)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.Size = New System.Drawing.Size(20, 24)
        Me.txtcount.TabIndex = 40
        Me.txtcount.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(280, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 24)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "ລາຍການ"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(145, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 24)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "ລວມທັງໝົດມີ:"
        '
        'cbprice
        '
        Me.cbprice.DisplayMember = "Text"
        Me.cbprice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbprice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbprice.FormattingEnabled = True
        Me.cbprice.ItemHeight = 29
        Me.cbprice.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5})
        Me.cbprice.Location = New System.Drawing.Point(360, 8)
        Me.cbprice.Name = "cbprice"
        Me.cbprice.Size = New System.Drawing.Size(325, 35)
        Me.cbprice.TabIndex = 37
        '
        'ComboItem1
        '
        Me.ComboItem1.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center
        Me.ComboItem1.Text = "ເລືອກລາຄາ"
        '
        'ComboItem2
        '
        Me.ComboItem2.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center
        Me.ComboItem2.Text = "ໜ້າຮ້ານ"
        '
        'ComboItem3
        '
        Me.ComboItem3.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center
        Me.ComboItem3.Text = "ລາຄາຊ່າງ"
        '
        'ComboItem4
        '
        Me.ComboItem4.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center
        Me.ComboItem4.Text = "ລາຄາຕິດຕັ້ງ"
        '
        'ComboItem5
        '
        Me.ComboItem5.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center
        Me.ComboItem5.Text = "ລາຄາສົ່ງ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "ລາຄາ:"
        '
        'btnedit
        '
        Me.btnedit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnedit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnedit.Image = Global.Smartinventory.My.Resources.Resources.edit_icon
        Me.btnedit.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnedit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnedit.Location = New System.Drawing.Point(431, 47)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(80, 59)
        Me.btnedit.TabIndex = 35
        Me.btnedit.Text = "ແກ້ໄຂ"
        '
        'btnupdate
        '
        Me.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnupdate.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnupdate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnupdate.Location = New System.Drawing.Point(516, 47)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 59)
        Me.btnupdate.TabIndex = 34
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'btnsale
        '
        Me.btnsale.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsale.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsale.Image = Global.Smartinventory.My.Resources.Resources.Save_icon
        Me.btnsale.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnsale.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnsale.Location = New System.Drawing.Point(596, 48)
        Me.btnsale.Name = "btnsale"
        Me.btnsale.Size = New System.Drawing.Size(85, 59)
        Me.btnsale.TabIndex = 33
        Me.btnsale.Text = "ບັນທືກ"
        '
        'txttotallast
        '
        Me.txttotallast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotallast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txttotallast.Font = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttotallast.Location = New System.Drawing.Point(691, -1)
        Me.txttotallast.Multiline = True
        Me.txttotallast.Name = "txttotallast"
        Me.txttotallast.ReadOnly = True
        Me.txttotallast.Size = New System.Drawing.Size(308, 115)
        Me.txttotallast.TabIndex = 32
        '
        'btnprint
        '
        Me.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnprint.Image = Global.Smartinventory.My.Resources.Resources.print_and_save
        Me.btnprint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnprint.Location = New System.Drawing.Point(3, 49)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(136, 59)
        Me.btnprint.TabIndex = 31
        Me.btnprint.Text = "ພິມບີນ"
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
        Me.btnclear.TabIndex = 30
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
        Me.btnminus.TabIndex = 29
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
        Me.btnadd.TabIndex = 28
        Me.btnadd.Text = "ເພີ້ມ"
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
        'btnnew
        '
        Me.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnnew.Image = Global.Smartinventory.My.Resources.Resources.New_file
        Me.btnnew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnnew.Location = New System.Drawing.Point(358, 47)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(67, 59)
        Me.btnnew.TabIndex = 41
        Me.btnnew.Text = "ສ້າງໄຫມ່"
        '
        'frmsalesubitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmsalesubitem"
        Me.Text = "ລາຍການຍ່ອຍ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvsub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvsub As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtitemid As System.Windows.Forms.TextBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnclear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnminus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnadd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txttotallast As System.Windows.Forms.TextBox
    Friend WithEvents btnedit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnupdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsale As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbprice As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcount As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ລບToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnnew As DevComponents.DotNetBar.ButtonX
End Class
