Public Class CloudlogSettingsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.CloudlogURL = TextBox1.Text
        My.Settings.CloudlogAPIKey = TextBox2.Text
        Me.Close()
    End Sub

    Private Function ValidateSettings() As Boolean
        ToolStripStatusLabel1.Text = String.Empty
        Try
            Dim url = New Uri(TextBox1.Text)
            If Not url.Scheme.ToUpper.StartsWith("HTTP") Then
                Throw New UriFormatException("Need 'https://' or 'http://'")
            End If
            My.Settings.CloudlogURL = url.ToString()
        Catch ex As UriFormatException
            ToolStripStatusLabel1.Text = ex.Message
            Return False
        End Try
        Return True
    End Function

    Private Sub CloudlogSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.CloudlogURL
        TextBox2.Text = My.Settings.CloudlogAPIKey
        StatusStrip1.Text = String.Empty
        Button1.Enabled = ValidateSettings()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button1.Enabled = ValidateSettings()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Button1.Enabled = ValidateSettings()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
