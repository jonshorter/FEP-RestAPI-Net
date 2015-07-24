Public Class Models




    Public Class ApiResponse(Of T)
        Public Property Success As Boolean
        Public Property [Error] As [Error]
        Public Property Data As T
    End Class
    Public Class [Error]
        Public Property StatusCode As Integer
        Public Property Message As String
    End Class


    Public Enum ProcessModeEnum
        eDiscoveryMode
        FieldMode
        FTKMode
        eDiscoveryNoIndexing
        Custom
        Security
    End Enum

    Public Class ProjectInformation
        Public Property forceHasChanges As Integer
        Public Property projectId As String
        Public Property projectType As String 'Object
        Public Property name As String
        Public Property description As String ' object
        Public Property createdDate As DateTime
        Public Property createdByUsername As String
        Public Property modifiedDate As DateTime
        Public Property modifiedByUsername As String
        Public Property ftkCaseId As Integer
        Public Property ftkCaseFolderPath As String
        Public Property responsiveFilePath As String
        Public Property isSensitive As Boolean
        Public Property priority As Integer
        Public Property priorityText As String
        Public Property agentPriority As Integer
        Public Property status As Integer
        Public Property statusText As String
        Public Property size As Double
        Public Property jobsCount As Integer
        Public Property attorney As String
        Public Property jurisdiction As String
        Public Property legalAssistant As String
        Public Property outsideCounsel As String
        Public Property comments As String 'Object
        Public Property effectiveStartDate As String 'Object
        Public Property effectiveEndDate As String 'Object
        Public Property selectedCertificateId As String 'Object
        Public Property mainPasswordString As String 'Object
        Public Property hasPassword As Boolean
        Public Property encryptedPassword As String 'Object
        Public Property encryptionPasswordSalt As String 'Object
        Public Property customPropertyValues As List(Of Object) 'Object
        Public Property encryptionType As String 'Object
        Public Property networkAcquisitionRetainValue As Integer
        Public Property networkAcquisitionPurgeFirstPurge As DateTime
        Public Property networkAcquisitionFrequencyValue As Integer
        Public Property eventRetainValue As Integer
        Public Property eventFirstPurge As DateTime
        Public Property purgeEventsEnabled As Boolean
        Public Property purgeVolatileEnabled As Boolean
        Public Property purgeNetworkEnabled As Boolean
        Public Property eventFrequencyValue As Integer
        Public Property volatileRetainValue As Integer
        Public Property volatilePurgeFirstPurge As DateTime
        Public Property volatileFrequencyValue As Integer
        Public Property feedCheckingEnabled As Boolean
        Public Property feedVirusTotalEnabled As Boolean
        Public Property feedDataPurgeEnabled As Boolean
        Public Property displayTimeZone As String 'Object
        Public Property defaultSortColumn As String 'Object
        Public Property defaultSortOrder As String 'Object
    End Class

    Public Enum JobAction
        Create
        Approve
        Execute
        Cancel
        Status
    End Enum

    Public Class AlertSourceBreakdownResult
        Public Property Name As String
        Public Property Count As Integer
        Public Property Percent As Integer
    End Class

    Public Class JobDefinitionModel
        Public Property JobDef As Object ' JobDefinition
        Public Property ProjectId As Long
        Public Property JobAction As JobAction
        Public Property ComputerTargets As Target
        Public Property NetworkShareTargets As Target
    End Class

    Public Class Target
        Public Property Addresses As List(Of String)
        Public Property SearchString As String
    End Class

    Public Class JobInfo
        Public Property JobID As Guid
        Public Property Name As String
        Public Property JobType As String
        Public Property Status As String
        Public Property Targets As String()
    End Class

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

    Public Enum JobTypes
        SearchAndReview
        MetadataOnly
        ReportOnly
        Archive
        Remediate
        RemediateAndReview
        RMM
        Volatile
        MemoryAnalysis
        MemoryAcquisition
        SoftwareInventory
        AgentRemediation
        MemoryOperations
        NetworkAcquisition
        CombinationJob
        ProcessDump
        ThreatScan
        EventEndpointQuery
    End Enum


    Public Enum CaseReportType
        ProductionSet
        ProcessingExceptions
        Search
        Generic
        AuditLog
        ImageConversionExceptions
        ExportRenamingMap
        TBRSet
        DataVolume_EncryptedFiles
        DataVolume_CaseBreakout
        DataVolume_CustodianBreakout
        DeduplicationFiles
        DeduplicationEmails
        DataVolume
        LegalMatterResultReport
        CompletionStatus
        CustodianDataMap
        Bookmark
    End Enum
    Public Enum CaseReportStatus
        Initializing
        Populating
        Completed
        Failed
    End Enum


End Class
