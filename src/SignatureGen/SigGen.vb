Public Class SigGen
    Public Shared Function Generate(ByVal URL As String, ByVal Key As String)
        'Generate Hash
        Dim strToHash As String
        strToHash = URL + Key
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
End Class
