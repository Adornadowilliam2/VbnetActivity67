Public Class AddForm
    Dim cla As New Class1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = tbusername
        Dim password = tbpassword
        Dim email = tbemail

        If username.Text.Count() <> 0 And password.Text.Count() <> 0 And email.Text.Count() <> 0 Then
            'please ad statement inform a valid email
            cla.adduser(username.Text(), password.Text(), email.Text())
            'only exeute ifthis or this form or anyform is call by the that show
            Form1.RefreshDGB(sender, e)
            Dispose()
        Else
            MessageBox.Show("lOL. place fill out this txt field or you will not able to register", "Add a User", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If

    End Sub
End Class