<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IP
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.HipotecaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.HipotecaTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.HipotecaEstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaEstadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEstadoTableAdapter()
        Me.txtIP = New DevExpress.XtraEditors.TextEdit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaEstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Número IP:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(166, 160)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(153, 36)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HipotecaBindingSource
        '
        Me.HipotecaBindingSource.DataMember = "Hipoteca"
        Me.HipotecaBindingSource.DataSource = Me.DataSetCreditos
        '
        'HipotecaTableAdapter
        '
        Me.HipotecaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbogadoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventoTableAdapter = Nothing
        Me.TableAdapterManager.hipotecaEstadoTableAdapter = Nothing
        Me.TableAdapterManager.HipotecaTableAdapter = Me.HipotecaTableAdapter
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'HipotecaEstadoBindingSource
        '
        Me.HipotecaEstadoBindingSource.DataMember = "hipotecaEstado"
        Me.HipotecaEstadoBindingSource.DataSource = Me.DataSetCreditos
        '
        'HipotecaEstadoTableAdapter
        '
        Me.HipotecaEstadoTableAdapter.ClearBeforeFill = True
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(166, 105)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtIP.Properties.Appearance.Options.UseFont = True
        Me.txtIP.Properties.Mask.BeepOnError = True
        Me.txtIP.Properties.Mask.EditMask = "n0"
        Me.txtIP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIP.Size = New System.Drawing.Size(153, 32)
        Me.txtIP.TabIndex = 5
        '
        'IP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 259)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IP"
        Me.Opacity = 1.0R
        Me.Text = "IP | AMC"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.txtIP, 0)
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaEstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents HipotecaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.HipotecaTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents HipotecaEstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaEstadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEstadoTableAdapter
    Friend WithEvents txtIP As DevExpress.XtraEditors.TextEdit
End Class
