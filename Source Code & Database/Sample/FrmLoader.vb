Public Class FrmLoader
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FrmLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles progreport.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        progreport.Text = loading1.Value & "%"

        loading1.Value += 1

        If loading1.Value = 100 Then

            MainForm.Show()
            Me.Hide()
            Timer1.Dispose()
        End If


    End Sub

    Private Sub loading1_Click(sender As Object, e As EventArgs) Handles loading1.Click

    End Sub
End Class