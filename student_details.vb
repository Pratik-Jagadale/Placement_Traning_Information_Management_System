Imports System.Data.SqlClient

Public Class student_details

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")
    Dim gen As String = ""
    Dim dr As SqlDataReader

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
            cnt = 100
        Else
            cnt += 100
        End If
        con.Close()
        textstudname.Focus()
        Return cnt
    End Function

    Private Sub student_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_Student_id.Text = auto_incre()
        textstudname.Focus()

        connection()
        cmd = New SqlCommand("select * from student_registration where Student_ID = " + tb_Student_id.Text + "", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            textstudname.Text = dr("Student_Name").ToString
            textmobno.Text = dr("Mobile_No").ToString
            textstudname.Enabled = False
            textmobno.Enabled = False
        Else

        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        connection()

        If rb_Male.Checked Then
            gen = "Other"
        End If
        If rb_Female.Checked Then
            gen = "Female"
        End If
        If rb_Female.Checked Then
            gen = "Male"
        End If
        If tb_Student_id.Text <> "" And textstudname.Text <> "" And textmobno.Text <> "" And dtp_DOB.Text <> "" And textssc.Text <> "" And textpassyear.Text <> "" And texthsc.Text <> "" And textpassyear2.Text <> "" And textpassyear2.Text <> "" And textpassyear3.Text <> "" And textgradcoll.Text <> "" And textbranch.Text <> "" Then
            cmd = New SqlCommand(" insert into student_detail values( " + tb_Student_id.Text + ",'" + textstudname.Text + "'," + textmobno.Text + ",'" + dtp_DOB.Text + "','" + gen + "'," + textssc.Text + "," + textpassyear.Text + "," + texthsc.Text + "," + textpassyear2.Text + "," + textpassyear2.Text + "," + textpassyear3.Text + ",'" + textgradcoll.Text + "','" + textbranch.Text + "' )", con)
            Dim i As Integer = cmd.ExecuteScalar
            If (i > 0) Then
                MessageBox.Show("Student details Added Successfully")
            Else

            End If
            gen = ""
            If rb_Female.Checked Then
                gen = "Female"
            End If
        End If



    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        'connection()
        'Dim cnt As Integer
        'cmd = New SqlCommand("Delete from student_registration where Student_ID = " + tb_Student_id.Text + "", con)
        'cnt = cmd.ExecuteScalar
        'If (cnt > 0) Then
        '    MessageBox.Show("Cancled...")
        'End If
    End Sub

    Private Sub rb_Other_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Other.CheckedChanged
        gen = ""
        
    End Sub

    Private Sub rb_Female_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Female.CheckedChanged
        gen = ""
       
    End Sub

    Private Sub rb_Male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Male.CheckedChanged
        gen = ""
       
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

    Private Sub textssc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textssc.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub texthsc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles texthsc.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textgrad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textgrad.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textpassyear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textpassyear.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textpassyear2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textpassyear2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textpassyear3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textpassyear3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textgradcoll_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textgradcoll.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub textbranch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textbranch.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
End Class