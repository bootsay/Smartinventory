<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportsummarydebitcustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportsummarydebitcustomer))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbsalename = New System.Windows.Forms.CheckBox()
        Me.cbcus = New System.Windows.Forms.CheckBox()
        Me.rdall = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rdbyall = New System.Windows.Forms.RadioButton()
        Me.rdbybill = New System.Windows.Forms.RadioButton()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.rddate = New System.Windows.Forms.RadioButton()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbsalename)
        Me.Panel1.Controls.Add(Me.cbcus)
        Me.Panel1.Controls.Add(Me.rdall)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Controls.Add(Me.txtcustomer)
        Me.Panel1.Controls.Add(Me.rddate)
        Me.Panel1.Controls.Add(Me.date2)
        Me.Panel1.Controls.Add(Me.date1)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 88)
        Me.Panel1.TabIndex = 0
        '
        'cbsalename
        '
        Me.cbsalename.AutoSize = True
        Me.cbsalename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbsalename.Location = New System.Drawing.Point(419, 11)
        Me.cbsalename.Name = "cbsalename"
        Me.cbsalename.Size = New System.Drawing.Size(95, 28)
        Me.cbsalename.TabIndex = 274
        Me.cbsalename.Text = "ຜູ້ອອກບີນ"
        Me.cbsalename.UseVisualStyleBackColor = True
        '
        'cbcus
        '
        Me.cbcus.AutoSize = True
        Me.cbcus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbcus.Location = New System.Drawing.Point(311, 12)
        Me.cbcus.Name = "cbcus"
        Me.cbcus.Size = New System.Drawing.Size(95, 28)
        Me.cbcus.TabIndex = 273
        Me.cbcus.Text = "ຜູ້ສະໜອງ"
        Me.cbcus.UseVisualStyleBackColor = True
        '
        'rdall
        '
        Me.rdall.AutoSize = True
        Me.rdall.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdall.ForeColor = System.Drawing.Color.Blue
        Me.rdall.Location = New System.Drawing.Point(9, 43)
        Me.rdall.Name = "rdall"
        Me.rdall.Size = New System.Drawing.Size(69, 28)
        Me.rdall.TabIndex = 272
        Me.rdall.TabStop = True
        Me.rdall.Text = "ທັງໜົດ"
        Me.rdall.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(647, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 35)
        Me.Button2.TabIndex = 271
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rdbyall)
        Me.GroupPanel1.Controls.Add(Me.rdbybill)
        Me.GroupPanel1.Location = New System.Drawing.Point(520, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(167, 40)
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
        Me.GroupPanel1.TabIndex = 270
        '
        'rdbyall
        '
        Me.rdbyall.AutoSize = True
        Me.rdbyall.BackColor = System.Drawing.Color.Transparent
        Me.rdbyall.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbyall.ForeColor = System.Drawing.Color.Blue
        Me.rdbyall.Location = New System.Drawing.Point(84, 3)
        Me.rdbyall.Name = "rdbyall"
        Me.rdbyall.Size = New System.Drawing.Size(74, 28)
        Me.rdbyall.TabIndex = 266
        Me.rdbyall.TabStop = True
        Me.rdbyall.Text = "ສັງລວມ"
        Me.rdbyall.UseVisualStyleBackColor = False
        '
        'rdbybill
        '
        Me.rdbybill.AutoSize = True
        Me.rdbybill.BackColor = System.Drawing.Color.Transparent
        Me.rdbybill.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbybill.ForeColor = System.Drawing.Color.Blue
        Me.rdbybill.Location = New System.Drawing.Point(4, 4)
        Me.rdbybill.Name = "rdbybill"
        Me.rdbybill.Size = New System.Drawing.Size(76, 28)
        Me.rdbybill.TabIndex = 265
        Me.rdbybill.TabStop = True
        Me.rdbybill.Text = "ແຍກບີນ"
        Me.rdbybill.UseVisualStyleBackColor = False
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(307, 46)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(337, 34)
        Me.txtcustomer.TabIndex = 268
        '
        'rddate
        '
        Me.rddate.AutoSize = True
        Me.rddate.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rddate.ForeColor = System.Drawing.Color.Blue
        Me.rddate.Location = New System.Drawing.Point(9, 9)
        Me.rddate.Name = "rddate"
        Me.rddate.Size = New System.Drawing.Size(84, 28)
        Me.rddate.TabIndex = 263
        Me.rddate.TabStop = True
        Me.rddate.Text = "ຕາມວັນທີ"
        Me.rddate.UseVisualStyleBackColor = True
        '
        'date2
        '
        Me.date2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date2.Location = New System.Drawing.Point(152, 46)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(149, 34)
        Me.date2.TabIndex = 254
        '
        'date1
        '
        Me.date1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date1.Location = New System.Drawing.Point(152, 9)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(149, 34)
        Me.date1.TabIndex = 253
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.ForeColor = System.Drawing.Color.Blue
        Me.ButtonX1.Image = Global.Smartinventory.My.Resources.Resources.Report
        Me.ButtonX1.Location = New System.Drawing.Point(698, 6)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(106, 74)
        Me.ButtonX1.TabIndex = 207
        Me.ButtonX1.Text = "ລາຍງານ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(120, 51)
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
        Me.Label2.Location = New System.Drawing.Point(110, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 24)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "ວັນທີ:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 97)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1002, 629)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmreportsummarydebitcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmreportsummarydebitcustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ລາຍງານສັງລວມຕິດໜີ້ລູກຄ້າ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rddate As System.Windows.Forms.RadioButton
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdbyall As System.Windows.Forms.RadioButton
    Friend WithEvents rdbybill As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rdall As System.Windows.Forms.RadioButton
    Friend WithEvents cbsalename As System.Windows.Forms.CheckBox
    Friend WithEvents cbcus As System.Windows.Forms.CheckBox
End Class
