Namespace Models.ThreatFilters
    Public Class ThreatFilters
        Public type As String
        Public values As New List(Of ThreatFilterInfo)
    End Class
    Public Class ThreatFilterInfo
        Public filterId As Integer
        Public totalItemCount As Integer
        Public xmlData As String
        Public name As String
        Public description As String
        Public source As String
        Public authoredDate As Date
        Public authoredBy As String
        Public category As String
        Public filterType As Integer
        Public groups As String
        Public tags As String
    End Class
End Namespace
