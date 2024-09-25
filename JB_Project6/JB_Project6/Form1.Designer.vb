<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.btnEnterIncome = New System.Windows.Forms.Button()
        Me.btnEnterExpense = New System.Windows.Forms.Button()
        Me.lstIncome = New System.Windows.Forms.ListBox()
        Me.lstExpenses = New System.Windows.Forms.ListBox()
        Me.txtTotalIncome = New System.Windows.Forms.TextBox()
        Me.lblTotalIncome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(318, 95)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 0
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(345, 79)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Amount"
        '
        'btnEnterIncome
        '
        Me.btnEnterIncome.Location = New System.Drawing.Point(313, 155)
        Me.btnEnterIncome.Name = "btnEnterIncome"
        Me.btnEnterIncome.Size = New System.Drawing.Size(105, 25)
        Me.btnEnterIncome.TabIndex = 2
        Me.btnEnterIncome.Text = "&Enter Income"
        Me.btnEnterIncome.UseVisualStyleBackColor = True
        '
        'btnEnterExpense
        '
        Me.btnEnterExpense.Location = New System.Drawing.Point(313, 197)
        Me.btnEnterExpense.Name = "btnEnterExpense"
        Me.btnEnterExpense.Size = New System.Drawing.Size(105, 25)
        Me.btnEnterExpense.TabIndex = 3
        Me.btnEnterExpense.Text = "&Enter Expenses"
        Me.btnEnterExpense.UseVisualStyleBackColor = True
        '
        'lstIncome
        '
        Me.lstIncome.FormattingEnabled = True
        Me.lstIncome.Location = New System.Drawing.Point(136, 95)
        Me.lstIncome.Name = "lstIncome"
        Me.lstIncome.Size = New System.Drawing.Size(145, 160)
        Me.lstIncome.TabIndex = 4
        '
        'lstExpenses
        '
        Me.lstExpenses.FormattingEnabled = True
        Me.lstExpenses.Location = New System.Drawing.Point(495, 95)
        Me.lstExpenses.Name = "lstExpenses"
        Me.lstExpenses.Size = New System.Drawing.Size(147, 160)
        Me.lstExpenses.TabIndex = 5
        '
        'txtTotalIncome
        '
        Me.txtTotalIncome.Location = New System.Drawing.Point(313, 280)
        Me.txtTotalIncome.Name = "txtTotalIncome"
        Me.txtTotalIncome.Size = New System.Drawing.Size(105, 20)
        Me.txtTotalIncome.TabIndex = 6
        '
        'lblTotalIncome
        '
        Me.lblTotalIncome.AutoSize = True
        Me.lblTotalIncome.Location = New System.Drawing.Point(331, 255)
        Me.lblTotalIncome.Name = "lblTotalIncome"
        Me.lblTotalIncome.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalIncome.TabIndex = 7
        Me.lblTotalIncome.Text = "Total Income"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JB_Project6.My.Resources.Resources.vern
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalIncome)
        Me.Controls.Add(Me.txtTotalIncome)
        Me.Controls.Add(Me.lstExpenses)
        Me.Controls.Add(Me.lstIncome)
        Me.Controls.Add(Me.btnEnterExpense)
        Me.Controls.Add(Me.btnEnterIncome)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtAmount)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents btnEnterIncome As Button
    Friend WithEvents btnEnterExpense As Button
    Friend WithEvents lstIncome As ListBox
    Friend WithEvents lstExpenses As ListBox
    Friend WithEvents txtTotalIncome As TextBox
    Friend WithEvents lblTotalIncome As Label
End Class
