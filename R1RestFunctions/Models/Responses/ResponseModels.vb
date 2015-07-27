Namespace Models
    Public Class Response
        Public Class ApiResponse(Of T)
            Public Property Success As Boolean
            Public Property [Error] As [Error]
            Public Property Data As T
        End Class
        Public Class [Error]
            Public Property StatusCode As Integer
            Public Property Message As String
        End Class
    End Class
End Namespace