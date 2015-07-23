Imports ADG.Wizard.Shared.Filters
Imports ADG.Wizard.Shared
Imports ADG.ServicesCommon
Imports System.Runtime.Serialization
Imports ADG.Wizard.Shared.Filters.JobFilters
Imports ADG.WebLab.Web.Controllers.API.Job.Target

Module R1SimpleRestClasses
    Public Class Project
        Public Property name As String
        Public Property FTKCaseFolderPath As String
        Public Property ResponsiveFilePath As String
        Public Property ProcessingMode As ProcessModeEnum



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
        Public Property customPropertyValues As String 'Object
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

    Public Class ProjectList
        Public Property success As Boolean
        Public Property err As String
        Public Property data As List(Of ProjectInformation)
    End Class

    Public Class JobList
        Public Property success As Boolean
        Public Property err As String
        Public Property data As List(Of ADG.WebLab.Web.Controllers.API.Job.JobInfo)
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




End Module
