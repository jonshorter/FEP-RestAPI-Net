Imports Newtonsoft.Json

Namespace Models.ThreatFilters
    Public Class ThreatFilterResponse
        <JsonProperty("$type")>
        Public Property Type As String
        'Public Property [values] As List(Of ThreatFilterInfo)
        <JsonProperty("$values")>
        Public Property Values As New List(Of ThreatFilterInfo)
    End Class
    Public Class ThreatFilterInfo
        <JsonProperty("filterId")>
        Public Property FilterId As Integer

        <JsonProperty("totalItemCount")>
        Public Property TotalItemCount As Integer

        <JsonProperty("xmlData")>
        Public Property XmlData As Object

        <JsonProperty("name")>
        Public Property Name As String

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("source")>
        Public Property Source As String

        <JsonProperty("authoredDate")>
        Public Property AuthoredDate As DateTime

        <JsonProperty("authoredBy")>
        Public Property AuthoredBy As String

        <JsonProperty("category")>
        Public Property Category As String

        <JsonProperty("filterType")>
        Public Property FilterType As ThreatFilterType

        <JsonProperty("groups")>
        Public Property Groups As String

        <JsonProperty("tags")>
        Public Property Tags As String
    End Class
    Public Enum ThreatFilterType
        IOC = 1
        YARA = 2
    End Enum

End Namespace
