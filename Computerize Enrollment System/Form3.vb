Public Class Form3

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        GunaTextBox1.Text = Nothing
        GunaTextBox2.Text = Nothing
        GunaTextBox3.Text = Nothing
        GunaTextBox4.Text = Nothing
        GunaTextBox5.Text = Nothing
        GunaTextBox6.Text = Nothing
        GunaTextBox7.Text = Nothing
        GunaTextBox8.Text = Nothing
        GunaTextBox9.Text = Nothing
        GunaTextBox10.Text = Nothing
        GunaTextBox11.Text = Nothing
        GunaTextBox12.Text = Nothing
        GunaTextBox13.Text = Nothing
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        Try
            Using mycn As New OleDb.OleDbConnection(cn)
                mycn.Open()
                With cm
                    .Connection = mycn
                    .CommandText = "INSERT INTO Information ([ID], [FirstName], [MiddleName], [LastName], [Age], [Gender], [Address], [ContactNo], [Email], [FathersName], [OccupationF], [MothersName], [OccupationM])  VALUES (@ID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Address, @ContactNo, @Email, @FathersName, @OccupationF, @MothersName, @OccupationM)"
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
                mycn.Close()
            End Using
        Catch ex As Exception

        End Try
        
    End Sub
End Class