Imports MySql.Data.MySqlClient

Public Class frmViewDrivers

    ' --- NEW: Local Connection Function ---
    Private Function GetConnection() As MySqlConnection
        Dim cs As String = "Server=localhost;Uid=root;Pwd=;Database=tricycle_db;SslMode=Disabled;"
        Return New MySqlConnection(cs)
    End Function

    ' --- 1. FORM LOAD (No change) ---
    Private Sub frmViewDrivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllDrivers()
    End Sub

    ' --- 2. LOAD ALL (Updated) ---
    Private Sub LoadAllDrivers()
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT id, fullname, plate_no, license_no, contact FROM drivers ORDER BY fullname"
                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvDrivers.DataSource = dt
                    If dt.Rows.Count > 0 Then
                        dgvDrivers.Columns("id").Visible = False
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading drivers: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 3. GRID CLICK (No change) ---
    Private Sub dgvDrivers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDrivers.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvDrivers.Rows(e.RowIndex)
            Dim driverID As String = selectedRow.Cells("id").Value.ToString()
            lblSelectedDriverID.Text = driverID
            LoadDriverForEdit(driverID)
        End If
    End Sub

    ' --- Helper function to get full details (Updated) ---
    Private Sub LoadDriverForEdit(driverID As String)
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM drivers WHERE id = @id LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", driverID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtEditFullname.Text = reader("fullname").ToString()
                            txtEditAddress.Text = reader("address").ToString()
                            txtEditContact.Text = reader("contact").ToString()
                            txtEditPlateNo.Text = reader("plate_no").ToString()
                            txtEditOrCr.Text = reader("or_cr_no").ToString()
                            txtEditLicense.Text = reader("license_no").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading driver details: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 4. UPDATE BUTTON (Updated) ---
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lblSelectedDriverID.Text = "0" Then
            MessageBox.Show("Please select a driver from the list first.", "No Driver Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "UPDATE drivers SET fullname = @fname, address = @addr, contact = @contact, " &
                                    "plate_no = @plate, or_cr_no = @orcr, license_no = @license " &
                                    "WHERE id = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", txtEditFullname.Text.Trim())
                    cmd.Parameters.AddWithValue("@addr", txtEditAddress.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact", txtEditContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@plate", txtEditPlateNo.Text.Trim())
                    cmd.Parameters.AddWithValue("@orcr", txtEditOrCr.Text.Trim())
                    cmd.Parameters.AddWithValue("@license", txtEditLicense.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", lblSelectedDriverID.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Driver updated successfully.")
                    LoadAllDrivers() ' Refresh the grid
                End Using
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Error: This plate number is already in use by another driver.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Error updating driver: " & ex.Message)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' --- 5. DELETE BUTTON (Updated) ---
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lblSelectedDriverID.Text = "0" Then
            MessageBox.Show("Please select a driver from the list first.", "No Driver Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm = MessageBox.Show("Are you sure you want to delete this driver?" & vbCrLf & "This action cannot be undone.",
                                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "DELETE FROM drivers WHERE id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", lblSelectedDriverID.Text)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Driver deleted successfully.")
                    LoadAllDrivers()
                    ClearEditFields()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting driver: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 6. SEARCH BUTTON (Updated) ---
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim()
        If String.IsNullOrWhiteSpace(searchTerm) Then
            LoadAllDrivers()
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT id, fullname, plate_no, license_no, contact FROM drivers " &
                                "WHERE fullname LIKE @search OR plate_no LIKE @search OR license_no LIKE @search"

                Using adapter As New MySqlDataAdapter(query, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvDrivers.DataSource = dt
                    If dt.Rows.Count > 0 Then
                        dgvDrivers.Columns("id").Visible = False
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error searching drivers: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 7. CLEAR BUTTON (No change) ---
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearEditFields()
    End Sub

    Private Sub ClearEditFields()
        lblSelectedDriverID.Text = "0"
        txtEditFullname.Clear()
        txtEditAddress.Clear()
        txtEditContact.Clear()
        txtEditPlateNo.Clear()
        txtEditOrCr.Clear()
        txtEditLicense.Clear()
        dgvDrivers.ClearSelection()
    End Sub

End Class