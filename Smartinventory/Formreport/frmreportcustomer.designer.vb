<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportcustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportcustomer))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnshow = New DevComponents.DotNetBar.ButtonX()
        Me.cbcustomer = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.rdspecific = New System.Windows.Forms.RadioButton()
        Me.rdall = New System.Windows.Forms.RadioButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.cbcustomer)
        Me.Panel1.Controls.Add(Me.rdspecific)
        Me.Panel1.Controls.Add(Me.rdall)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 44)
        Me.Panel1.TabIndex = 0
        '
        'btnshow
        '
        Me.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnshow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnshow.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnshow.Image = Global.Smartinventory.My.Resources.Resources.Search1
        Me.btnshow.Location = New System.Drawing.Point(672, 5)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(94, 34)
        Me.btnshow.TabIndex = 3
        Me.btnshow.Text = "ສະແດງ"
        '
        'cbcustomer
        '
        Me.cbcustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbcustomer.DisplayMember = "Text"
        Me.cbcustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcustomer.FormattingEnabled = True
        Me.cbcustomer.ItemHeight = 29
        Me.cbcustomer.Location = New System.Drawing.Point(209, 4)
        Me.cbcustomer.Name = "cbcustomer"
        Me.cbcustomer.Size = New System.Drawing.Size(457, 35)
        Me.cbcustomer.TabIndex = 2
        '
        'rdspecific
        '
        Me.rdspecific.AutoSize = True
        Me.rdspecific.ForeColor = System.Drawing.Color.Blue
        Me.rdspecific.Location = New System.Drawing.Point(98, 9)
        Me.rdspecific.Name = "rdspecific"
        Me.rdspecific.Size = New System.Drawing.Size(105, 28)
        Me.rdspecific.TabIndex = 1
        Me.rdspecific.TabStop = True
        Me.rdspecific.Text = "ຕາມປະເພດ:"
        Me.rdspecific.UseVisualStyleBackColor = True
        '
        'rdall
        '
        Me.rdall.AutoSize = True
        Me.rdall.ForeColor = System.Drawing.Color.Blue
        Me.rdall.Location = New System.Drawing.Point(16, 9)
        Me.rdall.Name = "rdall"
        Me.rdall.Size = New System.Drawing.Size(76, 28)
        Me.rdall.TabIndex = 0
        Me.rdall.TabStop = True
        Me.rdall.Text = "ທັງໜົດ:"
        Me.rdall.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 53)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1002, 673)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmreportcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmreportcustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ລາຍງານລູກຄ້າ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdspecific As System.Windows.Forms.RadioButton
    Friend WithEvents rdall As System.Windows.Forms.RadioButton
    Friend WithEvents cbcustomer As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnshow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
