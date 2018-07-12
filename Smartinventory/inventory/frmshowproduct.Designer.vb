<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshowproduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmshowproduct))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvprodouct = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbsubcate = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbcate = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbstock = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvprodouct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvprodouct, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 594)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvprodouct
        '
        Me.dgvprodouct.AllowUserToAddRows = False
        Me.dgvprodouct.AllowUserToDeleteRows = False
        Me.dgvprodouct.AllowUserToResizeColumns = False
        Me.dgvprodouct.AllowUserToResizeRows = False
        Me.dgvprodouct.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvprodouct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvprodouct.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvprodouct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvprodouct.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvprodouct.Location = New System.Drawing.Point(3, 122)
        Me.dgvprodouct.Name = "dgvprodouct"
        Me.dgvprodouct.ReadOnly = True
        Me.dgvprodouct.RowHeadersVisible = False
        Me.dgvprodouct.RowTemplate.Height = 28
        Me.dgvprodouct.Size = New System.Drawing.Size(1002, 469)
        Me.dgvprodouct.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbsubcate)
        Me.Panel1.Controls.Add(Me.cbcate)
        Me.Panel1.Controls.Add(Me.cbstock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 113)
        Me.Panel1.TabIndex = 1
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(112, 77)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(881, 35)
        Me.txtsearch.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ຊອກຕາມຊື່:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ປະເພດຍ່ອຍ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ປະເພດຫລັກ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ສາງ"
        '
        'cbsubcate
        '
        Me.cbsubcate.DisplayMember = "Text"
        Me.cbsubcate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsubcate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsubcate.FormattingEnabled = True
        Me.cbsubcate.ItemHeight = 29
        Me.cbsubcate.Location = New System.Drawing.Point(112, 40)
        Me.cbsubcate.Name = "cbsubcate"
        Me.cbsubcate.Size = New System.Drawing.Size(881, 35)
        Me.cbsubcate.TabIndex = 2
        '
        'cbcate
        '
        Me.cbcate.DisplayMember = "Text"
        Me.cbcate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcate.FormattingEnabled = True
        Me.cbcate.ItemHeight = 29
        Me.cbcate.Location = New System.Drawing.Point(425, 4)
        Me.cbcate.Name = "cbcate"
        Me.cbcate.Size = New System.Drawing.Size(568, 35)
        Me.cbcate.TabIndex = 1
        '
        'cbstock
        '
        Me.cbstock.DisplayMember = "Text"
        Me.cbstock.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbstock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbstock.FormattingEnabled = True
        Me.cbstock.ItemHeight = 29
        Me.cbstock.Location = New System.Drawing.Point(112, 4)
        Me.cbstock.Name = "cbstock"
        Me.cbstock.Size = New System.Drawing.Size(210, 35)
        Me.cbstock.TabIndex = 0
        '
        'frmshowproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 594)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(1024, 39)
        Me.Name = "frmshowproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ຄົ້ນຫາສີນຄ້າ"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvprodouct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvprodouct As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbsubcate As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbcate As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbstock As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
End Class
