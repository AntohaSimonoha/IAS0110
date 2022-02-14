Public Class USwitchCtrl
    Private Sub selectMode(ByVal intMode As Integer)
        pbSwitch.Image = imgSwitch.Images(intMode)

    End Sub
    Public stateOn As Boolean = True
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

    Private Sub pbSwitch_Click(sender As Object, e As EventArgs) Handles pbSwitch.Click
        If stateOn = True Then
            setMode("off")
            stateOn = False
        ElseIf stateOn = False Then
            setMode("on")
            stateOn = True
        End If

    End Sub
End Class
