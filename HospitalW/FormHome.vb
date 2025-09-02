Imports HospitalW

Public Class FormHome
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnWard_Click(sender As Object, e As EventArgs) Handles btnWard.Click
        Dim formWard = New FormWard
        formWard.Show()
    End Sub
End Class
