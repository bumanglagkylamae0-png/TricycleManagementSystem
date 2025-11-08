<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminDashboard
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
        pnlNav = New Panel()
        pnlMain = New Panel()
        btnRegister = New Button()
        btnViewDrivers = New Button()
        btnManageAdmins = New Button()
        btnLogout = New Button()
        pnlNav.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlNav
        ' 
        pnlNav.BackColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        pnlNav.Controls.Add(btnLogout)
        pnlNav.Controls.Add(btnManageAdmins)
        pnlNav.Controls.Add(btnViewDrivers)
        pnlNav.Controls.Add(btnRegister)
        pnlNav.Dock = DockStyle.Left
        pnlNav.Location = New Point(0, 0)
        pnlNav.Name = "pnlNav"
        pnlNav.Size = New Size(222, 450)
        pnlNav.TabIndex = 0
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.White
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(222, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(578, 450)
        pnlMain.TabIndex = 1
        ' 
        ' btnRegister
        ' 
        btnRegister.Dock = DockStyle.Top
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(0, 0)
        btnRegister.Name = "btnRegister"
        btnRegister.Padding = New Padding(20, 0, 0, 0)
        btnRegister.Size = New Size(222, 48)
        btnRegister.TabIndex = 0
        btnRegister.Text = "REGISTER DRIVER"
        btnRegister.TextAlign = ContentAlignment.MiddleLeft
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnViewDrivers
        ' 
        btnViewDrivers.Dock = DockStyle.Top
        btnViewDrivers.FlatStyle = FlatStyle.Flat
        btnViewDrivers.Font = New Font("Segoe UI", 12F)
        btnViewDrivers.ForeColor = Color.White
        btnViewDrivers.Location = New Point(0, 48)
        btnViewDrivers.Name = "btnViewDrivers"
        btnViewDrivers.Padding = New Padding(20, 0, 0, 0)
        btnViewDrivers.Size = New Size(222, 48)
        btnViewDrivers.TabIndex = 1
        btnViewDrivers.Text = "VIEW/SEARCH DRIVERS"
        btnViewDrivers.TextAlign = ContentAlignment.MiddleLeft
        btnViewDrivers.UseVisualStyleBackColor = True
        ' 
        ' btnManageAdmins
        ' 
        btnManageAdmins.Dock = DockStyle.Top
        btnManageAdmins.FlatStyle = FlatStyle.Flat
        btnManageAdmins.Font = New Font("Segoe UI", 12F)
        btnManageAdmins.ForeColor = Color.White
        btnManageAdmins.Location = New Point(0, 96)
        btnManageAdmins.Name = "btnManageAdmins"
        btnManageAdmins.Padding = New Padding(20, 0, 0, 0)
        btnManageAdmins.Size = New Size(222, 48)
        btnManageAdmins.TabIndex = 2
        btnManageAdmins.Text = "MANAGE ADMINS"
        btnManageAdmins.TextAlign = ContentAlignment.MiddleLeft
        btnManageAdmins.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(0, 427)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(222, 23)
        btnLogout.TabIndex = 3
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' frmAdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(250))
        ClientSize = New Size(800, 450)
        Controls.Add(pnlMain)
        Controls.Add(pnlNav)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAdminDashboard"
        WindowState = FormWindowState.Maximized
        pnlNav.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlNav As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnManageAdmins As Button
    Friend WithEvents btnViewDrivers As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogout As Button
End Class
