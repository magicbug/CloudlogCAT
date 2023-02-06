Public Class CloudlogSettingsForm
    Dim targets As ArrayList
    Private Sub SaveBut_Click(sender As Object, e As EventArgs) Handles SaveBut.Click
        Dim target As CloudlogTarget
        target = getValues() ' Get the target to be added


        ' Basic sanity check, an empty name will result in empty but existing list entries 
        If String.Equals(target.name, "") Or String.Equals(target.url, "") Then
            MsgBox("Neither Name nor URL May be Empty!")
            Return
        End If

        ' it is possible to click select without selecting anything in the list
        ' Just add a new entry i
        If TargetList.SelectedIndex = -1 Then
            targets.Add(getValues) ' add new
        Else
            targets(TargetList.SelectedIndex) = getValues() ' Override
        End If

        ' Store the list as a string 
        My.Settings.MultiCloudlog = CloudlogTarget.toSettingsString(targets)
        My.Settings.Save()
        ' update gui
        populateList()
    End Sub

    Private Sub CloudlogSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get current settings and override the local object
        targets = CloudlogTarget.fromSettingsString(My.Settings.MultiCloudlog)
        ' Update the gui
        populateList()
        ' Select the first entry and populate the values into the textboxes
        TargetList.SetSelected(0, True)
        populateValues(0)

    End Sub

    Private Sub TargetList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TargetList.SelectedIndexChanged
        ' Ignore the un-select event
        If TargetList.SelectedIndex >= 0 Then
            ' update gui
            populateValues(TargetList.SelectedIndex)
        End If
    End Sub
    Private Sub populateList()
        Dim selected As Integer

        ' We will clear the list, so stroe the currently selected item
        selected = TargetList.SelectedIndex
        ' clear list and populate the values
        TargetList.Items.Clear()
        For Each target As CloudlogTarget In targets
            TargetList.Items.Add(target.name)
        Next

        ' reselect the item, if neccesary
        If 0 <= selected And selected < targets.Count Then
            TargetList.SetSelected(selected, True)
            populateValues(selected)
        End If

    End Sub

    ' Puts the values from the list into the textboxes
    Private Sub populateValues(ByVal index As Integer)
        Dim target As CloudlogTarget
        target = targets(index)

        NameBox.Text = target.name
        radioNameBox.Text = target.radioName
        URLBox.Text = target.url
        KeyBox.Text = target.key
        ActiveBox.Checked = target.active

    End Sub

    Private Function getValues() As CloudlogTarget
        Dim target As New CloudlogTarget()
        ' Create a new target object, remove trailling and leading spaces
        target.name = NameBox.Text.Trim()
        target.radioName = radioNameBox.Text.Trim()
        target.url = URLBox.Text.Trim()
        ' the url may not end with a /
        While target.url.EndsWith("/")
            target.url = target.url.Substring(0, target.url.Length - 1)
        End While
        target.key = KeyBox.Text.Trim()
        target.active = ActiveBox.Checked
        Return target
    End Function

    Private Sub AddBut_Click(sender As Object, e As EventArgs) Handles AddBut.Click
        Dim target As New CloudlogTarget()
        ' Create a new basic Target, the name is increased to the count number
        target.name = target.name & " " & (targets.Count + 1)
        targets.Add(target)
        ' put it in the list
        populateList()
        ' this new entry is neither selected nor saved, this is on purpose. The use needs to make changes to make saving worth it
    End Sub

    Private Sub SubBut_Click(sender As Object, e As EventArgs) Handles SubBut.Click
        Dim index As Integer
        index = TargetList.SelectedIndex
        ' Check weather anything is selected, and do not delete the last entry
        If index > -1 And targets.Count > 1 Then
            ' flush gui
            NameBox.Text = ""
            radioNameBox.Text = ""
            URLBox.Text = ""
            KeyBox.Text = ""
            ActiveBox.Checked = False
            ' remove and update gui
            targets.RemoveAt(index)
            populateList()
            ' save 
            My.Settings.MultiCloudlog = CloudlogTarget.toSettingsString(targets)
            My.Settings.Save()
        End If
    End Sub
End Class