Imports R1SimpleRestClient.Models.Enums

Namespace Models
    Public Class Job
        Public Class JobInfoStatusCounts
            Public totalCount As Integer
            Public runningCount As Integer
            Public completedCount As Integer
            Public failedCount As Integer
        End Class

        Public Class JobTargets
            Public targets As New List(Of JobTargetsInfo)
            Public total As Integer
            Public jobName As String
        End Class
        Public Class JobTargetsInfo
            Public jobResultId As String
            Public jobTargetResultId As String
            Public itemId As String
            Public name As String
            Public jobStatusCode As Integer
            Public status As String
            Public startDate As Date
            Public endDate As Date
            Public hits As Integer
        End Class

        Public Class JobDefinitionModel
            Public Property JobDef As JobDefinition
            Public Property ProjectId As Long
            Public Property JobAction As JobAction
            Public Property ComputerTargets As New Target
            Public Property NetworkShareTargets As New Target
        End Class

        Public Class Target
            Public Property Addresses As New List(Of String)
            Public Property SearchString As String = vbNullString
        End Class
        Public Class JobInfo57
            Public Property JobID As Guid
            Public Property Name As String
            Public Property JobType As String
            Public Property Status As String
            Public Property Targets As String()
        End Class
        Public Class JobInfo
            Public Property JobID As Guid
            Public Property ResultID As Guid?
            Public Property Name As String
            Public Property Targets As String()
            Public Property StartDate As DateTime?
            Public Property EndDate As DateTime?
            Public Property CreatedDate As DateTime
            Public Property HasSchedule As Boolean
            Public Property JobType As String
            Public Property JobTypeCode As Integer
            Public Property Status As String
            Public Property StatusCode As Integer
        End Class
        Public Class JobData
            Public Property jobs As List(Of JobInfo)
            Public Property total As Long

        End Class
        Public NotInheritable Class JobDefinition
            Inherits JobDefinitionBase
            Public Property secondaryActionsImmediate As Boolean = True
            Public Property UseRoleBasedApproval As Boolean = True
            Public Property AdvancedOptions As New AdvancedFilterOptions()
            Public Property JamThreshold As Integer = 20
            Public Property secondaryActionTemplateId As Guid
            Public Property secondaryActionsEnabled As Boolean
            Public Property threatScanIsReportOnly As Boolean
            Public Property UseCollectionTemplate As Boolean
            Public Property InheritResponsivePath As Boolean
            Public Property InheritJobPriorityFromProject As Boolean
            Public Property InheritAgentPriorityFromProject As Boolean
            Public Property AD1EncryptionInheritFromProject As Boolean
            Public Property AutoProcessJob As Boolean
            Public Property DestinationRoot As String
            Public Property ProjectResponsiveFilePath As String
            Public Property JobApprovers As ObservableCollection(Of Long)
            Public Property ShareFilters As IncludeExcludeFilterContainer
            Public Property ComputerFilters As IncludeExcludeFilterContainer
            Public Property JobArchiveAndRemediateInfo As JobArchiveAndRemediateInfo
            Public Property JobType As System.Nullable(Of JobTypes)
            Public Property ProjectId As Guid
            Public Property rmPolicyDefinition As RMPolicyDefinition
            Public Property rmPolicyDefinition2 As RMPolicyDefinition2
            Public Property jobSchedule As JobSchedule
            Public Property VolatileDefinition As VolatileDefinition
            Public Property VolatileScheduleDefinition As VolatileScheduleDefinition
            Public Property MemoryAnalysisDefinition As MemoryAnalysisDefinition
            Public Property AgentRemediateInfo As AgentRemediateInfo
            Public Property MemoryAcquisitionInfo As MemoryAcquisitionInfo
            Public Property processDumpInfo As ProcessDumpInfo
            Public Property CombinationJobInfo As CombinationJobInfo
            Public Property IsFullDiskAcquisition As Boolean
            Public Property BasicJamSelected As Boolean
            Public Property AdvancedJamSelected As Boolean
            Public Property ShowUnscorables As Boolean
            Public Property MemoryOperationsType As MemoryOperationsTypes
            Public Property networkAcquisitionDefinition As NetworkAcquisitionDefinition
            Public Property CreateArchiveFileOnAgent As Boolean
            Public Property KFFInfo As KFFInfo
            Public Property ThreatScanJobOptions As ThreatScanJobOptions
            Public Property DisableHashing As Boolean
            Public Property RecurringIncrementalCollection As Boolean
            Public Property runScriptsOnJobCompletion As Boolean
            Public Property impersonationUsername As String
            Public Property impersonationDomain As String
            Public Property impersonationPasswordEncrypted As String
            Public Property ImpersonationPasswordEncryptedChanged As Boolean
            Public Property scriptFileName As String

            Public Sub New()
                Me.secondaryActionTemplateId = Guid.Empty
                Me.ComputerFilters = New IncludeExcludeFilterContainer()
                Me.JobArchiveAndRemediateInfo = New JobArchiveAndRemediateInfo()
                Me.ShareFilters = New IncludeExcludeFilterContainer()
                '  Me.JobApprovers = New ObservableCollection(Of Long)()
                Me.JobType = New System.Nullable(Of JobTypes)()
                Me.rmPolicyDefinition = New RMPolicyDefinition()
                Me.rmPolicyDefinition2 = New RMPolicyDefinition2()
                Me.jobSchedule = New JobSchedule()
                Me.VolatileDefinition = New VolatileDefinition()
                Me.VolatileScheduleDefinition = New VolatileScheduleDefinition()
                Me.MemoryAnalysisDefinition = New MemoryAnalysisDefinition()
                Me.MemoryAcquisitionInfo = New MemoryAcquisitionInfo()
                Me.AgentRemediateInfo = New AgentRemediateInfo()
                Me.processDumpInfo = New ProcessDumpInfo()
                Me.networkAcquisitionDefinition = New NetworkAcquisitionDefinition()
                Me.Description = String.Empty
                Me.Name = String.Empty
                Me.TargetTypeSelected = JobTargetType.[Custom]
                Me.CombinationJobInfo = New CombinationJobInfo()
                Me.AutoProcessJob = False
                Me.ThreatScanJobOptions = New ThreatScanJobOptions()
            End Sub
        End Class

        Public Class RMPolicyDefinition

            Private _isDeviceWrittenToChecked As Boolean
            Private _isDeviceReadFromChecked As Boolean
            Private _policyMaskCollection As ObservableCollection(Of RMPolicyMaskDefinition)
            Private _isIgnoreExtChecked As Boolean
            Private _isCaptureMedataChecked As Boolean
            Public _minByteSize As System.Nullable(Of Long)
            Public _isMinSizeChecked As Boolean
            Private _maxByteSize As System.Nullable(Of Long)
            Public _isMaxSizeChecked As Boolean
            Private _startDate As System.Nullable(Of DateTime)
            Private _endDate As System.Nullable(Of DateTime)
            Public _policyNotfiyFileMasks As String

            Public Shared IsDeviceWrittenToCheckedName As String
        End Class
        Public Class RMPolicyMaskDefinition

            Private _mask As String
            Private _denyRead As Boolean
            Private _denyWrite As Boolean
            Private _denyDelete As Boolean
            Private _capture As Boolean

            Public Shared MaskName As String
        End Class
        Public Class RMPolicyDefinition2

            Private _defaultMasks As String() = New String(11) {"*.doc?", "*.doc", "*.mpp", "*.pot?", "*.pps?", "*.vsd", _
                "*.xl", "*.xls", "*.xls?", "*.txt", "*.pdf", "*.od?"}
            Public _minByteSize As New System.Nullable(Of Long)(0L)
            Private _maxByteSize As New System.Nullable(Of Long)(0L)
            Private _policyMaskCollection As ObservableCollection(Of RMPolicyMaskDefinition2)
            Private _isIgnoreExtChecked As Boolean
            Public _isMinSizeChecked As Boolean
            Public _isMaxSizeChecked As Boolean
            Private _startDate As System.Nullable(Of DateTime)
            Private _endDate As System.Nullable(Of DateTime)
            Public _policyNotfiyFileMasks As String

            Public Shared PolicyMaskCollectionName As String
        End Class
        Public Class RMPolicyMaskDefinition2

            Private _mask As String
            Private _denyRead As Boolean
            Private _denyWrite As Boolean
            Private _denyDelete As Boolean
            Private _captureRead As Boolean
            Private _captureWrite As Boolean
            Private _metaDataOnly As Boolean
            Private _capture As Boolean

            Public Shared MaskName As String
        End Class
        Public Class ThreatScanJobOptions

            Private _ThreatScanSelection As ThreatScanSelectionType = ThreatScanSelectionType.SelectedFiltersOnly
            Private _threatFilters As ObservableCollection(Of Long)
            Private _AuthoredByFilter As String
            Private _CategoryFilter As String
            Private _GroupFilter As String
            Private _SourceFilter As String
            Private _InitialCreationDateFilter As System.Nullable(Of DateTime)
            Private _EnableArchiveDrillDown As Boolean
            Private _ArchiveDrillDownExtensions As String
            Private _EnableIgnoreIOCFileSize As Boolean
            Private _EnableIgnoreYARAFileSize As Boolean
            Private _IgnoreIOCFileSizeBytes As Long
            Private _IgnoreYARAFileSizeBytes As Long
            Private _DisableHashing As Boolean
            Private _DisableStringContentSearch As Boolean

            Public Shared ThreatFiltersName As String
        End Class
        Public Class AgentRemediateInfo
            Private _RemediateCommands As ObservableCollection(Of AgentRemediateCommand)
            Public Shared RemediateCommandsName As String
        End Class
        Public Class NetworkAcquisitionDefinition
            Private Shared _NetworkAcquisitionTransactionDefinitionName As String = DirectCast(Nothing, String)
            Private Shared _NetworkAcquisitionSessionDefinitionName As String = DirectCast(Nothing, String)
            Private Shared _NetworkAcquisitionRemoteShellDefinitionName As String = DirectCast(Nothing, String)
            Private Shared _NetworkAcquisitionIocDefinitionName As String = DirectCast(Nothing, String)
            Private Shared _NetworkAcquisitionWebContentDefinitionName As String = DirectCast(Nothing, String)
            Private Shared _IncludeWebContentName As String = DirectCast(Nothing, String)
            Private Shared _IncludeTransactionName As String = DirectCast(Nothing, String)
            Private Shared _IncludeSessionName As String = DirectCast(Nothing, String)
            Private Shared _IncludeIocName As String = DirectCast(Nothing, String)
            Private Shared _IncludeRemoteShellName As String = DirectCast(Nothing, String)
            Public Shared TimeZonesName As String
            Public Shared _EmptyXaml As String
            Public Shared ReadOnly whitespaceChars As Char() = New Char(3) {" "c, ControlChars.Cr, ControlChars.Lf, "\"c}
            Private _NetworkAcquisitionEmailDefinition As NetworkAcquisitionEmailDefinition
            Private _networkAcquisitionTransactionDefinition As NetworkAcquisitionTransactionDefinition
            Private _networkAcquisitionSessionDefinition As NetworkAcquisitionSessionDefinition
            Private _networkAcquisitionRemoteShellDefinition As NetworkAcquisitionRemoteShellDefinition
            Private _NetworkAcquisitionIocDefinition As NetworkAcquisitionIocDefinition
            Private _NetworkAcquisitionWebContentDefinition As NetworkAcquisitionWebContentDefinition
            Private _IncludeEmail As Boolean
            Private _IncludeWebContent As Boolean
            Private _includeTransaction As Boolean
            Private _includeSession As Boolean
            Private _IncludeIoc As Boolean
            Private _IncludeRemoteShell As Boolean
            Private _Collectors As ObservableCollection(Of SentinelCollectorDefinition)
            Private _TimeZones As ObservableCollection(Of NetworkAcquisitionTimeZone)
            Public Shared NetworkAcquisitionEmailDefinitionName As String
        End Class
        Public Class NetworkAcquisitionEmailDefinition
            Inherits NetworkAcquisitionCommonDefinition
            Private _AttachmentSizeMax As New System.Nullable(Of Integer)(0)
            Private _AttachmentSizeMin As New System.Nullable(Of Integer)(0)
            Private _ToAddressCountMin As New System.Nullable(Of Integer)(0)
            Private _ToAddressCountMax As New System.Nullable(Of Integer)(0)
            Public Shared AttachmentTypeRTBXamlName As String
            Public Shared AttachmentNameContainsRTBXamlName As String
            Public Shared FromAddressesRTBXamlName As String
            Public Shared ToAddressesRTBXamlName As String
            Private _FilterAttachmentSizeOrName As Boolean
            Private _SpecifyAttachmentSizeMax As Boolean
            Private _SpecifyAttachmentSizeMin As Boolean
            Private _FilterAttachmentType As Boolean
            Private _AttachmentType As String
            Private _AttachmentTypeRTBXaml As String
            Private _AttachmentNameContains As String
            Private _AttachmentNameContainsRTBXaml As String
            Private _FilterBodyAttachmentContent As Boolean
            Private _BodyAttachmentContent As String
            Private _FilterFromAddress As Boolean
            Private _FromAddresses As String
            Private _FromAddressesRTBXaml As String
            Private _FilterSubject As Boolean
            Private _SubjectContains As String
            Private _FilterToAddress As Boolean
            Private _ToAddresses As String
            Private _ToAddressesRTBXaml As String
            Private _SpecifyToAddressMin As Boolean
            Private _specifyToAddressMax As Boolean
            Public Shared FilterAttachmentSizeOrNameName As String
        End Class
        Public Class NetworkAcquisitionTransactionDefinition
            Inherits NetworkAcquisitionCommonDefinition
            Private Shared _FilterTransactionSizeName As String = DirectCast(Nothing, String)
            Private Shared _FilterPacketCountName As String = DirectCast(Nothing, String)
            Public Shared PacketCountMinName As String
            Public Shared PacketCountMaxName As String
            Public Shared SpecifyPacketCountMinName As String
            Public Shared SpecifyPacketCountMaxName As String
            Public Shared TSizeMinName As String
            Public Shared TSizeMaxName As String
            Public Shared SpecifyTSizeMinName As String
            Public Shared SpecifyTSizeMaxName As String
            Friend Shared ProbeInvalidNameChars As String() = New String(4) {"'", """", vbTab, vbCr, vbLf}
            Private _filterTransactionSize As Boolean
            Private _filterPacketCount As Boolean
            Private _packetCountMin As Integer
            Private _packetCountMax As Integer
            Private _SpecifyPacketCountMin As Boolean
            Private _SpecifyPacketCountMax As Boolean
            Private _tSizeMin As Integer
            Private _tSizeMax As Integer
            Private _SpecifyTSizeMin As Boolean
            Private _SpecifyTSizeMax As Boolean
        End Class
        Public Class NetworkAcquisitionSessionDefinition
            Inherits NetworkAcquisitionCommonDefinition
            Private Shared _FilterSessionSizeName As String = DirectCast(Nothing, String)
            Private Shared _FilterPacketCountName As String = DirectCast(Nothing, String)
            Public Shared PacketCountMinName As String
            Public Shared PacketCountMaxName As String
            Public Shared SpecifyPacketCountMinName As String
            Public Shared SpecifyPacketCountMaxName As String
            Public Shared SessionSizeMinName As String
            Public Shared SessionSizeMaxName As String
            Public Shared SpecifySessionSizeMinName As String
            Public Shared SpecifySessionSizeMaxName As String
            Private Shared ReadOnly _filterExtractSessionFilesName As String = DirectCast(Nothing, String)
            Private Shared ReadOnly _filterExtractPCapFilesName As String = DirectCast(Nothing, String)
            Private _filterSessionSize As Boolean
            Private _filterPacketCount As Boolean
            Private _packetCountMin As Integer
            Private _packetCountMax As Integer
            Private _SpecifyPacketCountMin As Boolean
            Private _SpecifyPacketCountMax As Boolean
            Private _sessionSizeMin As Integer
            Private _sessionSizeMax As Integer
            Private _SpecifySessionSizeMin As Boolean
            Private _SpecifySessionSizeMax As Boolean
            Private _filterExtractSessionFiles As Boolean
            Private _filterExtractPCapFiles As Boolean
        End Class
        Public Class NetworkAcquisitionIocDefinition
            Inherits NetworkAcquisitionCommonDefinition
        End Class
        Public Class NetworkAcquisitionRemoteShellDefinition
            Inherits NetworkAcquisitionCommonDefinition
            Private Shared _filterUsersName As String = DirectCast(Nothing, String)
            Private Shared _UsersName As String = DirectCast(Nothing, String)
            Public Shared UsersRtbXamlName As String
            Private _filterUsers As Boolean
            Private _users As String
            Private _usersRtbXaml As String
        End Class
        Public Class SentinelCollectorDefinition
            Private Shared _ServerName As String
            Private _Server As String
            Private Shared _DbInstanceName As String
            Private _DbInstance As String
            Private Shared _DescriptionName As String
            Private _Description As String
            Private Shared _IdName As String
            Private _Id As Guid
            Private Shared _CollectName As String
            Private _Collect As Boolean
        End Class
        Public Class NetworkAcquisitionTimeZone
            Public DisplayName As String
            Public BaseUtcOffset As TimeSpan
            Public Index As Integer
        End Class
        Public Class NetworkAcquisitionWebContentDefinition
            Inherits NetworkAcquisitionCommonDefinition
            Private Shared _FilterProtocolHttp_ProxyName As String = DirectCast(Nothing, String)
            Private Shared _FilterProtocolHttpName As String = DirectCast(Nothing, String)
            Private Shared _FilterProtocolHttpsName As String = DirectCast(Nothing, String)
            Private Shared _FilterHostsName As String = DirectCast(Nothing, String)
            Private Shared _HostsName As String = DirectCast(Nothing, String)
            Public Shared HostsRTBXamlName As String
            Private Shared _FilterURLName As String = DirectCast(Nothing, String)
            Private Shared _URLName As String = DirectCast(Nothing, String)
            Private Shared _ActionPutName As String = DirectCast(Nothing, String)
            Public Shared ActionTraceName As String
            Private Shared _ActionPostName As String = DirectCast(Nothing, String)
            Private Shared _ActionHeadName As String = DirectCast(Nothing, String)
            Private Shared _FilterActionsName As String = DirectCast(Nothing, String)
            Private Shared _ActionGetName As String = DirectCast(Nothing, String)
            Private Shared _ActionDeleteName As String = DirectCast(Nothing, String)
            Public Shared ActionConnectName As String
            Public Shared ActionOptionsName As String
            Public Shared ActionPatchName As String
            Private Shared _FilterFileExtensionsName As String = DirectCast(Nothing, String)
            Private Shared _FileExtensionsName As String = DirectCast(Nothing, String)
            Public Shared FileExtensionsRTBXamlName As String
            Private Shared _FilterReferrerName As String = DirectCast(Nothing, String)
            Private Shared _ReferrerName As String = DirectCast(Nothing, String)
            Public Shared ReferrerRTBXamlName As String
            Private Shared _FilterFileContentName As String = DirectCast(Nothing, String)
            Private Shared _FileContentName As String = DirectCast(Nothing, String)
            Private Shared _FullReconstructionName As String = DirectCast(Nothing, String)
            Public Shared ReadOnly HostNameRegEx As String = "^([0-9A-Za-z\-\?\*\.])*$"
            Private _FilterProtocolHttp_Proxy As Boolean
            Private _FilterProtocolHttp As Boolean
            Private _FilterProtocolHttps As Boolean
            Private _FilterHosts As Boolean
            Private _Hosts As String
            Private _HostsRTBXaml As String
            Private _FilterURL As Boolean
            Private _URL As String
            Private _ActionPut As Boolean
            Private _ActionTrace As Boolean
            Private _ActionPost As Boolean
            Private _ActionHead As Boolean
            Private _FilterActions As Boolean
            Private _ActionGet As Boolean
            Private _ActionDelete As Boolean
            Private _ActionConnect As Boolean
            Private _ActionOptions As Boolean
            Private _ActionPatch As Boolean
            Private _FilterFileExtensions As Boolean
            Private _FileExtensions As String
            Private _FileExtensionsRTBXaml As String
            Private _FilterReferrer As Boolean
            Private _Referrer As String
            Private _ReferrerRTBXaml As String
            Private _FilterFileContent As Boolean
            Private _FileContent As String
            Private _FullReconstruction As Boolean
        End Class
        Public Class NetworkAcquisitionCommonDefinition
            Public Shared SpecifyEndDateName As String
            Private Shared ReadOnly _UtcOffsetName As String = DirectCast(Nothing, String)
            Private Shared _TimeZoneNameName As String = DirectCast(Nothing, String)
            Private Shared ReadOnly _rangeFromDateName As String = DirectCast(Nothing, String)
            Private Shared ReadOnly _rangeUntilDateName As String = DirectCast(Nothing, String)
            Private Shared _filterProbesName As String = DirectCast(Nothing, String)
            Private Shared _probesName As String = DirectCast(Nothing, String)
            Public Shared ProbesRtbXamlName As String
            Public Shared FilterSourceIpAddressesName As String
            Public Shared SourceIpAddressesName As String
            Public Shared SourceIpAddressesRtbXamlName As String
            Public Shared ReadOnly IndividualIpRegEx As String = "^ ?([0-9A-Fa-f]+.){3}\* ?$|^ ?([0-9A-Fa-f]+.){2}\*.\* ?$|^ ?[0-9A-Fa-f]+.\*.\*.\* ?$| ?^([0-9A-Fa-f]+:){7}\* ?$| ?^([0-9A-Fa-f]+:){6}\*:\* ?$| ?^([0-9A-Fa-f]+:){5}\*:\*:\* ?$| ?^([0-9A-Fa-f]+:){4}\*:\*:\*:\* ?$| ?^([0-9A-Fa-f]+:){3}\*:\*:\*:\*:\* ?$| ?^([0-9A-Fa-f]+:){2}\*:\*:\*:\*:\*:\* ?$| ?^[0-9A-Fa-f]+:\*:\*:\*:\*:\*:\*:\* ?$"
            Public Shared FilterDestinationIpAddressesName As String
            Public Shared DestinationIpAdressesName As String
            Public Shared DestinationIpAddressRtbXamlName As String
            Public Shared SourceMacAddressesRtbXamlName As String
            Public Shared ReadOnly MacAddressRegEx As String = "^ ?([0-9A-Fa-f][0-9A-Fa-f]?:){5}[0-9A-Fa-f][0-9A-Fa-f] ?$|^ ?([0-9A-Fa-f][0-9A-Fa-f]?-){5}[0-9A-Fa-f][0-9A-Fa-f] ?$"
            Public Shared DestinationMacAddressesRtbXamlName As String
            Public Shared SourcePortsRtbXamlName As String
            Public Shared DestinationPortsRtbXamlName As String
            Public Shared FilterProtocolsName As String
            Public Shared FileNamesRTBXamlName As String
            Friend Shared InvalidNameChars As String() = New String(6) {"\", "/", ":", """", "<", ">", _
                "|"}
            Private _specifyEndDate As Boolean = True
            Private _FileSizeMax As New System.Nullable(Of Integer)(0)
            Private _FileSizeMin As New System.Nullable(Of Integer)(0)
            Private _utcOffset As TimeSpan
            Private _timeZoneName As String
            Private _rangeFromDate As DateTime
            Private _rangeUntilDate As DateTime
            Private _filterProbes As Boolean
            Private _probes As String
            Private _probesRtbXaml As String
            Private _filterSourceIpAddresses As Boolean
            Private _sourceIpAddresses As String
            Private _sourceIpAddressesRtbXaml As String
            Private _filterDestinationIpAddresses As Boolean
            Private _destinationIpAdresses As String
            Private _destinationIpAddressRtbXaml As String
            Private _filterSourceMacAddresses As Boolean
            Private _sourceMacAddresses As String
            Private _sourceMacAddressesRtbXaml As String
            Private _filterDestinationMacAddresses As Boolean
            Private _destinationMacAddresses As String
            Private _destinationMacAddressesRtbXaml As String
            Private _filterSourcePorts As Boolean
            Private _sourcePorts As String
            Private _sourcePortsRtbXaml As String
            Private _filterDestinationPorts As Boolean
            Private _destinationPorts As String
            Private _destinationPortsRtbXaml As String
            Private _filterProtocols As Boolean
            Private _filterContentExtraction As Boolean
            Private _SpecifyFileNames As Boolean
            Protected _FileNames As String
            Private _FileNamesRTBXaml As String
            Private _SpecifyFileSizeMin As Boolean
            Private _SpecifyFileSizeMax As Boolean
            Private _FilterFileNames As Boolean
        End Class
        Public Class CombinationJobInfo
            Private _SearchAndReview As Boolean
            Private Shared _MetaDataOnlyName As String
            Private _MetaDataOnly As Boolean
            Private _Volatile As Boolean
            Private _ComputerSoftwareInventory As Boolean
            Private _MemoryOperations As Boolean
            Public Shared SearchAndReviewName As String
        End Class
        Public Class ProcessDumpInfo
            Private _FlagsValue As Integer
            Private _ProcessIDs As String
            Private _processNames As String
            Public Shared FlagsValueName As String
        End Class
        Public Class MemoryAcquisitionInfo
            Private _IncludePageFile As Boolean
            Private _CreateArchive As Boolean
            Public Shared IncludePageFileName As String
        End Class
        Public Class AgentRemediateCommand
            Private _CommandType As System.Nullable(Of AgentRemediateCommandTypes)
            Private _ProcessOrExcecutableName As String
            Private _ProcessId As Integer
            Private _description As String
            Private _sourceFile As String
            Private _destinationFile As String
            Private _targetFile As String
            Private _executables As String
            Private _addDeleteFileRow As Boolean
            Private _addExecuteRow As Boolean
            Public Shared AvailableAgentRemediateCommands As ObservableCollection(Of AgentRemediateCommandTypes)
            Public Shared CommandTypeName As String
        End Class
        Public Class MemoryAnalysisDefinition
            Private _includeIdt As Boolean
            Private _includeSdt As Boolean
            Private _includeDrivers As Boolean
            Private _includeDLLs As Boolean
            Private _includeHandles As Boolean
            Private _includeSockets As Boolean
            Private _includeVAD As Boolean
            Private _includeRegistry As Boolean
            Private _includeCrypto As Boolean
            Public Shared IncludeIDTName As String
        End Class
        Public Class VolatileScheduleDefinition
            Private _isScheduledJob As Boolean
            Private _recurrencePattern As VolatileRecurrencePatternTypes
            Private _endRecurrenceOptions As EndRecurrenceOptions
            Private _isRecurrenceEnabled As Boolean
            Private _startDate As System.Nullable(Of DateTime)
            Private _byMinute As Minutes
            Private _byHour As Hours
            Private _endOccurrenceNumber As System.Nullable(Of Integer)
            Private _endOccurrenceDate As System.Nullable(Of DateTime)
            Public Shared IsScheduledJobName As String
        End Class
        Public Class VolatileDefinition
            Private _jamThreshold As Integer = 20
            Private _includeProcessTree As Boolean
            Private _flagHidden As Boolean
            Private _includeDLLAndSharedLibraries As Boolean
            Private _detectInjectedDLLs As Boolean
            Private _volatileIncludeSockets As Boolean
            Private _volatileIncludeHandles As Boolean
            Private _volatileMergeWithMemoryAnalysis As Boolean
            Private _cerberusStageThree As Boolean
            Private _cerberusStageOne As Boolean
            Private _includeServices As Boolean
            Private _includeDrivers As Boolean
            Private _includeUsers As Boolean
            Private _includeNics As Boolean
            Private _includeNetworkSessions As Boolean
            Private _IncludeDNS As Boolean
            Private _IncludeUSB As Boolean
            Private _IncludeVolumes As Boolean
            Private _IncludePrefetch As Boolean
            Private _IncludeWindowsTasks As Boolean
            Private _IncludeNetworkRouteTable As Boolean
            Private _IncludeAddressResolutionProtocol As Boolean
            Private _includeRegistry As Boolean
            Private _includeHiddenRegistryKeys As Boolean
            Private _regSearchDef As ObservableCollection(Of RegistrySearchDefinition)
            Private _IncludeJamScoreServices As Boolean
            Private _IncludeJamScoreTasks As Boolean
            Private _IncludeJamScoreDrivers As Boolean
            Public Shared IncludeProcessTreeName As String
        End Class
        Public Class RegistrySearchDefinition
            Private _is32Bit As Boolean
            Private _is64Bit As Boolean
            Private _displayName As String
            Private _registryPath As String
            Private _depth As Integer
        End Class
        Public NotInheritable Class KFFInfo
            Private _isKFFEnabled As Boolean
            Public Shared IsKFFEnabledName As String
        End Class
        Public NotInheritable Class JobSchedule
            Private _isScheduledJob As Boolean
            Private _startJobOnDate As DateTime
            Private _endRecurrenceOption As EndRecurrenceOptions
            Private _noOfOccurenceToEndRecurrence As System.Nullable(Of Integer)
            Private _endRecurrenceByDate As System.Nullable(Of DateTime)
            Private _isRecurrenceEnabled As Boolean
            Private _recurrencePattern As RecurrencePatternTypes
            Private _minutesInMinutelyPattern As Minutes
            Private _Hours As Hours
            Private _noOfDaysInDRP As System.Nullable(Of Integer)
            Private _isEveryWeekDayEnabledInDRP As Boolean
            Private _noOfWeeksForRecurrenceInWRP As Integer
            Private _recurrenceDaysInWRP As ObservableCollection(Of DayOfWeek)
            Private _isSpecificDayEnabledInMRP As Boolean
            Private _dayInMRP As System.Nullable(Of Integer)
            Private _noOfMonthsForRecurrenceInMRP As System.Nullable(Of Integer)
            Private _rankInMRP As Ranks
            Private _dayTypeInMRP As DayTypes
            Private _noOfMonthsForRecurrenceInMRPRankOption As System.Nullable(Of Integer)
            Private _isSpecificDayMonthEnabledInYRP As Boolean
            Private _dayInYRP As System.Nullable(Of Integer)
            Private _monthInYRP As Months
            Private _rankInYRP As Ranks
            Private _dayTypeInYRP As DayTypes
            Private _monthInYRPRankOption As Months
        End Class
        Public NotInheritable Class JobArchiveAndRemediateInfo
            Private _secureDelete As Boolean
            Private _VerifyRemediation As System.Nullable(Of Boolean)
            Private _IsHitsPerNodeEnabled As Boolean
            Private _hitsPerNode As System.Nullable(Of Integer)
            Private _useExpressExport As Boolean
            Private _usePreScan As Boolean
            Private _encryptionCertificateId As System.Nullable(Of Guid)
            Private _encryptionPassword As String
            Private _EncryptionPasswordChanged As Boolean
            Private _Ad1Encryption As Ad1EncryptionTypes
            Private _raPassword As String
            Private _raUsername As String
            Private _redirectedAquisition As Boolean
            Private _reportOnNonResponsiveItems As Boolean
            Private _useStubbing As Boolean
            Private _remediationFileId As System.Nullable(Of Guid)
        End Class
        Public NotInheritable Class IncludeExcludeFilterContainer
            Private _InclusionFilters As ObservableCollection(Of Filters)
            Private _ExclusionFilters As ObservableCollection(Of Filters)
        End Class
        Public NotInheritable Class JobDefinitionTemplate
            Private _name As String
            Private _description As String
            Private _jobId As Guid
            Private _jobDefinition As JobDefinitionBase
            Private _IsSystemJob As Boolean
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

        Public Class ObservableCollection(Of T)
            Private Const CountString As String = "Count"
            Private Const IndexerName As String = "Item[]"
        End Class
        Public MustInherit Class JobDefinitionBase
            Public Property Description As String
            Public Property JobId As Guid
            Public Property jobTargets As JobCustomTargetInfo
            Public Property JobCustomTargetInfo As JobCustomTargetInfo
            Public Property JobIpRangeTargetInfo As JobIpRangeTargetInfo
            Public Property Name As String
            Public Property Priority As JobPriorities
            Public Property AgentPriority As JobPriorities
            Public Property UserId As Long
            Public Property JobGroupTargetInfo As JobGroupTargetInfo
            Public Property IsForceEndEnabled As Boolean
            Public Property ForceEndAfterDays As Integer
            Public Property ForceEndAfterHours As Integer
            Public Property TargetTypeSelected As JobTargetType
            Public Property JobExpirationSingleAttempt As Boolean
            Public Property JobExpirationCancelPending As Boolean
            Public Property JobExpirationCancelIncomplete As Boolean
            Public Property AgentOperationsDefinition As AgentOperationsDefinition
            Public Property EventEndpointOptions As EventEndpointOptions
            Public Property IsUseJobTemplateOptionEnabled As Boolean
            Public Property SelectedJobTemplate As JobDefinitionTemplate
            Public Property SaveAsJobTemplate As Boolean
            Public Property IncludeTemplateTargetOptions As Boolean
            Public Property EnableTargetSelection As Boolean
        End Class


        Public Class EventEndpointOptions
            Private _StartDate As System.Nullable(Of DateTime)
            Private _EndDate As System.Nullable(Of DateTime)
            Private Shared _RelativeStartMinuteName As String
            Private _RelativeStartMinute As System.Nullable(Of Long)
            Private Shared _RelativeEndMinuteName As String
            Private _RelativeEndMinute As System.Nullable(Of Long)
            Private Shared _UseRelativeTimeName As String
            Private _UseRelativeTime As Boolean
            Private _Events As ObservableCollection(Of EndpointEvent)
            Private _Processes As ObservableCollection(Of Process)
            Private _TargetAllProcesses As Boolean
            Private _IncludeSystemProcess As Boolean
            Private _EventDeduplication As Boolean
        End Class
        Public MustInherit Class EndpointEvent
            Private _Id As ULong
            Private _Name As String
            Private _Description As String
            Private _Events As ObservableCollection(Of EndpointEvent)
            Private _IsAgentEvent As Boolean
            Private _IsMobileEvent As Boolean
        End Class
        Public Class JobIpRangeTargetInfo
            Private _startOctetOne As Integer
            Private _startOctetTwo As Integer
            Private _startOctetThree As Integer
            Private _startOctetFour As Integer
            Private _endOctetOne As Integer
            Private _endOctetTwo As Integer
            Private _endOctetThree As Integer
            Private _endOctetFour As Integer
            Private Shared _StartIPName As String
            Private Shared _EndIPName As String
            Public Shared StartOctetOneName As String
        End Class
        Public Class JobGroupTargetInfo
            Inherits JobTargetBase
            Private _jobGroups As ObservableCollection(Of Guid)
            Private _groupPersonTargets As ObservableCollection(Of Guid)
            Private _groupComputerTargets As ObservableCollection(Of Guid)
            Private _groupNetworkShareTargets As ObservableCollection(Of Guid)
            Private _GroupPersonTargetAssociationExclusions As ObservableCollection(Of PersonTargetAssociation)
            Private Shared _HasComputerTargetsName As String
            Private Shared _HasShareTargetsName As String
            Public Shared JobGroupsName As String
        End Class
        Public NotInheritable Class JobCustomTargetInfo
            Inherits JobTargetBase
            Private Shared _HasNetworkShareTargetsName As String = DirectCast(Nothing, String)
            Private Shared _HasComputerTargetsName As String = DirectCast(Nothing, String)
            Private Shared _HasShareTargetsName As String = DirectCast(Nothing, String)
            Private Shared _HasMobileDeviceTargetsName As String = DirectCast(Nothing, String)
            Private Shared _HasPersonTargetsName As String = DirectCast(Nothing, String)
            Private Shared _FilteredShareCountName As String = DirectCast(Nothing, String)
            Private Shared _HasValidComputerFilterName As String = DirectCast(Nothing, String)
            Private Shared _FilteredComputerCountName As String = DirectCast(Nothing, String)
            Private Shared _HasMultipleTargetsName As String = DirectCast(Nothing, String)
            Private Shared _HasValidShareFilterName As String
            Private _ComputerGroupsFilter As String
            Private _ComputerAndOpdGroups As List(Of String)
            Private _ComputerTargets As ObservableCollection(Of Guid)
            Private _NetworkShareTargets As ObservableCollection(Of Guid)
            Private _PersonTargetAssociations As ObservableCollection(Of PersonTargetAssociation)
            Private _MobileDeviceTargets As ObservableCollection(Of Guid)
            Private _ComputerFilter As String
            Private _UseFilterToSelectComputers As Boolean
            Private _MobileDeviceFilter As String
            Private _UseFilterToSelectMobileDevices As Boolean
            Private _ShareFilter As String
            Private _UseFilterToSelectShares As Boolean
            Private _FilteredShareCount As Integer
            Private _FilteredComputerCount As Integer
            Private _FilteredMobileDeviceCount As Integer
        End Class
        Public Class PersonTargetAssociation
            Private _PersonId As Guid
            Private _IncludeAllComputers As Boolean
            Private _ComputerTargetIds As ObservableCollection(Of Guid)
            Private _IncludeAllShares As Boolean
            Private _NetworkShareTargetIds As ObservableCollection(Of Guid)
            Private _IncludeAllMobileDevices As Boolean
            Private _MobileDeviceTargetIds As ObservableCollection(Of Guid)
            Public Shared PersonIdName As String
        End Class
        Public Class JobTargetBase
            Private _IncludePersons As Boolean
            Private _IncludeComputers As Boolean
            Private _IncludeShares As Boolean
            Private _IncludeNetworkCollectors As Boolean
            Private _IncludePersonComputers As Boolean
            Private _IncludePersonShares As Boolean
            Private _IncludePersonMobileDevices As Boolean
            Private _IncludeMobileDevices As Boolean
            Public Shared IncludePersonsName As String
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
        Public Class RemediationFile
            Private _remediationFileId As System.Nullable(Of Guid)
            Private _fileName As String
            Private _description As String
            Private _createBy As Long
            Private _createdDate As DateTime
            Private _isReferenced As Boolean
        End Class
        Public Class StringMatchSimpleFilter
            Private _Value As String
            Private _Operator As StringMatchSimpleOptions
        End Class
        Public Class JobReportDataStatus

            Public Key As Guid

            Public DownloadableReportId As System.Nullable(Of Guid)

            Public JobResultId As Guid

            Public HasData As Boolean

            Public ReportType As ReportTypeEnum

            Public Status As Integer
        End Class
    End Class
End Namespace
