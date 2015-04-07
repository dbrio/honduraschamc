<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateUser
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
        Me.EstadoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.UsuarioTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContrasenaTextBox = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContrasenaLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.EstadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(49, 62)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(47, 14)
        UsuarioLabel.TabIndex = 3
        UsuarioLabel.Text = "Usuario:"
        '
        'ContrasenaLabel
        '
        ContrasenaLabel.AutoSize = True
        ContrasenaLabel.Location = New System.Drawing.Point(49, 113)
        ContrasenaLabel.Name = "ContrasenaLabel"
        ContrasenaLabel.Size = New System.Drawing.Size(66, 14)
        ContrasenaLabel.TabIndex = 5
        ContrasenaLabel.Text = "Contraseña:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(49, 168)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 14)
        EstadoLabel.TabIndex = 7
        EstadoLabel.Text = "Estado:"
        '
        'EstadoCheckEdit
        '
        Me.EstadoCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuarioBindingSource, "estado", True))
        Me.EstadoCheckEdit.Location = New System.Drawing.Point(138, 166)
        Me.EstadoCheckEdit.Name = "EstadoCheckEdit"
        Me.EstadoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.EstadoCheckEdit.Properties.Caption = ""
        Me.EstadoCheckEdit.Size = New System.Drawing.Size(100, 19)
        Me.EstadoCheckEdit.TabIndex = 8
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
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(140, 62)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(189, 26)
        Me.UsuarioTextBox.TabIndex = 9
        '
        'ContrasenaTextBox
        '
        Me.ContrasenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "contrasena", True))
        Me.ContrasenaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContrasenaTextBox.Location = New System.Drawing.Point(140, 104)
        Me.ContrasenaTextBox.Name = "ContrasenaTextBox"
        Me.ContrasenaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContrasenaTextBox.Size = New System.Drawing.Size(189, 26)
        Me.ContrasenaTextBox.TabIndex = 10
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(140, 224)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(189, 44)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "ACTUALIZAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'updateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 294)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.ContrasenaTextBox)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(ContrasenaLabel)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoCheckEdit)
        Me.Name = "updateUser"
        Me.Text = "ACTUALIZAR USUARIO"
        Me.Controls.SetChildIndex(Me.EstadoCheckEdit, 0)
        Me.Controls.SetChildIndex(EstadoLabel, 0)
        Me.Controls.SetChildIndex(ContrasenaLabel, 0)
        Me.Controls.SetChildIndex(UsuarioLabel, 0)
        Me.Controls.SetChildIndex(Me.UsuarioTextBox, 0)
        Me.Controls.SetChildIndex(Me.ContrasenaTextBox, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        CType(Me.EstadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents EstadoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContrasenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
