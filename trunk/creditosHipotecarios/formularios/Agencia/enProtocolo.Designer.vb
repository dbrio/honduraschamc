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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AGREGARNOTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaEstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaEestadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCreditosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HipotecaEstadoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEstadoTableAdapter()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrestamoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.prestamoTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.HipotecaEestadoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhipotecaEstadoId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrnpCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltasaInteres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaEestadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PrestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaEstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HipotecaEestadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCreditosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.AgenciaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CargoTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EventoTableAdapter = Nothing
        Me.TableAdapterManager.hipotecaEstadoTableAdapter = Nothing
        Me.TableAdapterManager.HipotecaTableAdapter = Nothing
        Me.TableAdapterManager.MemoTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGREGARNOTAToolStripMenuItem, Me.RegresarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 48)
        '
        'AGREGARNOTAToolStripMenuItem
        '
        Me.AGREGARNOTAToolStripMenuItem.Name = "AGREGARNOTAToolStripMenuItem"
        Me.AGREGARNOTAToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AGREGARNOTAToolStripMenuItem.Text = "AGREGAR NOTA"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RegresarToolStripMenuItem.Text = "REGRESAR"
        Me.RegresarToolStripMenuItem.Visible = False
        '
        'PrestamoBindingSource
        '
        Me.PrestamoBindingSource.DataMember = "prestamo"
        Me.PrestamoBindingSource.DataSource = Me.DataSetCreditos
        '
        'HipotecaEstadoBindingSource
        '
        Me.HipotecaEstadoBindingSource.DataMember = "hipotecaEstado"
        Me.HipotecaEstadoBindingSource.DataSource = Me.DataSetCreditos
        '
        'HipotecaEestadoBindingSource1
        '
        Me.HipotecaEestadoBindingSource1.DataMember = "hipotecaEestado"
        Me.HipotecaEestadoBindingSource1.DataSource = Me.DataSetCreditos
        '
        'DataSetCreditosBindingSource
        '
        Me.DataSetCreditosBindingSource.DataSource = Me.DataSetCreditos
        Me.DataSetCreditosBindingSource.Position = 0
        '
        'HipotecaEstadoTableAdapter
        '
        Me.HipotecaEstadoTableAdapter.ClearBeforeFill = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'PrestamoTableAdapter
        '
        Me.PrestamoTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(12, 9)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxBuscar.TabIndex = 6
        '
        'HipotecaEestadoGridControl
        '
        Me.HipotecaEestadoGridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.HipotecaEestadoGridControl.DataSource = Me.HipotecaEestadoBindingSource
        Me.HipotecaEestadoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HipotecaEestadoGridControl.Location = New System.Drawing.Point(0, 0)
        Me.HipotecaEestadoGridControl.MainView = Me.GridView1
        Me.HipotecaEestadoGridControl.Name = "HipotecaEestadoGridControl"
        Me.HipotecaEestadoGridControl.Size = New System.Drawing.Size(861, 489)
        Me.HipotecaEestadoGridControl.TabIndex = 5
        Me.HipotecaEestadoGridControl.UseEmbeddedNavigator = True
        Me.HipotecaEestadoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colAgencia, Me.colhipotecaEstadoId, Me.colnombreCliente, Me.colrnpCliente, Me.colmonto, Me.coltasaInteres, Me.coldescripcion})
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
        Me.GridView1.PaintStyleName = "WindowsXP"
        Me.GridView1.RowHeight = 30
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "AGENCIA"
        Me.GridColumn1.FieldName = "nombreAgencia"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'colAgencia
        '
        Me.colAgencia.Caption = "AGE"
        Me.colAgencia.FieldName = "codigoAgencia"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.Visible = True
        Me.colAgencia.VisibleIndex = 7
        Me.colAgencia.Width = 29
        '
        'colhipotecaEstadoId
        '
        Me.colhipotecaEstadoId.Caption = "Id"
        Me.colhipotecaEstadoId.MinWidth = 10
        Me.colhipotecaEstadoId.Name = "colhipotecaEstadoId"
        Me.colhipotecaEstadoId.Visible = True
        Me.colhipotecaEstadoId.VisibleIndex = 6
        Me.colhipotecaEstadoId.Width = 16
        '
        'colnombreCliente
        '
        Me.colnombreCliente.Caption = "NOMBRE DEL CLIENTE"
        Me.colnombreCliente.FieldName = "nombreCliente"
        Me.colnombreCliente.Name = "colnombreCliente"
        Me.colnombreCliente.Visible = True
        Me.colnombreCliente.VisibleIndex = 1
        Me.colnombreCliente.Width = 176
        '
        'colrnpCliente
        '
        Me.colrnpCliente.Caption = "IDENTIDAD"
        Me.colrnpCliente.FieldName = "rnpCliente"
        Me.colrnpCliente.Name = "colrnpCliente"
        Me.colrnpCliente.Visible = True
        Me.colrnpCliente.VisibleIndex = 2
        Me.colrnpCliente.Width = 91
        '
        'colmonto
        '
        Me.colmonto.Caption = "MONTO"
        Me.colmonto.FieldName = "monto"
        Me.colmonto.Name = "colmonto"
        Me.colmonto.Visible = True
        Me.colmonto.VisibleIndex = 3
        Me.colmonto.Width = 60
        '
        'coltasaInteres
        '
        Me.coltasaInteres.Caption = "TASA DE INTERES"
        Me.coltasaInteres.FieldName = "tasaInteres"
        Me.coltasaInteres.Name = "coltasaInteres"
        Me.coltasaInteres.Visible = True
        Me.coltasaInteres.VisibleIndex = 4
        Me.coltasaInteres.Width = 62
        '
        'coldescripcion
        '
        Me.coldescripcion.Caption = "DESCRIPCION"
        Me.coldescripcion.FieldName = "descripcion"
        Me.coldescripcion.Name = "coldescripcion"
        Me.coldescripcion.Visible = True
        Me.coldescripcion.VisibleIndex = 5
        Me.coldescripcion.Width = 417
        '
        'enProtocolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 489)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.HipotecaEestadoGridControl)
        Me.Name = "enProtocolo"
        Me.Text = "Protocolo"
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaEestadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PrestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaEstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaEestadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCreditosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HipotecaEestadoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents HipotecaEestadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaEestadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEestadoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents DataSetCreditosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaEestadoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaEstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HipotecaEstadoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.hipotecaEstadoTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AGREGARNOTAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PrestamoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrestamoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.prestamoTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents HipotecaEestadoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhipotecaEstadoId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrnpCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltasaInteres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescripcion As DevExpress.XtraGrid.Columns.GridColumn
End Class
