

Imports System.Data.SqlClient
Public Class FrmMarks
    Dim con As New SqlConnection("server=DESKTOP-KNP9Q60; database=DB_students1; integrated security=true")

    Dim adapter As SqlDataAdapter
    Dim dt, dtstudent, dtcourse As New DataTable
    Dim cmd As New SqlCommandBuilder

    Sub fillDVG()
        dt.Rows.Clear()
        adapter = New SqlDataAdapter("SELECT * From TBL_mark", con)
        adapter.Fill(dt)
        DGV.DataSource = dt

        DGV.Columns(0).HeaderText = "الطالب "
        DGV.Columns(1).HeaderText = "المادة "
        DGV.Columns(1).HeaderText = "الدرجة "

    End Sub

    Sub cmbStudents()
        adapter = New SqlDataAdapter("SELECT * From TBL_students", con)
        adapter.Fill(dtcourse)
        cmbstudent.DataSource = dtcourse
        cmbstudent.DisplayMember = "name"
        cmbstudent.ValueMember = "id"

    End Sub

    Private Sub FrmMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStudents()
        cmbcourses()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adapter = New SqlDataAdapter("SELECT  * From TBL_mark", con)
        adapter.Fill(dt)
        DGV.DataSource = dt
        Dim row As DataRow = dt.NewRow
        row(0) = cmbstudent.Text
        row(1) = cmbcourse.Text
        row(2) = txtmark.Text

        dt.Rows.Add(row)
        cmd = New SqlCommandBuilder(adapter)

        adapter.Update(dt)
        MsgBox("تمت الاضافة بنجاح ", MsgBoxStyle.Information, "تاكيد ")
        fillDVG()
    End Sub

    Sub cmbcourses()
        adapter = New SqlDataAdapter("SELECT * From TBL_courses", con)
        adapter.Fill(dtstudent)
        cmbcourse.DataSource = dtstudent
        cmbcourse.DisplayMember = "label"
        cmbcourse.ValueMember = "id"

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class