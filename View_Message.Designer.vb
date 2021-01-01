<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Message
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
        Me.dgv_MSG_BOX = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Name = New System.Windows.Forms.TextBox()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.tb_msg = New System.Windows.Forms.TextBox()
        CType(Me.dgv_MSG_BOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_MSG_BOX
        '
        Me.dgv_MSG_BOX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_MSG_BOX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_MSG_BOX.Location = New System.Drawing.Point(609, 136)
        Me.dgv_MSG_BOX.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_MSG_BOX.Name = "dgv_MSG_BOX"
        Me.dgv_MSG_BOX.Size = New System.Drawing.Size(759, 423)
        Me.dgv_MSG_BOX.TabIndex = 64
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1440, 111)
        Me.Panel1.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(616, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 45)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Message BOX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Name :"
        '
        'tb_Name
        '
        Me.tb_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Name.Location = New System.Drawing.Point(127, 170)
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.Size = New System.Drawing.Size(256, 28)
        Me.tb_Name.TabIndex = 67
        '
        'btn_read
        '
        Me.btn_read.BackColor = System.Drawing.Color.Indigo
        Me.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_read.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_read.Location = New System.Drawing.Point(178, 216)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(124, 46)
        Me.btn_read.TabIndex = 68
        Me.btn_read.Text = "Read"
        Me.btn_read.UseVisualStyleBackColor = False
        '
        'tb_msg
        '
        Me.tb_msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_msg.Location = New System.Drawing.Point(12, 280)
        Me.tb_msg.Multiline = True
        Me.tb_msg.Name = "tb_msg"
        Me.tb_msg.Size = New System.Drawing.Size(479, 234)
        Me.tb_msg.TabIndex = 69
        '
        'View_Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 708)
        Me.Controls.Add(Me.tb_msg)
        Me.Controls.Add(Me.btn_read)
        Me.Controls.Add(Me.tb_Name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_MSG_BOX)
        Me.Name = "View_Message"
        Me.Text = "View_Message"
        CType(Me.dgv_MSG_BOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_MSG_BOX As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_Name As System.Windows.Forms.TextBox
    Friend WithEvents btn_read As System.Windows.Forms.Button
    Friend WithEvents tb_msg As System.Windows.Forms.TextBox
End Class
