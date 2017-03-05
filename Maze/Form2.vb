Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Form1.Panel1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Function ColorDialog() As Windows.Forms.DialogResult
        Throw New NotImplementedException
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If (ColorDialog2.ShowDialog = Windows.Forms.DialogResult.OK) Then

        End If
    End Sub
End Class