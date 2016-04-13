Namespace Models
    Public Class Facets
        Public Property Key As String
        Public Property Label As String
        Public Property Options As New List(Of FacetsOptions)
        Public Property TotalOptions As Integer
        Public Property facetSelector As Integer
    End Class
    Public Class FacetsOptions
        Public Property Key As String
        Public Property Label As String
    End Class

    Public Class FacetSearch
        Public Property SearchFields As New List(Of FacetSearchFields)
    End Class
    Public Class FacetSearchFields
        Public Property FieldName As String
        Public Property Values As New List(Of String)
    End Class
End Namespace
