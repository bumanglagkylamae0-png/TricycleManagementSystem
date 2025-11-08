<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewDrivers
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        txtSearch = New TextBox()
        btnSearch = New Button()
        dgvDrivers = New DataGridView()
        pnlEdit = New Panel()
        lblSelectedDriverID = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Me.txtEditFullname = New TextBox()
        Me.txtEditAddress = New TextBox()
        Me.txtEditContact = New TextBox()
        Me.txtEditPlateNo = New TextBox()
        Me.txtEditOrCr = New TextBox()
        txtEditLicense = New TextBox()
        btnUpdate = New Button()
        Me.btnDelete = New Button()
        Me.btnClear = New Button()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvDrivers, ComponentModel.ISupportInitialize).BeginInit()
        pnlEdit.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel1.Controls.Add(btnSearch, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(dgvDrivers, 0, 1)
        TableLayoutPanel1.Controls.Add(pnlEdit, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtSearch)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(554, 54)
        Panel1.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Dock = DockStyle.Fill
        txtSearch.Font = New Font("Segoe UI", 12F)
        txtSearch.Location = New Point(0, 0)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(554, 54)
        txtSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.DodgerBlue
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(563, 3)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(234, 54)
        btnSearch.TabIndex = 1
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvDrivers
        ' 
        dgvDrivers.AllowUserToAddRows = False
        dgvDrivers.AllowUserToDeleteRows = False
        dgvDrivers.BorderStyle = BorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(250))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvDrivers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvDrivers.DefaultCellStyle = DataGridViewCellStyle4
        dgvDrivers.Dock = DockStyle.Fill
        dgvDrivers.Location = New Point(3, 63)
        dgvDrivers.Name = "dgvDrivers"
        dgvDrivers.ReadOnly = True
        dgvDrivers.RowHeadersVisible = False
        dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDrivers.Size = New Size(554, 384)
        dgvDrivers.TabIndex = 2
        ' 
        ' pnlEdit
        ' 
        pnlEdit.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(250))
        pnlEdit.Controls.Add(Me.btnClear)
        pnlEdit.Controls.Add(Me.btnDelete)
        pnlEdit.Controls.Add(btnUpdate)
        pnlEdit.Controls.Add(txtEditLicense)
        pnlEdit.Controls.Add(Me.txtEditOrCr)
        pnlEdit.Controls.Add(Me.txtEditPlateNo)
        pnlEdit.Controls.Add(Me.txtEditContact)
        pnlEdit.Controls.Add(Me.txtEditAddress)
        pnlEdit.Controls.Add(Me.txtEditFullname)
        pnlEdit.Controls.Add(Label6)
        pnlEdit.Controls.Add(Label5)
        pnlEdit.Controls.Add(Label4)
        pnlEdit.Controls.Add(Label3)
        pnlEdit.Controls.Add(Label2)
        pnlEdit.Controls.Add(Label1)
        pnlEdit.Controls.Add(lblSelectedDriverID)
        pnlEdit.Dock = DockStyle.Fill
        pnlEdit.Location = New Point(563, 63)
        pnlEdit.Name = "pnlEdit"
        pnlEdit.Size = New Size(234, 384)
        pnlEdit.TabIndex = 3
        ' 
        ' lblSelectedDriverID
        ' 
        lblSelectedDriverID.AutoSize = True
        lblSelectedDriverID.Location = New Point(225, 369)
        lblSelectedDriverID.Name = "lblSelectedDriverID"
        lblSelectedDriverID.Size = New Size(0, 15)
        lblSelectedDriverID.TabIndex = 0
        lblSelectedDriverID.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 1
        Label1.Text = "Full Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 2
        Label2.Text = "Address:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 3
        Label3.Text = "Contact:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 15)
        Label4.TabIndex = 4
        Label4.Text = "Plate Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 5
        Label5.Text = "OR/CR Number:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 229)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 15)
        Label6.TabIndex = 6
        Label6.Text = "License Number"
        ' 
        ' txtEditFullname
        ' 
        Me.txtEditFullname.Location = New Point(12, 27)
        Me.txtEditFullname.Name = "txtEditFullname"
        Me.txtEditFullname.Size = New Size(213, 23)
        Me.txtEditFullname.TabIndex = 8
        ' 
        ' txtEditAddress
        ' 
        Me.txtEditAddress.Location = New Point(12, 71)
        Me.txtEditAddress.Name = "txtEditAddress"
        Me.txtEditAddress.Size = New Size(213, 23)
        Me.txtEditAddress.TabIndex = 9
        ' 
        ' txtEditContact
        ' 
        Me.txtEditContact.Location = New Point(12, 115)
        Me.txtEditContact.Name = "txtEditContact"
        Me.txtEditContact.Size = New Size(213, 23)
        Me.txtEditContact.TabIndex = 10
        ' 
        ' txtEditPlateNo
        ' 
        Me.txtEditPlateNo.Location = New Point(12, 159)
        Me.txtEditPlateNo.Name = "txtEditPlateNo"
        Me.txtEditPlateNo.Size = New Size(213, 23)
        Me.txtEditPlateNo.TabIndex = 11
        ' 
        ' txtEditOrCr
        ' 
        Me.txtEditOrCr.Location = New Point(12, 203)
        Me.txtEditOrCr.Name = "txtEditOrCr"
        Me.txtEditOrCr.Size = New Size(213, 23)
        Me.txtEditOrCr.TabIndex = 12
        ' 
        ' txtEditLicense
        ' 
        txtEditLicense.Location = New Point(12, 247)
        txtEditLicense.Name = "txtEditLicense"
        txtEditLicense.Size = New Size(213, 23)
        txtEditLicense.TabIndex = 13
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Cyan
        btnUpdate.Location = New Point(12, 290)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(93, 32)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        Me.btnDelete.BackColor = Color.Crimson
        Me.btnDelete.Location = New Point(126, 290)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New Size(99, 32)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        Me.btnClear.BackColor = Color.Gray
        Me.btnClear.Location = New Point(48, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New Size(126, 37)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        ' 
        ' frmViewDrivers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmViewDrivers"
        Text = "frmViewDrivers"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvDrivers, ComponentModel.ISupportInitialize).EndInit()
        pnlEdit.ResumeLayout(False)
        pnlEdit.PerformLayout()
        ResumeLayout(False)
    End Sub

    ' --- PASTE THIS NEW BLOCK ---
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvDrivers As DataGridView
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSelectedDriverID As Label
    Friend WithEvents txtEditLicense As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtEditFullname As TextBox
    Friend WithEvents txtEditAddress As TextBox
    Friend WithEvents txtEditContact As TextBox
    Friend WithEvents txtEditPlateNo As TextBox
    Friend WithEvents txtEditOrCr As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
End Class

