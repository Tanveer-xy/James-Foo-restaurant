Public Class Form1
    Dim user As String = "FooABC"
    Dim pass As Integer = 123
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim password As Integer = Convert.ToInt32(TextBox2.Text)
            Dim username As String = TextBox1.Text
            If user = username And pass = password Then
                MessageBox.Show(" Successfully login ")
                Dim obj = New Form2()
                obj.welcom = user
                obj.Show()
                Me.Hide()
            Else
                MessageBox.Show("  username or password incorrect  ")
            End If
        Catch ex As Exception
            MessageBox.Show(" Error During inputs please insert the inputs according to the textboxs ")

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("THANK you for using our Service !")
        Application.Exit()

    End Sub
End Class
