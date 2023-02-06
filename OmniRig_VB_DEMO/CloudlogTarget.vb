Imports CloudlogCAT.My
Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class CloudlogTarget

    Private _name As String ' The name of this target, this is only visible in the error messages and in settings window
    Private _radioName As String ' the String which is displayed in Cloudlog, Appended by 1 or 2 depending on the RIG Radio Button Setting
    Private _url As String
    Private _key As String
    Private _active As Boolean ' Determines weather CloudlogCAT should push to this variable

    ' Empty construcor, initializes the object with basic Names, sets it to not be active
    Public Sub New()
        _name = "Target"
        _radioName = "OmniRig"
        _active = False
        _url = ""
        _key = ""
    End Sub

    ' Complete Constructor
    Public Sub New(ByVal name As String, ByVal radioName As String, ByVal url As String, ByVal key As String, ByVal active As Boolean)
        _name = name
        _radioName = radioName
        _url = url
        _key = key
        _active = active
    End Sub


    ' A shared function which allows to serialize an ArrayList Object of CloudlogTargets objects into a string
    ' This is needed as the settings functions only allows to store basic datatypes
    ' Argument: ArrayList
    ' Returns: String
    Public Shared Function toSettingsString(ByVal list As ArrayList) As String
        Dim serialized As String
        Dim formatter As New BinaryFormatter()
        Using memoryStream As New MemoryStream()
            formatter.Serialize(memoryStream, list)
            serialized = Convert.ToBase64String(memoryStream.ToArray())
        End Using
        Return serialized
    End Function

    ' A shared function which allows to deserialize a string into an ArrayList Object of CloudlogTarget objects into a string
    ' This is needed as the settings functions only allows to store basic datatypes
    ' Argument: ArrayList
    ' Returns: String
    Public Shared Function fromSettingsString(ByVal str As String) As ArrayList
        Dim formatter As New BinaryFormatter()
        Dim retrievedTargets As ArrayList
        Using memoryStream As New MemoryStream(Convert.FromBase64String(str))
            retrievedTargets = DirectCast(formatter.Deserialize(memoryStream), ArrayList)
        End Using
        Return retrievedTargets
    End Function


    ' Setter and Getter Functions
    <Category("Target"), Description("Name of the target, only visible within CloudlogCAT")>
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    <Category("Target"), Description("The Radio Name displayed by Cloudlog")>
    Public Property radioName() As String
        Get
            Return _radioName
        End Get
        Set(ByVal value As String)
            _radioName = value
        End Set
    End Property

    <Category("Target"), Description("URL of Cloudlog")>
    Public Property url() As String
        Get
            Return _url
        End Get
        Set(ByVal value As String)
            _url = value
        End Set
    End Property

    <Category("Target"), Description("API Key of Cloudlog")>
    Public Property key() As String
        Get
            Return _key
        End Get
        Set(ByVal value As String)
            _key = value
        End Set
    End Property

    <Category("Target"), Description("Should CloudlogCAT publish to this target?")>
    Public Property active() As Boolean
        Get
            Return _active
        End Get
        Set(ByVal value As Boolean)
            _active = value
        End Set
    End Property

End Class
