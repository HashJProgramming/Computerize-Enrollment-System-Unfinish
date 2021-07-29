Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listrefresh3()
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        listrefresh3()
    End Sub

    Private Sub GunaTextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaTextBox14.TextChanged
        Try
            Using mycn As New OleDb.OleDbConnection(cn)
                mycn.Open()
                ListView1.Items.Clear()
                cm = New OleDb.OleDbCommand("SELECT * FROM [Information] WHERE [ID] LIKE '" & GunaTextBox14.Text & "'", mycn)
                dr = cm.ExecuteReader

                While dr.Read
                    list = ListView1.Items.Add(dr.Item(0).ToString)
                    list.SubItems.Add(dr.Item(1).ToString)
                    list.SubItems.Add(dr.Item(2).ToString)
                    list.SubItems.Add(dr.Item(3).ToString)
                    list.SubItems.Add(dr.Item(4).ToString)
                    list.SubItems.Add(dr.Item(5).ToString)
                    list.SubItems.Add(dr.Item(6).ToString)
                    list.SubItems.Add(dr.Item(7).ToString)
                    list.SubItems.Add(dr.Item(8).ToString)
                    list.SubItems.Add(dr.Item(9).ToString)
                    list.SubItems.Add(dr.Item(10).ToString)
                    list.SubItems.Add(dr.Item(11).ToString)
                    list.SubItems.Add(dr.Item(12).ToString)


                End While
                dr.Close()
            End Using
        Catch ex As Exception
            listrefresh3()
        End Try
    End Sub
End Class