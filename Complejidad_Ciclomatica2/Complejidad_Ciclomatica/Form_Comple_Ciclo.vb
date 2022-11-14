Imports System.Drawing.Drawing2D
Public Class Form_Comple_Ciclo
    Sub Codigo_CSharp()
        Dim arreglo() As String
        Dim largo As String
        Dim cod_fuente As String
        Dim matriz_cod() As String
        Dim i As Long
        Dim num As Integer = 1
        Dim cantidad_lineas As Integer
        Dim nodos_p As Integer = 0
        Dim aristas As Integer = 0
        cod_fuente = txt_cod.Text
        arreglo = Split(cod_fuente, vbCrLf)
        cantidad_lineas = arreglo.Length
        largo = String.Join(" ", arreglo)
        matriz_cod = Split(largo, " ")

        For i0 = LBound(arreglo) To UBound(arreglo)
            If arreglo(i0) = "" Then
                cantidad_lineas -= 1
            End If
        Next

        For i = LBound(matriz_cod) To UBound(matriz_cod)
            If matriz_cod(i) = "if" Or matriz_cod(i) = "Then" Or matriz_cod(i) = "While" Or matriz_cod(i) = "For" Or matriz_cod(i) = "foreach" Then
                num += 1
                nodos_p += 1
                aristas += 1
            End If
            If matriz_cod(i) = "else" Or matriz_cod(i) = "{" Or matriz_cod(i) = "}" Then
                cantidad_lineas -= 1
            End If
        Next
        txt_nodos.Text = cantidad_lineas
        txt_nodosP.Text = nodos_p
        txt_complejidad.Text = nodos_p + 1
        Dim nod As Integer = Integer.Parse(txt_nodos.Text)
        Dim cc As Integer = Integer.Parse(txt_complejidad.Text)
        Dim aris As Integer
        aris = (cc - 2) + nod
        lbl_nodos.Text = cantidad_lineas
        txt_aristas.Text = aris
        lbl_aristas.Text = aris
        lbl_tot_aristas_m_nodos.Text = (lbl_aristas.Text - lbl_nodos.Text) + 2
    End Sub
    Sub Codigo_Javaz()
        Dim arreglo(), largo, codigo, matriz() As String
        Dim i As Long
        Dim num As Integer = 1
        Dim cantidad_lineas As Integer
        Dim nodos_p As Integer = 0
        Dim aristas As Integer = 0
        codigo = txt_cod.Text
        arreglo = Split(codigo, vbCrLf)
        cantidad_lineas = arreglo.Length
        largo = String.Join(" ", arreglo)
        matriz = Split(largo, " ")
        For i0 = LBound(arreglo) To UBound(arreglo)
            If arreglo(i0) = "" Then
                cantidad_lineas -= 1
            End If
        Next
        For i = LBound(matriz) To UBound(matriz)
            If matriz(i).Contains("if") = True Or matriz(i).Contains("while") = True Or matriz(i).Contains("for") = True Or matriz(i).Contains("foreach") = True Then
                num += 1
                nodos_p += 1
                aristas += 1
            End If
            If matriz(i).Contains("else") = True Or matriz(i).Contains("{") = True Or matriz(i).Contains("}") = True Then
                cantidad_lineas -= 1
            End If
        Next
        txt_nodos.Text = cantidad_lineas
        txt_nodosP.Text = nodos_p
        txt_complejidad.Text = nodos_p + 1
        Dim nod As Integer = Integer.Parse(txt_nodos.Text)
        Dim cc As Integer = Integer.Parse(txt_complejidad.Text)
        Dim aris As Integer
        aris = (cc - 2) + nod
        lbl_nodos.Text = cantidad_lineas
        txt_aristas.Text = aris
        lbl_aristas.Text = aris
        lbl_tot_aristas_m_nodos.Text = (lbl_aristas.Text - lbl_nodos.Text) + 2
    End Sub
    Sub Codigo_Visual()
        Dim arreglo_cod() As String
        Dim largo As String
        Dim txt_cod_fuente As String
        Dim matriz_cod() As String
        Dim i As Long
        Dim num As Integer = 1
        Dim lineas As Integer
        Dim nodos_p As Integer = 0
        Dim aristas As Integer = 0
        txt_cod_fuente = txt_cod.Text
        arreglo_cod = Split(txt_cod_fuente, vbCrLf)
        lineas = arreglo_cod.Length
        largo = String.Join(" ", arreglo_cod)
        matriz_cod = Split(largo, " ")
        For a = LBound(arreglo_cod) To UBound(arreglo_cod)
            If arreglo_cod(a) = "" Then
                lineas -= 1
            End If
        Next
        For i = LBound(matriz_cod) To UBound(matriz_cod)
            If matriz_cod(i).Contains("Then") = True Or matriz_cod(i).Contains("While") = True Or matriz_cod(i).Contains("For") = True Or matriz_cod(i).Contains("foreach") = True Then
                num += 1
                nodos_p += 1
                aristas += 1
            End If
            If matriz_cod(i).Contains("Else") = True Or matriz_cod(i).Contains("End") = True Or matriz_cod(i).Contains("Next") = True Then
                lineas -= 1

            End If
            If matriz_cod(i).Contains("ElseIf") = True Then
                nodos_p -= 1
            End If
        Next
        txt_nodos.Text = lineas
        txt_nodosP.Text = nodos_p
        txt_complejidad.Text = nodos_p + 1
        Dim Total_Nodos As Integer = txt_nodos.Text
        Dim Total_CC As Integer = txt_complejidad.Text
        Dim Total_Aristas As Integer
        Total_Aristas = (Total_CC - 2) + Total_Nodos
        lbl_nodos.Text = lineas
        txt_aristas.Text = Total_Aristas
        lbl_aristas.Text = Total_Aristas
        lbl_tot_aristas_m_nodos.Text = (lbl_aristas.Text - lbl_nodos.Text) + 2
    End Sub
    Sub limpiar()
        txt_aristas.Text = ""
        txt_cod.Clear()
        txt_complejidad.Text = ""
        txt_nodos.Text = ""
        txt_nodosP.Text = ""
        lbl_aristas.Text = ""
        lbl_nodos.Text = ""
        lbl_tot_aristas_m_nodos.Text = ""
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        limpiar()
    End Sub
    Private Sub chk_C_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If chk_C.Checked = True Then
            limpiar()
            chk_Java.Checked = False
            chk_VB.Checked = False
        End If
    End Sub

    Private Sub chk_Java_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If chk_Java.Checked = True Then
            limpiar()
            chk_C.Checked = False
            chk_VB.Checked = False
        End If
    End Sub

    Private Sub chk_VB_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If chk_VB.Checked = True Then
            limpiar()
            chk_Java.Checked = False
            chk_C.Checked = False
        End If
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        chk_VB.Checked = True
    End Sub
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim figura As GraphicsPath = New GraphicsPath
        Dim x, y, ancho, alto As Integer
        ancho = 90
        alto = 90
        x = (PictureBox1.Width - ancho) / 2
        y = (PictureBox1.Height - alto) / 2
        figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        PictureBox1.Region = New Region(figura)
    End Sub
    Private Sub btnhsd_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        If txt_cod.Text = "" Then
            MsgBox("Error: No se ha Ingresado Ningun Algoritmo a Evaluar", vbCritical, "Error de Ingreso")
        Else
            If chk_C.Checked = True Then
                Codigo_CSharp()
            ElseIf chk_Java.Checked = True Then
                Codigo_Javaz()
            ElseIf chk_VB.Checked = True Then
                Codigo_Visual()
            End If
        End If
    End Sub
    Private Sub limpieza_Click(sender As Object, e As EventArgs) Handles limpieza.Click
        limpiar()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub
End Class
