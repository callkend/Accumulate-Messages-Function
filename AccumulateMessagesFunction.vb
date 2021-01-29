'Kendall Callister
'RCET0265
'Spring 2021
'Accumulate Messages Function

Option Explicit On
Option Strict On

Module AccumulateMessagesFunction
    Sub Main()
        Dim userInput As String
        Dim storedMessages As String

        'loops a call to the userMessages function to store userInput
        Console.WriteLine("Write a Message to store or write clear to clear stored messages")
        For i = 0 To 5
            userInput = Console.ReadLine()
            If userInput = "clear" Then
                storedMessages = UserMessages(userInput, True)
            Else
                storedMessages = UserMessages(userInput + vbNewLine, False)
            End If

        Next

        'Writes the stored messages
        Console.WriteLine(vbNewLine + "Your stored messages are")
        Console.WriteLine(storedMessages)
        Console.ReadLine()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static storedMessages As String

        'If clear is false the string is concatenated togther. If true stored messages is cleared.
        If clear = False Then
            storedMessages &= newMessage
        Else
            storedMessages = String.Empty
        End If

        Return storedMessages
    End Function

End Module
