Imports System.Net
Imports SignatureGen

''' <summary>
''' Game Jolt supports multiple online score tables, or scoreboards, per game. You are able to, for example, have a score table for each level in your game, or a table for different scoring metrics. Gamers will keep coming back to try to achieve the highest scores for your game.
'''
''' With multiple formatting And sorting options, the system Is quite flexible. You are also able To include extra data With Each score. If there Is other data associated With the score such As time played, coins collected, etc., you should definitely include it. It will be helpful In cases where you believe a gamer has illegitimately achieved a high score.
''' </summary>

Public Class Score

    ''' <summary>
    ''' Adds a score for a user or guest.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="score">This is a string value associated with the score. Example: 500 Points</param>
    ''' <param name="sort">This is a numerical sorting value associated with the score. All sorting will be based on this number. Example: 500</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
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

    ''' <summary>
    ''' Returns the rank of a particular score on a score table.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="sort">This is a numerical sorting value associated with the score. All sorting will be based on this number. Example: 500</param>
    ''' <returns></returns>
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

    ''' <summary>
    ''' Returns a list of high score tables for a game.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <returns></returns>
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

    ''' <summary>
    ''' Returns a list of scores either for a user or globally for a game.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
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
