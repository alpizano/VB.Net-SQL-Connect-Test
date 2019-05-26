Imports dat = Data.Policy

Public Class Policy


  'Public Function PopulateDataObject(ByVal oDataTable As DataTable) As dat.Policy
  'Dim datPolicy As New dat.Policy
  'If oDataTable IsNot Nothing AndAlso oDataTable.Rows.Count > 0 Then
  'datPolicy = New dat.Policy()
  'With datPolicy
  'Must use get and set names for 
  '.PolicyUser = oDataTable.Rows(0).Field(Of Integer)("UniqPolicy")
  '.PolicyNumber = oDataTable.Rows(0).Field(Of Integer)("UniqEntity")
  '.PolicyName = oDataTable.Rows(0).Field(Of String)("Name")
  'End With
  'End If
  'Return datPolicy
  'End Function

  Public Function PopulateDataObject(ByVal oDataTable As DataTable) As dat.Policy
    Dim datPolicy As New dat.Policy
    If oDataTable IsNot Nothing AndAlso oDataTable.Rows.Count > 0 Then
      datPolicy = New dat.Policy()
      With datPolicy
        'Must use get and set names for 
        .PolicyUser = oDataTable.Rows(0).Field(Of Integer)("UniqPolicy")
        .PolicyNumber = oDataTable.Rows(0).Field(Of Integer)("UniqEntity")
        .PolicyName = oDataTable.Rows(0).Field(Of String)("Name")
      End With
    End If
    Return datPolicy
  End Function

End Class
