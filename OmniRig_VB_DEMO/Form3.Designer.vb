<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.CheckBoxTransverterOffsetEnable = New System.Windows.Forms.CheckBox()
        Me.TransverterOffsetFreq = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransverterOffsetType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckBoxTransverterOffsetEnable
        '
        Me.CheckBoxTransverterOffsetEnable.AutoSize = True
        Me.CheckBoxTransverterOffsetEnable.Location = New System.Drawing.Point(15, 9)
        Me.CheckBoxTransverterOffsetEnable.Name = "CheckBoxTransverterOffsetEnable"
        Me.CheckBoxTransverterOffsetEnable.Size = New System.Drawing.Size(147, 17)
        Me.CheckBoxTransverterOffsetEnable.TabIndex = 0
        Me.CheckBoxTransverterOffsetEnable.Text = "Enable Transverter Offset"
        Me.CheckBoxTransverterOffsetEnable.UseVisualStyleBackColor = True
        '
        'TransverterOffsetFreq
        '
        Me.TransverterOffsetFreq.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransverterOffsetFreq.Location = New System.Drawing.Point(106, 32)
        Me.TransverterOffsetFreq.Name = "TransverterOffsetFreq"
        Me.TransverterOffsetFreq.Size = New System.Drawing.Size(194, 20)
        Me.TransverterOffsetFreq.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Frequnecy Offset:"
        '
        'TransverterOffsetType
        '
        Me.TransverterOffsetType.FormattingEnabled = True
        Me.TransverterOffsetType.Items.AddRange(New Object() {"Plus", "Minus"})
        Me.TransverterOffsetType.Location = New System.Drawing.Point(106, 58)
        Me.TransverterOffsetType.Name = "TransverterOffsetType"
        Me.TransverterOffsetType.Size = New System.Drawing.Size(121, 21)
        Me.TransverterOffsetType.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Offset Type"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save Options"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AccessibleDescription = "Configure Transverter Offset Options within CloudlogCAT"
        Me.AccessibleName = "Transverter Offset Options"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 131)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TransverterOffsetType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TransverterOffsetFreq)
        Me.Controls.Add(Me.CheckBoxTransverterOffsetEnable)
        Me.Name = "Form3"
        Me.Text = "Transverter Offset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxTransverterOffsetEnable As CheckBox
    Friend WithEvents TransverterOffsetFreq As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TransverterOffsetType As ComboBox
    Private WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
