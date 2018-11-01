Imports Microsoft.VisualBasic
Public Class Form2
    Dim permit As Boolean = True
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()




    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If ComboBox1.SelectedItem = "SA ID DOCUMENT" Then
            PeoplesTableAdapter1.Fill(VectorsoftDataSet1.Peoples, TextBox3.Text)

            If VectorsoftDataSet1.Peoples.Rows.Count > 0 Then


                TextBox1.Text = VectorsoftDataSet1.Peoples.Rows(0).Item(0).ToString
                TextBox2.Text = VectorsoftDataSet1.Peoples.Rows(0).Item(1).ToString
                ComboBox2.SelectedItem = VectorsoftDataSet1.Peoples.Rows(0).Item(5).ToString
                DateTimePicker1.Text = VectorsoftDataSet1.Peoples.Rows(0).Item(4).ToString



            End If

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        permit = True

        If TextBox1.Text = String.Empty Then
            permit = False
            Label8.Visible = True
        Else
            Label8.Visible = False
        End If

        If TextBox2.Text = String.Empty Then
            permit = False
            Label9.Visible = True
        Else
            Label9.Visible = False
        End If

        If TextBox3.Text = String.Empty Then
            permit = False
            Label11.Visible = True
        Else
            Label11.Visible = False
        End If

        If ComboBox1.Text = String.Empty Then
            permit = False
            Label10.Visible = True
        Else
            Label10.Visible = False
        End If

        If ComboBox2.Text = String.Empty Then
            permit = False
            Label12.Visible = True
        Else
            Label12.Visible = False
        End If
        '--------------------------------------------------------------------
        '--------------------------------------------------------------------

        If (Not IsNumeric(TextBox3.Text)) And ComboBox1.Text = "SA ID DOCUMENT" Then
            permit = False
            Label11.Visible = True
            Label11.Text = "Incorrect Format"
        End If

        PeopleTableAdapter1.FillBy(VectorsoftDataSet1.People, TextBox3.Text)
        If VectorsoftDataSet1.People.Rows.Count > 0 Then
            permit = False
            MsgBox("This record already exists. Only Unique ID's are allowed")
        End If



        If permit Then
            PeopleTableAdapter1.Fill(VectorsoftDataSet1.People, TextBox1.Text, TextBox2.Text, ComboBox1.Text, TextBox3.Text, DateTimePicker1.Text, ComboBox2.Text)
            Dim form As Form1
            form = New Form1()
            form.Show()
            'Close()
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Dim form As Form1
        form = New Form1()
        form.Show()
    End Sub
End Class