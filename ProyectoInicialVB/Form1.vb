Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalculo.Click
        Dim num1, num2, num3 As Integer
        Dim promedio As Double

        num1 = PrimerValortxt.Text
        num2 = SegundoValortxt.Text
        num3 = TercerValortxt.Text

        promedio = (num1 + num2 + num3) / 3
        Promediotxt.Text = promedio

    End Sub

    Private Sub Borrarbtn_Click(sender As Object, e As EventArgs) Handles Borrarbtn.Click
        PrimerValortxt.Clear()
        SegundoValortxt.Clear()
        TercerValortxt.Clear()
        Promediotxt.Clear()
    End Sub

    Private Sub Salirbtn_Click(sender As Object, e As EventArgs) Handles Salirbtn.Click
        Environment.Exit(0)
    End Sub
End Class
