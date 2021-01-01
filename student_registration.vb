Imports System.Data.SqlClient

Public Class student_registration

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Function auto_incre()
        connection()
        Dim cnt As Integer
        cmd = New SqlCommand("select count(Student_ID)from student_registration", con)
        cnt = cmd.ExecuteScalar
        If cnt = 0 Then
            cnt = 101
        Else
            cnt += 101
        End If
        con.Close()
        textstudname.Focus()
        Return cnt
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        connection()

        If textstudname.Text <> "" And textmobno.Text <> "" And textemailid.Text <> "" And textentpass.Text = textconfpass.Text Then
            connection()
            cmd.Connection = con
            cmd.CommandText = "insert into student_registration values (" + tb_Student_id.Text + ",'" + textstudname.Text + "'," + textmobno.Text + ",'" + textemailid.Text + "','" + textentpass.Text + "')"

            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                
                tb_Student_id.Text = auto_incre()

            Else
            End If
            MessageBox.Show("Student Registred Succesffuly")
            textstudname.Text = ""
            textmobno.Text = ""
            textentpass.Text = ""
            textconfpass.Text = ""
            textemailid.Text = ""
            student_details.Show()

            Try
                connection()

                cmd = New SqlCommand("select * from student_registration", con)


                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                da.Fill(dt)

                dgv_Student_Registration.DataSource = dt
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Please Fill Correct Information")
        End If
        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub student_registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_Student_id.Text = auto_incre()
        textstudname.Focus()

        Try
            connection()

            cmd = New SqlCommand("select * from student_registration", con)


            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            dgv_Student_Registration.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        connection()
        Dim cnt As Integer
        cmd = New SqlCommand("Delete from student_registration where Student_ID = " + tb_Student_id.Text + "", con)
        cnt = cmd.ExecuteScalar
        If (cnt > 0) Then
            MessageBox.Show("ddd")
        End If
    End Sub

    Private Sub tb_Student_id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Student_id.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textstudname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textstudname.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textmobno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textmobno.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textentpass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textentpass.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textconfpass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textconfpass.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
End Class