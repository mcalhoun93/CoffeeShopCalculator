<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoffeeOrderCalculator
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.icapbutton = New System.Windows.Forms.RadioButton()
        Me.ilattebutton = New System.Windows.Forms.RadioButton()
        Me.lattebutton = New System.Windows.Forms.RadioButton()
        Me.expressbutton = New System.Windows.Forms.RadioButton()
        Me.capbutton = New System.Windows.Forms.RadioButton()
        Me.amounttextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.calcbutton = New System.Windows.Forms.Button()
        Me.taxcheckbox = New System.Windows.Forms.CheckBox()
        Me.quantextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.totaltextbox = New System.Windows.Forms.TextBox()
        Me.taxtextbox = New System.Windows.Forms.TextBox()
        Me.subtotaltextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.newbutton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 223)
        Me.GroupBox1.TabIndex = 0
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
        Me.GroupBox2.Location = New System.Drawing.Point(286, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 152)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffe Selections"
        '
        'icapbutton
        '
        Me.icapbutton.AutoSize = True
        Me.icapbutton.Location = New System.Drawing.Point(28, 122)
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
        Me.ilattebutton.Location = New System.Drawing.Point(28, 96)
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
        Me.lattebutton.Location = New System.Drawing.Point(28, 73)
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
        Me.expressbutton.Location = New System.Drawing.Point(28, 50)
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
        Me.capbutton.Location = New System.Drawing.Point(28, 27)
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
        Me.amounttextbox.Location = New System.Drawing.Point(83, 175)
        Me.amounttextbox.Name = "amounttextbox"
        Me.amounttextbox.Size = New System.Drawing.Size(100, 20)
        Me.amounttextbox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Amount"
        '
        'clearbutton
        '
        Me.clearbutton.Enabled = False
        Me.clearbutton.Location = New System.Drawing.Point(10, 127)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(147, 23)
        Me.clearbutton.TabIndex = 4
        Me.clearbutton.Text = "Clear For Next Item "
        Me.clearbutton.UseVisualStyleBackColor = True
        '
        'calcbutton
        '
        Me.calcbutton.Location = New System.Drawing.Point(10, 82)
        Me.calcbutton.Name = "calcbutton"
        Me.calcbutton.Size = New System.Drawing.Size(147, 23)
        Me.calcbutton.TabIndex = 3
        Me.calcbutton.Text = "Calculate Selection"
        Me.calcbutton.UseVisualStyleBackColor = True
        '
        'taxcheckbox
        '
        Me.taxcheckbox.AutoSize = True
        Me.taxcheckbox.Location = New System.Drawing.Point(10, 46)
        Me.taxcheckbox.Name = "taxcheckbox"
        Me.taxcheckbox.Size = New System.Drawing.Size(72, 17)
        Me.taxcheckbox.TabIndex = 2
        Me.taxcheckbox.Text = "Takeout?"
        Me.taxcheckbox.UseVisualStyleBackColor = True
        '
        'quantextbox
        '
        Me.quantextbox.Location = New System.Drawing.Point(57, 20)
        Me.quantextbox.Name = "quantextbox"
        Me.quantextbox.Size = New System.Drawing.Size(100, 20)
        Me.quantextbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quanity"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.totaltextbox)
        Me.GroupBox3.Controls.Add(Me.taxtextbox)
        Me.GroupBox3.Controls.Add(Me.subtotaltextbox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(509, 132)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'totaltextbox
        '
        Me.totaltextbox.Enabled = False
        Me.totaltextbox.Location = New System.Drawing.Point(142, 93)
        Me.totaltextbox.Name = "totaltextbox"
        Me.totaltextbox.Size = New System.Drawing.Size(100, 20)
        Me.totaltextbox.TabIndex = 8
        '
        'taxtextbox
        '
        Me.taxtextbox.Enabled = False
        Me.taxtextbox.Location = New System.Drawing.Point(142, 62)
        Me.taxtextbox.Name = "taxtextbox"
        Me.taxtextbox.Size = New System.Drawing.Size(100, 20)
        Me.taxtextbox.TabIndex = 9
        '
        'subtotaltextbox
        '
        Me.subtotaltextbox.Enabled = False
        Me.subtotaltextbox.Location = New System.Drawing.Point(142, 27)
        Me.subtotaltextbox.Name = "subtotaltextbox"
        Me.subtotaltextbox.Size = New System.Drawing.Size(100, 20)
        Me.subtotaltextbox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Due"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tax (If Takeout)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Subtotal"
        '
        'newbutton
        '
        Me.newbutton.Enabled = False
        Me.newbutton.Location = New System.Drawing.Point(259, 384)
        Me.newbutton.Name = "newbutton"
        Me.newbutton.Size = New System.Drawing.Size(83, 23)
        Me.newbutton.TabIndex = 8
        Me.newbutton.Text = "New Order"
        Me.newbutton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(348, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Summary"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(443, 384)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 419)
        Me.Controls.Add(Me.newbutton)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Reading and Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents icapbutton As System.Windows.Forms.RadioButton
    Friend WithEvents ilattebutton As System.Windows.Forms.RadioButton
    Friend WithEvents lattebutton As System.Windows.Forms.RadioButton
    Friend WithEvents expressbutton As System.Windows.Forms.RadioButton
    Friend WithEvents capbutton As System.Windows.Forms.RadioButton
    Friend WithEvents amounttextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clearbutton As System.Windows.Forms.Button
    Friend WithEvents calcbutton As System.Windows.Forms.Button
    Friend WithEvents taxcheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents quantextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents totaltextbox As System.Windows.Forms.TextBox
    Friend WithEvents taxtextbox As System.Windows.Forms.TextBox
    Friend WithEvents subtotaltextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents newbutton As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
