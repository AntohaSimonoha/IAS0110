Public Class UBulbCtrl
    ' Klassisisene meetod kuvatava pildi määramiseks

    Private Sub selectMode(ByVal intMode As Integer)
        pbBulb.Image = imgBulb.Images(intMode)

    End Sub
    ' Avalik liidesmeetod

    Public Sub setMode(ByVal strMode As String)
        Select Case strMode
            Case "off"
                Me.selectMode(0)
            Case "on"
                Me.selectMode(1)
            Case Else
                Me.selectMode(0)
        End Select
    End Sub
End Class
