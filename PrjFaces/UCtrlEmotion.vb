Public Class UCtrlEmotion
    ' Klassisisene meetod kuvatava pildi määramiseks
    Private Sub selectMood(ByVal intMood As Integer)
        If intMood = 6 Then
            pbEmotion.Image = Nothing
        Else
            pbEmotion.Image = imgLoend.Images(intMood)
        End If

    End Sub
    ' Avalik liidesmeetod
    Public Sub setMood(ByVal strMood As String)
        Select Case strMood
            Case "confused"
                Me.selectMood(0)
            Case "cool"
                Me.selectMood(1)
            Case "smile"
                Me.selectMood(2)
            Case "star"
                Me.selectMood(3)
            Case "teeth"
                Me.selectMood(4)
            Case "yell"
                Me.selectMood(5)
            Case "clear"
                Me.selectMood(6)
            Case Else
                Me.selectMood(0)
        End Select
    End Sub

End Class
