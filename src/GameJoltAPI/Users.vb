Imports System.Net
Imports SignatureGen

''' <summary>
''' Your games will not authenticate users by using their username and password. Instead, users have a token to verify themselves along with their username.
''' 
''' Passing in the username and token can sometimes interrupt the flow of your game, so Game Jolt makes the effort to automatically pass your game the username and token whenever possible.
''' </summary>

Public Class Users

    ''' <summary>
    ''' Returns a user's data.
    ''' </summary>
    ''' <param name="game_id">The ID of your game.</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The username of the user whose data you'd like to fetch.</param>
    ''' <param name="user_id">The ID of the user whose data you'd like to fetch.</param>
    ''' <returns></returns>
    Public Shared Function Fetch(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_id As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/users/fetch/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_id=" & user_id, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_id=" & user_id & "&signature=" & sig))
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
    ''' Authenticates the user's information. This should be done before you make any calls for the user, to make sure the user's credentials (username and token) are valid.
    ''' </summary>
    ''' <param name="game_id">The ID of your game.</param>
    ''' <param name="PrivateKey">The Private API Key for the game, it can be found in your game's API settings</param>
    ''' <param name="username">The user's username.</param>
    ''' <param name="user_id">The user's token.</param>
    ''' <returns></returns>
    Public Shared Function Auth(ByVal game_id As String, ByVal PrivateKey As String, ByVal username As String, ByVal user_id As String)
        Dim baseurl As String = "https://api.gamejolt.com/api/game/v1_2/users/auth/"
        Dim webClient As WebClient = New WebClient()
        Dim result As String
        Dim sig As String

        Try
            sig = SigGen.Generate(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_id=" & user_id, PrivateKey)
            result = webClient.DownloadString(New Uri(baseurl & "?game_id=" & game_id & "&username=" & username & "&user_id=" & user_id & "&signature=" & sig))
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
