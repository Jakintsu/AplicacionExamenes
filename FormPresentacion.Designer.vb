<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPresentacion
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.TxtTotalPreguntas = New System.Windows.Forms.TextBox()
        Me.LblNumeroPreguntas = New System.Windows.Forms.Label()
        Me.BtnAcceder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(162, 70)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(250, 63)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(250, 114)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(100, 20)
        Me.TxtApellidos.TabIndex = 3
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Location = New System.Drawing.Point(162, 121)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(49, 13)
        Me.LblApellidos.TabIndex = 2
        Me.LblApellidos.Text = "Apellidos"
        '
        'TxtTotalPreguntas
        '
        Me.TxtTotalPreguntas.Location = New System.Drawing.Point(227, 208)
        Me.TxtTotalPreguntas.Name = "TxtTotalPreguntas"
        Me.TxtTotalPreguntas.Size = New System.Drawing.Size(169, 20)
        Me.TxtTotalPreguntas.TabIndex = 5
        '
        'LblNumeroPreguntas
        '
        Me.LblNumeroPreguntas.AutoSize = True
        Me.LblNumeroPreguntas.Location = New System.Drawing.Point(185, 180)
        Me.LblNumeroPreguntas.Name = "LblNumeroPreguntas"
        Me.LblNumeroPreguntas.Size = New System.Drawing.Size(262, 13)
        Me.LblNumeroPreguntas.TabIndex = 4
        Me.LblNumeroPreguntas.Text = "Preguntas que quieres realizar (Minimo 10, máximo 70)"
        '
        'BtnAcceder
        '
        Me.BtnAcceder.Location = New System.Drawing.Point(227, 275)
        Me.BtnAcceder.Name = "BtnAcceder"
        Me.BtnAcceder.Size = New System.Drawing.Size(169, 76)
        Me.BtnAcceder.TabIndex = 6
        Me.BtnAcceder.Text = "Acceso Al Examen"
        Me.BtnAcceder.UseVisualStyleBackColor = True
        '
        'FormularioPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAcceder)
        Me.Controls.Add(Me.TxtTotalPreguntas)
        Me.Controls.Add(Me.LblNumeroPreguntas)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.LblApellidos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FormularioPresentacion"
        Me.Text = "FormularioPresentacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents LblApellidos As Label
    Friend WithEvents TxtTotalPreguntas As TextBox
    Friend WithEvents LblNumeroPreguntas As Label
    Friend WithEvents BtnAcceder As Button
End Class
