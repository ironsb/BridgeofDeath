Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strNameGuess As String = Me.txtName.Text
        Dim strQuestGuess As String = Me.txtQuest.Text
        Dim strColorGuess As String = Me.txtColor.Text
        Dim strName As String = "Blake"
        Dim strQuest As String = "I seek the Grail"
        Dim strColor As String = "Blue"

        If strNameGuess = strName And strQuestGuess = strQuest And strColorGuess = strColor Then
            Me.lblFate.Text = "You May Cross The Bridge"
        Else
            Me.lblFate.Text = "You are dead."
        End If

    End Sub
End Class
