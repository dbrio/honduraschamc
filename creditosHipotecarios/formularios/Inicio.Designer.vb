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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.btnAddHipoteca = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(1093, 335)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.creditosHipotecarios.My.Resources.Resources.cliente2
        Me.Button1.Location = New System.Drawing.Point(109, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 151)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "FIRMAS DE CLIENTES"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.RibbonControl1.MaximumSize = New System.Drawing.Size(0, 1000)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1093, 139)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 474)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnAddHipoteca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
End Class
