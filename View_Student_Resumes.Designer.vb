<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Student_Resumes
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
        Me.btn_Search_View_purchase_Details = New System.Windows.Forms.Button()
        Me.cb_Product_Name_View_purchase_Details = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgv_View_Student_Details = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgv_View_Student_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Search_View_purchase_Details
        '
        Me.btn_Search_View_purchase_Details.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btn_Search_View_purchase_Details.FlatAppearance.BorderSize = 0
        Me.btn_Search_View_purchase_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search_View_purchase_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search_View_purchase_Details.ForeColor = System.Drawing.Color.GhostWhite
        Me.btn_Search_View_purchase_Details.Location = New System.Drawing.Point(1101, 171)
        Me.btn_Search_View_purchase_Details.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Search_View_purchase_Details.Name = "btn_Search_View_purchase_Details"
        Me.btn_Search_View_purchase_Details.Size = New System.Drawing.Size(300, 42)
        Me.btn_Search_View_purchase_Details.TabIndex = 66
        Me.btn_Search_View_purchase_Details.Text = "Send CALL Letter"
        Me.btn_Search_View_purchase_Details.UseVisualStyleBackColor = False
        '
        'cb_Product_Name_View_purchase_Details
        '
        Me.cb_Product_Name_View_purchase_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Product_Name_View_purchase_Details.FormattingEnabled = True
        Me.cb_Product_Name_View_purchase_Details.Location = New System.Drawing.Point(810, 176)
        Me.cb_Product_Name_View_purchase_Details.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_Product_Name_View_purchase_Details.Name = "cb_Product_Name_View_purchase_Details"
        Me.cb_Product_Name_View_purchase_Details.Size = New System.Drawing.Size(247, 30)
        Me.cb_Product_Name_View_purchase_Details.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Indigo
        Me.Label14.Location = New System.Drawing.Point(553, 175)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(225, 32)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Student Name :"
        '
        'dgv_View_Student_Details
        '
        Me.dgv_View_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_View_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_View_Student_Details.Location = New System.Drawing.Point(73, 289)
        Me.dgv_View_Student_Details.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_View_Student_Details.Name = "dgv_View_Student_Details"
        Me.dgv_View_Student_Details.Size = New System.Drawing.Size(1507, 587)
        Me.dgv_View_Student_Details.TabIndex = 63
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(657, 528)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(729, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(374, 45)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "View Student Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1800, 111)
        Me.Panel1.TabIndex = 61
        '
        'View_Student_Resumes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.btn_Search_View_purchase_Details)
        Me.Controls.Add(Me.cb_Product_Name_View_purchase_Details)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dgv_View_Student_Details)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "View_Student_Resumes"
        Me.Text = "View_Student_Resumes"
        CType(Me.dgv_View_Student_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Search_View_purchase_Details As System.Windows.Forms.Button
    Friend WithEvents cb_Product_Name_View_purchase_Details As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dgv_View_Student_Details As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
