Module RegexFunctions
    Public Function RegExpSubstitute(ByVal ReplaceIn As String, ByVal ReplaceWhat As String, ByVal ReplaceWith As String)
        Dim RE As Object
        RE = CreateObject("vbscript.regexp")
        RE.Pattern = ReplaceWhat
        RE.Global = True
        RegExpSubstitute = RE.Replace(ReplaceIn, ReplaceWith)
    End Function
    Public Function RegExpFind(ByVal FindIn As String, ByVal FindWhat As String, Optional ByVal IgnoreCase As Boolean = False)
        Dim i As Long
        Dim RE As Object, allMatches As Object
        Dim rslt()
        RE = CreateObject("vbscript.regexp")
        RE.Pattern = FindWhat
        RE.IgnoreCase = IgnoreCase
        RE.Global = True
        allMatches = RE.Execute(FindIn)
        ReDim rslt(0 To allMatches.Count - 1)
        For i = 0 To allMatches.Count - 1
            rslt(i) = allMatches(i).Value
        Next i
        RegExpFind = rslt
        
    End Function

End Module
