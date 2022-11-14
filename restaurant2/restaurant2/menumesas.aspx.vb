Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq
Public Class menumesas
    Inherits System.Web.UI.Page
    Protected WithEvents botones As System.Web.UI.WebControls.Button
    Protected menumesas As System.Web.UI.HtmlControls.HtmlForm
    Dim estado As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer
        Dim x As Integer
        Dim y As Integer
        x = 190
        y = 24
        Actualizacion_Tabla()
        For i = 1 To dt.Rows.Count
            botones = New System.Web.UI.WebControls.Button
            botones.Text = "MESA " & i
            botones.Height = 37
            y += 43
            If y >= 283 Then
                y = 24
                x += 100
            End If
            botones.ID = "botones" & i
            botones.BackColor = Drawing.Color.White
            botones.ForeColor = Drawing.Color.Black
            Panel1.Controls.Add(botones)
            AddHandler botones.Click, AddressOf boton1_Click
            mesas_dispo_ocup()
        Next
    End Sub
    Sub Actualizacion_Tabla()
        Try
            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=marioluigi;Uid=root;pwd=root;"
            Dim sql As String
            sql = "Call GeneracionBotones"
            Dim comando As New MySqlCommand(sql, conexion)
            da = New MySqlDataAdapter(sql, conexion)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception
            Page_Load(True, Nothing)
        End Try
    End Sub
    Private Sub boton1_Click(sender As Object, e As EventArgs)
        mesaseleccionada = sender.text
        Response.Redirect("Transacciones.aspx")
    End Sub
    Sub mesas_dispo_ocup()
        Try
            'Crear la Conexion
            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=marioluigi;Uid=root;pwd=root;"
            'Crear SQL
            Dim sql As String
            sql = "Call CambiarColor ('" & (botones.Text) & "')"
            Dim comando As New MySqlCommand(sql, conexion)
            da = New MySqlDataAdapter(sql, conexion)
            da.Fill(dt)
            Dim count As Integer = Convert.ToInt64(comando.ExecuteScalar())
            If count > 0 Then
                Dim DataReader As MySqlDataReader
                conexion.Open()
                DataReader = comando.ExecuteReader()
                estado = DataReader("Estado")
            End If
            If estado = "Disponible" Then
                botones.BackColor = Drawing.Color.White
                botones.ForeColor = Drawing.Color.Black
            End If
            If estado = "Ocupado" Then
                botones.BackColor = Drawing.Color.DarkRed
                botones.ForeColor = Drawing.Color.White
            End If
        Catch ex As Exception
            'Page_Load(True, Nothing)
        End Try
    End Sub
End Class