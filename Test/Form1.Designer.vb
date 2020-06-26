<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Param
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
		Me.trkParam = New System.Windows.Forms.TrackBar()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.lblParam = New System.Windows.Forms.Label()
		CType(Me.trkParam, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'trkParam
		'
		Me.trkParam.LargeChange = 50
		Me.trkParam.Location = New System.Drawing.Point(16, 30)
		Me.trkParam.Maximum = 800
		Me.trkParam.Minimum = 200
		Me.trkParam.Name = "trkParam"
		Me.trkParam.Size = New System.Drawing.Size(226, 45)
		Me.trkParam.TabIndex = 0
		Me.trkParam.Tag = ""
		Me.trkParam.UseWaitCursor = True
		Me.trkParam.Value = 200
		'
		'btnCancel
		'
		Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
		Me.btnCancel.Location = New System.Drawing.Point(158, 81)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'lblParam
		'
		Me.lblParam.AutoSize = True
		Me.lblParam.Location = New System.Drawing.Point(25, 14)
		Me.lblParam.Name = "lblParam"
		Me.lblParam.Size = New System.Drawing.Size(55, 13)
		Me.lblParam.TabIndex = 2
		Me.lblParam.Text = "Parameter"
		'
		'Param
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(269, 127)
		Me.Controls.Add(Me.lblParam)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.trkParam)
		Me.Name = "Param"
		Me.Text = "Parameter"
		CType(Me.trkParam, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents trkParam As TrackBar
	Friend WithEvents btnCancel As Button
	Friend WithEvents lblParam As Label
End Class
