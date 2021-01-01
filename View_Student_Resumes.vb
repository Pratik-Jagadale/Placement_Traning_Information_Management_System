Imports System.Data.SqlClient

Public Class View_Student_Resumes


    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub View_Student_Resumes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection()

            cmd = New SqlCommand("select * from student_detail", con)


            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            dgv_View_Student_Details.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Search_View_purchase_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_View_purchase_Details.Click

        Common_Class.Student_Name = cb_Product_Name_View_purchase_Details.Text
        frm_Student_Mesg_Box.Show()
    End Sub
End Class