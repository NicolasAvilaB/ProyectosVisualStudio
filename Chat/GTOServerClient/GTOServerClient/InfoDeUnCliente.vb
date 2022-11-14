Imports System.Net

Friend Class InfoDeUnCliente
    'Esta estructura permite guardar la información sobre un cliente
    Friend Socket As Net.Sockets.Socket 'Socket utilizado para mantener la conexion con el cliente
    Friend Thread As Threading.Thread 'Thread utilizado para escuchar al cliente
    Friend UltimosDatosRecibidos As Object 'Ultimos datos enviados por el cliente
    Friend RemoteEndPoint As IPEndPoint
    Friend IsSocketBusy As Boolean
End Class
