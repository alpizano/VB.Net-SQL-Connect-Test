Imports dat = Data.Student
Imports da = DataAccess.Student

Public Class Student


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

  Private ReadOnly Property daStudent() As da.Student
    Get
      Return New da.Student
    End Get
  End Property


  Public Function Find(ByVal iEntityID As Integer) As dat.Students

    'Dim daStudent As New da.Student

    Return PopulateDataObject(daStudent.Fetch(iEntityID))

  End Function

  Public Function PopulateDataObject(ByVal oDataTable As DataTable) As dat.Students

    Dim datStudents As New dat.Students 'Creates new Students List object 
    Dim datStudent As dat.Student = Nothing 'Creates new Student object

    If oDataTable IsNot Nothing Then

      For Each oDataRow As DataRow In oDataTable.Rows
        datStudent = New dat.Student()

        With datStudent

          .PrimKeyID = oDataRow.Field(Of Integer)("TestPrimKeyID")
          .UniqID = oDataRow.Field(Of Integer)("TestUniqID")
          .FirstName = oDataRow.Field(Of String)("FirstName")
          .LastName = oDataRow.Field(Of String)("LastName")
          .Age = oDataRow.Field(Of Integer)("Age")
          .Payrate = oDataRow.Field(Of Decimal)("PayRate")

        End With
        datStudents.Add(datStudent) 'Adding Students object to List of Students
      Next
    End If

    Return datStudents 'Returns Students List

  End Function

End Class
