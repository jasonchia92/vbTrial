<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userSearch
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cancel = New System.Windows.Forms.Button()
        Me.seachButton = New System.Windows.Forms.Button()
        Me.mailTxtBx = New System.Windows.Forms.TextBox()
        Me.phoneTxtBx = New System.Windows.Forms.TextBox()
        Me.idTxtBx = New System.Windows.Forms.TextBox()
        Me.accTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idTxt = New System.Windows.Forms.Label()
        Me.phoneTxt = New System.Windows.Forms.Label()
        Me.mailTxt = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mailTxt)
        Me.GroupBox1.Controls.Add(Me.phoneTxt)
        Me.GroupBox1.Controls.Add(Me.idTxt)
        Me.GroupBox1.Controls.Add(Me.cancel)
        Me.GroupBox1.Controls.Add(Me.seachButton)
        Me.GroupBox1.Controls.Add(Me.mailTxtBx)
        Me.GroupBox1.Controls.Add(Me.phoneTxtBx)
        Me.GroupBox1.Controls.Add(Me.idTxtBx)
        Me.GroupBox1.Controls.Add(Me.accTxtBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8)
        Me.GroupBox1.Size = New System.Drawing.Size(595, 366)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "搜尋特定用戶"
        '
        'cancel
        '
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.cancel.Location = New System.Drawing.Point(318, 281)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(176, 43)
        Me.cancel.TabIndex = 9
        Me.cancel.Text = "取消"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'seachButton
        '
        Me.seachButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.seachButton.Location = New System.Drawing.Point(81, 281)
        Me.seachButton.Name = "seachButton"
        Me.seachButton.Size = New System.Drawing.Size(176, 43)
        Me.seachButton.TabIndex = 8
        Me.seachButton.Text = "搜尋"
        Me.seachButton.UseVisualStyleBackColor = True
        '
        'mailTxtBx
        '
        Me.mailTxtBx.Location = New System.Drawing.Point(163, 207)
        Me.mailTxtBx.Name = "mailTxtBx"
        Me.mailTxtBx.Size = New System.Drawing.Size(395, 34)
        Me.mailTxtBx.TabIndex = 7
        '
        'phoneTxtBx
        '
        Me.phoneTxtBx.Location = New System.Drawing.Point(163, 158)
        Me.phoneTxtBx.Name = "phoneTxtBx"
        Me.phoneTxtBx.Size = New System.Drawing.Size(395, 34)
        Me.phoneTxtBx.TabIndex = 5
        '
        'idTxtBx
        '
        Me.idTxtBx.Location = New System.Drawing.Point(165, 107)
        Me.idTxtBx.Name = "idTxtBx"
        Me.idTxtBx.Size = New System.Drawing.Size(393, 34)
        Me.idTxtBx.TabIndex = 3
        '
        'accTxtBox
        '
        Me.accTxtBox.Location = New System.Drawing.Point(163, 57)
        Me.accTxtBox.Name = "accTxtBox"
        Me.accTxtBox.Size = New System.Drawing.Size(395, 34)
        Me.accTxtBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "員工編號"
        '
        'idTxt
        '
        Me.idTxt.AutoSize = True
        Me.idTxt.Location = New System.Drawing.Point(42, 116)
        Me.idTxt.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(112, 25)
        Me.idTxt.TabIndex = 10
        Me.idTxt.Text = "身分證字號"
        '
        'phoneTxt
        '
        Me.phoneTxt.AutoSize = True
        Me.phoneTxt.Location = New System.Drawing.Point(42, 167)
        Me.phoneTxt.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.phoneTxt.Name = "phoneTxt"
        Me.phoneTxt.Size = New System.Drawing.Size(92, 25)
        Me.phoneTxt.TabIndex = 11
        Me.phoneTxt.Text = "手機號碼"
        '
        'mailTxt
        '
        Me.mailTxt.AutoSize = True
        Me.mailTxt.Location = New System.Drawing.Point(42, 216)
        Me.mailTxt.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.mailTxt.Name = "mailTxt"
        Me.mailTxt.Size = New System.Drawing.Size(92, 25)
        Me.mailTxt.TabIndex = 12
        Me.mailTxt.Text = "電子郵件"
        '
        'userSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 20.0!)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "userSearch"
        Me.Text = "userSearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mailTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents phoneTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents idTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents accTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents seachButton As System.Windows.Forms.Button
    Friend WithEvents mailTxt As System.Windows.Forms.Label
    Friend WithEvents phoneTxt As System.Windows.Forms.Label
    Friend WithEvents idTxt As System.Windows.Forms.Label
End Class
