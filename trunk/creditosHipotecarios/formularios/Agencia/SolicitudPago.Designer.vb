<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitudPago
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
        Me.txtGastos = New DevExpress.XtraEditors.TextEdit()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHonorario = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComision = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HipotecaEstadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEstadoTableAdapter()
        CType(Me.txtGastos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHonorario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtGastos
        '
        Me.txtGastos.Location = New System.Drawing.Point(154, 75)
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtGastos.Properties.Appearance.Options.UseFont = True
        Me.txtGastos.Properties.Mask.BeepOnError = True
        Me.txtGastos.Properties.Mask.EditMask = "n2"
        Me.txtGastos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGastos.Size = New System.Drawing.Size(153, 32)
        Me.txtGastos.TabIndex = 8
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(154, 249)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(153, 36)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Gastos:"
        '
        'txtHonorario
        '
        Me.txtHonorario.Location = New System.Drawing.Point(154, 130)
        Me.txtHonorario.Name = "txtHonorario"
        Me.txtHonorario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtHonorario.Properties.Appearance.Options.UseFont = True
        Me.txtHonorario.Properties.Mask.BeepOnError = True
        Me.txtHonorario.Properties.Mask.EditMask = "n2"
        Me.txtHonorario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtHonorario.Size = New System.Drawing.Size(153, 32)
        Me.txtHonorario.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Honorarios:"
        '
        'txtComision
        '
        Me.txtComision.Location = New System.Drawing.Point(154, 188)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtComision.Properties.Appearance.Options.UseFont = True
        Me.txtComision.Properties.Mask.BeepOnError = True
        Me.txtComision.Properties.Mask.EditMask = "n2"
        Me.txtComision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtComision.Size = New System.Drawing.Size(153, 32)
        Me.txtComision.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Comisión:"
        '
        'HipotecaEstadoTableAdapter
        '
        Me.HipotecaEstadoTableAdapter.ClearBeforeFill = True
        '
        'SolicitudPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 319)
        Me.Controls.Add(Me.txtComision)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHonorario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGastos)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SolicitudPago"
        Me.Text = "Solicitar Pagos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.txtGastos, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtHonorario, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtComision, 0)
        CType(Me.txtGastos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHonorario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGastos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHonorario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtComision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HipotecaEstadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEstadoTableAdapter
End Class
