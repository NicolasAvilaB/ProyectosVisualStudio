Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports System.Runtime.Serialization
Imports Ionic.Zip

Public Class DataStreamTools

#Region "Serialize and Deserialize"

    Shared Function Serialize(ByVal obj As Object, ByVal Path As String) As Boolean

        Try
            Dim formatter As IFormatter = New BinaryFormatter 'formateador binario para realizar la serialización.
            ' Todo lo que necesita es crear una instancia de la secuencia y el formateador que desee utilizar, 
            Dim stream As Stream = New FileStream(Path, FileMode.Create, FileAccess.Write, FileShare.Read)
            'y a continuación, llamar al método Serialize en el formateador
            formatter.Serialize(stream, obj)
            stream.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Shared Function SerializeXml(ByVal obj As Object, ByVal path As String, ByVal type As Type) As Boolean
        'Try
        ' Insert code to set properties and fields of the object.
        Dim mySerializer As XmlSerializer = New XmlSerializer(type)
        ' To write to a file, create a StreamWriter object.
        Dim myWriter As StreamWriter = New StreamWriter(path)
        mySerializer.Serialize(myWriter, obj)
        myWriter.Close()
        Return True
        'Catch ex As Exception
        '    Return  false
        'End Try

    End Function
    Shared Function Serialize(ByVal obj As Object) As Byte()

        Dim bytes() As Byte
        Try
            Dim ms As New MemoryStream
            Dim bf1 As New BinaryFormatter
            'bf1.Serialize(ms, messageKind);
            bf1.Serialize(ms, obj)
            bytes = ms.ToArray()
            ms.Close()
            Return bytes
        Catch ex As Exception
            Return Nothing
        End Try


    End Function
    Shared Function Deserialize(ByVal Buffer() As Byte) As Object
        Try
            Dim ms As New MemoryStream(Buffer)
            ms.Position = 0
            Dim formatter As New BinaryFormatter
            Dim obj As Object = formatter.Deserialize(ms)
            ms.Close()
            Return obj
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Shared Function DeserializeXml(ByVal path As String, ByVal _ttype As Type) As Object
        Try

            ' Construct an instance of the XmlSerializer with the type
            ' of object that is being deserialized.
            Dim mySerializer As XmlSerializer = New XmlSerializer(_ttype)
            ' To read the file, create a FileStream.
            Dim myFileStream As FileStream = New FileStream(path, FileMode.Open)
            ' Call the Deserialize method and cast to the object type.

            Dim obj As Object = mySerializer.Deserialize(myFileStream)
            myFileStream.Close()
            Return obj
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Shared Function Deserialize(ByVal Path As String) As Object
        Try
            Dim obj As Object
            ' Open the file containing the data that you want to deserialize.
            Dim fs As New FileStream(Path, FileMode.Open)

            Dim formatter As New BinaryFormatter
            ' Deserialize the hashtable from the file and 
            ' assign the reference to the local variable.
            obj = formatter.Deserialize(fs)

            fs.Close()

            Return obj
        Catch e As SerializationException
            Return Nothing
        End Try
    End Function

#End Region

    Public Shared Function CompressFiles(ByVal PathFiles() As String, ByVal pathDestination As String) As Boolean
        Try
            Using zip As ZipFile = New ZipFile
                For Each pathFile As String In PathFiles
                    zip.AddFile(pathFile, "")
                Next
                zip.Save(pathDestination)

                Return True
            End Using
        Catch ex1 As Exception
            Return False
        End Try

    End Function
    Public Shared Function DecompressFiles(ByVal path As String, ByVal BaseDirectory As String) As Boolean
        Try
            Using zip As ZipFile = ZipFile.Read(path)
                Dim e As ZipEntry
                For Each e In zip
                    e.Extract(BaseDirectory)
                Next
                Return True
            End Using
        Catch ex1 As Exception
            Try
                Dim direc As New DirectoryInfo(BaseDirectory)
                For Each k As FileInfo In direc.GetFiles
                    File.Delete(k.FullName)
                Next
            Catch ex As Exception
            End Try

            Return False
        End Try
    End Function
End Class
