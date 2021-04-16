Imports GameJoltAPI

Module Module1

    Sub Main()
        Console.WriteLine("1. Add Score")
        Console.WriteLine("2. Get Rank (Scores)")
        Console.WriteLine("3. Tables (Scores)")
        Console.WriteLine("4. Get Scores")
        Dim choice As Integer = Console.ReadLine

        If choice = 1 Then
            Console.WriteLine("Enter your Game Jolt Username: ")
            Dim un As String = Console.ReadLine()
            Console.WriteLine("Enter your Game Jolt Token:    ")
            Dim token As String = Console.ReadLine()
            Console.WriteLine("Enter a number:                ")
            Dim number As String = Console.ReadLine()
            Console.WriteLine(Score.Add("607194", "2f1222b54cb623b7ad8fb55eea58869c", number, number, un, token))
        ElseIf choice = 2 Then
            Console.WriteLine("Enter a number:                ")
            Dim number As String = Console.ReadLine()
            Console.WriteLine(Score.GetRank("607194", "2f1222b54cb623b7ad8fb55eea58869c", number))
        ElseIf choice = 3 Then
            Console.WriteLine(Score.Tables("607194", "2f1222b54cb623b7ad8fb55eea58869c"))
        ElseIf choice = 4 Then
            Console.WriteLine("Enter your Game Jolt Username: ")
            Dim un As String = Console.ReadLine()
            Console.WriteLine("Enter your Game Jolt Token:    ")
            Dim token As String = Console.ReadLine()
            Console.WriteLine(Score.Fetch("607194", "2f1222b54cb623b7ad8fb55eea58869c", un, token))
        End If
        Main()
    End Sub

End Module
