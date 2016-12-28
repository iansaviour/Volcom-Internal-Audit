<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMasterDesign
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterDesign))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LargeImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BtnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.GCDesign = New DevExpress.XtraGrid.GridControl()
        Me.GVDesign = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSampleSeason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnFabrication = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnOrign = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSampleCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDisplayName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Orign = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnBreakSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BClose = New DevExpress.XtraEditors.SimpleButton()
        Me.XTCDesign = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.BRefresh = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTCDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCDesign.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BClose)
        Me.PanelControl1.Controls.Add(Me.BRefresh)
        Me.PanelControl1.Controls.Add(Me.BtnNew)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 251)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(700, 44)
        Me.PanelControl1.TabIndex = 0
        '
        'LargeImageCollection
        '
        Me.LargeImageCollection.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeImageCollection.ImageStream = CType(resources.GetObject("LargeImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.LargeImageCollection.Images.SetKeyName(0, "1482830862_common-logout-signout-exit-glyph.png")
        Me.LargeImageCollection.Images.SetKeyName(1, "1482915093_plus-24.png")
        Me.LargeImageCollection.Images.SetKeyName(2, "1482915104_new-24.png")
        Me.LargeImageCollection.Images.SetKeyName(3, "1482915113_cross-24.png")
        Me.LargeImageCollection.Images.SetKeyName(4, "1482916005_black_2_audio_simple_repeat_2.png")
        '
        'BtnNew
        '
        Me.BtnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnNew.Appearance.Options.UseFont = True
        Me.BtnNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnNew.ImageIndex = 1
        Me.BtnNew.ImageList = Me.LargeImageCollection
        Me.BtnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BtnNew.Location = New System.Drawing.Point(2, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(102, 40)
        Me.BtnNew.TabIndex = 0
        Me.BtnNew.Text = "Add (F1)"
        '
        'GCDesign
        '
        Me.GCDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCDesign.Location = New System.Drawing.Point(0, 0)
        Me.GCDesign.MainView = Me.GVDesign
        Me.GCDesign.Name = "GCDesign"
        Me.GCDesign.Size = New System.Drawing.Size(694, 223)
        Me.GCDesign.TabIndex = 1
        Me.GCDesign.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDesign})
        '
        'GVDesign
        '
        Me.GVDesign.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColID, Me.ColName, Me.ColUOM, Me.ColSampleSeason, Me.GridColumn7, Me.GridColumnFabrication, Me.GridColumnOrign, Me.ColSampleCode, Me.ColDisplayName, Me.Orign, Me.GridColumnColor, Me.GridColumnClass, Me.GridColumnBreakSize, Me.GridColumnPrice, Me.GridColumnActive})
        Me.GVDesign.GridControl = Me.GCDesign
        Me.GVDesign.Name = "GVDesign"
        Me.GVDesign.OptionsBehavior.Editable = False
        Me.GVDesign.OptionsCustomization.AllowGroup = False
        Me.GVDesign.OptionsView.ShowGroupPanel = False
        Me.GVDesign.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColID
        '
        Me.ColID.Caption = "Id Sample"
        Me.ColID.FieldName = "id_design"
        Me.ColID.Name = "ColID"
        '
        'ColName
        '
        Me.ColName.Caption = "Design"
        Me.ColName.FieldName = "design_name"
        Me.ColName.Name = "ColName"
        Me.ColName.Width = 99
        '
        'ColUOM
        '
        Me.ColUOM.Caption = "UOM"
        Me.ColUOM.FieldName = "id_uom"
        Me.ColUOM.Name = "ColUOM"
        '
        'ColSampleSeason
        '
        Me.ColSampleSeason.Caption = "Season"
        Me.ColSampleSeason.FieldName = "season"
        Me.ColSampleSeason.FieldNameSortGroup = "id_season"
        Me.ColSampleSeason.Name = "ColSampleSeason"
        Me.ColSampleSeason.Visible = True
        Me.ColSampleSeason.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "id season"
        Me.GridColumn7.FieldName = "id_season"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnFabrication
        '
        Me.GridColumnFabrication.Caption = "Fabrication"
        Me.GridColumnFabrication.FieldName = "design_fabrication"
        Me.GridColumnFabrication.Name = "GridColumnFabrication"
        '
        'GridColumnOrign
        '
        Me.GridColumnOrign.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnOrign.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnOrign.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnOrign.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnOrign.Caption = "Source"
        Me.GridColumnOrign.FieldName = "product_source"
        Me.GridColumnOrign.Name = "GridColumnOrign"
        Me.GridColumnOrign.Width = 69
        '
        'ColSampleCode
        '
        Me.ColSampleCode.Caption = "Code"
        Me.ColSampleCode.FieldName = "design_code"
        Me.ColSampleCode.Name = "ColSampleCode"
        Me.ColSampleCode.Visible = True
        Me.ColSampleCode.VisibleIndex = 1
        Me.ColSampleCode.Width = 92
        '
        'ColDisplayName
        '
        Me.ColDisplayName.Caption = "Description"
        Me.ColDisplayName.FieldName = "design_display_name"
        Me.ColDisplayName.Name = "ColDisplayName"
        Me.ColDisplayName.Visible = True
        Me.ColDisplayName.VisibleIndex = 2
        Me.ColDisplayName.Width = 92
        '
        'Orign
        '
        Me.Orign.Caption = "Sample"
        Me.Orign.FieldName = "orign"
        Me.Orign.Name = "Orign"
        Me.Orign.Width = 120
        '
        'GridColumnColor
        '
        Me.GridColumnColor.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnColor.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnColor.Caption = "Color"
        Me.GridColumnColor.FieldName = "color"
        Me.GridColumnColor.Name = "GridColumnColor"
        Me.GridColumnColor.Visible = True
        Me.GridColumnColor.VisibleIndex = 3
        Me.GridColumnColor.Width = 67
        '
        'GridColumnClass
        '
        Me.GridColumnClass.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnClass.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnClass.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnClass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnClass.Caption = "Class"
        Me.GridColumnClass.FieldName = "product_class_display"
        Me.GridColumnClass.Name = "GridColumnClass"
        Me.GridColumnClass.Visible = True
        Me.GridColumnClass.VisibleIndex = 4
        Me.GridColumnClass.Width = 64
        '
        'GridColumnBreakSize
        '
        Me.GridColumnBreakSize.Caption = "Size Chart"
        Me.GridColumnBreakSize.FieldName = "size_chart"
        Me.GridColumnBreakSize.Name = "GridColumnBreakSize"
        Me.GridColumnBreakSize.Visible = True
        Me.GridColumnBreakSize.VisibleIndex = 5
        '
        'GridColumnPrice
        '
        Me.GridColumnPrice.Caption = "Current Price"
        Me.GridColumnPrice.DisplayFormat.FormatString = "N2"
        Me.GridColumnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnPrice.FieldName = "design_price"
        Me.GridColumnPrice.Name = "GridColumnPrice"
        Me.GridColumnPrice.Visible = True
        Me.GridColumnPrice.VisibleIndex = 6
        '
        'GridColumnActive
        '
        Me.GridColumnActive.Caption = "Active"
        Me.GridColumnActive.FieldName = "active"
        Me.GridColumnActive.Name = "GridColumnActive"
        Me.GridColumnActive.Visible = True
        Me.GridColumnActive.VisibleIndex = 7
        '
        'BClose
        '
        Me.BClose.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BClose.Appearance.Options.UseFont = True
        Me.BClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BClose.ImageIndex = 0
        Me.BClose.ImageList = Me.LargeImageCollection
        Me.BClose.Location = New System.Drawing.Point(594, 2)
        Me.BClose.Name = "BClose"
        Me.BClose.Size = New System.Drawing.Size(104, 40)
        Me.BClose.TabIndex = 3
        Me.BClose.Text = "Exit (Esc)"
        '
        'XTCDesign
        '
        Me.XTCDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCDesign.Location = New System.Drawing.Point(0, 0)
        Me.XTCDesign.Name = "XTCDesign"
        Me.XTCDesign.SelectedTabPage = Me.XtraTabPage1
        Me.XTCDesign.Size = New System.Drawing.Size(700, 251)
        Me.XTCDesign.TabIndex = 2
        Me.XTCDesign.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GCDesign)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(694, 223)
        Me.XtraTabPage1.Text = "Design List (9 digit)"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(294, 272)
        Me.XtraTabPage2.Text = "Product List (12 digit)"
        '
        'BRefresh
        '
        Me.BRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BRefresh.Appearance.Options.UseFont = True
        Me.BRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.BRefresh.ImageIndex = 4
        Me.BRefresh.ImageList = Me.LargeImageCollection
        Me.BRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BRefresh.Location = New System.Drawing.Point(104, 2)
        Me.BRefresh.Name = "BRefresh"
        Me.BRefresh.Size = New System.Drawing.Size(119, 40)
        Me.BRefresh.TabIndex = 4
        Me.BRefresh.Text = "Refresh (F5)"
        '
        'FormMasterDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 295)
        Me.Controls.Add(Me.XTCDesign)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMasterDesign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDesign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDesign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTCDesign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCDesign.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LargeImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents GCDesign As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDesign As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSampleSeason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnFabrication As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnOrign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSampleCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDisplayName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Orign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnClass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnBreakSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTCDesign As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
End Class
