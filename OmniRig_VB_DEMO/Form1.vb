Public Class Form1
    'OmniRig events WithEvents
    Dim WithEvents OmniRigEngine As OmniRig.OmniRigX
    Dim Rig As OmniRig.RigX
    Dim OurRigNo As Integer

    'How to: Make Thread-Safe Calls To Windows Forms Controls
    'https://msdn.microsoft.com/ja-jp/library/a1hetckb(v=vs.110).aspx
    'http://www.atmarkit.co.jp/ait/articles/0506/17/news111.html

    'Thread-Safe Calls To Windows Forms Controls
    Delegate Sub ShowRigStatusDelegate()
    Delegate Sub ShowRigParamsDelegate()

    ' Constants for enum RigParamX
    Const PM_UNKNOWN = &H1
    Const PM_FREQ = &H2
    Const PM_FREQA = &H4
    Const PM_FREQB = &H8
    Const PM_PITCH = &H10
    Const PM_RITOFFSET = &H20
    Const PM_RIT0 = &H40
    Const PM_VFOAA = &H80
    Const PM_VFOAB = &H100
    Const PM_VFOBA = &H200
    Const PM_VFOBB = &H400
    Const PM_VFOA = &H800
    Const PM_VFOB = &H1000
    Const PM_VFOEQUAL = &H2000
    Const PM_VFOSWAP = &H4000
    Const PM_SPLITON = &H8000
    Const PM_SPLITOFF = &H10000
    Const PM_RITON = &H20000
    Const PM_RITOFF = &H40000
    Const PM_XITON = &H80000
    Const PM_XITOFF = &H100000
    Const PM_RX = &H200000
    Const PM_TX = &H400000
    Const PM_CW_U = &H800000
    Const PM_CW_L = &H1000000
    Const PM_SSB_U = &H2000000
    Const PM_SSB_L = &H4000000
    Const PM_DIG_U = &H8000000
    Const PM_DIG_L = &H10000000
    Const PM_AM = &H20000000
    Const PM_FM = &H40000000

    ' Constants for enum RigStatusX
    Const ST_NOTCONFIGURED = &H0
    Const ST_DISABLED = &H1
    Const ST_PORTBUSY = &H2
    Const ST_NOTRESPONDING = &H3
    Const ST_ONLINE = &H4

    'Form LOAD events
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set Status Bar Information
        ToolStripStatusLabel1.Text = "Cloudlog Not Connected"

        'ComboBox MODE SETING　
        ComboBox1.Items.Add("CW_U")
        ComboBox1.Items.Add("CW_L")
        ComboBox1.Items.Add("SSB_U")
        ComboBox1.Items.Add("SSB_L")
        ComboBox1.Items.Add("DIG_U")
        ComboBox1.Items.Add("DIG_L")
        ComboBox1.Items.Add("AM")
        ComboBox1.Items.Add("FM")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Text = ComboBox1.GetItemText(ComboBox1.Items(0))
        RadioButton1.Checked = True
        NumericUpDown1.ThousandsSeparator = True
        StartOmniRig()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs)
        StopOmniRig()
    End Sub

    'Thread-Safe Calls To Windows Forms Controls
    'OmniRig StatusChange events
    Private Sub OmniRigEngine_StatusChange(ByVal RigNumber As Long) Handles OmniRigEngine.StatusChange
        If RigNumber = OurRigNo Then Invoke(New ShowRigStatusDelegate(AddressOf ShowRigStatus))
    End Sub

    'Thread-Safe Calls To Windows Forms Controls
    'OmniRig ParamsChange events
    Private Sub OmniRigEngine_ParamsChange(ByVal RigNumber As Long, ByVal Params As Long) Handles OmniRigEngine.ParamsChange
        If RigNumber = OurRigNo Then Invoke(New ShowRigParamsDelegate(AddressOf ShowRigParams))

    End Sub

    'Thread-Safe Calls To Windows Forms Controls
    Private Sub ShowRigStatus()
        If Rig Is Nothing Then Exit Sub
        Label8.Text = Rig.StatusStr
    End Sub

    'Thread-Safe Calls To Windows Forms Controls
    Private Sub ShowRigParams()
        If Rig Is Nothing Then Exit Sub
        Label3.Text = Rig.GetRxFrequency
        Label4.Text = Rig.GetTxFrequency
        NumericUpDown1.Value = Rig.Freq
        Select Case Rig.Mode
            Case PM_CW_L
                ComboBox1.Text = ComboBox1.GetItemText(ComboBox1.Items(1))
                Label6.Text = "CW"
            Case PM_CW_U
                ComboBox1.Text = ComboBox1.GetItemText(ComboBox1.Items(0))
                Label6.Text = "CW"
            Case PM_SSB_L
                ComboBox1.Text = ComboBox1.GetItemText(ComboBox1.Items(3))
                Label6.Text = "LSB"
            Case PM_SSB_U
                ComboBox1.Text = ComboBox1.GetItemText(ComboBox1.Items(2))
                Label6.Text = "USB"
            Case Else
                Label6.Text = "Other"
        End Select
    End Sub

    'Procedures
    Private Sub StartOmniRig()
        ' On Error GoTo Error1
        If Not OmniRigEngine Is Nothing Then Exit Sub
        OmniRigEngine = CreateObject("OmniRig.OmniRigX")
        ' we want OmniRig interface V.1.1 to 1.99
        ' as V2.0 will likely be incompatible  with 1.x
        If OmniRigEngine.InterfaceVersion < &H101 Then GoTo Error1
        If OmniRigEngine.InterfaceVersion > &H299 Then GoTo Error1
        SelectRig(1)
        Exit Sub
Error1:
        ' report problems
        OmniRigEngine = Nothing
        MsgBox("OmniRig Is Not installed Or has a wrong version number")

    End Sub

    Private Sub StopOmniRig()
        Rig = Nothing
        OmniRigEngine = Nothing
    End Sub

    Private Sub SelectRig(NewRigNo As Integer)
        If OmniRigEngine Is Nothing Then Exit Sub
        OurRigNo = NewRigNo
        Select Case NewRigNo
            Case 1
                Rig = OmniRigEngine.Rig1
            Case 2
                Rig = OmniRigEngine.Rig2
        End Select
        ShowRigStatus()
        ShowRigParams()
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        SelectRig(1)
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        SelectRig(2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim freq As Integer
        freq = Int(NumericUpDown1.Value / 1000) * 1000
        Rig.SetSimplexMode(freq)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If OmniRigEngine Is Nothing Then Exit Sub
        Select Case ComboBox1.SelectedItem
            Case "CW_L"
                Rig.Mode = OmniRig.RigParamX.PM_CW_L
            Case "CW_U"
                Rig.Mode = OmniRig.RigParamX.PM_CW_U
            Case "SSB_L"
                Rig.Mode = OmniRig.RigParamX.PM_SSB_L
            Case "SSB_U"
                Rig.Mode = OmniRig.RigParamX.PM_SSB_U
            Case "DIG_L"
                Rig.Mode = OmniRig.RigParamX.PM_DIG_L
            Case "DIG_U"
                Rig.Mode = OmniRig.RigParamX.PM_DIG_U
            Case "AM"
                Rig.Mode = OmniRig.RigParamX.PM_AM
            Case "FM"
                Rig.Mode = OmniRig.RigParamX.PM_FM
        End Select
    End Sub

    Private Sub OmnirigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OmnirigToolStripMenuItem.Click
        If OmniRigEngine Is Nothing Then Exit Sub
        OmniRigEngine.DialogVisible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CloudlogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloudlogToolStripMenuItem.Click
        CloudlogSettingsForm.Show()
    End Sub
End Class
