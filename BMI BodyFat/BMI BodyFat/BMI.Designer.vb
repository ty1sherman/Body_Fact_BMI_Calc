<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMI
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBMI))
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblHeight = New System.Windows.Forms.Label()
		Me.lblWeight = New System.Windows.Forms.Label()
		Me.lblResultsTitle = New System.Windows.Forms.Label()
		Me.lblResults = New System.Windows.Forms.Label()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.btnMain = New System.Windows.Forms.Button()
		Me.btnCalc = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.txtHeight = New System.Windows.Forms.TextBox()
		Me.txtWeight = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.Location = New System.Drawing.Point(129, 22)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(195, 25)
		Me.lblTitle.TabIndex = 0
		Me.lblTitle.Text = "Body Mass Index"
		'
		'lblHeight
		'
		Me.lblHeight.AutoSize = True
		Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeight.Location = New System.Drawing.Point(103, 90)
		Me.lblHeight.Name = "lblHeight"
		Me.lblHeight.Size = New System.Drawing.Size(165, 16)
		Me.lblHeight.TabIndex = 1
		Me.lblHeight.Text = "Enter your height in inches:"
		'
		'lblWeight
		'
		Me.lblWeight.AutoSize = True
		Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWeight.Location = New System.Drawing.Point(106, 140)
		Me.lblWeight.Name = "lblWeight"
		Me.lblWeight.Size = New System.Drawing.Size(173, 16)
		Me.lblWeight.TabIndex = 2
		Me.lblWeight.Text = "Enter your weight in pounds:"
		'
		'lblResultsTitle
		'
		Me.lblResultsTitle.AutoSize = True
		Me.lblResultsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblResultsTitle.Location = New System.Drawing.Point(53, 208)
		Me.lblResultsTitle.Name = "lblResultsTitle"
		Me.lblResultsTitle.Size = New System.Drawing.Size(215, 18)
		Me.lblResultsTitle.TabIndex = 3
		Me.lblResultsTitle.Text = "Your Body Mass Index (BMI) is:"
		'
		'lblResults
		'
		Me.lblResults.AutoSize = True
		Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblResults.Location = New System.Drawing.Point(294, 212)
		Me.lblResults.Name = "lblResults"
		Me.lblResults.Size = New System.Drawing.Size(0, 18)
		Me.lblResults.TabIndex = 4
		'
		'lblMessage
		'
		Me.lblMessage.AutoSize = True
		Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.Location = New System.Drawing.Point(84, 254)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(0, 16)
		Me.lblMessage.TabIndex = 5
		'
		'btnMain
		'
		Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMain.Location = New System.Drawing.Point(48, 344)
		Me.btnMain.Name = "btnMain"
		Me.btnMain.Size = New System.Drawing.Size(75, 40)
		Me.btnMain.TabIndex = 6
		Me.btnMain.Text = "   &Return     to Main"
		Me.btnMain.UseVisualStyleBackColor = True
		'
		'btnCalc
		'
		Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalc.Location = New System.Drawing.Point(173, 344)
		Me.btnCalc.Name = "btnCalc"
		Me.btnCalc.Size = New System.Drawing.Size(75, 40)
		Me.btnCalc.TabIndex = 7
		Me.btnCalc.Text = "&Calculate"
		Me.btnCalc.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(297, 344)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 40)
		Me.btnExit.TabIndex = 8
		Me.btnExit.Text = "&Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'txtHeight
		'
		Me.txtHeight.Location = New System.Drawing.Point(297, 90)
		Me.txtHeight.Name = "txtHeight"
		Me.txtHeight.Size = New System.Drawing.Size(40, 20)
		Me.txtHeight.TabIndex = 9
		'
		'txtWeight
		'
		Me.txtWeight.Location = New System.Drawing.Point(297, 137)
		Me.txtWeight.Name = "txtWeight"
		Me.txtWeight.Size = New System.Drawing.Size(40, 20)
		Me.txtWeight.TabIndex = 10
		'
		'frmBMI
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(437, 396)
		Me.Controls.Add(Me.txtWeight)
		Me.Controls.Add(Me.txtHeight)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnCalc)
		Me.Controls.Add(Me.btnMain)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.lblResults)
		Me.Controls.Add(Me.lblResultsTitle)
		Me.Controls.Add(Me.lblWeight)
		Me.Controls.Add(Me.lblHeight)
		Me.Controls.Add(Me.lblTitle)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmBMI"
		Me.Text = "Body Mass Index"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblTitle As Label
	Friend WithEvents lblHeight As Label
	Friend WithEvents lblWeight As Label
	Friend WithEvents lblResultsTitle As Label
	Friend WithEvents lblResults As Label
	Friend WithEvents lblMessage As Label
	Friend WithEvents btnMain As Button
	Friend WithEvents btnCalc As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents txtHeight As TextBox
	Friend WithEvents txtWeight As TextBox
End Class
