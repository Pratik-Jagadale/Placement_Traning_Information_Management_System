<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_details
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
        Dim btnsubmit As System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textstudname = New System.Windows.Forms.TextBox()
        Me.dtp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.rb_Male = New System.Windows.Forms.RadioButton()
        Me.rb_Female = New System.Windows.Forms.RadioButton()
        Me.rb_Other = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textmobno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textssc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texthsc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textpassyear = New System.Windows.Forms.TextBox()
        Me.textpassyear2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textgrad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.textpassyear3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textgradcoll = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.textbranch = New System.Windows.Forms.ComboBox()
        Me.tb_Student_id = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        btnsubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsubmit
        '
        btnsubmit.BackColor = System.Drawing.Color.MediumSeaGreen
        btnsubmit.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        btnsubmit.Location = New System.Drawing.Point(293, 617)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New System.Drawing.Size(280, 57)
        btnsubmit.TabIndex = 26
        btnsubmit.Text = "SUBMIT"
        btnsubmit.UseVisualStyleBackColor = False
        AddHandler btnsubmit.Click, AddressOf Me.Button1_Click
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(53, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Name   :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(749, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date of Birth     :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(750, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender             :"
        '
        'textstudname
        '
        Me.textstudname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textstudname.Location = New System.Drawing.Point(311, 178)
        Me.textstudname.Name = "textstudname"
        Me.textstudname.Size = New System.Drawing.Size(198, 24)
        Me.textstudname.TabIndex = 4
        '
        'dtp_DOB
        '
        Me.dtp_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_DOB.Location = New System.Drawing.Point(999, 119)
        Me.dtp_DOB.Name = "dtp_DOB"
        Me.dtp_DOB.Size = New System.Drawing.Size(141, 26)
        Me.dtp_DOB.TabIndex = 5
        Me.dtp_DOB.Value = New Date(2019, 12, 26, 19, 7, 32, 0)
        '
        'rb_Male
        '
        Me.rb_Male.AutoSize = True
        Me.rb_Male.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Male.Location = New System.Drawing.Point(999, 209)
        Me.rb_Male.Name = "rb_Male"
        Me.rb_Male.Size = New System.Drawing.Size(58, 22)
        Me.rb_Male.TabIndex = 6
        Me.rb_Male.TabStop = True
        Me.rb_Male.Text = "Male"
        Me.rb_Male.UseVisualStyleBackColor = True
        '
        'rb_Female
        '
        Me.rb_Female.AutoSize = True
        Me.rb_Female.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Female.Location = New System.Drawing.Point(1074, 209)
        Me.rb_Female.Name = "rb_Female"
        Me.rb_Female.Size = New System.Drawing.Size(75, 22)
        Me.rb_Female.TabIndex = 7
        Me.rb_Female.TabStop = True
        Me.rb_Female.Text = "Female"
        Me.rb_Female.UseVisualStyleBackColor = True
        '
        'rb_Other
        '
        Me.rb_Other.AutoSize = True
        Me.rb_Other.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Other.Location = New System.Drawing.Point(1155, 209)
        Me.rb_Other.Name = "rb_Other"
        Me.rb_Other.Size = New System.Drawing.Size(63, 22)
        Me.rb_Other.TabIndex = 8
        Me.rb_Other.TabStop = True
        Me.rb_Other.Text = "Other"
        Me.rb_Other.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(59, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Mobile No        :"
        '
        'textmobno
        '
        Me.textmobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textmobno.Location = New System.Drawing.Point(310, 257)
        Me.textmobno.Name = "textmobno"
        Me.textmobno.Size = New System.Drawing.Size(198, 24)
        Me.textmobno.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(553, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(450, 26)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "---------- Enter Educational Details ----------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(252, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "SSC (%)          :"
        '
        'textssc
        '
        Me.textssc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textssc.Location = New System.Drawing.Point(542, 372)
        Me.textssc.Name = "textssc"
        Me.textssc.Size = New System.Drawing.Size(72, 24)
        Me.textssc.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(251, 412)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 26)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "HSC (%)          :"
        '
        'texthsc
        '
        Me.texthsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texthsc.Location = New System.Drawing.Point(542, 413)
        Me.texthsc.Name = "texthsc"
        Me.texthsc.Size = New System.Drawing.Size(72, 24)
        Me.texthsc.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(840, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 26)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Passout Year  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(840, 412)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 26)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Passout Year  :"
        '
        'textpassyear
        '
        Me.textpassyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textpassyear.Location = New System.Drawing.Point(1146, 372)
        Me.textpassyear.Name = "textpassyear"
        Me.textpassyear.Size = New System.Drawing.Size(72, 24)
        Me.textpassyear.TabIndex = 18
        '
        'textpassyear2
        '
        Me.textpassyear2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textpassyear2.Location = New System.Drawing.Point(1146, 411)
        Me.textpassyear2.Name = "textpassyear2"
        Me.textpassyear2.Size = New System.Drawing.Size(72, 24)
        Me.textpassyear2.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(252, 455)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 26)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Graduation       :"
        '
        'textgrad
        '
        Me.textgrad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textgrad.Location = New System.Drawing.Point(544, 452)
        Me.textgrad.Name = "textgrad"
        Me.textgrad.Size = New System.Drawing.Size(72, 24)
        Me.textgrad.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(840, 453)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 26)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Passout Year  :"
        '
        'textpassyear3
        '
        Me.textpassyear3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textpassyear3.Location = New System.Drawing.Point(1146, 452)
        Me.textpassyear3.Name = "textpassyear3"
        Me.textpassyear3.Size = New System.Drawing.Size(72, 24)
        Me.textpassyear3.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(483, 511)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(228, 26)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Graduation College :"
        '
        'textgradcoll
        '
        Me.textgradcoll.Location = New System.Drawing.Point(729, 518)
        Me.textgradcoll.Name = "textgradcoll"
        Me.textgradcoll.Size = New System.Drawing.Size(256, 20)
        Me.textgradcoll.TabIndex = 25
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btncancel.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancel.Location = New System.Drawing.Point(927, 617)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(280, 57)
        Me.btncancel.TabIndex = 27
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnreset.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreset.Location = New System.Drawing.Point(610, 617)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(280, 57)
        Me.btnreset.TabIndex = 28
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(483, 551)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(210, 26)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Branch                   :"
        '
        'textbranch
        '
        Me.textbranch.FormattingEnabled = True
        Me.textbranch.Items.AddRange(New Object() {"--- Select Options ---", "Computer Science", "Information Technology", "B. Com IT"})
        Me.textbranch.Location = New System.Drawing.Point(729, 558)
        Me.textbranch.Name = "textbranch"
        Me.textbranch.Size = New System.Drawing.Size(158, 21)
        Me.textbranch.TabIndex = 30
        '
        'tb_Student_id
        '
        Me.tb_Student_id.Enabled = False
        Me.tb_Student_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Student_id.Location = New System.Drawing.Point(311, 105)
        Me.tb_Student_id.MaxLength = 30
        Me.tb_Student_id.Name = "tb_Student_id"
        Me.tb_Student_id.Size = New System.Drawing.Size(122, 24)
        Me.tb_Student_id.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(53, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(185, 26)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Student ID        : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 64)
        Me.Panel1.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(551, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(343, 40)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Student Other Details"
        '
        'student_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tb_Student_id)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.textbranch)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(btnsubmit)
        Me.Controls.Add(Me.textgradcoll)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.textpassyear3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.textgrad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.textpassyear2)
        Me.Controls.Add(Me.textpassyear)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.texthsc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.textssc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textmobno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rb_Other)
        Me.Controls.Add(Me.rb_Female)
        Me.Controls.Add(Me.rb_Male)
        Me.Controls.Add(Me.dtp_DOB)
        Me.Controls.Add(Me.textstudname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "student_details"
        Me.Text = "Training and Placement System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textstudname As System.Windows.Forms.TextBox
    Friend WithEvents dtp_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents rb_Male As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Female As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Other As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textmobno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents textssc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents texthsc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents textpassyear As System.Windows.Forms.TextBox
    Friend WithEvents textpassyear2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents textgrad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents textpassyear3 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents textgradcoll As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents textbranch As System.Windows.Forms.ComboBox
    Friend WithEvents tb_Student_id As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
