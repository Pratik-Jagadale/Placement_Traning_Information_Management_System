<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Add_Trainning
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_End_Date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_start_date = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_post = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_Trainner = New System.Windows.Forms.TextBox()
        Me.btn_Cancle = New System.Windows.Forms.Button()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 64)
        Me.Panel1.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(565, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(265, 40)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Add Trainning  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(780, 497)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 26)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "To"
        '
        'dtp_End_Date
        '
        Me.dtp_End_Date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_End_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_End_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_End_Date.Location = New System.Drawing.Point(727, 551)
        Me.dtp_End_Date.Name = "dtp_End_Date"
        Me.dtp_End_Date.Size = New System.Drawing.Size(150, 31)
        Me.dtp_End_Date.TabIndex = 51
        '
        'dtp_start_date
        '
        Me.dtp_start_date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_start_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_start_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_start_date.Location = New System.Drawing.Point(727, 423)
        Me.dtp_start_date.Name = "dtp_start_date"
        Me.dtp_start_date.Size = New System.Drawing.Size(150, 31)
        Me.dtp_start_date.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(401, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 26)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Tranning Date       :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(435, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 26)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Post                    :"
        '
        'cb_post
        '
        Me.cb_post.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cb_post.FormattingEnabled = True
        Me.cb_post.Location = New System.Drawing.Point(718, 216)
        Me.cb_post.Name = "cb_post"
        Me.cb_post.Size = New System.Drawing.Size(174, 26)
        Me.cb_post.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(425, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 26)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Trainner               :"
        '
        'text_Trainner
        '
        Me.text_Trainner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_Trainner.Location = New System.Drawing.Point(718, 315)
        Me.text_Trainner.Name = "text_Trainner"
        Me.text_Trainner.Size = New System.Drawing.Size(204, 22)
        Me.text_Trainner.TabIndex = 55
        '
        'btn_Cancle
        '
        Me.btn_Cancle.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Cancle.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancle.Location = New System.Drawing.Point(735, 630)
        Me.btn_Cancle.Name = "btn_Cancle"
        Me.btn_Cancle.Size = New System.Drawing.Size(280, 57)
        Me.btn_Cancle.TabIndex = 57
        Me.btn_Cancle.Text = "CANCEL"
        Me.btn_Cancle.UseVisualStyleBackColor = False
        '
        'btn_Submit
        '
        Me.btn_Submit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Submit.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btn_Submit.Location = New System.Drawing.Point(430, 630)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(280, 57)
        Me.btn_Submit.TabIndex = 56
        Me.btn_Submit.Text = "SUBMIT"
        Me.btn_Submit.UseVisualStyleBackColor = False
        '
        'frm_Add_Trainning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btn_Cancle)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.text_Trainner)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_post)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_End_Date)
        Me.Controls.Add(Me.dtp_start_date)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_Add_Trainning"
        Me.Text = "frm_Add_Trainning"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_End_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_start_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_post As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents text_Trainner As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancle As System.Windows.Forms.Button
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
End Class
