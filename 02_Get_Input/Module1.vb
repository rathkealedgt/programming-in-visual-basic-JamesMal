Module Module1
    ''' <summary>
    '''     This program will show you how to get input from the user.
    ''' </summary>
    ''' <author> James Malsher </author>
    ''' <date> 6/8/19 </date>
    ''' 
    Sub Main()
        ' Housekeeping
        Dim UserName, OutputMessage As String
        Dim FirstNumber, SecondNumber, Sum, Product, Subtraction As Integer


        ' Ask for user name
        Console.WriteLine("Enter your name here.")
        UserName = Console.ReadLine()

        Console.WriteLine(StrReverse(UserName))

        ' Ask user for two numbers
        Console.WriteLine("Please enter number here")
        FirstNumber = Console.ReadLine()

        Console.WriteLine("Please enter  another number here")
        SecondNumber = Console.ReadLine()

        ' Add numbers together
        Sum = FirstNumber + SecondNumber

        ' Multiply numbers together
        Product = FirstNumber * SecondNumber

        ' Subtract numbers
        Subtraction = FirstNumber - SecondNumber

        ' Greet user and display maths
        OutputMessage = String.Format("Hello, {0}. The sum of your numbers is {1}, the product of your numbers is {2}, and the subtracted numbers = {3}.", UserName, Sum, Product, Subtraction)
        Console.WriteLine(OutputMessage)
        Console.ReadLine()


    End Sub

End Module
