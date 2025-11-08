Imports bc = BCrypt.Net.BCrypt ' Use the same alias

Public Class frmTestHash
    Private Sub btnHash_Click(sender As Object, e As EventArgs) Handles btnHash.Click
        Try
            ' We use the 'bc' alias to hash the password
            Dim hashedPassword As String = bc.HashPassword(txtPassword.Text)

            txtResult.Text = hashedPassword
            MessageBox.Show("New hash generated! Copy it from the textbox.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class