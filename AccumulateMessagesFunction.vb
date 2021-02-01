'Kendall Callister
'RCET0265
'Spring 2021
'Accumulate Messages Function
'https://github.com/callkend/Accumulate-Messages-Function.git

Option Explicit On
Option Strict On

Module AccumulateMessagesFunction
    Sub Main()
        Dim userInput As String
        Dim storedMessages As String
        Dim run As Boolean = True

        'loops a call to the userMessages function to store userInput
        Console.WriteLine("Write a Message to store or write clear to clear stored messages." _
                          + vbNewLine + "Write quit to exit program." + vbNewLine +
                          "Write return to read stored messages.")
        Do While run = True
            userInput = Console.ReadLine()
            Select Case (userInput)
                Case = "clear"
                    storedMessages = UserMessages(userInput, True)
                Case = "quit"
                    run = False
                Case = "return"
                    'Writes the stored messages
                    Console.WriteLine(vbNewLine + "Your stored messages are")
                    Console.WriteLine(storedMessages)
                Case Else
                    storedMessages = UserMessages(userInput + vbNewLine, False)
            End Select
        Loop

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
