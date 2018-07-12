<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportincome_outcomedetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportincome_outcomedetail))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdall = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rddate = New System.Windows.Forms.RadioButton()
        Me.cbtype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.rdtype = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnshow = New DevComponents.DotNetBar.ButtonX()
        Me.dt2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CrystalReportViewer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07133!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.92867!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdall)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Controls.Add(Me.cbtype)
        Me.Panel1.Controls.Add(Me.rdtype)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.dt2)
        Me.Panel1.Controls.Add(Me.dt1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 81)
        Me.Panel1.TabIndex = 0
        '
        'rdall
        '
        Me.rdall.AutoSize = True
        Me.rdall.BackColor = System.Drawing.Color.Transparent
        Me.rdall.Location = New System.Drawing.Point(115, 46)
        Me.rdall.Name = "rdall"
        Me.rdall.Size = New System.Drawing.Size(76, 28)
        Me.rdall.TabIndex = 6
        Me.rdall.TabStop = True
        Me.rdall.Text = "ທັງໜົດ:"
        Me.rdall.UseVisualStyleBackColor = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rddate)
        Me.GroupPanel1.Location = New System.Drawing.Point(17, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(226, 37)
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
        Me.GroupPanel1.TabIndex = 8
        '
        'rddate
        '
        Me.rddate.AutoSize = True
        Me.rddate.BackColor = System.Drawing.Color.Transparent
        Me.rddate.Location = New System.Drawing.Point(7, 3)
        Me.rddate.Name = "rddate"
        Me.rddate.Size = New System.Drawing.Size(63, 28)
        Me.rddate.TabIndex = 5
        Me.rddate.TabStop = True
        Me.rddate.Text = "ວັັນທີ:"
        Me.rddate.UseVisualStyleBackColor = False
        '
        'cbtype
        '
        Me.cbtype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbtype.DisplayMember = "Text"
        Me.cbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtype.Font = New System.Drawing.Font("Saysettha OT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.ItemHeight = 31
        Me.cbtype.Location = New System.Drawing.Point(249, 41)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(464, 37)
        Me.cbtype.TabIndex = 7
        '
        'rdtype
        '
        Me.rdtype.AutoSize = True
        Me.rdtype.BackColor = System.Drawing.Color.Transparent
        Me.rdtype.Location = New System.Drawing.Point(23, 46)
        Me.rdtype.Name = "rdtype"
        Me.rdtype.Size = New System.Drawing.Size(73, 28)
        Me.rdtype.TabIndex = 6
        Me.rdtype.TabStop = True
        Me.rdtype.Text = "ປະເພດ"
        Me.rdtype.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ຫາ:"
        '
        'btnshow
        '
        Me.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshow.Image = Global.Smartinventory.My.Resources.Resources.Search
        Me.btnshow.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnshow.Location = New System.Drawing.Point(719, 4)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(97, 74)
        Me.btnshow.TabIndex = 2
        Me.btnshow.Text = "ສະແດງ"
        '
        'dt2
        '
        Me.dt2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dt2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt2.ButtonDropDown.Visible = True
        Me.dt2.Location = New System.Drawing.Point(491, 4)
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
        Me.dt2.MonthCalendar.DisplayMonth = New Date(2018, 1, 1, 0, 0, 0, 0)
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
        Me.dt2.Size = New System.Drawing.Size(222, 35)
        Me.dt2.TabIndex = 1
        '
        'dt1
        '
        '
        '
        '
        Me.dt1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt1.ButtonDropDown.Visible = True
        Me.dt1.Location = New System.Drawing.Point(249, 4)
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
        Me.dt1.MonthCalendar.DisplayMonth = New Date(2018, 1, 1, 0, 0, 0, 0)
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
        Me.dt1.Size = New System.Drawing.Size(200, 35)
        Me.dt1.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 90)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1002, 636)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmreportincome_outcomedetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmreportincome_outcomedetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ລາຍງານລາຍຮັບ-ຈ່າຍ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnshow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dt2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dt1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdtype As System.Windows.Forms.RadioButton
    Friend WithEvents rddate As System.Windows.Forms.RadioButton
    Friend WithEvents cbtype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdall As System.Windows.Forms.RadioButton
End Class
