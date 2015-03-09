<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class creditos
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
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New creditosHipotecarios.DataSetAMCProduccionTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager()
        Me.ClienteGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colccodofi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcnomcli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcnudoci = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colccodact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colccodcta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnmonsug = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colncuosug = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colntasint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnmoncuo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMora_int = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcestado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldfecsol = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetAMCProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetAMCProduccion
        '
        Me.DataSetAMCProduccion.DataSetName = "DataSetAMCProduccion"
        Me.DataSetAMCProduccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSetAMCProduccion
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CreditoTableAdapter = Nothing
        Me.TableAdapterManager.GastosTableAdapter = Nothing
        Me.TableAdapterManager.GrantiaHipotecariaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienteGridControl
        '
        Me.ClienteGridControl.DataSource = Me.ClienteBindingSource
        Me.ClienteGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClienteGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ClienteGridControl.MainView = Me.GridView1
        Me.ClienteGridControl.Name = "ClienteGridControl"
        Me.ClienteGridControl.Size = New System.Drawing.Size(900, 418)
        Me.ClienteGridControl.TabIndex = 0
        Me.ClienteGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colccodofi, Me.colcnomcli, Me.colcnudoci, Me.colccodact, Me.colccodcta, Me.colnmonsug, Me.colncuosug, Me.colntasint, Me.colnmoncuo, Me.colnMora_int, Me.colcestado, Me.coldfecsol})
        Me.GridView1.GridControl = Me.ClienteGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colccodofi
        '
        Me.colccodofi.FieldName = "ccodofi"
        Me.colccodofi.Name = "colccodofi"
        Me.colccodofi.Visible = True
        Me.colccodofi.VisibleIndex = 0
        '
        'colcnomcli
        '
        Me.colcnomcli.FieldName = "cnomcli"
        Me.colcnomcli.Name = "colcnomcli"
        Me.colcnomcli.Visible = True
        Me.colcnomcli.VisibleIndex = 1
        '
        'colcnudoci
        '
        Me.colcnudoci.FieldName = "cnudoci"
        Me.colcnudoci.Name = "colcnudoci"
        Me.colcnudoci.Visible = True
        Me.colcnudoci.VisibleIndex = 2
        '
        'colccodact
        '
        Me.colccodact.FieldName = "ccodact"
        Me.colccodact.Name = "colccodact"
        Me.colccodact.Visible = True
        Me.colccodact.VisibleIndex = 3
        '
        'colccodcta
        '
        Me.colccodcta.FieldName = "ccodcta"
        Me.colccodcta.Name = "colccodcta"
        Me.colccodcta.Visible = True
        Me.colccodcta.VisibleIndex = 4
        '
        'colnmonsug
        '
        Me.colnmonsug.FieldName = "nmonsug"
        Me.colnmonsug.Name = "colnmonsug"
        Me.colnmonsug.Visible = True
        Me.colnmonsug.VisibleIndex = 5
        '
        'colncuosug
        '
        Me.colncuosug.FieldName = "ncuosug"
        Me.colncuosug.Name = "colncuosug"
        Me.colncuosug.Visible = True
        Me.colncuosug.VisibleIndex = 6
        '
        'colntasint
        '
        Me.colntasint.FieldName = "ntasint"
        Me.colntasint.Name = "colntasint"
        Me.colntasint.Visible = True
        Me.colntasint.VisibleIndex = 7
        '
        'colnmoncuo
        '
        Me.colnmoncuo.FieldName = "nmoncuo"
        Me.colnmoncuo.Name = "colnmoncuo"
        Me.colnmoncuo.Visible = True
        Me.colnmoncuo.VisibleIndex = 8
        '
        'colnMora_int
        '
        Me.colnMora_int.FieldName = "nMora_int"
        Me.colnMora_int.Name = "colnMora_int"
        Me.colnMora_int.Visible = True
        Me.colnMora_int.VisibleIndex = 9
        '
        'colcestado
        '
        Me.colcestado.FieldName = "cestado"
        Me.colcestado.Name = "colcestado"
        Me.colcestado.Visible = True
        Me.colcestado.VisibleIndex = 10
        '
        'coldfecsol
        '
        Me.coldfecsol.FieldName = "dfecsol"
        Me.coldfecsol.Name = "coldfecsol"
        Me.coldfecsol.Visible = True
        Me.coldfecsol.VisibleIndex = 11
        '
        'creditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 418)
        Me.Controls.Add(Me.ClienteGridControl)
        Me.Name = "creditos"
        Me.Text = "creditos"
        CType(Me.DataSetAMCProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetAMCProduccion As creditosHipotecarios.DataSetAMCProduccion
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As creditosHipotecarios.DataSetAMCProduccionTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager
    Friend WithEvents ClienteGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colccodofi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcnomcli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcnudoci As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colccodact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colccodcta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnmonsug As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colncuosug As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colntasint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnmoncuo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMora_int As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcestado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldfecsol As DevExpress.XtraGrid.Columns.GridColumn
End Class
