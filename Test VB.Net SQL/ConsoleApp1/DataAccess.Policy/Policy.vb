'Module Module1
Imports DataAccess.Common

Public Class Policy

  Public Function FetchPolicyDetail() As DataTable

    Dim sSQL As String = "SELECT * " &
                          "FROM Policy p "

    Return ExecuteDataTable(sSQL)
  End Function

End Class

'End Module
