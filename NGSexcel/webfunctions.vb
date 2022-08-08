Imports System.Xml
Imports System.Xml.XPath

Module webfunctions
    Public Function browser_locToLink(ByVal browser As String, ByVal chr As String, ByVal chr_start As Object, ByVal chr_end As Object)
        If browser = "ensembl" Then
            browser_locToLink = "http://www.ensembl.org/Homo_sapiens/Location/View?r=" & chr & ":" & chr_start & "-" & chr_end
        ElseIf browser = "UCSC" Then
            browser_locToLink = "http://genome.ucsc.edu/cgi-bin/hgTracks?position=chr" & chr & ":" & chr_start & "-" & chr_end
        ElseIf browser = "ensembl-hg18" Then
            browser_locToLink = "http://may2009.archive.ensembl.org/Homo_sapiens/Location/View?r=" & chr & ":" & chr_start & "-" & chr_end
        ElseIf browser = "UCSC-hg18" Then
            browser_locToLink = "http://genome.ucsc.edu/cgi-bin/hgTracks?db=hg18&position=chr" & chr & ":" & chr_start & "-" & chr_end
        Else
            browser_locToLink = "http://www.ensembl.org/Homo_sapiens/Location/View?r=" & chr & ":" & chr_start & "-" & chr_end
        End If
    End Function

    Public Function getSeq(ByVal mychr As String, ByVal mychrstart As Long, ByVal mychrend As Long, Optional ByVal source As String = "UCSC", Optional ByVal myBuildVer As String = "hg19")
        Dim path As String = ""
        Dim URLString As String = ""
        If source = "UCSC" Then
            path = "/DASDNA/SEQUENCE/DNA/text()"
            URLString = "http://genome.ucsc.edu/cgi-bin/das/" & myBuildVer & "/dna?segment=chr"
        ElseIf source = "ensembl" Then
            path = "/DASSEQUENCE/SEQUENCE/text()"
            URLString = "http://www.ensembl.org/das/Homo_sapiens.GRCh37.reference/sequence?segment="
        End If
        URLString = URLString & mychr & ":" & mychrstart & "," & mychrend
        On Error GoTo err

        Dim seq As String = ""
        Dim doc As XPathDocument = New XPathDocument(URLString)
        seq = doc.CreateNavigator.SelectSingleNode(path).Value

        seq = seq.Trim
        seq = seq.Replace(Chr(10), vbNullString)
        getSeq = seq
        Exit Function
err:
        getSeq = "Error"

    End Function

End Module
