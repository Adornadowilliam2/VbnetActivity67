

Public Class Form1
    'all Class must be declare to a new instance
    Private cla As New Class1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    cla.test = "Hello World"
        '    MsgBox(cla.test)

        cla.retrieveData(dgvUsers)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddForm.ShowDialog()
    End Sub

    Public Sub RefreshDGB(sender As Object, e As EventArgs) Handles btnrefresh.Click
        cla.retrieveData(dgvUsers)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EDITForm.user_id = dgvUsers.SelectedCells().Item(0).Value.ToString()
        EDITForm.tbusername.Text = dgvUsers.SelectedCells().Item(1).Value.ToString()
        EDITForm.tbpassword.Text = dgvUsers.SelectedCells().Item(2).Value.ToString()
        EDITForm.tbemail.Text = dgvUsers.SelectedCells().Item(3).Value.ToString()

        EDITForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim userid = dgvUsers.SelectedCells().Item(0).Value.ToString()
        Dim confirm = MessageBox.Show("CONFIRM DELETION OF user_id" & userid, "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


        If confirm = DialogResult.Yes Then
            cla.deleteuser(Integer.Parse(userid))
            RefreshDGB(sender, e)
        End If


    End Sub
End Class
