Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (My.Settings.TransverterEnabled = True) Then
            CheckBoxTransverterOffsetEnable.Checked = True
        End If

        TransverterOffsetFreq.Text = My.Settings.TransverterFreq
        TransverterOffsetType.Text = My.Settings.TransverterOffsetType
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.TransverterEnabled = CheckBoxTransverterOffsetEnable.CheckState
        My.Settings.TransverterFreq = TransverterOffsetFreq.Text
        My.Settings.TransverterOffsetType = TransverterOffsetType.Text

        If (My.Settings.TransverterEnabled = True) Then
            Form1.TransverterOffsetToolStripMenuItem.Checked = True
        Else
            Form1.TransverterOffsetToolStripMenuItem.Checked = False
        End If

        Me.Close()

    End Sub
End Class