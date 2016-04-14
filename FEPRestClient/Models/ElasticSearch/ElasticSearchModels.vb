Namespace Models
    Public Class ElasticSearchResult
        Public Property Took As Integer
        Public Property Timed_Out As Boolean
        Public Property _Shards As New ESShards
        Public Property hits As New ESHits
        Public Property aggregations As New Object
    End Class
    Public Class ESShards
        Public Property Total As Integer
        Public Property Successful As Integer
        Public Property Failed As Integer
    End Class
    Public Class ESHits
        Public Property Total As Integer
        Public Property Max_Score As Nullable(Of Integer)
        Public Property Hits As New List(Of ESHitItems)
    End Class
    Public Class ESHitItems
        Public Property _index As String
        Public Property _type As String
        Public Property _id As String
        Public Property _score As String
        Public Property _source As New Object
        Public Property _sort As New List(Of String)
    End Class

End Namespace
