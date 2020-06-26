Public Class Param
	Dim partDoc As Inventor.PartDocument
	Dim param As Inventor.Parameter

	Private Sub Param_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		'Get the Inventor Application object.'
		Dim invApp As Inventor.Application
		invApp = GetObject(, "Inventor.Application")

		'Get the active document. This assumes it's a part document'
		partDoc = invApp.ActiveDocument

		'Get the parameters collection'
		Dim params As Inventor.Parameters
		params = partDoc.ComponentDefinition.Parameters

		'Get the parameter using its name'
		param = params.Item("Length")

	End Sub

	Private Sub trkParam_Scroll(sender As Object, e As EventArgs) Handles trkParam.Scroll
		Dim newValue As Double = trkParam.Value / 1000

		param.Value = newValue
		partDoc.Update()

		lblParam.Text = "Parameter (" & newValue * 10 & " mm)"
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

End Class
