<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addProtocolo
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtIdPropietario = New System.Windows.Forms.TextBox()
        Me.LabelIdentidadCliente = New System.Windows.Forms.Label()
        Me.NombresAbogado = New System.Windows.Forms.ComboBox()
        Me.AbogadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.AbogadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelValorRemate = New System.Windows.Forms.Label()
        Me.LabelInteresMora = New System.Windows.Forms.Label()
        Me.LabelCuota = New System.Windows.Forms.Label()
        Me.LabelInteres = New System.Windows.Forms.Label()
        Me.LabelPlazos = New System.Windows.Forms.Label()
        Me.LabelMonto = New System.Windows.Forms.Label()
        Me.LabelIdentidadProietario = New System.Windows.Forms.Label()
        Me.LabelPropietario = New System.Windows.Forms.Label()
        Me.AbogadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.AbogadoTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.PrestamoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.prestamoTableAdapter()
        Me.HipotecaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.HipotecaTableAdapter()
        Me.EventoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.EventoTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.AbogadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbogadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PrestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(30, 75)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(79, 20)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "NOMBRE"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtIdPropietario)
        Me.Panel1.Controls.Add(Me.LabelIdentidadCliente)
        Me.Panel1.Controls.Add(Me.NombresAbogado)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.LabelIdentidadProietario)
        Me.Panel1.Controls.Add(Me.LabelPropietario)
        Me.Panel1.Controls.Add(Me.LabelNombre)
        Me.Panel1.ForeColor = System.Drawing.Color.SlateGray
        Me.Panel1.Location = New System.Drawing.Point(104, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 538)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Tag = ""
        '
        'txtIdPropietario
        '
        Me.txtIdPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPropietario.Location = New System.Drawing.Point(612, 189)
        Me.txtIdPropietario.Name = "txtIdPropietario"
        Me.txtIdPropietario.Size = New System.Drawing.Size(188, 26)
        Me.txtIdPropietario.TabIndex = 13
        '
        'LabelIdentidadCliente
        '
        Me.LabelIdentidadCliente.AutoSize = True
        Me.LabelIdentidadCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdentidadCliente.Location = New System.Drawing.Point(30, 135)
        Me.LabelIdentidadCliente.Name = "LabelIdentidadCliente"
        Me.LabelIdentidadCliente.Size = New System.Drawing.Size(74, 20)
        Me.LabelIdentidadCliente.TabIndex = 12
        Me.LabelIdentidadCliente.Text = "identidad"
        '
        'NombresAbogado
        '
        Me.NombresAbogado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbogadoBindingSource, "nombres", True))
        Me.NombresAbogado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AbogadoBindingSource1, "abogadoId", True))
        Me.NombresAbogado.DataSource = Me.AbogadoBindingSource
        Me.NombresAbogado.DisplayMember = "nombres"
        Me.NombresAbogado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresAbogado.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.NombresAbogado.FormattingEnabled = True
        Me.NombresAbogado.Location = New System.Drawing.Point(175, 22)
        Me.NombresAbogado.Name = "NombresAbogado"
        Me.NombresAbogado.Size = New System.Drawing.Size(179, 24)
        Me.NombresAbogado.TabIndex = 11
        Me.NombresAbogado.Text = " "
        Me.NombresAbogado.ValueMember = "abogadoId"
        '
        'AbogadoBindingSource
        '
        Me.AbogadoBindingSource.DataMember = "Abogado"
        Me.AbogadoBindingSource.DataSource = Me.DataSetCreditos
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AbogadoBindingSource1
        '
        Me.AbogadoBindingSource1.DataMember = "Abogado"
        Me.AbogadoBindingSource1.DataSource = Me.DataSetCreditos
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(336, 471)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(190, 43)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(27, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 20)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "ABOGADO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelValorRemate)
        Me.GroupBox1.Controls.Add(Me.LabelInteresMora)
        Me.GroupBox1.Controls.Add(Me.LabelCuota)
        Me.GroupBox1.Controls.Add(Me.LabelInteres)
        Me.GroupBox1.Controls.Add(Me.LabelPlazos)
        Me.GroupBox1.Controls.Add(Me.LabelMonto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 202)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS PARA PROTOCOLIZAR"
        '
        'LabelValorRemate
        '
        Me.LabelValorRemate.AutoSize = True
        Me.LabelValorRemate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValorRemate.ForeColor = System.Drawing.Color.Black
        Me.LabelValorRemate.Location = New System.Drawing.Point(366, 154)
        Me.LabelValorRemate.Name = "LabelValorRemate"
        Me.LabelValorRemate.Size = New System.Drawing.Size(129, 20)
        Me.LabelValorRemate.TabIndex = 11
        Me.LabelValorRemate.Text = "Valor de Remate"
        '
        'LabelInteresMora
        '
        Me.LabelInteresMora.AutoSize = True
        Me.LabelInteresMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInteresMora.ForeColor = System.Drawing.Color.Black
        Me.LabelInteresMora.Location = New System.Drawing.Point(366, 96)
        Me.LabelInteresMora.Name = "LabelInteresMora"
        Me.LabelInteresMora.Size = New System.Drawing.Size(126, 20)
        Me.LabelInteresMora.TabIndex = 10
        Me.LabelInteresMora.Text = "Interes por Mora"
        '
        'LabelCuota
        '
        Me.LabelCuota.AutoSize = True
        Me.LabelCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCuota.ForeColor = System.Drawing.Color.Black
        Me.LabelCuota.Location = New System.Drawing.Point(366, 40)
        Me.LabelCuota.Name = "LabelCuota"
        Me.LabelCuota.Size = New System.Drawing.Size(110, 20)
        Me.LabelCuota.TabIndex = 9
        Me.LabelCuota.Text = "Cuota a pagar"
        '
        'LabelInteres
        '
        Me.LabelInteres.AutoSize = True
        Me.LabelInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInteres.ForeColor = System.Drawing.Color.Black
        Me.LabelInteres.Location = New System.Drawing.Point(24, 154)
        Me.LabelInteres.Name = "LabelInteres"
        Me.LabelInteres.Size = New System.Drawing.Size(120, 20)
        Me.LabelInteres.TabIndex = 8
        Me.LabelInteres.Text = "Tasa de Interes"
        '
        'LabelPlazos
        '
        Me.LabelPlazos.AutoSize = True
        Me.LabelPlazos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPlazos.ForeColor = System.Drawing.Color.Black
        Me.LabelPlazos.Location = New System.Drawing.Point(24, 96)
        Me.LabelPlazos.Name = "LabelPlazos"
        Me.LabelPlazos.Size = New System.Drawing.Size(100, 20)
        Me.LabelPlazos.TabIndex = 7
        Me.LabelPlazos.Text = "Plazo cuotas"
        '
        'LabelMonto
        '
        Me.LabelMonto.AutoSize = True
        Me.LabelMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonto.ForeColor = System.Drawing.Color.Black
        Me.LabelMonto.Location = New System.Drawing.Point(24, 40)
        Me.LabelMonto.Name = "LabelMonto"
        Me.LabelMonto.Size = New System.Drawing.Size(126, 20)
        Me.LabelMonto.TabIndex = 6
        Me.LabelMonto.Text = "Monto Prestamo"
        '
        'LabelIdentidadProietario
        '
        Me.LabelIdentidadProietario.AutoSize = True
        Me.LabelIdentidadProietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdentidadProietario.ForeColor = System.Drawing.Color.Black
        Me.LabelIdentidadProietario.Location = New System.Drawing.Point(495, 192)
        Me.LabelIdentidadProietario.Name = "LabelIdentidadProietario"
        Me.LabelIdentidadProietario.Size = New System.Drawing.Size(101, 20)
        Me.LabelIdentidadProietario.TabIndex = 2
        Me.LabelIdentidadProietario.Text = "IDENTIDAD:"
        '
        'LabelPropietario
        '
        Me.LabelPropietario.AutoSize = True
        Me.LabelPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPropietario.Location = New System.Drawing.Point(30, 192)
        Me.LabelPropietario.Name = "LabelPropietario"
        Me.LabelPropietario.Size = New System.Drawing.Size(85, 20)
        Me.LabelPropietario.TabIndex = 1
        Me.LabelPropietario.Text = "Propietario"
        '
        'AbogadoTableAdapter
        '
        Me.AbogadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbogadoTableAdapter = Me.AbogadoTableAdapter
        Me.TableAdapterManager.AgenciaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CargoTableAdapter = Nothing
        Me.TableAdapterManager.EventoTableAdapter = Nothing
        Me.TableAdapterManager.hipotecaEstadoTableAdapter = Nothing
        Me.TableAdapterManager.HipotecaTableAdapter = Nothing
        Me.TableAdapterManager.MemoTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'PrestamoBindingSource
        '
        Me.PrestamoBindingSource.DataMember = "prestamo"
        Me.PrestamoBindingSource.DataSource = Me.DataSetCreditos
        '
        'PrestamoTableAdapter
        '
        Me.PrestamoTableAdapter.ClearBeforeFill = True
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
        'EventoBindingSource
        '
        Me.EventoBindingSource.DataMember = "Evento"
        Me.EventoBindingSource.DataSource = Me.DataSetCreditos
        '
        'EventoTableAdapter
        '
        Me.EventoTableAdapter.ClearBeforeFill = True
        '
        'addProtocolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(996, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "addProtocolo"
        Me.Text = "Autorización para Protocolo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AbogadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbogadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PrestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelValorRemate As System.Windows.Forms.Label
    Friend WithEvents LabelInteresMora As System.Windows.Forms.Label
    Friend WithEvents LabelCuota As System.Windows.Forms.Label
    Friend WithEvents LabelInteres As System.Windows.Forms.Label
    Friend WithEvents LabelPlazos As System.Windows.Forms.Label
    Friend WithEvents LabelMonto As System.Windows.Forms.Label
    Friend WithEvents LabelIdentidadProietario As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents AbogadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbogadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.AbogadoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents NombresAbogado As System.Windows.Forms.ComboBox
    Friend WithEvents AbogadoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LabelIdentidadCliente As System.Windows.Forms.Label
    Friend WithEvents LabelPropietario As System.Windows.Forms.Label
    Friend WithEvents txtIdPropietario As System.Windows.Forms.TextBox
    Friend WithEvents PrestamoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrestamoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.prestamoTableAdapter
    Friend WithEvents HipotecaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.HipotecaTableAdapter
    Friend WithEvents EventoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EventoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.EventoTableAdapter
End Class
