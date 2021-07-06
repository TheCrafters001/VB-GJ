Imports System.Net
Imports SignatureGen

Public Class Trophy

    ''' <summary>
    ''' Sets a trophy as achieved for a particular user.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="trophy_id">The ID of the trophy to add for the user.</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
    Public Shared Function Add(ByVal game_id As String, ByVal PrivateKey As String, ByVal trophy_id As Integer, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/trophies/add-achieved/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&trophy_id=" & trophy_id, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&trophy_id=" & trophy_id & "&signature=" & sig))
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

    ''' <summary>
    ''' Remove a previously achieved trophy for a particular user.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="trophy_id">The ID of the trophy to remove from the user.</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
    Public Shared Function Remove(ByVal game_id As String, ByVal PrivateKey As String, ByVal trophy_id As Integer, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/trophies/remove-achieved/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&trophy_id=" & trophy_id, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&trophy_id=" & trophy_id & "&signature=" & sig))
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

    ''' <summary>
    ''' Returns one trophy or multiple trophies, depending on the parameters passed in.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
    Public Shared Function Fetch(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/trophies/"
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
