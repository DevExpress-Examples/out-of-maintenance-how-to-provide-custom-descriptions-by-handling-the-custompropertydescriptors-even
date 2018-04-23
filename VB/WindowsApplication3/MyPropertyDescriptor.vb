Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports System.ComponentModel

Namespace DXSample
	Public Class MyPropertyDescriptor
		Inherits PropertyDescriptor
		Private pd As PropertyDescriptor

		Public Sub New(ByVal pd As PropertyDescriptor)
			MyBase.New(pd)
			Me.pd = pd
		End Sub

		Public Overrides ReadOnly Property Description() As String
			Get
				Return String.Format("=====Custom Description:======" & Constants.vbCrLf & " {0}", MyBase.Description)
			End Get
		End Property

		Public Overrides ReadOnly Property ComponentType() As Type
			Get
				Return pd.ComponentType
			End Get
		End Property
		Public Overrides ReadOnly Property IsReadOnly() As Boolean
			Get
				Return pd.IsReadOnly
			End Get
		End Property

		Public Overrides ReadOnly Property PropertyType() As Type
			Get
				Return pd.PropertyType
			End Get
		End Property

		Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
			Return pd.CanResetValue(component)
		End Function

		Public Overrides Function GetValue(ByVal component As Object) As Object
			Return pd.GetValue(component)
		End Function
		Public Overrides Sub ResetValue(ByVal component As Object)
			pd.ResetValue(component)
		End Sub
		Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
			pd.SetValue(component, value)
		End Sub
		Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
			Return pd.ShouldSerializeValue(component)
		End Function
	End Class
End Namespace