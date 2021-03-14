Imports System.Data.SqlClient
Imports System.IO
Public Class FormularioExamenes

    Const PUNTUACION_MAXIMA As Integer = 100
    Const OPCIONES_RESPUESTA As Integer = 3


    Dim Ruta As String = "Data Source=.;Initial Catalog=Examenes;Persist Security Info=True;User ID=sa;Password=P@ssw0rd"
    Dim Conexion As New SqlConnection(Ruta)
    Dim TodasPreguntasYRespuestas As String = "SELECT * FROM Cuestionario"
    Dim Consulta As New SqlCommand(TodasPreguntasYRespuestas, Conexion)
    Dim Adaptador As New SqlDataAdapter(Consulta)
    Dim TablaExamenes As New DataTable()
    Dim Posicion As Integer = 0
    Dim TotalPreguntas As Integer = Integer.Parse(FormularioPresentacion.TxtTotalPreguntas.Text)
    Dim NombreAlumno As String = FormularioPresentacion.TxtNombre.Text & " " & FormularioPresentacion.TxtApellidos.Text
    Dim TotalAciertos As Integer = 0
    Dim ValorRespuesta As Single = PUNTUACION_MAXIMA / TotalPreguntas
    Dim Puntuacion As Integer = 0

    Dim ListaRespuestas(TotalPreguntas, OPCIONES_RESPUESTA) As String
    Dim ListaIndiceRespuestasCorrectas(TotalPreguntas) As Integer
    Private Sub FormularioExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adaptador.Fill(TablaExamenes)
        ObtenerPregunta(0)
        BtnFinalizarExamen.Enabled = False
        BtnNuevoExamen.Enabled = False
        MessageBox.Show("Ha comenzado el examen. Mucha suerte, " & NombreAlumno)
        RellenarArrayRespuestas()
        RellenarArrayCorrectas()
    End Sub


    Private Sub ObtenerPregunta(ByVal Posicion As Integer)
        Dim NumeroPregunta As String = (Posicion + 1).ToString
        NumeroPregunta &= "/" & TotalPreguntas.ToString
        LblSeguimiento.Text = NumeroPregunta
        LblPreguntaExamen.Text = TablaExamenes.Rows(Posicion)("Pregunta")
        RdBtnRespuesta1.Text = TablaExamenes.Rows(Posicion)("Respuesta1")
        RdBtnRespuesta2.Text = TablaExamenes.Rows(Posicion)("Respuesta2")
        RdBtnRespuesta3.Text = TablaExamenes.Rows(Posicion)("Respuesta3")
        RdBtnRespuesta4.Text = TablaExamenes.Rows(Posicion)("Respuesta4")
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub Anterior()
        If Posicion = TotalPreguntas - 1 Then
            BtnFinalizarExamen.Enabled = True
        End If
        If Posicion = 0 Then
            BtnAnterior.Enabled = False
            BtnSiguiente.Enabled = True
        Else
            Posicion -= 1
        End If
        ObtenerPregunta(Posicion)
    End Sub

    Private Sub Siguiente()
        If Posicion = TotalPreguntas - 2 Then
            BtnFinalizarExamen.Enabled = True
        End If
        If Posicion = TotalPreguntas - 1 Then
            BtnSiguiente.Enabled = False
            BtnAnterior.Enabled = True
            BtnNuevoExamen.Enabled = True

        Else
            Posicion += 1
        End If

        RdBtnRespuesta1.Enabled = True
        RdBtnRespuesta2.Enabled = True
        RdBtnRespuesta3.Enabled = True
        RdBtnRespuesta4.Enabled = True
        ObtenerPregunta(Posicion)
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Siguiente()
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        Anterior()
    End Sub

    Private Sub RellenarArrayRespuestas()
        For Contador1 As Integer = 0 To TotalPreguntas - 1
            For Contador2 As Integer = 0 To OPCIONES_RESPUESTA
                ListaRespuestas(Contador1, Contador2) = TablaExamenes.Rows(Contador1)(Contador2 + 2)
                'MessageBox.Show(ListaRespuestas(Contador1, Contador2))
            Next
        Next

    End Sub
    Private Sub RellenarArrayCorrectas()
        For Contador As Integer = 0 To TotalPreguntas - 1
            ListaIndiceRespuestasCorrectas(Contador) = TablaExamenes.Rows(Contador)("Solucion")
            'MessageBox.Show(ListaIndiceRespuestasCorrectas(Contador))
        Next
    End Sub

    Private Sub Correccion()
        Dim PosicionCorrecta As Integer = ListaIndiceRespuestasCorrectas(Posicion) - 1
        If RdBtnRespuesta1.Checked AndAlso RdBtnRespuesta1.Text.Equals(ListaRespuestas(Posicion, PosicionCorrecta)) Then
            MessageBox.Show("respuesta correcta!!!!!!")
            TotalAciertos += 1
            Puntuacion += ValorRespuesta
        End If
        If RdBtnRespuesta2.Checked AndAlso RdBtnRespuesta2.Text.Equals(ListaRespuestas(Posicion, PosicionCorrecta)) Then
            MessageBox.Show("respuesta correcta!!!!!!")
            TotalAciertos += 1
            Puntuacion += ValorRespuesta
        End If

        If RdBtnRespuesta3.Checked AndAlso RdBtnRespuesta3.Text.Equals(ListaRespuestas(Posicion, PosicionCorrecta)) Then
            MessageBox.Show("respuesta correcta!!!!!!")
            TotalAciertos += 1
            Puntuacion += ValorRespuesta
        End If

        If RdBtnRespuesta4.Checked AndAlso RdBtnRespuesta4.Text.Equals(ListaRespuestas(Posicion, PosicionCorrecta)) Then
            MessageBox.Show("respuesta correcta!!!!!!")
            TotalAciertos += 1
            Puntuacion += ValorRespuesta
        End If
    End Sub

    Private Sub BtnCorregir_Click(sender As Object, e As EventArgs) Handles BtnCorregir.Click
        Correccion()
        RdBtnRespuesta1.Enabled = False
        RdBtnRespuesta2.Enabled = False
        RdBtnRespuesta3.Enabled = False
        RdBtnRespuesta4.Enabled = False
    End Sub

    Private Sub BtnFinalizarExamen_Click(sender As Object, e As EventArgs) Handles BtnFinalizarExamen.Click
        MessageBox.Show("Ya has finalizado el examen...")
        MessageBox.Show("Has obtenido un total de " & Puntuacion.ToString)
        If Puntuacion >= PUNTUACION_MAXIMA / 2 Then
            MessageBox.Show("Zorionak. Eres apto")
        Else
            MessageBox.Show("Lo siento. Puedes intentarlo de nuevo más adelante")
        End If
    End Sub
End Class
