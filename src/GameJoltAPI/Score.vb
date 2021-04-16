Imports System.Net
Imports SignatureGen

''' <summary>
''' Credit to Jimmy Smith on Stack Overflow,
''' as this solution uses some of his code.
''' https://stackoverflow.com/questions/46056316/net-framework-4-vb-net-call-an-api
''' </summary>

Public Class Score
    Public Shared Function Add(ByVal game_id As String, ByVal PrivateKey As String, ByVal score As String, ByVal sort As Integer, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/scores/add/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&score=" & score & "&sort=" & sort, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&score=" & score & "&sort=" & sort & "&signature=" & sig))
        Catch ex As WebException
            If ex.Status = WebExceptionStatus.ProtocolError AndAlso ex.Response IsNot Nothing Then
                Dim resp = DirectCast(ex.Response, HttpWebResponse)
                If resp.StatusCode = HttpStatusCode.NotFound Then
                    Console.WriteLine("404")
                End If
            End If
            Throw
        End Try
        Return result
    End Function

    Public Shared Function GetRank(ByVal game_id As String, ByVal PrivateKey As String, ByVal sort As Integer)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/scores/get-rank/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&sort=" & sort, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&sort=" & sort & "&signature=" & sig))
        Catch ex As WebException
            If ex.Status = WebExceptionStatus.ProtocolError AndAlso ex.Response IsNot Nothing Then
                Dim resp = DirectCast(ex.Response, HttpWebResponse)
                If resp.StatusCode = HttpStatusCode.NotFound Then
                    Console.WriteLine("404")
                End If
            End If
            Throw
        End Try
        Return result
    End Function

    Public Shared Function Tables(ByVal game_id As String, ByVal PrivateKey As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/scores/tables/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&signature=" & sig))
        Catch ex As WebException
            If ex.Status = WebExceptionStatus.ProtocolError AndAlso ex.Response IsNot Nothing Then
                Dim resp = DirectCast(ex.Response, HttpWebResponse)
                If resp.StatusCode = HttpStatusCode.NotFound Then
                    Console.WriteLine("404")
                End If
            End If
            Throw
        End Try
        Return result
    End Function

    Public Shared Function Fetch(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/scores/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&signature=" & sig))
        Catch ex As WebException
            If ex.Status = WebExceptionStatus.ProtocolError AndAlso ex.Response IsNot Nothing Then
                Dim resp = DirectCast(ex.Response, HttpWebResponse)
                If resp.StatusCode = HttpStatusCode.NotFound Then
                    Console.WriteLine("404")
                End If
            End If
            Throw
        End Try
        Return result
    End Function
End Class
