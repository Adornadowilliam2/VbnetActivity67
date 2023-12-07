Public Class EDITForm
    Dim cla As New Class1
    Public user_id
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = tbusername
        Dim password = tbpassword
        Dim email = tbemail

        If username.Text.Count() <> 0 And password.Text.Count() <> 0 And email.Text.Count() <> 0 Then
            'please add statement inform a valid email

            'only exeute ifthis or this form or anyform is call by the that show
            cla.updateuser(Integer.Parse(user_id), username.Text, password.Text, email.Text)
            Form1.RefreshDGB(sender, e)
            Dispose()
        Else
            MessageBox.Show("lOL. place fill out this txt field or you will not able to register", "Add a User", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If

    End Sub
End Class