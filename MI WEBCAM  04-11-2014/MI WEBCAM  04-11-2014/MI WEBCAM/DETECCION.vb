Public Class DETECCION
    Dim CARPETA As String = "C:\MI WEBCAM\CARPETAS DETECCION\"
    Dim DIAS As Integer
    Dim INTERVALO As Integer
    Dim DATOS As IDataObject
    Dim IMAGEN As Image
    Dim CONTADOR As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MUESTRA QUE EN ESTE MOMENTO NO HA DETECTADO AMENAZAS
        Form1.Label1.Visible = True
        'RESALTA EL BOTON PARA PARAR LA DETECCION
        Form1.Button1.BackColor = Color.Blue
        Form1.Button1.Text = "PARAR DETECCION"
        'TOMA EL NUMERO DE DIAS PARA LA ANTIGÜEDAD QUE SE QUIERE CONSERVAR
        DIAS = CInt(TextBox2.Text)

        ' SI HAY CARPETAS MAS ANTIGUAS QUE LAS DESEADAS ELIMINALAS
        If My.Computer.FileSystem.DirectoryExists(CARPETA) Then
            ELIMINAR()
        End If

        'TOMA EL NUMERO DE IMAGENES POR MINUTO A GUARDAR POR DETECCION DE MOVIMIENTO
        INTERVALO = CInt(TextBox1.Text)
        Timer2.Interval = 1000 * 60 / INTERVALO

        'SI NO EXISTE EL DIRECTORIO CARPETAS DIARIAS LO CREARA, SI EXISTE NO HARA NADA
        If My.Computer.FileSystem.FileExists(CARPETA) = False Then
            My.Computer.FileSystem.CreateDirectory(CARPETA)

        End If


        'COPIA LA IMAGEN DE LA WEBCAM EN EL PICTUREBOX2 DE ESTE FORMULARIO PARA COMPARAR
        PictureBox2.Image = PictureBox1.Image

        'PONE EN MARCHA EL RELOJ PARA HACER COMPARACIONES
        Timer1.Enabled = True
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
       
        'COMPARACION DE PIXELES ENTRE PICTUREBOX1 Y PICTUREBOX2
        Dim BITMAP1 As Bitmap
        Dim BITMAP2 As Bitmap
        Dim ROJO As Integer = 0
        Dim VERDE As Integer = 0
        Dim AZUL As Integer = 0
        Dim X, Y As Integer

        BITMAP1 = PictureBox1.Image
        BITMAP2 = PictureBox2.Image
        For Y = 0 To BITMAP1.Height - 1 Step 10
            For X = 0 To BITMAP1.Width - 1 Step 10
                Dim MICOLOR1 As Color = BITMAP1.GetPixel(X, Y)
                Dim MICOLOR2 As Color = BITMAP2.GetPixel(X, Y)

                If Math.Abs(CInt(MICOLOR1.R) - CInt(MICOLOR2.R)) > 20 Then
                    ROJO = ROJO + 1

                End If
                If Math.Abs(CInt(MICOLOR1.G) - CInt(MICOLOR2.G)) > 20 Then
                    VERDE = VERDE + 1

                End If
                If Math.Abs(CInt(MICOLOR1.B) - CInt(MICOLOR2.B)) > 20 Then
                    AZUL = AZUL + 1

                End If
            Next
        Next
        Dim SUMA As Integer = ROJO + VERDE + AZUL
        ' SI LA SUMA DE LAS DIFERENCIAS ES SUFICIENTEMENTE GRANDE  ALARMA Y EMPIEZA A GUARDAR IMAGENES
        If SUMA > 500 Then
            Beep()
            Form1.TextBox1.Text = Form1.TextBox1.Text + vbCrLf & "NUEVA DETECCION:" & vbCrLf & DateTime.Now.ToShortDateString & "  HORA: " & DateTime.Now.ToLongTimeString & vbCrLf
            Form1.Label3.Visible = True
            Form1.Button2.Visible = True
            Timer1.Enabled = False
            Timer2.Enabled = True
            Form1.Label1.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' CADA MINUTO COMPRUEBA SI SIGUEN HABIENDO CAMBIOS EN LA IMAGEN
        If CONTADOR > INTERVALO Then
            CONTADOR = 0
            PictureBox2.Image = PictureBox1.Image
            Timer1.Enabled = True
            Timer2.Enabled = False
            Form1.Label1.Visible = True
        Else

            'VAMOS A COMPONER EL NOMBRE DE LAS SUBCARPETAS CON FORMATO AÑO/MES/DIA PARA QUE SE 
            'ORDENEN DE MAS NUEVA A MAS ANTIGUA
            Dim SUBCARPETA_AA As String
            SUBCARPETA_AA = DateTime.Today.Year
            Dim SUBCARPETA_MM As String
            SUBCARPETA_MM = DateTime.Today.Month
            If SUBCARPETA_MM < 10 Then
                SUBCARPETA_MM = "0" & SUBCARPETA_MM
            End If
            Dim SUBCARPETA_DD As String
            SUBCARPETA_DD = DateTime.Today.Day
            If SUBCARPETA_DD < 10 Then
                SUBCARPETA_DD = "0" & SUBCARPETA_DD
            End If

            'EL NOMBRE DE LA SUBCARPETA SE COMPONDRA CON LAS ANTERIORES SEPARADAS POR _ E
            'INCLUYE LA BARRA SEPARADORA DE CARPETAS
            Dim SUBCARPETA As String
            SUBCARPETA = SUBCARPETA_AA & "_" & SUBCARPETA_MM & "_" & SUBCARPETA_DD & "\"

            'SI NO EXISTE LA SUBCARPETA LA CREARA, SI EXISTE NO HARA NADA
            If My.Computer.FileSystem.FileExists(CARPETA & SUBCARPETA) = False Then
                My.Computer.FileSystem.CreateDirectory(CARPETA & SUBCARPETA)

            End If

            'GUARDA LAS IMAGENES DE LA DETECCION
            Dim FECHA As String = DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_")
            PictureBox1.Image.Save(CARPETA & "\" & SUBCARPETA & FECHA & ".JPG", Imaging.ImageFormat.Jpeg)

            'PARA CALCULAR UN MINUTO DE GRABACION
            CONTADOR = CONTADOR + 1
        End If
    End Sub
    Public Sub ELIMINAR()
        'DEFINIMOS EL NUMERO DE DIAS DE SEGURIDAD Y LO CONVERTIMOS EN INTERVALO DE TIEMPO

        Dim MENOS As TimeSpan
        MENOS = New TimeSpan(-DIAS, 0, 0, 0)

        'CAPTURAMOS LA FECHA ACTUAL
        Dim FECHA_ACTUAL As DateTime
        FECHA_ACTUAL = DateTime.Today

        'DETERMINAMOS LA FECHA DE SEGURIDAD
        Dim FECHA_SEGURIDAD As DateTime
        FECHA_SEGURIDAD = FECHA_ACTUAL.Add(MENOS)

        'DESCOMPONEMOS LA FECHA MAXIMA EN SUS ELEMENTOS Y AÑADIMOS 0 SI EL MES O DIA < 10
        Dim FECHA_MAXIMA_AÑO As String
        FECHA_MAXIMA_AÑO = FECHA_SEGURIDAD.Year
        Dim FECHA_MAXIMA_MES As String
        FECHA_MAXIMA_MES = FECHA_SEGURIDAD.Month
        If FECHA_MAXIMA_MES < 10 Then
            FECHA_MAXIMA_MES = "0" & FECHA_MAXIMA_MES
        End If
        Dim FECHA_MAXIMA_DIA As String
        FECHA_MAXIMA_DIA = FECHA_SEGURIDAD.Day
        If FECHA_MAXIMA_DIA < 10 Then
            FECHA_MAXIMA_DIA = "0" & FECHA_MAXIMA_DIA
        End If
        ' COMPONEMOS LA FECHA EN EL MISMO FORMATO QUE COMPUSIMOS LAS SUBCARPETAS
        Dim FECHA_COMPARACION As String
        FECHA_COMPARACION = FECHA_MAXIMA_AÑO & "_" & FECHA_MAXIMA_MES & "_" & FECHA_MAXIMA_DIA

        'CREAMOS UN ARRAY CON LOS NOMBRES DE LAS SUBCARPETAS QUE CONTIENE "CARPETAS DIARIAS"
        Dim SUBCARPETAS As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        SUBCARPETAS = My.Computer.FileSystem.GetDirectories(CARPETA)

        'SI HAY  MAS CARPETAS QUE DIAS DE SEGURIDAD ELIMINAREMOS LAS MAS ANTIGUAS

        'RECORREMOS TODO EL ARRAY
        For I = 0 To SUBCARPETAS.Count - 1
            'DEJAMOS SOLO LA PARTE FINAL DEL NOMBRE DE LA SUBCARPETA 
            Dim INDICE As Integer
            INDICE = SUBCARPETAS(I).LastIndexOf("\")
            Dim SUBCARPETA_NOMBRE As String
            SUBCARPETA_NOMBRE = SUBCARPETAS(I).Substring(INDICE + 1, 10)
            'SI LA PARTE FINAL DEL NOMBRE DE  LA SUBCARPETA ES MENOR O IGUAL QUE LA FECHA DE COMPARACION
            'ELIMINALA
            If SUBCARPETA_NOMBRE <= FECHA_COMPARACION Then
                My.Computer.FileSystem.DeleteDirectory(SUBCARPETAS(I), FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If

        Next


    End Sub
End Class