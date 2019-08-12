''' <summary>
'''     This exercise will introduce you to if statements and while loops.
''' </summary>
''' <author> James Malsher </author>
''' <date> 12/  8/19 </date>
''' 
Module Module1

    Sub Main()
        ' Housekeeping
        Dim UserInput As String
        Dim KeepGoing As String = ""

        While KeepGoing = ""
            ' Ask user if they like coffee and record their answer.
            Console.WriteLine("Do you like tea or coffee?")
            UserInput = Console.ReadLine().ToLower()

            ' Check input and respond
            If UserInput = "Coffee" Or UserInput = "C" Then
                Console.WriteLine("I like coffee too, my favorite is Flat White.")
            ElseIf UserInput = "Tea" Or UserInput = "T" Then
                Console.WriteLine("I like tea too. my favorite is Earl Grey")
            Else
                Console.WriteLine("I don't understand!")
            End If

            ' Pause program to let the user read 
            Console.WriteLine("Press q followed by <enter> to quit.")
            KeepGoing = Console.ReadLine()

        End While

    End Sub

End Module