Module Module1
    Public message As New DialogResult
    Public list As ListViewItem
    Public dr As OleDb.OleDbDataReader
    Public cm As New OleDb.OleDbCommand
    Public cn As String = "Provider = Microsoft.jet.OleDB.4.0;Data Source = " & Application.StartupPath & "\Database1.mdb;"

    Sub showform(ByVal panel As Form)

        Form2.Panel4.Controls.Clear()
        panel.TopLevel = False
        Form2.Panel4.Controls.Add(panel)
        panel.Show()


    End Sub



    Sub listrefresh1()
        Try
            Using mycn As New OleDb.OleDbConnection(cn)
                mycn.Open()
                Form4.ListView1.Items.Clear()
                cm = New OleDb.OleDbCommand("SELECT * FROM [Information]", mycn)
                dr = cm.ExecuteReader

                While dr.Read
                    list = Form4.ListView1.Items.Add(dr.Item(0).ToString)
                    list.SubItems.Add(dr.Item(1).ToString)


                End While
                dr.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Sub listrefresh2()
        Try
            Using mycn As New OleDb.OleDbConnection(cn)
                mycn.Open()
                Form5.ListView1.Items.Clear()
                cm = New OleDb.OleDbCommand("SELECT * FROM [Information]", mycn)
                dr = cm.ExecuteReader

                While dr.Read
                    list = Form5.ListView1.Items.Add(dr.Item(0).ToString)
                    list.SubItems.Add(dr.Item(1).ToString)


                End While
                dr.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Sub listrefresh3()
        Try
            Using mycn As New OleDb.OleDbConnection(cn)
                mycn.Open()
                Form6.ListView1.Items.Clear()
                cm = New OleDb.OleDbCommand("SELECT * FROM [Information]", mycn)
                dr = cm.ExecuteReader

                While dr.Read
                    list = Form6.ListView1.Items.Add(dr.Item(0).ToString)
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
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
