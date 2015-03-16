<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.btnProtocolo = New System.Windows.Forms.Button()
        Me.btnFirmaCliente = New System.Windows.Forms.Button()
        Me.btnPresentacion = New System.Windows.Forms.Button()
        Me.btnCustodio = New System.Windows.Forms.Button()
        Me.btnFirmaGerencia = New System.Windows.Forms.Button()
        Me.btnSolicitudPago = New System.Windows.Forms.Button()
        Me.btnListo = New System.Windows.Forms.Button()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 139)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1151, 335)
        Me.PanelControl1.TabIndex = 2
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
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
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddHipoteca, Me.BarButtonItem3})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1151, 139)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Location = New System.Drawing.Point(0, 32)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1435, 34)
        Me.PanelControl2.TabIndex = 4
        '
        'btnProtocolo
        '
        Me.btnProtocolo.BackColor = System.Drawing.Color.White
        Me.btnProtocolo.FlatAppearance.BorderSize = 0
        Me.btnProtocolo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnProtocolo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProtocolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProtocolo.Image = Global.creditosHipotecarios.My.Resources.Resources._1426295057_man
        Me.btnProtocolo.Location = New System.Drawing.Point(146, -63)
        Me.btnProtocolo.Name = "btnProtocolo"
        Me.btnProtocolo.Size = New System.Drawing.Size(81, 196)
        Me.btnProtocolo.TabIndex = 5
        Me.btnProtocolo.Text = "PARA FIRMA CLIENTES"
        Me.btnProtocolo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProtocolo.UseVisualStyleBackColor = False
        '
        'btnFirmaCliente
        '
        Me.btnFirmaCliente.BackColor = System.Drawing.Color.White
        Me.btnFirmaCliente.FlatAppearance.BorderSize = 0
        Me.btnFirmaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnFirmaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFirmaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirmaCliente.Image = Global.creditosHipotecarios.My.Resources.Resources.manager_01
        Me.btnFirmaCliente.Location = New System.Drawing.Point(275, -62)
        Me.btnFirmaCliente.Name = "btnFirmaCliente"
        Me.btnFirmaCliente.Size = New System.Drawing.Size(81, 195)
        Me.btnFirmaCliente.TabIndex = 7
        Me.btnFirmaCliente.Text = "PARA FIRMA GERENCIA"
        Me.btnFirmaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFirmaCliente.UseVisualStyleBackColor = False
        '
        'btnPresentacion
        '
        Me.btnPresentacion.BackColor = System.Drawing.Color.White
        Me.btnPresentacion.FlatAppearance.BorderSize = 0
        Me.btnPresentacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnPresentacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPresentacion.Image = Global.creditosHipotecarios.My.Resources.Resources.custodia_01
        Me.btnPresentacion.Location = New System.Drawing.Point(527, -67)
        Me.btnPresentacion.Name = "btnPresentacion"
        Me.btnPresentacion.Size = New System.Drawing.Size(81, 199)
        Me.btnPresentacion.TabIndex = 9
        Me.btnPresentacion.Text = "EVIAR A CUSTODIA"
        Me.btnPresentacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPresentacion.UseVisualStyleBackColor = False
        '
        'btnCustodio
        '
        Me.btnCustodio.BackColor = System.Drawing.Color.White
        Me.btnCustodio.FlatAppearance.BorderSize = 0
        Me.btnCustodio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnCustodio.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCustodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustodio.Image = Global.creditosHipotecarios.My.Resources.Resources._1426298110_Tag_128
        Me.btnCustodio.Location = New System.Drawing.Point(654, -57)
        Me.btnCustodio.Name = "btnCustodio"
        Me.btnCustodio.Size = New System.Drawing.Size(81, 189)
        Me.btnCustodio.TabIndex = 11
        Me.btnCustodio.Text = "SOLICITAR PAGO"
        Me.btnCustodio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustodio.UseVisualStyleBackColor = False
        '
        'btnFirmaGerencia
        '
        Me.btnFirmaGerencia.BackColor = System.Drawing.Color.White
        Me.btnFirmaGerencia.FlatAppearance.BorderSize = 0
        Me.btnFirmaGerencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnFirmaGerencia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFirmaGerencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirmaGerencia.Image = Global.creditosHipotecarios.My.Resources.Resources._1426294964_pencil_128
        Me.btnFirmaGerencia.Location = New System.Drawing.Point(401, -62)
        Me.btnFirmaGerencia.Name = "btnFirmaGerencia"
        Me.btnFirmaGerencia.Size = New System.Drawing.Size(81, 195)
        Me.btnFirmaGerencia.TabIndex = 16
        Me.btnFirmaGerencia.Text = "ESCRITURA AL IP"
        Me.btnFirmaGerencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFirmaGerencia.UseVisualStyleBackColor = False
        '
        'btnSolicitudPago
        '
        Me.btnSolicitudPago.BackColor = System.Drawing.Color.White
        Me.btnSolicitudPago.FlatAppearance.BorderSize = 0
        Me.btnSolicitudPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSolicitudPago.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSolicitudPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitudPago.Image = Global.creditosHipotecarios.My.Resources.Resources.pagar
        Me.btnSolicitudPago.Location = New System.Drawing.Point(776, -56)
        Me.btnSolicitudPago.Name = "btnSolicitudPago"
        Me.btnSolicitudPago.Size = New System.Drawing.Size(81, 189)
        Me.btnSolicitudPago.TabIndex = 18
        Me.btnSolicitudPago.Text = "EFECTURAR PAGO"
        Me.btnSolicitudPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSolicitudPago.UseVisualStyleBackColor = False
        '
        'btnListo
        '
        Me.btnListo.BackColor = System.Drawing.Color.White
        Me.btnListo.FlatAppearance.BorderSize = 0
        Me.btnListo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnListo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListo.Image = Global.creditosHipotecarios.My.Resources.Resources._1426294923_document
        Me.btnListo.Location = New System.Drawing.Point(26, -63)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(82, 196)
        Me.btnListo.TabIndex = 20
        Me.btnListo.Text = "PROTOCOLO LISTO"
        Me.btnListo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 474)
        Me.Controls.Add(Me.btnListo)
        Me.Controls.Add(Me.btnSolicitudPago)
        Me.Controls.Add(Me.btnFirmaGerencia)
        Me.Controls.Add(Me.btnCustodio)
        Me.Controls.Add(Me.btnPresentacion)
        Me.Controls.Add(Me.btnFirmaCliente)
        Me.Controls.Add(Me.btnProtocolo)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
