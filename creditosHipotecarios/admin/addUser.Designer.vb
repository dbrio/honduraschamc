<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUser
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ContrasenaLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.UsuarioTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.ContrasenaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstadoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.UsuarioTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContrasenaLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.UsuarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContrasenaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(73, 89)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(56, 16)
        UsuarioLabel.TabIndex = 4
        UsuarioLabel.Text = "Usuario:"
        '
        'ContrasenaLabel
        '
        ContrasenaLabel.AutoSize = True
        ContrasenaLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContrasenaLabel.Location = New System.Drawing.Point(73, 143)
        ContrasenaLabel.Name = "ContrasenaLabel"
        ContrasenaLabel.Size = New System.Drawing.Size(78, 16)
        ContrasenaLabel.TabIndex = 6
        ContrasenaLabel.Text = "Contrasena:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(71, 194)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(53, 16)
        EstadoLabel.TabIndex = 8
        EstadoLabel.Text = "Estado:"
        '
        'UsuarioTextEdit
        '
        Me.UsuarioTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuarioBindingSource, "usuario", True))
        Me.UsuarioTextEdit.Location = New System.Drawing.Point(172, 88)
        Me.UsuarioTextEdit.Name = "UsuarioTextEdit"
        Me.UsuarioTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextEdit.Properties.Appearance.Options.UseFont = True
        Me.UsuarioTextEdit.Size = New System.Drawing.Size(196, 26)
        Me.UsuarioTextEdit.TabIndex = 5
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.DataSetCreditos
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContrasenaTextEdit
        '
        Me.ContrasenaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuarioBindingSource, "contrasena", True))
        Me.ContrasenaTextEdit.Location = New System.Drawing.Point(172, 142)
        Me.ContrasenaTextEdit.Name = "ContrasenaTextEdit"
        Me.ContrasenaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContrasenaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ContrasenaTextEdit.Size = New System.Drawing.Size(196, 26)
        Me.ContrasenaTextEdit.TabIndex = 7
        '
        'EstadoCheckEdit
        '
        Me.EstadoCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuarioBindingSource, "estado", True))
        Me.EstadoCheckEdit.Location = New System.Drawing.Point(170, 193)
        Me.EstadoCheckEdit.Name = "EstadoCheckEdit"
        Me.EstadoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.EstadoCheckEdit.Properties.Caption = ""
        Me.EstadoCheckEdit.Size = New System.Drawing.Size(100, 19)
        Me.EstadoCheckEdit.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(172, 253)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(196, 41)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbogadoTableAdapter = Nothing
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
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'addUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 346)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextEdit)
        Me.Controls.Add(ContrasenaLabel)
        Me.Controls.Add(Me.ContrasenaTextEdit)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoCheckEdit)
        Me.Name = "addUser"
        Me.Text = "AGREGAR USUARIO"
        Me.Controls.SetChildIndex(Me.EstadoCheckEdit, 0)
        Me.Controls.SetChildIndex(EstadoLabel, 0)
        Me.Controls.SetChildIndex(Me.ContrasenaTextEdit, 0)
        Me.Controls.SetChildIndex(ContrasenaLabel, 0)
        Me.Controls.SetChildIndex(Me.UsuarioTextEdit, 0)
        Me.Controls.SetChildIndex(UsuarioLabel, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        CType(Me.UsuarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContrasenaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents UsuarioTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContrasenaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstadoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
