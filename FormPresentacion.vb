Public Class FormularioPresentacion
    Const MINIMO_PREGUNTAS As Integer = 10
    Const MAXIMO_PREGUNTAS As Integer = 70
    Private Sub FormularioPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Bienvenido a nuestra aplicación para realizar exámenes. Ingrese su nombre, apellidos y 
las preguntas que quiera realizar")
    End Sub

    Private Function ComprobacionDatos() As Boolean
        Dim Resultado As Boolean = True
        If TxtApellidos.Text.Equals("") OrElse TxtNombre.Equals("") Then
            MessageBox.Show("No puede dejar el nombre ni el apellido en blanco.")
            TxtApellidos.Text = ""
            TxtNombre.Text = ""
            Resultado = False
        End If
        If TxtTotalPreguntas.Equals("") Then
            MessageBox.Show("Debe ingresar cuantas preguntas quiere realizar")
            Resultado = False
        End If
        Return Resultado
    End Function
    Private Function ComprobacionRango() As Boolean
        Dim Resultado As Boolean = True
        Dim TotalPreguntasExamen As Integer = Integer.Parse(TxtTotalPreguntas.Text)
        If TotalPreguntasExamen < MINIMO_PREGUNTAS OrElse TotalPreguntasExamen > MAXIMO_PREGUNTAS Then
            MessageBox.Show("El valor debe estar comprendido entre 10 y 70")
            TxtTotalPreguntas.Text = ""
            Resultado = False
        End If
        Return Resultado
    End Function

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        If ComprobacionDatos() AndAlso ComprobacionRango() Then

            FormularioExamenes.Show()

        End If
    End Sub
End Class