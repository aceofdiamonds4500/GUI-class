<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		PictureBox1 = New PictureBox()
		lblHeader = New Label()
		boxMonths = New ComboBox()
		btnStatistics = New Button()
		lblMonthStat = New Label()
		lblAvgStat = New Label()
		lblMostSavedStat = New Label()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.Image = My.Resources.Resources.smarthome
		PictureBox1.Location = New Point(0, -1)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(374, 262)
		PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' lblHeader
		' 
		lblHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		lblHeader.AutoSize = True
		lblHeader.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHeader.Location = New Point(468, 56)
		lblHeader.Name = "lblHeader"
		lblHeader.Size = New Size(215, 74)
		lblHeader.TabIndex = 1
		lblHeader.Text = "Smart Home" & vbCrLf & "Electric Savings"
		lblHeader.TextAlign = ContentAlignment.MiddleCenter
		' 
		' boxMonths
		' 
		boxMonths.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		boxMonths.DropDownStyle = ComboBoxStyle.DropDownList
		boxMonths.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		boxMonths.FormattingEnabled = True
		boxMonths.Location = New Point(513, 185)
		boxMonths.Name = "boxMonths"
		boxMonths.Size = New Size(121, 29)
		boxMonths.TabIndex = 2
		' 
		' btnStatistics
		' 
		btnStatistics.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
		btnStatistics.Cursor = Cursors.Hand
		btnStatistics.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnStatistics.ForeColor = SystemColors.ControlLightLight
		btnStatistics.Location = New Point(263, 324)
		btnStatistics.Name = "btnStatistics"
		btnStatistics.Size = New Size(201, 45)
		btnStatistics.TabIndex = 3
		btnStatistics.Text = "Display Statistics"
		btnStatistics.UseVisualStyleBackColor = False
		' 
		' lblMonthStat
		' 
		lblMonthStat.AutoSize = True
		lblMonthStat.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblMonthStat.Location = New Point(207, 286)
		lblMonthStat.Name = "lblMonthStat"
		lblMonthStat.Size = New Size(295, 21)
		lblMonthStat.TabIndex = 4
		lblMonthStat.Text = "The electric savings for blank is blank"
		' 
		' lblAvgStat
		' 
		lblAvgStat.AutoSize = True
		lblAvgStat.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblAvgStat.Location = New Point(218, 382)
		lblAvgStat.Name = "lblAvgStat"
		lblAvgStat.Size = New Size(284, 21)
		lblAvgStat.TabIndex = 5
		lblAvgStat.Text = "The average montly savings: money"
		' 
		' lblMostSavedStat
		' 
		lblMostSavedStat.AutoSize = True
		lblMostSavedStat.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblMostSavedStat.Location = New Point(167, 420)
		lblMostSavedStat.Name = "lblMostSavedStat"
		lblMostSavedStat.Size = New Size(380, 21)
		lblMostSavedStat.TabIndex = 6
		lblMostSavedStat.Text = "Month had the most significant monthly savings"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
		ClientSize = New Size(727, 462)
		Controls.Add(lblMostSavedStat)
		Controls.Add(lblAvgStat)
		Controls.Add(lblMonthStat)
		Controls.Add(btnStatistics)
		Controls.Add(boxMonths)
		Controls.Add(lblHeader)
		Controls.Add(PictureBox1)
		MinimumSize = New Size(740, 500)
		Name = "Form1"
		Text = "Smart Home Application"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents lblHeader As Label
	Friend WithEvents boxMonths As ComboBox
	Friend WithEvents btnStatistics As Button
	Friend WithEvents lblMonthStat As Label
	Friend WithEvents lblAvgStat As Label
	Friend WithEvents lblMostSavedStat As Label

End Class
