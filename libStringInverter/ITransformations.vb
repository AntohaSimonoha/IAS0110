Public Interface ITransformations
    Property intStart As Integer
    Property intFinish As Integer
    Property strText As String

    Function invertText() As String
    Sub convertText(ByRef strInputText As String)

End Interface
