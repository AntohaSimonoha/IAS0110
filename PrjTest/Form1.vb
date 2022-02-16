Public Class Form1
    Private Sub btnConfused_Click(sender As Object, e As EventArgs) Handles btnConfused.Click
        UCtrlEmotion1.setMood("confused")
    End Sub

    Private Sub btnCool_Click(sender As Object, e As EventArgs) Handles btnCool.Click
        UCtrlEmotion1.setMood("cool")
    End Sub

    Private Sub btnSmile_Click(sender As Object, e As EventArgs) Handles btnSmile.Click
        UCtrlEmotion1.setMood("smile")
    End Sub

    Private Sub btnStar_Click(sender As Object, e As EventArgs) Handles btnStar.Click
        UCtrlEmotion1.setMood("star")
    End Sub

    Private Sub btnTeeth_Click(sender As Object, e As EventArgs) Handles btnTeeth.Click
        UCtrlEmotion1.setMood("teeth")
    End Sub

    Private Sub btnYell_Click(sender As Object, e As EventArgs) Handles btnYell.Click
        UCtrlEmotion1.setMood("yell")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        UCtrlEmotion1.setMood("clear")
    End Sub

    Private Sub USwitchCtrl1_Load(sender As Object, e As EventArgs) Handles USwitchCtrl1.Load
        USwitchCtrl1.setMode("on")
    End Sub

    Private Sub UBulbCtrl1_Load(sender As Object, e As EventArgs) Handles UBulbCtrl1.Load
        UBulbCtrl1.setMode("on")
    End Sub

    Private Sub USwitchCtrl1_SwitchOn() Handles USwitchCtrl1.SwitchOn
        UBulbCtrl1.setMode("on")
    End Sub

    Private Sub USwitchCtrl1_SwitchOff() Handles USwitchCtrl1.SwitchOff
        UBulbCtrl1.setMode("off")
    End Sub
End Class
