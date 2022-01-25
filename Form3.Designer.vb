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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hi !" & Global.Microsoft.VisualBasic.ChrW(10) & "Let’s Start to Work and Manage Your Store" & Global.Microsoft.VisualBasic.ChrW(10) & "What Do You Want To Check First ?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 109)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(161, 304)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 112)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Employess"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(32, 216)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 48)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(32, 270)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(49, 47)
        Me.Button6.TabIndex = 6
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(32, 323)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(49, 43)
        Me.Button7.TabIndex = 7
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(612, 163)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 8
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(798, 465)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 34)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Close "
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(341, 304)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(112, 112)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "data user"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(341, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 109)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Stok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 527)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "DASHBOARD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button2 As Button
End Class
