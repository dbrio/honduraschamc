<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seguimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(seguimiento))
        Dim PrestamoIdLabel As System.Windows.Forms.Label
        Dim EstadoIdLabel As System.Windows.Forms.Label
        Dim NombreAgenciaLabel As System.Windows.Forms.Label
        Dim NombreClienteLabel As System.Windows.Forms.Label
        Dim RnpClienteLabel As System.Windows.Forms.Label
        Dim NombrePropietarioLabel As System.Windows.Forms.Label
        Dim RnpPropietarioLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim PlazoLabel As System.Windows.Forms.Label
        Dim TasaInteresLabel As System.Windows.Forms.Label
        Dim CuotaPagarLabel As System.Windows.Forms.Label
        Dim InteresMoraLabel As System.Windows.Forms.Label
        Dim ValorRemateLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim AsientoLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim NumeroIpLabel As System.Windows.Forms.Label
        Dim TomoLabel As System.Windows.Forms.Label
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.SeguimientoBindingSource = New System.Windows.Forms.BindingSource()
        Me.SeguimientoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.seguimientoTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.SeguimientoBindingNavigator = New System.Windows.Forms.BindingNavigator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SeguimientoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdPrestamoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdPrestamoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrestamoIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.EstadoIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.NombreAgenciaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombreClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RnpClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombrePropietarioTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RnpPropietarioTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MontoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PlazoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TasaInteresSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CuotaPagarSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.InteresMoraSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ValorRemateSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DescripcionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombresTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidosTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AsientoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MatriculaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NumeroIpTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TomoTextEdit = New DevExpress.XtraEditors.TextEdit()
        PrestamoIdLabel = New System.Windows.Forms.Label()
        EstadoIdLabel = New System.Windows.Forms.Label()
        NombreAgenciaLabel = New System.Windows.Forms.Label()
        NombreClienteLabel = New System.Windows.Forms.Label()
        RnpClienteLabel = New System.Windows.Forms.Label()
        NombrePropietarioLabel = New System.Windows.Forms.Label()
        RnpPropietarioLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        PlazoLabel = New System.Windows.Forms.Label()
        TasaInteresLabel = New System.Windows.Forms.Label()
        CuotaPagarLabel = New System.Windows.Forms.Label()
        InteresMoraLabel = New System.Windows.Forms.Label()
        ValorRemateLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        AsientoLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        NumeroIpLabel = New System.Windows.Forms.Label()
        TomoLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguimientoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SeguimientoBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.PrestamoIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreAgenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnpClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombrePropietarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnpPropietarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MontoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlazoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasaInteresSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuotaPagarSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresMoraSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValorRemateSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsientoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroIpTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TomoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeguimientoBindingSource
        '
        Me.SeguimientoBindingSource.DataMember = "seguimiento"
        Me.SeguimientoBindingSource.DataSource = Me.DataSetCreditos
        '
        'SeguimientoTableAdapter
        '
        Me.SeguimientoTableAdapter.ClearBeforeFill = True
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
        'SeguimientoBindingNavigator
        '
        Me.SeguimientoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SeguimientoBindingNavigator.BindingSource = Me.SeguimientoBindingSource
        Me.SeguimientoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SeguimientoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SeguimientoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SeguimientoBindingNavigatorSaveItem})
        Me.SeguimientoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SeguimientoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SeguimientoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SeguimientoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SeguimientoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SeguimientoBindingNavigator.Name = "SeguimientoBindingNavigator"
        Me.SeguimientoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SeguimientoBindingNavigator.Size = New System.Drawing.Size(953, 25)
        Me.SeguimientoBindingNavigator.TabIndex = 0
        Me.SeguimientoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'SeguimientoBindingNavigatorSaveItem
        '
        Me.SeguimientoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SeguimientoBindingNavigatorSaveItem.Enabled = False
        Me.SeguimientoBindingNavigatorSaveItem.Image = CType(resources.GetObject("SeguimientoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SeguimientoBindingNavigatorSaveItem.Name = "SeguimientoBindingNavigatorSaveItem"
        Me.SeguimientoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.SeguimientoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdPrestamoToolStripLabel, Me.IdPrestamoToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(953, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'IdPrestamoToolStripLabel
        '
        Me.IdPrestamoToolStripLabel.Name = "IdPrestamoToolStripLabel"
        Me.IdPrestamoToolStripLabel.Size = New System.Drawing.Size(70, 22)
        Me.IdPrestamoToolStripLabel.Text = "idPrestamo:"
        '
        'IdPrestamoToolStripTextBox
        '
        Me.IdPrestamoToolStripTextBox.Name = "IdPrestamoToolStripTextBox"
        Me.IdPrestamoToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 19)
        Me.FillToolStripButton.Text = "Fill"
        '
        'PrestamoIdLabel
        '
        PrestamoIdLabel.AutoSize = True
        PrestamoIdLabel.Location = New System.Drawing.Point(297, 101)
        PrestamoIdLabel.Name = "PrestamoIdLabel"
        PrestamoIdLabel.Size = New System.Drawing.Size(65, 13)
        PrestamoIdLabel.TabIndex = 2
        PrestamoIdLabel.Text = "prestamo Id:"
        '
        'PrestamoIdSpinEdit
        '
        Me.PrestamoIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "prestamoId", True))
        Me.PrestamoIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PrestamoIdSpinEdit.Location = New System.Drawing.Point(401, 98)
        Me.PrestamoIdSpinEdit.Name = "PrestamoIdSpinEdit"
        Me.PrestamoIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrestamoIdSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.PrestamoIdSpinEdit.TabIndex = 3
        '
        'EstadoIdLabel
        '
        EstadoIdLabel.AutoSize = True
        EstadoIdLabel.Location = New System.Drawing.Point(297, 127)
        EstadoIdLabel.Name = "EstadoIdLabel"
        EstadoIdLabel.Size = New System.Drawing.Size(54, 13)
        EstadoIdLabel.TabIndex = 4
        EstadoIdLabel.Text = "estado Id:"
        '
        'EstadoIdSpinEdit
        '
        Me.EstadoIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "estadoId", True))
        Me.EstadoIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.EstadoIdSpinEdit.Location = New System.Drawing.Point(401, 124)
        Me.EstadoIdSpinEdit.Name = "EstadoIdSpinEdit"
        Me.EstadoIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstadoIdSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.EstadoIdSpinEdit.TabIndex = 5
        '
        'NombreAgenciaLabel
        '
        NombreAgenciaLabel.AutoSize = True
        NombreAgenciaLabel.Location = New System.Drawing.Point(297, 153)
        NombreAgenciaLabel.Name = "NombreAgenciaLabel"
        NombreAgenciaLabel.Size = New System.Drawing.Size(87, 13)
        NombreAgenciaLabel.TabIndex = 6
        NombreAgenciaLabel.Text = "nombre Agencia:"
        '
        'NombreAgenciaTextEdit
        '
        Me.NombreAgenciaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "nombreAgencia", True))
        Me.NombreAgenciaTextEdit.Location = New System.Drawing.Point(401, 150)
        Me.NombreAgenciaTextEdit.Name = "NombreAgenciaTextEdit"
        Me.NombreAgenciaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NombreAgenciaTextEdit.TabIndex = 7
        '
        'NombreClienteLabel
        '
        NombreClienteLabel.AutoSize = True
        NombreClienteLabel.Location = New System.Drawing.Point(297, 179)
        NombreClienteLabel.Name = "NombreClienteLabel"
        NombreClienteLabel.Size = New System.Drawing.Size(80, 13)
        NombreClienteLabel.TabIndex = 8
        NombreClienteLabel.Text = "nombre Cliente:"
        '
        'NombreClienteTextEdit
        '
        Me.NombreClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "nombreCliente", True))
        Me.NombreClienteTextEdit.Location = New System.Drawing.Point(401, 176)
        Me.NombreClienteTextEdit.Name = "NombreClienteTextEdit"
        Me.NombreClienteTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NombreClienteTextEdit.TabIndex = 9
        '
        'RnpClienteLabel
        '
        RnpClienteLabel.AutoSize = True
        RnpClienteLabel.Location = New System.Drawing.Point(297, 205)
        RnpClienteLabel.Name = "RnpClienteLabel"
        RnpClienteLabel.Size = New System.Drawing.Size(60, 13)
        RnpClienteLabel.TabIndex = 10
        RnpClienteLabel.Text = "rnp Cliente:"
        '
        'RnpClienteTextEdit
        '
        Me.RnpClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "rnpCliente", True))
        Me.RnpClienteTextEdit.Location = New System.Drawing.Point(401, 202)
        Me.RnpClienteTextEdit.Name = "RnpClienteTextEdit"
        Me.RnpClienteTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.RnpClienteTextEdit.TabIndex = 11
        '
        'NombrePropietarioLabel
        '
        NombrePropietarioLabel.AutoSize = True
        NombrePropietarioLabel.Location = New System.Drawing.Point(297, 231)
        NombrePropietarioLabel.Name = "NombrePropietarioLabel"
        NombrePropietarioLabel.Size = New System.Drawing.Size(98, 13)
        NombrePropietarioLabel.TabIndex = 12
        NombrePropietarioLabel.Text = "nombre Propietario:"
        '
        'NombrePropietarioTextEdit
        '
        Me.NombrePropietarioTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "nombrePropietario", True))
        Me.NombrePropietarioTextEdit.Location = New System.Drawing.Point(401, 228)
        Me.NombrePropietarioTextEdit.Name = "NombrePropietarioTextEdit"
        Me.NombrePropietarioTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NombrePropietarioTextEdit.TabIndex = 13
        '
        'RnpPropietarioLabel
        '
        RnpPropietarioLabel.AutoSize = True
        RnpPropietarioLabel.Location = New System.Drawing.Point(297, 257)
        RnpPropietarioLabel.Name = "RnpPropietarioLabel"
        RnpPropietarioLabel.Size = New System.Drawing.Size(78, 13)
        RnpPropietarioLabel.TabIndex = 14
        RnpPropietarioLabel.Text = "rnp Propietario:"
        '
        'RnpPropietarioTextEdit
        '
        Me.RnpPropietarioTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "rnpPropietario", True))
        Me.RnpPropietarioTextEdit.Location = New System.Drawing.Point(401, 254)
        Me.RnpPropietarioTextEdit.Name = "RnpPropietarioTextEdit"
        Me.RnpPropietarioTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.RnpPropietarioTextEdit.TabIndex = 15
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(297, 283)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(39, 13)
        MontoLabel.TabIndex = 16
        MontoLabel.Text = "monto:"
        '
        'MontoSpinEdit
        '
        Me.MontoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "monto", True))
        Me.MontoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MontoSpinEdit.Location = New System.Drawing.Point(401, 280)
        Me.MontoSpinEdit.Name = "MontoSpinEdit"
        Me.MontoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MontoSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.MontoSpinEdit.TabIndex = 17
        '
        'PlazoLabel
        '
        PlazoLabel.AutoSize = True
        PlazoLabel.Location = New System.Drawing.Point(297, 309)
        PlazoLabel.Name = "PlazoLabel"
        PlazoLabel.Size = New System.Drawing.Size(35, 13)
        PlazoLabel.TabIndex = 18
        PlazoLabel.Text = "plazo:"
        '
        'PlazoSpinEdit
        '
        Me.PlazoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "plazo", True))
        Me.PlazoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PlazoSpinEdit.Location = New System.Drawing.Point(401, 306)
        Me.PlazoSpinEdit.Name = "PlazoSpinEdit"
        Me.PlazoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PlazoSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.PlazoSpinEdit.TabIndex = 19
        '
        'TasaInteresLabel
        '
        TasaInteresLabel.AutoSize = True
        TasaInteresLabel.Location = New System.Drawing.Point(297, 335)
        TasaInteresLabel.Name = "TasaInteresLabel"
        TasaInteresLabel.Size = New System.Drawing.Size(65, 13)
        TasaInteresLabel.TabIndex = 20
        TasaInteresLabel.Text = "tasa Interes:"
        '
        'TasaInteresSpinEdit
        '
        Me.TasaInteresSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "tasaInteres", True))
        Me.TasaInteresSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TasaInteresSpinEdit.Location = New System.Drawing.Point(401, 332)
        Me.TasaInteresSpinEdit.Name = "TasaInteresSpinEdit"
        Me.TasaInteresSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TasaInteresSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.TasaInteresSpinEdit.TabIndex = 21
        '
        'CuotaPagarLabel
        '
        CuotaPagarLabel.AutoSize = True
        CuotaPagarLabel.Location = New System.Drawing.Point(297, 361)
        CuotaPagarLabel.Name = "CuotaPagarLabel"
        CuotaPagarLabel.Size = New System.Drawing.Size(68, 13)
        CuotaPagarLabel.TabIndex = 22
        CuotaPagarLabel.Text = "cuota Pagar:"
        '
        'CuotaPagarSpinEdit
        '
        Me.CuotaPagarSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "cuotaPagar", True))
        Me.CuotaPagarSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CuotaPagarSpinEdit.Location = New System.Drawing.Point(401, 358)
        Me.CuotaPagarSpinEdit.Name = "CuotaPagarSpinEdit"
        Me.CuotaPagarSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CuotaPagarSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.CuotaPagarSpinEdit.TabIndex = 23
        '
        'InteresMoraLabel
        '
        InteresMoraLabel.AutoSize = True
        InteresMoraLabel.Location = New System.Drawing.Point(297, 387)
        InteresMoraLabel.Name = "InteresMoraLabel"
        InteresMoraLabel.Size = New System.Drawing.Size(68, 13)
        InteresMoraLabel.TabIndex = 24
        InteresMoraLabel.Text = "interes Mora:"
        '
        'InteresMoraSpinEdit
        '
        Me.InteresMoraSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "interesMora", True))
        Me.InteresMoraSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.InteresMoraSpinEdit.Location = New System.Drawing.Point(401, 384)
        Me.InteresMoraSpinEdit.Name = "InteresMoraSpinEdit"
        Me.InteresMoraSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InteresMoraSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.InteresMoraSpinEdit.TabIndex = 25
        '
        'ValorRemateLabel
        '
        ValorRemateLabel.AutoSize = True
        ValorRemateLabel.Location = New System.Drawing.Point(297, 413)
        ValorRemateLabel.Name = "ValorRemateLabel"
        ValorRemateLabel.Size = New System.Drawing.Size(73, 13)
        ValorRemateLabel.TabIndex = 26
        ValorRemateLabel.Text = "valor Remate:"
        '
        'ValorRemateSpinEdit
        '
        Me.ValorRemateSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "valorRemate", True))
        Me.ValorRemateSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ValorRemateSpinEdit.Location = New System.Drawing.Point(401, 410)
        Me.ValorRemateSpinEdit.Name = "ValorRemateSpinEdit"
        Me.ValorRemateSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ValorRemateSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.ValorRemateSpinEdit.TabIndex = 27
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(297, 439)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 28
        DescripcionLabel.Text = "descripcion:"
        '
        'DescripcionTextEdit
        '
        Me.DescripcionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "descripcion", True))
        Me.DescripcionTextEdit.Location = New System.Drawing.Point(401, 436)
        Me.DescripcionTextEdit.Name = "DescripcionTextEdit"
        Me.DescripcionTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextEdit.TabIndex = 29
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(297, 465)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(50, 13)
        NombresLabel.TabIndex = 30
        NombresLabel.Text = "nombres:"
        '
        'NombresTextEdit
        '
        Me.NombresTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "nombres", True))
        Me.NombresTextEdit.Location = New System.Drawing.Point(401, 462)
        Me.NombresTextEdit.Name = "NombresTextEdit"
        Me.NombresTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NombresTextEdit.TabIndex = 31
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(297, 491)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(51, 13)
        ApellidosLabel.TabIndex = 32
        ApellidosLabel.Text = "apellidos:"
        '
        'ApellidosTextEdit
        '
        Me.ApellidosTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "apellidos", True))
        Me.ApellidosTextEdit.Location = New System.Drawing.Point(401, 488)
        Me.ApellidosTextEdit.Name = "ApellidosTextEdit"
        Me.ApellidosTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ApellidosTextEdit.TabIndex = 33
        '
        'AsientoLabel
        '
        AsientoLabel.AutoSize = True
        AsientoLabel.Location = New System.Drawing.Point(297, 517)
        AsientoLabel.Name = "AsientoLabel"
        AsientoLabel.Size = New System.Drawing.Size(44, 13)
        AsientoLabel.TabIndex = 34
        AsientoLabel.Text = "asiento:"
        '
        'AsientoTextEdit
        '
        Me.AsientoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "asiento", True))
        Me.AsientoTextEdit.Location = New System.Drawing.Point(401, 514)
        Me.AsientoTextEdit.Name = "AsientoTextEdit"
        Me.AsientoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AsientoTextEdit.TabIndex = 35
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(297, 543)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(52, 13)
        MatriculaLabel.TabIndex = 36
        MatriculaLabel.Text = "matricula:"
        '
        'MatriculaTextEdit
        '
        Me.MatriculaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "matricula", True))
        Me.MatriculaTextEdit.Location = New System.Drawing.Point(401, 540)
        Me.MatriculaTextEdit.Name = "MatriculaTextEdit"
        Me.MatriculaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.MatriculaTextEdit.TabIndex = 37
        '
        'NumeroIpLabel
        '
        NumeroIpLabel.AutoSize = True
        NumeroIpLabel.Location = New System.Drawing.Point(297, 569)
        NumeroIpLabel.Name = "NumeroIpLabel"
        NumeroIpLabel.Size = New System.Drawing.Size(57, 13)
        NumeroIpLabel.TabIndex = 38
        NumeroIpLabel.Text = "numero Ip:"
        '
        'NumeroIpTextEdit
        '
        Me.NumeroIpTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "numeroIp", True))
        Me.NumeroIpTextEdit.Location = New System.Drawing.Point(401, 566)
        Me.NumeroIpTextEdit.Name = "NumeroIpTextEdit"
        Me.NumeroIpTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NumeroIpTextEdit.TabIndex = 39
        '
        'TomoLabel
        '
        TomoLabel.AutoSize = True
        TomoLabel.Location = New System.Drawing.Point(297, 595)
        TomoLabel.Name = "TomoLabel"
        TomoLabel.Size = New System.Drawing.Size(33, 13)
        TomoLabel.TabIndex = 40
        TomoLabel.Text = "tomo:"
        '
        'TomoTextEdit
        '
        Me.TomoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "tomo", True))
        Me.TomoTextEdit.Location = New System.Drawing.Point(401, 592)
        Me.TomoTextEdit.Name = "TomoTextEdit"
        Me.TomoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TomoTextEdit.TabIndex = 41
        '
        'seguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(953, 712)
        Me.Controls.Add(PrestamoIdLabel)
        Me.Controls.Add(Me.PrestamoIdSpinEdit)
        Me.Controls.Add(EstadoIdLabel)
        Me.Controls.Add(Me.EstadoIdSpinEdit)
        Me.Controls.Add(NombreAgenciaLabel)
        Me.Controls.Add(Me.NombreAgenciaTextEdit)
        Me.Controls.Add(NombreClienteLabel)
        Me.Controls.Add(Me.NombreClienteTextEdit)
        Me.Controls.Add(RnpClienteLabel)
        Me.Controls.Add(Me.RnpClienteTextEdit)
        Me.Controls.Add(NombrePropietarioLabel)
        Me.Controls.Add(Me.NombrePropietarioTextEdit)
        Me.Controls.Add(RnpPropietarioLabel)
        Me.Controls.Add(Me.RnpPropietarioTextEdit)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.MontoSpinEdit)
        Me.Controls.Add(PlazoLabel)
        Me.Controls.Add(Me.PlazoSpinEdit)
        Me.Controls.Add(TasaInteresLabel)
        Me.Controls.Add(Me.TasaInteresSpinEdit)
        Me.Controls.Add(CuotaPagarLabel)
        Me.Controls.Add(Me.CuotaPagarSpinEdit)
        Me.Controls.Add(InteresMoraLabel)
        Me.Controls.Add(Me.InteresMoraSpinEdit)
        Me.Controls.Add(ValorRemateLabel)
        Me.Controls.Add(Me.ValorRemateSpinEdit)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextEdit)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextEdit)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextEdit)
        Me.Controls.Add(AsientoLabel)
        Me.Controls.Add(Me.AsientoTextEdit)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextEdit)
        Me.Controls.Add(NumeroIpLabel)
        Me.Controls.Add(Me.NumeroIpTextEdit)
        Me.Controls.Add(TomoLabel)
        Me.Controls.Add(Me.TomoTextEdit)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.SeguimientoBindingNavigator)
        Me.Name = "seguimiento"
        Me.Text = "estado"
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguimientoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SeguimientoBindingNavigator.ResumeLayout(False)
        Me.SeguimientoBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.PrestamoIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreAgenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnpClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombrePropietarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnpPropietarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MontoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlazoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasaInteresSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuotaPagarSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresMoraSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValorRemateSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsientoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroIpTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TomoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents SeguimientoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeguimientoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.seguimientoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents SeguimientoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeguimientoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdPrestamoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdPrestamoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrestamoIdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EstadoIdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NombreAgenciaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombreClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RnpClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombrePropietarioTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RnpPropietarioTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MontoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PlazoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TasaInteresSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CuotaPagarSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents InteresMoraSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ValorRemateSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DescripcionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombresTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidosTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AsientoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MatriculaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NumeroIpTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TomoTextEdit As DevExpress.XtraEditors.TextEdit
End Class
