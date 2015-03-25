<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form
   

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.btnAddHipoteca = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MODIFICARUSUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelDeparamento = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ESTADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.btnSolicitudPago = New System.Windows.Forms.Button()
        Me.btnProtocolo = New System.Windows.Forms.Button()
        Me.btnFirmaGerencia = New System.Windows.Forms.Button()
        Me.btnFirmaCliente = New System.Windows.Forms.Button()
        Me.btnCustodio = New System.Windows.Forms.Button()
        Me.btnPresentacion = New System.Windows.Forms.Button()
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl1.Appearance.BorderColor = System.Drawing.Color.White
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseBorderColor = True
        Me.PanelControl1.Appearance.Options.UseForeColor = True
        Me.PanelControl1.AutoSize = True
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = Global.creditosHipotecarios.My.Resources.Resources.AMC_Logo_sin_fondo
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 121)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1435, 540)
        Me.PanelControl1.TabIndex = 2
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Agregar Hipoteca"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Transparent
        Me.BarButtonItem1.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.BarButtonItem1.ItemAppearance.Hovered.Options.UseTextOptions = True
        Me.BarButtonItem1.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseTextOptions = True
        Me.BarButtonItem1.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarButtonItem1.ItemAppearance.Pressed.Options.UseTextOptions = True
        Me.BarButtonItem1.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarButtonItem1.ItemInMenuAppearance.Hovered.Options.UseTextOptions = True
        Me.BarButtonItem1.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarButtonItem1.ItemInMenuAppearance.Normal.Options.UseTextOptions = True
        Me.BarButtonItem1.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarButtonItem1.ItemInMenuAppearance.Pressed.Options.UseTextOptions = True
        Me.BarButtonItem1.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarButtonItem1.LargeGlyph = Global.creditosHipotecarios.My.Resources.Resources.add
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "MENU"
        '
        'btnAddHipoteca
        '
        Me.btnAddHipoteca.Caption = "Lista de Garantía"
        Me.btnAddHipoteca.Id = 2
        Me.btnAddHipoteca.ItemAppearance.Disabled.Options.UseTextOptions = True
        Me.btnAddHipoteca.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnAddHipoteca.ItemAppearance.Hovered.Options.UseTextOptions = True
        Me.btnAddHipoteca.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnAddHipoteca.ItemAppearance.Normal.Options.UseTextOptions = True
        Me.btnAddHipoteca.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnAddHipoteca.ItemAppearance.Pressed.Options.UseTextOptions = True
        Me.btnAddHipoteca.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnAddHipoteca.LargeGlyph = Global.creditosHipotecarios.My.Resources.Resources.add
        Me.btnAddHipoteca.Name = "btnAddHipoteca"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 10
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.BackColor = System.Drawing.Color.White
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddHipoteca, Me.BarButtonItem3})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1435, 121)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.PanelControl2.Controls.Add(Me.GroupBox1)
        Me.PanelControl2.Controls.Add(Me.btnBuscar)
        Me.PanelControl2.Controls.Add(Me.btnListo)
        Me.PanelControl2.Controls.Add(Me.btnSolicitudPago)
        Me.PanelControl2.Controls.Add(Me.btnProtocolo)
        Me.PanelControl2.Controls.Add(Me.btnFirmaGerencia)
        Me.PanelControl2.Controls.Add(Me.btnFirmaCliente)
        Me.PanelControl2.Controls.Add(Me.btnCustodio)
        Me.PanelControl2.Controls.Add(Me.btnPresentacion)
        Me.PanelControl2.Location = New System.Drawing.Point(0, -11)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1435, 153)
        Me.PanelControl2.TabIndex = 4
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MODIFICARUSUARIOSToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(196, 26)
        '
        'MODIFICARUSUARIOSToolStripMenuItem
        '
        Me.MODIFICARUSUARIOSToolStripMenuItem.Name = "MODIFICARUSUARIOSToolStripMenuItem"
        Me.MODIFICARUSUARIOSToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.MODIFICARUSUARIOSToolStripMenuItem.Text = "MODIFICAR USUARIOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelDeparamento)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(820, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 75)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DEPARTAMENTO DE:"
        '
        'LabelDeparamento
        '
        Me.LabelDeparamento.AutoSize = True
        Me.LabelDeparamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeparamento.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.LabelDeparamento.Location = New System.Drawing.Point(6, 20)
        Me.LabelDeparamento.Name = "LabelDeparamento"
        Me.LabelDeparamento.Size = New System.Drawing.Size(111, 37)
        Me.LabelDeparamento.TabIndex = 23
        Me.LabelDeparamento.Text = "Label1"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.creditosHipotecarios.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(4, -31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 174)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESTADOToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 26)
        '
        'ESTADOToolStripMenuItem
        '
        Me.ESTADOToolStripMenuItem.Name = "ESTADOToolStripMenuItem"
        Me.ESTADOToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ESTADOToolStripMenuItem.Text = "ESTADO"
        '
        'btnListo
        '
        Me.btnListo.BackColor = System.Drawing.Color.White
        Me.btnListo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListo.FlatAppearance.BorderSize = 0
        Me.btnListo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnListo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListo.Image = Global.creditosHipotecarios.My.Resources.Resources._1426294923_document
        Me.btnListo.Location = New System.Drawing.Point(92, -51)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(82, 196)
        Me.btnListo.TabIndex = 20
        Me.btnListo.Text = "PROTOCOLO LISTO"
        Me.btnListo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'btnSolicitudPago
        '
        Me.btnSolicitudPago.BackColor = System.Drawing.Color.White
        Me.btnSolicitudPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSolicitudPago.FlatAppearance.BorderSize = 0
        Me.btnSolicitudPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSolicitudPago.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSolicitudPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitudPago.Image = Global.creditosHipotecarios.My.Resources.Resources.pagar
        Me.btnSolicitudPago.Location = New System.Drawing.Point(664, -50)
        Me.btnSolicitudPago.Name = "btnSolicitudPago"
        Me.btnSolicitudPago.Size = New System.Drawing.Size(82, 195)
        Me.btnSolicitudPago.TabIndex = 18
        Me.btnSolicitudPago.Text = "EFECTURAR PAGO"
        Me.btnSolicitudPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSolicitudPago.UseVisualStyleBackColor = False
        '
        'btnProtocolo
        '
        Me.btnProtocolo.BackColor = System.Drawing.Color.White
        Me.btnProtocolo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProtocolo.FlatAppearance.BorderSize = 0
        Me.btnProtocolo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnProtocolo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProtocolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProtocolo.Image = Global.creditosHipotecarios.My.Resources.Resources._1426295057_man
        Me.btnProtocolo.Location = New System.Drawing.Point(187, -50)
        Me.btnProtocolo.Name = "btnProtocolo"
        Me.btnProtocolo.Size = New System.Drawing.Size(81, 196)
        Me.btnProtocolo.TabIndex = 5
        Me.btnProtocolo.Text = "PARA FIRMA CLIENTES"
        Me.btnProtocolo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProtocolo.UseVisualStyleBackColor = False
        '
        'btnFirmaGerencia
        '
        Me.btnFirmaGerencia.BackColor = System.Drawing.Color.White
        Me.btnFirmaGerencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirmaGerencia.FlatAppearance.BorderSize = 0
        Me.btnFirmaGerencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnFirmaGerencia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFirmaGerencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirmaGerencia.Image = Global.creditosHipotecarios.My.Resources.Resources._1426294964_pencil_128
        Me.btnFirmaGerencia.Location = New System.Drawing.Point(376, -48)
        Me.btnFirmaGerencia.Name = "btnFirmaGerencia"
        Me.btnFirmaGerencia.Size = New System.Drawing.Size(81, 195)
        Me.btnFirmaGerencia.TabIndex = 16
        Me.btnFirmaGerencia.Text = "ESCRITURA AL IP"
        Me.btnFirmaGerencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFirmaGerencia.UseVisualStyleBackColor = False
        '
        'btnFirmaCliente
        '
        Me.btnFirmaCliente.BackColor = System.Drawing.Color.White
        Me.btnFirmaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirmaCliente.FlatAppearance.BorderSize = 0
        Me.btnFirmaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnFirmaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFirmaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirmaCliente.Image = Global.creditosHipotecarios.My.Resources.Resources.manager_01
        Me.btnFirmaCliente.Location = New System.Drawing.Point(282, -48)
        Me.btnFirmaCliente.Name = "btnFirmaCliente"
        Me.btnFirmaCliente.Size = New System.Drawing.Size(80, 195)
        Me.btnFirmaCliente.TabIndex = 7
        Me.btnFirmaCliente.Text = "PARA FIRMA GERENCIA"
        Me.btnFirmaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFirmaCliente.UseVisualStyleBackColor = False
        '
        'btnCustodio
        '
        Me.btnCustodio.BackColor = System.Drawing.Color.White
        Me.btnCustodio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustodio.FlatAppearance.BorderSize = 0
        Me.btnCustodio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnCustodio.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCustodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustodio.Image = Global.creditosHipotecarios.My.Resources.Resources._1426298110_Tag_128
        Me.btnCustodio.Location = New System.Drawing.Point(567, -44)
        Me.btnCustodio.Name = "btnCustodio"
        Me.btnCustodio.Size = New System.Drawing.Size(81, 189)
        Me.btnCustodio.TabIndex = 11
        Me.btnCustodio.Text = "SOLICITAR PAGO"
        Me.btnCustodio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustodio.UseVisualStyleBackColor = False
        '
        'btnPresentacion
        '
        Me.btnPresentacion.BackColor = System.Drawing.Color.White
        Me.btnPresentacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPresentacion.FlatAppearance.BorderSize = 0
        Me.btnPresentacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnPresentacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPresentacion.Image = Global.creditosHipotecarios.My.Resources.Resources.custodia_01
        Me.btnPresentacion.Location = New System.Drawing.Point(471, -52)
        Me.btnPresentacion.Name = "btnPresentacion"
        Me.btnPresentacion.Size = New System.Drawing.Size(81, 199)
        Me.btnPresentacion.TabIndex = 9
        Me.btnPresentacion.Text = "EVIAR A CUSTODIA"
        Me.btnPresentacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPresentacion.UseVisualStyleBackColor = False
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.DataSetCreditos
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbogadoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventoTableAdapter = Nothing
        Me.TableAdapterManager.hipotecaEstadoTableAdapter = Nothing
        Me.TableAdapterManager.HipotecaTableAdapter = Nothing
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1268, 678)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddHipoteca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Private WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnProtocolo As System.Windows.Forms.Button
    Friend WithEvents btnFirmaCliente As System.Windows.Forms.Button
    Friend WithEvents btnPresentacion As System.Windows.Forms.Button
    Friend WithEvents btnCustodio As System.Windows.Forms.Button
    Friend WithEvents btnFirmaGerencia As System.Windows.Forms.Button
    Friend WithEvents btnSolicitudPago As System.Windows.Forms.Button
    Friend WithEvents btnListo As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ESTADOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MODIFICARUSUARIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents UsuarioTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDeparamento As System.Windows.Forms.Label
End Class
