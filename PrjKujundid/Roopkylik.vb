Public Class Roopkylik
    Inherits Nelinurk

    Private korgus As Double
    Public Sub New(ByVal alus As Double, ByVal kylg As Double, ByVal korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Rööpkülik", kylg, alus, kylg, alus)
        Me.korgus = korgus
    End Sub
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
