Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim strName As String = txtName.Text
        Dim strState As String = txtState.Text
        Dim strOutput As String = " Hello " + strName + " cantik " + " from " + strState

        lblOutput.Text = strOutput

    End Sub

    Private Sub txtState_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtState.MaskInputRejected

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
