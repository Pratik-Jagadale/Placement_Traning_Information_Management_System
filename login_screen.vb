Imports System.Data.SqlClient

Public Class login_screen

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim i As Integer = 0
        connection()

        cmd.Connection = con

        If texttype.Text = "Student" Then
            cmd.CommandText = "select * from student_registration where Student_Name = '" + textusername.Text + "' and Enter_Password = '" + textpass.Text + "' "
            i = cmd.ExecuteScalar()

            If (i > 0) Then
                MessageBox.Show("Login Succesfully")
                
                Common_Class.C_Name = ""
                Common_Class.User_Type = "Student"
                Common_Class.Student_Name = textusername.Text
                textusername.Focus()
                textusername.Text = ""
                textpass.Text = ""
                student_portal.Show()
            Else
                MessageBox.Show("Inavlid User Name or Paaword")
                textusername.Focus()
                textusername.Text = ""
                textpass.Text = ""

            End If

        ElseIf texttype.Text = "Admin" Then
            cmd.CommandText = "select * from loginform where Username = '" + textusername.Text + "' and Password = '" + textpass.Text + "' "
            i = cmd.ExecuteNonQuery()
            If (i > -2) Then
                
                Common_Class.C_Name = ""
                Common_Class.User_Type = "Admin"
                Common_Class.Student_Name = ""
                MessageBox.Show("Login Succesfully")
                textusername.Focus()
                textusername.Text = ""
                textpass.Text = ""
                frm_Mainform.Show()
            Else
                textusername.Focus()
                textusername.Text = ""
                textpass.Text = ""
                MessageBox.Show("Inavlid User Name or Paaword")
            End If

        ElseIf texttype.Text = "Company" Then
            cmd.CommandText = "select * from Company_registration where Name = '" + textusername.Text + "' and Password = '" + textpass.Text + "' "
            i = cmd.ExecuteNonQuery()

            Common_Class.C_Name = textusername.Text
            If (i > -2) Then
                MessageBox.Show("Login Succesfully")

                Common_Class.C_Name = textusername.Text
                Common_Class.User_Type = "Company"
                Common_Class.Student_Name = ""

                textusername.Focus()
                textusername.Text = ""
                textpass.Text = ""
                company_portal.Show()
            Else
                textusername.Focus()
                textusername.Text = ""
                textpass.Text = ""
                MessageBox.Show("Inavlid User Name or Paaword")
            End If
        End If
       
        con.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub login_screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub textusername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textusername.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub texttype_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles texttype.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
End Class