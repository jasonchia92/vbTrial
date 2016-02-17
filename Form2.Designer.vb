<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.account = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.search = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(24, 1132)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 90)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.account, Me.enName, Me.birthday, Me.id, Me.mobile, Me.email})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(894, 198)
        Me.DataGridView1.TabIndex = 0
        '
        'account
        '
        Me.account.HeaderText = "帳號"
        Me.account.Name = "account"
        '
        'enName
        '
        Me.enName.HeaderText = "名字"
        Me.enName.Name = "enName"
        '
        'birthday
        '
        Me.birthday.HeaderText = "生日日期"
        Me.birthday.Name = "birthday"
        '
        'id
        '
        Me.id.HeaderText = "身分證字號"
        Me.id.Name = "id"
        '
        'mobile
        '
        Me.mobile.HeaderText = "手機號碼"
        Me.mobile.Name = "mobile"
        '
        'email
        '
        Me.email.HeaderText = "電子郵件信箱"
        Me.email.Name = "email"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(14, 514)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(99, 35)
        Me.search.TabIndex = 2
        Me.search.Text = "搜尋"
        Me.search.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 561)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 15.0!)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents enName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents birthday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents search As System.Windows.Forms.Button
End Class
