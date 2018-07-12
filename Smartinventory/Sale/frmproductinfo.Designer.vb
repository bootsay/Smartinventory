<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproductinfo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvproductsaleprice = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvproduct = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnclose = New DevComponents.DotNetBar.ButtonX()
        Me.cbsubcate = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbsearchtype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rdtype = New System.Windows.Forms.RadioButton()
        Me.rdid = New System.Windows.Forms.RadioButton()
        Me.rdname = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.dgvproductsaleprice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1164, 482)
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
        Me.GroupPanel1.Text = "ຂໍ້ມູນສີນຄ້າ"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.dgvproductsaleprice, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1158, 446)
        Me.TableLayoutPanel7.TabIndex = 3
        '
        'dgvproductsaleprice
        '
        Me.dgvproductsaleprice.AllowUserToAddRows = False
        Me.dgvproductsaleprice.AllowUserToDeleteRows = False
        Me.dgvproductsaleprice.AllowUserToResizeColumns = False
        Me.dgvproductsaleprice.AllowUserToResizeRows = False
        Me.dgvproductsaleprice.BackgroundColor = System.Drawing.Color.Azure
        Me.dgvproductsaleprice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvproductsaleprice.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvproductsaleprice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvproductsaleprice.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvproductsaleprice.Location = New System.Drawing.Point(3, 300)
        Me.dgvproductsaleprice.Name = "dgvproductsaleprice"
        Me.dgvproductsaleprice.ReadOnly = True
        Me.dgvproductsaleprice.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvproductsaleprice.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvproductsaleprice.RowTemplate.Height = 26
        Me.dgvproductsaleprice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvproductsaleprice.Size = New System.Drawing.Size(1152, 143)
        Me.dgvproductsaleprice.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvproduct)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1152, 239)
        Me.Panel3.TabIndex = 0
        '
        'dgvproduct
        '
        Me.dgvproduct.AllowUserToAddRows = False
        Me.dgvproduct.AllowUserToDeleteRows = False
        Me.dgvproduct.AllowUserToResizeColumns = False
        Me.dgvproduct.AllowUserToResizeRows = False
        Me.dgvproduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvproduct.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvproduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvproduct.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvproduct.Location = New System.Drawing.Point(0, 0)
        Me.dgvproduct.Name = "dgvproduct"
        Me.dgvproduct.ReadOnly = True
        Me.dgvproduct.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvproduct.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvproduct.RowTemplate.Height = 28
        Me.dgvproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvproduct.Size = New System.Drawing.Size(1152, 239)
        Me.dgvproduct.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnclose)
        Me.Panel4.Controls.Add(Me.cbsubcate)
        Me.Panel4.Controls.Add(Me.cbsearchtype)
        Me.Panel4.Controls.Add(Me.txtsearch)
        Me.Panel4.Controls.Add(Me.GroupPanel2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1152, 46)
        Me.Panel4.TabIndex = 7
        '
        'btnclose
        '
        Me.btnclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclose.Image = Global.Smartinventory.My.Resources.Resources._1489493744_exit
        Me.btnclose.Location = New System.Drawing.Point(1072, 0)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(76, 43)
        Me.btnclose.TabIndex = 21
        Me.btnclose.Text = "ປິດ"
        '
        'cbsubcate
        '
        Me.cbsubcate.DisplayMember = "Text"
        Me.cbsubcate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsubcate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsubcate.FormattingEnabled = True
        Me.cbsubcate.ItemHeight = 29
        Me.cbsubcate.Location = New System.Drawing.Point(590, 6)
        Me.cbsubcate.Name = "cbsubcate"
        Me.cbsubcate.Size = New System.Drawing.Size(336, 35)
        Me.cbsubcate.TabIndex = 3
        '
        'cbsearchtype
        '
        Me.cbsearchtype.DisplayMember = "Text"
        Me.cbsearchtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsearchtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsearchtype.FormattingEnabled = True
        Me.cbsearchtype.ItemHeight = 29
        Me.cbsearchtype.Location = New System.Drawing.Point(290, 6)
        Me.cbsearchtype.Name = "cbsearchtype"
        Me.cbsearchtype.Size = New System.Drawing.Size(294, 35)
        Me.cbsearchtype.TabIndex = 1
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(290, 6)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(636, 35)
        Me.txtsearch.TabIndex = 2
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.rdtype)
        Me.GroupPanel2.Controls.Add(Me.rdid)
        Me.GroupPanel2.Controls.Add(Me.rdname)
        Me.GroupPanel2.Location = New System.Drawing.Point(81, 3)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(203, 40)
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
        Me.GroupPanel2.TabIndex = 1
        '
        'rdtype
        '
        Me.rdtype.AutoSize = True
        Me.rdtype.BackColor = System.Drawing.Color.Transparent
        Me.rdtype.Location = New System.Drawing.Point(126, 4)
        Me.rdtype.Name = "rdtype"
        Me.rdtype.Size = New System.Drawing.Size(73, 28)
        Me.rdtype.TabIndex = 2
        Me.rdtype.TabStop = True
        Me.rdtype.Text = "ປະເພດ"
        Me.rdtype.UseVisualStyleBackColor = False
        '
        'rdid
        '
        Me.rdid.AutoSize = True
        Me.rdid.BackColor = System.Drawing.Color.Transparent
        Me.rdid.Location = New System.Drawing.Point(53, 4)
        Me.rdid.Name = "rdid"
        Me.rdid.Size = New System.Drawing.Size(69, 28)
        Me.rdid.TabIndex = 1
        Me.rdid.TabStop = True
        Me.rdid.Text = "ລະຫັດ"
        Me.rdid.UseVisualStyleBackColor = False
        '
        'rdname
        '
        Me.rdname.AutoSize = True
        Me.rdname.BackColor = System.Drawing.Color.Transparent
        Me.rdname.Location = New System.Drawing.Point(3, 4)
        Me.rdname.Name = "rdname"
        Me.rdname.Size = New System.Drawing.Size(38, 28)
        Me.rdname.TabIndex = 0
        Me.rdname.TabStop = True
        Me.rdname.Text = "ຊື່"
        Me.rdname.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ຄົ້ນຫາດ້ວຍ:"
        '
        'frmproductinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmproductinfo"
        Me.GroupPanel1.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.dgvproductsaleprice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvproductsaleprice As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvproduct As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cbsubcate As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbsearchtype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdtype As System.Windows.Forms.RadioButton
    Friend WithEvents rdid As System.Windows.Forms.RadioButton
    Friend WithEvents rdname As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnclose As DevComponents.DotNetBar.ButtonX
End Class
