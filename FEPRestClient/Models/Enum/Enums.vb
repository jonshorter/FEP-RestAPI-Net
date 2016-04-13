Imports System.ComponentModel

Namespace Models
    Public Class Enums
        Public Enum ReportTypeEnum
            GeneratedReportTypes_CollectedFiles
            GeneratedReportTypes_CollectedEmails
            GeneratedReportTypes_ResultReport
            GeneratedReportTypes_DataVolumeEncryptedFiles
            GeneratedReportTypes_DataVolumeCaseBreakout
            GeneratedReportTypes_DataVolumeCustodianBreakout
            GeneratedReportTypes_DeduplicationFiles
            GeneratedReportTypes_DeduplicationEmail
            GeneratedReportTypes_ProductionSet
            GeneratedReportTypes_ExpressExport
            GeneratedReportTypes_ExportExclusion
            GeneratedReportTypes_FailedFiles
            GeneratedReportTypes_FailedEmails
            GeneratedReportTypes_DataVolume
            GeneratedReportTypes_ProcessingExceptions
            GeneratedReportTypes_LegalMatterResultReport
            GeneratedReportTypes_VolatileReport
            GeneratedReportTypes_JobDetail
            GeneratedReportTypes_SoftwareInventoryReport
            GeneratedReportTypes_MemoryOperationsReport
            GeneratedReportTypes_ThreatScanReport
            GeneratedReportTypes_FullErrorReport
            GeneratedReportTypes_CompletionStatus
            GeneratedReportTypes_CustodianDataMap
            Invalid
            Sample
            CollectedEmails
            CollectedFiles
            ComputerTotals
            CustodianFileTotals
            EmailStatistics
            FailedEmails
            FailedFiles
            FileBreakout
            FileStatistics
            JobResults
            NetworkSharesTotals
            ProjectResults
            RemediatedFiles
            Deduplication
            DataVolume
            AuditLog
            SystemJobAgentOperation
            ProjectCompletionStatus
            CustodianDataMap
            Keyword
            AgentOperation
            AgentRemediation
            MemoryAcquisition
            SoftwareInventory
            UnmatchedFiles
            Generated
            Volatile
            MemoryOperations
            MemoryAnalysis
            ProcessDump
            CompletionStatus
            ThreatScan
        End Enum
        Public Enum ProcessModeEnum
            eDiscoveryMode
            FieldMode
            FTKMode
            eDiscoveryNoIndexing
            Custom
            Security
        End Enum
        Public Enum JobAction
            Create
            Approve
            Execute
            Cancel
            Status
        End Enum
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
        'Public Enum JobTypes
        '    SearchAndReview
        '    MetadataOnly
        '    ReportOnly
        '    Archive
        '    Remediate
        '    RemediateAndReview
        '    RMM
        '    Volatile
        '    MemoryAnalysis
        '    MemoryAcquisition
        '    SoftwareInventory
        '    AgentRemediation
        '    MemoryOperations
        '    NetworkAcquisition
        '    CombinationJob
        '    ProcessDump
        '    ThreatScan
        '    EventEndpointQuery
        'End Enum

        Public Enum JobTypes
            DeployAgents = 3
            VerifyAgentConnectivity = 4
            MapNodesToPeople = 5
            Volatile = 6
            RMM = 7
            MemoryAnalysis = 8
            SoftwareInventory = 9
            MemoryAcquisition = 10
            AgentRemediation = 11
            ProcessDump = 12
            NetworkAcquisition = 13
            CombinationJob = 14
            ThreatScan = 16
            EventEndpointQuery = 18
            MemoryOperations = 40
            ReportOnly = 41
            Archive = 42
            SearchAndReview = 43
            MetadataOnly = 44
            Remediate = 45
            RemediateAndReview = 46
        End Enum

        '=======================================================
        'Service provided by Telerik (www.telerik.com)
        'Conversion powered by NRefactory.
        'Twitter: @telerik
        'Facebook: facebook.com/telerik
        '=======================================================



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

        Public Enum DayTypes
            Day
            Weekday
            Weekend
            Sunday
            Monday
            Tuesday
            Wednesday
            Thursday
            Friday
            Saturday
        End Enum
        Public Enum Minutes
            One
            Two
            Three
            Foure
            Five
            Six
            Ten
            Twelve
            Fifteen
            Twenty
            Thirty
        End Enum
        Public Enum Ranks
            First
            Second
            Third
            Fourth
        End Enum
        Public Enum Months
            January
            February
            March
            April
            May
            June
            July
            August
            September
            October
            November
            December
        End Enum
        Public Enum Hours
            One
            Two
            Three
            Four
            Six
            Eight
            Twelve
        End Enum

        Public Enum CustomMatchOptions
            CMO_ANY
            CMO_ALL
            NMO_REGEX
        End Enum
        Public Enum StringMatchSimpleOptions
            NotEquals
        End Enum
        Public Enum FileSizeDistributionOptions
            FSDO_IS
            FSDO_GREATERTHAN
            FSDO_LESSTHAN
            FSDO_ANY
        End Enum
        Public Enum FileSizeOptions
            FSO_BYTES
            FSO_KBYTES
            FSO_MBYTES
        End Enum
        Public Enum NameMatchOptions
            NMO_TEXT
            NMO_REGEX
        End Enum
        Public Enum FileExtensionOptions
            FEO_EQUALS
            FEO_NOTEQUAL
        End Enum
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
        Public Enum JobPriorities
            Low
            Normal
            High
            Urgent
        End Enum
        Public Enum ComputerSearchType
            ST_AgentServer = 1
            ST_Server = 2
            ST_Agent = 3
        End Enum
        Public Enum ThumbNailModeTypes
            Percent
            Minutes
        End Enum
        Public Enum KFFAllowIgnorableEnum
            NotAllowIgnorable
            AllowIgnorable
        End Enum
        Public Enum DupeAtOptionEnum
            <Description("Deduplicate at the Project Level")> _
            CaseLevel
            <Description("Deduplicate at the Person Level")> _
            CustodianLevel
            <Description("Does not Deduplicate")> _
            NoDedupe
        End Enum
        Public Enum EmailHashDuplicatesEnum
            None
            BodyAndAttachments
            EmailBodyOnly
        End Enum
        Public Enum Ad1EncryptionPresenterType
            Disabled
            Password
            Certificate
        End Enum
        Public Enum LanguageOption
            None
            Basic
            Extended
        End Enum
        Public Enum SearchProviderEnum
            dtSearch
            ElasticSearch
        End Enum
    End Class
End Namespace
