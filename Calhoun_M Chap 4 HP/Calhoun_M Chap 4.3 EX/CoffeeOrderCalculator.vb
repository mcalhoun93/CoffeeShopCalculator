Public Class CoffeeOrderCalculator
    Const taxratedecimal As Decimal = 0.8D
    Const capprice As Decimal = 2D
    Const expressprice As Decimal = 2.25D
    Const latteprice As Decimal = 1.75D
    Const icedprice As Decimal = 2.5D
    Private subtotaldecimal, totaldecimal, grandtotaldecimal As Decimal
    Private customercountinteger As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub calcbutton_Click(sender As Object, e As EventArgs) Handles calcbutton.Click

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
            newbutton.Enabled = True

        Catch ex As FormatException
            MessageBox.Show("quanity must be numeric", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            With quantextbox
                .Focus()
                .SelectAll()
            End With

        End Try

    End Sub

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        capbutton.Checked = True
        amounttextbox.Clear()
        With quantextbox
            .Clear()
            .Focus()

        End With

    End Sub

    Private Sub newbutton_Click(sender As Object, e As EventArgs) Handles newbutton.Click
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
            End If
            With taxcheckbox
                .Enabled = True
                .Checked = False
            End With
            clearbutton.Enabled = False
            newbutton.Enabled = False

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim averagedecimal As String
        Dim messagestring As String

        If totaldecimal <> 0 Then
            newbutton_Click(sender, e)
        End If
        If customercountinteger > 0 Then
            averagedecimal = grandtotaldecimal / customercountinteger

            messagestring = "number of orders: " & customercountinteger.ToString() _
            & Environment.NewLine & Environment.NewLine _
            & "total sales: " & grandtotaldecimal.ToString("C") _
            & Environment.NewLine & Environment.NewLine _
            & "average sale: " & averagedecimal.ToString("C")

            MessageBox.Show(messagestring, "coffee sales summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub
End Class
