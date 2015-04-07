<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPersonal
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
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.CargoTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.AgenciaTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.AgenciaTableAdapter()
        Me.PersonalTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.PersonalTableAdapter()
        Me.AgenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxAGE = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCARG = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellido = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.DataSetCreditos
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbogadoTableAdapter = Nothing
        Me.TableAdapterManager.AgenciaTableAdapter = Me.AgenciaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CargoTableAdapter = Me.CargoTableAdapter
        Me.TableAdapterManager.EventoTableAdapter = Nothing
        Me.TableAdapterManager.hipotecaEstadoTableAdapter = Nothing
        Me.TableAdapterManager.HipotecaTableAdapter = Nothing
        Me.TableAdapterManager.MemoTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Me.PersonalTableAdapter
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'AgenciaTableAdapter
        '
        Me.AgenciaTableAdapter.ClearBeforeFill = True
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'AgenciaBindingSource
        '
        Me.AgenciaBindingSource.DataMember = "Agencia"
        Me.AgenciaBindingSource.DataSource = Me.DataSetCreditos
        '
        'ComboBoxAGE
        '
        Me.ComboBoxAGE.DataSource = Me.AgenciaBindingSource
        Me.ComboBoxAGE.DisplayMember = "nombreAgencia"
        Me.ComboBoxAGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAGE.FormattingEnabled = True
        Me.ComboBoxAGE.Location = New System.Drawing.Point(139, 161)
        Me.ComboBoxAGE.Name = "ComboBoxAGE"
        Me.ComboBoxAGE.Size = New System.Drawing.Size(241, 28)
        Me.ComboBoxAGE.TabIndex = 0
        Me.ComboBoxAGE.ValueMember = "codigoAgencia"
        '
        'ComboBoxCARG
        '
        Me.ComboBoxCARG.DataSource = Me.CargoBindingSource
        Me.ComboBoxCARG.DisplayMember = "Cargo"
        Me.ComboBoxCARG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCARG.FormattingEnabled = True
        Me.ComboBoxCARG.Location = New System.Drawing.Point(139, 216)
        Me.ComboBoxCARG.Name = "ComboBoxCARG"
        Me.ComboBoxCARG.Size = New System.Drawing.Size(241, 28)
        Me.ComboBoxCARG.TabIndex = 1
        Me.ComboBoxCARG.ValueMember = "cargoId"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(139, 278)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(241, 41)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(139, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.Appearance.Options.UseFont = True
        Me.txtNombre.Size = New System.Drawing.Size(241, 26)
        Me.txtNombre.TabIndex = 19
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(139, 109)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Properties.Appearance.Options.UseFont = True
        Me.txtApellido.Size = New System.Drawing.Size(241, 26)
        Me.txtApellido.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Agencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Cargo:"
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.DataSetCreditos
        '
        'addPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 341)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.ComboBoxCARG)
        Me.Controls.Add(Me.ComboBoxAGE)
        Me.Name = "addPersonal"
        Me.Opacity = 1.0R
        Me.Text = "AGREGAR EMPLEADO"
        Me.Controls.SetChildIndex(Me.ComboBoxAGE, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxCARG, 0)
        Me.Controls.SetChildIndex(Me.txtApellido, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents CargoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.CargoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents AgenciaTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.AgenciaTableAdapter
    Friend WithEvents AgenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBoxAGE As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCARG As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PersonalTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.PersonalTableAdapter
    Friend WithEvents PersonalBindingSource As System.Windows.Forms.BindingSource
End Class
