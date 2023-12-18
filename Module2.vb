Module Module2
    Sub main()
        computermove()
    End Sub
    Sub computermove()
        Dim cominput As Integer
        cominput = Rnd() * 2


        Console.WriteLine($"Computer chose {cominput.ToString}")
        Console.ReadKey()
        main()
    End Sub
End Module
