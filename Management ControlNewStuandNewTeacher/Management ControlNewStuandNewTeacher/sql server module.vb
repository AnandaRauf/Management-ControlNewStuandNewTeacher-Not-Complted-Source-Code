Imports System.Data.SqlClient
Module sql_server_module
    Public koneksiSQL As SqlConnection

    Sub konekdatabase()
        Try
            koneksiSQL = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Penting\Database Kulibet Restor\Kulibet_Restor.mdf;Integrated Security=True;Connect Timeout=30")
            koneksiSQL.Open()
        Catch ex As Exception
            MsgBox("Sorry Cant Connect Server !", MsgBoxStyle.Critical, “Connection Failed !!!”)
        End Try
    End Sub
    Public Sub jalankansql(ByVal sql As String)
        Dim SQLCmd As New SqlCommand
        konekdatabase()
        Try
            SQLCmd.Connection = koneksiSQL
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sql
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            koneksiSQL.Close()

            MsgBox("Data  Has Been Saved", vbInformation)
        Catch ex As Exception
            MsgBox("Sorry Cant Save Data" + "Data to Server" & ex.Message)
        End Try
    End Sub
End Module

