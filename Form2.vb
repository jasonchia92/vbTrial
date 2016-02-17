Imports System.Data.SqlClient
Public Class Form2
    Dim connString As String = "Data Source=localhost;Initial Catalog=USERTEST;Persist Security Info=True;User ID=JASON;Password=12345"
    Public account_searchBx, id_searchBx, phone_searchBx, mail_searchBx As String
    Public count As Integer = 1
    Public max As Integer = 5
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '顯示List
        showList()
    End Sub

    Private Sub showList()
        Using conn As SqlConnection = New SqlConnection(connString)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Using connCmd As SqlCommand = New SqlCommand()
                connCmd.Connection = conn
                connCmd.CommandType = CommandType.StoredProcedure
                connCmd.CommandText = "users_get_LIST"
                connCmd.Parameters.Clear()

                Using listReader As SqlDataReader = connCmd.ExecuteReader
                    DataGridView1.Rows.Clear()

                    While (listReader.Read())
                        Dim acc As String = listReader.Item("account").ToString()
                        Dim name As String = listReader.Item("name").ToString()
                        Dim birthday As String = listReader.Item("birthday").ToString()
                        Dim id As String = listReader.Item("idnumber").ToString()
                        Dim mobile As String = listReader.Item("mobile").ToString()
                        Dim mail As String = listReader.Item("email").ToString()

                        Dim array() As String = New String() {acc, name, birthday, id, mobile, mail}
                        DataGridView1.Rows.Add(array)
                    End While
                End Using
            End Using
        End Using
    End Sub
  
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        '搜尋某特定用戶
        Dim searchBox As userSearch = New userSearch() '新增新一個dialog
        If searchBox.ShowDialog() = Windows.Forms.DialogResult.Yes Then '當用戶點擊開始搜尋時(DialogResult)

            account_searchBx = searchBox.accTxtBox.Text
            id_searchBx = searchBox.idTxtBx.Text.ToString
            phone_searchBx = searchBox.phoneTxtBx.Text.ToString
            mail_searchBx = searchBox.mailTxtBx.Text.ToString

            '為了達到模糊查詢 所有空白輸入都必須預設為%
            If String.IsNullOrEmpty(account_searchBx) Then account_searchBx = "%"
            If String.IsNullOrEmpty(id_searchBx) Then id_searchBx = "%"
            If String.IsNullOrEmpty(phone_searchBx) Then phone_searchBx = "%"
            If String.IsNullOrEmpty(mail_searchBx) Then mail_searchBx = "%"

            'Debug.WriteLine(account_searchBx, id_searchBx, phone_searchBx, mail_searchBx)

            Using conn As SqlConnection = New SqlConnection(connString)
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Using connCmd As SqlCommand = New SqlCommand()
                    connCmd.Connection = conn
                    connCmd.CommandType = CommandType.StoredProcedure
                    connCmd.CommandText = "getUsers"
                    connCmd.Parameters.Clear()

                    connCmd.Parameters.AddWithValue("@currentPAGE", count)
                    connCmd.Parameters.AddWithValue("@maxROWS", max)
                    connCmd.Parameters.AddWithValue("@account", account_searchBx)
                    connCmd.Parameters.AddWithValue("@idNumber", id_searchBx)
                    connCmd.Parameters.AddWithValue("@mobile", phone_searchBx)
                    connCmd.Parameters.AddWithValue("@email", mail_searchBx)


                    Using listReader As SqlDataReader = connCmd.ExecuteReader

                        DataGridView1.Rows.Clear()
                        While (listReader.Read())
                            Dim acc As String = listReader.Item("account").ToString()
                            Dim name As String = listReader.Item("name").ToString()
                            Dim birthday As String = listReader.Item("birthday").ToString()
                            Dim id As String = listReader.Item("idNumber").ToString()
                            Dim mobile As String = listReader.Item("mobile").ToString()
                            Dim mail As String = listReader.Item("email").ToString()

                            Dim array() As String = New String() {acc, name, birthday, id, mobile, mail}
                            DataGridView1.Rows.Add(array)
                        End While
                    End Using
                End Using
            End Using

        End If
    End Sub
End Class
