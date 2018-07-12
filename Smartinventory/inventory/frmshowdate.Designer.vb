<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshowdate
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
        Me.dt = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnok = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt
        '
        '
        '
        '
        Me.dt.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt.ButtonDropDown.Visible = True
        Me.dt.Dock = System.Windows.Forms.DockStyle.Top
        Me.dt.Font = New System.Drawing.Font("Saysettha OT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dt.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.dt.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dt.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt.MonthCalendar.DisplayMonth = New Date(2017, 12, 1, 0, 0, 0, 0)
        Me.dt.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt.MonthCalendar.TodayButtonVisible = True
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(426, 41)
        Me.dt.TabIndex = 0
        '
        'btnok
        '
        Me.btnok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnok.Location = New System.Drawing.Point(149, 54)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(118, 54)
        Me.btnok.TabIndex = 1
        Me.btnok.Text = "ຕົກລົງ"
        '
        'frmshowdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 123)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.dt)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmshowdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ເລືອກວັນທີ"
        CType(Me.dt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnok As DevComponents.DotNetBar.ButtonX
End Class
