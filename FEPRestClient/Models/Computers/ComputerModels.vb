Namespace Models
    Public Class ComputersInGroup
        Public Property groupId As String
        Public Property computers As New List(Of Computers)
        Public Property rootComputerCount As Integer
    End Class

    Public Class Computers
        Public Property computerId As String
        Public Property agentOS As String
        Public Property computerName As String
        Public Property ipAddressLastContacted As String
        Public Property agentLastContacted As String
        Public Property createdDate As String
    End Class
End Namespace
