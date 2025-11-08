<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestHash
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
        txtPassword = New TextBox()
        btnHash = New Button()
        txtResult = New TextBox()
        SuspendLayout()
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(321, 93)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 0
        ' 
        ' btnHash
        ' 
        btnHash.Location = New Point(331, 147)
        btnHash.Name = "btnHash"
        btnHash.Size = New Size(75, 23)
        btnHash.TabIndex = 1
        btnHash.Text = "GENERATE HASH"
        btnHash.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(321, 215)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(258, 23)
        txtResult.TabIndex = 2
        ' 
        ' frmTestHash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtResult)
        Controls.Add(btnHash)
        Controls.Add(txtPassword)
        Name = "frmTestHash"
        Text = "frmTestHash"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnHash As Button
    Friend WithEvents txtResult As TextBox
End Class
