Imports System
Imports System.Threading
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Net


Public Class Servidor


    Public Sub New()

    End Sub

    Public Sub New(ByVal Puerto As Integer, ByVal IPServidor As String)
        _PuertoDeEscucha = Puerto
        _IPServidor = IPServidor
    End Sub
 
#Region "VARIABLES"
    Private tcpLsn As TcpListener 'Escucha las conexiones de clientes en puertos TCP
    Private _Clientes As New Hashtable() 'Aqui se guarda la informacion de todos los clientes conectados
    Private tcpThd As Thread 'Crea un subproceso a parte
    Private IDClienteActual As Net.IPEndPoint 'Ultimo cliente conectado
    Private _PuertoDeEscucha As Integer
    Private _IPServidor As String
    Private _IsConnected As Boolean
    Private _CountCliente As Integer = 0
    Private _PathDirectoryTemp As String
    Private Const BufferSize As Integer = 1024
    Private _IsSocketsAllBusy As Boolean

#End Region

#Region "EVENTOS"

    Public Event ObjetoRecibido(ByVal IPTerminal As String, ByVal obj As Object) 'Datos directos del cliente
    Public Event ObjetoEnviado(ByVal IPTerminal As String, ByVal obj As Object)
    Public Event ObjetosEnviados(ByVal obj As Object) 'Datos enviados a todos los clientes

    Public Event MensajesEnviados(ByVal msj As String) 'Datos enviados a todos los clientes
    Public Event MensajeEnviado(ByVal IPTerminal As String, ByVal msj As String) 'Dato enviado al cliente
    Public Event MensajeRecibido(ByVal IPTerminal As String, ByVal msj As String) 'Dato recibido

    Public Event FileEnviados(ByVal file As String, ByVal sizeByte As Integer) 'Datos enviados a todos los clientes
    Public Event FileEnviado(ByVal IPTerminal As String, ByVal Pathfile As String, ByVal recbSize As Integer) 'Dato enviado al cliente
    Public Event FileRecibido(ByVal IPTerminal As String, ByVal Pathfile As String, ByVal recbSize As Integer) 'Dato recibido


    Public Event ConexionTerminada(ByVal IPTerminal As String)
    Public Event ChangueCountConnection(ByVal count As Integer)
    Public Event ClienteBorrado(ByVal IPTerminal As String)
    Public Event ErrorServidor(ByVal ErrorMensaje As String)

    Public Event IniciarServidor()
    Public Event DetenerServidor()
    Public Event ReanudarServidor()
    Public Event PausearServidor()
    Public Event NuevaConexion(ByVal IPTerminal As String, ByVal Port As String)

    Public Event IsSocketsAllBusyChanged(ByVal _IsSocketBusy As Boolean)
    Public Event IsSocketClientBusyChanged(ByVal IDCliente As String, ByVal _IsSocketBusy As Boolean)
#End Region

#Region "PROPIEDADES"

    Public ReadOnly Property IsSocketsAllBusy() As Boolean
        Get
            Return _IsSocketsAllBusy
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

    Public Property Clientes() As Hashtable
        Get
            Return _Clientes
        End Get
        Set(ByVal value As Hashtable)
            _Clientes = value
        End Set
    End Property

    Public ReadOnly Property CountCliente() As Integer
        Get
            Return _CountCliente
        End Get
    End Property
    Public Property IPServidor() As String
        Get
            Return _IPServidor
        End Get
        Set(ByVal value As String)
            _IPServidor = value
        End Set
    End Property

    Property PuertoDeEscucha() As Integer
        Get
            Return _PuertoDeEscucha
        End Get
        Set(ByVal Value As Integer)
            _PuertoDeEscucha = Value
        End Set
    End Property


    Public ReadOnly Property IsConnected() As Boolean
        Get
            Return _IsConnected
        End Get

    End Property

#End Region

#Region "METODOS"

#Region "Set Raise Event Property"

    Private Sub SetIsSocketsAllBusy(ByVal value As Boolean)
        _IsSocketsAllBusy = value
        RaiseEvent IsSocketsAllBusyChanged(value)
    End Sub

 

#End Region

#Region "Gestion del Servidor"

    Public Function Begin() As Boolean
        Return Begin(_IPServidor)
    End Function

    Public Function Begin(ByVal ipServidor As String) As Boolean
        Dim result As Boolean = Escuchar(GenerarIP(ipServidor))
        _IsConnected = result
        _CountCliente = 0
        RaiseEvent ChangueCountConnection(_CountCliente)
        If result Then
            RaiseEvent IniciarServidor()
        End If
        Return result
    End Function

    Public Function Stopping() As Boolean

        Try

            If _IsConnected Then

                CloseConnections()
                CloseThreads() 'Cierra los subProcesos q se encargaban de escuchar al cliente
                DeleteClients()

                If Not tcpThd Is Nothing Then
                    tcpThd.Abort()
                End If
                If Not tcpLsn Is Nothing Then
                    tcpLsn.Stop()
                End If
                _IsConnected = False
                RaiseEvent DetenerServidor()
            End If

            Return True
        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Stopping: " + ex.Message)
            Return False
        End Try


    End Function

    Public Function Pausing() As Boolean
        Try

            'CerrarConexiones()
            'CerrarThread() 'Cierra los subProcesos q se encargaban de escuchar al cliente
            tcpThd.Abort()
            tcpLsn.Stop()
            RaiseEvent PausearServidor()

            Return True
        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Pausing: " + ex.Message)
            Return False
        End Try


    End Function

    Public Function Resuming() As Boolean
        Try
            tcpLsn.Start() 'Inicia la escucha
            'Creo un thread para que se quede escuchando la llegada de un cliente
            tcpThd = New Thread(AddressOf EsperarCliente) 'Asignamos el metodo EsperarCliente, q se crea al momento de crear el hilo
            tcpThd.Start() 'Comienza el el proceso EsperarCliente
            'AbrirConexion()

            RaiseEvent ReanudarServidor()
            Return True
        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Resuming: " + ex.Message)
            Return False
        End Try


    End Function

    Private Function Escuchar(ByVal ip() As Byte) As Boolean
        Try
            'Se limpia la tabla si en caso ubiera clientes guardados

            tcpLsn = New TcpListener(New System.Net.IPAddress(ip), _PuertoDeEscucha)
            'Inicio la escucha
            tcpLsn.Start()
            'Creo un thread para que se quede escuchando la llegada de un cliente
            tcpThd = New Thread(AddressOf EsperarCliente) 'Asignamos el metodo EsperarCliente, q se crea al momento de crear el hilo
            tcpThd.Start() 'Comienza el el proceso EsperarCliente
            Return True


        Catch exSok As SocketException
            RaiseEvent ErrorServidor("Operación de Escuchar Socket: " + exSok.Message)
            Return False
        Catch exp As Exception
            RaiseEvent ErrorServidor("Operación de Escuchar Socket: " + exp.Message)
            Return False
        End Try

    End Function

    Private Sub EsperarCliente()

        Dim InfoClienteActual As New InfoDeUnCliente
        With InfoClienteActual
            While True
                'Cuando se recibe la conexion, guardo la informacion del cliente

                'Guardo el Socket que utilizo para mantener la conexion con el cliente
                .Socket = tcpLsn.AcceptSocket 'Se queda esperando la conexion de un cliente
                'Guardo el el RemoteEndPoint, que utilizo para identificar al cliente
                IDClienteActual = .Socket.RemoteEndPoint


                'Agrego la informacion del cliente al HashArray Clientes, donde esta la
                'informacion de todos estos
                SyncLock Me 'esta palabra reservada garantiza q varios subProceso no ejecuten esta instruccion.

                    If IsNothing(_Clientes(IDClienteActual.Address.ToString)) Then
                        .RemoteEndPoint = IDClienteActual

                    Else
                        .Socket.Shutdown(SocketShutdown.Both)
                        .Socket.Close()

                    End If


                End SyncLock

                If .Socket.Connected Then

                    'Creo un Thread para que se encargue de escuchar los mensaje del cliente
                    .Thread = New Thread(AddressOf ReadSocket)
                    _Clientes.Add(IDClienteActual.Address.ToString, InfoClienteActual)
                    'Inicio el thread encargado de escuchar los mensajes del cliente
                    .Thread.Start()
                    'Genero el evento Nueva conexion
                    _CountCliente = _CountCliente + 1
                    RaiseEvent ChangueCountConnection(_CountCliente)
                    RaiseEvent NuevaConexion(IDClienteActual.Address.ToString, IDClienteActual.Port.ToString)
                End If


            End While
        End With
    End Sub

    Private Sub ReadSocket()
        'Dim IDReal As Net.IPEndPoint 'ID del cliente que se va a escuchar
        Dim InfoClienteActual As InfoDeUnCliente 'Informacion del cliente que se va escuchar
        Dim IPClient As String = IDClienteActual.Address.ToString  'como este proceso se ejecuta en relacion aun hilo, la variable IDCLienteActual tendra el valor del ultimo cliente asignado justo antes de iniciar este proceso.
        InfoClienteActual = _Clientes(IPClient)
        ReadSocket(InfoClienteActual, IPClient)

    End Sub

    Private Sub ReadSocket(ByVal InfoClienteActual As InfoDeUnCliente, ByVal IPClient As String)
        ' InfoClienteActual =Informacion del cliente que se va escuchar
        Dim Recibir() As Byte 'Array utilizado para recibir los datos que llegan
        Dim Ret As Integer = 0
        Dim TipeData(3) As Byte
        Dim longitudByte(3) As Byte
        Dim lengitudInt As Integer
        'Dim NoOfPackets As Integer = 0
        Dim totalrecbytes As Integer = 0
        Dim Fs As FileStream

        With InfoClienteActual
            While True
                If .Socket.Connected Then
                    Try
                        ''Me quedo esperando a que llegue un mensaje desde el cliente
                        Ret = .Socket.Receive(TipeData, TipeData.Length, SocketFlags.None)
                        If Ret > 0 Then
                            ''Me quedo esperando a que llegue un mensaje desde el cliente
                            Ret = .Socket.Receive(longitudByte, longitudByte.Length, SocketFlags.None)
                            If Ret > 0 Then

                                lengitudInt = BitConverter.ToInt32(longitudByte, 0)
                                'NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lengitudInt) / Convert.ToDouble(BufferSize)))
                                totalrecbytes = 0
                                If lengitudInt > BufferSize Then
                                    Recibir = New Byte(BufferSize - 1) {}
                                Else
                                    Recibir = New Byte(lengitudInt - 1) {}
                                End If
                                Select Case BitConverter.ToInt32(TipeData, 0)
                                    Case TypeData.FileData
                                        Dim rnd As New Random
                                        Dim PathFile As String = PathFileAvailable()

                                        Fs = New FileStream(PathFile, FileMode.OpenOrCreate, FileAccess.Write)
                                        Do
                                            Ret = .Socket.Receive(Recibir, Recibir.Length, SocketFlags.None)
                                            Fs.Write(Recibir, 0, Ret)
                                            totalrecbytes += Ret

                                        Loop While (Ret > 0 And totalrecbytes < lengitudInt)

                                        Fs.Close()
                                        .UltimosDatosRecibidos = PathFile
                                        RaiseEvent FileRecibido(IPClient, .UltimosDatosRecibidos, totalrecbytes)

                                    Case TypeData.ObjetoData
                                        Dim bufferData(lengitudInt - 1) As Byte
                                        Do
                                            Ret = .Socket.Receive(Recibir, Recibir.Length, SocketFlags.None)
                                            ByteWrite(bufferData, Recibir, totalrecbytes, Ret)
                                            totalrecbytes += Ret
                                        Loop While (Ret > 0 And totalrecbytes < lengitudInt)

                                        .UltimosDatosRecibidos = DataStreamTools.Deserialize(bufferData)
                                        RaiseEvent ObjetoRecibido(IPClient, .UltimosDatosRecibidos)
                                    Case TypeData.StringData
                                        Dim bufferData(lengitudInt - 1) As Byte
                                        Do
                                            Ret = .Socket.Receive(Recibir, Recibir.Length, SocketFlags.None)
                                            ByteWrite(bufferData, Recibir, totalrecbytes, Ret)
                                            totalrecbytes += Ret
                                        Loop While (Ret > 0 And totalrecbytes < lengitudInt)
                                        .UltimosDatosRecibidos = Encoding.ASCII.GetString(bufferData, 0, bufferData.Length)
                                        RaiseEvent MensajeRecibido(IPClient, .UltimosDatosRecibidos)
                                End Select
                                _Clientes(IPClient) = InfoClienteActual

                            Else
                                Exit While
                            End If
                        Else
                            Exit While
                        End If
                    Catch exSokect As ThreadAbortException
                        RaiseEvent ErrorServidor("Socket: " + exSokect.Message & " " & InfoClienteActual.RemoteEndPoint.ToString)
                        If Not .Socket.Connected Then
                            Exit While
                        End If
                    Catch e As Exception
                        RaiseEvent ErrorServidor("Operación de Leer Socket: " + e.Message & " " & InfoClienteActual.RemoteEndPoint.ToString)
                        If Not .Socket.Connected Then
                            Exit While
                        End If
                    End Try
                Else
                    Exit While
                End If
            End While
            'Genero el evento de la finalizacion de la conexion
            DeleteClient(IPClient)
            _CountCliente = _CountCliente - 1
            RaiseEvent ChangueCountConnection(_CountCliente)
            RaiseEvent ConexionTerminada(IPClient)

            Call CloseThread(IPClient)
        End With
    End Sub

    Private Sub CloseThread(ByVal IPCliente As String)

        Dim InfoClienteActual As InfoDeUnCliente
        'Cierro el thread que se encargaba de escuchar al cliente especificado
        InfoClienteActual = _Clientes(IPCliente)
        Try
            InfoClienteActual.Thread.Abort()

        Catch e As Exception
            SyncLock Me
                'Elimino el cliente del HashArray que guarda la informacion de los clientes
                'Clientes.Remove(IDCliente.Address)
            End SyncLock
            'MsgBox("Codigo:20 " + e.Message)
        End Try
    End Sub

    Private Sub CloseThreads()


        Dim InfoClienteActual As InfoDeUnCliente
        Try
            'Cierro el thread que se encargaba de escuchar al cliente especificado
            'Recorro todos los clientes y voy cerrando las conexiones
            For Each InfoClienteActual In _Clientes.Values
                'Call CloseThread(InfoClienteActual.RemoteEndPoint.Address.ToString)
                InfoClienteActual.Thread.Abort()
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CloseConnection(ByVal IPCliente As String)
        Dim InfoClienteActual As InfoDeUnCliente
        'Obtengo la informacion del cliente solicitado
        InfoClienteActual = _Clientes(IPCliente)
        'Cierro la conexion con el cliente

        InfoClienteActual.Socket.Shutdown(SocketShutdown.Both)
        InfoClienteActual.Socket.Close()

    End Sub

    Private Sub CloseConnections()
        Dim InfoClienteActual As InfoDeUnCliente
        'Recorro todos los clientes y voy cerrando las conexiones
        For Each InfoClienteActual In _Clientes.Values
            'Call CloseConnection(InfoClienteActual.RemoteEndPoint)
            InfoClienteActual.Socket.Shutdown(SocketShutdown.Both)
            InfoClienteActual.Socket.Close()
        Next
    End Sub

    Public Sub DeleteClient(ByVal IPCliente As String)

        Try
            SyncLock Me
                'Elimino el cliente del HashArray que guarda la informacion de los clientes
                _Clientes.Remove(IPCliente)

            End SyncLock
            RaiseEvent ClienteBorrado(IPCliente)
        Catch e As Exception
            RaiseEvent ErrorServidor("Operación Delete Client: " + e.Message & " " & IPCliente)
        End Try
    End Sub

    Public Sub DeleteClients()
        'Dim InfoClienteActual As InfoDeUnCliente
        'Recorro todos los clientes y voy cerrando las conexiones
        Try
            'For Each InfoClienteActual In Clientes.Values
            '    Call BorrarCiente(InfoClienteActual.Socket.RemoteEndPoint)
            'Next
            If Not _Clientes Is Nothing Then
                _Clientes.Clear()
            End If

        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Delete Clients: " + ex.Message)
        End Try

    End Sub

#End Region

#Region "Envio y recepcion de datos"

    Public Sub EnviarMensaje(ByVal IPCliente As String, ByVal Datos As String)
        Try
            If Not _IsSocketsAllBusy Then

                Dim _SocketPrmt As New SocketParametersThread


                Dim cliente As InfoDeUnCliente = _Clientes(IPCliente)
                If Not cliente.IsSocketBusy Then

                    Dim _tcpThd As New Thread(AddressOf Thd_EnviarDato)

                    _SocketPrmt.BufferByte = Encoding.ASCII.GetBytes(Datos)
                    _SocketPrmt.Msg = Datos
                    _SocketPrmt.IDCliente = IPCliente
                    _SocketPrmt.TypeData = TypeData.StringData
                    cliente.IsSocketBusy = True
                    _SocketPrmt.Cliente = cliente
                    RaiseEvent IsSocketClientBusyChanged(IPCliente, cliente.IsSocketBusy)
                    _tcpThd.Start(_SocketPrmt)

                Else
                    RaiseEvent ErrorServidor("Espere que termine la transacción de datos: " & IPCliente)
                End If
            Else
                RaiseEvent ErrorServidor("Espere que termine la transacción de datos!")
            End If
        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Enviar Mensaje: " & ex.Message & ", " & IPCliente)
        End Try


    End Sub

    Public Sub EnviarMensajes(ByVal Datos As String)
        If Not _IsSocketsAllBusy Then
            Dim _tcpThd As New Thread(AddressOf Thd_EnviarDatos)
            Dim _SocketPrmt As New SocketParametersThread
            _SocketPrmt.BufferByte = Encoding.ASCII.GetBytes(Datos)
            _SocketPrmt.Msg = Datos
            _SocketPrmt.TypeData = TypeData.StringData
            SetIsSocketsAllBusy(True)
            _tcpThd.Start(_SocketPrmt)
        Else
            RaiseEvent ErrorServidor("Espere que termine la transacción de datos!")
        End If
    End Sub

    Public Sub EnviarObjeto(ByVal IPCliente As String, ByVal Dato As Object)

        Try
            If Not _IsSocketsAllBusy Then
                Dim _SocketPrmt As New SocketParametersThread
                Dim cliente As InfoDeUnCliente = _Clientes(IPCliente)
                If Not cliente Is Nothing Then
                    If Not cliente.IsSocketBusy Then
                        Dim _tcpThd As New Thread(AddressOf Thd_EnviarDato)

                        _SocketPrmt.BufferByte = DataStreamTools.Serialize(Dato)
                        _SocketPrmt.ObjClass = Dato
                        _SocketPrmt.IDCliente = IPCliente
                        _SocketPrmt.TypeData = TypeData.ObjetoData
                        cliente.IsSocketBusy = True
                        _SocketPrmt.Cliente = cliente
                        RaiseEvent IsSocketClientBusyChanged(IPCliente, cliente.IsSocketBusy)
                        _tcpThd.Start(_SocketPrmt)

                    Else
                        RaiseEvent ErrorServidor("Espere que termine la transacción de datos: " & IPCliente)
                    End If
                Else
                    RaiseEvent ErrorServidor("No se encontro el cliente! " & IPCliente)

                End If
            Else
                RaiseEvent ErrorServidor("Espere que termine la transacción de datos!")
            End If

        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Enviar Objeto: " & ex.Message & ", " & IPCliente)
        End Try

    End Sub

    Public Sub EnviarObjetos(ByVal Dato As Object)
        If Not _IsSocketsAllBusy Then
            Dim _tcpThd As New Thread(AddressOf Thd_EnviarDatos)
            Dim _SocketPrmt As New SocketParametersThread
            _SocketPrmt.BufferByte = DataStreamTools.Serialize(Dato)
            _SocketPrmt.ObjClass = Dato
            _SocketPrmt.TypeData = TypeData.ObjetoData
            SetIsSocketsAllBusy(True)
            _tcpThd.Start(_SocketPrmt)
        Else
            RaiseEvent ErrorServidor("Espere que termine la transacción de datos!")
        End If
    End Sub

    Public Sub Thd_EnviarFile(ByVal _obj As Object)

        Dim _SocketPrmt As SocketParametersThread = CType(_obj, SocketParametersThread)
        'Obtengo la informacion del cliente al que se le quiere enviar el mensaje
        Dim Cliente As InfoDeUnCliente = _SocketPrmt.Cliente
        Dim IPCliente As String = _SocketPrmt.IDCliente
        Try


            Dim PathFile As String = PathFileAvailable()

            If DataStreamTools.CompressFiles(_SocketPrmt.PathFile, PathFile) Then

                Dim fInfo As New FileInfo(PathFile)
                Dim fStream As New FileStream(PathFile, FileMode.Open, FileAccess.Read)
                Dim TypeData As TypeData = TypeData.FileData

                Dim NoOfPackets As Integer
                Dim SendingBuffer() As Byte
                Dim TotalSendBytes As Integer = 0


                Dim TypeDataByte() As Byte = BitConverter.GetBytes(TypeData)

                If Not Cliente.Socket Is Nothing Then
                    If Cliente.Socket.Connected Then

                        Dim TotalLength As Integer = fStream.Length
                        Dim CurrentPacketLength As Integer
                        '    'Obtenemos la longitud en bytes del fichero leido
                        Dim longitud() As Byte = BitConverter.GetBytes(TotalLength)
                        ''Pasamos el tipo de dato
                        Cliente.Socket.Send(TypeDataByte, TypeDataByte.Length, SocketFlags.None)

                        ''Pasamos la cantidad de bytes del fichero
                        Cliente.Socket.Send(longitud, longitud.Length, SocketFlags.None)

                        NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalLength) / Convert.ToDouble(BufferSize)))

                        'progressBar1.Maximum = NoOfPackets

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
                            Cliente.Socket.Send(SendingBuffer, SendingBuffer.Length, SocketFlags.None)

                            TotalSendBytes = TotalSendBytes + SendingBuffer.Length
                            'If (progressBar1.Value >= progressBar1.Maximum) Then

                            '    progressBar1.Value = progressBar1.Minimum

                            'End If

                            'progressBar1.PerformStep()
                        Next
                        fStream.Close()
                        RaiseEvent FileEnviado(IPCliente, fInfo.Name, TotalSendBytes)

                    Else
                        RaiseEvent ErrorServidor("Cliente no conectado: " & IPCliente)

                    End If
                Else
                    RaiseEvent ErrorServidor("Cliente no encontrado: " & IPCliente)

                End If
            Else
                RaiseEvent ErrorServidor("No se pudo comprimir los archivo(s)!: " & IPCliente)
            End If

        Catch ex As Exception
            RaiseEvent ErrorServidor("Operacion Enviar Fileo: " & ex.Message)
        Finally
            Cliente.IsSocketBusy = False
            RaiseEvent IsSocketClientBusyChanged(IPCliente, Cliente.IsSocketBusy)
        End Try




    End Sub

    Public Sub Thd_EnviarFiles(ByVal _obj As Object)
        Try
            Dim _SocketPrmt As SocketParametersThread = CType(_obj, SocketParametersThread)

            Dim PathFile As String = PathFileAvailable()

            If DataStreamTools.CompressFiles(_SocketPrmt.PathFile, PathFile) Then

                Dim fInfo As New FileInfo(PathFile)
                Dim fStream As New FileStream(PathFile, FileMode.Open, FileAccess.Read)


                Dim Cliente As InfoDeUnCliente
                Dim TypeData As TypeData = TypeData.FileData
                Dim TypeDataByte() As Byte = BitConverter.GetBytes(TypeData)


                Dim SendingBuffer() As Byte
                Dim TotalSendBytes As Integer
                Dim CurrentPacketLength As Integer
                Dim TotalLength As Integer = fStream.Length
                Dim longitud() As Byte = BitConverter.GetBytes(TotalLength)
                Dim NoOfPackets As Integer = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalLength) / Convert.ToDouble(BufferSize)))

                For Each Cliente In _Clientes.Values
                    If Not Cliente.Socket Is Nothing Then
                        If Cliente.Socket.Connected Then
                            '    'Obtenemos la longitud en bytes del fichero leido
                            TotalLength = fStream.Length
                            TotalSendBytes = 0
                            ''Pasamos el tipo de dato
                            Cliente.Socket.Send(TypeDataByte, TypeDataByte.Length, SocketFlags.None)

                            ''Pasamos la cantidad de bytes del fichero
                            Cliente.Socket.Send(longitud, longitud.Length, SocketFlags.None)

                            'progressBar1.Maximum = NoOfPackets

                            For i As Integer = 1 To NoOfPackets

                                If (TotalLength > BufferSize) Then

                                    CurrentPacketLength = BufferSize
                                    TotalLength = TotalLength - CurrentPacketLength

                                Else
                                    CurrentPacketLength = TotalLength
                                End If
                                SendingBuffer = New Byte(CurrentPacketLength - 1) {}

                                'Fs.Read(SendingBuffer, 0, CurrentPacketLength)
                                fStream.Read(SendingBuffer, 0, CurrentPacketLength)
                                'ByteRead(BufferDeEscritura, SendingBuffer, TotalSendBytes, SendingBuffer.Length)
                                Cliente.Socket.Send(SendingBuffer, SendingBuffer.Length, SocketFlags.None)

                                TotalSendBytes = TotalSendBytes + SendingBuffer.Length
                                'If (progressBar1.Value >= progressBar1.Maximum) Then

                                '    progressBar1.Value = progressBar1.Minimum

                                'End If

                                'progressBar1.PerformStep()
                            Next
                            fStream.Position = 0

                        End If

                    End If
                Next
                fStream.Close()
                RaiseEvent FileEnviados(fInfo.Name, TotalSendBytes)
            Else
                RaiseEvent ErrorServidor("No se pudo comprimir los archivo(s)!")
            End If
        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Enviar Dato: " & ex.Message)
        Finally
            SetIsSocketsAllBusy(False)
        End Try

    End Sub

    Public Sub EnviarFiles(ByVal PathFile() As String)
        If Not _IsSocketsAllBusy Then

            Dim _tcpThd As New Thread(AddressOf Thd_EnviarFiles)
            Dim _SocketPrmt As New SocketParametersThread
            _SocketPrmt.PathFile = PathFile
            SetIsSocketsAllBusy(True)
            _tcpThd.Start(_SocketPrmt)
        Else
            RaiseEvent ErrorServidor("Espere que termine la transacción de datos!")
        End If
    End Sub

    Public Sub EnviarFile(ByVal IPCliente As String, ByVal PathFile() As String, ByVal isThread As Boolean)

        Try
            If Not _IsSocketsAllBusy Then
                Dim _SocketPrmt As New SocketParametersThread
                Dim cliente As InfoDeUnCliente = _Clientes(IPCliente)

                If Not cliente.IsSocketBusy Then
                    _SocketPrmt.IDCliente = IPCliente
                    _SocketPrmt.PathFile = PathFile
                    cliente.IsSocketBusy = True
                    _SocketPrmt.Cliente = cliente
                    RaiseEvent IsSocketClientBusyChanged(IPCliente, cliente.IsSocketBusy)

                    If isThread Then
                        Dim _tcpThd As New Thread(AddressOf Thd_EnviarFile)
                        _tcpThd.Start(_SocketPrmt)
                    Else
                        Thd_EnviarFile(_SocketPrmt)
                    End If
                Else
                    RaiseEvent ErrorServidor("Espere que termine la transacción de datos: " & IPCliente)
                End If
            Else
                RaiseEvent ErrorServidor("Espere que termine la transacción de datos!")
            End If
        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Enviar File: " & ex.Message & ", " & IPCliente)
        End Try
    End Sub

    Private Sub Thd_EnviarDato(ByVal _obj As Object)
        Dim _SocketPrmt As SocketParametersThread = CType(_obj, SocketParametersThread)
        Dim Cliente As InfoDeUnCliente = _SocketPrmt.Cliente
        Dim BufferDeEscritura() As Byte = _SocketPrmt.BufferByte
        Dim typeData As TypeData = _SocketPrmt.TypeData
        Dim IPCliente As String = _SocketPrmt.IDCliente
        Try


            'Obtengo la informacion del cliente al que se le quiere enviar el mensaje


            Dim NoOfPackets As Integer
            Dim SendingBuffer() As Byte
            Dim TotalSendBytes As Integer = 0


            Dim TypeDataByte() As Byte = BitConverter.GetBytes(typeData)

            If Not Cliente.Socket Is Nothing Then
                If Cliente.Socket.Connected Then

                    Dim TotalLength As Integer = BufferDeEscritura.Length
                    Dim CurrentPacketLength As Integer
                    '    'Obtenemos la longitud en bytes del fichero leido
                    Dim longitud() As Byte = BitConverter.GetBytes(TotalLength)
                    ''Pasamos el tipo de dato
                    Cliente.Socket.Send(TypeDataByte, TypeDataByte.Length, SocketFlags.None)

                    ''Pasamos la cantidad de bytes del fichero
                    Cliente.Socket.Send(longitud, longitud.Length, SocketFlags.None)

                    NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalLength) / Convert.ToDouble(BufferSize)))

                    'progressBar1.Maximum = NoOfPackets

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

                        Cliente.Socket.Send(SendingBuffer, SendingBuffer.Length, SocketFlags.None)

                        TotalSendBytes = TotalSendBytes + SendingBuffer.Length
                        'If (progressBar1.Value >= progressBar1.Maximum) Then

                        '    progressBar1.Value = progressBar1.Minimum

                        'End If

                        'progressBar1.PerformStep()
                    Next

                    If typeData = typeData.StringData Then
                        RaiseEvent MensajeEnviado(_SocketPrmt.IDCliente, _SocketPrmt.Msg)
                    ElseIf typeData = typeData.ObjetoData Then
                        RaiseEvent ObjetoEnviado(_SocketPrmt.IDCliente, _SocketPrmt.ObjClass)
                    End If
                Else
                    RaiseEvent ErrorServidor("Cliente no conectado: " & IPCliente)

                End If
            Else
                RaiseEvent ErrorServidor("Cliente no encontrado: " & IPCliente)

            End If

        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Enviar Dato: " & ex.Message)
        Finally
            Cliente.IsSocketBusy = False
            RaiseEvent IsSocketClientBusyChanged(IPCliente, Cliente.IsSocketBusy)
        End Try
    End Sub

    Private Sub Thd_EnviarDatos(ByVal _obj As Object)
        Try
            Dim _SocketPrmt As SocketParametersThread = CType(_obj, SocketParametersThread)
            Dim BufferDeEscritura() As Byte = _SocketPrmt.BufferByte
            Dim typeData As TypeData = _SocketPrmt.TypeData

            Dim Cliente As InfoDeUnCliente
            Dim TypeDataByte() As Byte = BitConverter.GetBytes(typeData)
            Dim longitud() As Byte = BitConverter.GetBytes(BufferDeEscritura.Length)

            Dim SendingBuffer() As Byte
            Dim TotalSendBytes As Integer
            Dim CurrentPacketLength As Integer
            Dim TotalLength As Integer = BufferDeEscritura.Length

            Dim NoOfPackets As Integer = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalLength) / Convert.ToDouble(BufferSize)))

            For Each Cliente In _Clientes.Values
                If Not Cliente.Socket Is Nothing Then
                    If Cliente.Socket.Connected Then
                        '    'Obtenemos la longitud en bytes del fichero leido
                        TotalLength = BufferDeEscritura.Length
                        TotalSendBytes = 0
                        ''Pasamos el tipo de dato
                        Cliente.Socket.Send(TypeDataByte, TypeDataByte.Length, SocketFlags.None)

                        ''Pasamos la cantidad de bytes del fichero
                        Cliente.Socket.Send(longitud, longitud.Length, SocketFlags.None)

                        'progressBar1.Maximum = NoOfPackets

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

                            Cliente.Socket.Send(SendingBuffer, SendingBuffer.Length, SocketFlags.None)

                            TotalSendBytes = TotalSendBytes + SendingBuffer.Length
                            'If (progressBar1.Value >= progressBar1.Maximum) Then

                            '    progressBar1.Value = progressBar1.Minimum

                            'End If

                            'progressBar1.PerformStep()
                        Next

                    End If
                End If
            Next

            If typeData = typeData.StringData Then
                RaiseEvent MensajesEnviados(_SocketPrmt.Msg)
            ElseIf typeData = typeData.ObjetoData Then
                RaiseEvent ObjetosEnviados(_SocketPrmt.ObjClass)
            End If

        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Enviar Dato: " & ex.Message)
        Finally
            SetIsSocketsAllBusy(False)
        End Try
    End Sub

#End Region

#Region "Otros"

    Private Function GenerarIP(ByVal _ip As String) As Byte()
        Try
            Dim ip(3) As Byte
            Dim cadena As String = _ip
            Dim length As Integer = 0
            For k = 0 To ip.Length - 1
                If k <> 3 Then
                    length = cadena.IndexOf(".")
                    ip(k) = CByte(cadena.Substring(0, length))
                    cadena = cadena.Remove(0, length + 1)
                Else
                    ip(k) = CByte(cadena)

                End If

            Next
            Return ip
        Catch ex As Exception
            RaiseEvent ErrorServidor("Operación Generar IP: " + ex.Message)
            Return Nothing
        End Try

    End Function

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

    Public Function ObtenerUltimoDato(ByVal IPCliente As String) As Object
        Dim InfoClienteSolicitado As InfoDeUnCliente
        'Obtengo la informacion del cliente solicitado
        InfoClienteSolicitado = _Clientes(IPCliente)
        'RaiseEvent UltimoDatoObtenido(IPCliente, InfoClienteSolicitado.UltimosDatosRecibidos)
        Return InfoClienteSolicitado.UltimosDatosRecibidos
    End Function

#End Region

#End Region

End Class
