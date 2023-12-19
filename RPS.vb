Module RPS
    Private userplay(4), compplay(4) As Integer
    Private outcome(4) As String
    Private rand As New Random
    Private totalwins As Integer
    Private totalloss As Integer
    Private totalties As Integer


    'Sub main prints the title, gets user input and computer input by running functions, and informs the user if they won, tied, or lost.
    Sub main()
        PrintTitle()

        For i As Integer = 0 To 4
            userplay(i) = GetValidInputs()
            compplay(i) = ComputerMove()
            outcome(i) = DetermineOutcome(userplay(i), compplay(i))
            Console.WriteLine($"You played {ConvertNumToWord(userplay(i))}, the comptuer played {ConvertNumToWord(compplay(i))}, you {outcome(i)}")
        Next
        Scoreboard()
    End Sub

    Function ComputerMove() As Integer
        Return rand.Next(1, 4)
    End Function


    Function GetValidInputs() As Integer
        Dim valid As Boolean = False
        Dim input As String
        Dim num As Integer
        Do
            Console.Write("Please enter a 1 for Rock, 2 for Paper, or 3 for Scissors >")
            input = Console.ReadLine
            Integer.TryParse(input, num)
            If num = 1 OrElse num = 2 OrElse num = 3 Then
                valid = True
            Else
                Console.WriteLine("Invalid Input")
            End If
        Loop While Not valid
        Return num
    End Function


    Function ConvertNumToWord(num As Integer) As String
        Dim word As String = "undefined"
        If num = 1 Then
            word = "Rock"
        ElseIf num = 2 Then
            word = "Paper"
        ElseIf num = 3 Then
            word = "Scissors"
        End If
        Return word
    End Function

    'This function determines if the user won, tied, or lost, and returns the outcome
    Function DetermineOutcome(user As Integer, comp As Integer) As String
        Dim outcome As String = "Lost"
        If (user = 1 AndAlso comp = 3) OrElse
        (user = 2 AndAlso comp = 1) OrElse
        (user = 3 AndAlso comp = 2) Then
            outcome = "Won"
            totalwins = totalwins + 1
        ElseIf user = comp Then
            outcome = "Tied"
            totalties = totalties + 1
        End If

        If outcome = "Lost" Then
            totalloss = totalloss + 1
        End If
        Return outcome
    End Function

    Sub PrintTitle()
        Console.WriteLine("
.-. .-. .-. . .     .-. .-. .-. .-. .-.     .-. .-. .-. .-. .-. .-. .-. .-.
|(  | | |   |<      |-' |-| |-' |-  |(      `-. |    |  `-. `-. | | |(  `-.
' ' `-' `-' ' ` ,   '   ` ' '   `-' ' ' ,   `-' `-' `-' `-' `-' `-' ' ' `-'
    _______           _______               _______
---'   ____)      ---'   ____)____     ---'    ____)____
      (_____)               ______)               ______)
      (_____)               _______)           __________)
      (____)               _______)           (____)
---.__(___)       ---.__________)      ---.__(___)")
    End Sub


    Sub Scoreboard()
        Console.ReadKey()
        Console.Clear()
        Console.WriteLine($"|-----------------|" & $"-----------------".PadRight(17) & $"|-----------------|".PadRight(17) & $"-----------------|")
        Console.WriteLine($"|   ROUND NUMBER  |" & $"  COMPUTER PLAY  ".PadRight(17) & $"|    YOUR PLAY    |".PadRight(17) & $"     OUTCOME     |")
        Console.WriteLine($"|-----------------|" & $"-----------------".PadRight(17) & $"|-----------------|".PadRight(17) & $"-----------------|")
        Console.WriteLine($"|   ROUND  ONE    |".PadRight(10) & $"       {compplay(0)}  ".PadRight(17) & $"|        {userplay(0)}        |" & $"      {outcome(0)}".PadRight(17) & "|")
        Console.WriteLine($"|-----------------|" & $"-----------------".PadRight(17) & $"|-----------------|".PadRight(17) & $"-----------------|")
        Console.WriteLine($"|   ROUND  TWO    |".PadRight(10) & $"       {compplay(1)}  ".PadRight(17) & $"|        {userplay(1)}        |" & $"      {outcome(1)}".PadRight(17) & "|")
        Console.WriteLine($"|-----------------|" & $"-----------------".PadRight(17) & $"|-----------------|".PadRight(17) & $"-----------------|")
        Console.WriteLine($"|   ROUND  THREE  |".PadRight(10) & $"       {compplay(2)}  ".PadRight(17) & $"|        {userplay(2)}        |" & $"      {outcome(2)}".PadRight(17) & "|")
        Console.WriteLine($"|-----------------|" & $"-----------------".PadRight(17) & $"|-----------------|".PadRight(17) & $"-----------------|")
        Console.WriteLine($"|   ROUND  FOUR   |".PadRight(10) & $"       {compplay(3)}  ".PadRight(17) & $"|        {userplay(3)}        |" & $"      {outcome(3)}".PadRight(17) & "|")
        Console.WriteLine($"|-----------------|" & $"-----------------".PadRight(17) & $"|-----------------|".PadRight(17) & $"-----------------|")
        Console.WriteLine($"|   ROUND  FIVE   |".PadRight(10) & $"       {compplay(4)}  ".PadRight(17) & $"|        {userplay(4)}        |" & $"      {outcome(4)}".PadRight(17) & "|")
        Console.WriteLine($"|-----------------|" & $"-----------------".PadRight(17) & $"|-----------------|".PadRight(17) & $"-----------------|" & vbNewLine)
        scoreboard2()
    End Sub


    Sub scoreboard2()
        Dim Percent As Double
        Dim Percent2 As Double
        Dim Percent3 As Double
        Dim overall As String

        'These equations determine what percentage of the round that the user won, lost, and tied in.
        Percent = (totalwins / 5) * 100
        Percent2 = (totalloss / 5) * 100
        Percent3 = (totalties / 5) * 100

        Console.WriteLine($"You won {totalwins} times." & vbNewLine & $"You lost {totalloss} times." & vbNewLine & $"You tied {totalties} times.")
        Console.WriteLine($"You won {Percent}% of the time.")
        Console.WriteLine($"You lost {Percent2}% of the time.")
        Console.WriteLine($"You ties {Percent3}% of the time.")
        If totalwins > totalloss Then
            overall = "You are"
        ElseIf totalloss > totalwins Then
            overall = "The computer is"
        End If

        Console.WriteLine($"{overall} the overall winner.")
    End Sub
End Module
