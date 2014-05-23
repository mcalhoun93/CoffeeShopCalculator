Public Class SummaryForm

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        totsaltxtbox.Text = Main.grandtotaldecimal.ToString("C")
        avgsaltxtbox.Text = Main.averagedecimal.ToString("C")
        totcusttxtbox.Text = Main.customercountinteger.ToString("N")
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Me.Close()
    End Sub
End Class