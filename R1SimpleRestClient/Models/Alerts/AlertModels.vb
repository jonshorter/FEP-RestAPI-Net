Namespace Models
    Public Class Alert

        Public Class AlertSourceBreakdownResult
            Public Property Name As String
            Public Property Count As Integer
            Public Property Percent As Integer
        End Class

        Public Class MeanTimeStatistics
            Public Property meanTime As String
            Public Property responseTimeType As Integer
        End Class

        Public Class AlertsWithCounts
            Public Property entities As New List(Of AlertDataDetails)
            Public Property totalCount As Integer
        End Class

        Public Class AlertDetails
            Public Property alertDataDetails As New AlertDataDetails
            Public Property threatLookupDescription As String
        End Class
        Public Class AlertDataDetails
            Public Property objectCount As Integer
            Public Property alertId As Integer
            Public Property objectId As String
            Public Property caseName As String
            Public Property createDate As DateTime
            Public Property source As String
            Public Property target As String
            Public Property caseId As Integer
            Public Property severity As Integer
            Public Property description As String
            Public Property viewed As Boolean
            Public Property alertSourceType As Integer
            Public Property cifHash As String
            Public Property assessment As String
            Public Property confidence As Double
            Public Property alertIntelSource As String
            Public Property alertScanDetails As String
            Public Property alternateArtifactName As String
            Public Property artifactName As String
            Public Property alertStatus As Integer
            Public Property userFlagged As Integer
            Public Property respondedDate As String
            Public Property validatedDate As String
            Public Property dataSourceType As Integer
            Public Property datasourceAppDbId As String
            Public Property virusTotalMax As String
        End Class

    End Class
End Namespace