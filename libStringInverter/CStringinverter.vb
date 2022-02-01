Public Class CStringinverter
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

    Private Sub convertText(ByRef strInputText As String) Implements ITransformations.convertText
        strTextToInvert = StrReverse(strInputText)
    End Sub

    Private Function invertText() As String Implements ITransformations.invertText
        Return StrReverse(strTextToInvert)
    End Function
End Class
