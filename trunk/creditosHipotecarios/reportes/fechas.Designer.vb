<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fechas
    'Inherits System.Windows.Forms.Form

    Inherits JaarForm.JForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.TextInicio = New DevExpress.XtraEditors.TextEdit()
        Me.TextFinal = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TextInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(258, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "HASTA:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(164, 174)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(153, 39)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "GENERAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'TextInicio
        '
        Me.TextInicio.Location = New System.Drawing.Point(35, 101)
        Me.TextInicio.Name = "TextInicio"
        Me.TextInicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextInicio.Properties.Appearance.Options.UseFont = True
        Me.TextInicio.Properties.Mask.BeepOnError = True
        Me.TextInicio.Properties.Mask.EditMask = "d"
        Me.TextInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.TextInicio.Size = New System.Drawing.Size(177, 32)
        Me.TextInicio.TabIndex = 10
        '
        'TextFinal
        '
        Me.TextFinal.Location = New System.Drawing.Point(263, 101)
        Me.TextFinal.Name = "TextFinal"
        Me.TextFinal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFinal.Properties.Appearance.Options.UseFont = True
        Me.TextFinal.Properties.Mask.EditMask = "d"
        Me.TextFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.TextFinal.Size = New System.Drawing.Size(177, 32)
        Me.TextFinal.TabIndex = 11
        '
        'fechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 260)
        Me.Controls.Add(Me.TextFinal)
        Me.Controls.Add(Me.TextInicio)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fechas"
        Me.Opacity = 1.0R
        Me.Text = "FECHAS"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.TextInicio, 0)
        Me.Controls.SetChildIndex(Me.TextFinal, 0)
        CType(Me.TextInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents TextInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextFinal As DevExpress.XtraEditors.TextEdit
End Class
