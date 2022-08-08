Module Validation
    Function ValidateFileName(ByVal name As String) As Boolean
        ' Determines if the name is Nothing.
        If name Is Nothing Then
            Return False
        End If

        ' Determines if there are bad characters in the name.
        For Each badChar As Char In System.IO.Path.GetInvalidPathChars
            If InStr(name, badChar) > 0 Then
                Return False
            End If
        Next

        'check that directory is okay


        ' The name passes basic validation.
        Return True
    End Function

    Function StripInvalidFileChar(ByVal name As String) As String
        For Each badChar As Char In System.IO.Path.GetInvalidPathChars
            If InStr(name, badChar) > 0 Then
                name = RegExpSubstitute(name, badChar, "")
            End If
        Next
        StripInvalidFileChar = name
    End Function
End Module
