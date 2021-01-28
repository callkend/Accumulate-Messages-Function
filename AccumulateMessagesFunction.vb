


Option Explicit On
Option Strict On

Module AccumulateMessagesFunction
    Sub Main()
        Dim userInput As String
        Dim storedMessages As String

        Console.WriteLine("Write a Message to store or write clear to clear stored messages")
        For i = 0 To 5
            userInput = Console.ReadLine()
            If userInput = "clear" Then
                storedMessages = UserMessages(userInput, True)
            Else
                storedMessages = UserMessages(userInput + vbNewLine, False)
            End If

        Next

        Console.WriteLine(storedMessages)
        Console.ReadLine()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static storedMessages As String

        If clear = False Then
            storedMessages &= newMessage
        Else
            storedMessages = String.Empty
        End If

        Return storedMessages
    End Function

End Module
