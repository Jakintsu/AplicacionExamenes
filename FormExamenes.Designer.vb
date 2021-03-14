<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioExamenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblPregunta = New System.Windows.Forms.Label()
        Me.LblSeguimiento = New System.Windows.Forms.Label()
        Me.LblPreguntaExamen = New System.Windows.Forms.Label()
        Me.RdBtnRespuesta1 = New System.Windows.Forms.RadioButton()
        Me.RdBtnRespuesta2 = New System.Windows.Forms.RadioButton()
        Me.RdBtnRespuesta3 = New System.Windows.Forms.RadioButton()
        Me.RdBtnRespuesta4 = New System.Windows.Forms.RadioButton()
        Me.BtnNuevoExamen = New System.Windows.Forms.Button()
        Me.BtnFinalizarExamen = New System.Windows.Forms.Button()
        Me.BtnCorregir = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPregunta
        '
        Me.LblPregunta.AutoSize = True
        Me.LblPregunta.Location = New System.Drawing.Point(34, 13)
        Me.LblPregunta.Name = "LblPregunta"
        Me.LblPregunta.Size = New System.Drawing.Size(53, 13)
        Me.LblPregunta.TabIndex = 0
        Me.LblPregunta.Text = "Pregunta:"
        '
        'LblSeguimiento
        '
        Me.LblSeguimiento.AutoSize = True
        Me.LblSeguimiento.Location = New System.Drawing.Point(105, 13)
        Me.LblSeguimiento.Name = "LblSeguimiento"
        Me.LblSeguimiento.Size = New System.Drawing.Size(79, 13)
        Me.LblSeguimiento.TabIndex = 1
        Me.LblSeguimiento.Text = "LblSeguimiento"
        '
        'LblPreguntaExamen
        '
        Me.LblPreguntaExamen.AutoSize = True
        Me.LblPreguntaExamen.Location = New System.Drawing.Point(37, 62)
        Me.LblPreguntaExamen.Name = "LblPreguntaExamen"
        Me.LblPreguntaExamen.Size = New System.Drawing.Size(102, 13)
        Me.LblPreguntaExamen.TabIndex = 2
        Me.LblPreguntaExamen.Text = "LblPreguntaExamen"
        '
        'RdBtnRespuesta1
        '
        Me.RdBtnRespuesta1.AutoSize = True
        Me.RdBtnRespuesta1.Location = New System.Drawing.Point(54, 273)
        Me.RdBtnRespuesta1.Name = "RdBtnRespuesta1"
        Me.RdBtnRespuesta1.Size = New System.Drawing.Size(112, 17)
        Me.RdBtnRespuesta1.TabIndex = 3
        Me.RdBtnRespuesta1.TabStop = True
        Me.RdBtnRespuesta1.Text = "RdBtnRespuesta1"
        Me.RdBtnRespuesta1.UseVisualStyleBackColor = True
        '
        'RdBtnRespuesta2
        '
        Me.RdBtnRespuesta2.AutoSize = True
        Me.RdBtnRespuesta2.Location = New System.Drawing.Point(54, 324)
        Me.RdBtnRespuesta2.Name = "RdBtnRespuesta2"
        Me.RdBtnRespuesta2.Size = New System.Drawing.Size(85, 17)
        Me.RdBtnRespuesta2.TabIndex = 4
        Me.RdBtnRespuesta2.TabStop = True
        Me.RdBtnRespuesta2.Text = "Respuesta 2"
        Me.RdBtnRespuesta2.UseVisualStyleBackColor = True
        '
        'RdBtnRespuesta3
        '
        Me.RdBtnRespuesta3.AutoSize = True
        Me.RdBtnRespuesta3.Location = New System.Drawing.Point(54, 382)
        Me.RdBtnRespuesta3.Name = "RdBtnRespuesta3"
        Me.RdBtnRespuesta3.Size = New System.Drawing.Size(85, 17)
        Me.RdBtnRespuesta3.TabIndex = 5
        Me.RdBtnRespuesta3.TabStop = True
        Me.RdBtnRespuesta3.Text = "Respuesta 3"
        Me.RdBtnRespuesta3.UseVisualStyleBackColor = True
        '
        'RdBtnRespuesta4
        '
        Me.RdBtnRespuesta4.AutoSize = True
        Me.RdBtnRespuesta4.Location = New System.Drawing.Point(54, 438)
        Me.RdBtnRespuesta4.Name = "RdBtnRespuesta4"
        Me.RdBtnRespuesta4.Size = New System.Drawing.Size(85, 17)
        Me.RdBtnRespuesta4.TabIndex = 6
        Me.RdBtnRespuesta4.TabStop = True
        Me.RdBtnRespuesta4.Text = "Respuesta 4"
        Me.RdBtnRespuesta4.UseVisualStyleBackColor = True
        '
        'BtnNuevoExamen
        '
        Me.BtnNuevoExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoExamen.Location = New System.Drawing.Point(709, 26)
        Me.BtnNuevoExamen.Name = "BtnNuevoExamen"
        Me.BtnNuevoExamen.Size = New System.Drawing.Size(104, 49)
        Me.BtnNuevoExamen.TabIndex = 7
        Me.BtnNuevoExamen.Text = "Nuevo Examen"
        Me.BtnNuevoExamen.UseVisualStyleBackColor = True
        '
        'BtnFinalizarExamen
        '
        Me.BtnFinalizarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizarExamen.Location = New System.Drawing.Point(709, 121)
        Me.BtnFinalizarExamen.Name = "BtnFinalizarExamen"
        Me.BtnFinalizarExamen.Size = New System.Drawing.Size(104, 49)
        Me.BtnFinalizarExamen.TabIndex = 8
        Me.BtnFinalizarExamen.Text = "Finalizar Examen"
        Me.BtnFinalizarExamen.UseVisualStyleBackColor = True
        '
        'BtnCorregir
        '
        Me.BtnCorregir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCorregir.Location = New System.Drawing.Point(709, 208)
        Me.BtnCorregir.Name = "BtnCorregir"
        Me.BtnCorregir.Size = New System.Drawing.Size(104, 49)
        Me.BtnCorregir.TabIndex = 9
        Me.BtnCorregir.Text = "Corregir Examen"
        Me.BtnCorregir.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.Location = New System.Drawing.Point(709, 350)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(104, 49)
        Me.BtnSiguiente.TabIndex = 10
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.Location = New System.Drawing.Point(709, 467)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(104, 49)
        Me.BtnAnterior.TabIndex = 11
        Me.BtnAnterior.Text = "Anterior"
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(709, 573)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 49)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FormularioExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 662)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnCorregir)
        Me.Controls.Add(Me.BtnFinalizarExamen)
        Me.Controls.Add(Me.BtnNuevoExamen)
        Me.Controls.Add(Me.RdBtnRespuesta4)
        Me.Controls.Add(Me.RdBtnRespuesta3)
        Me.Controls.Add(Me.RdBtnRespuesta2)
        Me.Controls.Add(Me.RdBtnRespuesta1)
        Me.Controls.Add(Me.LblPreguntaExamen)
        Me.Controls.Add(Me.LblSeguimiento)
        Me.Controls.Add(Me.LblPregunta)
        Me.Name = "FormularioExamenes"
        Me.Text = "FormularioExamenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPregunta As Label
    Friend WithEvents LblSeguimiento As Label
    Friend WithEvents LblPreguntaExamen As Label
    Friend WithEvents RdBtnRespuesta1 As RadioButton
    Friend WithEvents RdBtnRespuesta2 As RadioButton
    Friend WithEvents RdBtnRespuesta3 As RadioButton
    Friend WithEvents RdBtnRespuesta4 As RadioButton
    Friend WithEvents BtnNuevoExamen As Button
    Friend WithEvents BtnFinalizarExamen As Button
    Friend WithEvents BtnCorregir As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnSalir As Button
End Class
