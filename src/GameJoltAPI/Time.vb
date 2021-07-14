Imports System.Net
Imports SignatureGen

''' <summary>
''' A namespace to obtain time information from the Game Jolt server.
''' </summary>

Public Class Time

    ''' <summary>
    ''' Returns the time of the Game Jolt server.
    ''' </summary>
    ''' <param name="game_id">The ID of your game.</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <returns></returns>
    Public Shared Function Time(ByVal game_id As String, ByVal PrivateKey As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/time/"
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
End Class
