Imports MySql.Data.MySqlClient
Imports bc = BCrypt.Net.BCrypt    ' Alias avoids name conflicts

Public Class frmLogin
    ' --- Database Connection Settings ---
    Private ReadOnly DbServer As String = "localhost"
    Private ReadOnly DbUser As String = "root"
    Private ReadOnly DbPassword As String = ""      ' default XAMPP root password is empty
    Private ReadOnly DbName As String = "tricycle_db"

    Private Function GetConnection() As MySqlConnection
        Dim cs As String = $"Server={DbServer};Uid={DbUser};Pwd={DbPassword};Database={DbName};SslMode=Disabled;"
        Return New MySqlConnection(cs)
    End Function

    ' --- ADMIN LOGIN BUTTON (WITH FINAL DIAGNOSTIC TEST) ---
    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim username As String = txtAdminUser.Text.Trim()
        Dim password As String = txtAdminPass.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username and password are required.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()

                Dim query As String = "SELECT password_hash FROM admin_users WHERE username = @username LIMIT 1;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)

                    Dim result = cmd.ExecuteScalar()
                    If result Is Nothing Then
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Dim storedHash As String = result.ToString().Trim()




                    ' ----------------------------------

                    ' Verify password using BCrypt (alias bc)
                    Dim ok As Boolean = False
                    Try
                        ok = bc.Verify(password, storedHash)
                    Catch ex As Exception
                        MessageBox.Show("An error happened while verifying the password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End Try

                    If ok Then
                        MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim adminDash As New frmAdminDashboard()
                        adminDash.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    ' --- DRIVER VERIFY BUTTON ---
    Private Sub btnVerifyDriver_Click(sender As Object, e As EventArgs) Handles btnVerifyDriver.Click
        Dim plateNo As String = txtPlateNumber.Text.Trim()
        If String.IsNullOrWhiteSpace(plateNo) Then
            MessageBox.Show("Plate number is required.", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM drivers WHERE plate_no = @plate;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@plate", plateNo)
                    Dim driverExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If driverExists > 0 Then
                        MessageBox.Show("Plate number verified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim driverDash As New frmDriverDashboard()
                        driverDash.LoadDriverData(plateNo)
                        driverDash.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Plate number not registered.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    ' --- CLOSE APPLICATION BUTTON ---
    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        Dim confirm = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then Application.Exit()
    End Sub

End Class