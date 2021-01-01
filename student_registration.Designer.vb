<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textmobno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textemailid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textentpass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textconfpass = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.textstudname = New System.Windows.Forms.TextBox()
        Me.tb_Student_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_Student_Registration = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dgv_Student_Registration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(41, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Name       : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(47, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mobile No            : "
        '
        'textmobno
        '
        Me.textmobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.textmobno.Location = New System.Drawing.Point(321, 259)
        Me.textmobno.MaxLength = 10
        Me.textmobno.Name = "textmobno"
        Me.textmobno.Size = New System.Drawing.Size(227, 24)
        Me.textmobno.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(44, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Email ID               : "
        '
        'textemailid
        '
        Me.textemailid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.textemailid.Location = New System.Drawing.Point(321, 329)
        Me.textemailid.MaxLength = 40
        Me.textemailid.Name = "textemailid"
        Me.textemailid.Size = New System.Drawing.Size(227, 24)
        Me.textemailid.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(40, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Enter Password    : "
        '
        'textentpass
        '
        Me.textentpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.textentpass.Location = New System.Drawing.Point(321, 399)
        Me.textentpass.MaxLength = 10
        Me.textentpass.Name = "textentpass"
        Me.textentpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textentpass.Size = New System.Drawing.Size(227, 24)
        Me.textentpass.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(25, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Confirm Password  : "
        '
        'textconfpass
        '
        Me.textconfpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.textconfpass.Location = New System.Drawing.Point(321, 470)
        Me.textconfpass.MaxLength = 10
        Me.textconfpass.Name = "textconfpass"
        Me.textconfpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textconfpass.Size = New System.Drawing.Size(226, 24)
        Me.textconfpass.TabIndex = 10
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnsubmit.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnsubmit.Location = New System.Drawing.Point(45, 578)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(280, 57)
        Me.btnsubmit.TabIndex = 11
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btncancel.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Location = New System.Drawing.Point(340, 578)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(280, 57)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Delete"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'textstudname
        '
        Me.textstudname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.textstudname.Location = New System.Drawing.Point(321, 189)
        Me.textstudname.MaxLength = 30
        Me.textstudname.Name = "textstudname"
        Me.textstudname.Size = New System.Drawing.Size(227, 24)
        Me.textstudname.TabIndex = 13
        '
        'tb_Student_id
        '
        Me.tb_Student_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.tb_Student_id.Location = New System.Drawing.Point(319, 118)
        Me.tb_Student_id.MaxLength = 30
        Me.tb_Student_id.Name = "tb_Student_id"
        Me.tb_Student_id.Size = New System.Drawing.Size(116, 24)
        Me.tb_Student_id.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(56, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 26)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Student ID          : "
        '
        'dgv_Student_Registration
        '
        Me.dgv_Student_Registration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Student_Registration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Student_Registration.Location = New System.Drawing.Point(648, 194)
        Me.dgv_Student_Registration.Name = "dgv_Student_Registration"
        Me.dgv_Student_Registration.Size = New System.Drawing.Size(685, 401)
        Me.dgv_Student_Registration.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(643, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 26)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Registred Students"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 64)
        Me.Panel1.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(558, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(328, 40)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Student Registartion"
        '
        'student_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_Student_Registration)
        Me.Controls.Add(Me.tb_Student_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.textstudname)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.textconfpass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textentpass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textemailid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textmobno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "student_registration"
        Me.Text = "Training and Placement System"
        CType(Me.dgv_Student_Registration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textmobno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textemailid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textentpass As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents textconfpass As System.Windows.Forms.TextBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents textstudname As System.Windows.Forms.TextBox
    Friend WithEvents tb_Student_id As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv_Student_Registration As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
