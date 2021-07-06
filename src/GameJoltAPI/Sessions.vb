Imports System.Net
Imports SignatureGen

Public Class Sessions

    ''' <summary>
    ''' Opens a game session for a particular user and allows you to tell Game Jolt that a user is playing your game. You must ping the session to keep it active and you must close it when you're done with it.
    ''' </summary>
    ''' <param name="game_id">The ID For your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
    Public Shared Function Open(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/sessions/open/"
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

    ''' <summary>
    ''' Pings an open session to tell the system that it's still active. If the session hasn't been pinged within 120 seconds, the system will close the session and you will have to open another one. It's recommended that you ping about every 30 seconds or so to keep the system from clearing out your session. 
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <param name="status">Sets the status of the session.</param>
    ''' <returns></returns>
    Public Shared Function Ping(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_token As String, Optional ByVal status As String = "active")
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/sessions/ping/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&status=" & status, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_token=" & user_token & "&status=" & status & "&signature=" & sig))
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
    ''' Checks to see if there is an open session for the user. Can be used to see if a particular user account is active in the game.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
    Public Shared Function Check(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/sessions/check/"
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


    ''' <summary>
    ''' Closes the active session.
    ''' </summary>
    ''' <param name="game_id">The ID of your game. Can be found in the Game's URL</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The user's username</param>
    ''' <param name="user_token">The user's token.</param>
    ''' <returns></returns>
    Public Shared Function Close(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_token As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/sessions/close/"
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
