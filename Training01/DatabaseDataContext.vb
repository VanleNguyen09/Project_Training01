Imports System.Data.Linq

Public Class DatabaseDataContext
    Inherits DataContext

    Public Property Employees As Table(Of Employees)

    Public Sub New(connectionString As String)
        MyBase.New(connectionString)
        Employees = Me.GetTable(Of Employees)()
    End Sub
End Class
