<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriverDashboard
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
        pnlHeader = New Panel()
        btnLogout = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        txtDateRegistered = New TextBox()
        txtLicense = New TextBox()
        txtOrCr = New TextBox()
        txtPlateNo = New TextBox()
        txtContact = New TextBox()
        txtAddress = New TextBox()
        txtFullname = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        pnlHeader.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.MediumSeaGreen
        pnlHeader.Controls.Add(btnLogout)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(800, 62)
        pnlHeader.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Right
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(725, 0)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 62)
        btnLogout.TabIndex = 1
        btnLogout.Text = "EXIT"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 30)
        Label1.TabIndex = 0
        Label1.Text = "MY DRIVER INFORMATION"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(txtDateRegistered)
        Panel1.Controls.Add(txtLicense)
        Panel1.Controls.Add(txtOrCr)
        Panel1.Controls.Add(txtPlateNo)
        Panel1.Controls.Add(txtContact)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(txtFullname)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(131, 91)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(571, 332)
        Panel1.TabIndex = 1
        ' 
        ' txtDateRegistered
        ' 
        txtDateRegistered.BorderStyle = BorderStyle.FixedSingle
        txtDateRegistered.Font = New Font("Segoe UI", 10F)
        txtDateRegistered.Location = New Point(158, 254)
        txtDateRegistered.Name = "txtDateRegistered"
        txtDateRegistered.ReadOnly = True
        txtDateRegistered.Size = New Size(244, 25)
        txtDateRegistered.TabIndex = 13
        ' 
        ' txtLicense
        ' 
        txtLicense.BorderStyle = BorderStyle.FixedSingle
        txtLicense.Font = New Font("Segoe UI", 10F)
        txtLicense.Location = New Point(117, 224)
        txtLicense.Name = "txtLicense"
        txtLicense.ReadOnly = True
        txtLicense.Size = New Size(285, 25)
        txtLicense.TabIndex = 12
        ' 
        ' txtOrCr
        ' 
        txtOrCr.BorderStyle = BorderStyle.FixedSingle
        txtOrCr.Font = New Font("Segoe UI", 10F)
        txtOrCr.Location = New Point(136, 195)
        txtOrCr.Name = "txtOrCr"
        txtOrCr.ReadOnly = True
        txtOrCr.Size = New Size(266, 25)
        txtOrCr.TabIndex = 11
        ' 
        ' txtPlateNo
        ' 
        txtPlateNo.BorderStyle = BorderStyle.FixedSingle
        txtPlateNo.Font = New Font("Segoe UI", 10F)
        txtPlateNo.Location = New Point(136, 142)
        txtPlateNo.Name = "txtPlateNo"
        txtPlateNo.ReadOnly = True
        txtPlateNo.Size = New Size(266, 25)
        txtPlateNo.TabIndex = 10
        ' 
        ' txtContact
        ' 
        txtContact.BorderStyle = BorderStyle.FixedSingle
        txtContact.Font = New Font("Segoe UI", 10F)
        txtContact.Location = New Point(117, 107)
        txtContact.Name = "txtContact"
        txtContact.ReadOnly = True
        txtContact.Size = New Size(285, 25)
        txtContact.TabIndex = 9
        ' 
        ' txtAddress
        ' 
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 10F)
        txtAddress.Location = New Point(117, 67)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(285, 34)
        txtAddress.TabIndex = 8
        ' 
        ' txtFullname
        ' 
        txtFullname.BorderStyle = BorderStyle.FixedSingle
        txtFullname.Font = New Font("Segoe UI", 10F)
        txtFullname.Location = New Point(117, 32)
        txtFullname.Name = "txtFullname"
        txtFullname.ReadOnly = True
        txtFullname.Size = New Size(285, 25)
        txtFullname.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(39, 254)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 19)
        Label8.TabIndex = 6
        Label8.Text = "Date Registered: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(39, 222)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 19)
        Label7.TabIndex = 5
        Label7.Text = "License:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(34, 173)
        Label6.Name = "Label6"
        Label6.Size = New Size(317, 19)
        Label6.TabIndex = 4
        Label6.Text = "Official Receipt (OR) and Certificate of Registration:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(34, 143)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 19)
        Label5.TabIndex = 3
        Label5.Text = "Plate Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(34, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 19)
        Label4.TabIndex = 2
        Label4.Text = "Contact: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(34, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 19)
        Label3.TabIndex = 1
        Label3.Text = "Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(34, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 19)
        Label2.TabIndex = 0
        Label2.Text = "Full Name: "
        ' 
        ' frmDriverDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDriverDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REGISTERED DRIVER"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDateRegistered As TextBox
    Friend WithEvents txtLicense As TextBox
    Friend WithEvents txtOrCr As TextBox
    Friend WithEvents txtPlateNo As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFullname As TextBox
End Class
