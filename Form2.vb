Public Class Form2
    Public welcom As String '' variable for username
    Dim price As Integer '' varibel for price
    Dim menu As String '' vairbale for the selection of the menu 
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = welcom '' asging the user name 
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            '' if else statement to choose the menu and asign the price to the vairble as well menu 
            If RadioButton1.Checked Then
                price = 35                     '' asinging price and menu 
                menu = " chicken burger "
            ElseIf RadioButton2.Checked Then
                price = 25
                menu = " GRILLED SALMON "  '' asinging price and menu 

            ElseIf RadioButton3.Checked Then
                price = 20
                menu = " KOREAN SPICY WINGS "  '' asinging price and menu 

            ElseIf RadioButton4.Checked Then
                price = 15
                menu = " SALAD " '' asinging price and menu 

            ElseIf RadioButton5.Checked Then
                price = 9
                menu = " ICE LEMON TEA " '' asinging price and menu 

            End If
            Dim quantity As Integer = Convert.ToInt32(TextBox1.Text)
            Dim delivery As Integer
            If ComboBox1.SelectedIndex = 0 Then   '' combobox  delivery mod selection
                delivery = 0
            ElseIf ComboBox1.SelectedIndex = 1 Then   '' combobox  delivery mod selection
                delivery = 20
            End If
            Dim total As Integer = price * quantity '' total 
            Dim Gtotal As Integer = delivery + total '' gradan total 
            TextBox3.Text = "Your Total Price is :" + Gtotal.ToString(".00") '' writing into the textboxs
            TextBox2.Text = "You have Selected " + quantity.ToString() + " set of " + menu
        Catch ex As Exception
            MessageBox.Show(" Error please try again  ")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(" Thank you for ordering with Jame foo ! ")
        Application.Exit()

    End Sub
End Class