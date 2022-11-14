Friend Class SocketParametersThread

    Private _Msg As String
    Friend Property Msg() As String
        Get
            Return _Msg
        End Get
        Set(ByVal value As String)
            _Msg = value
        End Set
    End Property

    Private _PathFile() As String
    Friend Property PathFile() As String()
        Get
            Return _PathFile
        End Get
        Set(ByVal value() As String)
            _PathFile = value
        End Set
    End Property


    Private _TypeData As TypeData
    Friend Property TypeData() As TypeData
        Get
            Return _TypeData
        End Get
        Set(ByVal value As TypeData)
            _TypeData = value
        End Set
    End Property

    Private _BufferByte() As Byte
    Friend Property BufferByte As Byte()
        Get
            Return _BufferByte
        End Get
        Set(ByVal value() As Byte)
            _BufferByte = value
        End Set
    End Property


    Private _ObjClass As Object
    Friend Property ObjClass() As Object
        Get
            Return _ObjClass
        End Get
        Set(ByVal value As Object)
            _ObjClass = value
        End Set
    End Property


    Private _IDCliente As String
    Friend Property IDCliente() As String
        Get
            Return _IDCliente
        End Get
        Set(ByVal value As String)
            _IDCliente = value
        End Set
    End Property


    Private _Cliente As InfoDeUnCliente
    Friend Property Cliente() As InfoDeUnCliente
        Get
            Return _Cliente
        End Get
        Set(ByVal value As InfoDeUnCliente)
            _Cliente = value
        End Set
    End Property


End Class
