<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custodia
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.HipotecaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.HipotecaTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.HipotecaEstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaEstadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEstadoTableAdapter()
        Me.txtMatricula = New DevExpress.XtraEditors.TextEdit()
        Me.txtAsiento = New DevExpress.XtraEditors.TextEdit()
        Me.txtTomo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaEstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMatricula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTomo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(179, 235)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(155, 32)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Matrícula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Asiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tomo:"
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
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(179, 75)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Properties.Appearance.Options.UseFont = True
        Me.txtMatricula.Properties.Mask.BeepOnError = True
        Me.txtMatricula.Properties.Mask.EditMask = "n0"
        Me.txtMatricula.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMatricula.Size = New System.Drawing.Size(155, 32)
        Me.txtMatricula.TabIndex = 12
        '
        'txtAsiento
        '
        Me.txtAsiento.Location = New System.Drawing.Point(179, 121)
        Me.txtAsiento.Name = "txtAsiento"
        Me.txtAsiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtAsiento.Properties.Appearance.Options.UseFont = True
        Me.txtAsiento.Properties.Mask.BeepOnError = True
        Me.txtAsiento.Properties.Mask.EditMask = "n0"
        Me.txtAsiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAsiento.Size = New System.Drawing.Size(155, 32)
        Me.txtAsiento.TabIndex = 13
        '
        'txtTomo
        '
        Me.txtTomo.Location = New System.Drawing.Point(179, 170)
        Me.txtTomo.Name = "txtTomo"
        Me.txtTomo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtTomo.Properties.Appearance.Options.UseFont = True
        Me.txtTomo.Properties.Mask.BeepOnError = True
        Me.txtTomo.Properties.Mask.EditMask = "n0"
        Me.txtTomo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTomo.Size = New System.Drawing.Size(155, 32)
        Me.txtTomo.TabIndex = 14
        '
        'custodia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 302)
        Me.Controls.Add(Me.txtTomo)
        Me.Controls.Add(Me.txtAsiento)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "custodia"
        Me.Opacity = 1.0R
        Me.Text = "CUSTODIA | AMC"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtMatricula, 0)
        Me.Controls.SetChildIndex(Me.txtAsiento, 0)
        Me.Controls.SetChildIndex(Me.txtTomo, 0)
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaEstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMatricula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTomo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents HipotecaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.HipotecaTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents HipotecaEstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaEstadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEstadoTableAdapter
    Friend WithEvents txtMatricula As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAsiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTomo As DevExpress.XtraEditors.TextEdit
End Class
