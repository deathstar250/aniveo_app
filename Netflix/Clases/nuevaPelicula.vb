Public Class nuevaPelicula

    Private _nombrePelicula As String
    Private _linkPelicula As String
    Private _linkCaratula As String


    Sub New(nombrePelicula As String, linkPelicula As String, linkCaratula As String)
        _nombrePelicula = nombrePelicula
        _linkPelicula = linkPelicula
        _linkCaratula = linkCaratula
    End Sub

    Public Property nombrePelicula As String
        Get
            Return _nombrePelicula
        End Get
        Set(value As String)
            _nombrePelicula = value
        End Set
    End Property

    Public Property linkPelicula As String
        Get
            Return _linkPelicula
        End Get
        Set(value As String)
            _linkPelicula = value
        End Set
    End Property

    Public Property linkCaratula As String
        Get
            Return _linkCaratula
        End Get
        Set(value As String)
            _linkCaratula = value
        End Set
    End Property
End Class
