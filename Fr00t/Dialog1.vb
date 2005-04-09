Public Class Dialog1

    Dim getresult As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        getresult = True
        Form1.TextBox2.Text = getresult
        Me.Dispose(Windows.Forms.DialogResult.Yes)

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        getresult = False
        Form1.TextBox2.Text = getresult
        Me.Dispose(Windows.Forms.DialogResult.No)
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getresult = False

    End Sub
End Class
