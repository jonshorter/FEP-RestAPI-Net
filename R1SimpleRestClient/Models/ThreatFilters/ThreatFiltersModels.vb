Namespace Models.ThreatFilters
    Public Class ThreatFilters
        Public Property [type] As String
        Public Property [values] As New List(Of ThreatFilterInfo)
    End Class
    Public Class ThreatFilterInfo
        Public Property filterId As Integer
        Public Property totalItemCount As Integer
        Public Property xmlData As String
        Public Property name As String
        Public Property description As String
        Public Property source As String
        Public Property authoredDate As Date
        Public Property authoredBy As String
        Public Property category As String
        Public Property filterType As Integer
        Public Property groups As String
        Public Property tags As String
    End Class
End Namespace
