<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageAdmins
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        dgvAdmins = New DataGridView()
        Label1 = New Label()
        Panel2 = New Panel()
        btnCreateAdmin = New Button()
        txtConfirmPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtNewUsername = New TextBox()
        txtNewFullname = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvAdmins, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dgvAdmins)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(394, 444)
        Panel1.TabIndex = 0
        ' 
        ' dgvAdmins
        ' 
        dgvAdmins.AllowUserToAddRows = False
        dgvAdmins.AllowUserToDeleteRows = False
        dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAdmins.BackgroundColor = Color.White
        dgvAdmins.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(250))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAdmins.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvAdmins.DefaultCellStyle = DataGridViewCellStyle2
        dgvAdmins.Dock = DockStyle.Fill
        dgvAdmins.Location = New Point(0, 25)
        dgvAdmins.Name = "dgvAdmins"
        dgvAdmins.ReadOnly = True
        dgvAdmins.RowHeadersVisible = False
        dgvAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAdmins.Size = New Size(394, 419)
        dgvAdmins.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 25)
        Label1.TabIndex = 0
        Label1.Text = "Current Admin Users"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(250))
        Panel2.Controls.Add(btnCreateAdmin)
        Panel2.Controls.Add(txtConfirmPassword)
        Panel2.Controls.Add(txtNewPassword)
        Panel2.Controls.Add(txtNewUsername)
        Panel2.Controls.Add(txtNewFullname)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(403, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(394, 444)
        Panel2.TabIndex = 1
        ' 
        ' btnCreateAdmin
        ' 
        btnCreateAdmin.BackColor = Color.DodgerBlue
        btnCreateAdmin.FlatStyle = FlatStyle.Flat
        btnCreateAdmin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateAdmin.ForeColor = Color.White
        btnCreateAdmin.Location = New Point(94, 386)
        btnCreateAdmin.Name = "btnCreateAdmin"
        btnCreateAdmin.Size = New Size(211, 40)
        btnCreateAdmin.TabIndex = 9
        btnCreateAdmin.Text = "CREATE ACCOUNT"
        btnCreateAdmin.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 12F)
        txtConfirmPassword.Location = New Point(90, 334)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(274, 29)
        txtConfirmPassword.TabIndex = 8
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Segoe UI", 12F)
        txtNewPassword.Location = New Point(90, 251)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(274, 29)
        txtNewPassword.TabIndex = 7
        txtNewPassword.UseSystemPasswordChar = True
        ' 
        ' txtNewUsername
        ' 
        txtNewUsername.Font = New Font("Segoe UI", 12F)
        txtNewUsername.Location = New Point(94, 163)
        txtNewUsername.Name = "txtNewUsername"
        txtNewUsername.Size = New Size(270, 29)
        txtNewUsername.TabIndex = 6
        ' 
        ' txtNewFullname
        ' 
        txtNewFullname.Font = New Font("Segoe UI", 12F)
        txtNewFullname.Location = New Point(90, 89)
        txtNewFullname.Name = "txtNewFullname"
        txtNewFullname.Size = New Size(274, 29)
        txtNewFullname.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(13, 298)
        Label6.Name = "Label6"
        Label6.Size = New Size(218, 21)
        Label6.TabIndex = 4
        Label6.Text = "Confirm Temporary Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(13, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 21)
        Label5.TabIndex = 3
        Label5.Text = "Temporary Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(13, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 21)
        Label4.TabIndex = 2
        Label4.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(13, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 21)
        Label3.TabIndex = 1
        Label3.Text = "Full Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 25)
        Label2.TabIndex = 0
        Label2.Text = "CREATE NEW ADMIN ACCOUNT"
        ' 
        ' frmManageAdmins
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmManageAdmins"
        Text = "frmManageAdmins"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvAdmins, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvAdmins As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents txtNewFullname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateAdmin As Button
End Class
