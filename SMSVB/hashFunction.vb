Imports System.Text
Imports System.Security.Cryptography
Public Class hashFunction

    Public Function fromstring(ByVal source As String) As String
        Dim bytes() As Byte
        Dim sb As New StringBuilder()
        If String.IsNullOrEmpty(source) Then
            Throw New ArgumentNullException

        End If
        bytes = Encoding.Default.GetBytes(source)
        bytes = SHA256.Create().ComputeHash(bytes)
        For x As Integer = 0 To bytes.Length - 1
            sb.Append(bytes(x).ToString("x2"))
        Next
        Return sb.ToString
    End Function

End Class
