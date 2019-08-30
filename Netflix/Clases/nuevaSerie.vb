Public Class nuevaSerie

    Private _nombreSerie As String
    Private _linkSerie As String
    Private _linkCaratula As String


    Sub New(nombreSerie As String, linkSerie As String, linkCaratula As String)
        _nombreSerie = nombreSerie
        _linkSerie = linkSerie
        _linkCaratula = linkCaratula
    End Sub

    Public Property nombreSerie As String
        Get
            Return _nombreSerie
        End Get
        Set(value As String)
            _nombreSerie = value
        End Set
    End Property

    Public Property linkSerie As String
        Get
            Return _linkSerie
        End Get
        Set(value As String)
            _linkSerie = value
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
