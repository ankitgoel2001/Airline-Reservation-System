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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxName = New System.Windows.Forms.TextBox()
        Me.txtBoxSeat = New System.Windows.Forms.TextBox()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.btnAddPassenger = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnResetAll = New System.Windows.Forms.Button()
        Me.btnListPassenger = New System.Windows.Forms.Button()
        Me.btnDeletePassenger = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPassengerCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstBoxWaitlist = New System.Windows.Forms.ListBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.lstSeatChart = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'txtBoxName
        '
        Me.txtBoxName.Location = New System.Drawing.Point(103, 36)
        Me.txtBoxName.Name = "txtBoxName"
        Me.txtBoxName.Size = New System.Drawing.Size(156, 22)
        Me.txtBoxName.TabIndex = 1
        '
        'txtBoxSeat
        '
        Me.txtBoxSeat.Location = New System.Drawing.Point(373, 39)
        Me.txtBoxSeat.Name = "txtBoxSeat"
        Me.txtBoxSeat.Size = New System.Drawing.Size(156, 22)
        Me.txtBoxSeat.TabIndex = 3
        '
        'lblSeat
        '
        Me.lblSeat.AutoSize = True
        Me.lblSeat.Location = New System.Drawing.Point(326, 39)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(41, 17)
        Me.lblSeat.TabIndex = 2
        Me.lblSeat.Text = "&Seat:"
        '
        'btnAddPassenger
        '
        Me.btnAddPassenger.Location = New System.Drawing.Point(48, 111)
        Me.btnAddPassenger.Name = "btnAddPassenger"
        Me.btnAddPassenger.Size = New System.Drawing.Size(195, 55)
        Me.btnAddPassenger.TabIndex = 4
        Me.btnAddPassenger.Text = "&Add Passenger"
        Me.btnAddPassenger.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(48, 403)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(195, 55)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnResetAll
        '
        Me.btnResetAll.Location = New System.Drawing.Point(48, 331)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(195, 53)
        Me.btnResetAll.TabIndex = 6
        Me.btnResetAll.Text = "&Reset All"
        Me.btnResetAll.UseVisualStyleBackColor = True
        '
        'btnListPassenger
        '
        Me.btnListPassenger.Location = New System.Drawing.Point(48, 265)
        Me.btnListPassenger.Name = "btnListPassenger"
        Me.btnListPassenger.Size = New System.Drawing.Size(195, 49)
        Me.btnListPassenger.TabIndex = 7
        Me.btnListPassenger.Text = "&List Passenger"
        Me.btnListPassenger.UseVisualStyleBackColor = True
        '
        'btnDeletePassenger
        '
        Me.btnDeletePassenger.Location = New System.Drawing.Point(48, 191)
        Me.btnDeletePassenger.Name = "btnDeletePassenger"
        Me.btnDeletePassenger.Size = New System.Drawing.Size(195, 49)
        Me.btnDeletePassenger.TabIndex = 8
        Me.btnDeletePassenger.Text = "&Delete Passenger"
        Me.btnDeletePassenger.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "(1A,1B,1C,1D===10A,10B,10C,10D)"
        '
        'lblPassengerCount
        '
        Me.lblPassengerCount.AutoSize = True
        Me.lblPassengerCount.Location = New System.Drawing.Point(345, 308)
        Me.lblPassengerCount.Name = "lblPassengerCount"
        Me.lblPassengerCount.Size = New System.Drawing.Size(133, 17)
        Me.lblPassengerCount.TabIndex = 11
        Me.lblPassengerCount.Text = "Passenger Count: 0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Wait List:"
        '
        'lstBoxWaitlist
        '
        Me.lstBoxWaitlist.FormattingEnabled = True
        Me.lstBoxWaitlist.ItemHeight = 16
        Me.lstBoxWaitlist.Location = New System.Drawing.Point(350, 371)
        Me.lstBoxWaitlist.Name = "lstBoxWaitlist"
        Me.lstBoxWaitlist.Size = New System.Drawing.Size(236, 84)
        Me.lstBoxWaitlist.TabIndex = 13
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(571, 374)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(14, 83)
        Me.VScrollBar1.TabIndex = 14
        '
        'lstSeatChart
        '
        Me.lstSeatChart.FormattingEnabled = True
        Me.lstSeatChart.ItemHeight = 16
        Me.lstSeatChart.Items.AddRange(New Object() {"Row       A     B     C     D", "    1", "    2", "    3", "    4", "    5", "    6", "    7", "    8", "    9", "  10"})
        Me.lstSeatChart.Location = New System.Drawing.Point(340, 111)
        Me.lstSeatChart.Name = "lstSeatChart"
        Me.lstSeatChart.Size = New System.Drawing.Size(233, 180)
        Me.lstSeatChart.TabIndex = 10
        Me.lstSeatChart.Tag = "g"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 470)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.lstBoxWaitlist)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPassengerCount)
        Me.Controls.Add(Me.lstSeatChart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDeletePassenger)
        Me.Controls.Add(Me.btnListPassenger)
        Me.Controls.Add(Me.btnResetAll)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddPassenger)
        Me.Controls.Add(Me.txtBoxSeat)
        Me.Controls.Add(Me.lblSeat)
        Me.Controls.Add(Me.txtBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Project5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxName As TextBox
    Friend WithEvents txtBoxSeat As TextBox
    Friend WithEvents lblSeat As Label
    Friend WithEvents btnAddPassenger As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnResetAll As Button
    Friend WithEvents btnListPassenger As Button
    Friend WithEvents btnDeletePassenger As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPassengerCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstBoxWaitlist As ListBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents lstSeatChart As ListBox
End Class
