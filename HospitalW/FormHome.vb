Imports HospitalW

Public Class FormHome
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnWard_Click(sender As Object, e As EventArgs) Handles btnWard.Click
        Dim formWard = New FormWard
        formWard.Show()
    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        Dim formPatient = New FormPatient
        formPatient.Show()
    End Sub

    Private Sub btnTreatment_Click(sender As Object, e As EventArgs) Handles btnTreatment.Click
        Dim formTreatment = New FormTreatment
        formTreatment.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim formPayment = New FormPayment
        formPayment.Show()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim formStaff = New FormStaff
        formStaff.Show()
    End Sub

    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        Dim formShifting = New FormShifting
        formShifting.Show()
    End Sub

    Private Sub btnMedecine_Click(sender As Object, e As EventArgs) Handles btnMedecine.Click
        Dim formMedecine = New FormMedecine
        formMedecine.Show()
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        Dim formItem = New FormItem
        formItem.Show()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        Dim formProduct = New FormProduct
        formProduct.Show()
    End Sub

    Private Sub btnSuplier_Click(sender As Object, e As EventArgs) Handles btnSuplier.Click
        Dim formSupplier = New FormSupplier
        formSupplier.Show()
    End Sub
End Class
