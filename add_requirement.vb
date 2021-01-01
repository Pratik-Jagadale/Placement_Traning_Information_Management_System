Imports System.Data.SqlClient

Public Class add_requirement
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=pisdb;Integrated Security=True;Pooling=False")


    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub add_requirement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_company_Name.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connection()
        Dim cr As String = "HSC"

        If tb_company_Name.Text <> "" And post.Text <> "" And tb_Vacncy.Text <> "" And tb_Year_gap.Text <> "" Then

            cmd = New SqlCommand(" insert into add_requirment values( '" + tb_company_Name.Text + "','" + post.Text + "'," + tb_Vacncy.Text + ",'" + cr + "'," + tb_Year_gap.Text + " )", con)
            Dim i As Integer = cmd.ExecuteScalar
            If i > 0 Then
                MessageBox.Show("Recrutement Added Succesfully")

                tb_company_Name.Text = ""
                post.Text = ""
                tb_Vacncy.Text = ""
                tb_Year_gap.Text = ""
            Else
                MessageBox.Show("System Error")
            End If
        End If
    End Sub

    Private Sub tb_company_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_company_Name.TextChanged

    End Sub

    Private Sub tb_company_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_company_Name.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub post_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles post.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
End Class
