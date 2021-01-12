<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.lblGreeting = New System.Windows.Forms.Label()
		Me.btnBMI = New System.Windows.Forms.Button()
		Me.btnBFP = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblGreeting
		'
		Me.lblGreeting.AutoSize = True
		Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGreeting.Location = New System.Drawing.Point(54, 9)
		Me.lblGreeting.Name = "lblGreeting"
		Me.lblGreeting.Size = New System.Drawing.Size(319, 24)
		Me.lblGreeting.TabIndex = 0
		Me.lblGreeting.Text = "Choose your Index to get started:"
		'
		'btnBMI
		'
		Me.btnBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBMI.Location = New System.Drawing.Point(17, 204)
		Me.btnBMI.Name = "btnBMI"
		Me.btnBMI.Size = New System.Drawing.Size(122, 56)
		Me.btnBMI.TabIndex = 1
		Me.btnBMI.Text = "      (BMI)        Body Mass Index"
		Me.btnBMI.UseVisualStyleBackColor = True
		'
		'btnBFP
		'
		Me.btnBFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBFP.Location = New System.Drawing.Point(275, 204)
		Me.btnBFP.Name = "btnBFP"
		Me.btnBFP.Size = New System.Drawing.Size(140, 56)
		Me.btnBFP.TabIndex = 2
		Me.btnBFP.Text = "         (BFP)           Body Fat Percentage"
		Me.btnBFP.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(328, 307)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "&Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(427, 353)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnBFP)
		Me.Controls.Add(Me.btnBMI)
		Me.Controls.Add(Me.lblGreeting)
		Me.DoubleBuffered = True
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmMain"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblGreeting As Label
	Friend WithEvents btnBMI As Button
	Friend WithEvents btnBFP As Button
	Friend WithEvents btnExit As Button
End Class
