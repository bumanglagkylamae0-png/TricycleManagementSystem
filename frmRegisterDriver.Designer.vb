<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterDriver
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
        Label1 = New Label()
        pnlContent = New Panel()
        btnSave = New Button()
        dtpDateRegistered = New DateTimePicker()
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
        pnlContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(20, 20, 0, 10)
        Label1.Size = New Size(415, 62)
        Label1.TabIndex = 0
        Label1.Text = "REGISTER NEW TRICYCLE DRIVER"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(btnSave)
        pnlContent.Controls.Add(dtpDateRegistered)
        pnlContent.Controls.Add(txtLicense)
        pnlContent.Controls.Add(txtOrCr)
        pnlContent.Controls.Add(txtPlateNo)
        pnlContent.Controls.Add(txtContact)
        pnlContent.Controls.Add(txtAddress)
        pnlContent.Controls.Add(txtFullname)
        pnlContent.Controls.Add(Label8)
        pnlContent.Controls.Add(Label7)
        pnlContent.Controls.Add(Label6)
        pnlContent.Controls.Add(Label5)
        pnlContent.Controls.Add(Label4)
        pnlContent.Controls.Add(Label3)
        pnlContent.Controls.Add(Label2)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 62)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(30, 10, 30, 10)
        pnlContent.Size = New Size(800, 388)
        pnlContent.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DodgerBlue
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(667, 314)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 45)
        btnSave.TabIndex = 14
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dtpDateRegistered
        ' 
        dtpDateRegistered.Font = New Font("Segoe UI", 12F)
        dtpDateRegistered.Format = DateTimePickerFormat.Short
        dtpDateRegistered.Location = New Point(198, 272)
        dtpDateRegistered.Name = "dtpDateRegistered"
        dtpDateRegistered.Size = New Size(163, 29)
        dtpDateRegistered.TabIndex = 13
        ' 
        ' txtLicense
        ' 
        txtLicense.Font = New Font("Segoe UI", 12F)
        txtLicense.Location = New Point(249, 236)
        txtLicense.Name = "txtLicense"
        txtLicense.Size = New Size(258, 29)
        txtLicense.TabIndex = 12
        ' 
        ' txtOrCr
        ' 
        txtOrCr.Font = New Font("Segoe UI", 12F)
        txtOrCr.Location = New Point(185, 201)
        txtOrCr.Name = "txtOrCr"
        txtOrCr.Size = New Size(322, 29)
        txtOrCr.TabIndex = 11
        ' 
        ' txtPlateNo
        ' 
        txtPlateNo.Font = New Font("Segoe UI", 12F)
        txtPlateNo.Location = New Point(185, 143)
        txtPlateNo.Name = "txtPlateNo"
        txtPlateNo.Size = New Size(322, 29)
        txtPlateNo.TabIndex = 10
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 12F)
        txtContact.Location = New Point(161, 108)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(346, 29)
        txtContact.TabIndex = 9
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Segoe UI", 12F)
        txtAddress.Location = New Point(161, 63)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(346, 42)
        txtAddress.TabIndex = 8
        ' 
        ' txtFullname
        ' 
        txtFullname.Font = New Font("Segoe UI", 12F)
        txtFullname.Location = New Point(161, 24)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(346, 29)
        txtFullname.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(83, 272)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 19)
        Label8.TabIndex = 6
        Label8.Text = "Date Registered:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(83, 242)
        Label7.Name = "Label7"
        Label7.Size = New Size(160, 19)
        Label7.TabIndex = 5
        Label7.Text = "Driver's License Number:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(83, 179)
        Label6.Name = "Label6"
        Label6.Size = New Size(317, 19)
        Label6.TabIndex = 4
        Label6.Text = "Official Receipt (OR) and Certificate of Registration:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(83, 144)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 19)
        Label5.TabIndex = 3
        Label5.Text = "Plate Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(83, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 19)
        Label4.TabIndex = 2
        Label4.Text = "Contact:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(83, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 19)
        Label3.TabIndex = 1
        Label3.Text = "Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(82, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 19)
        Label2.TabIndex = 0
        Label2.Text = "Full Name:"
        ' 
        ' frmRegisterDriver
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(pnlContent)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmRegisterDriver"
        Text = "frmRegisterDriver"
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLicense As TextBox
    Friend WithEvents txtOrCr As TextBox
    Friend WithEvents txtPlateNo As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents dtpDateRegistered As DateTimePicker
    Friend WithEvents btnSave As Button
End Class
