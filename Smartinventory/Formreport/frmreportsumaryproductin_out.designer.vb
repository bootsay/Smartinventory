<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportsumaryproductin_out
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportsumaryproductin_out))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbsupcategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbcategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnreportsalelist = New DevComponents.DotNetBar.ButtonX()
        Me.btnreportsaleno = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CrystalReportViewer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1140, 524)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbsupcategory)
        Me.Panel1.Controls.Add(Me.cbcategory)
        Me.Panel1.Controls.Add(Me.date2)
        Me.Panel1.Controls.Add(Me.date1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.btnreportsalelist)
        Me.Panel1.Controls.Add(Me.btnreportsaleno)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 72)
        Me.Panel1.TabIndex = 0
        '
        'cbsupcategory
        '
        Me.cbsupcategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbsupcategory.DisplayMember = "Text"
        Me.cbsupcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsupcategory.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsupcategory.ForeColor = System.Drawing.Color.Blue
        Me.cbsupcategory.FormattingEnabled = True
        Me.cbsupcategory.ItemHeight = 28
        Me.cbsupcategory.Location = New System.Drawing.Point(591, 36)
        Me.cbsupcategory.Name = "cbsupcategory"
        Me.cbsupcategory.Size = New System.Drawing.Size(212, 34)
        Me.cbsupcategory.TabIndex = 259
        '
        'cbcategory
        '
        Me.cbcategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbcategory.DisplayMember = "Text"
        Me.cbcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcategory.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcategory.ForeColor = System.Drawing.Color.Blue
        Me.cbcategory.FormattingEnabled = True
        Me.cbcategory.ItemHeight = 28
        Me.cbcategory.Location = New System.Drawing.Point(591, 1)
        Me.cbcategory.Name = "cbcategory"
        Me.cbcategory.Size = New System.Drawing.Size(212, 34)
        Me.cbcategory.TabIndex = 257
        '
        'date2
        '
        Me.date2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date2.Location = New System.Drawing.Point(239, 19)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(139, 34)
        Me.date2.TabIndex = 254
        '
        'date1
        '
        Me.date1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date1.Location = New System.Drawing.Point(49, 19)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(156, 34)
        Me.date1.TabIndex = 253
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(1083, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 42)
        Me.Button1.TabIndex = 252
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.ForeColor = System.Drawing.Color.Blue
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.Location = New System.Drawing.Point(809, 14)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(106, 43)
        Me.ButtonX1.TabIndex = 207
        Me.ButtonX1.Text = "ລາຍງານ"
        '
        'btnreportsalelist
        '
        Me.btnreportsalelist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreportsalelist.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreportsalelist.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportsalelist.ForeColor = System.Drawing.Color.Blue
        Me.btnreportsalelist.Image = CType(resources.GetObject("btnreportsalelist.Image"), System.Drawing.Image)
        Me.btnreportsalelist.Location = New System.Drawing.Point(920, 14)
        Me.btnreportsalelist.Name = "btnreportsalelist"
        Me.btnreportsalelist.Size = New System.Drawing.Size(158, 43)
        Me.btnreportsalelist.TabIndex = 5
        Me.btnreportsalelist.Text = "ລາຍການທັງໝົດ"
        '
        'btnreportsaleno
        '
        Me.btnreportsaleno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreportsaleno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreportsaleno.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportsaleno.ForeColor = System.Drawing.Color.Blue
        Me.btnreportsaleno.Image = CType(resources.GetObject("btnreportsaleno.Image"), System.Drawing.Image)
        Me.btnreportsaleno.Location = New System.Drawing.Point(385, 16)
        Me.btnreportsaleno.Name = "btnreportsaleno"
        Me.btnreportsaleno.Size = New System.Drawing.Size(112, 41)
        Me.btnreportsaleno.TabIndex = 4
        Me.btnreportsaleno.Text = "ລາຍງານ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(209, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 24)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "ຫາ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(9, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 24)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "ວັນທີ:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(506, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 24)
        Me.Label14.TabIndex = 260
        Me.Label14.Text = "ປະເພດຍ່ອຍ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(504, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "ປະເພດຫລັກ:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 81)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1134, 440)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmreportsumaryproductin_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1140, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmreportsumaryproductin_out"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ລາຍງານການຂາຍປະຈໍາວັນ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnreportsaleno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnreportsalelist As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbsupcategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbcategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
