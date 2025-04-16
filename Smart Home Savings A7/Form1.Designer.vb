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
		Label1 = New Label()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.Image = My.Resources.Resources.smarthome
		PictureBox1.Location = New Point(12, 26)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(374, 262)
		PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(495, 125)
		Label1.Name = "Label1"
		Label1.Size = New Size(41, 15)
		Label1.TabIndex = 1
		Label1.Text = "Label1"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(Label1)
		Controls.Add(PictureBox1)
		Name = "Form1"
		Text = "Form1"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label

End Class
