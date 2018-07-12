<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportsaledetaillist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportsaledetaillist))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbstatusapprove = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.r5 = New System.Windows.Forms.RadioButton()
        Me.r4 = New System.Windows.Forms.RadioButton()
        Me.r3 = New System.Windows.Forms.RadioButton()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.cmbosalename = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.cbstatusapprove)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Controls.Add(Me.txtcustomer)
        Me.Panel1.Controls.Add(Me.cmbosalename)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.date2)
        Me.Panel1.Controls.Add(Me.date1)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 83)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(75, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 34)
        Me.TextBox1.TabIndex = 275
        '
        'cbstatusapprove
        '
        Me.cbstatusapprove.DisplayMember = "Text"
        Me.cbstatusapprove.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbstatusapprove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbstatusapprove.FormattingEnabled = True
        Me.cbstatusapprove.ItemHeight = 28
        Me.cbstatusapprove.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cbstatusapprove.Location = New System.Drawing.Point(75, 6)
        Me.cbstatusapprove.Name = "cbstatusapprove"
        Me.cbstatusapprove.Size = New System.Drawing.Size(143, 34)
        Me.cbstatusapprove.TabIndex = 274
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "ທັງໜົດ"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "ອະນຸມັດ"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "ຍັງບໍອະນຸມັດ"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "ຍົກເລີກ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(1, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 273
        Me.Label3.Text = "ສະຖານະ:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(688, 41)
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
        Me.GroupPanel1.Controls.Add(Me.r5)
        Me.GroupPanel1.Controls.Add(Me.r4)
        Me.GroupPanel1.Controls.Add(Me.r3)
        Me.GroupPanel1.Location = New System.Drawing.Point(738, 5)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(146, 71)
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
        'r5
        '
        Me.r5.AutoSize = True
        Me.r5.BackColor = System.Drawing.Color.Transparent
        Me.r5.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r5.ForeColor = System.Drawing.Color.Blue
        Me.r5.Location = New System.Drawing.Point(22, 33)
        Me.r5.Name = "r5"
        Me.r5.Size = New System.Drawing.Size(70, 28)
        Me.r5.TabIndex = 267
        Me.r5.TabStop = True
        Me.r5.Text = "ທັງໝົດ"
        Me.r5.UseVisualStyleBackColor = False
        '
        'r4
        '
        Me.r4.AutoSize = True
        Me.r4.BackColor = System.Drawing.Color.Transparent
        Me.r4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r4.ForeColor = System.Drawing.Color.Blue
        Me.r4.Location = New System.Drawing.Point(76, 4)
        Me.r4.Name = "r4"
        Me.r4.Size = New System.Drawing.Size(61, 28)
        Me.r4.TabIndex = 266
        Me.r4.TabStop = True
        Me.r4.Text = "ຕິດໜີ້"
        Me.r4.UseVisualStyleBackColor = False
        '
        'r3
        '
        Me.r3.AutoSize = True
        Me.r3.BackColor = System.Drawing.Color.Transparent
        Me.r3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r3.ForeColor = System.Drawing.Color.Blue
        Me.r3.Location = New System.Drawing.Point(22, 4)
        Me.r3.Name = "r3"
        Me.r3.Size = New System.Drawing.Size(48, 28)
        Me.r3.TabIndex = 265
        Me.r3.TabStop = True
        Me.r3.Text = "ສົດ"
        Me.r3.UseVisualStyleBackColor = False
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(486, 41)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(200, 34)
        Me.txtcustomer.TabIndex = 268
        '
        'cmbosalename
        '
        Me.cmbosalename.DisplayMember = "Text"
        Me.cmbosalename.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbosalename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbosalename.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbosalename.ForeColor = System.Drawing.Color.Blue
        Me.cmbosalename.FormattingEnabled = True
        Me.cmbosalename.ItemHeight = 28
        Me.cmbosalename.Location = New System.Drawing.Point(486, 5)
        Me.cmbosalename.Name = "cmbosalename"
        Me.cmbosalename.Size = New System.Drawing.Size(242, 34)
        Me.cmbosalename.TabIndex = 267
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(410, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 266
        Me.Label6.Text = "ພ/ງ ຂາຍ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(430, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 24)
        Me.Label5.TabIndex = 265
        Me.Label5.Text = "ລູກຄ້າ:"
        '
        'date2
        '
        Me.date2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date2.Location = New System.Drawing.Point(258, 40)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(149, 34)
        Me.date2.TabIndex = 254
        '
        'date1
        '
        Me.date1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date1.Location = New System.Drawing.Point(258, 5)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(149, 34)
        Me.date1.TabIndex = 253
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(228, 45)
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
        Me.Label2.Location = New System.Drawing.Point(216, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 24)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "ວັນທີ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(1, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 276
        Me.Label4.Text = "ລະຫັດບິນ:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 92)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1002, 634)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.ForeColor = System.Drawing.Color.Blue
        Me.ButtonX1.Image = Global.Smartinventory.My.Resources.Resources.Report
        Me.ButtonX1.Location = New System.Drawing.Point(890, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(106, 71)
        Me.ButtonX1.TabIndex = 207
        Me.ButtonX1.Text = "ລາຍງານ"
        '
        'frmreportsaledetaillist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmreportsaledetaillist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ລາຍງານການອອກໃບບິນ"
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
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents cmbosalename As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents r5 As System.Windows.Forms.RadioButton
    Friend WithEvents r4 As System.Windows.Forms.RadioButton
    Friend WithEvents r3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbstatusapprove As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
