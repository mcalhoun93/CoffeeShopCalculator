Public Class Main
    Const taxratedecimal As Decimal = 0.8D
    Const capprice As Decimal = 2D
    Const expressprice As Decimal = 2.25D
    Const latteprice As Decimal = 1.75D
    Const icedprice As Decimal = 2.5D
    Private subtotaldecimal, totaldecimal As Decimal
    Friend customercountinteger As Integer
    Friend grandtotaldecimal, averagedecimal As Decimal

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub calcbutton_Click(sender As Object, e As EventArgs) Handles calcbutton.Click, CalculateSelectionToolStripMenuItem.Click

        Dim pricedecimal, taxdecimal, itemdecimal As Decimal
        Dim quanityinteger As Integer

        If capbutton.Checked Then
            pricedecimal = capprice
        ElseIf expressbutton.Checked Then
            pricedecimal = expressprice
        ElseIf lattebutton.Checked Then
            pricedecimal = latteprice
        ElseIf icapbutton.Checked Or ilattebutton.Checked Then
            pricedecimal = icedprice
        End If

        Try
            quanityinteger = Integer.Parse(quantextbox.Text)
            itemdecimal = pricedecimal * quanityinteger
            subtotaldecimal += itemdecimal
            If taxcheckbox.Checked Then
                taxdecimal = subtotaldecimal * taxratedecimal
            Else
                taxdecimal = 0
            End If
            totaldecimal = subtotaldecimal + taxdecimal

            amounttextbox.Text = itemdecimal.ToString("C")
            subtotaltextbox.Text = subtotaldecimal.ToString("C")
            taxtextbox.Text = taxdecimal.ToString("C")
            totaltextbox.Text = totaldecimal.ToString("C")

            taxcheckbox.Enabled = False
            clearbutton.Enabled = True

        Catch ex As FormatException
            MessageBox.Show("quanity must be numeric", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            With quantextbox
                .Focus()
                .SelectAll()
            End With

        End Try

    End Sub

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click, ClearItemToolStripMenuItem.Click
        capbutton.Checked = True
        amounttextbox.Clear()
        With quantextbox
            .Clear()
            .Focus()

        End With

    End Sub

    Private Sub newbutton_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim returnresult As DialogResult
        Dim messagestring As String

        messagestring = "clear the current oreder?"
        returnresult = MessageBox.Show(messagestring, "clear order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If returnresult = DialogResult.Yes Then
            clearbutton_Click(sender, e)
            subtotaltextbox.Clear()
            taxtextbox.Clear()
            totaltextbox.Clear()

            If subtotaldecimal <> 0 Then
                grandtotaldecimal += totaldecimal
                customercountinteger += 1
                subtotaldecimal = 0
                totaldecimal = 0
                averagedecimal = grandtotaldecimal / customercountinteger
            End If
            With taxcheckbox
                .Enabled = True
                .Checked = False
            End With
            clearbutton.Enabled = False

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim messagestring As String
        messagestring = "No Sales Data Present"
        If totaldecimal <> 0 Then
            newbutton_Click(sender, e)
        End If

        If grandtotaldecimal > 0 Then
            SummaryForm.Show()
        Else
            MessageBox.Show(messagestring, "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CalculateSelectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculateSelectionToolStripMenuItem.Click

    End Sub

    Private Function FindTax(itemdecimal As Decimal) As Decimal

        FindTax = subtotaldecimal * taxratedecimal

    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub ClearItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearItemToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox1.Show()

       
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .Font = subtotaltextbox.Font
            .ShowDialog()
            subtotaltextbox.Font = .Font
            taxtextbox.Font = .Font
            totaltextbox.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = subtotaltextbox.ForeColor
            .ShowDialog()
            subtotaltextbox.ForeColor = .Color
            taxtextbox.ForeColor = .Color
            totaltextbox.ForeColor = .Color
        End With
    End Sub
End Class
