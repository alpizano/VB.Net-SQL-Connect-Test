Public Class Student

  Private iID As Integer
  Private iPrimKeyID As Integer
  Private iUniqID As Integer
  Private sFirstName As String
  Private sLastName As String
  Private iAge As Integer
  Private decPayRate As Decimal

  Sub New(iPrimKeyID As Integer, iUniqID As Integer, sFirstName As String, sLastName As String, iAge As Integer, decPayRate As Decimal)

    iPrimKeyID = 0
    iUniqID = 0
    sFirstName = Nothing
    sLastName = Nothing
    iAge = 0
    decPayRate = 0

  End Sub

  Sub New()
    iPrimKeyID = 0
    iUniqID = 0
    sFirstName = Nothing
    sLastName = Nothing
    iAge = 0
    decPayRate = 0
  End Sub

  Property ID() As Integer
    Get
      Return iID
    End Get
    Set(value As Integer)
      iID = value
    End Set
  End Property

  Property PrimKeyID() As Integer
    Get
      Return iPrimKeyID
    End Get
    Set(value As Integer)
      iPrimKeyID = value
    End Set
  End Property

  Property UniqID() As Integer
    Get
      Return iUniqID
    End Get
    Set(value As Integer)
      iUniqID = value
    End Set
  End Property

  Property FirstName() As String
    Get
      Return sFirstName
    End Get
    Set(value As String)
      sFirstName = value
    End Set
  End Property

  Property LastName() As String
    Get
      Return sLastName
    End Get
    Set(value As String)
      sLastName = value
    End Set
  End Property

  Property Age() As Integer
    Get
      Return iAge
    End Get
    Set(value As Integer)
      iAge = value
    End Set
  End Property

  Property PayRate() As Decimal
    Get
      Return decPayRate
    End Get
    Set(value As Decimal)
      decPayRate = value
    End Set
  End Property

End Class
