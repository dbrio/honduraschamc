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
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddHipoteca = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PageAgencia = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PageProveeduria = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PageGerente = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PageGerenteRegional = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PageAdmin = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddHipoteca, Me.BarButtonItem2})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 10
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.PageAgencia, Me.PageProveeduria, Me.PageGerente, Me.PageGerenteRegional, Me.PageAdmin})
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1093, 142)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
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
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Para Protocolo"
        Me.BarButtonItem2.Id = 9
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage1.Appearance.Options.UseFont = True
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "INICIO"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        '
        'PageAgencia
        '
        Me.PageAgencia.Appearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.PageAgencia.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageAgencia.Appearance.Options.UseBorderColor = True
        Me.PageAgencia.Appearance.Options.UseFont = True
        Me.PageAgencia.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.PageAgencia.Name = "PageAgencia"
        Me.PageAgencia.Text = "AGENCIA"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        '
        'PageProveeduria
        '
        Me.PageProveeduria.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageProveeduria.Appearance.Options.UseFont = True
        Me.PageProveeduria.Name = "PageProveeduria"
        Me.PageProveeduria.Text = "PROVEEDURIA"
        '
        'PageGerente
        '
        Me.PageGerente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageGerente.Appearance.Options.UseFont = True
        Me.PageGerente.Name = "PageGerente"
        Me.PageGerente.Text = "GERENTE"
        '
        'PageGerenteRegional
        '
        Me.PageGerenteRegional.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageGerenteRegional.Appearance.Options.UseFont = True
        Me.PageGerenteRegional.Name = "PageGerenteRegional"
        Me.PageGerenteRegional.Text = "GERENTE REGIONAL"
        '
        'PageAdmin
        '
        Me.PageAdmin.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageAdmin.Appearance.Options.UseFont = True
        Me.PageAdmin.Name = "PageAdmin"
        Me.PageAdmin.Text = "ADMIN"
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
        Me.PanelControl1.Location = New System.Drawing.Point(0, 142)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1093, 332)
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
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 474)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddHipoteca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PageAgencia As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PageProveeduria As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents PageGerente As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents PageGerenteRegional As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents PageAdmin As DevExpress.XtraBars.Ribbon.RibbonPage
End Class
