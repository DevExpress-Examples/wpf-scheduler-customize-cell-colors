Imports DevExpress.Mvvm.POCO
Imports System.Windows.Media

Namespace CustomCellColoring.Model

    Public Class MyCategory

        Protected Sub New(ByVal id As Integer, ByVal name As String, ByVal color As Color)
            Me.Id = id
            Me.Name = name
            ColorInfo = color
        End Sub

        Public Shared Function Create(ByVal id As Integer, ByVal name As String, ByVal color As Color) As MyCategory
            Return ViewModelSource.Create(Function() New MyCategory(id, name, color))
        End Function

        Protected Sub New()
        End Sub

        Public Overridable Property Id As Integer

        Public Overridable Property Name As String

        Public Overridable Property ColorInfo As Color
    End Class
End Namespace
