Imports R1SimpleRestClient.Models.Enums

Namespace Models
    Public Class Project
        Public Class NewProjectDefinition
            Public ProjectId As Guid
            Public Name As String
            Public Description As String
            Public FTKCaseFolderPath As String
            Public ResponsiveFilePath As String
            Public Priority As Integer
            Public AgentPriority As Integer
            Public ProjectType As String
            Public ProcessingMode As ProcessModeEnum
            Public CreateHTMLForAllFiles As Boolean
            Public OCREnabled As Boolean
            Public OCRPDFEnabled As Boolean
            Public OCRTIFFEnabled As Boolean
            Public OCRJPEGEnabled As Boolean
            Public OCRBMPEnabled As Boolean
            Public OCRPNGEnabled As Boolean
            Public OCRGIFEnabled As Boolean
            Public OCRUnCommonEnabled As Boolean
            Public DoNotOCRUnderEnabled As Boolean
            Public DoNotOCROverEnabled As Boolean
            Public DoNotOCRFullColorEnabled As Boolean
            Public DoNotOCRPdfTextSizeOverEnabled As Boolean
            Public DoNotOCRUnderValue As System.Nullable(Of Long)
            Public DoNotOCROverValue As System.Nullable(Of Long)
            Public DoNotOCRPdfTextSizeOverValue As System.Nullable(Of Long)
            Public IsDontExpandEmbeddedGraphicsEnabled As Boolean
            Public EntropyEnabled As Boolean
            Public CerberusStage1Enabled As Boolean
            Public CerberusStage2Enabled As Boolean
            Public Threshold As Integer
            Public KFFEnabled As Boolean
            Public ADViewerEnabled As Boolean
            Public VideoConversionEnabled As Boolean
            Public VideoResolution As Integer
            Public VideoBitRate As Integer
            Public GenerateThumbNailEnabled As Boolean
            Public ThumbNailInterval As Integer
            Public ThumbNailMode As ThumbNailModeTypes
            Public KFFAllowIgnorable As KFFAllowIgnorableEnum
            Public KFFToken As String
            Public DedupActualFilesOnly As Boolean
            Public DupeAtOption As DupeAtOptionEnum
            Public EmailDupeAtOption As DupeAtOptionEnum
            Public UseEmailHash As Boolean
            Public UseEmailTo As Boolean
            Public UseEmailFrom As Boolean
            Public UseEmailSubject As Boolean
            Public UseEmailCc As Boolean
            Public UseEmailBCc As Boolean
            Public UseEmailSubmittime As Boolean
            Public UseEmailDeliverytime As Boolean
            Public UseEmailAttachmentcount As Boolean
            Public EmailHashDeduplicationOption As EmailHashDuplicatesEnum
            Public Password As String
            Public CertificateId As System.Nullable(Of Guid)
            Public AssociatedPersonIds As Guid()
            Public CustomPropertyValues As List(Of CustomPropertyValue)
            Public Ad1Encryption As Ad1EncryptionPresenter
            Public Attorney As String
            Public Jurisdiction As String
            Public LegalAssistant As String
            Public OutsideCounsel As String
            Public Comments As String
            Public EffectiveStartDate As System.Nullable(Of DateTime)
            Public EffectiveEndDate As System.Nullable(Of DateTime)
            Public LanguageOption As LanguageOption
            Public AutomaticallyPerformClusteringAfterLoad As Boolean
            Public MaxKeywordPairs As Integer
            Public ClusterThreshold As Long
            Public EmailBodyCaching As Boolean
            Public DoNotDropDbIndexes As Boolean
            Public GeoLocationEnabled As Boolean
            Public FeedCheckingEnabled As Boolean
            Public FeedVirusTotalEnabled As Boolean
            Public FeedDataPurgeEnabled As Boolean
            Public ExpandAdditionalTimelineEvents As Boolean
            Public MinimalIndexing As Boolean
            Public DisplayTimeZone As String
            Public DefaultSortColumn As String
            Public DefaultSortOrder As String
            Public GenerateImageThumbNailsEnabled As Boolean
            Public ExtractCreditCardNumbers As Boolean
            Public ExtractPeople As Boolean
            Public ExtractLocations As Boolean
            Public ExtractOrganizations As Boolean
            Public ExtractEmailAddresses As Boolean
            Public ExtractSSNs As Boolean
            Public ExtractPhoneNumbers As Boolean
            Public SearchProvider As SearchProviderEnum
            Public NetworkAcquisitionRetainValue As Integer
            Public NetworkAcquisitionPurgeFirstPurge As DateTime
            Public NetworkAcquisitionFrequencyValue As Integer
            Public EventRetainValue As Integer
            Public EventFirstPurge As DateTime
            Public EventFrequencyValue As Integer
            Public VolatileRetainValue As Integer
            Public VolatilePurgeFirstPurge As DateTime
            Public VolatileFrequencyValue As Integer
        End Class
        Public Class CustomPropertyValue
            Public PropertyId As Guid
            Public Value As String
        End Class
        Public Class Ad1EncryptionPresenter
            Public EncryptionType As Ad1EncryptionPresenterType
            Public CertificateId As Guid
            Public Password As String
        End Class
        Public Class EncryptionType
            Private _Id As Integer
            Private _Description As String
        End Class
        Public Class SerializableProjectCustomProperty
            Public PropertyId As Guid
            Public Name As String
            Public Value As String
        End Class
        Public Class ProjectCustomPropertyValue
            Private _PropertyId As Guid
            Private _ProjectId As Guid
            Private _Value As String
        End Class
        Public Class ProjectPresenter
            Public Property ForceHasChanges As Integer
            Public Property ProjectId As Guid
            Public Property ProjectType As String
            Public Property Name As String
            Public Property Description As String
            Public Property CreatedDate As DateTime
            Public Property CreatedByUsername As String
            Public Property ModifiedDate As DateTime
            Public Property ModifiedByUsername As String
            Public Property FtkCaseId As System.Nullable(Of Long)
            Public Property FtkCaseFolderPath As String
            Public Property ResponsiveFilePath As String
            Public Property IsSensitive As Boolean
            Public Property Priority As Integer
            Public Property PriorityText As String
            Public Property AgentPriority As Integer
            Public Property Status As Integer
            Public Property StatusText As String
            Public Property Size As Double
            Public Property JobsCount As Integer
            Public Property Attorney As String
            Public Property Jurisdiction As String
            Public Property LegalAssistant As String
            Public Property OutsideCounsel As String
            Public Property Comments As String
            Public Property EffectiveStartDate As System.Nullable(Of DateTime)
            Public Property EffectiveEndDate As System.Nullable(Of DateTime)
            Public Property SelectedCertificateId As System.Nullable(Of Guid)
            Public Property MainPasswordString As String
            Public Property HasPassword As Boolean
            Public Property EncryptedPassword As String
            Public Property EncryptionPasswordSalt As String
            Public Property ProjectCustomPropertyValues As List(Of ProjectCustomPropertyValue)
            Public Property CustomPropertyValues As List(Of SerializableProjectCustomProperty)
            Public Property EncryptionType As EncryptionType
            Public Property NetworkAcquisitionRetainValue As Integer
            Public Property NetworkAcquisitionPurgeFirstPurge As DateTime
            Public Property NetworkAcquisitionFrequencyValue As Integer
            Public Property EventRetainValue As Integer
            Public Property EventFirstPurge As DateTime
            Public Property PurgeEventsEnabled As Boolean
            Public Property PurgeVolatileEnabled As Boolean
            Public Property PurgeNetworkEnabled As Boolean
            Public Property EventFrequencyValue As Integer
            Public Property VolatileRetainValue As Integer
            Public Property VolatilePurgeFirstPurge As DateTime
            Public Property VolatileFrequencyValue As Integer
            Public Property FeedCheckingEnabled As Boolean
            Public Property FeedVirusTotalEnabled As Boolean
            Public Property FeedDataPurgeEnabled As Boolean
            Public Property DisplayTimeZone As String
            Public Property DefaultSortColumn As String
            Public Property DefaultSortOrder As String
        End Class
    End Class
End Namespace
