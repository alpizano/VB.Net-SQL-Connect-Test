﻿'Module Module1
Imports DataAccess.Common

Public Class Student

  Public Function Fetch(ByVal iEntityID As Integer) As DataTable

    Dim sSQL As String = "SELECT * " &
                          "FROM Student s" &
                          "WHERE =" & iEntityID

    Return ExecuteDataTable(sSQL)
  End Function

End Class

'End Module
