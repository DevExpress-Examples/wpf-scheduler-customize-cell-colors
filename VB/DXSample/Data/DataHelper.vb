Imports System
Imports System.Collections.ObjectModel
Imports System.Windows.Media

Namespace DXSample.ViewModels
	Friend Class DataHelper
		Public Shared Function GetAppointments() As ObservableCollection(Of AppointmentViewModel)
			Dim collection As New ObservableCollection(Of AppointmentViewModel)() From {
				New AppointmentViewModel() With {
					.Id = 1,
					.StartTime = DateTime.Today.AddDays(-1),
					.EndTime = DateTime.Today.AddDays(4),
					.ResourceId = 1,
					.Subject = "Task 1"
				},
				New AppointmentViewModel() With {
					.Id = 2,
					.StartTime = DateTime.Today,
					.EndTime = DateTime.Today.AddDays(5),
					.ResourceId = 1,
					.Subject = "Task 2"
				},
				New AppointmentViewModel() With {
					.Id = 3,
					.StartTime = DateTime.Today.AddDays(2),
					.EndTime = DateTime.Today.AddDays(7),
					.ResourceId = 2,
					.Subject = "Task 3"
				}
			}
			Return collection
		End Function

		Public Shared Function GetResources() As ObservableCollection(Of ResourceViewModel)
			Dim collection As New ObservableCollection(Of ResourceViewModel)() From {
				New ResourceViewModel() With {
					.Id = 1,
					.Caption = "Work",
					.Brush = Brushes.LightGreen
				},
				New ResourceViewModel() With {
					.Id = 2,
					.Caption = "Personal",
					.Brush = Brushes.LightSkyBlue
				}
			}
			Return collection
		End Function
		Public Shared Function GetTimeRegions() As ObservableCollection(Of TimeRegionViewModel)
			Dim collection As New ObservableCollection(Of TimeRegionViewModel)() From {
				New TimeRegionViewModel() With {
					.Id = 1,
					.ResourceId = 2,
					.StartTime = DateTime.Today.AddDays(-50),
					.EndTime = DateTime.Today.AddDays(50),
					.Brush = Brushes.LightPink
				},
				New TimeRegionViewModel() With {
					.Id = 2,
					.ResourceId = 1,
					.StartTime = DateTime.Today.AddDays(-50),
					.EndTime = DateTime.Today.AddDays(50),
					.Brush = Brushes.Aquamarine
				}
			}
			Return collection
		End Function
	End Class
End Namespace