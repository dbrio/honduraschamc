<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class garantias
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
        Me.DataSetAMCProduccion = New creditosHipotecarios.DataSetAMCProduccion()
        Me.GrantiaHipotecariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrantiaHipotecariaTableAdapter = New creditosHipotecarios.DataSetAMCProduccionTableAdapters.GrantiaHipotecariaTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager()
        Me.GrantiaHipotecariaGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcod_garant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnumclien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnomdeudor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfecinsgar2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescripcio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalpericia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colowngarant = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetAMCProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrantiaHipotecariaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrantiaHipotecariaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetAMCProduccion
        '
        Me.DataSetAMCProduccion.DataSetName = "DataSetAMCProduccion"
        Me.DataSetAMCProduccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrantiaHipotecariaBindingSource
        '
        Me.GrantiaHipotecariaBindingSource.DataMember = "GrantiaHipotecaria"
        Me.GrantiaHipotecariaBindingSource.DataSource = Me.DataSetAMCProduccion
        '
        'GrantiaHipotecariaTableAdapter
        '
        Me.GrantiaHipotecariaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.CreditoTableAdapter = Nothing
        Me.TableAdapterManager.GastosTableAdapter = Nothing
        Me.TableAdapterManager.GrantiaHipotecariaTableAdapter = Me.GrantiaHipotecariaTableAdapter
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GrantiaHipotecariaGridControl
        '
        Me.GrantiaHipotecariaGridControl.DataSource = Me.GrantiaHipotecariaBindingSource
        Me.GrantiaHipotecariaGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrantiaHipotecariaGridControl.Location = New System.Drawing.Point(0, 0)
        Me.GrantiaHipotecariaGridControl.MainView = Me.GridView1
        Me.GrantiaHipotecariaGridControl.Name = "GrantiaHipotecariaGridControl"
        Me.GrantiaHipotecariaGridControl.Size = New System.Drawing.Size(826, 477)
        Me.GrantiaHipotecariaGridControl.TabIndex = 1
        Me.GrantiaHipotecariaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcod_garant, Me.colnumclien, Me.colnomdeudor, Me.colfecinsgar2, Me.coldescripcio, Me.colvalpericia, Me.colowngarant})
        Me.GridView1.GridControl = Me.GrantiaHipotecariaGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colcod_garant
        '
        Me.colcod_garant.Caption = "Garantía"
        Me.colcod_garant.FieldName = "cod_garant"
        Me.colcod_garant.Name = "colcod_garant"
        Me.colcod_garant.Visible = True
        Me.colcod_garant.VisibleIndex = 0
        Me.colcod_garant.Width = 35
        '
        'colnumclien
        '
        Me.colnumclien.Caption = "Codigo del Cliente"
        Me.colnumclien.FieldName = "numclien"
        Me.colnumclien.Name = "colnumclien"
        Me.colnumclien.Visible = True
        Me.colnumclien.VisibleIndex = 1
        Me.colnumclien.Width = 58
        '
        'colnomdeudor
        '
        Me.colnomdeudor.Caption = "Nombre del Cliente"
        Me.colnomdeudor.FieldName = "nomdeudor"
        Me.colnomdeudor.Name = "colnomdeudor"
        Me.colnomdeudor.Visible = True
        Me.colnomdeudor.VisibleIndex = 2
        Me.colnomdeudor.Width = 155
        '
        'colfecinsgar2
        '
        Me.colfecinsgar2.Caption = "Fecha de Ingreso"
        Me.colfecinsgar2.FieldName = "fecinsgar2"
        Me.colfecinsgar2.Name = "colfecinsgar2"
        Me.colfecinsgar2.Visible = True
        Me.colfecinsgar2.VisibleIndex = 3
        Me.colfecinsgar2.Width = 55
        '
        'coldescripcio
        '
        Me.coldescripcio.Caption = "Descripción"
        Me.coldescripcio.FieldName = "descripcio"
        Me.coldescripcio.Name = "coldescripcio"
        Me.coldescripcio.Visible = True
        Me.coldescripcio.VisibleIndex = 4
        Me.coldescripcio.Width = 374
        '
        'colvalpericia
        '
        Me.colvalpericia.Caption = "Valor de Remate"
        Me.colvalpericia.FieldName = "valpericia"
        Me.colvalpericia.Name = "colvalpericia"
        Me.colvalpericia.Visible = True
        Me.colvalpericia.VisibleIndex = 5
        Me.colvalpericia.Width = 46
        '
        'colowngarant
        '
        Me.colowngarant.Caption = "Propietario"
        Me.colowngarant.FieldName = "owngarant"
        Me.colowngarant.Name = "colowngarant"
        Me.colowngarant.Visible = True
        Me.colowngarant.VisibleIndex = 6
        Me.colowngarant.Width = 82
        '
        'addHipoteca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 477)
        Me.Controls.Add(Me.GrantiaHipotecariaGridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "addHipoteca"
        Me.Text = "Agregar Hipoteca"
        CType(Me.DataSetAMCProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrantiaHipotecariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrantiaHipotecariaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetAMCProduccion As creditosHipotecarios.DataSetAMCProduccion
    Friend WithEvents GrantiaHipotecariaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrantiaHipotecariaTableAdapter As creditosHipotecarios.DataSetAMCProduccionTableAdapters.GrantiaHipotecariaTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager
    Friend WithEvents GrantiaHipotecariaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcod_garant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnumclien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnomdeudor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfecinsgar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescripcio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalpericia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colowngarant As DevExpress.XtraGrid.Columns.GridColumn
End Class
