<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmupdateproduct
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
        Me.btnup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnup
        '
        Me.btnup.Location = New System.Drawing.Point(244, 69)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(147, 53)
        Me.btnup.TabIndex = 2
        Me.btnup.Text = "Updatew"
        Me.btnup.UseVisualStyleBackColor = True
        '
        'frmupdateproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 330)
        Me.Controls.Add(Me.btnup)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmupdateproduct"
        Me.Text = "frmupdateproduct"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnup As System.Windows.Forms.Button
End Class
