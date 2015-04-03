<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAbogado
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
        Dim DireccionLabel1 As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CodigoAbogadoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.DataSetAMCProduccion1 = New creditosHipotecarios.DataSetAMCProduccion()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DireccionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.CorreoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.NombresTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidosTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoAbogadoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AbogadoBindingSource = New System.Windows.Forms.BindingSource()
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.AbogadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.AbogadoTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.EstadoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        DireccionLabel1 = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CodigoAbogadoLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetAMCProduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DireccionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoAbogadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbogadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DireccionLabel1
        '
        DireccionLabel1.AutoSize = True
        DireccionLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel1.Location = New System.Drawing.Point(42, 259)
        DireccionLabel1.Name = "DireccionLabel1"
        DireccionLabel1.Size = New System.Drawing.Size(66, 16)
        DireccionLabel1.TabIndex = 26
        DireccionLabel1.Text = "Dirección:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(64, 180)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(50, 16)
        CorreoLabel.TabIndex = 24
        CorreoLabel.Text = "Correo:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.Location = New System.Drawing.Point(50, 23)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(64, 16)
        NombresLabel.TabIndex = 16
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.Location = New System.Drawing.Point(49, 65)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(65, 16)
        ApellidosLabel.TabIndex = 18
        ApellidosLabel.Text = "Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(55, 103)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(59, 16)
        TelefonoLabel.TabIndex = 20
        TelefonoLabel.Text = "Telefono:"
        '
        'CodigoAbogadoLabel
        '
        CodigoAbogadoLabel.AutoSize = True
        CodigoAbogadoLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoAbogadoLabel.Location = New System.Drawing.Point(8, 141)
        CodigoAbogadoLabel.Name = "CodigoAbogadoLabel"
        CodigoAbogadoLabel.Size = New System.Drawing.Size(106, 16)
        CodigoAbogadoLabel.TabIndex = 22
        CodigoAbogadoLabel.Text = "Codigo Abogado:"
        '
        'DataSetAMCProduccion1
        '
        Me.DataSetAMCProduccion1.DataSetName = "DataSetAMCProduccion"
        Me.DataSetAMCProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoCheckEdit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(DireccionLabel1)
        Me.GroupBox1.Controls.Add(Me.DireccionMemoEdit)
        Me.GroupBox1.Controls.Add(CorreoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoTextEdit)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextEdit)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextEdit)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextEdit)
        Me.GroupBox1.Controls.Add(CodigoAbogadoLabel)
        Me.GroupBox1.Controls.Add(Me.CodigoAbogadoTextEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 437)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Necesariamente de GMAIL"
        '
        'DireccionMemoEdit
        '
        Me.DireccionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "direccion", True))
        Me.DireccionMemoEdit.Location = New System.Drawing.Point(120, 214)
        Me.DireccionMemoEdit.Name = "DireccionMemoEdit"
        Me.DireccionMemoEdit.Size = New System.Drawing.Size(335, 97)
        Me.DireccionMemoEdit.TabIndex = 6
        '
        'CorreoTextEdit
        '
        Me.CorreoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "correo", True))
        Me.CorreoTextEdit.Location = New System.Drawing.Point(120, 173)
        Me.CorreoTextEdit.Name = "CorreoTextEdit"
        Me.CorreoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CorreoTextEdit.Size = New System.Drawing.Size(180, 26)
        Me.CorreoTextEdit.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(120, 373)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(335, 44)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'NombresTextEdit
        '
        Me.NombresTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "nombres", True))
        Me.NombresTextEdit.Location = New System.Drawing.Point(120, 17)
        Me.NombresTextEdit.Name = "NombresTextEdit"
        Me.NombresTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NombresTextEdit.Size = New System.Drawing.Size(180, 26)
        Me.NombresTextEdit.TabIndex = 1
        '
        'ApellidosTextEdit
        '
        Me.ApellidosTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "apellidos", True))
        Me.ApellidosTextEdit.Location = New System.Drawing.Point(120, 59)
        Me.ApellidosTextEdit.Name = "ApellidosTextEdit"
        Me.ApellidosTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ApellidosTextEdit.Size = New System.Drawing.Size(180, 26)
        Me.ApellidosTextEdit.TabIndex = 2
        '
        'TelefonoTextEdit
        '
        Me.TelefonoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "telefono", True))
        Me.TelefonoTextEdit.Location = New System.Drawing.Point(120, 97)
        Me.TelefonoTextEdit.Name = "TelefonoTextEdit"
        Me.TelefonoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.TelefonoTextEdit.Size = New System.Drawing.Size(180, 26)
        Me.TelefonoTextEdit.TabIndex = 3
        '
        'CodigoAbogadoTextEdit
        '
        Me.CodigoAbogadoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "codigoAbogado", True))
        Me.CodigoAbogadoTextEdit.Location = New System.Drawing.Point(120, 135)
        Me.CodigoAbogadoTextEdit.Name = "CodigoAbogadoTextEdit"
        Me.CodigoAbogadoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoAbogadoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodigoAbogadoTextEdit.Size = New System.Drawing.Size(180, 26)
        Me.CodigoAbogadoTextEdit.TabIndex = 4
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
        'AbogadoTableAdapter
        '
        Me.AbogadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbogadoTableAdapter = Me.AbogadoTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventoTableAdapter = Nothing
        Me.TableAdapterManager.hipotecaEstadoTableAdapter = Nothing
        Me.TableAdapterManager.HipotecaTableAdapter = Nothing
        Me.TableAdapterManager.MemoTableAdapter = Nothing
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Arial", 10.0!)
        EstadoLabel.Location = New System.Drawing.Point(48, 340)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(56, 16)
        EstadoLabel.TabIndex = 27
        EstadoLabel.Text = "Estado:"
        '
        'EstadoCheckEdit
        '
        Me.EstadoCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AbogadoBindingSource, "estado", True))
        Me.EstadoCheckEdit.Location = New System.Drawing.Point(118, 339)
        Me.EstadoCheckEdit.Name = "EstadoCheckEdit"
        Me.EstadoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.EstadoCheckEdit.Properties.Caption = ""
        Me.EstadoCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.EstadoCheckEdit.TabIndex = 28
        '
        'addAbogado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "addAbogado"
        Me.Opacity = 1.0R
        Me.Text = "AGREGAR ABOGADO"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        CType(Me.DataSetAMCProduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DireccionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoAbogadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbogadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents AbogadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbogadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.AbogadoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents DataSetAMCProduccion1 As creditosHipotecarios.DataSetAMCProduccion
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DireccionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CorreoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents NombresTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidosTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoAbogadoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EstadoCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
