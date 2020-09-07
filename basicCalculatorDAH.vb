
'Tim Rossiter
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/harmdavi/basicCalculatorDAH.git

Option Strict On
Option Explicit On
Option Compare Text


Module basicCalculatorDAH

    Sub Main()
        Dim firstNumber As String
        Dim work1 As Decimal
        Dim work2 As Decimal
        Dim secondNumber As String
        Dim operation As String
        Dim userInput As String
        Dim badData As Boolean
        Dim result As Decimal

        'This is just a into screen. it will not appear again in the calculator 
        Console.WriteLine("This is a basic Calculator. _ 
if at any time you would like to quit the calculator, press q ")

        userInput = Console.ReadLine
        If userInput = "q" Then
            Console.WriteLine("have a happy shopping! Please press Enter to exit")
            Console.ReadLine()
            Exit Sub
        End If

        Do

            Console.Clear()


            Do
                Console.WriteLine("Please enter a nubmer you wish to calculate")
                Try
                    firstNumber = Console.ReadLine()
                    If firstNumber = "q" Then
                        Console.WriteLine("have a happy shopping! Please press Enter to exit")
                        Console.ReadLine()
                        Exit Sub
                    End If
                    work1 = CDec(firstNumber)

                    Console.WriteLine("now select an operator:" & vbNewLine _
                              & "+ press 1" & vbNewLine & "- press 2" & vbNewLine & "quit press quit")
                    operation = Console.ReadLine()
                    If operation = "q" Then
                        Console.WriteLine("have a happy shopping! Please press Enter to exit")
                        Console.ReadLine()
                        Exit Sub
                    End If


                    Console.WriteLine("What is the second number you wish to calculate?")
                    secondNumber = Console.ReadLine
                    work2 = CDec(secondNumber)



                    badData = False
                Catch ex As Exception
                    Console.WriteLine("Numbers entered into calculator must be numbers")

                    badData = True
                    If firstNumber = "q" Or secondNumber = "q" Or operation = "q" Then
                        Console.WriteLine("have a happy shopping! Please press Enter to exit")
                        Console.ReadLine()
                        Exit Sub
                    End If

                End Try
            Loop Until badData = False


            If badData = False Then
                If operation = "1" Then
                    result = work1 + work2
                    Console.WriteLine(work1 & "+" & work2 & "=" & result)
                    Console.ReadLine()
                ElseIf operation = "2" Then
                    result = work1 - work2
                    Console.WriteLine(work1 & "-" & work2 & "=" & result)
                    Console.ReadLine()


                End If

                Console.ReadLine()

            Else
            End If



        Loop
    End Sub

End Module
