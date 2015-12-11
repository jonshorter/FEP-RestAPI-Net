Namespace Models
    Public Class ComputersInGroup
        Public groupId As String
        Public computers As New List(Of Computers)
        Public rootComputerCount As Integer
    End Class

    Public Class Computers
        Public computerId As String
        Public agentOS As String
        Public computerName As String
        Public ipAddressLastContacted As String
        Public agentLastContacted As Date
        Public createdDate As Date
    End Class
End Namespace
