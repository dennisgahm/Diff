Public Class Diff
    Public document1 As String = ""
    Public document1Tokens As String()
    Public document2 As String = ""
    Public document2Tokens As String()

    Public commonIndeces As New List(Of Integer) 'document1
    Public subtractionIndeces As New List(Of Integer) 'document1
    Public additionIndeces As New List(Of Integer) 'document2

    Public Sub New(ByVal document1 As String, ByVal document2 As String)
        Me.document1 = document1
        Me.document2 = document2
    End Sub

    Public Function LongestCommonSubsequence(ByVal str1 As String, ByVal str2 As String, len1 As Integer, len2 As Integer) As Integer
        If len1 = 0 Or len2 = 0 Then
            Return 0
        ElseIf str1(len1 - 1) = str2(len2 - 1) Then
            commonIndeces.Insert(0, len1 - 1)
            Return 1 + LongestCommonSubsequence(str1, str2, len1 - 1, len2 - 1)
        Else
            'Note to self: this is a recursion: I need to keep track of the indeces for each path like a search
            Return Math.Max(LongestCommonSubsequence(str1, str2, len1, len2 - 1), LongestCommonSubsequence(str1, str2, len1 - 1, len2))
        End If

    End Function

End Class
