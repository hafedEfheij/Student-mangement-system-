Imports System.Data.SqlClient
Public Class FrmAdd
    Dim con As New SqlConnection("server=DESKTOP-KNP9Q60; database=DB_students1; integrated security=true")

    Dim adapter As SqlDataAdapter
    Dim dt As New DataTable
    Dim cmd As New SqlCommandBuilder
    Public oper As String = "add"
    Public id As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If oper = "add" Then
                adapter = New SqlDataAdapter("SELECT * From TBL_students", con)
                adapter.Fill(dt)
                Dim row As DataRow = dt.NewRow
                row(1) = TextBox1.Text
                row(2) = TextBox2.Text
                row(3) = DateTimePicker1.Value

                dt.Rows.Add(row)
                cmd = New SqlCommandBuilder(adapter)

                adapter.Update(dt)
                MsgBox("تمت الاضافة بنجاح ", MsgBoxStyle.Information, "تاكيد ")
                TextBox1.Clear()
                TextBox2.Clear()
                DateTimePicker1.ResetText()

            Else
                adapter = New SqlDataAdapter("SELECT * From TBL_students", con)
                adapter.Fill(dt)


                If dt.Constraints.Contains("primary") Then

                Else

                    dt.Constraints.Add("primary", dt.Columns(0), True)
                End If
                Dim row As DataRow = dt.Rows.Find(id)
                row(1) = TextBox1.Text
                row(2) = TextBox2.Text
                row(3) = DateTimePicker1.Value.Date
                cmd = New SqlCommandBuilder(adapter)
                adapter.Update(dt)
                MsgBox("تم التحديث بنجاح ", MsgBoxStyle.Information, "تاكيد")


            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class