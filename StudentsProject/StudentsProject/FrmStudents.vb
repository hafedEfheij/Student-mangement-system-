
Imports System.Data.SqlClient
Public Class FrmStudents
    Dim con As New SqlConnection("server=DESKTOP-KNP9Q60; database=DB_students1; integrated security=true")
    Dim adapter As SqlDataAdapter
    Dim dt As New DataTable
    Dim cmd As New SqlCommandBuilder
    Sub DGVfill()
        dt.Rows.Clear()
        adapter = New SqlDataAdapter("SELECT   id, name  ,address  ,date  From TBL_students", con)
        adapter.Fill(dt)
        DGV.DataSource = dt
        DGV.Columns(0).Visible = False
        DGV.Columns(1).HeaderText = "الاسم "
        DGV.Columns(2).HeaderText = "العنوان "
        DGV.Columns(3).HeaderText = "التاريخ "
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAdd.oper = "add"
        FrmAdd.Label4.Text = "اضافة بيانات طالب "
        FrmAdd.Button1.Text = "اضافة"

        FrmAdd.ShowDialog()
        DGVfill()
    End Sub

    Private Sub FrmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGVfill()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = " name+ address +date  like '%" & TextBox1.Text & "%'"
            DGV.DataSource = dv
        Catch ex As Exception
            Exit Sub
        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmAdd.oper = "edit"
        FrmAdd.id = DGV.CurrentRow.Cells(0).Value
        FrmAdd.Label4.Text = "تعديل بيانات الطالب :" & DGV.CurrentRow.Cells(1).Value
        FrmAdd.Button1.Text = "تعديل"
        FrmAdd.TextBox1.Text = DGV.CurrentRow.Cells(1).Value
        FrmAdd.TextBox2.Text = DGV.CurrentRow.Cells(2).Value
        FrmAdd.DateTimePicker1.Value = DGV.CurrentRow.Cells(3).Value

        FrmAdd.ShowDialog()
        DGVfill()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If dt.Constraints.Contains("primary") Then

        Else

            dt.Constraints.Add("primary", dt.Columns(0), True)
        End If
        Dim row As DataRow = dt.Rows.Find(DGV.CurrentRow.Cells(0).Value)
        If row Is Nothing Then
            MsgBox("البيانات غير موجودة", MsgBoxStyle.Exclamation, "الحدف")
        Else

            If MsgBox("هل تريد الحذف ", MsgBoxStyle.YesNo, "تاكيد") = DialogResult.Yes Then

                row.Delete()
                cmd = New SqlCommandBuilder(adapter)
                adapter.Update(dt)
                MsgBox("تم الحذف بنجاح ", MsgBoxStyle.Information, "الحذف")
            Else
                MsgBox("تم الغاء الحذف ", MsgBoxStyle.Information, "الحذف")

            End If

        End If

    End Sub
End Class