<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsetmoney
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
        Me.rdkip = New System.Windows.Forms.RadioButton()
        Me.rdbth = New System.Windows.Forms.RadioButton()
        Me.rdusd = New System.Windows.Forms.RadioButton()
        Me.dgvlist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnsave = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdkip
        '
        Me.rdkip.AutoSize = True
        Me.rdkip.Location = New System.Drawing.Point(105, 12)
        Me.rdkip.Name = "rdkip"
        Me.rdkip.Size = New System.Drawing.Size(48, 28)
        Me.rdkip.TabIndex = 0
        Me.rdkip.TabStop = True
        Me.rdkip.Text = "ກີບ"
        Me.rdkip.UseVisualStyleBackColor = True
        '
        'rdbth
        '
        Me.rdbth.AutoSize = True
        Me.rdbth.Location = New System.Drawing.Point(223, 12)
        Me.rdbth.Name = "rdbth"
        Me.rdbth.Size = New System.Drawing.Size(56, 28)
        Me.rdbth.TabIndex = 1
        Me.rdbth.TabStop = True
        Me.rdbth.Text = "ບາດ"
        Me.rdbth.UseVisualStyleBackColor = True
        '
        'rdusd
        '
        Me.rdusd.AutoSize = True
        Me.rdusd.Location = New System.Drawing.Point(343, 12)
        Me.rdusd.Name = "rdusd"
        Me.rdusd.Size = New System.Drawing.Size(65, 28)
        Me.rdusd.TabIndex = 2
        Me.rdusd.TabStop = True
        Me.rdusd.Text = "ໂດລາ"
        Me.rdusd.UseVisualStyleBackColor = True
        '
        'dgvlist
        '
        Me.dgvlist.AllowUserToAddRows = False
        Me.dgvlist.AllowUserToDeleteRows = False
        Me.dgvlist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlist.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlist.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlist.Location = New System.Drawing.Point(12, 110)
        Me.dgvlist.Name = "dgvlist"
        Me.dgvlist.ReadOnly = True
        Me.dgvlist.RowHeadersVisible = False
        Me.dgvlist.RowTemplate.Height = 30
        Me.dgvlist.Size = New System.Drawing.Size(529, 222)
        Me.dgvlist.TabIndex = 3
        '
        'btnsave
        '
        Me.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsave.Location = New System.Drawing.Point(166, 46)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(177, 49)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "ບັນທືກ"
        '
        'frmsetmoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 334)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dgvlist)
        Me.Controls.Add(Me.rdusd)
        Me.Controls.Add(Me.rdbth)
        Me.Controls.Add(Me.rdkip)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmsetmoney"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tbsetmainmoney"
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdkip As System.Windows.Forms.RadioButton
    Friend WithEvents rdbth As System.Windows.Forms.RadioButton
    Friend WithEvents rdusd As System.Windows.Forms.RadioButton
    Friend WithEvents dgvlist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
End Class
