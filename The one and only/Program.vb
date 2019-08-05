''' <summary>
''' The form is used for nothing at the moment
''' </summary>
''' <author>James Malsher</author>
''' <date>26/7/2019</date>





Public Class Form1

    ''' <summary>
    ''' btnOk turns the text Red
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        lblOutput.ForeColor = Color.Red
        lblOutput.Text = "Hello James"
        btnOk.Text = "Done"
    End Sub


    ''' <summary>
    ''' btnEnd end the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    ''' <summary>
    ''' lblOutput allows the user to choose if they want to quit to program by displaying three buttons
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblOutput.Click
        Dim answer = MessageBox.Show(Me, "Do you want to quit, if you do, i will find you and hunt you down?", "Dont leave, please!", vbYesNoCancel)

        If answer = vbYes Then
            Application.Exit()


        Else
            lblOutput.Text = "Thank you for staying!"
        End If

    End Sub

End Class



