Imports System.Data.SqlClient

Public Class company_registration
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

        connection()
        If textname.Text <> "" And textaddress.Text <> "" And textcontno.Text <> "" And textemailid.Text <> "" And textwebsite.Text <> "" And textcity.Text <> "" And textenterpass.Text <> "" And textconfpass.Text <> "" And textenterpass.Text = textconfpass.Text Then
            cmd = New SqlCommand(" insert into Company_registration values( '" + textname.Text + "','" + textaddress.Text + "'," + textcontno.Text + ",'" + textemailid.Text + "','" + textwebsite.Text + "','" + textcity.Text + "','" + textenterpass.Text + "')", con)
            Dim i As Integer = cmd.ExecuteScalar
            If (i > 0) Then
                MessageBox.Show("registered Successfully")

                textname.Text = ""
                textaddress.Text = ""
                textcontno.Text = ""
                textemailid.Text = ""
                textwebsite.Text = ""
                textcity.Text = ""
                textenterpass.Text = ""
                textname.Focus()

            Else

            End If
            MessageBox.Show("registered Successfully")

            textname.Text = ""
            textaddress.Text = ""
            textcontno.Text = ""
            textemailid.Text = ""
            textwebsite.Text = ""
            textcity.Text = ""
            textenterpass.Text = ""
            textname.Focus()
        Else
            MessageBox.Show("Please fill the all fields")
        End If
        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub textname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textname.TextChanged

    End Sub

    Private Sub textname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textname.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If

    End Sub

    Private Sub textaddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textaddress.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If

    End Sub

    Private Sub textcity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textcity.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If

    End Sub

    Private Sub textwebsite_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textwebsite.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If

    End Sub

    Private Sub textcontno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textcontno.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub company_registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        textname.Focus()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class