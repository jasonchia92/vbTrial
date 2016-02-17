<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.account = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.confirm = New System.Windows.Forms.Button()
        Me.accountInput = New System.Windows.Forms.TextBox()
        Me.passwordInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'account
        '
        Me.account.AutoSize = True
        Me.account.Font = New System.Drawing.Font("微軟正黑體", 20.0!)
        Me.account.Location = New System.Drawing.Point(45, 114)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(69, 34)
        Me.account.TabIndex = 3
        Me.account.Text = "帳號"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("微軟正黑體", 20.0!)
        Me.password.Location = New System.Drawing.Point(45, 173)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(69, 34)
        Me.password.TabIndex = 4
        Me.password.Text = "密碼"
        '
        'confirm
        '
        Me.confirm.Location = New System.Drawing.Point(100, 239)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(244, 50)
        Me.confirm.TabIndex = 7
        Me.confirm.Text = "登陸"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'accountInput
        '
        Me.accountInput.Font = New System.Drawing.Font("微軟正黑體", 20.0!)
        Me.accountInput.Location = New System.Drawing.Point(139, 111)
        Me.accountInput.Name = "accountInput"
        Me.accountInput.Size = New System.Drawing.Size(245, 43)
        Me.accountInput.TabIndex = 12
        '
        'passwordInput
        '
        Me.passwordInput.Font = New System.Drawing.Font("微軟正黑體", 20.0!)
        Me.passwordInput.Location = New System.Drawing.Point(139, 170)
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.Size = New System.Drawing.Size(245, 43)
        Me.passwordInput.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(133, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 34)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "會員帳號系統"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 340)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordInput)
        Me.Controls.Add(Me.accountInput)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.account)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents account As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents confirm As System.Windows.Forms.Button
    Friend WithEvents accountInput As System.Windows.Forms.TextBox
    Friend WithEvents passwordInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
