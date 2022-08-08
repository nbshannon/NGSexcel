Imports System.Xml
Imports System.Xml.XPath

Module tests

    Private myBuildVer As String = "hg19"
    Private myChr As String = "1"
    Private myChrStart As Long = 123000
    Private myChrEnd As Long = 123100

    Public Function testgetSeq()
        On Error GoTo err
        Dim URLString As String
        URLString = "http://genome.ucsc.edu/cgi-bin/das/" & myBuildVer & "/dna?segment=chr"
        URLString = URLString & myChr & ":" & myChrStart & "," & myChrEnd
        Dim seq As String = ""
        Dim path As String = "/DASDNA/SEQUENCE/DNA/text()"
        Dim doc As XPathDocument = New XPathDocument(URLString)
        seq = doc.CreateNavigator.SelectSingleNode(path).Value

        'Exit Function
        'Dim reader As XmlTextReader = New XmlTextReader(URLString)
        'Do While (reader.Read())
        'If reader.Name.Equals("SEQUENCE") Then
        '
        'End If
        'Select Case reader.NodeType
        '    Case XmlNodeType.Text 'Display the text in each element.
        'seq = reader.Value
        'End Select
        'Loop

        seq = seq.Trim
        seq = seq.Replace(Chr(10), vbNullString)
        'Replace(seq, vbNewLine, "", , , vbTextCompare)
        'If myRevStrand = True Then
        ' seq = seqcomp(seq)
        ' End If
        testgetSeq = seq
        Exit Function
err:
        testgetSeq = "Error"

    End Function
End Module
