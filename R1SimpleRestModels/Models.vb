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

    Public Enum Ad1EncryptionTypes
        Disabled
        Password
        Certificate
    End Enum
    Public Enum AgentRemediateCommandTypes
        KillProcessById
        KillProcessesByName
        [Erase]
        Execute
        GetFile
        GetHash
        SendFile
        Spawn
    End Enum

    Public Enum ComputerDiskType
        CDT_PHYSICAL = 1
        CDT_LOGICAL = 2
        CDT_FILESYSTEM = 3
    End Enum

    Public Enum EndRecurrenceOptions
        NoEndDate
        EndAfter
        EndBy
    End Enum
    Public Enum JobTargetType
        [Group]
        [Custom]
        IpRange
        AllCurrentAndFuture
    End Enum
    Public Enum MemoryOperationsTypes
        MemoryAnalysis
        MemoryAcquisition
        ProcessDump
    End Enum
    Public Enum RecurrencePatternTypes
        Minute
        Hourly
        Daily
        Weekly
        Monthly
        Yearly
    End Enum
    Public Enum RegistryTemplatesEnum
        AutoStart
        General
        Hardware
        UserActivity
    End Enum
    Public Enum SystemJobTypes
        DeployAgents = 3
        VerifyAgentConnectivity = 4
        MapNodesToPeople = 5
    End Enum
    Public Enum ThreatScanSelectionType
        AllFilters
        SelectedFiltersOnly
        IncrementalScanningForRecurringJob
    End Enum
    Public Enum TimeUnitTypes
        Days
        Hours
        Minutes
    End Enum
    Public Enum VolatileRecurrencePatternTypes
        Minute
        Daily
        Hourly
    End Enum

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
    Public Enum WeekDays
        Sunday
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
    End Enum
    Public NotInheritable Class JobDefinition
        Inherits JobDefinitionBase
     
        Private _secondaryActionsImmediate As Boolean = True
        Private _UseRoleBasedApproval As Boolean = True
        Private _AdvancedOptions As New AdvancedFilterOptions()
        Private _JamThreshold As Integer = 20
        Private _secondaryActionTemplateId As Guid
        Private _secondaryActionsEnabled As Boolean
        Private _threatScanIsReportOnly As Boolean
        Private _UseCollectionTemplate As Boolean
        Private _InheritResponsivePath As Boolean
        Private _InheritJobPriorityFromProject As Boolean
        Private _InheritAgentPriorityFromProject As Boolean
        Private _AD1EncryptionInheritFromProject As Boolean
        Private _AutoProcessJob As Boolean
        Private _DestinationRoot As String
        Private _ProjectResponsiveFilePath As String
        Private _JobApprovers As ObservableCollection(Of Long)
        Private _ShareFilters As IncludeExcludeFilterContainer
        Private _ComputerFilters As IncludeExcludeFilterContainer
        Private _JobArchiveAndRemediateInfo As JobArchiveAndRemediateInfo
        Private _JobType As System.Nullable(Of JobTypes)
        Private _ProjectId As Guid
        Private _rmPolicyDefinition As RMPolicyDefinition
        Private _rmPolicyDefinition2 As RMPolicyDefinition2
        Private _jobSchedule As JobSchedule
        Private _VolatileDefinition As VolatileDefinition
        Private _VolatileScheduleDefinition As VolatileScheduleDefinition
        Private _MemoryAnalysisDefinition As MemoryAnalysisDefinition
        Private _AgentRemediateInfo As AgentRemediateInfo
        Private _MemoryAcquisitionInfo As MemoryAcquisitionInfo
        Private _processDumpInfo As ProcessDumpInfo
        Private _CombinationJobInfo As CombinationJobInfo
        Private _IsFullDiskAcquisition As Boolean
        Private Shared _HasAgentOperationsDefinitionName As String
        Private _BasicJamSelected As Boolean
        Private _AdvancedJamSelected As Boolean
        Private _ShowUnscorables As Boolean
        Private _MemoryOperationsType As MemoryOperationsTypes
        Private _networkAcquisitionDefinition As NetworkAcquisitionDefinition
        Private _CreateArchiveFileOnAgent As Boolean
        Private _KFFInfo As KFFInfo
        Private _ThreatScanJobOptions As ThreatScanJobOptions
        Private _DisableHashing As Boolean
        Private _RecurringIncrementalCollection As Boolean
        Private _runScriptsOnJobCompletion As Boolean
        Private _impersonationUsername As String
        Private _impersonationDomain As String
        Private _impersonationPasswordEncrypted As String
        Private _ImpersonationPasswordEncryptedChanged As Boolean
        Private _scriptFileName As String
    End Class
    Public NotInheritable Class IncludeExcludeFilterContainer

        Private _InclusionFilters As ObservableCollection(Of Filters)
        Private _ExclusionFilters As ObservableCollection(Of Filters)
    End Class

    Public Class Filters

        Private Shared ReadOnly _exampleQueries As String = String.Empty
        Private Shared ReadOnly _exampleRegexQueries As String = String.Empty
        Private _extensions As String = String.Empty
        Private _pathUrlContains As String = String.Empty
        Private _fileSize As String = String.Empty
        Private _fileSizeDistribution As FileSizeDistributionOptions = FileSizeDistributionOptions.FSDO_GREATERTHAN
        Private _creationDate As New FilterDateRange()
        Private _modifiedDate As New FilterDateRange()
        Private _accessedDate As New FilterDateRange()
        Private _subject As String = String.Empty
        Private _senderEmails As String = String.Empty
        Private _senderNames As String = String.Empty
        Private _recipients As String = String.Empty
        Private _cc As String = String.Empty
        Private _bcc As String = String.Empty
        Private _folderNames As String = String.Empty
        Private _title As String = String.Empty
        Private _owners As String = String.Empty
        Private _authors As String = String.Empty
        Private _editors As String = String.Empty
        Private _CustomRegexString As String = String.Empty
        Private _MD5HashsEntryText As String = String.Empty
        Private _Keywords As String = String.Empty
        Private _HitRadius As Integer = 1
        Private _noFileStubbing As Boolean = True
        Private _RemediationFileID As New System.Nullable(Of Guid)()
        Private _RemediationFiles As New ObservableCollection(Of RemediationFile)()
        Private _DatabaseView As New StringMatchSimpleFilter()
        Private _DatabaseDesignTemplate As New StringMatchSimpleFilter()
        Private _ReplicaID As New StringMatchSimpleFilter()
        Private _DataBaseName As New StringMatchSimpleFilter()
        Private _filterId As Guid = Guid.Empty
        Private _exampleQuery As String = Filters._exampleQueries
        Private _filterName As String = String.Empty
        Private _isKeyWordSearch As Boolean = True
        Public Const FilterNamePropertyName As String = "FilterName"
        Public Const ExtensionsPropertyName As String = "Extensions"
        Public Const FileExtensionOptionsPropertyName As String = "FileExtensionOptions"
        Public Const PathURLContainsPropertyName As String = "PathURLContains"
        Public Const NameMatchPropertyName As String = "NameMatch"
        Public Const FileSizePropertyName As String = "FileSize"
        Public Const FileSizeDistributionPropertyName As String = "FileSizeDistribution"
        Public Const FileSizeMagnitudePropertyName As String = "FileSizeMagnitude"
        Public Const CreationDatePropertyName As String = "CreationDate"
        Public Const ModifiedDatePropertyName As String = "ModifiedDate"
        Public Const AccessedDatePropertyName As String = "AccessedDate"
        Public Const SubjectPropertyName As String = "Subject"
        Public Const SenderEmailsPropertyName As String = "SenderEmails"
        Public Const SenderNamesPropertyName As String = "SenderNames"
        Public Const RecipientsPropertyName As String = "Recipients"
        Public Const CCsPropertyName As String = "CCs"
        Public Const BCCsPropertyName As String = "BCCs"
        Public Const FolderNamesPropertyName As String = "FolderNames"
        Public Const TitlePropertyName As String = "Title"
        Public Const OwnersPropertyName As String = "Owners"
        Public Const AuthorPropertyName As String = "Author"
        Public Const EditorsPropertyName As String = "Editors"
        Public Const FilterHasChangesPropertyName As String = "FilterHasChanges"
        Public Const SearchEmailContentPropertyName As String = "SearchEmailContent"
        Public Const SearchAttachmentsPropertyName As String = "SearchAttachments"
        Public Const CreditCardNumbersPropertyName As String = "CreditCardNumbers"
        Public Const CustomRegexPropertyName As String = "CustomRegex"
        Public Const CustomRegexStringPropertyName As String = "CustomRegexString"
        Public Const MD5HashsEntryTextPropertyName As String = "MD5HashsEntryText"
        Public Const CustomContentMatchOptionsPropertyName As String = "CustomContentMatchOptions"
        Public Const KeywordsPropertyName As String = "Keywords"
        Public Const IsKeyWordSearchPropertyName As String = "IsKeyWordSearch"
        Public Const IsRegExSearchPropertyName As String = "IsRegExSearch"
        Public Const HitRadiusPropertyName As String = "HitRadius"
        Public Const HideHitsPropertyName As String = "HideHits"
        Public Const HaveFileLevelThresholdPropertyName As String = "HaveFileLevelThreshold"
        Public Const FileLevelThresholdPropertyName As String = "FileLevelThreshold"
        Public Const UseExistingRemediationFilePropertyName As String = "UseExistingRemediationFile"
        Public Const RemediationFileIDPropertyName As String = "RemediationFileID"
        Public Const RemediationFilesPropertyName As String = "RemediationFiles"
        Public Const SelectedRemediationFilePropertyName As String = "SelectedRemediationFile"
        Public Const IncludeKFFAlertPropertyName As String = "IncludeKFFAlert"
        Public Const IncludeKFFUnknownPropertyName As String = "IncludeKFFUnknown"
        Public Const IncludeKFFIgnorePropertyName As String = "IncludeKFFIgnore"
        Public Const DatabaseViewPropertyName As String = "DatabaseView"
        Public Const DatabaseDesignTemplatePropertyName As String = "DatabaseDesignTemplate"
        Public Const ReplicaIDPropertyName As String = "ReplicaID"
        Public Const DataBaseNamePropertyName As String = "DataBaseName"
        Public Const FilterIDPropertyName As String = "FilterID"
        Private _nameMatch As NameMatchOptions
        Private _fileSizeMagnitude As FileSizeOptions
        Private _fileExtensionOption As FileExtensionOptions
        Private _filterHasChanges As Boolean
        Private _SearchEmailContent As Boolean
        Private _SearchAttachments As Boolean
        Private _CreditCardNumbers As Boolean
        Private _CustomRegex As Boolean
        Private _CustomContentMatchOptions As CustomMatchOptions
        Private _HideHits As Boolean
        Private _HaveFileLevelThreshold As Boolean
        Private _FileLevelThreshold As Integer
        Private _UseExistingRemediationFile As Boolean
        Private _uploadNewFile As Boolean
        Private _SelectedRemediationFile As RemediationFile
        Private _includeKFFAlert As Boolean
        Private _includeKFFIgnore As Boolean
        Private _includeKFFUnknown As Boolean
        Private _isSearchFilenameOnly As Boolean
        Private _isRegexSearch As Boolean
    End Class
    Public Enum FileSizeDistributionOptions
        FSDO_IS
        FSDO_GREATERTHAN
        FSDO_LESSTHAN
        FSDO_ANY
    End Enum

    Public Class FilterDateRange

        Private _DateName As String = String.Empty
        Private _SingleDate As DateTime = DateTime.Now
        Private _FirstRangeDate As DateTime = DateTime.Now
        Private _SecondRangeDate As DateTime = DateTime.Now
        Public Const DateChangedPropertyName As String = "DateChanged"
        Public Const SelectionRangeTypePropertyName As String = "SelectionRangeType"
        Public Const SingleSelectionTypePropertyName As String = "SingleSelectionType"
        Public Const RangeSelectionTypePropertyName As String = "RangeSelectionType"
        Public Const DateNamePropertyName As String = "DateName"
        Public Const SingleDatePropertyName As String = "SingleDate"
        Public Const FirstRangeDatePropertyName As String = "FirstRangeDate"
        Public Const SecondRangeDatePropertyName As String = "SecondRangeDate"
        Private _DateChanged As Boolean
        Private _SelectionRangeType As DateSelectionTypeEnum
        Private _SingleSelectionType As SingleDateSelectionTypeEnum
        Private _RangeSelectionType As RangeDateSelectionTypeEnum
    End Class
    Public Enum DateSelectionTypeEnum
        DR_ANY
        DR_SINGLE
        DR_RANGE
    End Enum
    Public Enum SingleDateSelectionTypeEnum
        SDR_IS
        SDR_BEFORE
        SDR_AFTER
    End Enum
    Public Enum RangeDateSelectionTypeEnum
        SDR_BETWEEN
        SDR_OUTSIDE
    End Enum


    Public Class ObservableCollection(Of T)
        Inherits Collection(Of T)
        Private Const CountString As String = "Count"
        Private Const IndexerName As String = "Item[]"
    End Class

    Public MustInherit Class JobDefinitionBase

        Private _description As String
        Private _jobId As Guid
        Private _jobTargets As JobCustomTargetInfo
        Private _jobIpRangeTargetInfo As JobIpRangeTargetInfo
        Private _name As String
        Private _priority As JobPriorities
        Private _AgentPriority As JobPriorities
        Private _userId As Long
        Private _jobGroupTargetInfo As JobGroupTargetInfo
        Private _isForceEndEnabled As Boolean
        Private _forceEndAfterDays As Integer
        Private _forceEndAfterHours As Integer
        Private _TargetTypeSelected As JobTargetType
        Private _isExpirationTimeShowing As Boolean
        Private _jobExpirationSingleAttempt As Boolean
        Private _jobExpirationCancelPending As Boolean
        Private Shared _JobExpirationCancelPendingName As String
        Private _jobExpirationCancelIncomplete As Boolean
        Private Shared _HasValidCancelOptionName As String
        Private Shared _HasAgentOperationsDefinitionName As String
        Private Shared _AgentOperationsDefinitionName As String
        Private _AgentOperationsDefinition As AgentOperationsDefinition
        Private _EventEndpointOptions As EventEndpointOptions
        Private _IsUseJobTemplateOptionEnabled As Boolean
        Private _SelectedJobTemplate As JobDefinitionTemplate
        Private _SaveAsJobTemplate As Boolean
        Private _includeTemplateTargetOptions As Boolean
    End Class
    Public Class AgentOperationsDefinition
   
        Private _isUninstallNukeAgentChecked As Boolean
        Private Shared _IsUninstallNukeAgentCheckedName As String
        Private Shared _IsMakePublicInstanceCheckedName As String
        Private _isMakePublicInstanceChecked As Boolean
        Private Shared _IsMakeHeartbeatCheckedName As String
        Private _isMakeHeartbeatChecked As Boolean
        Private Shared _AgentUsesProtectedStorageName As String
        Private _AgentUsesProtectedStorage As Boolean
        Private Shared _AgentUsesFileStorageName As String
        Private _AgentUsesFileStorage As Boolean
        Private Shared _IsRuntimeAgentName As String
        Private _IsRuntimeAgent As Boolean
        Private Shared _AgentHasLifetimeName As String
        Private _AgentHasLifetime As Boolean
        Private Shared _SizeOfTheDataStoreMBName As String
        Private _sizeOfTheDataStoreMB As System.Nullable(Of Integer)
        Private Shared _SizeOfTheStoreMBName As String
        Private _sizeOfTheStoreMB As System.Nullable(Of Integer)
        Private Shared _ServiceNameName As String
        Private _serviceName As String
        Private Shared _ExecutableNameName As String
        Private _executableName As String
        Private Shared _PortNumberName As String
        Private _portNumber As System.Nullable(Of Integer)
        Private Shared _PrimaryAgentPortNumberName As String
        Private _primaryAgentPortNumber As System.Nullable(Of Integer)
        Private Shared _SpecifyPortNumberName As String
        Private _SpecifyPortNumber As Boolean
        Private Shared _AgentLifeTimeName As String
        Private _AgentLifeTime As Integer
        Private Shared _AgentLifeTimeUnitName As String
        Private _AgentLifeTimeUnit As System.Nullable(Of TimeUnitTypes)
    End Class
    Public NotInheritable Class AdvancedFilterOptions

        Private _diskType As New System.Nullable(Of ComputerDiskType)(ComputerDiskType.CDT_LOGICAL)
        Private _customDrillDownExtensions As String = ""
        Private _searchType As New System.Nullable(Of ComputerSearchType)(ComputerSearchType.ST_AgentServer)
        Private _UseCustomDrillDownExtensions As Boolean
        Private _scanUnusedDiskArea As Boolean
        Private _scanSystemFiles As Boolean
        Private _scanDeletedFiles As Boolean
        Private _archiveDrillDown As Boolean
        Private _collectResponsiveArchiveFiles As Boolean
        Private _collectNonExtensionFiles As Boolean
        Private _userInternalFileIdentification As Boolean
        Private _collectEncryptedFiles As Boolean
        Private Shared _ExcludeRemovableDrivesName As String
        Private _ExcludeRemovableDrives As Boolean
        Private _includeDiskSectors As Boolean
        Private _startSectorValue As Integer
        Private _endSectorValue As Integer
        Private Shared _ParseI30IndexRecordsName As String
        Private _ParseI30IndexRecords As Boolean
    End Class
    Public Enum ComputerSearchType
        ST_AgentServer = 1
        ST_Server = 2
        ST_Agent = 3
    End Enum

End Class
