Public Class Form1
    Private Function FV(pv As Single, i As Single, n As Integer) As Double

        FV = pv * (1 + i / 100) ^ n

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim FutureVal As Single
        Dim PresentVal As Single
        Dim interest As Single
        Dim period As Integer
        PresentVal = TextBox1.Text
        interest = TextBox2.Text
        period = TextBox3.Text
        FutureVal = FV(PresentVal, interest, period)
        TextBox4.Text = Format(FutureVal, "$#,##0.00")
    End Sub
End Class
