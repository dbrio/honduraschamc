<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pudatePersonal
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
        Dim CodigoAgenciaLabel As System.Windows.Forms.Label
        Dim CargoIdLabel As System.Windows.Forms.Label
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.PersonalTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.NombresTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidosTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoAgenciaComboBox = New System.Windows.Forms.ComboBox()
        Me.AgenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoIdComboBox = New System.Windows.Forms.ComboBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgenciaTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.AgenciaTableAdapter()
        Me.CargoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.CargoTableAdapter()
        Me.btnAgregar = New System.Windows.Forms.Button()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        CodigoAgenciaLabel = New System.Windows.Forms.Label()
        CargoIdLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.Location = New System.Drawing.Point(61, 78)
        NombresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(67, 16)
        NombresLabel.TabIndex = 5
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.Location = New System.Drawing.Point(61, 127)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(68, 16)
        ApellidosLabel.TabIndex = 7
        ApellidosLabel.Text = "Apellidos:"
        '
        'CodigoAgenciaLabel
        '
        CodigoAgenciaLabel.AutoSize = True
        CodigoAgenciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoAgenciaLabel.Location = New System.Drawing.Point(61, 180)
        CodigoAgenciaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CodigoAgenciaLabel.Name = "CodigoAgenciaLabel"
        CodigoAgenciaLabel.Size = New System.Drawing.Size(61, 16)
        CodigoAgenciaLabel.TabIndex = 9
        CodigoAgenciaLabel.Text = "Agencia:"
        '
        'CargoIdLabel
        '
        CargoIdLabel.AutoSize = True
        CargoIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CargoIdLabel.Location = New System.Drawing.Point(61, 227)
        CargoIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CargoIdLabel.Name = "CargoIdLabel"
        CargoIdLabel.Size = New System.Drawing.Size(48, 16)
        CargoIdLabel.TabIndex = 11
        CargoIdLabel.Text = "Cargo:"
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.DataSetCreditos
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PersonalTableAdapter = Me.PersonalTableAdapter
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'NombresTextEdit
        '
        Me.NombresTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PersonalBindingSource, "nombres", True))
        Me.NombresTextEdit.Location = New System.Drawing.Point(146, 72)
        Me.NombresTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.NombresTextEdit.Name = "NombresTextEdit"
        Me.NombresTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NombresTextEdit.Size = New System.Drawing.Size(242, 26)
        Me.NombresTextEdit.TabIndex = 6
        '
        'ApellidosTextEdit
        '
        Me.ApellidosTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PersonalBindingSource, "apellidos", True))
        Me.ApellidosTextEdit.Location = New System.Drawing.Point(146, 124)
        Me.ApellidosTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ApellidosTextEdit.Name = "ApellidosTextEdit"
        Me.ApellidosTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ApellidosTextEdit.Size = New System.Drawing.Size(242, 26)
        Me.ApellidosTextEdit.TabIndex = 8
        '
        'CodigoAgenciaComboBox
        '
        Me.CodigoAgenciaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgenciaBindingSource, "nombreAgencia", True))
        Me.CodigoAgenciaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PersonalBindingSource, "codigoAgencia", True))
        Me.CodigoAgenciaComboBox.DataSource = Me.AgenciaBindingSource
        Me.CodigoAgenciaComboBox.DisplayMember = "nombreAgencia"
        Me.CodigoAgenciaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoAgenciaComboBox.FormattingEnabled = True
        Me.CodigoAgenciaComboBox.Location = New System.Drawing.Point(146, 174)
        Me.CodigoAgenciaComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CodigoAgenciaComboBox.Name = "CodigoAgenciaComboBox"
        Me.CodigoAgenciaComboBox.Size = New System.Drawing.Size(241, 28)
        Me.CodigoAgenciaComboBox.TabIndex = 10
        Me.CodigoAgenciaComboBox.ValueMember = "codigoAgencia"
        '
        'AgenciaBindingSource
        '
        Me.AgenciaBindingSource.DataMember = "Agencia"
        Me.AgenciaBindingSource.DataSource = Me.DataSetCreditos
        '
        'CargoIdComboBox
        '
        Me.CargoIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CargoBindingSource, "Cargo", True))
        Me.CargoIdComboBox.DataSource = Me.CargoBindingSource
        Me.CargoIdComboBox.DisplayMember = "Cargo"
        Me.CargoIdComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargoIdComboBox.FormattingEnabled = True
        Me.CargoIdComboBox.Location = New System.Drawing.Point(146, 225)
        Me.CargoIdComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CargoIdComboBox.Name = "CargoIdComboBox"
        Me.CargoIdComboBox.Size = New System.Drawing.Size(241, 28)
        Me.CargoIdComboBox.TabIndex = 12
        Me.CargoIdComboBox.ValueMember = "cargoId"
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.DataSetCreditos
        '
        'AgenciaTableAdapter
        '
        Me.AgenciaTableAdapter.ClearBeforeFill = True
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(146, 282)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(241, 41)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'pudatePersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 363)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextEdit)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextEdit)
        Me.Controls.Add(CodigoAgenciaLabel)
        Me.Controls.Add(Me.CodigoAgenciaComboBox)
        Me.Controls.Add(CargoIdLabel)
        Me.Controls.Add(Me.CargoIdComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "pudatePersonal"
        Me.Text = "pudatePersonal"
        Me.Controls.SetChildIndex(Me.CargoIdComboBox, 0)
        Me.Controls.SetChildIndex(CargoIdLabel, 0)
        Me.Controls.SetChildIndex(Me.CodigoAgenciaComboBox, 0)
        Me.Controls.SetChildIndex(CodigoAgenciaLabel, 0)
        Me.Controls.SetChildIndex(Me.ApellidosTextEdit, 0)
        Me.Controls.SetChildIndex(ApellidosLabel, 0)
        Me.Controls.SetChildIndex(Me.NombresTextEdit, 0)
        Me.Controls.SetChildIndex(NombresLabel, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents PersonalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonalTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.PersonalTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents NombresTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidosTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoAgenciaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CargoIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AgenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgenciaTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.AgenciaTableAdapter
    Friend WithEvents CargoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.CargoTableAdapter
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
