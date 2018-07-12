<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreturnproductlist
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rdnotsent = New System.Windows.Forms.RadioButton()
        Me.rdsent = New System.Windows.Forms.RadioButton()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rdall = New System.Windows.Forms.RadioButton()
        Me.rddate = New System.Windows.Forms.RadioButton()
        Me.showreturn = New DevComponents.DotNetBar.ButtonX()
        Me.btnclose = New DevComponents.DotNetBar.ButtonX()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cbstatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.btnshowdetail = New DevComponents.DotNetBar.ButtonX()
        Me.dt2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnshow = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rdcustomer = New System.Windows.Forms.RadioButton()
        Me.rdstatus = New System.Windows.Forms.RadioButton()
        Me.rdno = New System.Windows.Forms.RadioButton()
        Me.dgvsalelist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dgvsalelist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvsalelist, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1134, 482)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupPanel3)
        Me.Panel1.Controls.Add(Me.GroupPanel2)
        Me.Panel1.Controls.Add(Me.showreturn)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.cbstatus)
        Me.Panel1.Controls.Add(Me.btnshowdetail)
        Me.Panel1.Controls.Add(Me.dt2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dt1)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 87)
        Me.Panel1.TabIndex = 1
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.rdnotsent)
        Me.GroupPanel3.Controls.Add(Me.rdsent)
        Me.GroupPanel3.Location = New System.Drawing.Point(664, 47)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(230, 37)
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
        Me.GroupPanel3.TabIndex = 16
        '
        'rdnotsent
        '
        Me.rdnotsent.AutoSize = True
        Me.rdnotsent.BackColor = System.Drawing.Color.Transparent
        Me.rdnotsent.Location = New System.Drawing.Point(110, 2)
        Me.rdnotsent.Name = "rdnotsent"
        Me.rdnotsent.Size = New System.Drawing.Size(95, 28)
        Me.rdnotsent.TabIndex = 2
        Me.rdnotsent.TabStop = True
        Me.rdnotsent.Text = "ຍັງບໍ່ທັນສົ່ງ"
        Me.rdnotsent.UseVisualStyleBackColor = False
        '
        'rdsent
        '
        Me.rdsent.AutoSize = True
        Me.rdsent.BackColor = System.Drawing.Color.Transparent
        Me.rdsent.Location = New System.Drawing.Point(30, 2)
        Me.rdsent.Name = "rdsent"
        Me.rdsent.Size = New System.Drawing.Size(76, 28)
        Me.rdsent.TabIndex = 1
        Me.rdsent.TabStop = True
        Me.rdsent.Text = "ສົ່ງແລ້ວ"
        Me.rdsent.UseVisualStyleBackColor = False
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.rdall)
        Me.GroupPanel2.Controls.Add(Me.rddate)
        Me.GroupPanel2.Location = New System.Drawing.Point(9, 47)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(294, 37)
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
        Me.GroupPanel2.TabIndex = 15
        '
        'rdall
        '
        Me.rdall.AutoSize = True
        Me.rdall.BackColor = System.Drawing.Color.Transparent
        Me.rdall.Location = New System.Drawing.Point(96, 2)
        Me.rdall.Name = "rdall"
        Me.rdall.Size = New System.Drawing.Size(72, 28)
        Me.rdall.TabIndex = 2
        Me.rdall.TabStop = True
        Me.rdall.Text = "ທັງໜົດ"
        Me.rdall.UseVisualStyleBackColor = False
        '
        'rddate
        '
        Me.rddate.AutoSize = True
        Me.rddate.BackColor = System.Drawing.Color.Transparent
        Me.rddate.Location = New System.Drawing.Point(16, 2)
        Me.rddate.Name = "rddate"
        Me.rddate.Size = New System.Drawing.Size(59, 28)
        Me.rddate.TabIndex = 1
        Me.rddate.TabStop = True
        Me.rddate.Text = "ວັນທີ"
        Me.rddate.UseVisualStyleBackColor = False
        '
        'showreturn
        '
        Me.showreturn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.showreturn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.showreturn.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.showreturn.Image = Global.Smartinventory.My.Resources.Resources.edit_gnote_icon
        Me.showreturn.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.showreturn.Location = New System.Drawing.Point(898, 7)
        Me.showreturn.Name = "showreturn"
        Me.showreturn.Size = New System.Drawing.Size(154, 38)
        Me.showreturn.TabIndex = 14
        Me.showreturn.Text = "ສ້າງໃບສົ່ງສີນຄ້າ"
        '
        'btnclose
        '
        Me.btnclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclose.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnclose.Image = Global.Smartinventory.My.Resources.Resources._1489493744_exit
        Me.btnclose.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnclose.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnclose.Location = New System.Drawing.Point(1056, 7)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(39, 37)
        Me.btnclose.TabIndex = 13
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(305, 9)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(353, 35)
        Me.txtsearch.TabIndex = 11
        '
        'cbstatus
        '
        Me.cbstatus.DisplayMember = "Text"
        Me.cbstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.ItemHeight = 29
        Me.cbstatus.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cbstatus.Location = New System.Drawing.Point(306, 9)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(352, 35)
        Me.cbstatus.TabIndex = 6
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "ທັງໜົດ"
        Me.ComboItem1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "ຮັບແລ້ວ"
        Me.ComboItem2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "ຍັງບໍ່ຮັບ"
        Me.ComboItem3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ComboItem4
        '
        Me.ComboItem4.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center
        Me.ComboItem4.Text = "ຍົກເລີກ"
        '
        'btnshowdetail
        '
        Me.btnshowdetail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshowdetail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshowdetail.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnshowdetail.Image = Global.Smartinventory.My.Resources.Resources.list1
        Me.btnshowdetail.Location = New System.Drawing.Point(775, 7)
        Me.btnshowdetail.Name = "btnshowdetail"
        Me.btnshowdetail.Size = New System.Drawing.Size(119, 38)
        Me.btnshowdetail.TabIndex = 12
        Me.btnshowdetail.Text = "ລາຍລະອຽດ"
        '
        'dt2
        '
        '
        '
        '
        Me.dt2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt2.ButtonDropDown.Visible = True
        Me.dt2.Location = New System.Drawing.Point(513, 49)
        '
        '
        '
        Me.dt2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt2.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dt2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt2.MonthCalendar.DisplayMonth = New Date(2017, 11, 1, 0, 0, 0, 0)
        Me.dt2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt2.MonthCalendar.TodayButtonVisible = True
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(145, 35)
        Me.dt2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(473, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ຫາ:"
        '
        'dt1
        '
        '
        '
        '
        Me.dt1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt1.ButtonDropDown.Visible = True
        Me.dt1.Location = New System.Drawing.Point(305, 49)
        '
        '
        '
        Me.dt1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dt1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt1.MonthCalendar.DisplayMonth = New Date(2017, 11, 1, 0, 0, 0, 0)
        Me.dt1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt1.MonthCalendar.TodayButtonVisible = True
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(163, 35)
        Me.dt1.TabIndex = 8
        '
        'btnshow
        '
        Me.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshow.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnshow.Image = Global.Smartinventory.My.Resources.Resources.Search
        Me.btnshow.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnshow.Location = New System.Drawing.Point(664, 7)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(107, 38)
        Me.btnshow.TabIndex = 7
        Me.btnshow.Text = "ສະແດງ"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rdcustomer)
        Me.GroupPanel1.Controls.Add(Me.rdstatus)
        Me.GroupPanel1.Controls.Add(Me.rdno)
        Me.GroupPanel1.Location = New System.Drawing.Point(9, 7)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(294, 37)
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
        Me.GroupPanel1.TabIndex = 5
        '
        'rdcustomer
        '
        Me.rdcustomer.AutoSize = True
        Me.rdcustomer.BackColor = System.Drawing.Color.Transparent
        Me.rdcustomer.Location = New System.Drawing.Point(194, 1)
        Me.rdcustomer.Name = "rdcustomer"
        Me.rdcustomer.Size = New System.Drawing.Size(66, 28)
        Me.rdcustomer.TabIndex = 3
        Me.rdcustomer.TabStop = True
        Me.rdcustomer.Text = "ລູກຄ້າ"
        Me.rdcustomer.UseVisualStyleBackColor = False
        '
        'rdstatus
        '
        Me.rdstatus.AutoSize = True
        Me.rdstatus.BackColor = System.Drawing.Color.Transparent
        Me.rdstatus.Location = New System.Drawing.Point(96, 0)
        Me.rdstatus.Name = "rdstatus"
        Me.rdstatus.Size = New System.Drawing.Size(84, 28)
        Me.rdstatus.TabIndex = 2
        Me.rdstatus.TabStop = True
        Me.rdstatus.Text = "ສະຖານະ"
        Me.rdstatus.UseVisualStyleBackColor = False
        '
        'rdno
        '
        Me.rdno.AutoSize = True
        Me.rdno.BackColor = System.Drawing.Color.Transparent
        Me.rdno.Location = New System.Drawing.Point(16, 1)
        Me.rdno.Name = "rdno"
        Me.rdno.Size = New System.Drawing.Size(65, 28)
        Me.rdno.TabIndex = 1
        Me.rdno.TabStop = True
        Me.rdno.Text = "ເລກທີ"
        Me.rdno.UseVisualStyleBackColor = False
        '
        'dgvsalelist
        '
        Me.dgvsalelist.AllowUserToAddRows = False
        Me.dgvsalelist.AllowUserToDeleteRows = False
        Me.dgvsalelist.AllowUserToResizeColumns = False
        Me.dgvsalelist.AllowUserToResizeRows = False
        Me.dgvsalelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsalelist.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsalelist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvsalelist.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvsalelist.Location = New System.Drawing.Point(3, 96)
        Me.dgvsalelist.Name = "dgvsalelist"
        Me.dgvsalelist.ReadOnly = True
        Me.dgvsalelist.RowHeadersVisible = False
        Me.dgvsalelist.RowTemplate.Height = 28
        Me.dgvsalelist.Size = New System.Drawing.Size(1128, 383)
        Me.dgvsalelist.TabIndex = 0
        '
        'frmreturnproductlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1134, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmreturnproductlist"
        Me.Text = "frmsalelist"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.dgvsalelist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvsalelist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdstatus As System.Windows.Forms.RadioButton
    Friend WithEvents rdno As System.Windows.Forms.RadioButton
    Friend WithEvents dt2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnshow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbstatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents rdcustomer As System.Windows.Forms.RadioButton
    Friend WithEvents btnshowdetail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnclose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents showreturn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdall As System.Windows.Forms.RadioButton
    Friend WithEvents rddate As System.Windows.Forms.RadioButton
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdnotsent As System.Windows.Forms.RadioButton
    Friend WithEvents rdsent As System.Windows.Forms.RadioButton
End Class
