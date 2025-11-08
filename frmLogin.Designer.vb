<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        btnCloseApp = New Button()
        TabControl2 = New TabControl()
        TabPage1 = New TabPage()
        btnAdminLogin = New Button()
        txtAdminPass = New TextBox()
        Label3 = New Label()
        txtAdminUser = New TextBox()
        Label2 = New Label()
        TabPage2 = New TabPage()
        btnVerifyDriver = New Button()
        txtPlateNumber = New TextBox()
        Label4 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TabControl2.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 0)
        TableLayoutPanel1.Location = New Point(-1, -2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(801, 453)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(394, 447)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(379, 45)
        Label1.TabIndex = 0
        Label1.Text = "Tricycle Registry System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnCloseApp)
        Panel2.Controls.Add(TabControl2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(403, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(395, 447)
        Panel2.TabIndex = 1
        ' 
        ' btnCloseApp
        ' 
        btnCloseApp.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCloseApp.FlatStyle = FlatStyle.Flat
        btnCloseApp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCloseApp.ForeColor = Color.Gray
        btnCloseApp.Location = New Point(363, 0)
        btnCloseApp.Name = "btnCloseApp"
        btnCloseApp.Size = New Size(32, 45)
        btnCloseApp.TabIndex = 1
        btnCloseApp.Text = "X"
        btnCloseApp.UseVisualStyleBackColor = True
        ' 
        ' TabControl2
        ' 
        TabControl2.Anchor = AnchorStyles.None
        TabControl2.Appearance = TabAppearance.FlatButtons
        TabControl2.Controls.Add(TabPage1)
        TabControl2.Controls.Add(TabPage2)
        TabControl2.Font = New Font("Segoe UI", 12F)
        TabControl2.ItemSize = New Size(220, 40)
        TabControl2.Location = New Point(3, 59)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(389, 350)
        TabControl2.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnAdminLogin)
        TabPage1.Controls.Add(txtAdminPass)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(txtAdminUser)
        TabPage1.Controls.Add(Label2)
        TabPage1.Location = New Point(4, 44)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(381, 302)
        TabPage1.TabIndex = 0
        TabPage1.Text = "ADMIN LOGIN"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnAdminLogin
        ' 
        btnAdminLogin.BackColor = Color.DodgerBlue
        btnAdminLogin.FlatStyle = FlatStyle.Flat
        btnAdminLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdminLogin.ForeColor = Color.White
        btnAdminLogin.Location = New Point(165, 202)
        btnAdminLogin.Name = "btnAdminLogin"
        btnAdminLogin.Size = New Size(119, 44)
        btnAdminLogin.TabIndex = 4
        btnAdminLogin.Text = "LOGIN"
        btnAdminLogin.UseVisualStyleBackColor = False
        ' 
        ' txtAdminPass
        ' 
        txtAdminPass.Font = New Font("Segoe UI", 14F)
        txtAdminPass.Location = New Point(124, 126)
        txtAdminPass.Name = "txtAdminPass"
        txtAdminPass.Size = New Size(202, 32)
        txtAdminPass.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(34, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 19)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD:"
        ' 
        ' txtAdminUser
        ' 
        txtAdminUser.Font = New Font("Segoe UI", 14F)
        txtAdminUser.Location = New Point(124, 77)
        txtAdminUser.Name = "txtAdminUser"
        txtAdminUser.Size = New Size(202, 32)
        txtAdminUser.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(35, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 19)
        Label2.TabIndex = 0
        Label2.Text = "USERNAME:"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnVerifyDriver)
        TabPage2.Controls.Add(txtPlateNumber)
        TabPage2.Controls.Add(Label4)
        TabPage2.Font = New Font("Segoe UI", 10F)
        TabPage2.Location = New Point(4, 44)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(381, 302)
        TabPage2.TabIndex = 1
        TabPage2.Text = "DRIVER VERIFICATION"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnVerifyDriver
        ' 
        btnVerifyDriver.BackColor = Color.MediumSeaGreen
        btnVerifyDriver.FlatStyle = FlatStyle.Flat
        btnVerifyDriver.Font = New Font("Segoe UI", 12F)
        btnVerifyDriver.ForeColor = Color.White
        btnVerifyDriver.Location = New Point(86, 187)
        btnVerifyDriver.Name = "btnVerifyDriver"
        btnVerifyDriver.Size = New Size(204, 31)
        btnVerifyDriver.TabIndex = 2
        btnVerifyDriver.Text = "VERIFY PLATE NUMBER"
        btnVerifyDriver.UseVisualStyleBackColor = False
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.Font = New Font("Segoe UI", 14F)
        txtPlateNumber.Location = New Point(55, 112)
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.Size = New Size(266, 32)
        txtPlateNumber.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(86, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(192, 19)
        Label4.TabIndex = 0
        Label4.Text = "ENTER YOUR PLATE NUMBER:"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        TabControl2.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAdminPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdminUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents btnVerifyDriver As Button
    Friend WithEvents txtPlateNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCloseApp As Button

End Class
