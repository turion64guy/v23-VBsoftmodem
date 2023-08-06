<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.data_user = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.speed_user = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.repeat_times_user = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.random_data_switch_user = New System.Windows.Forms.CheckBox()
        CType(Me.data_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speed_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repeat_times_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Transmit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'data_user
        '
        Me.data_user.Location = New System.Drawing.Point(85, 51)
        Me.data_user.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.data_user.Name = "data_user"
        Me.data_user.Size = New System.Drawing.Size(120, 20)
        Me.data_user.TabIndex = 1
        Me.data_user.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "speed"
        '
        'speed_user
        '
        Me.speed_user.Location = New System.Drawing.Point(80, 149)
        Me.speed_user.Maximum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.speed_user.Name = "speed_user"
        Me.speed_user.Size = New System.Drawing.Size(120, 20)
        Me.speed_user.TabIndex = 4
        Me.speed_user.Value = New Decimal(New Integer() {1200, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "repeat byte"
        '
        'repeat_times_user
        '
        Me.repeat_times_user.Location = New System.Drawing.Point(85, 77)
        Me.repeat_times_user.Maximum = New Decimal(New Integer() {32768, 0, 0, 0})
        Me.repeat_times_user.Name = "repeat_times_user"
        Me.repeat_times_user.Size = New System.Drawing.Size(120, 20)
        Me.repeat_times_user.TabIndex = 5
        Me.repeat_times_user.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "times"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "bauds"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "V23 softmodem TX test"
        '
        'random_data_switch_user
        '
        Me.random_data_switch_user.AutoSize = True
        Me.random_data_switch_user.Location = New System.Drawing.Point(22, 116)
        Me.random_data_switch_user.Name = "random_data_switch_user"
        Me.random_data_switch_user.Size = New System.Drawing.Size(89, 17)
        Me.random_data_switch_user.TabIndex = 10
        Me.random_data_switch_user.Text = "random bytes"
        Me.random_data_switch_user.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.random_data_switch_user)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.repeat_times_user)
        Me.Controls.Add(Me.speed_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data_user)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "V23 test"
        CType(Me.data_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speed_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repeat_times_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents data_user As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents speed_user As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents repeat_times_user As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents random_data_switch_user As System.Windows.Forms.CheckBox

End Class
