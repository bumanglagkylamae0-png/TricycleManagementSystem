Imports MySql.Data.MySqlClient
Imports bc = BCrypt.Net.BCrypt ' NEW: Alias to match frmLogin

Public Class frmManageAdmins

    ' --- NEW: Local Connection Function ---
    Private Function GetConnection() As MySqlConnection
        Dim cs As String = "Server=localhost;Uid=root;Pwd=;Database=tricycle_db;SslMode=Disabled;"
        Return New MySqlConnection(cs)
    End Function

    ' --- 1. FORM LOAD (No change) ---
    Private Sub frmManageAdmins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllAdmins()
    End Sub

    ' --- 2. LOAD ALL (Updated) ---
    Private Sub LoadAllAdmins()
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT id, fullname, username FROM admin_users ORDER BY fullname"
                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvAdmins.DataSource = dt
                    If dt.Rows.Count > 0 Then
                        dgvAdmins.Columns("id").Visible = False
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading admin users: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 3. CREATE ADMIN BUTTON (Updated) ---
    Private Sub btnCreateAdmin_Click(sender As Object, e As EventArgs) Handles btnCreateAdmin.Click
        Dim fullname = txtNewFullname.Text.Trim()
        Dim username = txtNewUsername.Text.Trim()
        Dim password = txtNewPassword.Text
        Dim confirmPass = txtConfirmPassword.Text

        If String.IsNullOrWhiteSpace(fullname) Or String.IsNullOrWhiteSpace(username) Or
           String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password <> confirmPass Then
            MessageBox.Show("The passwords do not match. Please re-type them.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- UPDATED: Hashing with the 'bc' alias ---
        Dim hashedPassword As String = bc.HashPassword(password)

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "INSERT INTO admin_users (fullname, username, password_hash) VALUES (@fname, @user, @hash)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", fullname)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@hash", hashedPassword)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Admin account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LoadAllAdmins()
                    ClearNewAdminFields()
                End Using
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("This username already exists. Please choose another.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Error creating admin account: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' --- Helper function (No change) ---
    Private Sub ClearNewAdminFields()
        txtNewFullname.Clear()
        txtNewUsername.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub

End Class