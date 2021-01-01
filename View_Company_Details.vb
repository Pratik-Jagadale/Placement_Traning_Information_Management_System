Imports System.Data.SqlClient

Public Class View_Company_Details

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")


    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub View_Company_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection()

            cmd = New SqlCommand("select * from add_requirment", con)


            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            dgv_View_Company.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Search_View_purchase_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_View_purchase_Details.Click

        Common_Class.C_Name = cb_Product_Name_View_purchase_Details.Text
        frm_Student_Mesg_Box.Show()
    End Sub

    Private Sub dgv_View_Company_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_View_Company.CellContentClick

    End Sub
End Class