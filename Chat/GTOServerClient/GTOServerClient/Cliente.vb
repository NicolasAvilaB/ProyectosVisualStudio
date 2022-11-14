Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Cliente

    Sub New()

    End Sub

    Sub New(ByVal port As Integer, ByVal IPHost As String)
        _IPDelHost = IPHost
        _PuertoDelHost = port
    End Sub

#Region "VARIABLES"

    Private Stm As Stream 'Utilizado para enviar datos al Servidor y recibir datos del mismo

    Private _IPDelHost As String 'Direccion del objeto de la clase Servidor

    Private _MAC As String 'Mac de la PC

    Private _NombrePC As String 'Nombre de la PC

    Private _PuertoDelHost As Integer 'Puerto donde escucha el objeto de la clase Servidor

    Dim tcpClnt As TcpClient
    Dim tcpThd As Thread 'Se encarga de escuchar mensajes enviados por el Servidor

    Private _IsConnected As Boolean

    Private _PathDirectoryTemp As String

    Const BufferSize As Integer = 1024

    Private _IsSocketBusy As Boolean

#End Region

#Region "PROPIEDADES"


    Public ReadOnly Property IsSocketBusy() As Boolean
        Get
            Return _IsSocketBusy
        End Get
    End Property


    Public Property PathDirectoryTemp() As String
        Get
            Return _PathDirectoryTemp
        End Get
        Set(ByVal value As String)
            _PathDirectoryTemp = value
        End Set
    End Property


    Public ReadOnly Property IsConnected() As Boolean
        Get
            Return _IsConnected
        End Get

    End Property

    Public Property NombrePC() As String
        Get
            Return _NombrePC
        End Get
        Set(ByVal Value As String)

            _NombrePC = Value
        End Set
    End Property

    Public Property IPDelHost() As String
        Get
            Return _IPDelHost
        End Get
        Set(ByVal Value As String)
            _IPDelHost = Value
        End Set
    End Property

    Public Property Local_MAC() As String
        Get
            Return _MAC
        End Get
        Set(ByVal Value As String)
            _MAC = Value
        End Set
    End Property

    Public Property PuertoDelHost() As Integer
        Get
            Return _PuertoDelHost
        End Get
        Set(ByVal Value As Integer)
            _PuertoDelHost = Value
        End Set
    End Property

#End Region

#Region "EVENTOS"

    Public Event ConexionIniciada()
    Public Event ConexionTerminada()
    Public Event ErrorCliente(ByVal ErrorMensaje As String)

    Public Event MensajeEnviado(ByVal msj As String)
    Public Event MensajeRecibido(ByVal msj As String)

    Public Event FileEnviado(ByVal file As String, ByVal sizeByte As Integer)
    Public Event FileRecibido(ByVal Pathfile As String, ByVal recbSize As Integer)

    Public Event ObjetoEnviado(ByVal dato As Object)
    Public Event ObjetoRecibido(ByVal dato As Object)

    Public Event IsSocketBusyChanged(ByVal _IsSocketBusy As Boolean)

    Public Event StartTransactionData(ByVal SizeBytes As Integer, ByVal TypeData As TypeData)
    Public Event EndTransactionData(ByVal SizeBytes As Integer, ByVal TypeData As TypeData)
    Public Event ProcessTransactionData(ByVal CountPackage As Integer, ByVal SizeBytes As Integer)
#End Region

#Region "METODOS"

#Region "Set Raise Event Property"

    Private Sub SetIsSocketBusy(ByVal value As Boolean)
        _IsSocketBusy = value
        RaiseEvent IsSocketBusyChanged(value)
    End Sub

#End Region

#Region "Gestion del Cliente"

    Public Sub Cerrar()
        Try
            If _IsConnected Then
                _IsConnected = False
                If Not tcpClnt Is Nothing Then
                    tcpClnt.Close()
                End If
                If Not tcpThd Is Nothing Then
                    tcpThd.Abort()
                End If
            End If
        Catch ex As Exception
            'RaiseEvent ErrorCliente("Operación de Cerrar: " & ex.Message)
        Finally
            RaiseEvent ConexionTerminada()
        End Try

    End Sub

    Public Function Conectar() As Boolean
        Try
            If Not _IsConnected Then
                tcpClnt = New TcpClient()
                'Me conecto al objeto de la clase Servidor,

                '  determinado por las propiedades IPDelHost y PuertoDelHost

                tcpClnt.Connect(IPDelHost, PuertoDelHost)
                _IsConnected = tcpClnt.Connected
                If _IsConnected Then
                    Stm = tcpClnt.GetStream()
                    'Creo e inicio un thread para que escuche los mensajes enviados por el Servidor
                    tcpThd = New Thread(AddressOf LeerSocket)
                    tcpThd.Start()
                    RaiseEvent ConexionIniciada()
                End If
            End If

            Return _IsConnected
        Catch ex As Exception
            RaiseEvent ErrorCliente("Operación de Conectar: " & ex.Message)
            Return False
        End Try
    End Function

#End Region

#Region "Envio y recepcion de datos"

    Private Sub LeerSocket()


        Dim BufferDeLectura() As Byte
        Dim longitudByte(3) As Byte
        Dim TipeData(3) As Byte
        Dim lengitudInt As Integer
        Dim Ret As Integer

        Dim totalrecbytes As Integer = 0
        Dim Kon As Integer = 0
        Dim Fs As FileStream
        While True

            Try
                Ret = Stm.Read(TipeData, 0, TipeData.Length)
                If Ret > 0 Then
                    Ret = Stm.Read(longitudByte, 0, longitudByte.Length)
                    If Ret > 0 Then

                        lengitudInt = BitConverter.ToInt32(longitudByte, 0)
                        totalrecbytes = 0

                        If lengitudInt > BufferSize Then
                            BufferDeLectura = New Byte(BufferSize - 1) {}
                        Else
                            BufferDeLectura = New Byte(lengitudInt - 1) {}
                        End If
                        Select Case BitConverter.ToInt32(TipeData, 0)
                            Case TypeData.FileData
                                Dim rnd As New Random
                                Dim PathFile As String = PathFileAvailable()

                                Fs = New FileStream(PathFile, FileMode.OpenOrCreate, FileAccess.Write)
                                RaiseEvent StartTransactionData(lengitudInt, TypeData.FileData)
                                Do
                                    Ret = Stm.Read(BufferDeLectura, 0, BufferDeLectura.Length)
                                    Fs.Write(BufferDeLectura, 0, Ret)
                                    totalrecbytes += Ret
                                    Kon = Kon + 1
                                    If Kon = 50 Then
                                        RaiseEvent ProcessTransactionData(Kon, totalrecbytes)
                                        Kon = 0
                                    End If
                                Loop While (Ret > 0 And totalrecbytes < lengitudInt)
                                Fs.Close()
                                RaiseEvent EndTransactionData(totalrecbytes, TypeData.FileData)
                                RaiseEvent FileRecibido(PathFile, totalrecbytes)
                            Case TypeData.ObjetoData
                                Dim bufferData(lengitudInt - 1) As Byte
                                RaiseEvent StartTransactionData(lengitudInt, TypeData.FileData)
                                Do
                                    Ret = Stm.Read(BufferDeLectura, 0, BufferDeLectura.Length)
                                    ByteWrite(bufferData, BufferDeLectura, totalrecbytes, Ret)
                                    totalrecbytes += Ret
                                    Kon = Kon + 1
                                    If Kon = 50 Then
                                        RaiseEvent ProcessTransactionData(Kon, totalrecbytes)
                                        Kon = 0
                                    End If
                                Loop While (Ret > 0 And totalrecbytes < lengitudInt)

                                RaiseEvent EndTransactionData(totalrecbytes, TypeData.ObjetoData)
                                RaiseEvent ObjetoRecibido(DataStreamTools.Deserialize(bufferData))
                            Case TypeData.StringData
                                Dim bufferData(lengitudInt - 1) As Byte
                                RaiseEvent StartTransactionData(lengitudInt, TypeData.FileData)
                                Do
                                    Ret = Stm.Read(BufferDeLectura, 0, BufferDeLectura.Length)
                                    ByteWrite(bufferData, BufferDeLectura, totalrecbytes, Ret)
                                    totalrecbytes += Ret
                                    Kon = Kon + 1
                                    If Kon = 50 Then
                                        RaiseEvent ProcessTransactionData(Kon, totalrecbytes)
                                        Kon = 0
                                    End If
                                Loop While (Ret > 0 And totalrecbytes < lengitudInt)
                                RaiseEvent EndTransactionData(totalrecbytes, TypeData.StringData)
                                RaiseEvent MensajeRecibido(Encoding.ASCII.GetString(bufferData, 0, bufferData.Length))
                        End Select
                    Else
                        Exit While
                    End If
                Else
                    Exit While
                End If
            Catch e As SocketException
                'Genero el evento de la finalizacion de la conexion
                RaiseEvent ErrorCliente("Socket : " & e.Message)
                If Not tcpClnt.Connected Then
                    Exit While
                End If
            Catch e As System.IO.IOException
                'Genero el evento de la finalizacion de la conexion
                RaiseEvent ErrorCliente("Socket IOException : " & e.Message)
                If Not tcpClnt.Connected Then
                    Exit While
                End If

            Catch ex As Exception
                'Genero el evento de la finalizacion de la conexion
                RaiseEvent ErrorCliente("Exception : " & ex.Message)
                If Not tcpClnt.Connected Then
                    Exit While
                End If
            End Try
        End While
        _IsConnected = False
        tcpClnt.Close()
        RaiseEvent ConexionTerminada()

        tcpThd.Abort()
    End Sub

    Private Sub Thd_EnviarDato(ByVal _obj As Object)
        Try
            Dim _SocketPrmt As SocketParametersThread = CType(_obj, SocketParametersThread)
            Dim BufferDeEscritura() As Byte = _SocketPrmt.BufferByte
            Dim typeData As TypeData = _SocketPrmt.TypeData

            Dim kon As Integer = 0
            Dim SendingBuffer() As Byte
            Dim TotalSendBytes As Integer = 0
            Dim CurrentPacketLength As Integer
            Dim TotalLength As Integer = BufferDeEscritura.Length
            Dim NoOfPackets As Integer = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalLength) / Convert.ToDouble(BufferSize)))

            If Not tcpClnt Is Nothing Then

                If tcpClnt.Connected Then
                    'Obtenemos la longitud en bytes del fichero leido
                    Dim longitud() As Byte = BitConverter.GetBytes(BufferDeEscritura.Length)
                    Dim TypeDataByte() As Byte = BitConverter.GetBytes(typeData)
                    If Not (Stm Is Nothing) Then
                        RaiseEvent StartTransactionData(TotalLength, typeData.FileData)
                        'Envio los datos al Servidor
                        'Pasamos el tipo de dato
                        Stm.Write(TypeDataByte, 0, TypeDataByte.Length)
                        'Stm.Flush()

                        'Pasamos la cantidad de bytes del objeto
                        Stm.Write(longitud, 0, longitud.Length)
                        'Stm.Flush()


                        For i As Integer = 1 To NoOfPackets

                            If (TotalLength > BufferSize) Then

                                CurrentPacketLength = BufferSize
                                TotalLength = TotalLength - CurrentPacketLength

                            Else
                                CurrentPacketLength = TotalLength
                            End If
                            SendingBuffer = New Byte(CurrentPacketLength - 1) {}

                            'Fs.Read(SendingBuffer, 0, CurrentPacketLength)
                            ByteRead(BufferDeEscritura, SendingBuffer, TotalSendBytes, SendingBuffer.Length)

                            Stm.Write(SendingBuffer, 0, SendingBuffer.Length)
                            'Stm.Flush()

                            TotalSendBytes = TotalSendBytes + SendingBuffer.Length

                            kon = kon + 1
                            If kon = 50 Then
                                RaiseEvent ProcessTransactionData(kon, TotalSendBytes)
                                kon = 0
                            End If
                            'If (progressBar1.Value >= progressBar1.Maximum) Then

                            '    progressBar1.Value = progressBar1.Minimum

                            'End If
                            'progressBar1.PerformStep()
                        Next
                        RaiseEvent EndTransactionData(TotalSendBytes, typeData)

                        If typeData = typeData.StringData Then
                            RaiseEvent MensajeEnviado(_SocketPrmt.Msg)
                        ElseIf typeData = typeData.ObjetoData Then
                            RaiseEvent ObjetoEnviado(_SocketPrmt.ObjClass)
                        End If

                    Else
                        RaiseEvent ErrorCliente("Operación Enviar Objeto: Stm is  Nothing")
                    End If
                Else
                    RaiseEvent ErrorCliente("Operación Enviar Objeto: No está conectado!")

                End If
            Else
                RaiseEvent ErrorCliente("Operación Enviar Objeto: No está conectado!")

            End If
        Catch ex As Exception
            RaiseEvent ErrorCliente("Operación Enviar Objeto: " & ex.Message)
        Finally
            SetIsSocketBusy(False)
        End Try
    End Sub

    Public Sub Thd_EnviarFile(ByVal _obj As Object)
        Try
            Dim _SocketPrmt As SocketParametersThread = CType(_obj, SocketParametersThread)

            Dim PathFile As String = PathFileAvailable()

            If DataStreamTools.CompressFiles(_SocketPrmt.PathFile, PathFile) Then
         

            Dim fInfo As New FileInfo(PathFile)

            Dim TypeData As TypeData = TypeData.FileData
            Dim SendingBuffer() As Byte
            Dim TotalSendBytes As Integer = 0
            Dim CurrentPacketLength As Integer
            Dim fStream As New FileStream(PathFile, FileMode.Open, FileAccess.Read)
                Dim kon As Integer = 0
            Dim TotalLength As Integer = fStream.Length

            Dim NoOfPackets As Integer = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalLength) / Convert.ToDouble(BufferSize)))

            If Not tcpClnt Is Nothing Then

                If tcpClnt.Connected Then
                    'Obtenemos la longitud en bytes del fichero leido
                    Dim longitud() As Byte = BitConverter.GetBytes(TotalLength)
                    Dim TypeDataByte() As Byte = BitConverter.GetBytes(TypeData)
                        If Not (Stm Is Nothing) Then
                            RaiseEvent StartTransactionData(TotalLength, TypeData.FileData)
                            'Envio los datos al Servidor
                            'Pasamos el tipo de dato
                            Stm.Write(TypeDataByte, 0, TypeDataByte.Length)
                            'Stm.Flush()

                            'Pasamos la cantidad de bytes del objeto
                            Stm.Write(longitud, 0, longitud.Length)
                            'Stm.Flush()


                            For i As Integer = 1 To NoOfPackets

                                If (TotalLength > BufferSize) Then

                                    CurrentPacketLength = BufferSize
                                    TotalLength = TotalLength - CurrentPacketLength

                                Else
                                    CurrentPacketLength = TotalLength
                                End If
                                SendingBuffer = New Byte(CurrentPacketLength - 1) {}

                                'Fs.Read(SendingBuffer, 0, CurrentPacketLength)
                                'ByteRead(BufferDeEscritura, SendingBuffer, TotalSendBytes, SendingBuffer.Length)
                                fStream.Read(SendingBuffer, 0, CurrentPacketLength)
                                Stm.Write(SendingBuffer, 0, SendingBuffer.Length)
                                'Stm.Flush()

                                TotalSendBytes = TotalSendBytes + SendingBuffer.Length
                                kon = kon + 1
                                If kon = 50 Then
                                    RaiseEvent ProcessTransactionData(kon, TotalSendBytes)
                                    kon = 0
                                End If
                                'If (progressBar1.Value >= progressBar1.Maximum) Then

                                '    progressBar1.Value = progressBar1.Minimum

                                'End If

                                'progressBar1.PerformStep()
                            Next
                            fStream.Close()
                            RaiseEvent EndTransactionData(TotalSendBytes, TypeData.FileData)
                            RaiseEvent FileEnviado(fInfo.Name, TotalSendBytes)
                        Else

                        End If
                Else
                    RaiseEvent ErrorCliente("No está conectado!")

                End If
            Else
                RaiseEvent ErrorCliente("No está conectado!")

            End If

            Else
                RaiseEvent ErrorCliente("No se pudo comprimir los archivo(s)!")
            End If
        Catch ex As Exception

            RaiseEvent ErrorCliente("Operación Enviar File: " & ex.Message)
        Finally
            SetIsSocketBusy(False)
        End Try
    End Sub

    ''' <summary>
    ''' Envia archivos al servidor.
    ''' </summary>
    ''' <param name="PathFiles">Rutas de acceso local de los archivos.</param>
    ''' <remarks></remarks>
    Public Sub EnviarFile(ByVal PathFiles() As String)
        If Not _IsSocketBusy Then
            Dim _tcpThd As New Thread(AddressOf Thd_EnviarFile)
            Dim _SocketPrmt As New SocketParametersThread
            _SocketPrmt.PathFile = PathFiles
            SetIsSocketBusy(True)
            _tcpThd.Start(_SocketPrmt)
        Else
            RaiseEvent ErrorCliente("Espere que termine la transacción de datos!")
        End If

    End Sub

    Public Sub EnviarObjeto(ByVal Dato As Object)
        If Not _IsSocketBusy Then
            Dim _tcpThd As New Thread(AddressOf Thd_EnviarDato)
            Dim _SocketPrmt As New SocketParametersThread
            _SocketPrmt.BufferByte = DataStreamTools.Serialize(Dato)
            _SocketPrmt.ObjClass = Dato
            _SocketPrmt.TypeData = TypeData.ObjetoData
            SetIsSocketBusy(True)
            _tcpThd.Start(_SocketPrmt)
        Else
            RaiseEvent ErrorCliente("Espere que termine la transacción de datos!")
        End If
    End Sub

    Public Sub EnviarMensaje(ByVal Dato As String)
        If Not _IsSocketBusy Then
            Dim _tcpThd As New Thread(AddressOf Thd_EnviarDato)
            Dim _SocketPrmt As New SocketParametersThread
            _SocketPrmt.BufferByte = Encoding.ASCII.GetBytes(Dato)
            _SocketPrmt.Msg = Dato
            _SocketPrmt.TypeData = TypeData.StringData
            SetIsSocketBusy(True)
            _tcpThd.Start(_SocketPrmt)
        Else
            RaiseEvent ErrorCliente("Espere que termine la transacción de datos!")
        End If
    End Sub

#End Region

#Region "Otros"

    Private Sub ByteWrite(ByRef bufferWrite() As Byte, ByVal bufferRead() As Byte, ByVal start As Integer, ByVal length As Integer)
        Dim h As Integer = 0
        For k As Integer = start To (length + start) - 1
            bufferWrite(k) = bufferRead(h)
            h = h + 1
        Next
    End Sub

    Private Sub ByteRead(ByVal bufferRead() As Byte, ByRef bufferWrite() As Byte, ByVal start As Integer, ByVal length As Integer)
        Dim h As Integer = 0
        For k As Integer = start To (length + start) - 1
            bufferWrite(h) = bufferRead(k)
            h = h + 1
        Next
    End Sub

    Private Function PathFileAvailable() As String
        Dim PathFile As String
        VerifyDirectoryTemp()
        Dim Rnd As New Random
        Do
            PathFile = _PathDirectoryTemp & "\Package " & Rnd.Next(1000000, 9999999).ToString & ".zip"
        Loop While File.Exists(PathFile)
        Return PathFile
    End Function

    Private Sub VerifyDirectoryTemp()
        If Not Directory.Exists(_PathDirectoryTemp) Then
            If _PathDirectoryTemp Is Nothing Or _PathDirectoryTemp = "" Then
                _PathDirectoryTemp = System.Environment.CurrentDirectory & "\Temp"
                VerifyDirectoryTemp()
            Else
                Directory.CreateDirectory(_PathDirectoryTemp)
            End If
 
        End If
      
    End Sub

    Private Function ObtenerNamePC() As String
        Try
            Dim nombreHost As String = System.Net.Dns.GetHostName
            Return nombreHost
        Catch ex As Exception
            RaiseEvent ErrorCliente("Operación de Obtener Nambre PC: " & ex.Message)
            Return Nothing
        End Try

    End Function

    Private Function ObtenerMAC() As String
        Try
            Dim colNetAdapters, objWMIService As Object
            Dim strComputer As String

            strComputer = "."
            objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
            colNetAdapters = objWMIService.ExecQuery("Select * from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE")
            For Each objitem In colNetAdapters

                Return objitem.MACAddress

            Next
        Catch ex As Exception
            RaiseEvent ErrorCliente("Operación de Obtener MAC: " & ex.Message)
            Return Nothing
        End Try

        Return ""
    End Function

    Private Function GetFileToByte(ByVal pathFile As String) As Byte()
        Try
            ' Open a file that is to be loaded into a byte array
            Dim oFile As New System.IO.FileInfo(pathFile)
            Dim oFileStream As System.IO.FileStream = oFile.OpenRead()
            Dim lBytes As Long = oFileStream.Length

            If (lBytes > 0) Then
                Dim fileData(lBytes - 1) As Byte
                ' Read the file into a byte array
                oFileStream.Read(fileData, 0, lBytes)
                Return fileData
            End If
            oFileStream.Close()
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function SaveFile(ByVal Buffer() As Byte, ByVal pathFile As String) As Boolean
        Try


            ' Create a file and write the byte data to a file.
            Dim oFileStream As System.IO.FileStream
            oFileStream = New System.IO.FileStream(pathFile, System.IO.FileMode.Create)
            oFileStream.Write(Buffer, 0, Buffer.Length)
            oFileStream.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
        ''Variables que guardan la ruta donde se guardaran el origen y el destino de la ruta del archivo
        'Dim RutaOrigen As String = "C:\Juan.txt"
        'Dim RutaDestino As String = "D:\Viajes\NotasJuan.txt"

        'Try
        '    'Metodo que realiza la copia
        '    System.IO.File.Copy(RutaOrigen, RutaDestino, True)
        '    MsgBox("Archivo copiado correctamente", , "Copiar archivo")
        'Catch ex As Exception
        '    MsgBox(ex.Message, , "Error al copiar")
        'End Try

    End Function

#End Region

#End Region

End Class
