<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconfig
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnreceive = New DevComponents.DotNetBar.ButtonX()
        Me.btnorder = New DevComponents.DotNetBar.ButtonX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnclearsale = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtremindbeforepay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnextpaydate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsale = New DevComponents.DotNetBar.ButtonX()
        Me.btnclose = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnreceive)
        Me.GroupPanel1.Controls.Add(Me.btnorder)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.btnclearsale)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.txtremindbeforepay)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.txtnextpaydate)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.btnsale)
        Me.GroupPanel1.Controls.Add(Me.btnclose)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(808, 482)
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
        Me.GroupPanel1.Text = "ປັບປຸງລະບົບ"
        '
        'btnreceive
        '
        Me.btnreceive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreceive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnreceive.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnreceive.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnreceive.Location = New System.Drawing.Point(283, 184)
        Me.btnreceive.Name = "btnreceive"
        Me.btnreceive.Size = New System.Drawing.Size(254, 35)
        Me.btnreceive.TabIndex = 28
        Me.btnreceive.Text = "ລ້າງຂໍ້ມູນຮັບສີນຄ້າ"
        Me.btnreceive.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnorder
        '
        Me.btnorder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnorder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnorder.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnorder.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnorder.Location = New System.Drawing.Point(283, 143)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(254, 35)
        Me.btnorder.TabIndex = 27
        Me.btnorder.Text = "ລ້າງຂໍ້ມູນສັ່ງຊື້"
        Me.btnorder.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(41, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 24)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "ລ້າງຂໍ້ມູນຮັບສີນຄ້າ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(41, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ລ້າງຂໍ້ມູນສັ່ງຊື້:"
        '
        'btnclearsale
        '
        Me.btnclearsale.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclearsale.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclearsale.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnclearsale.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnclearsale.Location = New System.Drawing.Point(283, 104)
        Me.btnclearsale.Name = "btnclearsale"
        Me.btnclearsale.Size = New System.Drawing.Size(254, 35)
        Me.btnclearsale.TabIndex = 24
        Me.btnclearsale.Text = "ລ້າງຂໍ້ມູນການຂາຍ"
        Me.btnclearsale.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(41, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ລ້າງຂໍ້ມູນການຂາຍ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(543, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "/ ວັນ:"
        '
        'txtremindbeforepay
        '
        Me.txtremindbeforepay.Location = New System.Drawing.Point(283, 65)
        Me.txtremindbeforepay.Name = "txtremindbeforepay"
        Me.txtremindbeforepay.Size = New System.Drawing.Size(254, 34)
        Me.txtremindbeforepay.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(41, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(236, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "ແຈ້ງເຕືອນລູກຄ້າຕິດໜີ້ກ່ອນມື້ຈ່າຍເງີນ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(543, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "/ ວັນ:"
        '
        'txtnextpaydate
        '
        Me.txtnextpaydate.Location = New System.Drawing.Point(283, 29)
        Me.txtnextpaydate.Name = "txtnextpaydate"
        Me.txtnextpaydate.Size = New System.Drawing.Size(254, 34)
        Me.txtnextpaydate.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(41, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "ກໍານົດວັນຈ່າຍເງີນລ່ວງໜ້າ:"
        '
        'btnsale
        '
        Me.btnsale.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsale.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsale.Image = Global.Smartinventory.My.Resources.Resources.Save
        Me.btnsale.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnsale.Location = New System.Drawing.Point(283, 248)
        Me.btnsale.Name = "btnsale"
        Me.btnsale.Size = New System.Drawing.Size(85, 35)
        Me.btnsale.TabIndex = 14
        Me.btnsale.Text = "ບັນທືກ"
        '
        'btnclose
        '
        Me.btnclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclose.Image = Global.Smartinventory.My.Resources.Resources._1489493744_exit
        Me.btnclose.Location = New System.Drawing.Point(724, 3)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 35)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "ປິດ"
        '
        'frmconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmconfig"
        Me.Text = "frmconfig"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnclose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsale As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnextpaydate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtremindbeforepay As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnclearsale As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnorder As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnreceive As DevComponents.DotNetBar.ButtonX
End Class
