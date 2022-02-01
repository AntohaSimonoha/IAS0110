Public Class FormGui
    Private Sub btnInvert1_Click(sender As Object, e As EventArgs) Handles btnInvert1.Click
        'Creating an object
        Dim inverter As libStringInverter.ITransformations
        'Referencing new object
        inverter = New libStringInverter.CStringinverter

        inverter.strText = txtInputText.Text

        txtOutputText1.Text = inverter.invertText()

    End Sub

    Private Sub btnInvert2_Click(sender As Object, e As EventArgs) Handles btnInvert2.Click
        'Creating an object
        Dim inverter As libStringInverter.ITransformations
        'Referencing new object
        inverter = New libStringInverter.CStringinverter

        inverter.convertText(txtInputText.Text)

        txtOutputText2.Text = inverter.strText

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        btnStart.Enabled = False
        btnStop.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Creating an object
        Dim inverter As libStringInverter.ITransformations
        'Referencing new object
        inverter = New libStringInverter.CStringinverter

        inverter.strText = txtInputText.Text

        txtOutputText1.Text = inverter.invertText()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        btnStart.Enabled = True
        btnStop.Enabled = True
    End Sub

    Private Function CntVowels(ByVal strInput As String) As Integer
        Dim I As Integer

        Dim nVowels As Integer

        Dim Vowels As String

        Vowels = "aeiouäõüöAEIOUÄÕÜÖ"


        For I = 1 To Len(strInput)

            If InStr(Vowels, Mid(strInput, I, 1)) Then

                nVowels = nVowels + 1

            End If

        Next
        Return nVowels
    End Function

    Private Sub txtInputText_TextChanged(sender As Object, e As EventArgs) Handles txtInputText.TextChanged
        lblStrLen.Text = Len(txtInputText.Text)
        lblStrVowels.Text = CntVowels(txtInputText.Text)

    End Sub

    Private Sub btnInvertAlgo_Click(sender As Object, e As EventArgs) Handles btnInvertAlgo.Click
        'Creating an object
        Dim inverter As libStringInverter.ITransformations
        'Referencing new object
        inverter = New libStringInverter.CAlgorithmicInverter

        inverter.strText = txtInputText.Text

        txtOutputText1.Text = inverter.invertText()
    End Sub
End Class
