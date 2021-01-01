Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_user_name.Focus()
    End Sub

    Private Sub tb_user_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_user_name.TextChanged
        tb_password.Enabled = True
    End Sub

    Private Sub tb_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_password.TextChanged
        btn_Login.Enabled = True
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim name As String

        con.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=pisdb;Integrated Security=True;Pooling=true"
        con.Open()

        cmd.Connection = con
        cmd.CommandText = "select * from loginform where Username ='" + tb_user_name.Text + "' and Password=" + tb_password.Text + ""

        name = cmd.ExecuteScalar

        If (name <> "") Then
            If (tb_user_name.Text = "admin") Then
                MessageBox.Show("Welcome Admin", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                frm_Mainform.Show()
            Else
                MessageBox.Show("Welcome User", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                frm_Mainform.Show()
            End If
            Me.Hide()
        Else

            tb_user_name.Focus()
            tb_user_name.Text = ""
            tb_password.Text = ""
            tb_password.Enabled = False
            btn_Login.Enabled = False

        End If
        tb_user_name.Focus()
        tb_user_name.Text = ""
        tb_password.Text = ""
        tb_password.Enabled = False
        btn_Login.Enabled = False

    End Sub
End Class
