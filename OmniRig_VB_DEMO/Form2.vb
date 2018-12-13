Public Class CloudlogSettingsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.CloudlogURL = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub CloudlogSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.CloudlogURL
    End Sub
End Class