
Public Class AgregarPelicula

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim _id As Integer = traerID() + 1
            Dim _titulo As String = txtNombrePelicula.Text
            Dim _genero As String = txtGenero.Text
            Dim _duracion_minutos As Integer = txtDuracionMinutos.Text
            Dim _duracion_segundos As Integer = txtDuracionSegundos.Text
            Dim _link As String = txtLink.Text
            Dim _sinopsis As String = txtSinopsis.Text
            Dim _calificacion_id As Integer = txtCalificacion.Text
            Dim _reparto As String = txtReparto.Text
            Dim _fecha_estreno As Date

            Try
                _fecha_estreno = calendar.SelectionRange.Start
            Catch ex As Exception
                lblError.Text = ex.Message
            End Try

            If cbxPelicula.Checked Then
                Try
                    Dim _contenido = New agregarContenido(_id, _titulo, _genero, _duracion_minutos, _duracion_segundos, _link, _sinopsis, _calificacion_id, _reparto, _fecha_estreno)

                    Dim connectionClass = New Connection_PgSQL
                    Dim connection = New Npgsql.NpgsqlConnection()
                    connection = connectionClass.OpenConnection()

                    Dim cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = connection

                    Dim commandString = "insert into contenido VALUES (@_id,@_titulo, @_genero, @_duracion_minutos, @_duracion_segundos, @_link, @_sinopsis, @_calificacion_id, @_reparto, @_fecha_estreno);"

                    cmd.Parameters.Add("@_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = _id
                    cmd.Parameters.Add("@_titulo", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = _titulo
                    cmd.Parameters.Add("@_genero", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = _genero
                    cmd.Parameters.Add("@_duracion_minutos", NpgsqlTypes.NpgsqlDbType.Integer).Value = _duracion_minutos
                    cmd.Parameters.Add("@_duracion_segundos", NpgsqlTypes.NpgsqlDbType.Integer).Value = _duracion_segundos
                    cmd.Parameters.Add("@_link", NpgsqlTypes.NpgsqlDbType.Varchar, 1000).Value = _link
                    cmd.Parameters.Add("@_sinopsis", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = _sinopsis
                    cmd.Parameters.Add("@_calificacion_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = _calificacion_id
                    cmd.Parameters.Add("@_reparto", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = _reparto
                    cmd.Parameters.Add("@_fecha_estreno", NpgsqlTypes.NpgsqlDbType.Date).Value = _fecha_estreno

                    Dim resultado As Integer

                    resultado = cmd.ExecuteNonQuery()

                    If (resultado >= 0) Then
                        lblError.Text = "Enhorabuena, usuario creado correctamente"
                    Else
                        lblError.Text = "Le has errado al bizcochardo"
                    End If

                    connection.Close()
                    cmd.Parameters.Clear()



                    Dim connectionClass1 = New Connection_PgSQL
                    Dim connection1 = New Npgsql.NpgsqlConnection()
                    connection1 = connectionClass1.OpenConnection()

                    Dim cmd1 = New Npgsql.NpgsqlCommand()
                    cmd1.Connection = connection1

                    Dim commandString1 = "insert into reseña_contenido  (IDreseña,IDContenido) values (@_calificacion_id,@_id);"

                    cmd1.Parameters.Add("@_calificacion_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = _calificacion_id
                    cmd1.Parameters.Add("@_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = _id

                    Dim resultado1 As Integer

                    resultado1 = cmd1.ExecuteNonQuery()

                    If (resultado1 >= 0) Then
                        lblError.Text = "Enhorabuena, usuario creado correctamente"
                    Else
                        lblError.Text = "Le has errado al bizcochardo"
                    End If

                    connection1.Close()
                    cmd1.Parameters.Clear()

                Catch ex As Exception
                    lblError.Text = ex.Message
                End Try



            ElseIf cbxSerie.Checked Then

                lblError.Text = "no te pregunte"

            Else

            End If





        Catch ex As Exception

        End Try
    End Sub

    Public Function traerID()

        Try
            Dim clasecnn = New Connection_PgSQL
            Dim conexion As New Npgsql.NpgsqlConnection()
            conexion = clasecnn.OpenConnection()
            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion
            Dim commandString = " select count(*) from contenido"

            Dim id As Integer

            cmd.CommandText = commandString

            Dim lector As Npgsql.NpgsqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then

                lector.Read()
                id = lector(0).ToString

                lector.Close()
                cmd.Parameters.Clear()

                Return id

            End If


        Catch ex As Exception
            lblError.Text = ex.Message
        End Try




    End Function


    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = System.Drawing.Color.DimGray

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(214, 175, 26)

    End Sub

    Private Sub AgregarPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtSinopsis_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtCalificacion_TextChanged(sender As Object, e As EventArgs) Handles txtCalificacion.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class




'Select Case* From reseña

'Select Case* From reseña_contenido;

'Select Case* From contenido;

'insert into contenido ();

'drop table capitulo;
'drop table serie;
'drop table pelicula;
'drop table contenido;
'drop table capitulo_serie ;
'drop table reseña_contenido;
'drop table reseña;
'drop table comentario;
'drop table comentario_contenido;
'drop table lista_contenido;
'drop table lista;
'drop table normal_reseña;
'drop table normal;
'drop table normal_administrador;
'drop table administrador_contenido;


'CREATE TABLE reseña ( 
'        	ID Integer PRIMARY KEY Not NULL, 
'        	calificacion VARCHAR(20)  Not NULL, 
'        	fecha Date Not NULL 
'); 


'  CREATE TABLE contenido ( 
'        	ID Integer  PRIMARY KEY Not NULL, 
'        	titulo VARCHAR(50)  Not NULL, 
'        	genero VARCHAR(50) Not NULL, 
'        	duracion_minutos INT  Not NULL, 
'	duracion_segundos INT  Not NULL, 
'	link VARCHAR(1000) Not NULL,
'        	sinopsis VARCHAR(100) Not NULL, 
'        	calificacion_ID Integer Not NULL, 
'        	reparto VARCHAR(50) Not NULL, 
'        	fecha_estreno Date Not NULL, 
'        	FOREIGN KEY(calificacion_ID) REFERENCES reseña (ID)  
'); 




'CREATE TABLE reseña_contenido (
'        	IDreseña  Integer Not NULL, 
'            IDContenido Integer Not NULL,
'        	PRIMARY KEY(IDreseña, IDContenido),
'            FOREIGN KEY (IDreseña) REFERENCES reseña (ID),
'        	FOREIGN KEY(IDContenido) REFERENCES contenido (ID)
');  


'INSERT INTO contenido VALUES ( 1, 'gallinas asesinas', 'horror, acción, suspenso', 130, 00, 'https:/linkpeli.mp4/', 'Duki salva a su padre de las gallinas asesinas', 1, 'duki, papa de duki', '2019/05/24'),
'( 2, 'Elsor Prendido', ' suspenso', 200, 00,  'https:/linkpeli2.mp4/', 'un hombre se sorprende tanto que le hicieron una pelicula', 2, 'Elsor Prendido', '2020/01/24'),
'( 3, 'La aventura de Micho y Tito', 'aventura', 300, 00, 'https:/linkpeli3.mp4/', 'La historia de dos amigos inseparables que fueron unidos por el destino', 3, 'Micho, Tito', '2019/09/13'),
'( 4, 'Avengers End End game', 'acción, ficción', 200, 00, 'https:/linkpeli4.mp4/', 'La historia de los vengadores jamas contada', 4.5, 'revengers, nico fiury, la mujer ardilla, thamos', '2021/01/24'),
'( 5, 'Elsor Prendido dos', ' suspenso', 200, 00, 'https:/linkpeli5.mp4/', 'un hombre se sorprende tanto que le hicieron una pelicula dos', 2, 'Elsor Prendido', '2020/01/25');


'INSERT INTO reseña_contenido VALUES (90,1), (90,2), (90,3), (90,4), (90,5);


'insert into reseña (id,calificacion,fecha) VALUES (1,'1','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (2,'2','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (3,'3','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (4,'4','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (5,'5','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (6,'6','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (7,'7','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (8,'8','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (9,'9','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (10,'10','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (11,'11','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (12,'12','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (13,'13','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (14,'14','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (15,'15','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (16,'16','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (17,'17','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (18,'18','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (19,'19','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (20,'20','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (21,'21','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (22,'22','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (23,'23','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (24,'24','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (25,'25','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (26,'26','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (27,'27','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (28,'28','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (29,'29','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (30,'30','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (31,'31','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (32,'32','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (33,'33','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (34,'34','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (35,'35','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (36,'36','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (37,'37','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (38,'38','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (39,'39','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (40,'40','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (41,'41','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (42,'42','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (43,'43','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (44,'44','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (45,'45','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (46,'46','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (47,'47','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (48,'48','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (49,'49','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (50,'50','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (51,'51','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (52,'52','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (53,'53','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (54,'54','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (55,'55','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (56,'56','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (57,'57','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (58,'58','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (59,'59','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (60,'60','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (61,'61','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (62,'62','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (63,'63','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (64,'64','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (65,'65','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (66,'66','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (67,'67','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (68,'68','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (69,'69','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (70,'70','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (71,'71','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (72,'72','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (73,'73','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (74,'74','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (75,'75','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (76,'76','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (77,'77','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (78,'78','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (79,'79','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (80,'80','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (81,'81','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (82,'82','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (83,'83','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (84,'84','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (85,'85','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (86,'86','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (87,'87','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (88,'88','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (89,'89','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (90,'90','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (91,'91','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (92,'92','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (93,'93','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (94,'94','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (95,'95','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (96,'96','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (97,'97','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (98,'98','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (99,'99','10-10-2019');
'insert into reseña (id,calificacion,fecha) VALUES (100,'100','10-10-2019');
