Imports System.IO
Imports Newtonsoft.Json
Imports RestSharp.Serializers

Module RestSharpSerializer




    ''' <summary>
    ''' Default JSON serializer for request bodies
    ''' Doesn't currently use the SerializeAs attribute, defers to Newtonsoft's attributes
    ''' </summary>
    Public Class RestSharpJsonNetSerializer
        Implements ISerializer

        Private ReadOnly _serializer As Newtonsoft.Json.JsonSerializer

        ''' <summary>
        ''' Default serializer
        ''' </summary>
        Public Sub New()
            ContentType = "application/json"
            _serializer = New Newtonsoft.Json.JsonSerializer() With { _
                .MissingMemberHandling = MissingMemberHandling.Ignore, _
                .NullValueHandling = NullValueHandling.Include, _
                .DefaultValueHandling = DefaultValueHandling.Include _
            }
        End Sub

        ''' <summary>
        ''' Default serializer with overload for allowing custom Json.NET settings
        ''' </summary>
        Public Sub New(serializer As Newtonsoft.Json.JsonSerializer)
            ContentType = "application/json"
            _serializer = serializer
        End Sub

        ''' <summary>
        ''' Serialize the object as JSON
        ''' </summary>
        ''' <param name="obj">Object to serialize
        ''' <returns>JSON as String</returns>
        Public Function Serialize(obj As Object) As String
            Using stringWriter = New StringWriter()
                Using jsonTextWriter = New JsonTextWriter(stringWriter)
                    jsonTextWriter.Formatting = Formatting.Indented
                    jsonTextWriter.QuoteChar = """"c

                    _serializer.Serialize(jsonTextWriter, obj)

                    Dim result = stringWriter.ToString()
                    Return result
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Unused for JSON Serialization
        ''' </summary>
        Public Property DateFormat() As String
            Get
                Return m_DateFormat
            End Get
            Set(value As String)
                m_DateFormat = value
            End Set
        End Property
        Private m_DateFormat As String
        ''' <summary>
        ''' Unused for JSON Serialization
        ''' </summary>
        Public Property RootElement() As String
            Get
                Return m_RootElement
            End Get
            Set(value As String)
                m_RootElement = value
            End Set
        End Property
        Private m_RootElement As String
        ''' <summary>
        ''' Unused for JSON Serialization
        ''' </summary>
        Public Property [Namespace]() As String
            Get
                Return m_Namespace
            End Get
            Set(value As String)
                m_Namespace = value
            End Set
        End Property
        Private m_Namespace As String
        ''' <summary>
        ''' Content type for serialized content
        ''' </summary>
        Public Property ContentType() As String
            Get
                Return m_ContentType
            End Get
            Set(value As String)
                m_ContentType = value
            End Set
        End Property
        Private m_ContentType As String

        Public Property ContentType1 As String Implements ISerializer.ContentType

        Public Property DateFormat1 As String Implements ISerializer.DateFormat

        Public Property Namespace1 As String Implements ISerializer.Namespace

        Public Property RootElement1 As String Implements ISerializer.RootElement

        Public Function Serialize1(obj As Object) As String Implements ISerializer.Serialize

        End Function
    End Class




End Module
