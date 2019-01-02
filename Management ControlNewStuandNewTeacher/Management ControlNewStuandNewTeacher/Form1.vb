Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Private Sub ExBut_Click(sender As Object, e As EventArgs) Handles ExBut.Click
        MsgBox("Are you sure exit ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()

    End Sub

    Private Sub LogBut_Click(sender As Object, e As EventArgs) Handles LogBut.Click
        Call konekdatabase()
        Dim SQLCmd As New SqlCommand
        Dim DR As SqlDataReader
        SQLCmd = New SqlCommand("Select * From tbl_admin where Username='" & User.Text & "' and Password='" & pass.Text & "'", koneksiSQL)

        DR = SQLCmd.ExecuteReader



        If DR.Read Then

            User.Focus()
            pass.Focus()
            MsgBox("Login Succesfull !")
            MsgBox("Thanks For Using This Apps Desktop")
            MsgBox("Dont Forget Follow Developer & Company Social Media Account")
            MsgBox("For More Information About Product Program")
            Main_Menu.Show()

        Else
            MsgBox("Sorry Login Failed ! Wrong Username & Password !")

            userbox.Clear()

            Passbox.Clear()

            User.Focus()





        End If

    End Sub

End Class