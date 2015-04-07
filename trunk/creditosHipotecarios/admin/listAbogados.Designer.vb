<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listAbogados
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
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.AbogadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbogadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.AbogadoTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.AbogadoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colabogadoId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colapellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcodigoAbogado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcorreo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbogadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbogadoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'AbogadoGridControl
        '
        Me.AbogadoGridControl.DataSource = Me.AbogadoBindingSource
        Me.AbogadoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AbogadoGridControl.Location = New System.Drawing.Point(0, 0)
        Me.AbogadoGridControl.MainView = Me.GridView1
        Me.AbogadoGridControl.Name = "AbogadoGridControl"
        Me.AbogadoGridControl.Size = New System.Drawing.Size(698, 400)
        Me.AbogadoGridControl.TabIndex = 1
        Me.AbogadoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.SteelBlue
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colabogadoId, Me.colnombres, Me.GridColumn1, Me.colapellidos, Me.coltelefono, Me.coldireccion, Me.colcodigoAbogado, Me.colcorreo})
        Me.GridView1.GridControl = Me.AbogadoGridControl
        Me.GridView1.GroupPanelText = " "
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.PaintStyleName = "WindowsXP"
        '
        'colabogadoId
        '
        Me.colabogadoId.Caption = "ID"
        Me.colabogadoId.FieldName = "abogadoId"
        Me.colabogadoId.Name = "colabogadoId"
        Me.colabogadoId.OptionsColumn.ReadOnly = True
        Me.colabogadoId.Visible = True
        Me.colabogadoId.VisibleIndex = 0
        Me.colabogadoId.Width = 45
        '
        'colnombres
        '
        Me.colnombres.Caption = "NOMBRES"
        Me.colnombres.FieldName = "nombres"
        Me.colnombres.Name = "colnombres"
        Me.colnombres.Visible = True
        Me.colnombres.VisibleIndex = 1
        Me.colnombres.Width = 93
        '
        'colapellidos
        '
        Me.colapellidos.Caption = "APELLIDOS"
        Me.colapellidos.FieldName = "apellidos"
        Me.colapellidos.Name = "colapellidos"
        Me.colapellidos.Visible = True
        Me.colapellidos.VisibleIndex = 3
        Me.colapellidos.Width = 102
        '
        'coltelefono
        '
        Me.coltelefono.Caption = "TELEFONO"
        Me.coltelefono.FieldName = "telefono"
        Me.coltelefono.Name = "coltelefono"
        Me.coltelefono.Visible = True
        Me.coltelefono.VisibleIndex = 4
        Me.coltelefono.Width = 102
        '
        'coldireccion
        '
        Me.coldireccion.Caption = "DIRECCION"
        Me.coldireccion.FieldName = "direccion"
        Me.coldireccion.Name = "coldireccion"
        Me.coldireccion.Visible = True
        Me.coldireccion.VisibleIndex = 5
        Me.coldireccion.Width = 102
        '
        'colcodigoAbogado
        '
        Me.colcodigoAbogado.Caption = "CODIGO"
        Me.colcodigoAbogado.FieldName = "codigoAbogado"
        Me.colcodigoAbogado.Name = "colcodigoAbogado"
        Me.colcodigoAbogado.Visible = True
        Me.colcodigoAbogado.VisibleIndex = 6
        Me.colcodigoAbogado.Width = 102
        '
        'colcorreo
        '
        Me.colcorreo.Caption = "CORREO"
        Me.colcorreo.FieldName = "correo"
        Me.colcorreo.Name = "colcorreo"
        Me.colcorreo.Visible = True
        Me.colcorreo.VisibleIndex = 7
        Me.colcorreo.Width = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LISTAS DE ABOGADO AGOGADOS"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ESTADO"
        Me.GridColumn1.FieldName = "estado"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 35
        '
        'listAbogados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 400)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AbogadoGridControl)
        Me.Name = "listAbogados"
        Me.Text = "LISTA DE ABOGADOS"
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbogadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbogadoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents AbogadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbogadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.AbogadoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents AbogadoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colabogadoId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colapellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcodigoAbogado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcorreo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
