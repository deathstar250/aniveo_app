Public Class nuevoUsuario

    Private _nombre_usuario As String
    Private _nombre As String
    Private _apellido As String
    Private _contrasenia As String
    Private _correo As String
    Private _fechaNacimiento As Date
    Private _edad As Integer

    Sub New(nombre_usuario As String, nombre As String, apellido As String, contrasenia As String, correo As String, fechaNac As Date)
        _nombre_usuario = nombre_usuario
        _nombre = nombre
        _apellido = apellido
        _contrasenia = contrasenia
        _correo = correo
        _fechaNacimiento = fechaNac
        _edad = calcularEdad()
    End Sub

    Public Property contrasenia As String
        Get
            Return _contrasenia
        End Get
        Set(value As String)
            _contrasenia = value
        End Set
    End Property

    Public Property Nombre_usuario As String
        Get
            Return _nombre_usuario
        End Get
        Set(value As String)
            _nombre_usuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Private Function calcularEdad() As Integer
        Dim fechaActual = Date.Now ' 5/6/2019 - 9/8/2017
        Dim edad = fechaActual.Year - _fechaNacimiento.Year
        '18
        If (_fechaNacimiento.Month > fechaActual.Month) Then
            edad = edad - 1
        ElseIf (_fechaNacimiento.Month = fechaActual.Month) Then
            If (_fechaNacimiento.Day > fechaActual.Day) Then
                edad = edad - 1
            End If
        End If
        Return edad
    End Function




End Class
