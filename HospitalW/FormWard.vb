Public Class FormWard
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim formAppointments = New FormAppointments
        formAppointments.Show()
        Me.Hide()
    End Sub

    Private Sub FormWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class