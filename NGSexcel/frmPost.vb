Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class frmPost

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a request using a URL that can receive a post. 
        Dim request As WebRequest = WebRequest.Create("http://genome.ucsc.edu/cgi-bin/hgBlat?command=start")
        ' Set the Method property of the request to POST.
        request.Method = "POST"
        ' Create POST data and convert it to a byte array.
        Dim postData As String = "name=" & Chr(34) & "userSeq" & Chr(34) & vbCrLf & ">test" & vbCrLf & "actactatctact"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        ' Set the ContentType property of the WebRequest.
        request.ContentType = "application/x-www-form-urlencoded"
        ' Set the ContentLength property of the WebRequest.
        request.ContentLength = byteArray.Length
        ' Get the request stream.
        Dim dataStream As Stream = request.GetRequestStream()
        ' Write the data to the request stream.
        dataStream.Write(byteArray, 0, byteArray.Length)
        ' Close the Stream object.
        dataStream.Close()
        ' Get the response.
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        '        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.
        dataStream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.
        Windows.Forms.Clipboard.SetText(responseFromServer)
        ' Clean up the streams.
        reader.Close()
        dataStream.Close()
        response.Close()

    End Sub

    Private Sub frmPost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class