'Module Common
'Sub Main()
'End Sub
'End Module

Imports System.Data.SqlClient
Imports System.IO

'Module NOT Class!
Public Module Common

  Public Function ToDBString(ByVal sValue As String) As String

    Return sValue.Replace("'", "''")

  End Function

  Public Function ExecuteDataTable(ByVal sSQL As String) As DataTable

    Dim oDataTable As New DataTable
    'Dim oDataAdapter As New SqlDataAdapter(sSQL, GetConnectionString())
    Dim oDataAdapter As New SqlDataAdapter(sSQL, "Data Source=DESKTOP-OS08J4I;Initial Catalog=testDB;Integrated Security=True")
    oDataAdapter.Fill(oDataTable)
    Return oDataTable

  End Function

  Private Function GetConnectionString() As String

    'Using rdrSettings As StreamReader = File.OpenText(Path.Combine(Environment.CurrentDirectory, "DataAccess.Common.txt"))
    'Return "Data Source=" & rdrSettings.ReadLine() & "; Database=" & rdrSettings.ReadLine() & "; Integrated Security=True"
    'End Using

    Return "Data Source=DESKTOP-OS08J4I; Database=testDB; Integrated Security=True"

  End Function




End Module
