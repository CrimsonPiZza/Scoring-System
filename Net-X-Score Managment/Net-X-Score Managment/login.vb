Public Class loginform
    Private Sub exitbutt_Click(sender As Object, e As EventArgs) Handles exitbutt.Click
        Me.Close()
    End Sub

    Private Sub loginbutt_Click(sender As Object, e As EventArgs) Handles loginbutt.Click
        If usernametxt.Text = "admin" And passwordtxt.Text = "netxsupport" Then
            MsgBox("Access Granted! Welcome! :D", MsgBoxStyle.Information)
        Else
            MsgBox("Access Denied! :(", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
