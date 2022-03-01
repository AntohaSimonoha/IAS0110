Public Class formKujundid

    Private Sub tootleKujund(ByRef kujund As Kujund)

        lblTyyp.Text = kujund.annaTyyp

        txtPindala.Text = Math.Round(kujund.leiaPindala, ComboBox1.SelectedIndex)
        txtYmbermoot.Text = Math.Round(kujund.leiaYmbermMoot, ComboBox1.SelectedIndex)

    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        If String.IsNullOrEmpty(txtKylgA.Text) Or String.IsNullOrEmpty(txtKylgB.Text) Then
            Return
        End If
        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektKolmnurk)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        If String.IsNullOrEmpty(txtKylgA.Text) Or String.IsNullOrEmpty(txtKylgB.Text) Then
            Return
        End If
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        If String.IsNullOrEmpty(txtKylgA.Text) Or String.IsNullOrEmpty(txtKylgB.Text) Then
            Return
        End If
        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click
        If String.IsNullOrEmpty(txtKylgA.Text) Or String.IsNullOrEmpty(txtKylgB.Text) Then
            Return
        End If
        tootleKujund(New Romb(txtKylgA.Text, txtKylgB.Text))
    End Sub

    Private Sub btnRoopkylik_Click(sender As Object, e As EventArgs) Handles btnRoopkylik.Click
        If String.IsNullOrEmpty(txtKylgA.Text) Or String.IsNullOrEmpty(txtKylgB.Text) Then
            Return
        End If
        tootleKujund(New Roopkylik(txtKylgA.Text, txtKylgB.Text, numKorgus.Value))
    End Sub

    Private Sub txtKylgA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKylgA.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKylgB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKylgB.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtKorgus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKorgus.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub formKujundid_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class
