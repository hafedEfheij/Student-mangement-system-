Imports System.ComponentModel

Public Class FrmMain

    Public username As String

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        FrmLogin.Show()

        Me.Close()

    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        FrmAdd.Show()

    End Sub

    Private Sub Btnstudents_Click(sender As Object, e As EventArgs) Handles btnstudents.Click
        FrmStudents.Show()

    End Sub

    Private Sub Btncourses_Click(sender As Object, e As EventArgs) Handles btncourses.Click
        Frmcourses.Show()

    End Sub

    Private Sub Btnmarks_Click(sender As Object, e As EventArgs) Handles btnmarks.Click
        FrmMarks.Show()

    End Sub

    Private Sub Btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        MsgBox("هذا البرنامج تدريبي فقط لسنة 2022", MsgBoxStyle.Information, "حول")
    End Sub

    Private Sub Tsstudents_Click(sender As Object, e As EventArgs) Handles tsstudents.Click
        Btnstudents_Click(sender, e)
    End Sub

    Private Sub Tscourses_Click(sender As Object, e As EventArgs) Handles tscourses.Click
        Btncourses_Click(Nothing, Nothing)
    End Sub

    Private Sub Tdmarks_Click(sender As Object, e As EventArgs) Handles tdmarks.Click
        FrmMarks.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ssname.Text = username
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmAdd.Close()
        Frmcourses.Close()
        FrmLogin.Show()
        FrmMarks.Close()
        FrmStudents.Close()


    End Sub
End Class
