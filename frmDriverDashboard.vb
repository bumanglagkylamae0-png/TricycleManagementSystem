Imports MySql.Data.MySqlClient

Public Class frmDriverDashboard

    ' --- NEW: Local Connection Function ---
    Private Function GetConnection() As MySqlConnection
        Dim cs As String = "Server=localhost;Uid=root;Pwd=;Database=tricycle_db;SslMode=Disabled;"
        Return New MySqlConnection(cs)
    End Function

    ' --- UPDATED: To use the new connection method ---
    Public Sub LoadDriverData(plateNo As String)
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM drivers WHERE plate_no = @plate LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@plate", plateNo)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate all the read-only textboxes
                            txtFullname.Text = reader("fullname").ToString()
                            txtAddress.Text = reader("address").ToString()
                            txtContact.Text = reader("contact").ToString()
                            txtPlateNo.Text = reader("plate_no").ToString()
                            txtOrCr.Text = reader("or_cr_no").ToString()
                            txtLicense.Text = reader("license_no").ToString()

                            If reader("date_registered") IsNot DBNull.Value Then
                                txtDateRegistered.Text = Convert.ToDateTime(reader("date_registered")).ToShortDateString()
                            Else
                                txtDateRegistered.Text = "N/A"
                            End If
                        Else
                            MessageBox.Show("Could not find driver data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading driver data: " & ex.Message)
            End Try
        End Using ' Connection automatically closes here
    End Sub

    ' --- LOGOUT BUTTON ---
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