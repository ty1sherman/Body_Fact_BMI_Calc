<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBFP
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBFP))
		Me.picMale = New System.Windows.Forms.PictureBox()
		Me.picFemale = New System.Windows.Forms.PictureBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblChoose = New System.Windows.Forms.Label()
		Me.radMale = New System.Windows.Forms.RadioButton()
		Me.radFemale = New System.Windows.Forms.RadioButton()
		Me.lblWaist = New System.Windows.Forms.Label()
		Me.lblNeck = New System.Windows.Forms.Label()
		Me.lblHip = New System.Windows.Forms.Label()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.btnCalc = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.txtHip = New System.Windows.Forms.TextBox()
		Me.txtNeck = New System.Windows.Forms.TextBox()
		Me.txtWaist = New System.Windows.Forms.TextBox()
		Me.lblBFPResults = New System.Windows.Forms.Label()
		Me.lblBFPMessage = New System.Windows.Forms.Label()
		Me.lblHeight = New System.Windows.Forms.Label()
		Me.txtHeight = New System.Windows.Forms.TextBox()
		Me.picBodyFatStandards = New System.Windows.Forms.PictureBox()
		Me.picJacksonPollard = New System.Windows.Forms.PictureBox()
		CType(Me.picMale, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picFemale, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picBodyFatStandards, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picJacksonPollard, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picMale
		'
		Me.picMale.Image = CType(resources.GetObject("picMale.Image"), System.Drawing.Image)
		Me.picMale.Location = New System.Drawing.Point(12, 12)
		Me.picMale.Name = "picMale"
		Me.picMale.Size = New System.Drawing.Size(100, 94)
		Me.picMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picMale.TabIndex = 0
		Me.picMale.TabStop = False
		'
		'picFemale
		'
		Me.picFemale.Image = CType(resources.GetObject("picFemale.Image"), System.Drawing.Image)
		Me.picFemale.Location = New System.Drawing.Point(12, 12)
		Me.picFemale.Name = "picFemale"
		Me.picFemale.Size = New System.Drawing.Size(100, 94)
		Me.picFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picFemale.TabIndex = 1
		Me.picFemale.TabStop = False
		Me.picFemale.Visible = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.Location = New System.Drawing.Point(130, 43)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(232, 25)
		Me.lblTitle.TabIndex = 2
		Me.lblTitle.Text = "Body Fat Percentage"
		'
		'lblChoose
		'
		Me.lblChoose.AutoSize = True
		Me.lblChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChoose.Location = New System.Drawing.Point(173, 100)
		Me.lblChoose.Name = "lblChoose"
		Me.lblChoose.Size = New System.Drawing.Size(147, 18)
		Me.lblChoose.TabIndex = 3
		Me.lblChoose.Text = "Choose your gender:"
		'
		'radMale
		'
		Me.radMale.AutoSize = True
		Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.radMale.Location = New System.Drawing.Point(176, 130)
		Me.radMale.Name = "radMale"
		Me.radMale.Size = New System.Drawing.Size(56, 20)
		Me.radMale.TabIndex = 4
		Me.radMale.TabStop = True
		Me.radMale.Text = "Male"
		Me.radMale.UseVisualStyleBackColor = True
		'
		'radFemale
		'
		Me.radFemale.AutoSize = True
		Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.radFemale.Location = New System.Drawing.Point(260, 130)
		Me.radFemale.Name = "radFemale"
		Me.radFemale.Size = New System.Drawing.Size(72, 20)
		Me.radFemale.TabIndex = 5
		Me.radFemale.TabStop = True
		Me.radFemale.Text = "Female"
		Me.radFemale.UseVisualStyleBackColor = True
		'
		'lblWaist
		'
		Me.lblWaist.AutoSize = True
		Me.lblWaist.Location = New System.Drawing.Point(95, 205)
		Me.lblWaist.Name = "lblWaist"
		Me.lblWaist.Size = New System.Drawing.Size(200, 13)
		Me.lblWaist.TabIndex = 7
		Me.lblWaist.Text = "Enter your waist circumference in inches:"
		'
		'lblNeck
		'
		Me.lblNeck.AutoSize = True
		Me.lblNeck.Location = New System.Drawing.Point(95, 239)
		Me.lblNeck.Name = "lblNeck"
		Me.lblNeck.Size = New System.Drawing.Size(200, 13)
		Me.lblNeck.TabIndex = 8
		Me.lblNeck.Text = "Enter your neck circumference in inches:"
		'
		'lblHip
		'
		Me.lblHip.AutoSize = True
		Me.lblHip.Location = New System.Drawing.Point(95, 272)
		Me.lblHip.Name = "lblHip"
		Me.lblHip.Size = New System.Drawing.Size(190, 13)
		Me.lblHip.TabIndex = 10
		Me.lblHip.Text = "Enter your hip circumference in inches:"
		'
		'btnReset
		'
		Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReset.Location = New System.Drawing.Point(98, 483)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(75, 31)
		Me.btnReset.TabIndex = 12
		Me.btnReset.Text = "Clear"
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'btnCalc
		'
		Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalc.Location = New System.Drawing.Point(277, 483)
		Me.btnCalc.Name = "btnCalc"
		Me.btnCalc.Size = New System.Drawing.Size(85, 31)
		Me.btnCalc.TabIndex = 13
		Me.btnCalc.Text = "Calculate"
		Me.btnCalc.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(473, 483)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 31)
		Me.btnExit.TabIndex = 14
		Me.btnExit.Text = "&Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'txtHip
		'
		Me.txtHip.Location = New System.Drawing.Point(335, 272)
		Me.txtHip.Name = "txtHip"
		Me.txtHip.Size = New System.Drawing.Size(42, 20)
		Me.txtHip.TabIndex = 16
		'
		'txtNeck
		'
		Me.txtNeck.Location = New System.Drawing.Point(335, 239)
		Me.txtNeck.Name = "txtNeck"
		Me.txtNeck.Size = New System.Drawing.Size(42, 20)
		Me.txtNeck.TabIndex = 18
		'
		'txtWaist
		'
		Me.txtWaist.Location = New System.Drawing.Point(335, 205)
		Me.txtWaist.Name = "txtWaist"
		Me.txtWaist.Size = New System.Drawing.Size(42, 20)
		Me.txtWaist.TabIndex = 19
		'
		'lblBFPResults
		'
		Me.lblBFPResults.AutoSize = True
		Me.lblBFPResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBFPResults.Location = New System.Drawing.Point(202, 305)
		Me.lblBFPResults.Name = "lblBFPResults"
		Me.lblBFPResults.Size = New System.Drawing.Size(0, 16)
		Me.lblBFPResults.TabIndex = 21
		'
		'lblBFPMessage
		'
		Me.lblBFPMessage.AutoSize = True
		Me.lblBFPMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBFPMessage.Location = New System.Drawing.Point(95, 346)
		Me.lblBFPMessage.Name = "lblBFPMessage"
		Me.lblBFPMessage.Size = New System.Drawing.Size(0, 16)
		Me.lblBFPMessage.TabIndex = 22
		'
		'lblHeight
		'
		Me.lblHeight.AutoSize = True
		Me.lblHeight.Location = New System.Drawing.Point(95, 172)
		Me.lblHeight.Name = "lblHeight"
		Me.lblHeight.Size = New System.Drawing.Size(135, 13)
		Me.lblHeight.TabIndex = 23
		Me.lblHeight.Text = "Enter your height in inches:"
		'
		'txtHeight
		'
		Me.txtHeight.Location = New System.Drawing.Point(335, 172)
		Me.txtHeight.Name = "txtHeight"
		Me.txtHeight.Size = New System.Drawing.Size(42, 20)
		Me.txtHeight.TabIndex = 24
		'
		'picBodyFatStandards
		'
		Me.picBodyFatStandards.Image = CType(resources.GetObject("picBodyFatStandards.Image"), System.Drawing.Image)
		Me.picBodyFatStandards.Location = New System.Drawing.Point(412, 43)
		Me.picBodyFatStandards.Name = "picBodyFatStandards"
		Me.picBodyFatStandards.Size = New System.Drawing.Size(231, 182)
		Me.picBodyFatStandards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picBodyFatStandards.TabIndex = 25
		Me.picBodyFatStandards.TabStop = False
		'
		'picJacksonPollard
		'
		Me.picJacksonPollard.Image = CType(resources.GetObject("picJacksonPollard.Image"), System.Drawing.Image)
		Me.picJacksonPollard.Location = New System.Drawing.Point(412, 255)
		Me.picJacksonPollard.Name = "picJacksonPollard"
		Me.picJacksonPollard.Size = New System.Drawing.Size(231, 186)
		Me.picJacksonPollard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picJacksonPollard.TabIndex = 26
		Me.picJacksonPollard.TabStop = False
		'
		'frmBFP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(655, 526)
		Me.Controls.Add(Me.picJacksonPollard)
		Me.Controls.Add(Me.picBodyFatStandards)
		Me.Controls.Add(Me.txtHeight)
		Me.Controls.Add(Me.lblHeight)
		Me.Controls.Add(Me.lblBFPMessage)
		Me.Controls.Add(Me.lblBFPResults)
		Me.Controls.Add(Me.txtWaist)
		Me.Controls.Add(Me.txtNeck)
		Me.Controls.Add(Me.txtHip)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnCalc)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.lblHip)
		Me.Controls.Add(Me.lblNeck)
		Me.Controls.Add(Me.lblWaist)
		Me.Controls.Add(Me.radFemale)
		Me.Controls.Add(Me.radMale)
		Me.Controls.Add(Me.lblChoose)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.picFemale)
		Me.Controls.Add(Me.picMale)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmBFP"
		Me.Text = "Body Fat Percentage"
		CType(Me.picMale, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picFemale, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picBodyFatStandards, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picJacksonPollard, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents picMale As PictureBox
	Friend WithEvents picFemale As PictureBox
	Friend WithEvents lblTitle As Label
	Friend WithEvents lblChoose As Label
	Friend WithEvents radMale As RadioButton
	Friend WithEvents radFemale As RadioButton
	Friend WithEvents lblWaist As Label
	Friend WithEvents lblNeck As Label
	Friend WithEvents lblHip As Label
	Friend WithEvents btnReset As Button
	Friend WithEvents btnCalc As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents txtHip As TextBox
	Friend WithEvents txtNeck As TextBox
	Friend WithEvents txtWaist As TextBox
	Friend WithEvents lblBFPResults As Label
	Friend WithEvents lblBFPMessage As Label
	Friend WithEvents lblHeight As Label
	Friend WithEvents txtHeight As TextBox
	Friend WithEvents picBodyFatStandards As PictureBox
	Friend WithEvents picJacksonPollard As PictureBox
End Class
