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
		lblHeader = New Label()
		lblSubHeader = New Label()
		txtWordToList = New TextBox()
		btnWordAdd = New Button()
		lblWordList = New Label()
		btnNewWS = New Button()
		btnGenerate = New Button()
		cbxWordList = New ComboBox()
		btnAddToWS = New Button()
		btnWordRemove = New Button()
		SuspendLayout()
		' 
		' lblHeader
		' 
		lblHeader.Anchor = AnchorStyles.Top
		lblHeader.AutoSize = True
		lblHeader.Font = New Font("Montserrat", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		lblHeader.Location = New Point(69, 39)
		lblHeader.Name = "lblHeader"
		lblHeader.Size = New Size(447, 37)
		lblHeader.TabIndex = 0
		lblHeader.Text = "Nick's Word Search Generator"
		' 
		' lblSubHeader
		' 
		lblSubHeader.AutoSize = True
		lblSubHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		lblSubHeader.Location = New Point(198, 134)
		lblSubHeader.Name = "lblSubHeader"
		lblSubHeader.Size = New Size(214, 15)
		lblSubHeader.TabIndex = 9
		lblSubHeader.Text = "Note: Word must be less than 15 letters."
		' 
		' txtWordToList
		' 
		txtWordToList.Anchor = AnchorStyles.Top
		txtWordToList.Font = New Font("Consolas", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		txtWordToList.Location = New Point(198, 105)
		txtWordToList.Name = "txtWordToList"
		txtWordToList.Size = New Size(199, 26)
		txtWordToList.TabIndex = 1
		txtWordToList.Text = "Insert Your Word Here"
		txtWordToList.TextAlign = HorizontalAlignment.Center
		' 
		' btnWordAdd
		' 
		btnWordAdd.Anchor = AnchorStyles.Top
		btnWordAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
		btnWordAdd.FlatStyle = FlatStyle.Popup
		btnWordAdd.Font = New Font("Consolas", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		btnWordAdd.ForeColor = Color.Black
		btnWordAdd.Location = New Point(226, 170)
		btnWordAdd.Name = "btnWordAdd"
		btnWordAdd.Size = New Size(144, 43)
		btnWordAdd.TabIndex = 2
		btnWordAdd.Text = "Add to List"
		btnWordAdd.UseVisualStyleBackColor = False
		' 
		' lblWordList
		' 
		lblWordList.AutoSize = True
		lblWordList.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblWordList.Location = New Point(144, 266)
		lblWordList.Name = "lblWordList"
		lblWordList.Size = New Size(110, 22)
		lblWordList.TabIndex = 3
		lblWordList.Text = "Word List:"
		' 
		' btnNewWS
		' 
		btnNewWS.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
		btnNewWS.FlatStyle = FlatStyle.Popup
		btnNewWS.Font = New Font("Consolas", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		btnNewWS.ForeColor = Color.Black
		btnNewWS.Location = New Point(48, 170)
		btnNewWS.Name = "btnNewWS"
		btnNewWS.Size = New Size(144, 43)
		btnNewWS.TabIndex = 4
		btnNewWS.Text = "New Word Search"
		btnNewWS.UseVisualStyleBackColor = False
		' 
		' btnGenerate
		' 
		btnGenerate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		btnGenerate.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
		btnGenerate.FlatStyle = FlatStyle.Popup
		btnGenerate.Font = New Font("Consolas", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		btnGenerate.ForeColor = Color.Black
		btnGenerate.Location = New Point(403, 170)
		btnGenerate.Name = "btnGenerate"
		btnGenerate.Size = New Size(144, 43)
		btnGenerate.TabIndex = 5
		btnGenerate.Text = "Generate"
		btnGenerate.UseVisualStyleBackColor = False
		' 
		' cbxWordList
		' 
		cbxWordList.DropDownStyle = ComboBoxStyle.DropDownList
		cbxWordList.FormattingEnabled = True
		cbxWordList.Location = New Point(260, 265)
		cbxWordList.Name = "cbxWordList"
		cbxWordList.Size = New Size(121, 23)
		cbxWordList.TabIndex = 6
		' 
		' btnAddToWS
		' 
		btnAddToWS.Font = New Font("Consolas", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnAddToWS.Location = New Point(403, 257)
		btnAddToWS.Name = "btnAddToWS"
		btnAddToWS.Size = New Size(144, 23)
		btnAddToWS.TabIndex = 7
		btnAddToWS.Text = "Add to Word Search"
		btnAddToWS.UseVisualStyleBackColor = True
		' 
		' btnWordRemove
		' 
		btnWordRemove.Font = New Font("Consolas", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnWordRemove.Location = New Point(403, 286)
		btnWordRemove.Name = "btnWordRemove"
		btnWordRemove.Size = New Size(127, 23)
		btnWordRemove.TabIndex = 8
		btnWordRemove.Text = "Remove From List"
		btnWordRemove.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
		ClientSize = New Size(584, 361)
		Controls.Add(lblSubHeader)
		Controls.Add(btnWordRemove)
		Controls.Add(btnAddToWS)
		Controls.Add(cbxWordList)
		Controls.Add(btnGenerate)
		Controls.Add(btnNewWS)
		Controls.Add(lblWordList)
		Controls.Add(btnWordAdd)
		Controls.Add(txtWordToList)
		Controls.Add(lblHeader)
		MinimumSize = New Size(600, 400)
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Word Search Generator"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblHeader As Label
	Friend WithEvents txtWordToList As TextBox
	Friend WithEvents btnWordAdd As Button
	Friend WithEvents lblWordList As Label
	Friend WithEvents btnNewWS As Button
	Friend WithEvents btnGenerate As Button
	Friend WithEvents cbxWordList As ComboBox
	Friend WithEvents btnAddToWS As Button
	Friend WithEvents btnWordRemove As Button
	Friend WithEvents lblSubHeader As Label

End Class
