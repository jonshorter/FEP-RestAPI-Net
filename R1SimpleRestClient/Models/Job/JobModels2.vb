Namespace Models.Job2
    Public Class JobFromTemplate
        Public ComputerTargets As New List(Of String)
        Public ProjectId As String
        Public TemplateId As String
    End Class

    Public Class ShareFilters
        Public Property inclusionFilters As Object()
        Public Property exclusionFilters As Object()
    End Class

    Public Class ComputerFilters
        Public Property inclusionFilters As Object()
        Public Property exclusionFilters As Object()
    End Class

    Public Class AdvancedOptions
        Public Property diskType As Integer
        Public Property useCustomDrillDownExtensions As Boolean
        Public Property customDrillDownExtensions As String
        Public Property searchType As Integer
        Public Property scanUnusedDiskArea As Boolean
        Public Property scanSystemFiles As Boolean
        Public Property scanDeletedFiles As Boolean
        Public Property archiveDrillDown As Boolean
        Public Property collectResponsiveArchiveFiles As Boolean
        Public Property collectNonExtensionFiles As Boolean
        Public Property userInternalFileIdentification As Boolean
        Public Property collectEncryptedFiles As Boolean
        Public Property excludeRemovableDrives As Boolean
        Public Property includeDiskSectors As Boolean
        Public Property startSectorValue As Integer
        Public Property endSectorValue As Integer
        Public Property parseI30IndexRecords As Boolean
    End Class

    Public Class JobArchiveAndRemediateInfo
        Public Property secureDelete As Boolean
        Public Property verifyRemediation As Object
        Public Property isHitsPerNodeEnabled As Boolean
        Public Property hitsPerNode As Object
        Public Property useExpressExport As Boolean
        Public Property usePreScan As Boolean
        Public Property encryptionCertificateId As Object
        Public Property encryptionPassword As Object
        Public Property encryptionPasswordChanged As Boolean
        Public Property ad1Encryption As Integer
        Public Property raPassword As Object
        Public Property raUsername As Object
        Public Property redirectedAquisition As Boolean
        Public Property reportOnNonResponsiveItems As Boolean
        Public Property useStubbing As Boolean
        Public Property remediationFileId As Object
    End Class

    '  Public Class PolicyMaskCollection
    ' Public Property mask As String
    ' Public Property denyRead As Boolean
    ' Public Property denyWrite As Boolean
    ' Public Property denyDelete As Boolean
    ' Public Property capture As Boolean
    ' End Class
    '
    Public Class RmPolicyDefinition
        Public Property isDeviceWrittenToChecked As Boolean
        Public Property isDeviceReadFromChecked As Boolean
        Public Property policyMaskCollection As PolicyMaskCollection()
        Public Property isIgnoreExtChecked As Boolean
        Public Property isCaptureMetadataChecked As Boolean
        Public Property minByteSize As Object
        Public Property isMinSizeChecked As Boolean
        Public Property maxByteSize As Object
        Public Property isMaxSizeChecked As Boolean
        Public Property startDate As Object
        Public Property endDate As Object
        Public Property policyNotfiyFileMasks As Object
    End Class

    Public Class PolicyMaskCollection
        Public Property mask As String
        Public Property denyRead As Boolean
        Public Property denyWrite As Boolean
        Public Property denyDelete As Boolean
        Public Property captureRead As Boolean
        Public Property captureWrite As Boolean
        Public Property metaDataOnly As Boolean
        Public Property capture As Boolean
    End Class



    Public Class RmPolicyDefinition2
        Public Property policyMaskCollection As PolicyMaskCollection()
        Public Property isIgnoreExtChecked As Boolean
        Public Property minByteSize As Integer
        Public Property isMinSizeChecked As Boolean
        Public Property maxByteSize As Integer
        Public Property isMaxSizeChecked As Boolean
        Public Property startDate As Object
        Public Property endDate As Object
        Public Property policyNotfiyFileMasks As Object
    End Class

    Public Class JobSchedule
        Public Property isScheduledJob As Boolean
        Public Property startJobOnDate As DateTime
        Public Property endRecurrenceOption As Integer
        Public Property noOfOccurenceToEndRecurrence As Integer
        Public Property endRecurrenceByDate As DateTime
        Public Property isRecurrenceEnabled As Boolean
        Public Property recurrencePattern As Integer
        Public Property minutesInMinutelyPattern As Integer
        Public Property hours As Integer
        Public Property noOfDaysInDRP As Integer
        Public Property isEveryWeekDayEnabledInDRP As Boolean
        Public Property noOfWeeksForRecurrenceInWRP As Integer
        Public Property recurrenceDaysInWRP As Object()
        Public Property isSpecificDayEnabledInMRP As Boolean
        Public Property dayInMRP As Integer
        Public Property noOfMonthsForRecurrenceInMRP As Integer
        Public Property rankInMRP As Integer
        Public Property dayTypeInMRP As Integer
        Public Property noOfMonthsForRecurrenceInMRPRankOption As Integer
        Public Property isSpecificDayMonthEnabledInYRP As Boolean
        Public Property dayInYRP As Integer
        Public Property monthInYRP As Integer
        Public Property rankInYRP As Integer
        Public Property dayTypeInYRP As Integer
        Public Property monthInYRPRankOption As Integer
        Public Property useRelativeStartTime As Boolean
    End Class

    Public Class VolatileDefinition
        Public Property includeProcessTree As Boolean
        Public Property flagHidden As Boolean
        Public Property includeDLLAndSharedLibraries As Boolean
        Public Property detectInjectedDLLs As Boolean
        Public Property volatileIncludeSockets As Boolean
        Public Property volatileIncludeHandles As Boolean
        Public Property volatileMergeWithMemoryAnalysis As Boolean
        Public Property cerberusStageThree As Boolean
        Public Property cerberusStageOne As Boolean
        Public Property includeServices As Boolean
        Public Property includeDrivers As Boolean
        Public Property includeUsers As Boolean
        Public Property includeNics As Boolean
        Public Property includeNetworkSessions As Boolean
        Public Property includeDNS As Boolean
        Public Property includeUSB As Boolean
        Public Property includeVolumes As Boolean
        Public Property includePrefetch As Boolean
        Public Property includeWindowsTasks As Boolean
        Public Property includeNetworkRouteTable As Boolean
        Public Property includeAddressResolutionProtocol As Boolean
        Public Property includeRegistry As Boolean
        Public Property includeHiddenRegistryKeys As Boolean
        Public Property regSearchDef As Object()
        Public Property jamThreshold As Integer
        Public Property includeJamScoreServices As Boolean
        Public Property includeJamScoreTasks As Boolean
        Public Property includeJamScoreDrivers As Boolean
    End Class

    Public Class VolatileScheduleDefinition
        Public Property isScheduledJob As Boolean
        Public Property recurrencePattern As Integer
        Public Property endRecurrenceOptions As Integer
        Public Property isRecurrenceEnabled As Boolean
        Public Property startDate As DateTime
        Public Property byMinute As Integer
        Public Property byHour As Integer
        Public Property endOccurrenceNumber As Integer
        Public Property endOccurrenceDate As DateTime
    End Class

    Public Class MemoryAnalysisDefinition
        Public Property includeIDT As Boolean
        Public Property includeSDT As Boolean
        Public Property includeDrivers As Boolean
        Public Property includeDLLs As Boolean
        Public Property includeHandles As Boolean
        Public Property includeSockets As Boolean
        Public Property includeVAD As Boolean
        Public Property includeRegistry As Boolean
    End Class

    Public Class AgentRemediateInfo
        Public Property remediateCommands As Object()
    End Class

    Public Class MemoryAcquisitionInfo
        Public Property includePageFile As Boolean
        Public Property createArchive As Boolean
    End Class

    Public Class ProcessDumpInfo
        Public Property flagsValue As Integer
        Public Property processIDs As Object
        Public Property processNames As Object
    End Class

    Public Class CombinationJobInfo
        Public Property searchAndReview As Boolean
        Public Property metaDataOnly As Boolean
        Public Property volatile As Boolean
        Public Property computerSoftwareInventory As Boolean
        Public Property memoryOperations As Boolean
    End Class

    Public Class NetworkAcquisitionEmailDefinition
        Public Property filterAttachmentSizeOrName As Boolean
        Public Property specifyAttachmentSizeMax As Boolean
        Public Property attachmentSizeMax As Integer
        Public Property specifyAttachmentSizeMin As Boolean
        Public Property attachmentSizeMin As Integer
        Public Property filterAttachmentType As Boolean
        Public Property attachmentType As Object
        Public Property attachmentTypeRTBXaml As String
        Public Property attachmentNameContains As Object
        Public Property attachmentNameContainsRTBXaml As String
        Public Property filterBodyAttachmentContent As Boolean
        Public Property bodyAttachmentContent As Object
        Public Property filterFromAddress As Boolean
        Public Property fromAddresses As Object
        Public Property fromAddressesRTBXaml As String
        Public Property filterSubject As Boolean
        Public Property subjectContains As Object
        Public Property filterToAddress As Boolean
        Public Property toAddressCountMin As Integer
        Public Property toAddressCountMax As Integer
        Public Property toAddresses As Object
        Public Property toAddressesRTBXaml As String
        Public Property specifyToAddressMin As Boolean
        Public Property specifyToAddressMax As Boolean
        Public Property specifyEndDate As Boolean
        Public Property utcOffset As String
        Public Property timeZoneName As Object
        Public Property rangeFromDate As DateTime
        Public Property rangeUntilDate As DateTime
        Public Property filterProbes As Boolean
        Public Property probes As Object
        Public Property filterSourceIpAddresses As Boolean
        Public Property sourceIpAddresses As Object
        Public Property filterDestinationIpAddresses As Boolean
        Public Property destinationIpAdresses As Object
        Public Property filterSourceMacAddresses As Boolean
        Public Property sourceMacAddresses As Object
        Public Property filterDestinationMacAddresses As Boolean
        Public Property destinationMacAddresses As Object
        Public Property filterSourcePorts As Boolean
        Public Property sourcePorts As Object
        Public Property filterDestinationPorts As Boolean
        Public Property destinationPorts As Object
        Public Property filterProtocols As Boolean
        Public Property selectedProtocols As Object
        Public Property filterContentExtraction As Boolean
        Public Property specifyFileNames As Boolean
        Public Property fileNames As Object
        Public Property specifyFileSizeMin As Boolean
        Public Property specifyFileSizeMax As Boolean
        Public Property fileSizeMax As Integer
        Public Property fileSizeMin As Integer
        Public Property filterFileNames As Boolean
    End Class

    Public Class NetworkAcquisitionTransactionDefinition
        Public Property filterTransactionSize As Boolean
        Public Property filterPacketCount As Boolean
        Public Property packetCountMin As Integer
        Public Property packetCountMax As Integer
        Public Property specifyPacketCountMin As Boolean
        Public Property specifyPacketCountMax As Boolean
        Public Property tSizeMin As Integer
        Public Property tSizeMax As Integer
        Public Property specifyTSizeMin As Boolean
        Public Property specifyTSizeMax As Boolean
        Public Property specifyEndDate As Boolean
        Public Property utcOffset As String
        Public Property timeZoneName As Object
        Public Property rangeFromDate As DateTime
        Public Property rangeUntilDate As DateTime
        Public Property filterProbes As Boolean
        Public Property probes As Object
        Public Property filterSourceIpAddresses As Boolean
        Public Property sourceIpAddresses As Object
        Public Property filterDestinationIpAddresses As Boolean
        Public Property destinationIpAdresses As Object
        Public Property filterSourceMacAddresses As Boolean
        Public Property sourceMacAddresses As Object
        Public Property filterDestinationMacAddresses As Boolean
        Public Property destinationMacAddresses As Object
        Public Property filterSourcePorts As Boolean
        Public Property sourcePorts As Object
        Public Property filterDestinationPorts As Boolean
        Public Property destinationPorts As Object
        Public Property filterProtocols As Boolean
        Public Property selectedProtocols As Object
        Public Property filterContentExtraction As Boolean
        Public Property specifyFileNames As Boolean
        Public Property fileNames As Object
        Public Property specifyFileSizeMin As Boolean
        Public Property specifyFileSizeMax As Boolean
        Public Property fileSizeMax As Integer
        Public Property fileSizeMin As Integer
        Public Property filterFileNames As Boolean
    End Class

    Public Class NetworkAcquisitionSessionDefinition
        Public Property filterSessionSize As Boolean
        Public Property filterPacketCount As Boolean
        Public Property packetCountMin As Integer
        Public Property packetCountMax As Integer
        Public Property specifyPacketCountMin As Boolean
        Public Property specifyPacketCountMax As Boolean
        Public Property sessionSizeMin As Integer
        Public Property sessionSizeMax As Integer
        Public Property specifySessionSizeMin As Boolean
        Public Property specifySessionSizeMax As Boolean
        Public Property filterExtractSessionFiles As Boolean
        Public Property filterExtractPCapFiles As Boolean
        Public Property specifyEndDate As Boolean
        Public Property utcOffset As String
        Public Property timeZoneName As Object
        Public Property rangeFromDate As DateTime
        Public Property rangeUntilDate As DateTime
        Public Property filterProbes As Boolean
        Public Property probes As Object
        Public Property filterSourceIpAddresses As Boolean
        Public Property sourceIpAddresses As Object
        Public Property filterDestinationIpAddresses As Boolean
        Public Property destinationIpAdresses As Object
        Public Property filterSourceMacAddresses As Boolean
        Public Property sourceMacAddresses As Object
        Public Property filterDestinationMacAddresses As Boolean
        Public Property destinationMacAddresses As Object
        Public Property filterSourcePorts As Boolean
        Public Property sourcePorts As Object
        Public Property filterDestinationPorts As Boolean
        Public Property destinationPorts As Object
        Public Property filterProtocols As Boolean
        Public Property selectedProtocols As Object
        Public Property filterContentExtraction As Boolean
        Public Property specifyFileNames As Boolean
        Public Property fileNames As Object
        Public Property specifyFileSizeMin As Boolean
        Public Property specifyFileSizeMax As Boolean
        Public Property fileSizeMax As Integer
        Public Property fileSizeMin As Integer
        Public Property filterFileNames As Boolean
    End Class

    Public Class NetworkAcquisitionRemoteShellDefinition
        Public Property filterUsers As Boolean
        Public Property users As Object
        Public Property specifyEndDate As Boolean
        Public Property utcOffset As String
        Public Property timeZoneName As Object
        Public Property rangeFromDate As DateTime
        Public Property rangeUntilDate As DateTime
        Public Property filterProbes As Boolean
        Public Property probes As Object
        Public Property filterSourceIpAddresses As Boolean
        Public Property sourceIpAddresses As Object
        Public Property filterDestinationIpAddresses As Boolean
        Public Property destinationIpAdresses As Object
        Public Property filterSourceMacAddresses As Boolean
        Public Property sourceMacAddresses As Object
        Public Property filterDestinationMacAddresses As Boolean
        Public Property destinationMacAddresses As Object
        Public Property filterSourcePorts As Boolean
        Public Property sourcePorts As Object
        Public Property filterDestinationPorts As Boolean
        Public Property destinationPorts As Object
        Public Property filterProtocols As Boolean
        Public Property selectedProtocols As Object
        Public Property filterContentExtraction As Boolean
        Public Property specifyFileNames As Boolean
        Public Property fileNames As Object
        Public Property specifyFileSizeMin As Boolean
        Public Property specifyFileSizeMax As Boolean
        Public Property fileSizeMax As Integer
        Public Property fileSizeMin As Integer
        Public Property filterFileNames As Boolean
    End Class

    Public Class NetworkAcquisitionIocDefinition
        Public Property specifyEndDate As Boolean
        Public Property utcOffset As String
        Public Property timeZoneName As Object
        Public Property rangeFromDate As DateTime
        Public Property rangeUntilDate As DateTime
        Public Property filterProbes As Boolean
        Public Property probes As Object
        Public Property filterSourceIpAddresses As Boolean
        Public Property sourceIpAddresses As Object
        Public Property filterDestinationIpAddresses As Boolean
        Public Property destinationIpAdresses As Object
        Public Property filterSourceMacAddresses As Boolean
        Public Property sourceMacAddresses As Object
        Public Property filterDestinationMacAddresses As Boolean
        Public Property destinationMacAddresses As Object
        Public Property filterSourcePorts As Boolean
        Public Property sourcePorts As Object
        Public Property filterDestinationPorts As Boolean
        Public Property destinationPorts As Object
        Public Property filterProtocols As Boolean
        Public Property selectedProtocols As Object
        Public Property filterContentExtraction As Boolean
        Public Property specifyFileNames As Boolean
        Public Property fileNames As Object
        Public Property specifyFileSizeMin As Boolean
        Public Property specifyFileSizeMax As Boolean
        Public Property fileSizeMax As Integer
        Public Property fileSizeMin As Integer
        Public Property filterFileNames As Boolean
    End Class

    Public Class NetworkAcquisitionWebContentDefinition
        Public Property filterProtocolHttp_Proxy As Boolean
        Public Property filterProtocolHttp As Boolean
        Public Property filterProtocolHttps As Boolean
        Public Property filterHosts As Boolean
        Public Property hosts As Object
        Public Property filterURL As Boolean
        Public Property url As Object
        Public Property actionPut As Boolean
        Public Property actionTrace As Boolean
        Public Property actionPost As Boolean
        Public Property actionHead As Boolean
        Public Property filterActions As Boolean
        Public Property actionGet As Boolean
        Public Property actionDelete As Boolean
        Public Property actionConnect As Boolean
        Public Property actionOptions As Boolean
        Public Property actionPatch As Boolean
        Public Property filterFileExtensions As Boolean
        Public Property fileExtensions As Object
        Public Property filterReferrer As Boolean
        Public Property referrer As Object
        Public Property filterFileContent As Boolean
        Public Property fileContent As Object
        Public Property fullReconstruction As Boolean
        Public Property specifyEndDate As Boolean
        Public Property utcOffset As String
        Public Property timeZoneName As Object
        Public Property rangeFromDate As DateTime
        Public Property rangeUntilDate As DateTime
        Public Property filterProbes As Boolean
        Public Property probes As Object
        Public Property filterSourceIpAddresses As Boolean
        Public Property sourceIpAddresses As Object
        Public Property filterDestinationIpAddresses As Boolean
        Public Property destinationIpAdresses As Object
        Public Property filterSourceMacAddresses As Boolean
        Public Property sourceMacAddresses As Object
        Public Property filterDestinationMacAddresses As Boolean
        Public Property destinationMacAddresses As Object
        Public Property filterSourcePorts As Boolean
        Public Property sourcePorts As Object
        Public Property filterDestinationPorts As Boolean
        Public Property destinationPorts As Object
        Public Property filterProtocols As Boolean
        Public Property selectedProtocols As Object
        Public Property filterContentExtraction As Boolean
        Public Property specifyFileNames As Boolean
        Public Property fileNames As Object
        Public Property specifyFileSizeMin As Boolean
        Public Property specifyFileSizeMax As Boolean
        Public Property fileSizeMax As Integer
        Public Property fileSizeMin As Integer
        Public Property filterFileNames As Boolean
    End Class

    Public Class NetworkAcquisitionDefinition
        Public Property networkAcquisitionEmailDefinition As NetworkAcquisitionEmailDefinition
        Public Property networkAcquisitionTransactionDefinition As NetworkAcquisitionTransactionDefinition
        Public Property networkAcquisitionSessionDefinition As NetworkAcquisitionSessionDefinition
        Public Property networkAcquisitionRemoteShellDefinition As NetworkAcquisitionRemoteShellDefinition
        Public Property networkAcquisitionIocDefinition As NetworkAcquisitionIocDefinition
        Public Property networkAcquisitionWebContentDefinition As NetworkAcquisitionWebContentDefinition
        Public Property includeEmail As Boolean
        Public Property includeWebContent As Boolean
        Public Property includeTransaction As Boolean
        Public Property includeSession As Boolean
        Public Property includeIoc As Boolean
        Public Property includeRemoteShell As Boolean
        Public Property collectors As Object
        Public Property timeZones As Object
    End Class

    Public Class ThreatScanJobOptions
        Public Property threatFilters As Object()
        Public Property threatScanSelection As Integer
        Public Property authoredByFilter As Object
        Public Property categoryFilter As Object
        Public Property groupFilter As Object
        Public Property sourceFilter As Object
        Public Property initialCreationDateFilter As Object
        Public Property enableArchiveDrillDown As Boolean
        Public Property archiveDrillDownExtensions As Object
        Public Property enableIgnoreIOCFileSize As Boolean
        Public Property enableIgnoreYARAFileSize As Boolean
        Public Property ignoreIOCFileSizeBytes As Integer
        Public Property ignoreYARAFileSizeBytes As Integer
        Public Property disableHashing As Boolean
        Public Property disableStringContentSearch As Boolean
    End Class

    Public Class JobCustomTargetInfo
        Public Property computerGroupsFilter As Object
        Public Property computerAndOpdGroups As Object
        Public Property computerTargets As Object()
        Public Property networkShareTargets As Object()
        Public Property personTargetAssociations As Object()
        Public Property mobileDeviceTargets As Object()
        Public Property computerFilter As Object
        Public Property useFilterToSelectComputers As Boolean
        Public Property mobileDeviceFilter As Object
        Public Property useFilterToSelectMobileDevices As Boolean
        Public Property shareFilter As Object
        Public Property useFilterToSelectShares As Boolean
        Public Property includePersons As Boolean
        Public Property includeComputers As Boolean
        Public Property includeShares As Boolean
        Public Property includeNetworkCollectors As Boolean
        Public Property includePersonComputers As Boolean
        Public Property includePersonShares As Boolean
        Public Property includePersonMobileDevices As Boolean
        Public Property includeMobileDevices As Boolean
    End Class

    Public Class JobIpRangeTargetInfo
        Public Property startOctetOne As Integer
        Public Property startOctetTwo As Integer
        Public Property startOctetThree As Integer
        Public Property startOctetFour As Integer
        Public Property endOctetOne As Integer
        Public Property endOctetTwo As Integer
        Public Property endOctetThree As Integer
        Public Property endOctetFour As Integer
    End Class

    Public Class JobGroupTargetInfo
        Public Property jobGroups As Object()
        Public Property groupPersonTargets As Object()
        Public Property groupComputerTargets As Object()
        Public Property groupNetworkShareTargets As Object()
        Public Property groupPersonTargetAssociationExclusions As Object()
        Public Property includePersons As Boolean
        Public Property includeComputers As Boolean
        Public Property includeShares As Boolean
        Public Property includeNetworkCollectors As Boolean
        Public Property includePersonComputers As Boolean
        Public Property includePersonShares As Boolean
        Public Property includePersonMobileDevices As Boolean
        Public Property includeMobileDevices As Boolean
    End Class

    Public Class AgentOperationsDefinition
        Public Property isUninstallNukeAgentChecked As Boolean
        Public Property isMakePublicInstanceChecked As Boolean
        Public Property isMakeHeartbeatChecked As Boolean
        Public Property agentUsesProtectedStorage As Boolean
        Public Property agentUsesFileStorage As Boolean
        Public Property isRuntimeAgent As Boolean
        Public Property agentHasLifetime As Boolean
        Public Property sizeOfTheDataStoreMB As Object
        Public Property sizeOfTheStoreMB As Object
        Public Property serviceName As Object
        Public Property executableName As Object
        Public Property portNumber As Object
        Public Property primaryAgentPortNumber As Object
        Public Property specifyPortNumber As Boolean
        Public Property agentLifeTime As Integer
        Public Property agentLifeTimeUnit As Integer
    End Class

    Public Class [Event]
        Public Property type As String
        Public Property id As Integer
        Public Property name As String
        Public Property description As Object
        Public Property events As Object()
        Public Property isAgentEvent As Boolean
        Public Property isMobileEvent As Boolean
    End Class

    Public Class EventEndpointOptions
        Public Property startDate As Object
        Public Property endDate As Object
        Public Property relativeStartMinute As Object
        Public Property relativeEndMinute As Object
        Public Property useRelativeTime As Boolean
        Public Property events As Models.Job2.Event()
        Public Property includeSystemProcess As Boolean
        Public Property osEventFilters As Object
        Public Property fileEventFilters As Object
        Public Property networkEventFilters As Object
        Public Property registryEventFilters As Object
    End Class

    Public Class JobDefinition
        Public Property type As String
        Public Property secondaryActionTemplateId As String
        Public Property secondaryActionsImmediate As Boolean
        Public Property secondaryActionsEnabled As Boolean
        Public Property threatScanIsReportOnly As Boolean
        Public Property useRoleBasedApproval As Boolean
        Public Property useCollectionTemplate As Boolean
        Public Property inheritResponsivePath As Boolean
        Public Property inheritJobPriorityFromProject As Boolean
        Public Property inheritAgentPriorityFromProject As Boolean
        Public Property aD1EncryptionInheritFromProject As Boolean
        Public Property autoProcessJob As Boolean
        Public Property destinationRoot As String
        Public Property projectResponsiveFilePath As Object
        Public Property jobApprovers As Object()
        Public Property shareFilters As ShareFilters
        Public Property computerFilters As ComputerFilters
        Public Property advancedOptions As AdvancedOptions
        Public Property jobArchiveAndRemediateInfo As JobArchiveAndRemediateInfo
        Public Property jobType As Integer
        Public Property projectId As String
        Public Property responsiveFilePath As String
        Public Property rmPolicyDefinition As RmPolicyDefinition
        Public Property rmPolicyDefinition2 As RmPolicyDefinition2
        Public Property jobSchedule As JobSchedule
        Public Property volatileDefinition As VolatileDefinition
        Public Property volatileScheduleDefinition As VolatileScheduleDefinition
        Public Property memoryAnalysisDefinition As MemoryAnalysisDefinition
        Public Property agentRemediateInfo As AgentRemediateInfo
        Public Property memoryAcquisitionInfo As MemoryAcquisitionInfo
        Public Property processDumpInfo As ProcessDumpInfo
        Public Property combinationJobInfo As CombinationJobInfo
        Public Property isFullDiskAcquisition As Boolean
        Public Property hasAgentOperationsDefinition As Boolean
        Public Property basicJamSelected As Boolean
        Public Property advancedJamSelected As Boolean
        Public Property jamThreshold As Integer
        Public Property showUnscorables As Boolean
        Public Property memoryOperationsType As Integer
        Public Property networkAcquisitionDefinition As NetworkAcquisitionDefinition
        Public Property createArchiveFileOnAgent As Boolean
        Public Property kffInfo As Object
        Public Property threatScanJobOptions As ThreatScanJobOptions
        Public Property disableHashing As Boolean
        Public Property recurringIncrementalCollection As Boolean
        Public Property runScriptsOnJobCompletion As Boolean
        Public Property impersonationUsername As Object
        Public Property impersonationDomain As Object
        Public Property impersonationPasswordEncrypted As Object
        Public Property impersonationPasswordEncryptedChanged As Boolean
        Public Property scriptFileName As Object
        Public Property updateJobOptionsOnCreation As Boolean
        Public Property createVulnerableSoftwareReport As Boolean
        Public Property description As String
        Public Property jobId As String
        Public Property jobCustomTargetInfo As JobCustomTargetInfo
        Public Property jobIpRangeTargetInfo As JobIpRangeTargetInfo
        Public Property name As String
        Public Property priority As Integer
        Public Property agentPriority As Integer
        Public Property userId As Integer
        Public Property jobGroupTargetInfo As JobGroupTargetInfo
        Public Property isForceEndEnabled As Boolean
        Public Property forceEndAfterDays As Integer
        Public Property forceEndAfterHours As Integer
        Public Property targetTypeSelected As Integer
        Public Property jobExpirationSingleAttempt As Boolean
        Public Property jobExpirationCancelPending As Boolean
        Public Property jobExpirationCancelIncomplete As Boolean
        Public Property agentOperationsDefinition As AgentOperationsDefinition
        Public Property eventEndpointOptions As EventEndpointOptions
        Public Property isUseJobTemplateOptionEnabled As Boolean
        Public Property selectedJobTemplate As Object
        Public Property saveAsJobTemplate As Boolean
        Public Property includeTemplateTargetOptions As Boolean
        Public Property taskboardCategoryName As String
        Public Property updateJobOptionsOnTaskboardCreation As Boolean
    End Class

    Public Class TemplatejobDefinition
        Public Property jobDefinition As JobDefinition
    End Class
End Namespace