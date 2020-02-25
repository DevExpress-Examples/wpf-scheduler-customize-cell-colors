Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace DXSample.ViewModels
	Public Class SchedulingViewModel
		Inherits ViewModelBase

		Public Sub New()
			Appointments = DataHelper.GetAppointments()
			Resources = DataHelper.GetResources()
			TimeRegions = DataHelper.GetTimeRegions()
		End Sub
		Public Property Appointments() As ObservableCollection(Of AppointmentViewModel)
			Get
				Return GetValue(Of ObservableCollection(Of AppointmentViewModel))()
			End Get
			Set(ByVal value As ObservableCollection(Of AppointmentViewModel))
				SetValue(value)
			End Set
		End Property
		Public Property Resources() As ObservableCollection(Of ResourceViewModel)
			Get
				Return GetValue(Of ObservableCollection(Of ResourceViewModel))()
			End Get
			Set(ByVal value As ObservableCollection(Of ResourceViewModel))
				SetValue(value)
			End Set
		End Property
		Public Property TimeRegions() As ObservableCollection(Of TimeRegionViewModel)
			Get
				Return GetValue(Of ObservableCollection(Of TimeRegionViewModel))()
			End Get
			Set(ByVal value As ObservableCollection(Of TimeRegionViewModel))
				SetValue(value)
			End Set
		End Property
	End Class
End Namespace