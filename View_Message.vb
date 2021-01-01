Imports System.Data.SqlClient

Public Class View_Message

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")
    Dim Compnay_Name As String = Common_Class.C_Name
    Dim Student_Name As String = Common_Class.Student_Name
    Dim Type As String = Common_Class.User_Type


    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub View_Message_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection()
            
            Dim Ctemp As String = "Company"
            Dim Stemp As String = "Student"

            If Type = "Company" Then

                cmd = New SqlCommand("select * from Message_Box_Master where type= '" + Stemp + "' and Msg_To = '" + Compnay_Name + "'", con)

            ElseIf Type = "Student" Then

                cmd = New SqlCommand("select * from Message_Box_Master where Type = '" & Ctemp & "' and Msg_To = '" & Student_Name & "' ", con)

            End If

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            dgv_MSG_BOX.DataSource = dt
            cmd.Dispose()
            con.Close()
            tb_Name.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tb_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Name.TextChanged
        btn_read.Enabled = True
    End Sub

    Private Sub btn_read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_read.Click
        Try
            connection()
            Dim dr As SqlDataReader
            Dim Ctemp As String = "Company"
            Dim Stemp As String = "Student"

            If Type = "Company" Then

                cmd = New SqlCommand("select * from Message_Box_Master where type= '" + Stemp + "' and Msg_From = '" + tb_Name.Text + "'", con)

            ElseIf Type = "Student" Then

                cmd = New SqlCommand("select * from Message_Box_Master where Type = '" & Ctemp & "' and Msg_From = '" & tb_Name.Text & "' ", con)

            End If

            dr = cmd.ExecuteReader
            If dr.Read Then
                tb_msg.Text = dr("Message").ToString
                tb_msg.Enabled = False
            End If

            dr.Close()
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class