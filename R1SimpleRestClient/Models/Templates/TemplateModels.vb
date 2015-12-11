Namespace Models.Templates
    Public Class Templates
        Public Property name As String
        Public Property description As String
        Public Property templateID As String
        Public Property jobDefinition As String
        Public Property isSystemJob As Boolean
        Public Property updateJobOptionsOnCreation As Boolean
        Public Property jobType As String
    End Class

    Public Class Template
        Public Property name As String
        Public Property description As String
        Public Property templateId As String
        Public Property sortOrder As Integer
    End Class

    Public Class Categories
        Public Property categoryId As String
        Public Property name As String
        Public Property templates As New List(Of Template)
        Public Property sortOrder As Integer
    End Class

    Public Class TemplateInformation
        Public Property name As String
        Public Property description As String
        Public Property templateId As String
        Public Property jobDefinition As Models.Job2.JobDefinition
        Public Property isSystemJob As Boolean
        Public Property updateJobOptionsOnCreation As Boolean
        Public Property jobType As Integer
    End Class
End Namespace
