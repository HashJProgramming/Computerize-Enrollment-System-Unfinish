Public Class Form5

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        listrefresh2()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            message = MsgBox("Are you sure you want to Delete this?", MsgBoxStyle.Information + MsgBoxStyle.YesNoCancel)
            If message = DialogResult.Yes Then
                Using mycn As New OleDb.OleDbConnection(cn)
                    mycn.Open()
                    cm = New OleDb.OleDbCommand("DELETE FROM [Information] where [ID] like '" & ListView1.FocusedItem.Text & "'", mycn)
                    cm.ExecuteNonQuery()
                End Using
                listrefresh2()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listrefresh2()
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


                End While
                dr.Close()
            End Using
        Catch ex As Exception
            listrefresh2()
        End Try
    End Sub
End Class