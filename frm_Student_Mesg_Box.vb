Imports System.Data.SqlClient

Public Class frm_Student_Mesg_Box

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=pisdb_log;Integrated Security=True")
    

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub frm_Student_Mesg_Box_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Type As String = Common_Class.User_Type
        Dim Student_Name As String = Common_Class.Student_Name
        Dim Company_Name As String = Common_Class.C_Name
        If Type.ToString = "Company" Then
            tb_type.Text = Type
            tb_Name.Text = Company_Name
            tb_To.Text = Student_Name
        Else
            tb_type.Text = "Student"
            tb_Name.Text = Student_Name
            tb_To.Text = Company_Name
        End If

    End Sub


    Private Sub tb_Message_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Message.TextChanged
        Submit.Enabled = True
        caNCLE.Enabled = True
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        connection()
        cmd.Connection = con
        cmd.CommandText = "insert into Message_Box_Master values ('" + tb_type.Text + "','" + tb_Name.Text + "','" + tb_To.Text + "','" + dtp_Message_date.Text + "','" + tb_Message.Text + "')"
        Dim i As Integer = cmd.ExecuteNonQuery()

        If i > 0 Then
            MessageBox.Show("Message Send Succefully...")
            tb_Message.Text = ""
            Me.Close()

        End If
    End Sub
End Class