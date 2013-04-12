Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = String.Empty
        Button1.Text = "押す"
        Label1.Text = String.Empty
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text + " さん、おはようございます。おっと！！！いぇ～～～～い"
    End Sub
End Class
