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
		lblSubHeader = New Label()
		grpConversions = New GroupBox()
		rdioMToIn = New RadioButton()
		rdioInToM = New RadioButton()
		btnConvert = New Button()
		txtInput = New TextBox()
		btnSaveToList = New Button()
		btnClearResults = New Button()
		lblConverted = New Label()
		lblSaveStatus = New Label()
		btnClearList = New Button()
		btnSaveToFile = New Button()
		lstConvertList = New ListBox()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		grpConversions.SuspendLayout()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.Image = My.Resources.Resources.building
		PictureBox1.Location = New Point(12, 12)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(274, 211)
		PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' lblHeader
		' 
		lblHeader.AutoSize = True
		lblHeader.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHeader.Location = New Point(315, 24)
		lblHeader.Name = "lblHeader"
		lblHeader.Size = New Size(175, 30)
		lblHeader.TabIndex = 1
		lblHeader.Text = "Converter App 2"
		' 
		' lblSubHeader
		' 
		lblSubHeader.AutoSize = True
		lblSubHeader.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblSubHeader.Location = New Point(315, 69)
		lblSubHeader.Name = "lblSubHeader"
		lblSubHeader.Size = New Size(150, 40)
		lblSubHeader.TabIndex = 2
		lblSubHeader.Text = "Enter a value and" & vbCrLf & "choose a conversion"
		' 
		' grpConversions
		' 
		grpConversions.BackColor = Color.Blue
		grpConversions.Controls.Add(rdioMToIn)
		grpConversions.Controls.Add(rdioInToM)
		grpConversions.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		grpConversions.ForeColor = Color.White
		grpConversions.Location = New Point(315, 132)
		grpConversions.Name = "grpConversions"
		grpConversions.Size = New Size(311, 124)
		grpConversions.TabIndex = 3
		grpConversions.TabStop = False
		grpConversions.Text = "Convert Measurement"
		' 
		' rdioMToIn
		' 
		rdioMToIn.AutoSize = True
		rdioMToIn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		rdioMToIn.Location = New Point(22, 66)
		rdioMToIn.Name = "rdioMToIn"
		rdioMToIn.Size = New Size(153, 25)
		rdioMToIn.TabIndex = 1
		rdioMToIn.TabStop = True
		rdioMToIn.Text = "Meters to Inches"
		rdioMToIn.UseVisualStyleBackColor = True
		' 
		' rdioInToM
		' 
		rdioInToM.AutoSize = True
		rdioInToM.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		rdioInToM.Location = New Point(22, 29)
		rdioInToM.Name = "rdioInToM"
		rdioInToM.Size = New Size(153, 25)
		rdioInToM.TabIndex = 0
		rdioInToM.TabStop = True
		rdioInToM.Text = "Inches to Meters"
		rdioInToM.UseVisualStyleBackColor = True
		' 
		' btnConvert
		' 
		btnConvert.BackColor = Color.White
		btnConvert.FlatStyle = FlatStyle.Flat
		btnConvert.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
		btnConvert.Location = New Point(315, 290)
		btnConvert.Name = "btnConvert"
		btnConvert.Size = New Size(150, 33)
		btnConvert.TabIndex = 4
		btnConvert.Text = "Convert"
		btnConvert.UseVisualStyleBackColor = False
		' 
		' txtInput
		' 
		txtInput.BackColor = Color.Blue
		txtInput.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		txtInput.ForeColor = Color.White
		txtInput.Location = New Point(480, 80)
		txtInput.Name = "txtInput"
		txtInput.Size = New Size(146, 29)
		txtInput.TabIndex = 5
		' 
		' btnSaveToList
		' 
		btnSaveToList.BackColor = Color.White
		btnSaveToList.FlatStyle = FlatStyle.Flat
		btnSaveToList.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
		btnSaveToList.Location = New Point(315, 421)
		btnSaveToList.Name = "btnSaveToList"
		btnSaveToList.Size = New Size(150, 33)
		btnSaveToList.TabIndex = 7
		btnSaveToList.Text = "Save Results"
		btnSaveToList.UseVisualStyleBackColor = False
		' 
		' btnClearResults
		' 
		btnClearResults.BackColor = Color.White
		btnClearResults.FlatStyle = FlatStyle.Flat
		btnClearResults.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
		btnClearResults.Location = New Point(315, 466)
		btnClearResults.Name = "btnClearResults"
		btnClearResults.Size = New Size(150, 33)
		btnClearResults.TabIndex = 8
		btnClearResults.Text = "Clear Results"
		btnClearResults.UseVisualStyleBackColor = False
		' 
		' lblConverted
		' 
		lblConverted.AutoSize = True
		lblConverted.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblConverted.Location = New Point(315, 359)
		lblConverted.Name = "lblConverted"
		lblConverted.Size = New Size(177, 20)
		lblConverted.TabIndex = 9
		lblConverted.Text = "0.0 inches is 0.0 meters."
		' 
		' lblSaveStatus
		' 
		lblSaveStatus.AutoSize = True
		lblSaveStatus.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblSaveStatus.Location = New Point(315, 544)
		lblSaveStatus.Name = "lblSaveStatus"
		lblSaveStatus.Size = New Size(280, 20)
		lblSaveStatus.TabIndex = 10
		lblSaveStatus.Text = "Saved blank entries to filemeasures.txt"
		' 
		' btnClearList
		' 
		btnClearList.BackColor = Color.White
		btnClearList.FlatStyle = FlatStyle.Flat
		btnClearList.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnClearList.Location = New Point(30, 540)
		btnClearList.Name = "btnClearList"
		btnClearList.Size = New Size(110, 28)
		btnClearList.TabIndex = 11
		btnClearList.Text = "Clear List"
		btnClearList.UseVisualStyleBackColor = False
		' 
		' btnSaveToFile
		' 
		btnSaveToFile.BackColor = Color.White
		btnSaveToFile.FlatStyle = FlatStyle.Flat
		btnSaveToFile.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnSaveToFile.Location = New Point(156, 540)
		btnSaveToFile.Name = "btnSaveToFile"
		btnSaveToFile.Size = New Size(110, 28)
		btnSaveToFile.TabIndex = 12
		btnSaveToFile.Text = "Save to File"
		btnSaveToFile.UseVisualStyleBackColor = False
		' 
		' lstConvertList
		' 
		lstConvertList.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lstConvertList.FormattingEnabled = True
		lstConvertList.ItemHeight = 20
		lstConvertList.Location = New Point(12, 229)
		lstConvertList.Name = "lstConvertList"
		lstConvertList.Size = New Size(274, 304)
		lstConvertList.TabIndex = 13
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
		ClientSize = New Size(667, 638)
		Controls.Add(lstConvertList)
		Controls.Add(btnSaveToFile)
		Controls.Add(btnClearList)
		Controls.Add(lblSaveStatus)
		Controls.Add(lblConverted)
		Controls.Add(btnClearResults)
		Controls.Add(btnSaveToList)
		Controls.Add(txtInput)
		Controls.Add(btnConvert)
		Controls.Add(grpConversions)
		Controls.Add(lblSubHeader)
		Controls.Add(lblHeader)
		Controls.Add(PictureBox1)
		Name = "Form1"
		Text = "Building Plans Conversion 2"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		grpConversions.ResumeLayout(False)
		grpConversions.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents lblHeader As Label
	Friend WithEvents lblSubHeader As Label
	Friend WithEvents grpConversions As GroupBox
	Friend WithEvents rdioMToIn As RadioButton
	Friend WithEvents rdioInToM As RadioButton
	Friend WithEvents btnConvert As Button
	Friend WithEvents txtInput As TextBox
	Friend WithEvents btnSaveToList As Button
	Friend WithEvents btnClearResults As Button
	Friend WithEvents lblConverted As Label
	Friend WithEvents lblSaveStatus As Label
	Friend WithEvents btnClearList As Button
	Friend WithEvents btnSaveToFile As Button
	Friend WithEvents lstConvertList As ListBox

End Class
