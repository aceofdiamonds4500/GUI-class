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
		Label1 = New Label()
		Label2 = New Label()
		Button1 = New Button()
		Button2 = New Button()
		Button3 = New Button()
		Button4 = New Button()
		Button5 = New Button()
		Label3 = New Label()
		Button6 = New Button()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.Anchor = AnchorStyles.Top
		Label1.BackColor = SystemColors.Control
		Label1.Location = New Point(49, 22)
		Label1.Name = "Label1"
		Label1.Size = New Size(173, 30)
		Label1.TabIndex = 0
		Label1.Text = "Do you know the French words for the numbers 1 through 5?"
		Label1.TextAlign = ContentAlignment.TopCenter
		' 
		' Label2
		' 
		Label2.Anchor = AnchorStyles.Top
		Label2.BackColor = SystemColors.Control
		Label2.Location = New Point(26, 52)
		Label2.Name = "Label2"
		Label2.Size = New Size(229, 26)
		Label2.TabIndex = 1
		Label2.Text = "Click the buttons below to see them."
		Label2.TextAlign = ContentAlignment.TopCenter
		' 
		' Button1
		' 
		Button1.Anchor = AnchorStyles.Top
		Button1.Cursor = Cursors.Hand
		Button1.Location = New Point(26, 81)
		Button1.Name = "Button1"
		Button1.Size = New Size(41, 23)
		Button1.TabIndex = 2
		Button1.Text = "1"
		Button1.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.Anchor = AnchorStyles.Top
		Button2.Cursor = Cursors.Hand
		Button2.Location = New Point(73, 81)
		Button2.Name = "Button2"
		Button2.Size = New Size(40, 23)
		Button2.TabIndex = 3
		Button2.Text = "2"
		Button2.UseVisualStyleBackColor = True
		' 
		' Button3
		' 
		Button3.Anchor = AnchorStyles.Top
		Button3.Cursor = Cursors.Hand
		Button3.Location = New Point(119, 81)
		Button3.Name = "Button3"
		Button3.Size = New Size(41, 23)
		Button3.TabIndex = 4
		Button3.Text = "3"
		Button3.UseVisualStyleBackColor = True
		' 
		' Button4
		' 
		Button4.Anchor = AnchorStyles.Top
		Button4.Cursor = Cursors.Hand
		Button4.Location = New Point(166, 81)
		Button4.Name = "Button4"
		Button4.Size = New Size(39, 23)
		Button4.TabIndex = 5
		Button4.Text = "4"
		Button4.UseVisualStyleBackColor = True
		' 
		' Button5
		' 
		Button5.Anchor = AnchorStyles.Top
		Button5.Cursor = Cursors.Hand
		Button5.Location = New Point(211, 81)
		Button5.Name = "Button5"
		Button5.Size = New Size(39, 23)
		Button5.TabIndex = 6
		Button5.Text = "5"
		Button5.UseVisualStyleBackColor = True
		' 
		' Label3
		' 
		Label3.Anchor = AnchorStyles.Top
		Label3.AutoSize = True
		Label3.BackColor = Color.PaleGreen
		Label3.BorderStyle = BorderStyle.Fixed3D
		Label3.Cursor = Cursors.Hand
		Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label3.ForeColor = Color.Black
		Label3.Location = New Point(119, 107)
		Label3.Name = "Label3"
		Label3.Size = New Size(77, 32)
		Label3.TabIndex = 7
		Label3.Text = "French"
		Label3.TextAlign = ContentAlignment.TopCenter
		' 
		' Button6
		' 
		Button6.Anchor = AnchorStyles.Top
		Button6.Cursor = Cursors.Hand
		Button6.Location = New Point(119, 145)
		Button6.Name = "Button6"
		Button6.Size = New Size(41, 23)
		Button6.TabIndex = 8
		Button6.Text = "Exit"
		Button6.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(270, 180)
		Controls.Add(Button6)
		Controls.Add(Label3)
		Controls.Add(Button5)
		Controls.Add(Button4)
		Controls.Add(Button3)
		Controls.Add(Button2)
		Controls.Add(Button1)
		Controls.Add(Label2)
		Controls.Add(Label1)
		MaximizeBox = False
		MinimizeBox = False
		Name = "Form1"
		Text = "French Numbers"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents Button6 As Button

End Class
