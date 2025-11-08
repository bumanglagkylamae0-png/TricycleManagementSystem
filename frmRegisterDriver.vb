Imports MySql.Data.MySqlClient

Public Class frmRegisterDriver

    ' --- NEW: Local Connection Function ---
    Private Function GetConnection() As MySqlConnection
        Dim cs As String = "Server=localhost;Uid=root;Pwd=;Database=tricycle_db;SslMode=Disabled;"
        Return New MySqlConnection(cs)
    End Function

    ' --- UPDATED: To use the new connection method ---
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtFullname.Text) Or String.IsNullOrWhiteSpace(txtPlateNo.Text) Then
            MessageBox.Show("Full Name and Plate Number are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "INSERT INTO drivers (fullname, address, contact, plate_no, or_cr_no, license_no, date_registered) " &
                                    "VALUES (@fname, @addr, @contact, @plate, @orcr, @license, @dateReg)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", txtFullname.Text.Trim())
                    cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@plate", txtPlateNo.Text.Trim())
                    cmd.Parameters.AddWithValue("@orcr", txtOrCr.Text.Trim())
                    cmd.Parameters.AddWithValue("@license", txtLicense.Text.Trim())
                    cmd.Parameters.AddWithValue("@dateReg", dtpDateRegistered.Value)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Driver registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                End Using
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Error: This plate number is already registered.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Error saving to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using ' Connection automatically closes here
    End Sub

    ' A helper function to clear all textboxes
    Private Sub ClearForm()
        txtFullname.Clear()
        txtAddress.Clear()
        txtContact.Clear()
        txtPlateNo.Clear()
        txtOrCr.Clear()
        txtLicense.Clear()
        dtpDateRegistered.Value = DateTime.Now ' Reset date to today
    End Sub

End Class