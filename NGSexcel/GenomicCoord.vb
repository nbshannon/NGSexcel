Public Class GenomicCoord
    Private myChr As String
    Private myChrStart As Long
    Private myChrEnd As Long
    Private myOkay As Boolean = False
    Private myRevStrand As Boolean = False
    Private myBuildVer As String = "hg19"
    Private mySeqSource As String = "UCSC"
    Dim okayChr As String() = Split("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,X,Y", ",")

    Private Function getVals()
        Dim myvals(0 To 2) As String
        myvals(0) = myChr
        myvals(1) = myChrStart
        myvals(2) = myChrEnd
        getVals = myvals
    End Function
    ReadOnly Property length As Object
        Get
            Return myChrEnd - myChrStart
        End Get
    End Property

    ReadOnly Property coordinatesAsArray As Object
        Get
            Return getVals()
        End Get
    End Property

    ReadOnly Property coordinates() As String
        Get
            Return myChr & ":" & myChrStart & "-" & myChrEnd
        End Get
    End Property

    ReadOnly Property valid() As Boolean
        Get
            Return myOkay
        End Get
    End Property

    ReadOnly Property strand() As String
        Get
            If myRevStrand = True Then
                Return "-"
            Else
                Return "+"
            End If
        End Get
    End Property
    Public Sub setSeqSource(Optional ByVal seqSource As String = "UCSC")
        On Error Resume Next
        Dim allowed As String() = Split("UCSC,ensembl", ",")
        If allowed.Contains(seqSource) Then
            mySeqSource = seqSource
        End If
    End Sub
    Public Sub setBuild(Optional ByVal build As String = "hg19")
        On Error Resume Next
        Dim allowed As String() = Split("hg19,hg18,hg17,hg16", ",")
        If allowed.Contains(build) Then
            myBuildVer = build
        End If
    End Sub
    Public Sub setStrand(ByVal strand As String)
        On Error Resume Next
        Select Case strand
            Case 1
                myRevStrand = False
            Case "+"
                myRevStrand = False
            Case -1
                myRevStrand = True
            Case "-"
                myRevStrand = True
            Case Else
                myRevStrand = False
        End Select
    End Sub
    Public Sub extend(ByVal extend As Long)
        myChrStart -= extend
        If myChrStart < 1 Then myChrStart = 1
        myChrEnd += extend
    End Sub
    Sub setFromCoord(ByVal coord As String)
        On Error GoTo err
        Dim vals As String()
        vals = Split(coord, ":")
        Dim chr As String
        chr = vals(0)
        chr = RegExpSubstitute(chr, "chr", "")
        chr = RegExpSubstitute(chr, "c", "")
        chr = RegExpSubstitute(chr, ".fa", "")
        myChr = chr
        If okayChr.Contains(myChr) Then
        Else
            GoTo err
        End If
        vals = Split(vals(1), "-")
        myChrStart = vals(0)
        myChrEnd = vals(1)
        myOkay = True
        Exit Sub
err:
        myOkay = False
    End Sub
    Sub New()

    End Sub
    Sub setFromValues(ByVal chr As String, ByVal chr_start As Long, ByVal chr_end As Long)
        On Error GoTo err
        chr = RegExpSubstitute(chr, "chr", "")
        chr = RegExpSubstitute(chr, "c", "")
        chr = RegExpSubstitute(chr, ".fa", "")
        myChr = chr
        myChrStart = chr_start
        myChrEnd = chr_end
        myOkay = True
        Exit Sub
err:
        myOkay = False
    End Sub

    Public Function getSeq()
        On Error GoTo err
        If myOkay = False Then
            getSeq = "Error"
            Exit Function
        End If
        Dim path As String = ""
        Dim URLString As String = ""
        If mySeqSource = "UCSC" Then
            path = "/DASDNA/SEQUENCE/DNA/text()"
            URLString = "http://genome.ucsc.edu/cgi-bin/das/" & myBuildVer & "/dna?segment=chr"
        ElseIf mySeqSource = "ensembl" Then
            path = "/DASSEQUENCE/SEQUENCE/text()"
            URLString = "http://www.ensembl.org/das/Homo_sapiens.GRCh37.reference/sequence?segment="
        End If
        URLString = URLString & myChr & ":" & myChrStart & "," & myChrEnd
        On Error GoTo err
        Dim seq As String = ""
        Dim doc As System.Xml.XPath.XPathDocument = New System.Xml.XPath.XPathDocument(URLString)
        seq = doc.CreateNavigator.SelectSingleNode(path).Value

        seq = seq.Trim
        seq = seq.Replace(Chr(10), vbNullString)
        'Replace(seq, vbNewLine, "", , , vbTextCompare)
        If myRevStrand = True Then
            seq = seqcomp(seq)
        End If
        getSeq = seq
        Exit Function
err:
        getSeq = "Error"

    End Function

End Class
