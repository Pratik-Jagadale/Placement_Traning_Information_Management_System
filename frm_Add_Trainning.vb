Imports System.Data.SqlClient

Public Class frm_Add_Trainning

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")
    Dim C_Name As String = Common_Class.C_Name

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_post.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub frm_Add_Trainning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cb_post.Focus()
    End Sub

    Private Sub cb_post_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_post.Click

        connection()
        cmd = New SqlCommand("select distinct(post) from add_requirment where CompanyName = '" + C_Name + "'", con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        ad.Fill(table)
        cb_post.DataSource = table
        cb_post.DisplayMember = "post"

        ad.Dispose()
        cmd.Dispose()

    End Sub

    Private Sub btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Submit.Click
        If cb_post.Text <> "" And text_Trainner.Text <> "" Then
            connection()
            cmd = New SqlCommand("insert into tranning_Master values ( '" + C_Name + "','" + cb_post.Text + "','" + text_Trainner.Text + "','" + dtp_start_date.Text + "','" + dtp_End_Date.Text + "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("New Tranning Added Successfully...")
                cb_post.Text = ""
                text_Trainner.Text = ""
                dtp_End_Date.Text = ""
                dtp_start_date.Text = ""
            End If

        Else
            MessageBox.Show("Fill Correct Information")
        End If
    End Sub
End Class