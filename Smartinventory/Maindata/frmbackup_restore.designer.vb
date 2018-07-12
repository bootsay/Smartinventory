<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbackup_restore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbackup_restore))
        Me.cmbdatabase = New System.Windows.Forms.ComboBox()
        Me.cmbserver = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnrestore = New DevComponents.DotNetBar.ButtonX()
        Me.btnbackup = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbdatabase
        '
        Me.cmbdatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbdatabase.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdatabase.FormattingEnabled = True
        Me.cmbdatabase.Location = New System.Drawing.Point(125, 71)
        Me.cmbdatabase.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmbdatabase.Name = "cmbdatabase"
        Me.cmbdatabase.Size = New System.Drawing.Size(528, 32)
        Me.cmbdatabase.TabIndex = 13
        '
        'cmbserver
        '
        Me.cmbserver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbserver.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbserver.FormattingEnabled = True
        Me.cmbserver.Location = New System.Drawing.Point(125, 35)
        Me.cmbserver.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmbserver.Name = "cmbserver"
        Me.cmbserver.Size = New System.Drawing.Size(528, 32)
        Me.cmbserver.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ຊື່ Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ຊຶ່ Server:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbdatabase)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbserver)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(661, 120)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ຂໍ້ມູນຖານຂໍ້ມູນ"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 215)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(661, 42)
        Me.ProgressBar1.TabIndex = 20
        Me.ProgressBar1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Bakup files (*.Bak)|*.Bak"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Bakup files (*.Bak)|*.Bak"
        '
        'Timer1
        '
        '
        'btnrestore
        '
        Me.btnrestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnrestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnrestore.Image = Global.Smartinventory.My.Resources.Resources.backup
        Me.btnrestore.Location = New System.Drawing.Point(447, 126)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(204, 79)
        Me.btnrestore.TabIndex = 22
        Me.btnrestore.Text = " Restore ກູ້ຖານຂໍ້ມູນ"
        '
        'btnbackup
        '
        Me.btnbackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbackup.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnbackup.Location = New System.Drawing.Point(218, 127)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(223, 79)
        Me.btnbackup.TabIndex = 21
        Me.btnbackup.Text = "Backup ສຳຮອງຖານຂໍ້ມູນ"
        '
        'frmbackup_restore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 257)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnbackup)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.Name = "frmbackup_restore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ສຳຮອງຂໍ້ມູນ ແລະ ກູ້ຂໍ້ມູນ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmbdatabase As System.Windows.Forms.ComboBox
    Public WithEvents cmbserver As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnbackup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnrestore As DevComponents.DotNetBar.ButtonX

End Class
