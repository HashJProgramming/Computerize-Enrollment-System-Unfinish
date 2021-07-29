Public Class Form4

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        Try
            Using mycn As New OleDb.OleDbConnection(cn)
                mycn.Open()
                cm = New OleDb.OleDbCommand
                With cm

                    .Connection = mycn
                    .CommandText = ("UPDATE [Information] SET [ID] = @ID, [FirstName] =@FirstName, [MiddleName] =@MiddleName, [LastName] =@LastName, [Age] =@Age, [Gender] =@Gender, [Address] =@Address, [ContactNo] =@ContactNo, [Email] =@Email, [FathersName] =@FathersName, [OccupationF] =@OccupationF, [MothersName] =@MothersName, [OccupationM] =@OccupationM WHERE [ID] LIKE '" & GunaTextBox1.Text & "'")
                    .Parameters.AddWithValue("@ID", GunaTextBox1.Text)
                    .Parameters.AddWithValue("@FirstName", GunaTextBox2.Text)
                    .Parameters.AddWithValue("@MiddleName", GunaTextBox3.Text)
                    .Parameters.AddWithValue("@LastName", GunaTextBox4.Text)
                    .Parameters.AddWithValue("@Age", GunaTextBox5.Text)
                    .Parameters.AddWithValue("@Gender", GunaTextBox6.Text)
                    .Parameters.AddWithValue("@Address", GunaTextBox7.Text)
                    .Parameters.AddWithValue("@ContactNo", GunaTextBox8.Text)
                    .Parameters.AddWithValue("@Email", GunaTextBox9.Text)
                    .Parameters.AddWithValue("@FathersName", GunaTextBox10.Text)
                    .Parameters.AddWithValue("@OccupationF", GunaTextBox11.Text)
                    .Parameters.AddWithValue("@MothersName", GunaTextBox12.Text)
                    .Parameters.AddWithValue("@OccupationM", GunaTextBox13.Text)
                    .ExecuteNonQuery()
                    MsgBox("Done !")
                End With


            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        listrefresh1()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        GunaTextBox1.Text = ListView1.FocusedItem.Text
        Try
            Using mycn As New OleDb.OleDbConnection(cn)
                mycn.Open()

                cm = New OleDb.OleDbCommand("SELECT * FROM [Information]", mycn)
                dr = cm.ExecuteReader

                While dr.Read
                    GunaTextBox2.Text = (dr.Item(1).ToString)
                    GunaTextBox3.Text = (dr.Item(2).ToString)
                    GunaTextBox4.Text = (dr.Item(3).ToString)
                    GunaTextBox5.Text = (dr.Item(4).ToString)
                    GunaTextBox6.Text = (dr.Item(5).ToString)
                    GunaTextBox7.Text = (dr.Item(6).ToString)
                    GunaTextBox8.Text = (dr.Item(7).ToString)
                    GunaTextBox9.Text = (dr.Item(8).ToString)
                    GunaTextBox10.Text = (dr.Item(9).ToString)
                    GunaTextBox11.Text = (dr.Item(10).ToString)
                    GunaTextBox12.Text = (dr.Item(11).ToString)
                    GunaTextBox13.Text = (dr.Item(12).ToString)
                End While
                dr.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listrefresh1()
    End Sub
End Class