' Classes and Objects Programming Assignment
' To make a budgeting program with Visual Basic
' Josiah Barringer
'I will Not use code that was never covered in class Or in our textbook. If you do you
'must be able To explain your code When asked by the professor. Using code
'outside of the resources provided, it can be flagged And reported as an academic
'integrity violation If there Is any suspicion Of copying/cheating.

' Form1 class handles the form and budget logic
Public Class Form1
    Private _balance As Decimal ' Holds the balance

    ' Property to get the current balance
    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property

    ' Constructor to initialize the starting balance
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim startingBalance As Decimal
        Do
            Dim input As String = InputBox("Enter the starting balance:", "Starting Balance")
            If Decimal.TryParse(input, startingBalance) Then
                Exit Do
            Else
                MessageBox.Show("Please enter a valid number.")
            End If
        Loop
        _balance = startingBalance
        UpdateBalanceDisplay()
    End Sub

    ' Update the balance display on the form
    Private Sub UpdateBalanceDisplay()
        txtTotalIncome.Text = _balance.ToString("C") ' Currency format
    End Sub

    ' Method to add income
    Private Sub AddIncome(amount As Decimal)
        _balance += amount
    End Sub

    ' Method to subtract expenses
    Private Sub SubtractExpense(amount As Decimal)
        _balance -= amount
    End Sub

    ' Button click event to handle adding income
    Private Sub btnEnterIncome_Click(sender As Object, e As EventArgs) Handles btnEnterIncome.Click
        Dim amount As Decimal
        If Decimal.TryParse(txtAmount.Text, amount) Then
            Dim description As String = InputBox("Enter description of the income:")
            AddIncome(amount)
            lstIncome.Items.Add($"{description} - {amount.ToString("C")}") ' Add to the income list
            txtAmount.Clear()
            UpdateBalanceDisplay()
        Else
            MessageBox.Show("Please enter a valid income amount.")
        End If
    End Sub

    ' Button click event to handle adding expenses
    Private Sub btnEnterExpense_Click(sender As Object, e As EventArgs) Handles btnEnterExpense.Click
        Dim amount As Decimal
        If Decimal.TryParse(txtAmount.Text, amount) Then
            Dim description As String = InputBox("Enter description of the expense:")
            SubtractExpense(amount)
            lstExpenses.Items.Add($"{description} - {amount.ToString("C")}") ' Add to the expense list
            txtAmount.Clear()
            UpdateBalanceDisplay()

            ' Warn user if balance is negative
            If _balance < 0 Then
                MessageBox.Show("Warning: Your balance is negative.")
            End If
        Else
            MessageBox.Show("Please enter a valid expense amount.")
        End If
    End Sub




End Class


