Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates

Module Module1
    Private userinput As String
    Private CI2 As String
    Private GVI2 As String
    Private ComWins As Integer
    Private PlayerWins As Integer
    Private roundnumber As Integer = 0

    Private r1c, r1p, r2c, r2p, r3c, r3p, r4c, r4p, r5c, r5p As String
    Private r1cw, r1pw, r2cw, r2pw, r3cw, r3pw, r4cw, r4pw, r5cw, r5pw As String


    Sub Main()

        sg()

    End Sub


    Sub sg()
        roundnumber = roundnumber + 1
        Console.WriteLine(".-. .-. .-. . .     .-. .-. .-. .-. .-.     .-. .-. .-. .-. .-. .-. .-. .-.
|(  | | |   |<      |-' |-| |-' |-  |(      `-. |    |  `-. `-. | | |(  `-.
' ' `-' `-' ' ` ,   '   ` ' '   `-' ' ' ,   `-' `-' `-' `-' `-' `-' ' ' `-'
    _______           _______               _______
---'   ____)      ---'   ____)____     ---'    ____)____
      (_____)               ______)               ______)
      (_____)               _______)           __________)
      (____)               _______)           (____)
---.__(___)       ---.__________)      ---.__(___)" & vbNewLine & "Press any key to start")
        Console.ReadKey()
        Console.Clear()
        GVI()
    End Sub

    Function GVI()
        Console.WriteLine("Please Choose an option:" & vbNewLine & "1: Rock" & vbNewLine & "2: Paper" & vbNewLine & "3: Scissors")
        userinput = Console.ReadLine
        If userinput <> "1".ToString AndAlso userinput <> "2".ToString AndAlso userinput <> "3".ToString Then
            gviInval()
        Else
            GVIEnd()
        End If
        Return userinput
    End Function


    Sub gviInval()
        Console.Clear()
        Console.WriteLine("Invalid Input. When the prompt appears again, please enter a valid response.")
        Console.ReadKey()
        Console.Clear()
        GVI()
    End Sub

    Sub GVIEnd()
        Console.Clear()

        If userinput = "1" Then
            GVI2 = "rock"
        End If

        If userinput = "2" Then
            GVI2 = "paper"
        End If

        If userinput = "3" Then
            GVI2 = "scissors"
        End If

        Console.WriteLine($"You chose {GVI2}!")
        computermove()
    End Sub

    Sub computermove()
        Dim random As New Random()
        Dim cominput As Integer = random.Next(0, 3)

        If cominput = 0 Then
            CI2 = "rock"
        End If

        If cominput = 1 Then
            CI2 = "paper"
        End If

        If cominput = 2 Then
            CI2 = "scissors"
        End If

        Console.WriteLine($"The computer chose {CI2}")
        DeterWin()
    End Sub

    Sub DeterWin()
        ronecount()
        rocktie()
    End Sub


    Sub rocktie()
        If CI2 = "rock" AndAlso GVI2 = "rock" Then
            Console.WriteLine("We have a tie!")
            ComWins = ComWins + 1
            PlayerWins = PlayerWins + 1
            Console.ReadKey()
            ScoreBoard1()
        Else
            rockwincom()
        End If
    End Sub
    Sub rockwincom()
        If CI2 = "rock" AndAlso GVI2 = "scissors" Then
            Console.WriteLine("The computer beat you using: Rock!")
            ComWins = ComWins + 1
            Console.ReadKey()
            ScoreBoard1()
        Else
            rockwinplayer()
        End If
    End Sub
    Sub rockwinplayer()
        If CI2 = "scissors" AndAlso GVI2 = "rock" Then
            Console.WriteLine("You beat the computer using: Rock!")
            PlayerWins = PlayerWins + 1
            Console.ReadKey()
            ScoreBoard1()
        Else
            papertie()
        End If
    End Sub

    Sub papertie()
        If CI2 = "paper" AndAlso GVI2 = "paper" Then
            Console.WriteLine("We have a tie!")
            ComWins = ComWins + 1
            PlayerWins = PlayerWins + 1
            Console.ReadKey()
            ScoreBoard1()
        Else
            paperwincom()
        End If
    End Sub
    Sub paperwincom()
        If CI2 = "paper" AndAlso GVI2 = "rock" Then
            Console.WriteLine("The computer beat you using: Paper!")
            ComWins = ComWins + 1
            Console.ReadKey()
            ScoreBoard1()
        Else
            paperwinplayer()
        End If
    End Sub
    Sub paperwinplayer()
        If CI2 = "rock" AndAlso GVI2 = "paper" Then
            Console.WriteLine("You beat the computer using: Paper!")
            PlayerWins = PlayerWins + 1
            Console.ReadKey()
            ScoreBoard1()
        Else
            scissortie()
        End If
    End Sub


    Sub scissortie()
        If CI2 = "scissors" AndAlso GVI2 = "scissors" Then
            Console.WriteLine("We have a tie!")
            ComWins = ComWins + 1
            PlayerWins = PlayerWins + 1
            Console.ReadKey()
            ScoreBoard1()
        Else
            scissorwincom()
        End If
    End Sub

    Sub scissorwincom()
        If CI2 = "scissors" AndAlso GVI2 = "paper" Then
            Console.WriteLine("The computer beat you using: Scissors!")
            ComWins = ComWins + 1
            Console.ReadKey()
            ScoreBoard1()
        Else
            scissorwinplayer()
        End If
    End Sub
    Sub scissorwinplayer()
        If CI2 = "paper" AndAlso GVI2 = "scissors" Then
            Console.WriteLine("You beat the computer using: Scissors!")
            PlayerWins = PlayerWins + 1
            Console.ReadKey()
            ScoreBoard1()
        End If
    End Sub

    Sub ScoreBoard1()
        Console.Clear()
        deterwin2()
        Console.WriteLine("|-----------------|-----------------------|-----------------------|----------------|----------------|")
        Console.WriteLine("|   ROUND NUMBER  |     COMPUTER PLAY     |       YOUR PLAY       |   PLAYER WINS  |  COMPUTER WINS |")
        Console.WriteLine("|-----------------|-----------------------|-----------------------|----------------|----------------|")

        If roundnumber = 1 Then
            Console.WriteLine($"|   ROUND ONE     |       {r1c}           |         {r1p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

        End If
        If roundnumber = 2 Then
            Console.WriteLine($"|   ROUND ONE     |       {r1c}           |         {r1p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND TWO     |       {r2c}           |         {r2p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")
        End If
        If roundnumber = 3 Then
            Console.WriteLine($"|   ROUND ONE     |       {r1c}           |         {r1p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND TWO     |       {r2c}           |         {r2p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND THREE   |       {r3c}           |         {r3p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")
        End If
        If roundnumber = 4 Then
            Console.WriteLine($"|   ROUND ONE     |       {r1c}           |         {r1p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND TWO     |       {r2c}           |         {r2p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND THREE   |       {r3c}           |         {r3p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND FOUR    |       {r4c}           |         {r4p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")
        End If
        If roundnumber = 5 Then
            Console.WriteLine($"|   ROUND ONE     |       {r1c}           |         {r1p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND TWO     |       {r2c}           |         {r2p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND THREE   |       {r3c}           |         {r3p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND FOUR    |       {r4c}           |         {r4p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")

            Console.WriteLine($"|   ROUND FIVE    |       {r5c}           |         {r5p}         |  {PlayerWins}  |    {ComWins}   |")
            Console.WriteLine($"|-----------------|-----------------------|-----------------------|----------------|----------------|")
        End If
        Console.ReadKey()
        gameover()
    End Sub

    Sub gameover()
        If roundnumber <> 5 Then
            Console.Clear()
            sg()
        ElseIf roundnumber >= 5 Then
            Console.Clear()
            Console.WriteLine("GAME OVER")
            Console.ReadKey()
        End If


    End Sub

    Sub ronecount()
        If roundnumber = 1 Then
            r1c = CI2
            r1p = GVI2
        ElseIf roundnumber > 1 Then
            rtwocount()
        End If
    End Sub

    Sub rtwocount()
        If roundnumber = 2 Then
            r2c = CI2
            r2p = GVI2
        ElseIf roundnumber > 2 Then
            rthreecount()
        End If
    End Sub

    Sub rthreecount()
        If roundnumber = 3 Then
            r3c = CI2
            r3p = GVI2
        ElseIf roundnumber > 3 Then
            rfourcount()
        End If
    End Sub

    Sub rfourcount()
        If roundnumber = 4 Then
            r4c = CI2
            r4p = GVI2
        ElseIf roundnumber > 4 Then
            rfivecount()
        End If
    End Sub
    Sub rfivecount()
        If roundnumber = 5 Then
            r5c = CI2
            r5p = GVI2
        End If
    End Sub

    Sub deterwin2()
        If roundnumber = 1 Then
            r1pw = PlayerWins And r1cw = ComWins
        ElseIf roundnumber = 2 Then
            r2pw = PlayerWins And r2cw = ComWins
        ElseIf roundnumber = 3 Then
            r3pw = PlayerWins And r3cw = ComWins
        ElseIf roundnumber = 4 Then
            r4pw = PlayerWins And r4cw = ComWins
        ElseIf roundnumber = 5 Then
            r5pw = PlayerWins And r5cw = ComWins
        End If
    End Sub
End Module
