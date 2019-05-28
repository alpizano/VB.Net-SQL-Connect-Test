'Module Module1
Imports DataAccess.Common

Public Class Student

  Public Function Fetch() As DataTable

    Dim sSQL As String = "SELECT * FROM Student"

    '"WHERE = " & iEntityID

    Return ExecuteDataTable(sSQL)
  End Function

End Class

'End Module
