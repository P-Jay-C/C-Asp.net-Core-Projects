Public Class Form1
    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btndone.Click
        dim FIRSTNAME as String
        Dim lastname As String
        Dim gender As String
        FIRSTNAME=txtfirstname.Text
        lastname=txtlastname.Text
        gender=txtgender.Text
        MsgBox("you name is " & FIRSTNAME & " " & lastname & " " & GENDER)

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        ME.Close()
    End Sub

End Class
