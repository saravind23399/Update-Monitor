Public Class frmLogin
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        LineShape1.BorderColor = Color.CornflowerBlue
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        LineShape1.BorderColor = Color.LightSteelBlue
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        LineShape2.BorderColor = Color.CornflowerBlue
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        LineShape2.BorderColor = Color.LightSteelBlue
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Coral
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button2_Enter(sender As Object, e As EventArgs) Handles Button2.Enter
        Button2.BackColor = Color.Coral
    End Sub

    Private Sub Button2_Leave(sender As Object, e As EventArgs) Handles Button2.Leave
        Button2.BackColor = Color.DodgerBlue
    End Sub
End Class