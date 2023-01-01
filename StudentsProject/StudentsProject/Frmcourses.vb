Imports System.Data.SqlClient
Public Class Frmcourses
    Dim con As New SqlConnection("server=DESKTOP-KNP9Q60; database=DB_students1; integrated security=true")
    Dim adapter As SqlDataAdapter
    Dim dt As New DataTable
    Dim cmd As New SqlCommandBuilder
    Sub fillDVG()
        adapter = New SqlDataAdapter("SELECT * From TBL_courses", con)
        adapter.Fill(dt)
        DGV.DataSource = dt
        Me.DGV.Columns(0).Visible = False

        Me.DGV.Columns(0).ReadOnly = True
        DGV.Columns(1).HeaderText = "الاسم "

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd = New SqlCommandBuilder(adapter)
            adapter.Update(dt)
            MsgBox("تم الحفظ بنجاح  ", MsgBoxStyle.Information, "تاكيد")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Frmcourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDVG()
    End Sub
End Class