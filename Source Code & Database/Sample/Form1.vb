Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "administrator" And txtPassword.Text = "administrator" Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            FrmLoader.Show()
            Me.Close()

        ElseIf (txtUsername.Text = "") And (txtPassword.Text = "") Then
            MessageBox.Show("Input Username and Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()

        Else
            MessageBox.Show("Invalid Username and Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()

        End If

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
