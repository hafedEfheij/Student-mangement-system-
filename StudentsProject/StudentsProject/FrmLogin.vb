
Imports System.Data.SqlClient
Public Class FrmLogin
    Dim con As New SqlConnection("server=DESKTOP-KNP9Q60; database=DB_students1; integrated security=true")
    Dim adapter As SqlDataAdapter
    Dim dt As New DataTable
    Dim cmd As New SqlCommandBuilder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adapter = New SqlDataAdapter("SELECT  * From TBL_user where id='" & txtuser.Text & "' and password='" & txtpass.Text & "' ", con)
        adapter.Fill(dt)
        FrmMain.username = txtuser.Text
        If dt.Rows.Count > 0 Then
            FrmMain.Show()
            Me.Close()

        Else
            MsgBox(" يوجد خطاء في اليبانات ", MsgBoxStyle.Information, "تاكيد")
            txtuser.Clear()
            txtpass.Clear()
            txtuser.Focus()


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


End Class
