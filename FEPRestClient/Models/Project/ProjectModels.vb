Imports FEPRestClient.Models.Enums

Namespace Models
    Public Class Project
        Public Class SimpleNewProject
            Public Property description As String
            Public Property feedCheckingEnabled As Boolean
            Public Property ftkCaseFolderPath As String
            Public Property name As String
            Public Property processingMode As ProcessModeEnum
            Public Property responsiveFilePath As String
        End Class


        Public Class NewProjectDefinition
            Public Property ProjectId As String
            Public Property Name As String
            Public Property Description As String
            Public Property FTKCaseFolderPath As String
            Public Property ResponsiveFilePath As String
            Public Property Priority As Integer
            Public Property AgentPriority As Integer
            Public Property ProjectType As String
            Public Property ProcessingMode As ProcessModeEnum
            Public Property CreateHTMLForAllFiles As Boolean
            Public Property OCREnabled As Boolean
            Public Property OCRPDFEnabled As Boolean
            Public Property OCRTIFFEnabled As Boolean
            Public Property OCRJPEGEnabled As Boolean
            Public Property OCRBMPEnabled As Boolean
            Public Property OCRPNGEnabled As Boolean
            Public Property OCRGIFEnabled As Boolean
            Public Property OCRUnCommonEnabled As Boolean
            Public Property DoNotOCRUnderEnabled As Boolean
            Public Property DoNotOCROverEnabled As Boolean
            Public Property DoNotOCRFullColorEnabled As Boolean
            Public Property DoNotOCRPdfTextSizeOverEnabled As Boolean
            Public Property DoNotOCRUnderValue As System.Nullable(Of Long)
            Public Property DoNotOCROverValue As System.Nullable(Of Long)
            Public Property DoNotOCRPdfTextSizeOverValue As System.Nullable(Of Long)
            Public Property IsDontExpandEmbeddedGraphicsEnabled As Boolean
            Public Property EntropyEnabled As Boolean
            Public Property CerberusStage1Enabled As Boolean
            Public Property CerberusStage2Enabled As Boolean
            Public Property Threshold As Integer
            Public Property KFFEnabled As Boolean
            Public Property ADViewerEnabled As Boolean
            Public Property VideoConversionEnabled As Boolean
            Public Property VideoResolution As Integer
            Public Property VideoBitRate As Integer
            Public Property GenerateThumbNailEnabled As Boolean
            Public Property ThumbNailInterval As Integer
            Public Property ThumbNailMode As ThumbNailModeTypes
            Public Property KFFAllowIgnorable As KFFAllowIgnorableEnum
            Public Property KFFToken As String
            Public Property DedupActualFilesOnly As Boolean
            Public Property DupeAtOption As DupeAtOptionEnum
            Public Property EmailDupeAtOption As DupeAtOptionEnum
            Public Property UseEmailHash As Boolean
            Public Property UseEmailTo As Boolean
            Public Property UseEmailFrom As Boolean
            Public Property UseEmailSubject As Boolean
            Public Property UseEmailCc As Boolean
            Public Property UseEmailBCc As Boolean
            Public Property UseEmailSubmittime As Boolean
            Public Property UseEmailDeliverytime As Boolean
            Public Property UseEmailAttachmentcount As Boolean
            Public Property EmailHashDeduplicationOption As EmailHashDuplicatesEnum
            Public Property Password As String
            Public Property CertificateId As System.Nullable(Of Guid)
            Public Property AssociatedPersonIds As Guid()
            Public Property CustomPropertyValues As List(Of CustomPropertyValue)
            Public Property Ad1Encryption As Ad1EncryptionPresenter
            Public Property Attorney As String
            Public Property Jurisdiction As String
            Public Property LegalAssistant As String
            Public Property OutsideCounsel As String
            Public Property Comments As String
            Public Property EffectiveStartDate As System.Nullable(Of DateTime)
            Public Property EffectiveEndDate As System.Nullable(Of DateTime)
            Public Property LanguageOption As LanguageOption
            Public Property AutomaticallyPerformClusteringAfterLoad As Boolean
            Public Property MaxKeywordPairs As Integer
            Public Property ClusterThreshold As Long
            Public Property EmailBodyCaching As Boolean
            Public Property DoNotDropDbIndexes As Boolean
            Public Property GeoLocationEnabled As Boolean
            Public Property FeedCheckingEnabled As Boolean
            Public Property FeedVirusTotalEnabled As Boolean
            Public Property FeedDataPurgeEnabled As Boolean
            Public Property ExpandAdditionalTimelineEvents As Boolean
            Public Property MinimalIndexing As Boolean
            Public Property DisplayTimeZone As String
            Public Property DefaultSortColumn As String
            Public Property DefaultSortOrder As String
            Public Property GenerateImageThumbNailsEnabled As Boolean
            Public Property ExtractCreditCardNumbers As Boolean
            Public Property ExtractPeople As Boolean
            Public Property ExtractLocations As Boolean
            Public Property ExtractOrganizations As Boolean
            Public Property ExtractEmailAddresses As Boolean
            Public Property ExtractSSNs As Boolean
            Public Property ExtractPhoneNumbers As Boolean
            Public Property SearchProvider As SearchProviderEnum
            Public Property NetworkAcquisitionRetainValue As Integer
            Public Property NetworkAcquisitionPurgeFirstPurge As DateTime
            Public Property NetworkAcquisitionFrequencyValue As Integer
            Public Property EventRetainValue As Integer
            Public Property EventFirstPurge As DateTime
            Public Property EventFrequencyValue As Integer
            Public Property VolatileRetainValue As Integer
            Public Property VolatilePurgeFirstPurge As DateTime
            Public Property VolatileFrequencyValue As Integer
        End Class
        Public Class CustomPropertyValue
            Public Property PropertyId As Guid
            Public Property Value As String
        End Class
        Public Class Ad1EncryptionPresenter
            Public Property EncryptionType As Ad1EncryptionPresenterType
            Public Property CertificateId As Guid
            Public Property Password As String
        End Class
        Public Class EncryptionType
            Private _Id As Integer
            Private _Description As String
        End Class
        Public Class SerializableProjectCustomProperty
            Public Property PropertyId As Guid
            Public Property Name As String
            Public Property Value As String
        End Class
        Public Class ProjectCustomPropertyValue
            Private _PropertyId As Guid
            Private _ProjectId As String
            Private _Value As String
        End Class
        Public Class ProjectPresenter
            Public Property ForceHasChanges As Integer
            Public Property ProjectId As String
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
