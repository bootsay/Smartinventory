<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshowcustomer
    'Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmshowcustomer))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvcus = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnsearch = New DevComponents.DotNetBar.ButtonX()
        Me.cbtype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rname = New System.Windows.Forms.RadioButton()
        Me.rtype = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvcus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvcus, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.37344!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.62656!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 535)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvcus
        '
        Me.dgvcus.AllowUserToAddRows = False
        Me.dgvcus.AllowUserToDeleteRows = False
        Me.dgvcus.AllowUserToResizeColumns = False
        Me.dgvcus.AllowUserToResizeRows = False
        Me.dgvcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcus.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcus.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvcus.Location = New System.Drawing.Point(3, 58)
        Me.dgvcus.Name = "dgvcus"
        Me.dgvcus.ReadOnly = True
        Me.dgvcus.RowHeadersVisible = False
        Me.dgvcus.RowTemplate.Height = 28
        Me.dgvcus.Size = New System.Drawing.Size(1002, 474)
        Me.dgvcus.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.cbtype)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 49)
        Me.Panel1.TabIndex = 1
        '
        'btnsearch
        '
        Me.btnsearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsearch.Image = Global.Smartinventory.My.Resources.Resources.Search
        Me.btnsearch.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnsearch.Location = New System.Drawing.Point(910, 4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(89, 36)
        Me.btnsearch.TabIndex = 28
        Me.btnsearch.Text = "ສະແດງ"
        '
        'cbtype
        '
        Me.cbtype.DisplayMember = "Text"
        Me.cbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.ItemHeight = 29
        Me.cbtype.Location = New System.Drawing.Point(157, 6)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(747, 35)
        Me.cbtype.TabIndex = 26
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(157, 3)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(749, 35)
        Me.txtsearch.TabIndex = 5
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rname)
        Me.GroupPanel1.Controls.Add(Me.rtype)
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(148, 40)
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
        Me.GroupPanel1.TabIndex = 4
        '
        'rname
        '
        Me.rname.AutoSize = True
        Me.rname.BackColor = System.Drawing.Color.Transparent
        Me.rname.Location = New System.Drawing.Point(89, 4)
        Me.rname.Name = "rname"
        Me.rname.Size = New System.Drawing.Size(42, 28)
        Me.rname.TabIndex = 1
        Me.rname.TabStop = True
        Me.rname.Text = "ຊື່:"
        Me.rname.UseVisualStyleBackColor = False
        '
        'rtype
        '
        Me.rtype.AutoSize = True
        Me.rtype.BackColor = System.Drawing.Color.Transparent
        Me.rtype.Location = New System.Drawing.Point(10, 4)
        Me.rtype.Name = "rtype"
        Me.rtype.Size = New System.Drawing.Size(73, 28)
        Me.rtype.TabIndex = 0
        Me.rtype.TabStop = True
        Me.rtype.Text = "ປະເພດ"
        Me.rtype.UseVisualStyleBackColor = False
        '
        'frmshowcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 535)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmshowcustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ຂໍ້ມູນລູກຄ້າ"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvcus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvcus As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rname As System.Windows.Forms.RadioButton
    Friend WithEvents rtype As System.Windows.Forms.RadioButton
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents cbtype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnsearch As DevComponents.DotNetBar.ButtonX
End Class
