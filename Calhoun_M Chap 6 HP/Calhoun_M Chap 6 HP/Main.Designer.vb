<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.totaltextbox = New System.Windows.Forms.TextBox()
        Me.taxtextbox = New System.Windows.Forms.TextBox()
        Me.subtotaltextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.calcbutton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.icapbutton = New System.Windows.Forms.RadioButton()
        Me.ilattebutton = New System.Windows.Forms.RadioButton()
        Me.lattebutton = New System.Windows.Forms.RadioButton()
        Me.expressbutton = New System.Windows.Forms.RadioButton()
        Me.capbutton = New System.Windows.Forms.RadioButton()
        Me.amounttextbox = New System.Windows.Forms.TextBox()
        Me.taxcheckbox = New System.Windows.Forms.CheckBox()
        Me.quantextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.totaltextbox)
        Me.GroupBox3.Controls.Add(Me.taxtextbox)
        Me.GroupBox3.Controls.Add(Me.subtotaltextbox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(127, 287)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 148)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'totaltextbox
        '
        Me.totaltextbox.Enabled = False
        Me.totaltextbox.Location = New System.Drawing.Point(179, 103)
        Me.totaltextbox.Name = "totaltextbox"
        Me.totaltextbox.Size = New System.Drawing.Size(100, 20)
        Me.totaltextbox.TabIndex = 8
        '
        'taxtextbox
        '
        Me.taxtextbox.Enabled = False
        Me.taxtextbox.Location = New System.Drawing.Point(179, 68)
        Me.taxtextbox.Name = "taxtextbox"
        Me.taxtextbox.Size = New System.Drawing.Size(100, 20)
        Me.taxtextbox.TabIndex = 9
        '
        'subtotaltextbox
        '
        Me.subtotaltextbox.Enabled = False
        Me.subtotaltextbox.Location = New System.Drawing.Point(179, 30)
        Me.subtotaltextbox.Name = "subtotaltextbox"
        Me.subtotaltextbox.Size = New System.Drawing.Size(100, 20)
        Me.subtotaltextbox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Due"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tax (If Takeout)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Subtotal"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NewToolStripMenuItem.Text = "New Order"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ReportToolStripMenuItem.Text = "Summary"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateSelectionToolStripMenuItem, Me.ClearItemToolStripMenuItem, Me.ToolStripSeparator1, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CalculateSelectionToolStripMenuItem
        '
        Me.CalculateSelectionToolStripMenuItem.Name = "CalculateSelectionToolStripMenuItem"
        Me.CalculateSelectionToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CalculateSelectionToolStripMenuItem.Text = "Calculate Selection"
        '
        'ClearItemToolStripMenuItem
        '
        Me.ClearItemToolStripMenuItem.Name = "ClearItemToolStripMenuItem"
        Me.ClearItemToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ClearItemToolStripMenuItem.Text = "Clear Item "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(650, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Amount"
        '
        'clearbutton
        '
        Me.clearbutton.Enabled = False
        Me.clearbutton.Location = New System.Drawing.Point(63, 165)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(147, 23)
        Me.clearbutton.TabIndex = 4
        Me.clearbutton.Text = "Clear For Next Item "
        Me.clearbutton.UseVisualStyleBackColor = True
        '
        'calcbutton
        '
        Me.calcbutton.Location = New System.Drawing.Point(63, 120)
        Me.calcbutton.Name = "calcbutton"
        Me.calcbutton.Size = New System.Drawing.Size(147, 23)
        Me.calcbutton.TabIndex = 3
        Me.calcbutton.Text = "Calculate Selection"
        Me.calcbutton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.amounttextbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.clearbutton)
        Me.GroupBox1.Controls.Add(Me.calcbutton)
        Me.GroupBox1.Controls.Add(Me.taxcheckbox)
        Me.GroupBox1.Controls.Add(Me.quantextbox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 246)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.icapbutton)
        Me.GroupBox2.Controls.Add(Me.ilattebutton)
        Me.GroupBox2.Controls.Add(Me.lattebutton)
        Me.GroupBox2.Controls.Add(Me.expressbutton)
        Me.GroupBox2.Controls.Add(Me.capbutton)
        Me.GroupBox2.Location = New System.Drawing.Point(324, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 156)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffe Selections"
        '
        'icapbutton
        '
        Me.icapbutton.AutoSize = True
        Me.icapbutton.Location = New System.Drawing.Point(35, 121)
        Me.icapbutton.Name = "icapbutton"
        Me.icapbutton.Size = New System.Drawing.Size(106, 17)
        Me.icapbutton.TabIndex = 4
        Me.icapbutton.TabStop = True
        Me.icapbutton.Text = "Iced Cappuccino"
        Me.icapbutton.UseVisualStyleBackColor = True
        '
        'ilattebutton
        '
        Me.ilattebutton.AutoSize = True
        Me.ilattebutton.Location = New System.Drawing.Point(35, 98)
        Me.ilattebutton.Name = "ilattebutton"
        Me.ilattebutton.Size = New System.Drawing.Size(73, 17)
        Me.ilattebutton.TabIndex = 3
        Me.ilattebutton.TabStop = True
        Me.ilattebutton.Text = "Iced Latte"
        Me.ilattebutton.UseVisualStyleBackColor = True
        '
        'lattebutton
        '
        Me.lattebutton.AutoSize = True
        Me.lattebutton.Location = New System.Drawing.Point(35, 75)
        Me.lattebutton.Name = "lattebutton"
        Me.lattebutton.Size = New System.Drawing.Size(49, 17)
        Me.lattebutton.TabIndex = 2
        Me.lattebutton.TabStop = True
        Me.lattebutton.Text = "Latte"
        Me.lattebutton.UseVisualStyleBackColor = True
        '
        'expressbutton
        '
        Me.expressbutton.AutoSize = True
        Me.expressbutton.Location = New System.Drawing.Point(35, 52)
        Me.expressbutton.Name = "expressbutton"
        Me.expressbutton.Size = New System.Drawing.Size(68, 17)
        Me.expressbutton.TabIndex = 1
        Me.expressbutton.TabStop = True
        Me.expressbutton.Text = "Espresso"
        Me.expressbutton.UseVisualStyleBackColor = True
        '
        'capbutton
        '
        Me.capbutton.AutoSize = True
        Me.capbutton.Location = New System.Drawing.Point(35, 29)
        Me.capbutton.Name = "capbutton"
        Me.capbutton.Size = New System.Drawing.Size(82, 17)
        Me.capbutton.TabIndex = 0
        Me.capbutton.TabStop = True
        Me.capbutton.Text = "Cappuccino"
        Me.capbutton.UseVisualStyleBackColor = True
        '
        'amounttextbox
        '
        Me.amounttextbox.Enabled = False
        Me.amounttextbox.Location = New System.Drawing.Point(136, 213)
        Me.amounttextbox.Name = "amounttextbox"
        Me.amounttextbox.Size = New System.Drawing.Size(100, 20)
        Me.amounttextbox.TabIndex = 6
        '
        'taxcheckbox
        '
        Me.taxcheckbox.AutoSize = True
        Me.taxcheckbox.Location = New System.Drawing.Point(63, 84)
        Me.taxcheckbox.Name = "taxcheckbox"
        Me.taxcheckbox.Size = New System.Drawing.Size(72, 17)
        Me.taxcheckbox.TabIndex = 2
        Me.taxcheckbox.Text = "Takeout?"
        Me.taxcheckbox.UseVisualStyleBackColor = True
        '
        'quantextbox
        '
        Me.quantextbox.Location = New System.Drawing.Point(110, 58)
        Me.quantextbox.Name = "quantextbox"
        Me.quantextbox.Size = New System.Drawing.Size(100, 20)
        Me.quantextbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quanity"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 449)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents totaltextbox As System.Windows.Forms.TextBox
    Friend WithEvents taxtextbox As System.Windows.Forms.TextBox
    Friend WithEvents subtotaltextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clearbutton As System.Windows.Forms.Button
    Friend WithEvents calcbutton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents icapbutton As System.Windows.Forms.RadioButton
    Friend WithEvents ilattebutton As System.Windows.Forms.RadioButton
    Friend WithEvents lattebutton As System.Windows.Forms.RadioButton
    Friend WithEvents expressbutton As System.Windows.Forms.RadioButton
    Friend WithEvents capbutton As System.Windows.Forms.RadioButton
    Friend WithEvents amounttextbox As System.Windows.Forms.TextBox
    Friend WithEvents taxcheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents quantextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog

End Class
