Public Class ElementObject

#Region "LocalVariables"

    Private AtomNo_ As Integer
    Private AtomAgirlik_ As Single
    Private Grup_ As String
    Private Periyot_ As Integer
    Private Isim_ As String
    Private Desc_ As String

#End Region

#Region "Properties"

    Public Property AtomNo() As Integer
        Get
            Return Me.AtomNo_
        End Get
        Set(ByVal value As Integer)
            Me.AtomNo_ = value
        End Set
    End Property
    Public Property AtomAgirlik() As Single
        Get
            Return Me.AtomAgirlik_
        End Get
        Set(ByVal value As Single)
            Me.AtomAgirlik_ = value
        End Set
    End Property
    Public Property Grup() As String
        Get
            Return Me.Grup_
        End Get
        Set(ByVal value As String)
            Me.Grup_ = value
        End Set
    End Property
    Public Property Isim() As String
        Get
            Return Me.Isim_
        End Get
        Set(ByVal value As String)
            Me.Isim_ = value
        End Set
    End Property
    Public Property Periyot() As Integer
        Get
            Return Me.Periyot_
        End Get
        Set(ByVal value As Integer)
            Me.Periyot_ = value
        End Set
    End Property
    Public Property Desc() As String
        Get
            Return Me.Desc_
        End Get
        Set(ByVal value As String)
            Me.Desc_ = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal AtomNo As Integer, ByVal AtomAgirlik As Single, ByVal Grup As String, ByVal Periyot As Integer, ByVal Isim As String, ByVal Aciklama As String)
        Me.AtomNo_ = AtomNo
        Me.AtomAgirlik_ = AtomAgirlik
        Me.Grup_ = Grup
        Me.Isim_ = Isim
        Me.Periyot_ = Periyot
        Me.Desc_ = Aciklama
    End Sub

#End Region

End Class
