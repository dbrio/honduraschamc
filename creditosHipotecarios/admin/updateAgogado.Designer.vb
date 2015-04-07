<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateAgogado
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
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CodigoAbogadoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.AbogadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbogadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.AbogadoTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EstadoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.NombresTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidosTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DireccionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.CodigoAbogadoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CorreoTextEdit = New DevExpress.XtraEditors.TextEdit()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CodigoAbogadoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbogadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EstadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoAbogadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        NombresLabel.Location = New System.Drawing.Point(49, 41)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(68, 16)
        NombresLabel.TabIndex = 15
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        ApellidosLabel.Location = New System.Drawing.Point(49, 83)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(69, 16)
        ApellidosLabel.TabIndex = 17
        ApellidosLabel.Text = "Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        TelefonoLabel.Location = New System.Drawing.Point(56, 121)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(66, 16)
        TelefonoLabel.TabIndex = 19
        TelefonoLabel.Text = "Telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        DireccionLabel.Location = New System.Drawing.Point(49, 199)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 16)
        DireccionLabel.TabIndex = 21
        DireccionLabel.Text = "Direccion:"
        '
        'CodigoAbogadoLabel
        '
        CodigoAbogadoLabel.AutoSize = True
        CodigoAbogadoLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        CodigoAbogadoLabel.Location = New System.Drawing.Point(9, 260)
        CodigoAbogadoLabel.Name = "CodigoAbogadoLabel"
        CodigoAbogadoLabel.Size = New System.Drawing.Size(117, 16)
        CodigoAbogadoLabel.TabIndex = 23
        CodigoAbogadoLabel.Text = "Codigo Abogado:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        CorreoLabel.Location = New System.Drawing.Point(65, 295)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(56, 16)
        CorreoLabel.TabIndex = 25
        CorreoLabel.Text = "Correo:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        EstadoLabel.Location = New System.Drawing.Point(80, 335)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(56, 16)
        EstadoLabel.TabIndex = 29
        EstadoLabel.Text = "Estado:"
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AbogadoBindingSource
        '
        Me.AbogadoBindingSource.DataMember = "Abogado"
        Me.AbogadoBindingSource.DataSource = Me.DataSetCreditos
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoCheckEdit)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextEdit)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextEdit)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextEdit)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionMemoEdit)
        Me.GroupBox1.Controls.Add(CodigoAbogadoLabel)
        Me.GroupBox1.Controls.Add(Me.CodigoAbogadoTextEdit)
        Me.GroupBox1.Controls.Add(CorreoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoTextEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 413)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'EstadoCheckEdit
        '
        Me.EstadoCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "estado", True))
        Me.EstadoCheckEdit.Location = New System.Drawing.Point(149, 334)
        Me.EstadoCheckEdit.Name = "EstadoCheckEdit"
        Me.EstadoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.EstadoCheckEdit.Properties.Caption = ""
        Me.EstadoCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.EstadoCheckEdit.TabIndex = 30
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(149, 363)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(258, 44)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "ACTUALIZAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'NombresTextEdit
        '
        Me.NombresTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "nombres", True))
        Me.NombresTextEdit.Location = New System.Drawing.Point(149, 31)
        Me.NombresTextEdit.Name = "NombresTextEdit"
        Me.NombresTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NombresTextEdit.Size = New System.Drawing.Size(195, 26)
        Me.NombresTextEdit.TabIndex = 16
        '
        'ApellidosTextEdit
        '
        Me.ApellidosTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "apellidos", True))
        Me.ApellidosTextEdit.Location = New System.Drawing.Point(149, 73)
        Me.ApellidosTextEdit.Name = "ApellidosTextEdit"
        Me.ApellidosTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ApellidosTextEdit.Size = New System.Drawing.Size(195, 26)
        Me.ApellidosTextEdit.TabIndex = 18
        '
        'TelefonoTextEdit
        '
        Me.TelefonoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "telefono", True))
        Me.TelefonoTextEdit.Location = New System.Drawing.Point(149, 115)
        Me.TelefonoTextEdit.Name = "TelefonoTextEdit"
        Me.TelefonoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.TelefonoTextEdit.Size = New System.Drawing.Size(195, 26)
        Me.TelefonoTextEdit.TabIndex = 20
        '
        'DireccionMemoEdit
        '
        Me.DireccionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "direccion", True))
        Me.DireccionMemoEdit.Location = New System.Drawing.Point(149, 153)
        Me.DireccionMemoEdit.Name = "DireccionMemoEdit"
        Me.DireccionMemoEdit.Size = New System.Drawing.Size(258, 91)
        Me.DireccionMemoEdit.TabIndex = 22
        '
        'CodigoAbogadoTextEdit
        '
        Me.CodigoAbogadoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "codigoAbogado", True))
        Me.CodigoAbogadoTextEdit.Location = New System.Drawing.Point(149, 254)
        Me.CodigoAbogadoTextEdit.Name = "CodigoAbogadoTextEdit"
        Me.CodigoAbogadoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoAbogadoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodigoAbogadoTextEdit.Size = New System.Drawing.Size(195, 26)
        Me.CodigoAbogadoTextEdit.TabIndex = 24
        '
        'CorreoTextEdit
        '
        Me.CorreoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "correo", True))
        Me.CorreoTextEdit.Location = New System.Drawing.Point(149, 289)
        Me.CorreoTextEdit.Name = "CorreoTextEdit"
        Me.CorreoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CorreoTextEdit.Size = New System.Drawing.Size(195, 26)
        Me.CorreoTextEdit.TabIndex = 26
        '
        'updateAgogado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 490)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "updateAgogado"
        Me.Text = "ACTUALIZAR AGOGADO"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbogadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EstadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoAbogadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents AbogadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbogadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.AbogadoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NombresTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidosTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DireccionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CodigoAbogadoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CorreoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents EstadoCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
