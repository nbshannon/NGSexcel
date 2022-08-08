Partial Class Ribbon1
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
   Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
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

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.NGSxl = Me.Factory.CreateRibbonGroup
        Me.btnHome = Me.Factory.CreateRibbonButton
        Me.ButtonGroup2 = Me.Factory.CreateRibbonButtonGroup
        Me.btnSplit = Me.Factory.CreateRibbonButton
        Me.btnBrowser = Me.Factory.CreateRibbonButton
        Me.ButtonGroup1 = Me.Factory.CreateRibbonButtonGroup
        Me.btnMisc = Me.Factory.CreateRibbonButton
        Me.btnLinks = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.NGSxl.SuspendLayout()
        Me.ButtonGroup2.SuspendLayout()
        Me.ButtonGroup1.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.NGSxl)
        Me.Tab1.Label = "TabAddIns"
        Me.Tab1.Name = "Tab1"
        '
        'NGSxl
        '
        Me.NGSxl.Items.Add(Me.btnHome)
        Me.NGSxl.Items.Add(Me.ButtonGroup2)
        Me.NGSxl.Items.Add(Me.ButtonGroup1)
        Me.NGSxl.Label = "NGSexcel"
        Me.NGSxl.Name = "NGSxl"
        '
        'btnHome
        '
        Me.btnHome.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnHome.Image = Global.NGSexcel.My.Resources.Resources.ngs_ex
        Me.btnHome.Label = "NGSxl"
        Me.btnHome.Name = "btnHome"
        Me.btnHome.ShowImage = True
        '
        'ButtonGroup2
        '
        Me.ButtonGroup2.Items.Add(Me.btnSplit)
        Me.ButtonGroup2.Items.Add(Me.btnBrowser)
        Me.ButtonGroup2.Name = "ButtonGroup2"
        '
        'btnSplit
        '
        Me.btnSplit.Label = "Split"
        Me.btnSplit.Name = "btnSplit"
        '
        'btnBrowser
        '
        Me.btnBrowser.Label = "Browser"
        Me.btnBrowser.Name = "btnBrowser"
        '
        'ButtonGroup1
        '
        Me.ButtonGroup1.Items.Add(Me.btnMisc)
        Me.ButtonGroup1.Items.Add(Me.btnLinks)
        Me.ButtonGroup1.Name = "ButtonGroup1"
        '
        'btnMisc
        '
        Me.btnMisc.Label = "Misc"
        Me.btnMisc.Name = "btnMisc"
        '
        'btnLinks
        '
        Me.btnLinks.Label = "Links"
        Me.btnLinks.Name = "btnLinks"
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.NGSxl.ResumeLayout(False)
        Me.NGSxl.PerformLayout()
        Me.ButtonGroup2.ResumeLayout(False)
        Me.ButtonGroup2.PerformLayout()
        Me.ButtonGroup1.ResumeLayout(False)
        Me.ButtonGroup1.PerformLayout()

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents NGSxl As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnHome As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnSplit As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnBrowser As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnMisc As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents ButtonGroup2 As Microsoft.Office.Tools.Ribbon.RibbonButtonGroup
    Friend WithEvents ButtonGroup1 As Microsoft.Office.Tools.Ribbon.RibbonButtonGroup
    Friend WithEvents btnLinks As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
