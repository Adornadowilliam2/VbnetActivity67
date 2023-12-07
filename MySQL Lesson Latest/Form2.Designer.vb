<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbusername
        '
        Me.tbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbusername.Location = New System.Drawing.Point(54, 31)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(245, 31)
        Me.tbusername.TabIndex = 0
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(51, 9)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(67, 13)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.Location = New System.Drawing.Point(253, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password:"
        '
        'tbpassword
        '
        Me.tbpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpassword.Location = New System.Drawing.Point(54, 115)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.Size = New System.Drawing.Size(245, 31)
        Me.tbpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Email:"
        '
        'tbemail
        '
        Me.tbemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbemail.Location = New System.Drawing.Point(54, 190)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(245, 31)
        Me.tbemail.TabIndex = 5
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 301)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbemail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.tbusername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddForm"
        Me.ShowIcon = False
        Me.Text = "Add a Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbusername As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbemail As TextBox
End Class
