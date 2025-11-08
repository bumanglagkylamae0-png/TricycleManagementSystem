Public Class frmAdminDashboard

    ' --- This is our helper function to load forms into the pnlMain ---
    Private currentForm As Form = Nothing ' Keeps track of the currently open form

    Private Sub LoadFormIntoPanel(frm As Form)
        ' If a form is already open, close it
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If

        ' Set the new form as the current one
        currentForm = frm

        ' --- These are the magic properties ---
        frm.TopLevel = False ' Important: Tells .NET this is not a top-level window
        frm.FormBorderStyle = FormBorderStyle.None ' Remove its own borders
        frm.Dock = DockStyle.Fill ' Make it fill our panel
        ' --------------------------------------

        ' Add the form to the panel's controls and show it
        pnlMain.Controls.Add(frm)
        pnlMain.Tag = frm
        frm.BringToFront()
        frm.Show()
    End Sub

    ' --- Load the "Register" form ---
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        LoadFormIntoPanel(New frmRegisterDriver())
    End Sub

    ' --- Load the "View/Search" form ---
    Private Sub btnViewDrivers_Click(sender As Object, e As EventArgs) Handles btnViewDrivers.Click
        LoadFormIntoPanel(New frmViewDrivers())
    End Sub

    ' --- Load the "Manage Admins" form ---
    Private Sub btnManageAdmins_Click(sender As Object, e As EventArgs) Handles btnManageAdmins.Click
        LoadFormIntoPanel(New frmManageAdmins())
    End Sub

    ' --- LOGOUT ---
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Ask for confirmation
        Dim confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            ' Find the login form (which we just hid) and show it again
            Application.OpenForms("frmLogin").Show()

            ' Close this dashboard
            Me.Close()
        End If
    End Sub

End Class