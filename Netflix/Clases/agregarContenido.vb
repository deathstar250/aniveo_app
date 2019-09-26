Public Class agregarContenido

    Private _id As Integer
    Private _titulo As String
    Private _genero As String
    Private _duracion_minutos As Integer
    Private _duracion_segundos As Integer
    Private _link As String
    Private _sinopsis As String
    Private _calificacion_id As Integer
    Private _reparto As String
    Private _fecha_estreno As Date



    Sub New(id As Integer, titulo As String, genero As String, duracion_minutos As Integer,
            duracion_segundos As Integer, link As String,
             sinopsis As String, calificacion_id As Integer, reparto As String, fecha_estreno As Date)

        id = _id
        titulo = _titulo
        genero = _genero
        duracion_minutos = _duracion_minutos
        duracion_segundos = _duracion_segundos
        link = _link
        sinopsis = _sinopsis
        calificacion_id = _calificacion_id
        reparto = _reparto
        fecha_estreno = _fecha_estreno

    End Sub

    Public Property fecha_estreno As Date
        Get
            Return _fecha_estreno
        End Get
        Set(value As Date)
            _fecha_estreno = value
        End Set
    End Property


    Public Property reparto As String
        Get
            Return _sinopsis
        End Get
        Set(value As String)
            _sinopsis = value
        End Set
    End Property


    Public Property sinopsis As String
        Get
            Return _sinopsis
        End Get
        Set(value As String)
            _sinopsis = value
        End Set
    End Property


    Public Property link As String
        Get
            Return _link
        End Get
        Set(value As String)
            _link = value
        End Set
    End Property

    Public Property calificacion_id As Integer
        Get
            Return _calificacion_id
        End Get
        Set(value As Integer)
            _calificacion_id = value
        End Set
    End Property

    Public Property duracion_segundos As Integer
        Get
            Return _duracion_segundos
        End Get
        Set(value As Integer)
            _duracion_segundos = value
        End Set
    End Property


    Public Property duracion_minutos As Integer
        Get
            Return _duracion_minutos
        End Get
        Set(value As Integer)
            _duracion_minutos = value
        End Set
    End Property

    Public Property genero As String
        Get
            Return _genero
        End Get
        Set(value As String)
            _genero = value
        End Set
    End Property


    Public Property titulo As Integer
        Get
            Return _titulo
        End Get
        Set(value As Integer)
            _titulo = value
        End Set
    End Property

End Class