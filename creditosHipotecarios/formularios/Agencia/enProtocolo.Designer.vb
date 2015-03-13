<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enProtocolo
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
        Me.HipotecaEestadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaEestadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEestadoTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.HipotecaEestadoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrnpCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltasaInteres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaEestadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaEestadoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HipotecaEestadoBindingSource
        '
        Me.HipotecaEestadoBindingSource.DataMember = "hipotecaEestado"
        Me.HipotecaEestadoBindingSource.DataSource = Me.DataSetCreditos
        '
        'HipotecaEestadoTableAdapter
        '
        Me.HipotecaEestadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbogadoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EventoTableAdapter = Nothing
        Me.TableAdapterManager.hipotecaEstadoTableAdapter = Nothing
        Me.TableAdapterManager.HipotecaTableAdapter = Nothing
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'HipotecaEestadoGridControl
        '
        Me.HipotecaEestadoGridControl.DataSource = Me.HipotecaEestadoBindingSource
        Me.HipotecaEestadoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HipotecaEestadoGridControl.Location = New System.Drawing.Point(0, 0)
        Me.HipotecaEestadoGridControl.MainView = Me.GridView1
        Me.HipotecaEestadoGridControl.Name = "HipotecaEestadoGridControl"
        Me.HipotecaEestadoGridControl.Size = New System.Drawing.Size(861, 489)
        Me.HipotecaEestadoGridControl.TabIndex = 2
        Me.HipotecaEestadoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnombreCliente, Me.colrnpCliente, Me.colmonto, Me.coltasaInteres, Me.coldescripcion})
        Me.GridView1.FixedLineWidth = 1
        Me.GridView1.GridControl = Me.HipotecaEestadoGridControl
        Me.GridView1.GroupPanelText = "  "
        Me.GridView1.GroupRowHeight = 2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "WindowsXP"
        Me.GridView1.RowHeight = 40
        '
        'colnombreCliente
        '
        Me.colnombreCliente.Caption = "NOMBRE DEL CLIENTE"
        Me.colnombreCliente.FieldName = "nombreCliente"
        Me.colnombreCliente.Name = "colnombreCliente"
        Me.colnombreCliente.Visible = True
        Me.colnombreCliente.VisibleIndex = 0
        Me.colnombreCliente.Width = 160
        '
        'colrnpCliente
        '
        Me.colrnpCliente.Caption = "IDENTIDAD"
        Me.colrnpCliente.FieldName = "rnpCliente"
        Me.colrnpCliente.Name = "colrnpCliente"
        Me.colrnpCliente.Visible = True
        Me.colrnpCliente.VisibleIndex = 1
        Me.colrnpCliente.Width = 100
        '
        'colmonto
        '
        Me.colmonto.Caption = "MONTO"
        Me.colmonto.FieldName = "monto"
        Me.colmonto.Name = "colmonto"
        Me.colmonto.Visible = True
        Me.colmonto.VisibleIndex = 2
        Me.colmonto.Width = 50
        '
        'coltasaInteres
        '
        Me.coltasaInteres.Caption = "TASA DE INTERES"
        Me.coltasaInteres.FieldName = "tasaInteres"
        Me.coltasaInteres.Name = "coltasaInteres"
        Me.coltasaInteres.Visible = True
        Me.coltasaInteres.VisibleIndex = 3
        Me.coltasaInteres.Width = 70
        '
        'coldescripcion
        '
        Me.coldescripcion.Caption = "DESCRIPCION"
        Me.coldescripcion.FieldName = "descripcion"
        Me.coldescripcion.Name = "coldescripcion"
        Me.coldescripcion.Visible = True
        Me.coldescripcion.VisibleIndex = 4
        Me.coldescripcion.Width = 462
        '
        'enProtocolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 489)
        Me.Controls.Add(Me.HipotecaEestadoGridControl)
        Me.Name = "enProtocolo"
        Me.Text = "Protocolo"
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaEestadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaEestadoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents HipotecaEestadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaEestadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEestadoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents HipotecaEestadoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrnpCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltasaInteres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescripcion As DevExpress.XtraGrid.Columns.GridColumn
End Class
