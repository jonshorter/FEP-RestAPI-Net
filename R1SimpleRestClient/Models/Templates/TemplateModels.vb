Namespace Models.Templates
    Public Class Templates
        Public name As String
        Public description As String
        Public templateID As String
        Public jobDefinition As String
        Public isSystemJob As Boolean
        Public updateJobOptionsOnCreation As Boolean
        Public jobType As String
    End Class

    Public Class Template
        Public name As String
        Public description As String
        Public templateId As String
        Public sortOrder As Integer
    End Class

    Public Class Categories
        Public categoryId As String
        Public name As String
        Public templates As New List(Of Template)
        Public sortOrder As Integer
    End Class

    Public Class TemplateInformation
        Public name As String
        Public description As String
        Public templateId As String
        Public jobDefinition As Models.Job2.JobDefinition
        Public isSystemJob As Boolean
        Public updateJobOptionsOnCreation As Boolean
        Public jobType As Integer
    End Class
End Namespace
