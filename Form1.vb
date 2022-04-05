Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intBall, n As Integer
        Dim rand1 As New System.Random
        lblBalls.text = ""
        For n = 0 To 5
            intBall = rand1.Next(49) + 1
            lblBalls.text = lblBalls.text & " " & intBall
        Next n
    End Sub
End Class
