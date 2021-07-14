Imports GameJoltAPI

Public Class StartupForm
    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim page As String = Trophy.Fetch(gameID_txtBox.Text, privAPIKey_txtBox.Text, userName_txtBox.Text, userToken_txtBox.Text)
        WebBrowser1.DocumentText = page
    End Sub
End Class
