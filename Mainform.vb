Public Class frm_Mainform


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Student.Click
        login_screen.Show()
        Dim x As Integer = 271
        Dim y As Integer = 112

        Panel_Highlighter.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Company.Click
        login_screen.Show()
        Dim x As Integer = 271
        Dim y As Integer = 241

        Panel_Highlighter.Location = New System.Drawing.Point(x, y)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        login_screen.Show()

        Dim x As Integer = 271
        Dim y As Integer = 363

        Panel_Highlighter.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        student_registration.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        company_registration.Show()
    End Sub

    Private Sub btn_Registartion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Registartion.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TabControl1.SelectedIndex = 3
    End Sub
End Class