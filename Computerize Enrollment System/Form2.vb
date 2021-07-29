Public Class Form2

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        showform(Form3)

        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        showform(Form4)
        Form3.Close()

        Form5.Close()
        Form6.Close()
        Form7.Close()
    End Sub

    Private Sub GunaButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton3.Click
        showform(Form5)
        Form3.Close()
        Form4.Close()

        Form6.Close()
        Form7.Close()
    End Sub

    Private Sub GunaButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton4.Click
        showform(Form6)
        Form3.Close()
        Form4.Close()
        Form5.Close()

        Form7.Close()
    End Sub

    Private Sub GunaButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton5.Click
        showform(Form7)
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()

    End Sub

    Private Sub GunaButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton6.Click
        Me.Close()
        Form1.Show()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
    End Sub
End Class