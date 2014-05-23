<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.closebutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totsaltxtbox = New System.Windows.Forms.TextBox()
        Me.avgsaltxtbox = New System.Windows.Forms.TextBox()
        Me.totcusttxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'closebutton
        '
        Me.closebutton.Location = New System.Drawing.Point(150, 270)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(75, 23)
        Me.closebutton.TabIndex = 0
        Me.closebutton.Text = "Close"
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Sales: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Average Sales: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Number of Customers"
        '
        'totsaltxtbox
        '
        Me.totsaltxtbox.Location = New System.Drawing.Point(183, 112)
        Me.totsaltxtbox.Name = "totsaltxtbox"
        Me.totsaltxtbox.Size = New System.Drawing.Size(152, 20)
        Me.totsaltxtbox.TabIndex = 4
        '
        'avgsaltxtbox
        '
        Me.avgsaltxtbox.Location = New System.Drawing.Point(183, 159)
        Me.avgsaltxtbox.Name = "avgsaltxtbox"
        Me.avgsaltxtbox.Size = New System.Drawing.Size(152, 20)
        Me.avgsaltxtbox.TabIndex = 5
        '
        'totcusttxtbox
        '
        Me.totcusttxtbox.Location = New System.Drawing.Point(183, 213)
        Me.totcusttxtbox.Name = "totcusttxtbox"
        Me.totcusttxtbox.Size = New System.Drawing.Size(152, 20)
        Me.totcusttxtbox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(391, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "R 'n R for Reading and Refreshment"
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 372)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.totcusttxtbox)
        Me.Controls.Add(Me.avgsaltxtbox)
        Me.Controls.Add(Me.totsaltxtbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closebutton)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closebutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totsaltxtbox As System.Windows.Forms.TextBox
    Friend WithEvents avgsaltxtbox As System.Windows.Forms.TextBox
    Friend WithEvents totcusttxtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
