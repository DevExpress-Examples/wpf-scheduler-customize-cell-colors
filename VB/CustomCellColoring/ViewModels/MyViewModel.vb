Imports CustomCellColoring.Model
Imports DevExpress.Mvvm.DataAnnotations
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Media

Namespace CustomCellColoring.ViewModels
    <POCOViewModel> _
    Public Class MyViewModel
        Public Overridable Property Categories() As ObservableCollection(Of MyCategory)
        Protected Sub New()
            Categories = CreateCategories()
            UseCustomCellControlStyle = True
            UseResourceBrushSchema = True
            UseResourceColors = True
        End Sub

        #Region "#CreateCategories"
        Private Function CreateCategories() As ObservableCollection(Of MyCategory)
            Dim result As New ObservableCollection(Of MyCategory)()
            result.Add(MyCategory.Create(0, "White category", Colors.White))
            result.Add(MyCategory.Create(1, "Orange category", Colors.Orange))
            result.Add(MyCategory.Create(2, "Red category", Colors.Red))
            Return result
        End Function
        #End Region ' #CreateCategories

        Public Overridable Property UseResourceBrushSchema() As Boolean
        Public Overridable Property UseResourceColors() As Boolean
        Public Overridable Property UseCustomCellControlStyle() As Boolean
    End Class
End Namespace
