﻿Module ValidationFunctionsModule

    ' Validate ISBN
    Function ValidateISBN(ByVal ISBN As String) As Boolean
        Console.WriteLine(ISBN)
        If ISBN.Length = 13 Then
            If ISBN(0) <> "9" Or ISBN(1) <> "7" Or (ISBN(2) <> "9" AndAlso ISBN(2) <> "8") Then
                Return False
            Else
                Dim ct As Integer = 0
                Dim mul As Integer = 1

                For i As Integer = 0 To 11
                    ct = ct + mul * (Asc(ISBN(i)) - Asc("0"))

                    If mul = 3 Then
                        mul = 1
                    Else
                        mul = 3
                    End If

                Next
                ct = ct Mod 10
                ct = 10 - ct

                If ct = (Asc(ISBN(12)) - Asc("0")) Or ct = 10 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else

            ISBN = StrReverse(ISBN)
            Dim ct As Integer = 0
            For i As Integer = 2 To 10
                ct += i * (Asc(ISBN(i - 1)) - Asc("0"))
            Next
            ct = ct Mod 11
            If ISBN(0) = "X" Or ISBN(0) = "x" Then
                ct += 10
            ElseIf (Asc(ISBN(0)) - Asc("0")) < 10 Then
                ct += (Asc(ISBN(0)) - Asc("0"))
            Else : Return True
            End If
            If ct = 11 Or ct = 0 Then
                Return True
            Else : Return False
            End If

        End If
    End Function


End Module