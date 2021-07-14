Imports System.Net
Imports SignatureGen

''' <summary>
''' A namespace to get information about users friends on Game Jolt
''' </summary>

Public Class Friends

    ''' <summary>
    ''' Returns the list of a user's friends.
    ''' </summary>
    ''' <param name="game_id">The ID of your game.</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The user's username.</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
    Public Shared Function Friends(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/friends/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_id=" & user_token, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_id=" & user_token & "&signature=" & sig))
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
