Imports System.Data.Odbc

Public Class Class1
    'DSN = Data Source Name
    Private conn As New OdbcConnection("DSN=lesson_sample")

    Private dta As New SampleDataSet

    'Function = they return a value
    'Sub = doesn't return a value
    'INSERT QUERY STRUCTURE
    '[
    'INSERT INTO table_name (col1, col2, col3 ....)
    'VALUES (value1, value2, value3 ..... valifinity)
    ']

    Public Sub adduser(username As String, password As String, email As String)
        Try
            conn.Open()
            'unsafe
            'code below can and will accept anotherquery (like SELECT or any DML query)
            'username = "','','','; DELETE FROM tbl_users --"
            'password = "','','','; DELETE FROM tbl_users --"
            'email = "','','','; DELETE FROM tbl_users --"
            'Dim sql As String = "INSERT INTO tbl_users (surname, password, email) VALUES (" + username + "," + password + "," + email + ")"

            Dim sql As String = "INSERT INTO tbl_users (username, password, email) VALUES (?,?,?)"
            Dim cmd As New OdbcCommand(sql, conn)
            'field1 = username
            cmd.Parameters.Add("@field1", OdbcType.VarChar, 12).Value = username
            'field2 = password
            cmd.Parameters.Add("@field2", OdbcType.Text).Value = password
            'field3 = email
            cmd.Parameters.Add("@field3", OdbcType.VarChar, 100).Value = email
            cmd.ExecuteNonQuery()




            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub retrieveData(dgv As DataGridView)
        'any error that will happen inside try will not make the application crash
        'application will instead go to the Catch block to do any code inside Catch block
        'if database is being accessed inside Try block, put a close connection command inside Catch Block
        Try
            conn.Open()
            'codes
            'prepare sql text
            Dim sql As String = "SELECT * FROM tbl_users"

            'config adapter
            'OdbcDataAdapter(query, connection)
            Dim adp As New OdbcDataAdapter(sql, conn)

            'clear DataTable first
            dta.Tables("users").Clear()

            'fill up DataTable using odbcdataadapter
            adp.Fill(dta.Tables("users"))

            conn.Close()

            'update datagridview
            dgv.DataSource = dta.Tables("users")
            dgv.Refresh()

        Catch ex As Exception
            conn.Close()
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    'INSERT QUERY STRUCTURE
    '[
    'INSERT INTO table_name (col1, col2, col3 ....)
    'VALUES (value1, value2, value3 ..... valifinity)
    ']

    Public Sub updateuser(userID As Integer, username As String, password As String, email As String)
        Try
            conn.Open()
            'unsafe
            'code below can and will accept anotherquery (like SELECT or any DML query)
            'username = "','','','; DELETE FROM tbl_users --"
            'password = "','','','; DELETE FROM tbl_users --"
            'email = "','','','; DELETE FROM tbl_users --"
            'Dim sql As String = "INSERT INTO tbl_users (surname, password, email) VALUES (" + username + "," + password + "," + email + ")"

            Dim sql As String = "UPDATE tbl_users SET username=?, password=?, email=? WHERE user_id =?"
            Dim cmd As New OdbcCommand(sql, conn)
            'field1 = username
            cmd.Parameters.Add("@field1", OdbcType.VarChar, 12).Value = username
            'field2 = password
            cmd.Parameters.Add("@field2", OdbcType.Text).Value = password
            'field3 = email
            cmd.Parameters.Add("@field3", OdbcType.VarChar, 100).Value = email
            'filed4 =user_id
            cmd.Parameters.Add("@field4", OdbcType.Int).Value = userID
            'END ============================================================================================
            cmd.ExecuteNonQuery()




            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    'DELETE QUERY STRUCTURE
    'DELETE 
    Public Sub deleteuser(userID As Integer)
        Try
            conn.Open()
            'unsafe
            'code below can and will accept anotherquery (like SELECT or any DML query)
            'username = "','','','; DELETE FROM tbl_users --"
            'password = "','','','; DELETE FROM tbl_users --"
            'email = "','','','; DELETE FROM tbl_users --"
            'Dim sql As String = "INSERT INTO tbl_users (surname, password, email) VALUES (" + username + "," + password + "," + email + ")"

            Dim sql As String = "DELETE FROM tbl_users WHERE user_id = ?"
            Dim cmd As New OdbcCommand(sql, conn)
            'field1 = username
            cmd.Parameters.Add("@field1", OdbcType.Int).Value = userID
            'END ============================================================================================
            cmd.ExecuteNonQuery()




            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
