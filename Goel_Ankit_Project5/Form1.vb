'******************************************************************************************
'Name: Ankit Goel
'Date: 6/19/2021
'Purpose: Program to create an airline reservation booking system using 2d arrays
'******************************************************************************************
Public Class Form1
    Dim aryintPassengers(11, 5) As String 'array of passenger seats with 10 rows and 4 columns
    Dim aryPassengerName(11, 5) As String 'array to store passenger's name
    Dim aryWaitlistName As ArrayList = New ArrayList() 'array to store the waitlist of people
    Dim passengerCount As Integer = 0   'to store how many passengers are there

    Private Sub formLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Function to automatically fill the seat chart as specified in the bash script
        Dim seatCount As String 'to store number of seats by user
        Dim counter As Integer = 1 'to keep track of number of seats
        seatCount = Command()

        'To make sure that the user doesn't leave the seat count
        If seatCount = "" Then
            Exit Sub
        End If

        'To keep adding seats until counter
        For i = 1 To 10
            For j = 1 To 4
                If counter > CInt(seatCount) Then
                    lstSeatChart.Items.Clear()
                    Call createArray()
                    lblPassengerCount.Text = "Passenger count: " + CStr(countPassengers())
                    Exit Sub
                End If
                aryintPassengers(i, j) = "X"
                aryPassengerName(i, j) = "Pass".ToUpper & counter
                counter += 1
            Next
        Next
        lstSeatChart.Items.Clear()
        Call createArray()
        lblPassengerCount.Text = "Passenger count: " + CStr(countPassengers())

    End Sub
    Private Sub addPassenger()
        'Sub function to add new passengers to the seats
        Dim SeatNo As String 'to store the seat number
        Dim first_index As Integer   'to store the number from the seat to get the seat row
        Dim second_index As String    'to store the letter from the seat to get the seat column
        Dim column As Integer         'to store the seat column
        Dim isEmpty As Boolean = False 'to store as a flag to check if seat was empty
        Dim passengerCount As Integer  'to keep count of number of passengers getting a seat

        passengerCount = Val(lblPassengerCount.Text)
        SeatNo = txtBoxSeat.Text.ToUpper   'to get the seat number from the text box
        'to check if passenger didn't choose a seat
        If SeatNo = "" Then
            For first_index = 1 To 10
                For column = 1 To 4
                    'Assign them the next available empty seat
                    If aryintPassengers(first_index, column) <> "X" Then
                        aryintPassengers(first_index, column) = "X"
                        aryPassengerName(first_index, column) = txtBoxName.Text.ToUpper
                        lblPassengerCount.Text = "Passenger count: " + CStr(countPassengers())
                        isEmpty = True
                        Exit Sub
                    End If
                Next
            Next
            'To add passenger to the waitlist if no seat available
            If isEmpty = False Then
                Call addWaitlist()
                Exit Sub
            End If
        End If

        'To extract seat number for 10
        If SeatNo.Length = 3 Then
            first_index = 10
            second_index = SeatNo(2)

            'To extract seat number for 1 - 9
        Else
            first_index = Val(SeatNo(0))
            second_index = SeatNo(1)
        End If

        'To assign column number from seat letter
        If second_index = "A" Then
            column = 1
        End If
        If second_index = "B" Then
            column = 2
        End If
        If second_index = "C" Then
            column = 3
        End If
        If second_index = "D" Then
            column = 4
        End If

        'To check if seat is already assigned by another passenger
        If aryintPassengers(first_index, column) = "X" Then
            MsgBox("Seat already assigned!")
        Else
            aryintPassengers(first_index, column) = "X"
            aryPassengerName(first_index, column) = txtBoxName.Text.ToUpper
            isEmpty = True
        End If

        'To assign passenger to next available seat if no seat is there
        If isEmpty = False Then
            Call addWaitlist()
        End If
    End Sub

    Private Sub addWaitlist()
        'Sub function to add name to the waitlist if there are no empty seats
        lstBoxWaitlist.Items.Add(aryWaitlistName.Count + 1 & ":" & txtBoxName.Text)
        aryWaitlistName.Add(txtBoxName.Text)

    End Sub

    Private Function countPassengers() As Integer
        'Function to count the number of passengers
        Dim i, j As Integer
        Dim passengerCount As Integer = 0

        For i = 1 To 10
            For j = 1 To 4
                If aryintPassengers(i, j) = "X" Then
                    passengerCount += 1
                End If
            Next
        Next
        Return passengerCount
    End Function

    Private Sub btnAddPassenger_Click(sender As Object, e As EventArgs) Handles btnAddPassenger.Click
        'Sub function to add a new passenger to the seating chart
        If IsNumeric(txtBoxName.Text) Then 'input validation
            MsgBox("Invalid passenger name! Must be characters.")
            Exit Sub
        End If
        If txtBoxName.Text = "" Then
            MsgBox("Enter passenger name!")
            Exit Sub
        End If

        ' Call createArray()
        Call addPassenger()
        lstSeatChart.Items.Clear()
        'txtBoxSeatChart.Clear()
        Call createArray()
    End Sub

    Private Sub createArray()
        'Sub function to create the new array
        aryintPassengers(0, 0) = "Row"
        aryintPassengers(0, 1) = "A"
        aryintPassengers(0, 2) = "B"
        aryintPassengers(0, 3) = "C"
        aryintPassengers(0, 4) = "D"

        'To store 1 - 10
        For i = 1 To 10
            aryintPassengers(i, 0) = "    " & CStr(i) & " "
        Next

        'To get effective white spaces
        For i = 0 To 11
            Dim output As String = ""
            For j = 0 To 5
                output += aryintPassengers(i, j) + "       "
            Next
            lstSeatChart.Items.Add(output)
            'txtBoxSeatChart.Text = output
        Next


    End Sub
    Private Sub btnDeletePassenger_Click(sender As Object, e As EventArgs) Handles btnDeletePassenger.Click
        'Sub function to remove a passenger from the seating chart and add the next person on the waiting list
        Dim i, j As Integer
        Dim flag As Boolean = False

        If IsNumeric(txtBoxName.Text) Then
            MsgBox("Invalid passenger name! Must be characters.")
        End If
        If txtBoxName.Text = "" Then
            MsgBox("Enter passenger name!")
        End If

        For i = 1 To 10
            For j = 1 To 4
                If aryPassengerName(i, j) = txtBoxName.Text.ToUpper Then
                    aryPassengerName(i, j) = ""
                    aryintPassengers(i, j) = ""
                    flag = True
                    lblPassengerCount.Text = "Passenger count: " + CStr(countPassengers())

                    'To remove the first element from the waitlist array
                    If aryWaitlistName.Count <> 0 Then
                        aryPassengerName(i, j) = aryWaitlistName(0)
                        aryintPassengers(i, j) = "X"
                        aryWaitlistName.RemoveAt(0)
                        lstBoxWaitlist.Items.RemoveAt(0)
                        lblPassengerCount.Text = "Passenger count: " + CStr(countPassengers())
                    End If
                End If
            Next
        Next

        If flag = False Then
            MsgBox("Passenger not found!")
            Exit Sub
        End If

        lstSeatChart.Items.Clear()
        Call createArray()

    End Sub

    Private Sub btnListPassenger_Click(sender As Object, e As EventArgs) Handles btnListPassenger.Click
        'Sub function to display the new form of passengers with their seating chart
        Dim frmDisp As New frmDisplay
        frmDisp.txtDocument.SelectionStart = 0
        frmDisp.txtDocument.Text = "#:    Passanger Name:       Seat:" & vbCrLf
        Dim count As Integer = 1

        For i = 1 To 10
            For j = 1 To 4
                If aryintPassengers(i, j) <> "X" Then
                    aryPassengerName(i, j) = "  *** Available ***"
                End If
                frmDisp.txtDocument.Text += count & "      " & aryPassengerName(i, j) & "      " & i & aryintPassengers(0, j) & vbCrLf
                count += 1
            Next
        Next
        frmDisp.ShowDialog()
    End Sub

    Private Sub btnResetAll_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        'Sub function to reset the seating chart
        txtBoxName.Text = ""
        txtBoxSeat.Text = ""
        lstBoxWaitlist.Items.Clear()

        For i = 1 To 10
            For j = 1 To 4
                If aryintPassengers(i, j) = "X" Then
                    aryintPassengers(i, j) = ""
                    aryPassengerName(i, j) = ""
                End If
            Next
        Next

        For i = 0 To aryWaitlistName.Count - 1
            aryWaitlistName(i) = ""
        Next

        lblPassengerCount.Text = "Passenger count: " + CStr(countPassengers())

        lstSeatChart.Items.Clear()
        Call createArray()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Sub function to close the form
        Me.Close()
    End Sub
End Class
