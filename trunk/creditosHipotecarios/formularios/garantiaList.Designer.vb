<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class garantiaList
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
        Me.DataSetAMCProduccion = New creditosHipotecarios.DataSetAMCProduccion()
        Me.GrantiaHipotecariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrantiaHipotecariaTableAdapter = New creditosHipotecarios.DataSetAMCProduccionTableAdapters.GrantiaHipotecariaTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager()
        Me.GrantiaHipotecariaGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcod_garant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfecinsgar2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescripcio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalpericia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colowngarant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelCodigo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prestamoNumero = New System.Windows.Forms.Label()
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
        Me.TableAdapterManager.CreditoTableAdapter = Nothing
        Me.TableAdapterManager.GastosTableAdapter = Nothing
        Me.TableAdapterManager.GrantiaHipotecariaTableAdapter = Me.GrantiaHipotecariaTableAdapter
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GrantiaHipotecariaGridControl
        '
        Me.GrantiaHipotecariaGridControl.DataSource = Me.GrantiaHipotecariaBindingSource
        Me.GrantiaHipotecariaGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrantiaHipotecariaGridControl.Location = New System.Drawing.Point(0, 40)
        Me.GrantiaHipotecariaGridControl.MainView = Me.GridView1
        Me.GrantiaHipotecariaGridControl.Name = "GrantiaHipotecariaGridControl"
        Me.GrantiaHipotecariaGridControl.Size = New System.Drawing.Size(1128, 431)
        Me.GrantiaHipotecariaGridControl.TabIndex = 2
        Me.GrantiaHipotecariaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.SlateGray
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcod_garant, Me.colfecinsgar2, Me.coldescripcio, Me.colvalpericia, Me.colowngarant})
        Me.GridView1.GridControl = Me.GrantiaHipotecariaGridControl
        Me.GridView1.GroupPanelText = " "
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.PaintStyleName = "WindowsXP"
        '
        'colcod_garant
        '
        Me.colcod_garant.Caption = "GARANTÍA"
        Me.colcod_garant.FieldName = "cod_garant"
        Me.colcod_garant.Name = "colcod_garant"
        Me.colcod_garant.Visible = True
        Me.colcod_garant.VisibleIndex = 0
        '
        'colfecinsgar2
        '
        Me.colfecinsgar2.Caption = "FECHA INGRESO"
        Me.colfecinsgar2.FieldName = "fecinsgar2"
        Me.colfecinsgar2.Name = "colfecinsgar2"
        Me.colfecinsgar2.Visible = True
        Me.colfecinsgar2.VisibleIndex = 1
        Me.colfecinsgar2.Width = 100
        '
        'coldescripcio
        '
        Me.coldescripcio.Caption = "DESCRIPCIÓN"
        Me.coldescripcio.FieldName = "descripcio"
        Me.coldescripcio.Name = "coldescripcio"
        Me.coldescripcio.Visible = True
        Me.coldescripcio.VisibleIndex = 2
        Me.coldescripcio.Width = 650
        '
        'colvalpericia
        '
        Me.colvalpericia.Caption = "VALOR REMATE"
        Me.colvalpericia.FieldName = "valpericia"
        Me.colvalpericia.Name = "colvalpericia"
        Me.colvalpericia.Visible = True
        Me.colvalpericia.VisibleIndex = 3
        Me.colvalpericia.Width = 95
        '
        'colowngarant
        '
        Me.colowngarant.Caption = "PROPIETARIO"
        Me.colowngarant.FieldName = "owngarant"
        Me.colowngarant.Name = "colowngarant"
        Me.colowngarant.Visible = True
        Me.colowngarant.VisibleIndex = 4
        Me.colowngarant.Width = 285
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.SlateGray
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.Color.White
        Me.LabelNombre.Location = New System.Drawing.Point(25, 101)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(93, 24)
        Me.LabelNombre.TabIndex = 3
        Me.LabelNombre.Text = "NOMBRE"
        '
        'LabelCodigo
        '
        Me.LabelCodigo.AutoSize = True
        Me.LabelCodigo.BackColor = System.Drawing.Color.SlateGray
        Me.LabelCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCodigo.ForeColor = System.Drawing.Color.White
        Me.LabelCodigo.Location = New System.Drawing.Point(692, 101)
        Me.LabelCodigo.Name = "LabelCodigo"
        Me.LabelCodigo.Size = New System.Drawing.Size(89, 24)
        Me.LabelCodigo.TabIndex = 4
        Me.LabelCodigo.Text = "CLIENTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(275, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PRESTAMO N# "
        '
        'prestamoNumero
        '
        Me.prestamoNumero.AutoSize = True
        Me.prestamoNumero.BackColor = System.Drawing.Color.SlateGray
        Me.prestamoNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prestamoNumero.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.prestamoNumero.Location = New System.Drawing.Point(476, 50)
        Me.prestamoNumero.Name = "prestamoNumero"
        Me.prestamoNumero.Size = New System.Drawing.Size(169, 39)
        Me.prestamoNumero.TabIndex = 6
        Me.prestamoNumero.Text = "NOMBRE"
        '
        'garantiaList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1128, 471)
        Me.Controls.Add(Me.prestamoNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCodigo)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.GrantiaHipotecariaGridControl)
        Me.Name = "garantiaList"
        Me.Text = "AMC | CREDITOS"
        Me.Controls.SetChildIndex(Me.GrantiaHipotecariaGridControl, 0)
        Me.Controls.SetChildIndex(Me.LabelNombre, 0)
        Me.Controls.SetChildIndex(Me.LabelCodigo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.prestamoNumero, 0)
        CType(Me.DataSetAMCProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrantiaHipotecariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrantiaHipotecariaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetAMCProduccion As creditosHipotecarios.DataSetAMCProduccion
    Friend WithEvents GrantiaHipotecariaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrantiaHipotecariaTableAdapter As creditosHipotecarios.DataSetAMCProduccionTableAdapters.GrantiaHipotecariaTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetAMCProduccionTableAdapters.TableAdapterManager
    Friend WithEvents GrantiaHipotecariaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcod_garant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfecinsgar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescripcio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalpericia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colowngarant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelCodigo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prestamoNumero As System.Windows.Forms.Label
End Class
