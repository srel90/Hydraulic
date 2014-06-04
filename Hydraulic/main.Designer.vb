<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

    'Form overrides dispose to clean up the component list.
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


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.RibbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.btnpressure = New DevComponents.DotNetBar.ButtonItem()
        Me.btnwidth_radius = New DevComponents.DotNetBar.ButtonItem()
        Me.btnefficient = New DevComponents.DotNetBar.ButtonItem()
        Me.btnarea = New DevComponents.DotNetBar.ButtonItem()
        Me.btnproductivity_ratio = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnhelp = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black
        '
        'RibbonControl1
        '
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.Class = ""
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RibbonTabItem1})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(5, 1)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(622, 154)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 3
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(622, 99)
        '
        '
        '
        Me.RibbonPanel1.Style.Class = ""
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.Class = ""
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.Class = ""
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 1
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.Class = ""
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnpressure, Me.btnwidth_radius, Me.btnefficient, Me.btnarea, Me.btnproductivity_ratio, Me.ButtonItem1, Me.btnhelp})
        Me.RibbonBar2.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(399, 96)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 0
        '
        '
        '
        Me.RibbonBar2.TitleStyle.Class = ""
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.Class = ""
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'RibbonTabItem1
        '
        Me.RibbonTabItem1.Checked = True
        Me.RibbonTabItem1.Name = "RibbonTabItem1"
        Me.RibbonTabItem1.Panel = Me.RibbonPanel1
        Me.RibbonTabItem1.Text = "Calculate"
        '
        'btnpressure
        '
        Me.btnpressure.Image = Global.Hydraulic.My.Resources.Resources.boxdownload32
        Me.btnpressure.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnpressure.Name = "btnpressure"
        Me.btnpressure.SubItemsExpandWidth = 14
        Me.btnpressure.Text = "Fracture Pressure"
        '
        'btnwidth_radius
        '
        Me.btnwidth_radius.Image = Global.Hydraulic.My.Resources.Resources.boxdownload32
        Me.btnwidth_radius.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnwidth_radius.Name = "btnwidth_radius"
        Me.btnwidth_radius.SubItemsExpandWidth = 14
        Me.btnwidth_radius.Text = "Fracture Width and Fracture Length"
        '
        'btnefficient
        '
        Me.btnefficient.Image = Global.Hydraulic.My.Resources.Resources.boxdownload32
        Me.btnefficient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnefficient.Name = "btnefficient"
        Me.btnefficient.SubItemsExpandWidth = 14
        Me.btnefficient.Text = "Fracture Efficiency"
        '
        'btnarea
        '
        Me.btnarea.Image = Global.Hydraulic.My.Resources.Resources.boxdownload32
        Me.btnarea.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnarea.Name = "btnarea"
        Me.btnarea.SubItemsExpandWidth = 14
        Me.btnarea.Text = "Fracture Area"
        '
        'btnproductivity_ratio
        '
        Me.btnproductivity_ratio.Image = Global.Hydraulic.My.Resources.Resources.boxdownload32
        Me.btnproductivity_ratio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnproductivity_ratio.Name = "btnproductivity_ratio"
        Me.btnproductivity_ratio.SubItemsExpandWidth = 14
        Me.btnproductivity_ratio.Text = "Productivity Ratio"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Image = Global.Hydraulic.My.Resources.Resources.cc1
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "Cascade Windows"
        '
        'btnhelp
        '
        Me.btnhelp.Image = Global.Hydraulic.My.Resources.Resources.info
        Me.btnhelp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.SubItemsExpandWidth = 14
        Me.btnhelp.Text = "Help"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.RibbonControl1)
        Me.EnableGlass = False
        Me.IsMdiContainer = True
        Me.Name = "main"
        Me.Text = "Hydraulic fracturing calculation and design for horizontal fracturing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnpressure As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents btnwidth_radius As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnefficient As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnarea As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnproductivity_ratio As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnhelp As DevComponents.DotNetBar.ButtonItem

End Class
