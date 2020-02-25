Imports System
Imports System.Windows.Media
Imports DevExpress.Mvvm

Namespace DXSample.ViewModels
	Public Class ResourceViewModel
		Inherits ViewModelBase

		Public Property Id() As Integer
			Get
				Return GetValue(Of Integer)()
			End Get
			Set(ByVal value As Integer)
				SetValue(value)
			End Set
		End Property
		Public Property Caption() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
		Public Property Brush() As SolidColorBrush
			Get
				Return GetValue(Of SolidColorBrush)()
			End Get
			Set(ByVal value As SolidColorBrush)
				SetValue(value)
			End Set
		End Property
	End Class
End Namespace