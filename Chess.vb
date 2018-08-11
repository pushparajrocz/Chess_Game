Imports System
Imports System.IO
Module Module1
    '......................................global variables ......................................................
    Dim cast1 As Integer
    Dim cast2 As Integer
    Dim hoo As Integer
    Dim ree, s, s1 As Integer
    Dim war(6) As Integer
    Dim find As Integer
    Dim val1 As Integer
    Dim k As Integer
    Dim war1(6) As Integer
    Dim war2(6) As Integer
    Dim defeat1(16, 16) As Integer
    Dim defeat2(16, 16) As Integer
    Dim chess(20, 20) As Integer
    Dim pos1(2), pos2(2) As Integer
    Dim sol, r As Integer
    Dim ele As Integer
    Dim bis As Integer
    Dim hor As Integer
    Dim kin As Integer
    Dim ret1 As Integer
    Dim temp1(36) As Integer
    Dim temp2(36) As Integer
    Dim tem1(36) As Integer
    Dim tem2(36) As Integer
    Dim h As Integer
    Public Class openent1
        Public name As String
        Public Function check(ByVal p1 As Integer, ByVal p2 As Integer, ByVal chess(,) As Integer)
            If chess(p1, p2) > 10 And chess(p1, p2) < 18 Then
                Return 1
            Else
                Return 0
            End If
        End Function
    End Class
    Public Class openent2
        Public name As String
        Public Function check(ByVal p1 As Integer, ByVal p2 As Integer, ByVal chess(,) As Integer)
            If chess(p1, p2) > 20 And chess(p1, p2) < 28 Then
                Return 1
            Else
                Return 0
            End If
        End Function
    End Class
    Sub Main()
        Dim tim As Integer
        Dim surender As String
        surender = "no"
        Dim obj1 As New openent1
        Dim obj2 As New openent2 'player name get starts
        Dim player1, ret, player2, f1, f2, t1, t2, chek As Integer
        cast1 = 0
        cast2 = 0
        ret1 = 0
        pos1(0) = 1
        pos1(1) = 4
        pos2(0) = 8
        pos2(1) = 4
        '..................................................introduction...................................................................
        Console.Write(vbTab & vbTab & "! Welcome To Pushparaj Designed  --> CHESS GAME" & vbNewLine)
        Console.Write(vbNewLine & "NOTE :" & "This Chess Game Is Time Limited => Move Within The Time Limit <=" & vbNewLine)
        Console.Write("////////////////////////////////////////////////////////////////////////////////")
        Console.Write(vbNewLine & vbTab & "--------> By Default Time Limit is one Minute <--------- " & vbNewLine & " Enter Your Time Limit In Minutes :")
        tim = Console.ReadLine
        If Not (tim > 0 And tim < 59) Then
            tim = 1
        End If
        Console.Write(vbNewLine & "\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\")
        '..................................................players information...................................................................
        Console.Write(vbNewLine & vbNewLine & "Player 1 Can Enter Your Name  :")
        obj1.name = Console.ReadLine
        Console.Write(vbNewLine & "Player 2 Can Enter Your Name  :")
        obj2.name = Console.ReadLine 'ends
        '.......................................'initializing the positions of the warriors......................................................
        chess(1, 1) = 12
        chess(1, 2) = 13
        chess(1, 3) = 14
        chess(1, 4) = 15
        chess(1, 5) = 16
        chess(1, 6) = 14
        chess(1, 7) = 13
        chess(1, 8) = 12
        For i = 1 To 9
            chess(2, i) = 11
        Next i
        chess(8, 1) = 22
        chess(8, 2) = 23
        chess(8, 3) = 24
        chess(8, 4) = 25
        chess(8, 5) = 26
        chess(8, 6) = 24
        chess(8, 7) = 23
        chess(8, 8) = 22
        For i = 1 To 9
            chess(7, i) = 21
        Next i      'end of initializaition
        '.......................................time limit moving initialization......................................................
        Dim datee As DateTime
        Dim jjjj, kkk, kk, jj, reme, inc, jk As Integer
        Dim hr1, hr2 As Integer
        inc = 0
        '....................................game starts here..........................................................................
        Console.Write(vbNewLine & vbTab & vbTab & "Game Starts Now....")
        player1 = 1
        player2 = 0
        Console.Write(vbNewLine)
        '.......................................chess format printing...................................................................
        For k = 0 To 40
            Console.Write(vbNewLine & vbNewLine & vbTab & vbTab & vbTab & vbTab & "CHESS BOARD")
            Console.Write(vbNewLine & "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++")
            Console.WriteLine(vbNewLine & vbTab & "1        2       3       4        5       6       7     8" & vbNewLine & "       _____________________________________________________________" & vbNewLine)
            For i = 1 To 8 'positioning  the warriors in board.
                Console.Write(i & vbTab)
                For j = 1 To 8
                    Console.Write(chess(i, j) & "   |" & vbTab)
                Next j
                Console.Write(vbNewLine & "       _____________________________________________________________" & vbTab & vbNewLine & vbNewLine)
            Next i
            '...................................players moves and their exception.......................................................
            Console.Write(vbNewLine & "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++")
            'player 2
            '.......................................wanted surrender of the warriors....................................................
l:          If surender = "yes" Then 'surrender
                If player1 = 0 Then
                    Console.Write(vbNewLine & vbTab & vbTab & vbTab & obj1.name & " is the Winner Of The Game")
                Else
                    Console.Write(vbNewLine & vbTab & vbTab & vbTab & obj2.name & " is the Winner Of The Game ")
                End If
                Exit For
            End If
            '.......................................player 2 moves.......................................................................
            If player1 = 0 Then
                '..........................getting system time for time limit............................................................
                datee = Date.Now
                jj = datee.Second
                kk = jj
                kkk = datee.Minute
                jk = kkk
                hr1 = datee.Hour
                '.......................................checking check....................................................................
                ret1 = track(2)
                '.......................................used in checkmate function........................................................
                For i = 0 To 36
                    tem1(i) = temp1(i)
                    tem2(i) = temp2(i)
                Next i
                defend()    'check whether the defender while checkmate
                'if check then go for checkmate
                h = checkmate(pos2(0), pos2(1), 2)
                '.......................................if not checkmate or one check and any defenders...................................
                If (Not (h = 8) Or (hoo = 0 Or ret1 = 0)) Or (ret1 = 1 And k > 0) Then 'if not checkmate make a move
                    Console.Write(vbNewLine & vbTab & vbTab & vbTab & vbTab & obj2.name & " can move..")
                    Console.Write(vbNewLine & "################################################################################" & vbNewLine & "Start Time :")
                    Console.Write(datee.TimeOfDay)
                    Console.Write(vbNewLine & vbTab & vbTab & "(Exactly " & tim & " Minute To Move From The Time Given Above)" & vbNewLine)
                    Console.Write(vbNewLine & vbTab & vbTab & "Defeated Warriors ->>  ")
                    Console.Write("[")
                    For i = 0 To 16
                        For j = 0 To 16
                            If defeat2(i, j) > 0 Then
                                Console.Write(defeat2(i, j) & ",")
                            End If
                        Next j
                    Next i
                    Console.Write("]")
                    If ret1 > 0 Then
                        Console.Write(vbNewLine & vbNewLine & vbTab & vbTab & vbTab & " C!H!E!C!K !!! " & vbNewLine)
                    End If
                    '..........................timing limit loop for getting move from the user............................................
                    Console.Write(vbNewLine & vbNewLine & "From :")
                    f1 = Console.ReadLine
                    f2 = Console.ReadLine
                    Console.Write(vbNewLine & "To :")
                    t1 = Console.ReadLine
                    t2 = Console.ReadLine
                    datee = Date.Now
                    jj = datee.Second
                    jjjj = datee.Minute
                    hr2 = datee.Hour
                    '..........................timing limit get exceeded then jump to end of player 2........................................
                    reme = kkk + tim
                    If Not (hr1 = hr2) And kkk + tim >= 60 Then
                        reme = ((kkk + tim) - 60)
                    End If
                    If ((jj > kk And jjjj = reme) Or (jjjj > reme And hr1 = hr2) Or (jjjj > reme And kkk + tim >= 60) Or (Not (hr1 = hr2) And kkk + tim < 60)) Then
                        Console.Write("Time Taken To Move :")
                        If (jjjj - reme) = 0 Then
                            Console.Write(tim & " Min And " & (jj - kk) & " Sec")
                        Else
                            If Not (hr1 = hr2) Then
                                If (kkk + tim) >= 60 Then
                                    If jj > kk Then
                                        Console.Write(jjjj + (60 - jk) & " Min " & " And " & (jj - kk) & " Sec")
                                    Else
                                        Console.Write(jjjj + (60 - jk) - 1 & " Min " & " And " & (jj + (60 - kk)) & " Sec")
                                    End If
                                Else
                                    If jj > kk Then
                                        Console.Write((60 - jk) + jjjj & " Min " & " And " & (jj - kk) & " Sec")
                                    Else
                                        Console.Write((60 - jk) + jjjj - 1 & " Min " & " And " & (jj + (60 - kk)) & " Sec")
                                    End If
                                End If
                            Else
                                If jj > kk Then
                                    Console.Write(jjjj - jk & " Min " & " And " & (jj - kk) & " Sec")
                                Else
                                    Console.Write(jjjj - jk - 1 & " Min " & " And " & (jj + (60 - kk)) & " Sec")
                                End If
                            End If
                        End If
                        Console.Write(vbNewLine & "Sorry Time Limit Exceeded ...!" & vbTab & "End Time :")
                        Console.Write(datee.TimeOfDay)
                        GoTo l4
                        '..........................if user move within the time limit then procceed the operation.............................
                    Else
                        Console.Write(vbNewLine & vbNewLine & "################################################################################" & vbNewLine)
                        ret = obj2.check(f1, f2, chess)
                        If ret = 1 Then
                            chek = identify(f1, f2, t1, t2, chess)
                        Else
                            Console.WriteLine(vbNewLine & vbTab & "ACCESS DENIED !!")
                            GoTo l
                        End If
                        If chek = 1 Or sol = 1 Or hor = 1 Or ele = 1 Or bis = 1 Or kin = 1 Then 'exceptions
                            Console.Write(vbNewLine & vbNewLine & "Try Again !!")
                            If chek = 1 Then
                                Console.Write(vbNewLine & "Do You Want To Surrender ?  :")
                                surender = Console.ReadLine()
                            End If
                            chek = 0
                            sol = 0
                            hor = 0
                            ele = 0
                            bis = 0
                            kin = 0
                            GoTo l
                        End If
                        'player1 can move
l4:                     player1 = 1
                        player2 = 0
                        h = 0
                    End If
                Else 'if checkmate then stop the game
                    Console.Write(vbTab & vbTab & "!!!!C!!H!!!E!!C!!K!!M!!A!!T!!E..." & vbNewLine)
                    Console.Write(vbNewLine & vbTab & vbTab & obj1.name & " is the Winner Of The Game!!!!! ")
                    Exit For
                End If
            Else
                '..........................getting system time for time limit............................................................
                datee = Date.Now
                jj = datee.Second
                kk = jj
                kkk = datee.Minute
                jk = kkk
                hr1 = datee.Hour
                '.................................checking check........................................................................
                ret1 = track(1)
                '.......................................used in checkmate function......................................................
                For i = 0 To 36
                    tem1(i) = temp1(i)
                    tem2(i) = temp2(i)
                Next i
                defend() 'check whether the defender while checkmate
                'if check then go check for checkmate
                h = checkmate(pos1(0), pos1(1), 1)
                '.......................................if not checkmate or one check and any defenders.................................
                If (Not (h = 8) Or (hoo = 0 Or ret1 = 0)) Or (ret1 = 1 And k > 0) Then 'if not checkmate make a move
                    Console.Write(vbNewLine & vbTab & vbTab & vbTab & vbTab & obj1.name & "  can move ...")
                    Console.Write(vbNewLine & "********************************************************************************" & vbNewLine & "TIME :")
                    Console.Write(datee.TimeOfDay)
                    Console.Write(vbNewLine & vbTab & vbTab & "(Exactly " & tim & " Minute To Move From The Time Given Above)")
                    Console.Write(vbNewLine & vbNewLine & vbTab & vbTab & "Defeated Warriors ->>  ")
                    Console.Write("[")
                    For i = 0 To 16
                        For j = 0 To 16
                            If defeat1(i, j) > 0 Then
                                Console.Write(defeat1(i, j) & ",")
                            End If
                        Next j
                    Next i
                    Console.Write("]")
                    If ret1 > 0 Then
                        Console.Write(vbNewLine & vbNewLine & vbTab & vbTab & vbTab & vbTab & " C!H!E!C!K !!! " & vbNewLine)
                    End If
                    '..........................timing limit loop for getting move from the user............................................
                    Console.Write(vbNewLine & vbNewLine & "From :")
                    f1 = Console.ReadLine
                    f2 = Console.ReadLine
                    Console.Write(vbNewLine & "To :")
                    t1 = Console.ReadLine
                    t2 = Console.ReadLine
                    datee = Date.Now
                    jj = datee.Second
                    jjjj = datee.Minute
                    hr2 = datee.Hour
                    '..........................timing limit get exceeded then jump to end of player 2........................................
                    reme = kkk + tim
                    If Not (hr1 = hr2) And (kkk + tim) >= 60 Then
                        reme = ((kkk + tim) - 60)
                    End If
                    If ((jj > kk And jjjj = reme) Or (jjjj > reme And hr1 = hr2) Or (jjjj > reme And kkk + tim > 60) Or (Not (hr1 = hr2) And kkk + tim < 60)) Then
                        Console.Write("Time Taken To Move :")
                        If (jjjj - reme) = 0 Then
                            Console.Write(tim & " Min" & " And " & (jj - kk) & " Sec")
                        Else
                            If Not (hr1 = hr2) Then
                                If (kkk + tim) >= 60 Then
                                    If jj > kk Then
                                        Console.Write(jjjj + (60 - jk) & " Min " & " And " & (jj - kk) & " Sec")
                                    Else
                                        Console.Write(jjjj + (60 - jk) - 1 & " Min " & " And " & (jj + (60 - kk)) & " Sec")
                                    End If
                                Else
                                    If jj > kk Then
                                        Console.Write((60 - jk) + jjjj & " Min " & " And " & (jj - kk) & " Sec")
                                    Else
                                        Console.Write((60 - jk) + jjjj - 1 & " Min " & " And " & (jj + (60 - kk)) & " Sec")
                                    End If
                                End If
                            Else
                                If jj > kk Then
                                    Console.Write(jjjj - jk & " Min " & " And " & (jj - kk) & " Sec")
                                Else
                                    Console.Write(jjjj - jk - 1 & " Min " & " And " & (jj + (60 - kk)) & " Sec")
                                End If
                            End If
                        End If
                        Console.Write(vbNewLine & "Sorry Time Limit Exceeded ...!" & vbTab & "End Time :")
                        Console.Write(datee.TimeOfDay)
                        GoTo l44
                        '..........................if user move within the time limit then procceed the operation.............................
                    Else
                        Console.Write(vbNewLine & vbNewLine & "********************************************************************************" & vbNewLine)
                        ret = obj1.check(f1, f2, chess)
                        If ret = 1 Then
                            chek = identify(f1, f2, t1, t2, chess)
                        Else
                            Console.WriteLine(vbNewLine & "ACCESS DENIED  !!")
                            GoTo l
                        End If
                        If chek = 1 Or sol = 1 Or hor = 1 Or ele = 1 Or bis = 1 Or kin = 1 Then 'exception
                            Console.Write(vbNewLine & vbNewLine & "Try Again !!")
                            If chek = 1 Then
                                Console.Write(vbNewLine & "Do You Want To Surrender :")
                                surender = Console.ReadLine()
                            End If
                            chek = 0
                            sol = 0
                            hor = 0
                            ele = 0
                            bis = 0
                            kin = 0
                            GoTo l

                        End If
l44:                    player2 = 1
                        player1 = 0
                        h = 0
                    End If
                Else 'if checkmate stop the game
                    Console.Write(vbTab & vbTab & vbTab & "CHECKMATE !!!!C!!H!!!E!!C!!K!!M!!A!!T!!E..." & h & vbNewLine)
                    Console.Write(vbNewLine & vbTab & vbTab & vbTab & obj2.name & " is the WINNER Of The GAME!!!!! ")
                    Exit For
                End If
            End If
        Next k
        Console.ReadKey()
    End Sub
    Function identify(ByVal f1 As Integer, ByVal f2 As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal chess(,) As Integer)
        Dim checkmate As Integer = 0
        Dim i, j, r As Integer
        Dim yes As Integer = 0
        '..........................if user move is during check then warning is given which defender is rescue the king.......
        If (ret1 = 1 And k > 0) And (Not (chess(f1, f2) = 15) Or Not (chess(f1, f2) = 25)) Then
            Console.Write(vbTab & vbTab & vbTab & "WARNING......!" & vbNewLine)
            Console.Write(vbNewLine & vbTab & vbTab & vbTab & " C!H!E!C!K !!! " & vbNewLine)
            Console.Write(vbNewLine & "No Of Defenders You Have : " & ree & vbNewLine)
            Console.WriteLine("Name Of The Defenders :")
            For i = 0 To k - 1
                Console.Write(war(i) & vbNewLine)
                If chess(f1, f2) = war(i) And (war1(i) = f1 And war2(i) = f2) And (s = t1 And s1 = t2) Then
                    yes = 1
                End If
            Next i
        End If
        '..........................checking whether the move is which one of the warriors in the board........................
        Select Case chess(f1, f2)
            Case 11, 21
                If ret1 = 0 Or yes = 1 Then
                    solder(f1, f2, t1, t2, chess)
                Else
                    Console.Write(vbNewLine & "You Were Checked By " & ret1 & " Opponent Warriors -- >  Make Careful Move !")
                    checkmate = 1
                End If
            Case 12, 22
                If ret1 = 0 Or yes = 1 Then
                    elephant(f1, f2, t1, t2, chess)
                Else
                    Console.Write(vbNewLine & "You  Were Checked By " & ret1 & " Opponent Warriors -- > Make  Careful Move !")
                    checkmate = 1
                End If
            Case 15, 25
                If ((f1 = 1 And f2 = 4) And (t1 = 1 And t2 = 2)) Or ((f1 = 8 And f2 = 4) And (t1 = 8 And t2 = 2)) Then
                    r = casteling(f1, f2, t1, t2)
                    If r = 1 Then
                        kin = 1
                    End If
                Else
                    Dim kk As Integer
                    kk = 0
                    kk = king(f1, f2, t1, t2, chess)
                    If kk > 0 Then
                        Console.Write(vbNewLine & "This Move Makes Checked , Move Again  !")
                        checkmate = 1
                    End If
                End If
            Case 13, 23
                If ret1 = 0 Or yes = 1 Then
                    horse(f1, f2, t1, t2, chess)
                Else
                    Console.Write(vbNewLine & "You Were Checked By " & ret1 & " Opponent Warriors -- > Make Careful Move  !")
                    checkmate = 1
                End If
            Case 14, 24
                If ret1 = 0 Or yes = 1 Then
                    bishob(f1, f2, t1, t2, chess)
                Else
                    Console.Write(vbNewLine & "You Were Checked By " & ret1 & " Opponent Warriors -- > Make Careful Move  !")
                    checkmate = 1
                End If
            Case 16, 26
                If ret1 = 0 Or yes = 1 Then
                    queen(f1, f2, t1, t2, chess)
                Else
                    Console.Write(vbNewLine & "You Were Checked By " & ret1 & " Opponent Warriors -- > Make Careful Move  !")
                    checkmate = 1
                End If
        End Select
        Return checkmate
    End Function
    Sub solder(ByVal f1 As Integer, ByVal f2 As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal chess(,) As Integer)
        If ((t1 > 0 And t1 < 9) And (t2 > 0 And t2 < 9)) Then
            If chess(f1, f2) < 18 Then 'openent-1      
                If (t1 = f1 + 1 And t2 = f2) Or (f1 = 2 And t1 = 4 And t2 = f2) Then
                    If chess(t1, t2) = 0 Then
                        chess(t1, t2) = chess(f1, f2)
                        chess(f1, f2) = 0
                        If t1 = 8 Then
                            chess(t1, t2) = 16
                        End If
                    Else
                        sol = 1
                        Console.WriteLine(vbNewLine & "Wrong Move  !")
                    End If
                ElseIf (t1 = f1 + 1 And (t2 = f2 - 1 Or t2 = f2 + 1)) Then
                    If chess(t1, t2) > 18 Then
                        stack(t1, t2, 1)
                        chess(t1, t2) = chess(f1, f2)
                        chess(f1, f2) = 0
                        If t1 = 8 Then
                            chess(t1, t2) = 16
                        End If
                    Else
                        sol = 1
                        Console.WriteLine(vbNewLine & "Wrong  Move  !")
                    End If
                Else
                    sol = 1
                    Console.WriteLine(vbNewLine & "Invalid Move  !")
                End If
            Else
                If (t1 = f1 - 1 And t2 = f2) Or (f1 = 7 And t1 = 5 And t2 = f2) Then
                    If chess(t1, t2) = 0 Then
                        chess(t1, t2) = chess(f1, f2)
                        chess(f1, f2) = 0
                        If t1 = 1 Then
                            chess(t1, t2) = 26
                        End If
                    Else
                        sol = 1
                        Console.WriteLine(vbNewLine & "Wrong Move  !")
                    End If
                ElseIf (t1 = f1 - 1 And (t2 = f2 - 1 Or t2 = f2 + 1)) Then
                    If chess(t1, t2) > 0 And chess(t1, t2) < 18 Then
                        stack(t1, t2, 2)
                        chess(t1, t2) = chess(f1, f2)
                        chess(f1, f2) = 0
                        If t1 = 1 Then
                            chess(t1, t2) = 26
                        End If
                    Else
                        sol = 1
                        Console.WriteLine(vbNewLine & "Wrong  Move  !")
                    End If
                Else
                    sol = 1
                    Console.WriteLine(vbNewLine & "Invalid Move  !")
                End If
            End If
        Else
            sol = 1
            Console.Write(vbNewLine & "Out Of  Bound  !")
        End If
    End Sub
    Public Sub elephant(ByVal f1 As Integer, ByVal f2 As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal chess(,) As Integer)
        Dim ret As Integer
        If ((t1 > 0 And t1 < 9) And (t2 > 0 And t2 < 9)) Then
            If (t1 = f1 And (Not (t2 = f2))) Or (t2 = f2 And (Not (t1 = f1))) Then
                If chess(f1, f2) < 18 Then
                    If chess(t1, t2) > 18 Or chess(t1, t2) = 0 Then
                        ret = obstacle(f1, f2, t1, t2, chess)
                        If ret = 1 Then
                            If chess(t1, t2) > 18 Then
                                stack(t1, t2, 1)
                            End If
                            chess(t1, t2) = chess(f1, f2)
                            chess(f1, f2) = 0
                            If f1 = 1 And f2 = 1 Then
                                cast1 = 1
                            End If
                        End If
                    Else
                        ele = 1
                        Console.Write(vbNewLine & "Wrong Move  !")
                    End If
                Else
                    If chess(t1, t2) < 18 Or chess(t1, t2) = 0 Then
                        ret = obstacle(f1, f2, t1, t2, chess)
                        If ret = 1 Then
                            If chess(t1, t2) < 18 Then
                                stack(t1, t2, 2)
                            End If
                            chess(t1, t2) = chess(f1, f2)
                            chess(f1, f2) = 0
                            If f1 = 8 And f2 = 1 Then
                                cast2 = 1
                            End If
                        End If
                    Else
                        ele = 1
                        Console.Write(vbNewLine & "Wrong Move  !")
                    End If
                    End If
            Else
                    ele = 1
                    Console.Write(vbNewLine & "Invalid Move  !")
            End If
        Else
            ele = 1
            Console.Write(vbNewLine & "Out Of Bound  !")
        End If
    End Sub
    Function king(ByVal f1 As Integer, ByVal f2 As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal chess(,) As Integer)
        Dim p, ki As Integer
        p = 0
        ki = chess(f1, f2)
        If ((t1 > 0 And t1 < 9) And (t2 > 0 And t2 < 9)) Then
            If ((t1 = f1 - 1) And ((t2 = f2 - 1 Or t2 = f2 Or t2 = f2 + 1))) Or (((t1 = f1 + 1)) And ((t2 = f2 - 1 Or t2 = f2 Or t2 = f2 + 1))) Or (((t1 = f1)) And ((t2 = f2 - 1 Or t2 = f2 + 1))) Then
                If chess(f1, f2) < 18 Then
                    If chess(t1, t2) > 18 Or chess(t1, t2) = 0 Then
                        chess(f1, f2) = 0
                        p = status(t1, t2, 1)
                        chess(f1, f2) = ki
                        If p = 0 Then
                            If chess(t1, t2) > 18 And ret1 = 0 Then
                                stack(t1, t2, 1)
                            End If
                            chess(t1, t2) = chess(f1, f2)
                            pos1(0) = t1
                            pos1(1) = t2
                            chess(f1, f2) = 0
                            cast1 = 1
                        Else
                                Return 1
                        End If
                    Else
                        kin = 1
                        Console.WriteLine(vbNewLine & "Wrong Move  !")
                    End If
                Else
                    If chess(t1, t2) < 18 Or chess(t1, t2) = 0 Then
                        chess(f1, f2) = 0
                        p = status(t1, t2, 2)
                        chess(f1, f2) = ki
                        If p = 0 Then
                            If chess(t1, t2) < 18 And ret1 = 0 Then
                                stack(t1, t2, 2)
                            End If
                            chess(t1, t2) = chess(f1, f2)
                            pos2(0) = t1
                            pos2(1) = t2
                            chess(f1, f2) = 0
                            cast2 = 1
                        Else
                                Return 1
                        End If
                    Else
                        kin = 1
                        Console.WriteLine(vbNewLine & "Wrong Move  !")
                    End If
                End If
            Else
                kin = 1
                Console.WriteLine(vbNewLine & "Invalid Access  !")
            End If
        Else
            kin = 1
            Console.Write(vbNewLine & "Out Of Bound  !")
        End If
    End Function
    Sub horse(ByVal f1 As Integer, ByVal f2 As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal chess(,) As Integer)
        If ((t1 > 0 And t1 < 9) And (t2 > 0 And t2 < 9)) Then
            If (((t1 = f1 - 2) Or (t1 = f1 + 2)) And ((t2 = f2 - 1) Or (t2 = f2 + 1))) Or (((t1 = f1 - 1) Or (t1 = f1 + 1)) And ((t2 = f2 - 2) Or (t2 = f2 + 2))) Or (((t2 = f2 - 2) Or (t2 = f2 + 2)) And ((t1 = f1 - 1) Or (t1 = f1 + 1))) Or (((t2 = f2 - 1) Or (t2 = f2 + 1)) And ((t1 = f2 - 2) Or (t1 = f2 + 2))) Then
                If chess(f1, f2) < 18 Then
                    If chess(t1, t2) > 18 Or chess(t1, t2) = 0 Then
                        If chess(t1, t2) > 18 Then
                            stack(t1, t2, 1)
                        End If
                        chess(t1, t2) = chess(f1, f2)
                        chess(f1, f2) = 0
                    Else
                        hor = 1
                        Console.Write(vbNewLine & "Wrong Move  !")
                    End If
                Else
                    If chess(t1, t2) < 18 Or chess(t1, t2) = 0 Then
                        If chess(t1, t2) < 18 Then
                            stack(t1, t2, 2)
                        End If
                        chess(t1, t2) = chess(f1, f2)
                        chess(f1, f2) = 0
                    Else
                        hor = 1
                        Console.Write(vbNewLine & "Wrong Move  !")
                    End If
                End If
            Else
                hor = 1
                Console.Write(vbNewLine & "Invalid Move  !")
            End If
        Else
            hor = 1
            Console.Write(vbNewLine & "Out Of Bound  !")
        End If
    End Sub
    Public Sub bishob(ByVal f1 As Integer, ByVal f2 As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal chess(,) As Integer)
        Dim count, count1, i, ans As Integer
        If ((t1 > 0 And t1 < 9) And (t2 > 0 And t2 < 9)) Then
            Dim rb As Integer = diog(8 - f2, 8 - f1)
            Dim lt As Integer = diog(f2 - 1, f1 - 1)
            Dim rt As Integer = diog(8 - f2, f1 - 1)
            Dim lb As Integer = diog(f2 - 1, 8 - f1)
            count = 0
            count1 = 0
            ans = 1
            i = 1
            While (i < rb + 1)
                If ans = 1 Then
                    If (t1 = f1 + i) And (t2 = f2 + i) Then
                        count = 1
                        rb = (i - 1)
                        i = 0
                        ans = 0
                    End If
                Else
                    If chess(f1 + i, f2 + i) > 0 Then
                        count1 = 1
                        Exit While
                    End If
                End If
                i += 1
            End While
            i = 1
            If ans = 1 Then
                While (i < lt + 1)
                    If ans = 1 Then
                        If (t1 = f1 - i And t2 = f2 - i) Then
                            count = 1
                            lt = (i - 1)
                            i = 0
                            ans = 0
                        End If
                    Else
                        If chess(f1 - i, f2 - i) > 0 Then
                            count1 = 1
                            Exit While
                        End If
                    End If
                    i += 1
                End While
            End If
            i = 1
            If ans = 1 Then
                While (i < rt + 1)
                    If ans = 1 Then
                        If (t1 = f1 - i And t2 = f2 + i) Then
                            count = 1
                            rt = (i - 1)
                            i = 0
                            ans = 0
                        End If
                    Else
                        If chess(f1 - i, f2 + i) > 0 Then
                            count1 = 1
                            Exit While
                        End If
                    End If
                    i += 1
                End While
            End If
            i = 1
            If ans = 1 Then
                While (i < lb + 1)
                    If ans = 1 Then
                        If (t1 = f1 + i And t2 = f2 - i) Then
                            count = 1
                            lb = (i - 1)
                            i = 0
                            ans = 0
                        End If
                    Else
                        If chess(f1 + i, f2 - i) > 0 Then
                            count1 = 1
                            Exit While
                        End If
                    End If
                    i += 1
                End While
            End If
            If count = 0 Then
                bis = 1
                Console.Write(vbNewLine & "Invalid Move  !")
            Else
                If chess(f1, f2) < 18 Then
                    If chess(t1, t2) > 18 Or chess(t1, t2) = 0 Then
                        If count1 = 1 Then
                            bis = 1
                            Console.Write(vbNewLine & "Can't Move  !")
                        Else
                            If chess(t1, t2) > 18 Then
                                stack(t1, t2, 1)
                            End If
                            chess(t1, t2) = chess(f1, f2)
                            chess(f1, f2) = 0
                        End If
                    Else
                        bis = 1
                        Console.Write(vbNewLine & "Wrong Move  !")
                    End If
                Else
                    If chess(t1, t2) < 18 Or chess(t1, t2) = 0 Then
                        If count1 = 1 Then
                            bis = 1
                            Console.Write(vbNewLine & "Can't Move  !")
                            count1 = 0
                        Else
                            If chess(t1, t2) < 18 Then
                                stack(t1, t2, 2)
                            End If
                            chess(t1, t2) = chess(f1, f2)
                            chess(f1, f2) = 0
                        End If
                    Else
                        bis = 1
                        Console.Write(vbNewLine & "Wrong Move  !")
                    End If
                End If
            End If
        Else
            bis = 1
            Console.Write(vbNewLine & "Out Of Bound  !")
        End If
    End Sub
    Function diog(ByVal a, ByVal b)
        If a > b Then
            Return b
        Else
            Return a
        End If
    End Function
    '......................................checking whether any obstacle for moving elephant and queen and bishob..........................
    Function obstacle(ByVal f1 As Integer, ByVal f2 As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal chess(,) As Integer)
        Dim i, a As Integer
        a = 1
        Select Case chess(f1, f2)
            Case 12, 22
                If t1 = f1 Then
                    i = f2
                    While (i < t2 - 1 Or i > t2 + 1)
                        If f2 < t2 Then
                            i += 1
                        Else
                            i -= 1
                        End If
                        If chess(f1, i) > 0 Then
                            ele = 1
                            Console.Write(vbNewLine & "Can't Move   !")
                            a = 0
                            Exit While
                        End If
                    End While
                ElseIf t2 = f2 Then
                    i = f1
                    While (i < t1 - 1 Or i > t1 + 1)
                        If f1 < t1 Then
                            i += 1
                        Else
                            i -= 1
                        End If
                        If chess(i, f2) > 0 Then
                            ele = 1
                            Console.Write(vbNewLine & "Can't Move   !")
                            a = 0
                            Exit While
                        End If
                    End While
                End If
        End Select
        Return a
    End Function
    Public Sub queen(ByVal f1 As Integer, ByVal f2 As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal chess(,) As Integer)
        If t1 = f1 Or t2 = f2 Then
            elephant(f1, f2, t1, t2, chess)
        Else
            bishob(f1, f2, t1, t2, chess)
        End If
    End Sub
    '......................................storing the defeated warriors in the stack......................................................
    Sub stack(ByVal ff1, ByVal ff2, ByVal choice)
        Dim i, j As Integer
        For i = 0 To 16
            For j = 0 To 16
                If choice = 1 Then
                    If defeat1(i, j) = 0 Then
                        defeat1(i, j) = chess(ff1, ff2)
                        Exit Sub
                    End If
                Else
                    If defeat2(i, j) = 0 Then
                        defeat2(i, j) = chess(ff1, ff2)
                        Exit Sub
                    End If
                End If
            Next j
        Next i
    End Sub
    '......................................tracking the king for check and checkmate ......................................................
    Function track(ByVal val)
        Dim r As Integer
        If val = 1 Then
            If chess(pos1(0), pos1(1)) = 15 Then
                r = status(pos1(0), pos1(1), 1)
            End If
        Else
            If chess(pos2(0), pos2(1)) = 25 Then
                r = status(pos2(0), pos2(1), 2)
            End If
        End If
        Return r
    End Function
    '......................................tracking the king for check and checkmate ......................................................
    Function status(ByVal pos, ByVal pos1, ByVal val)
        Dim i, ans, j, m, mm, a As Integer
        For i = 0 To 36
            temp1(i) = 0
            temp2(i) = 0
        Next i
        a = 8
        ans = 0
        'side
        If val = 1 Then
            If (pos + 1 > 0 And pos + 1 < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
                If chess(pos + 1, pos1 - 1) = 21 Then
                    temp1(4) = pos + 1
                    temp2(4) = pos1 - 1
                    ans += 1
                End If

            End If
            If (pos + 1 > 0 And pos + 1 < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
                If chess(pos + 1, pos1 + 1) = 21 Then
                    temp1(6) = pos + 1
                    temp2(6) = pos1 + 1
                    ans += 1
                End If
            End If
        Else
            If (pos - 1 > 0 And pos - 1 < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
                If chess(pos - 1, pos1 + 1) = 11 Then
                    temp1(9) = pos - 1
                    temp2(9) = pos1 + 1
                    ans += 1
                End If
            End If
            If (pos - 1 > 0 And pos - 1 < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
                If chess(pos - 1, pos1 - 1) = 11 Then
                    temp1(11) = pos - 1
                    temp2(11) = pos1 - 1
                    ans += 1
                End If
            End If
        End If
        'king
        If (pos > 0 And pos < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
            If (val = 1 And chess(pos, pos1 - 1) = 25) Or (val = 2 And chess(pos, pos1 - 1) = 15) Then
                ans += 1
            End If
        End If
        If (pos > 0 And pos < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
            If (val = 1 And chess(pos, pos1 + 1) = 25) Or (val = 2 And chess(pos, pos1 + 1) = 15) Then
                ans += 1
            End If
        End If
        If (pos - 1 > 0 And pos - 1 < 9) And (pos1 > 0 And pos1 < 9) Then
            If (val = 1 And chess(pos - 1, pos1) = 25) Or (val = 2 And chess(pos - 1, pos1) = 15) Then
                ans += 1
            End If
        End If
        If (pos + 1 > 0 And pos + 1 < 9) And (pos1 > 0 And pos1 < 9) Then
            If (val = 1 And chess(pos + 1, pos1) = 25) Or (val = 2 And chess(pos + 1, pos1) = 15) Then
                ans += 1
            End If
        End If

        If (pos + 1 > 0 And pos + 1 < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
            If (val = 1 And chess(pos + 1, pos1 + 1) = 25) Or (val = 2 And chess(pos + 1, pos1 + 1) = 15) Then
                ans += 1
            End If
        End If
        If (pos - 1 > 0 And pos - 1 < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
            If (val = 1 And chess(pos - 1, pos1 - 1) = 25) Or (val = 2 And chess(pos - 1, pos1 - 1) = 15) Then
                ans += 1
            End If
        End If
        If (pos + 1 > 0 And pos + 1 < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
            If (val = 1 And chess(pos + 1, pos1 - 1) = 25) Or (val = 2 And chess(pos + 1, pos1 - 1) = 15) Then
                ans += 1
            End If
        End If
        If (pos - 1 > 0 And pos - 1 < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
            If (val = 1 And chess(pos - 1, pos1 + 1) = 25) Or (val = 2 And chess(pos - 1, pos1 + 1) = 15) Then
                ans += 1
            End If
        End If
        'horizontal
        i = pos
        j = pos1 + 1
        While ((j < 9 And j > 0) Or j = 9)
            If j < 9 Then
                If val = 1 Then
                    If chess(i, j) > 0 Then
                        If chess(i, j) = 22 Or chess(i, j) = 26 Then
                            temp1(0) = i
                            temp2(0) = j
                            ans += 1
                            Exit While
                        Else
                            If j > pos1 Then
                                j = 8
                            Else
                                Exit While
                            End If
                        End If
                    End If
                Else
                    If chess(i, j) > 0 Then
                        If chess(i, j) = 12 Or chess(i, j) = 16 Then
                            temp1(1) = i
                            temp2(1) = j
                            ans += 1
                            Exit While
                        Else
                            If j > pos1 Then
                                j = 8
                            Else
                                Exit While
                            End If
                        End If
                    End If
                End If
            End If
            If j = 8 Or j = 9 Then
                j = pos1
            End If
            If j > pos1 Then
                j += 1
            Else
                j -= 1
            End If
        End While
        a = 8
        'vertical
        i = pos + 1
        j = pos1
        While ((i < 9 And i > 0) Or i = 9)
            If i < 9 Then
                If val = 1 Then
                    If chess(i, j) > 0 Then
                        If chess(i, j) = 22 Or chess(i, j) = 26 Then
                            temp1(2) = i
                            temp2(2) = j
                            ans += 1
                            Exit While
                        Else
                            If i > pos Then
                                i = 8
                            Else
                                Exit While
                            End If
                        End If
                    End If
                Else
                    If chess(i, j) > 0 Then
                        If chess(i, j) = 12 Or chess(i, j) = 16 Then
                            temp1(3) = i
                            temp2(3) = j
                            ans += 1
                            Exit While
                        Else
                            If i > pos Then
                                i = 8
                            Else
                                Exit While
                            End If
                        End If
                    End If
                End If
            End If
            If i = 8 Or i = 9 Then
                i = pos
            End If
            If i > pos Then
                i += 1
            Else
                i -= 1
            End If
        End While
        'l-shape
        If val = 1 Then
            If (pos + 2 > 0 And pos + 2 < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
                If chess(pos + 2, pos1 - 1) = 23 Then
                    temp1(12) = pos + 2
                    temp2(12) = pos1 - 1
                    ans += 1
                End If
            End If
            If (pos + 2 > 0 And pos + 2 < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
                If chess(pos + 2, pos1 + 1) = 23 Then
                    temp1(13) = pos + 2
                    temp2(13) = pos1 + 1
                    ans += 1
                End If
            End If
            If (pos - 2 > 0 And pos - 2 < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
                If chess(pos - 2, pos1 - 1) = 23 Then
                    temp1(14) = pos - 2
                    temp2(14) = pos1 - 1
                    ans += 1
                End If
            End If
            If (pos - 2 > 0 And pos - 2 < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
                If chess(pos - 2, pos1 + 1) = 23 Then
                    temp1(15) = pos - 2
                    temp2(15) = pos1 + 1
                    ans += 1
                End If
            End If
            If (pos + 1 > 0 And pos + 1 < 9) And (pos1 - 2 > 0 And pos1 - 2 < 9) Then
                If chess(pos + 1, pos1 - 2) = 23 Then
                    temp1(16) = pos + 1
                    temp2(16) = pos1 - 2
                    ans += 1
                End If
            End If
            If (pos + 1 > 0 And pos + 1 < 9) And (pos1 + 2 > 0 And pos1 + 2 < 9) Then
                If chess(pos + 1, pos1 + 2) = 23 Then
                    temp1(17) = pos + 1
                    temp2(17) = pos1 + 2
                    ans += 1
                End If
            End If
            If (pos - 1 > 0 And pos - 1 < 9) And (pos1 - 2 > 0 And pos1 - 2 < 9) Then
                If chess(pos - 1, pos1 - 2) = 23 Then
                    temp1(18) = pos - 1
                    temp2(18) = pos1 - 2
                    ans += 1
                End If
            End If
            If (pos - 1 > 0 And pos - 1 < 9) And (pos1 + 2 > 0 And pos1 + 2 < 9) Then
                If chess(pos - 1, pos1 + 2) = 23 Then
                    temp1(19) = pos - 1
                    temp2(19) = pos1 + 2
                    ans += 1
                End If
            End If
        Else
            If (pos + 2 > 0 And pos + 2 < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
                If chess(pos + 2, pos1 - 1) = 13 Then
                    temp1(20) = pos + 2
                    temp2(20) = pos1 - 1
                    ans += 1
                End If
            End If
            If (pos + 2 > 0 And pos + 2 < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
                If chess(pos + 2, pos1 + 1) = 13 Then
                    temp1(21) = pos + 2
                    temp2(21) = pos1 + 1
                    ans += 1
                End If
            End If
            If (pos - 2 > 0 And pos - 2 < 9) And (pos1 - 1 > 0 And pos1 - 1 < 9) Then
                If chess(pos - 2, pos1 - 1) = 13 Then
                    temp1(22) = pos - 2
                    temp2(22) = pos1 - 1
                    ans += 1
                End If
            End If
            If (pos - 2 > 0 And pos - 2 < 9) And (pos1 + 1 > 0 And pos1 + 1 < 9) Then
                If chess(pos - 2, pos1 + 1) = 13 Then
                    temp1(23) = pos - 2
                    temp2(23) = pos1 + 1
                    ans += 1
                End If
            End If
            If (pos + 1 > 0 And pos + 1 < 9) And (pos1 - 2 > 0 And pos1 - 2 < 9) Then
                If chess(pos + 1, pos1 - 2) = 13 Then
                    temp1(24) = pos + 1
                    temp2(24) = pos1 - 2
                    ans += 1
                End If
            End If
            If (pos + 1 > 0 And pos + 1 < 9) And (pos1 + 2 > 0 And pos1 + 2 < 9) Then
                If chess(pos + 1, pos1 + 2) = 13 Then
                    temp1(25) = pos + 1
                    temp2(25) = pos1 + 2
                    ans += 1
                End If
            End If
            If (pos - 1 > 0 And pos - 1 < 9) And (pos1 - 2 > 0 And pos1 - 2 < 9) Then
                If chess(pos - 1, pos1 - 2) = 13 Then
                    temp1(26) = pos - 1
                    temp2(26) = pos1 - 2
                    ans += 1
                End If
            End If
            If (pos - 1 > 0 And pos - 1 < 9) And (pos1 + 2 > 0 And pos1 + 2 < 9) Then
                If chess(pos - 1, pos1 + 2) = 13 Then
                    temp1(27) = pos - 1
                    temp2(27) = pos1 + 2
                    ans += 1
                End If
            End If
        End If
        'diagonal
        If val = 1 Then
            m = pos
            mm = pos1
            While ((m > 0 And m < 9) And (mm > 0 And mm < 9))
                If chess(m + 1, mm - 1) > 0 Then
                    If chess(m + 1, mm - 1) = 24 Or chess(m + 1, mm - 1) = 26 Then
                        temp1(28) = m + 1
                        temp2(28) = mm - 1
                        ans += 1
                        Exit While
                    Else
                        Exit While
                    End If
                Else
                    m += 1
                    mm -= 1
                End If
            End While
            m = pos
            mm = pos1
            While ((m > 0 And m < 9) And (mm > 0 And mm < 9))
                If chess(m - 1, mm + 1) > 0 Then
                    If chess(m - 1, mm + 1) = 24 Or chess(m - 1, mm + 1) = 26 Then
                        temp1(29) = m - 1
                        temp2(29) = mm + 1
                        ans += 1
                        Exit While
                    Else
                        Exit While
                    End If
                Else
                    m -= 1
                    mm += 1
                End If
            End While
            m = pos
            mm = pos1
            While ((m > 0 And m < 9) And (mm > 0 And mm < 9))
                If chess(m + 1, mm + 1) > 0 Then
                    If chess(m + 1, mm + 1) = 24 Or chess(m + 1, mm + 1) = 26 Then
                        temp1(30) = m + 1
                        temp2(30) = mm + 1
                        ans += 1
                        Exit While
                    Else
                        Exit While
                    End If
                Else
                    m += 1
                    mm += 1
                End If
            End While
            m = pos
            mm = pos1
            While ((m > 0 And m < 9) And (mm > 0 And mm < 9))
                If chess(m - 1, mm - 1) > 0 Then
                    If chess(m - 1, mm - 1) = 24 Or chess(m - 1, mm - 1) = 26 Then
                        temp1(31) = m - 1
                        temp2(31) = mm - 1
                        ans += 1
                        Exit While
                    Else
                        Exit While
                    End If
                Else
                    m -= 1
                    mm -= 1
                End If
            End While
        Else
            m = pos
            mm = pos1
            While ((m > 0 And m < 9) And (mm > 0 And mm < 9))
                If chess(m + 1, mm - 1) > 0 Then
                    If chess(m + 1, mm - 1) = 14 Or chess(m + 1, mm - 1) = 16 Then
                        temp1(32) = m + 1
                        temp2(32) = mm - 1
                        ans += 1
                        Exit While
                    Else
                        Exit While
                    End If
                Else
                    m += 1
                    mm -= 1
                End If
            End While
            m = pos
            mm = pos1
            While ((m > 0 And m < 9) And (mm > 0 And mm < 9))
                If chess(m - 1, mm + 1) > 0 Then
                    If chess(m - 1, mm + 1) = 14 Or chess(m - 1, mm + 1) = 16 Then
                        temp1(33) = m - 1
                        temp2(33) = mm + 1
                        ans += 1
                        Exit While
                    Else
                        Exit While
                    End If
                Else
                    m -= 1
                    mm += 1
                End If
            End While
            m = pos
            mm = pos1
            While ((m > 0 And m < 9) And (mm > 0 And mm < 9))
                If chess(m + 1, mm + 1) > 0 Then
                    If chess(m + 1, mm + 1) = 14 Or chess(m + 1, mm + 1) = 16 Then
                        temp1(34) = m + 1
                        temp2(34) = mm + 1
                        ans += 1
                        Exit While
                    Else
                        Exit While
                    End If
                Else
                    m += 1
                    mm += 1
                End If
            End While
            m = pos
            mm = pos1
            While ((m > 0 And m < 9) And (mm > 0 And mm < 9))
                If chess(m - 1, mm - 1) > 0 Then
                    If chess(m - 1, mm - 1) = 14 Or chess(m - 1, mm - 1) = 16 Then
                        temp1(35) = m - 1
                        temp2(35) = mm - 1
                        ans += 1
                        Exit While
                    Else
                        Exit While
                    End If
                Else
                    m -= 1
                    mm -= 1
                End If
            End While
        End If
        Return ans
    End Function
    '......................................checking checkmate for the king.................................................................
    Function checkmate(ByVal pos, ByVal pos1, ByVal val)
        Dim i, j As Integer
        Dim ki As Integer
        j = 0
        i = 0
        hoo = 0
        ki = chess(pos, pos1)
        If chess(pos + 1, pos1 + 1) > -1 And (pos + 1 > 0 And pos + 1 < 9 And pos1 + 1 > 0 And pos1 + 1 < 9) And ((val = 1 And chess(pos + 1, pos1 + 1) > 18) Or (val = 2 And chess(pos + 1, pos1 + 1) < 18)) Then
            chess(pos, pos1) = 0
            i = status(pos + 1, pos1 + 1, val)
            chess(pos, pos1) = ki
        End If

        If i > 0 Or chess(pos + 1, pos1 + 1) > 0 Or (pos + 1 < 1 Or pos + 1 > 8 Or pos1 + 1 < 1 Or pos1 + 1 > 8) Then
            If i > 0 Then
                j += 1
                hoo += 1
            ElseIf chess(pos + 1, pos1 + 1) > 0 Then
                If val = 1 And ((chess(pos + 1, pos1 + 1) < 18)) Then
                    j += 1
                End If
                If val = 2 And ((chess(pos + 1, pos1 + 1) > 18)) Then
                    j += 1
                End If
            Else
                j += 1
            End If
        End If
        If chess(pos - 1, pos1 - 1) > -1 And (pos - 1 > 0 And pos - 1 < 9 And pos1 - 1 > 0 And pos1 - 1 < 9) And ((val = 1 And chess(pos - 1, pos1 - 1) > 18) Or (val = 2 And chess(pos - 1, pos1 - 1) < 18)) Then
            chess(pos, pos1) = 0
            i = status(pos - 1, pos1 - 1, val)
            chess(pos, pos1) = ki
        End If

        If i > 0 Or chess(pos - 1, pos1 - 1) > 0 Or (pos - 1 < 1 Or pos - 1 > 8 Or pos1 - 1 < 1 Or pos1 - 1 > 8) Then
            If i > 0 Then
                j += 1
                hoo += 1
            ElseIf chess(pos - 1, pos1 - 1) > 0 Then
                If val = 1 And ((chess(pos - 1, pos1 - 1) < 18)) Then
                    j += 1
                End If
                If val = 2 And ((chess(pos - 1, pos1 - 1) > 18)) Then
                    j += 1
                End If
            Else
                j += 1
            End If
        End If
        If chess(pos - 1, pos1 + 1) > -1 And (pos - 1 > 0 And pos - 1 < 9 And pos1 + 1 > 0 And pos1 + 1 < 9) Then
            chess(pos, pos1) = 0
            i = status(pos - 1, pos1 + 1, val)
            chess(pos, pos1) = ki
        End If

        If i > 0 Or chess(pos - 1, pos1 + 1) > 0 Or (pos - 1 < 1 Or pos - 1 > 8 Or pos1 + 1 < 1 Or pos1 + 1 > 8) And ((val = 1 And chess(pos - 1, pos1 + 1) > 18) Or (val = 2 And chess(pos - 1, pos1 + 1) < 18)) Then
            If i > 0 Then
                j += 1
                hoo += 1
            ElseIf chess(pos - 1, pos1 + 1) > 0 Then
                If val = 1 And ((chess(pos - 1, pos1 + 1) < 18)) Then
                    j += 1
                End If
                If val = 2 And ((chess(pos - 1, pos1 + 1) > 18)) Then
                    j += 1
                End If
            Else
                j += 1
            End If
        End If
        If chess(pos + 1, pos1 - 1) > -1 And (pos + 1 > 0 And pos + 1 < 9 And pos1 - 1 > 0 And pos1 - 1 < 9) And ((val = 1 And chess(pos + 1, pos1 - 1) > 18) Or (val = 2 And chess(pos + 1, pos1 - 1) < 18)) Then
            chess(pos, pos1) = 0
            i = status(pos + 1, pos1 - 1, val)
            chess(pos, pos1) = ki
        End If

        If i > 0 Or chess(pos + 1, pos1 - 1) > 0 Or (pos + 1 < 1 Or pos + 1 > 8 Or pos1 - 1 < 1 Or pos1 - 1 > 8) Then
            If i > 0 Then
                j += 1
                hoo += 1
            ElseIf chess(pos + 1, pos1 - 1) > 0 Then
                If val = 1 And ((chess(pos + 1, pos1 - 1) < 18)) Then
                    j += 1
                End If
                If val = 2 And ((chess(pos + 1, pos1 - 1) > 18)) Then
                    j += 1
                End If
            Else
                j += 1
            End If
        End If
        If chess(pos - 1, pos1) > -1 And (pos - 1 > 0 And pos - 1 < 9 And pos1 > 0 And pos1 < 9) And ((val = 1 And chess(pos - 1, pos1) > 18) Or (val = 2 And chess(pos - 1, pos1) < 18)) Then
            chess(pos, pos1) = 0
            i = status(pos - 1, pos1, val)
            chess(pos, pos1) = ki
        End If

        If i > 0 Or chess(pos - 1, pos1) > 0 Or (pos - 1 < 1 Or pos - 1 > 8 Or pos1 < 1 Or pos1 > 8) Then
            If i > 0 Then
                j += 1
                hoo += 1
            ElseIf chess(pos - 1, pos1) > 0 Then
                If val = 1 And ((chess(pos - 1, pos1) < 18)) Then
                    j += 1
                End If
                If val = 2 And ((chess(pos - 1, pos1) > 18)) Then
                    j += 1
                End If
            Else
                j += 1
            End If
        End If
        If chess(pos + 1, pos1) > -1 And (pos + 1 > 0 And pos + 1 < 9 And pos1 > 0 And pos1 < 9) And ((val = 1 And chess(pos + 1, pos1) > 18) Or (val = 2 And chess(pos + 1, pos1) < 18)) Then
            chess(pos, pos1) = 0
            i = status(pos + 1, pos1, val)
            chess(pos, pos1) = ki
        End If

        If i > 0 Or chess(pos + 1, pos1) > 0 Or (pos + 1 < 1 Or pos + 1 > 8 Or pos1 < 1 Or pos1 > 8) Then
            If i > 0 Then
                j += 1
                hoo += 1
            ElseIf chess(pos + 1, pos1) > 0 Then
                If val = 1 And ((chess(pos + 1, pos1) < 18)) Then
                    j += 1
                End If
                If val = 2 And ((chess(pos + 1, pos1) > 18)) Then
                    j += 1
                End If
            Else
                j += 1
            End If
        End If
        If chess(pos, pos1 + 1) > -1 And (pos > 0 And pos < 9 And pos1 + 1 > 0 And pos1 + 1 < 9) And ((val = 1 And chess(pos, pos1 + 1) > 18) Or (val = 2 And chess(pos, pos1 + 1) < 18)) Then
            chess(pos, pos1) = 0
            i = status(pos, pos1 + 1, val)
            chess(pos, pos1) = ki
        End If

        If i > 0 Or chess(pos, pos1 + 1) > 0 Or (pos < 1 Or pos > 8 Or pos1 + 1 < 1 Or pos1 + 1 > 8) Then
            If i > 0 Then
                j += 1
                hoo += 1
            ElseIf chess(pos, pos1 + 1) > 0 Then
                If val = 1 And ((chess(pos, pos1 + 1) < 18)) Then
                    j += 1
                End If
                If val = 2 And ((chess(pos, pos1 + 1) > 18)) Then
                    j += 1
                End If
            Else
                j += 1
            End If
        End If

        If chess(pos, pos1 - 1) > -1 And (pos > 0 And pos < 9 And pos1 - 1 > 0 And pos1 - 1 < 9) And ((val = 1 And chess(pos, pos1 - 1) > 18) Or (val = 2 And chess(pos, pos1 - 1) < 18)) Then
            chess(pos, pos1) = 0
            i = status(pos, pos1 - 1, val)
            chess(pos, pos1) = ki
        End If
        If i > 0 Or chess(pos, pos1 - 1) > 0 Or (pos < 1 Or pos > 8 Or pos1 - 1 < 1 Or pos1 - 1 > 8) Then
            If i > 0 Then
                j += 1
                hoo += 1
            ElseIf chess(pos, pos1 - 1) > 0 Then
                If val = 1 And ((chess(pos, pos1 - 1) < 18)) Then
                    j += 1
                End If
                If val = 2 And ((chess(pos, pos1 - 1) > 18)) Then
                    j += 1
                End If
            Else
                j += 1
            End If
        End If
        Return j
    End Function
    '......................................check for defender while checkmate..............................................................
    Function defend()
        val1 = 0
        find = 0
        ree = 0
        val1 = 0
        k = 0
        If ret1 = 1 Then
            For i = 0 To 36
                If (temp1(i) > 0 And temp1(i) < 9) And (temp2(i) > 0 And temp2(i) < 9) Then
                    find = i
                    s = temp1(i)
                    s1 = temp2(i)
                    If chess(temp1(find), temp2(find)) < 17 Then
                        val1 = 1
                    Else
                        val1 = 2
                    End If
                    Exit For
                End If
            Next i
            ree = status(temp1(find), temp2(find), val1)
            For i = 0 To 36
                If (temp1(i) > 0 And temp1(i) < 9) And (temp2(i) > 0 And temp2(i) < 9) Then
                    war1(k) = temp1(i)
                    war2(k) = temp2(i)
                    war(k) = chess(temp1(i), temp2(i))
                    k += 1
                End If
            Next i
        End If
        Return k
    End Function
    Function casteling(ByVal f As Integer, ByVal f1 As Integer, ByVal t As Integer, ByVal t1 As Integer)
        If chess(f, f1) < 18 Then
            If chess(1, 1) = 12 And chess(t, t1) = 0 And chess(1, 3) = 0 And cast1 = 0 Then
                chess(t, t1) = chess(f, f1)
                chess(f, f1) = 0
                chess(t, t1 + 1) = chess(1, 1)
                chess(1, 1) = 0
                pos1(0) = t
                pos1(1) = t1
            Else
                Console.Write("Castelling Cant Be Done !")
                Return 1
            End If
        Else
            If chess(8, 1) = 22 And chess(t, t1) = 0 And chess(8, 3) = 0 And cast2 = 0 Then
                chess(t, t1) = chess(f, f1)
                chess(f, f1) = 0
                chess(t, t1 + 1) = chess(8, 1)
                chess(8, 1) = 0
                pos2(0) = t
                pos2(1) = t1
            Else
                Console.Write("Castelling Cant Be Done !")
                Return 1
            End If
        End If
        Return 0
    End Function
End Module




