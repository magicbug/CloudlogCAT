<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloudlogSettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.URLBox = New System.Windows.Forms.TextBox()
        Me.SaveBut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KeyBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.radioNameBox = New System.Windows.Forms.TextBox()
        Me.TargetList = New System.Windows.Forms.ListBox()
        Me.ActiveBox = New System.Windows.Forms.CheckBox()
        Me.AddBut = New System.Windows.Forms.Button()
        Me.SubBut = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cloudlog Website Address"
        '
        'URLBox
        '
        Me.URLBox.Location = New System.Drawing.Point(277, 62)
        Me.URLBox.Name = "URLBox"
        Me.URLBox.Size = New System.Drawing.Size(206, 20)
        Me.URLBox.TabIndex = 6
        '
        'SaveBut
        '
        Me.SaveBut.Location = New System.Drawing.Point(379, 112)
        Me.SaveBut.Name = "SaveBut"
        Me.SaveBut.Size = New System.Drawing.Size(104, 23)
        Me.SaveBut.TabIndex = 9
        Me.SaveBut.Text = "Save"
        Me.SaveBut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cloudlog API Key"
        '
        'KeyBox
        '
        Me.KeyBox.Location = New System.Drawing.Point(277, 87)
        Me.KeyBox.Name = "KeyBox"
        Me.KeyBox.Size = New System.Drawing.Size(206, 20)
        Me.KeyBox.TabIndex = 7
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(277, 12)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(206, 20)
        Me.NameBox.TabIndex = 4
        '
        'radioNameBox
        '
        Me.radioNameBox.Location = New System.Drawing.Point(277, 37)
        Me.radioNameBox.Name = "radioNameBox"
        Me.radioNameBox.Size = New System.Drawing.Size(206, 20)
        Me.radioNameBox.TabIndex = 5
        '
        'TargetList
        '
        Me.TargetList.FormattingEnabled = True
        Me.TargetList.Location = New System.Drawing.Point(12, 12)
        Me.TargetList.Name = "TargetList"
        Me.TargetList.Size = New System.Drawing.Size(120, 95)
        Me.TargetList.TabIndex = 1
        '
        'ActiveBox
        '
        Me.ActiveBox.AutoSize = True
        Me.ActiveBox.Location = New System.Drawing.Point(277, 116)
        Me.ActiveBox.Name = "ActiveBox"
        Me.ActiveBox.Size = New System.Drawing.Size(56, 17)
        Me.ActiveBox.TabIndex = 8
        Me.ActiveBox.Text = "Active"
        Me.ActiveBox.UseVisualStyleBackColor = True
        '
        'AddBut
        '
        Me.AddBut.Location = New System.Drawing.Point(12, 112)
        Me.AddBut.Name = "AddBut"
        Me.AddBut.Size = New System.Drawing.Size(37, 23)
        Me.AddBut.TabIndex = 2
        Me.AddBut.Text = "➕"
        Me.AddBut.UseVisualStyleBackColor = True
        '
        'SubBut
        '
        Me.SubBut.Location = New System.Drawing.Point(95, 112)
        Me.SubBut.Name = "SubBut"
        Me.SubBut.Size = New System.Drawing.Size(37, 23)
        Me.SubBut.TabIndex = 3
        Me.SubBut.Text = "➖"
        Me.SubBut.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Radio Name in Cloudlog"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Title"
        '
        'CloudlogSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 162)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SubBut)
        Me.Controls.Add(Me.AddBut)
        Me.Controls.Add(Me.ActiveBox)
        Me.Controls.Add(Me.TargetList)
        Me.Controls.Add(Me.radioNameBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.KeyBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveBut)
        Me.Controls.Add(Me.URLBox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CloudlogSettingsForm"
        Me.ShowIcon = False
        Me.Text = "Cloudlog Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents URLBox As TextBox
    Friend WithEvents SaveBut As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents KeyBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents radioNameBox As TextBox
    Friend WithEvents TargetList As ListBox
    Friend WithEvents ActiveBox As CheckBox
    Friend WithEvents AddBut As Button
    Friend WithEvents SubBut As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
