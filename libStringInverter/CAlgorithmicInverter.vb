Public Class CAlgorithmicInverter
    Implements ITransformations

    'CStringinverter class variables
    Private intFirstSymbol As Integer
    Private intLastSymbol As Integer
    Private strTextToInvert As String

    Private Property intStart As Integer Implements ITransformations.intStart
        Get
            Return intFirstSymbol
        End Get
        Set(ByVal value As Integer)
            intFirstSymbol = value
        End Set
    End Property

    Private Property intFinish As Integer Implements ITransformations.intFinish
        Get
            Return intLastSymbol
        End Get
        Set(ByVal value As Integer)
            intLastSymbol = value
        End Set
    End Property

    Private Property strText As String Implements ITransformations.strText
        Get
            Return strTextToInvert
        End Get
        Set(ByVal value As String)
            strTextToInvert = value
        End Set
    End Property

    Private Function AlgoInvert(ByVal input As String) As String
        Dim output As String = String.Empty
        Dim chars As Char() = input.ToCharArray()

        For i As Integer = chars.Length - 1 To 0 Step -1
            output &= chars(i)
        Next

        Return output
    End Function

    Private Sub convertText(ByRef strInputText As String) Implements ITransformations.convertText
        strTextToInvert = AlgoInvert(strInputText)
    End Sub

    Private Function invertText() As String Implements ITransformations.invertText
        Return AlgoInvert(strTextToInvert)
    End Function
End Class