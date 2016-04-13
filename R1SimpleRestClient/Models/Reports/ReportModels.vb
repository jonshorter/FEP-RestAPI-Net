Imports FEPRestClient.Models.Enums

Namespace Models
    Public Class Report

        Public Class BasicReport
            Public Property ReportInfo As ExcelExportInfoPresenter
        End Class
        Public Class ExcelExportInfoPresenter
            Public Property Key As Guid
            Public Property CreationDate As DateTime
            Public Property Description As String
            Public Property ErrorMessage As String
            Public Property FilePath As String
            Public Property ItemsExported As Integer
            Public Property MimeType As String
            Public Property Name As String
            Public Property ReportId As Long
            Public Property ReportType As CaseReportType
            Public Property Status As CaseReportStatus
            Public Property TotalItems As Integer
        End Class

    End Class
End Namespace
