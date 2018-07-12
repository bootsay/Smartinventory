<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsetupbackup
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsetupbackup))
        Me.cbdatabasename = New System.Windows.Forms.ComboBox()
        Me.cbservername = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnrestore = New DevComponents.DotNetBar.ButtonX()
        Me.btnbackup = New DevComponents.DotNetBar.ButtonX()
        Me.dgvshow = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txttimebackup = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout
        CType(Me.dgvshow,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cbdatabasename
        '
        Me.cbdatabasename.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbdatabasename.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbdatabasename.FormattingEnabled = true
        Me.cbdatabasename.Location = New System.Drawing.Point(116, 82)
        Me.cbdatabasename.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbdatabasename.Name = "cbdatabasename"
        Me.cbdatabasename.Size = New System.Drawing.Size(489, 30)
        Me.cbdatabasename.TabIndex = 13
        '
        'cbservername
        '
        Me.cbservername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbservername.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbservername.FormattingEnabled = true
        Me.cbservername.Location = New System.Drawing.Point(116, 49)
        Me.cbservername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbservername.Name = "cbservername"
        Me.cbservername.Size = New System.Drawing.Size(489, 30)
        Me.cbservername.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "DatabaseName:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ServerName:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttimebackup)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbdatabasename)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbservername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(622, 155)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ID:"
        '
        'txtid
        '
        Me.txtid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtid.Location = New System.Drawing.Point(117, 17)
        Me.txtid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(488, 29)
        Me.txtid.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Time:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Bakup files (*.Bak)|*.Bak"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Bakup files (*.Bak)|*.Bak"
        '
        'btnrestore
        '
        Me.btnrestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnrestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnrestore.Image = Global.Smartinventory.My.Resources.Resources.Refresh
        Me.btnrestore.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnrestore.Location = New System.Drawing.Point(357, 162)
        Me.btnrestore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(202, 46)
        Me.btnrestore.TabIndex = 22
        Me.btnrestore.Text = "Update"
        '
        'btnbackup
        '
        Me.btnbackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbackup.Image = Global.Smartinventory.My.Resources.Resources.Save_icon
        Me.btnbackup.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnbackup.Location = New System.Drawing.Point(128, 162)
        Me.btnbackup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(223, 46)
        Me.btnbackup.TabIndex = 21
        Me.btnbackup.Text = "Save"
        '
        'dgvshow
        '
        Me.dgvshow.AllowUserToAddRows = false
        Me.dgvshow.AllowUserToDeleteRows = false
        Me.dgvshow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvshow.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvshow.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvshow.GridColor = System.Drawing.Color.FromArgb(CType(CType(208,Byte),Integer), CType(CType(215,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.dgvshow.Location = New System.Drawing.Point(0, 213)
        Me.dgvshow.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvshow.Name = "dgvshow"
        Me.dgvshow.ReadOnly = true
        Me.dgvshow.RowHeadersVisible = false
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.dgvshow.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvshow.RowTemplate.Height = 28
        Me.dgvshow.Size = New System.Drawing.Size(622, 189)
        Me.dgvshow.TabIndex = 23
        '
        'txttimebackup
        '
        Me.txttimebackup.CustomFormat = "hh:mm tt"
        Me.txttimebackup.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttimebackup.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttimebackup.Location = New System.Drawing.Point(117, 117)
        Me.txttimebackup.Name = "txttimebackup"
        Me.txttimebackup.ShowUpDown = True
        Me.txttimebackup.Size = New System.Drawing.Size(488, 29)
        Me.txttimebackup.TabIndex = 21
        Me.txttimebackup.Value = New Date(2018, 2, 13, 17, 44, 1, 0)
        '
        'frmsetupbackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 19!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194,Byte),Integer), CType(CType(217,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(622, 403)
        Me.Controls.Add(Me.dgvshow)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnbackup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = false
        Me.Name = "frmsetupbackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaveBackup"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.dgvshow,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Public WithEvents cbdatabasename As System.Windows.Forms.ComboBox
    Public WithEvents cbservername As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnbackup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnrestore As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents dgvshow As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txttimebackup As System.Windows.Forms.DateTimePicker

End Class
