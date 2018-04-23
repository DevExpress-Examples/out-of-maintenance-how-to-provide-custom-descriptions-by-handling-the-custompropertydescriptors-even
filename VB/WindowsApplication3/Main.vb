Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnCustomPropertyDescriptors(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomPropertyDescriptorsEventArgs) Handles propertyGridControl1.CustomPropertyDescriptors
			Dim grid As PropertyGridControl = TryCast(sender, PropertyGridControl)
			Dim sourceColl As PropertyDescriptorCollection = TypeDescriptor.GetProperties(grid.SelectedObject)
			Dim destColl As New PropertyDescriptorCollection(Nothing)
			For Each pd As PropertyDescriptor In sourceColl
				destColl.Add(New MyPropertyDescriptor(pd))
			Next pd
			e.Properties = destColl
		End Sub
	End Class
End Namespace
