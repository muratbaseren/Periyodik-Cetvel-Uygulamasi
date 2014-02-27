Public Class Paramaters

#Region "LocalVariables"

    Private Deger1_ As String
    Private Deger2_ As String
    Private Deger3_ As String
    Private Deger4_ As String
    Private Deger5_ As String

#End Region

#Region "Properties"

    Public Property Deger1() As String
        Get
            Return Me.Deger1_
        End Get
        Set(ByVal value As String)
            Me.Deger1_ = value
        End Set
    End Property
    Public Property Deger2() As String
        Get
            Return Me.Deger2_
        End Get
        Set(ByVal value As String)
            Me.Deger2_ = value
        End Set
    End Property
    Public Property Deger3() As String
        Get
            Return Me.Deger3_
        End Get
        Set(ByVal value As String)
            Me.Deger3_ = value
        End Set
    End Property
    Public Property Deger4() As String
        Get
            Return Me.Deger4_
        End Get
        Set(ByVal value As String)
            Me.Deger4_ = value
        End Set
    End Property
    Public Property Deger5() As String
        Get
            Return Me.Deger5_
        End Get
        Set(ByVal value As String)
            Me.Deger5_ = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal Deger1 As String)

        Me.Deger1_ = Deger1

    End Sub

    Public Sub New(ByVal Deger1 As String, ByVal Deger2 As String)

        Me.Deger1_ = Deger1
        Me.Deger2_ = Deger2

    End Sub

    Public Sub New(ByVal Deger1 As String, ByVal Deger2 As String, ByVal Deger3 As String)

        Me.Deger1_ = Deger1
        Me.Deger2_ = Deger2
        Me.Deger3_ = Deger3

    End Sub

    Public Sub New(ByVal Deger1 As String, ByVal Deger2 As String, ByVal Deger3 As String, ByVal Deger4 As String)

        Me.Deger1_ = Deger1
        Me.Deger2_ = Deger2
        Me.Deger3_ = Deger3
        Me.Deger4_ = Deger4

    End Sub

    Public Sub New(ByVal Deger1 As String, ByVal Deger2 As String, ByVal Deger3 As String, ByVal Deger4 As String, ByVal Deger5 As String)

        Me.Deger1_ = Deger1
        Me.Deger2_ = Deger2
        Me.Deger3_ = Deger3
        Me.Deger4_ = Deger4
        Me.Deger5_ = Deger5

    End Sub

#End Region

End Class
