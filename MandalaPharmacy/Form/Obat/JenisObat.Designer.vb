<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisObat
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JenisObat))
        Me.DataSetObat = New MandalaPharmacy.DataSetObat()
        Me.JenisObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JenisObatTableAdapter = New MandalaPharmacy.DataSetObatTableAdapters.jenisObatTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetObatTableAdapters.TableAdapterManager()
        Me.JenisObatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.JenisObatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.JenisObatGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljenisObat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGambar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.jenisObatTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForjenisObat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GambarPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.ItemForGambar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.DataSetObat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisObatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JenisObatBindingNavigator.SuspendLayout()
        CType(Me.JenisObatGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jenisObatTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForjenisObat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GambarPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetObat
        '
        Me.DataSetObat.DataSetName = "DataSetObat"
        Me.DataSetObat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JenisObatBindingSource
        '
        Me.JenisObatBindingSource.DataMember = "jenisObat"
        Me.JenisObatBindingSource.DataSource = Me.DataSetObat
        '
        'JenisObatTableAdapter
        '
        Me.JenisObatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.jenisObatTableAdapter = Me.JenisObatTableAdapter
        Me.TableAdapterManager.mstObatTableAdapter = Nothing
        Me.TableAdapterManager.mstSatuanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetObatTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JenisObatBindingNavigator
        '
        Me.JenisObatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JenisObatBindingNavigator.BindingSource = Me.JenisObatBindingSource
        Me.JenisObatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JenisObatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JenisObatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JenisObatBindingNavigatorSaveItem})
        Me.JenisObatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JenisObatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JenisObatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JenisObatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JenisObatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JenisObatBindingNavigator.Name = "JenisObatBindingNavigator"
        Me.JenisObatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JenisObatBindingNavigator.Size = New System.Drawing.Size(708, 25)
        Me.JenisObatBindingNavigator.TabIndex = 0
        Me.JenisObatBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'JenisObatBindingNavigatorSaveItem
        '
        Me.JenisObatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JenisObatBindingNavigatorSaveItem.Image = CType(resources.GetObject("JenisObatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JenisObatBindingNavigatorSaveItem.Name = "JenisObatBindingNavigatorSaveItem"
        Me.JenisObatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.JenisObatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'JenisObatGridControl
        '
        Me.JenisObatGridControl.DataSource = Me.JenisObatBindingSource
        Me.JenisObatGridControl.Location = New System.Drawing.Point(264, 12)
        Me.JenisObatGridControl.MainView = Me.GridView1
        Me.JenisObatGridControl.Name = "JenisObatGridControl"
        Me.JenisObatGridControl.Size = New System.Drawing.Size(432, 448)
        Me.JenisObatGridControl.TabIndex = 1
        Me.JenisObatGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.coljenisObat, Me.colGambar})
        Me.GridView1.GridControl = Me.JenisObatGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'coljenisObat
        '
        Me.coljenisObat.FieldName = "jenisObat"
        Me.coljenisObat.Name = "coljenisObat"
        Me.coljenisObat.Visible = True
        Me.coljenisObat.VisibleIndex = 0
        '
        'colGambar
        '
        Me.colGambar.FieldName = "Gambar"
        Me.colGambar.Name = "colGambar"
        Me.colGambar.Visible = True
        Me.colGambar.VisibleIndex = 1
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.JenisObatGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.jenisObatTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.GambarPictureEdit)
        Me.DataLayoutControl1.DataSource = Me.JenisObatBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(756, 294, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(708, 472)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(708, 472)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForjenisObat, Me.ItemForGambar, Me.LayoutControlItem1, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(688, 452)
        '
        'jenisObatTextEdit
        '
        Me.jenisObatTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JenisObatBindingSource, "jenisObat", True))
        Me.jenisObatTextEdit.Location = New System.Drawing.Point(53, 12)
        Me.jenisObatTextEdit.Name = "jenisObatTextEdit"
        Me.jenisObatTextEdit.Size = New System.Drawing.Size(207, 20)
        Me.jenisObatTextEdit.StyleController = Me.DataLayoutControl1
        Me.jenisObatTextEdit.TabIndex = 4
        '
        'ItemForjenisObat
        '
        Me.ItemForjenisObat.Control = Me.jenisObatTextEdit
        Me.ItemForjenisObat.Location = New System.Drawing.Point(0, 0)
        Me.ItemForjenisObat.Name = "ItemForjenisObat"
        Me.ItemForjenisObat.Size = New System.Drawing.Size(252, 24)
        Me.ItemForjenisObat.Text = "Jenis"
        Me.ItemForjenisObat.TextSize = New System.Drawing.Size(37, 13)
        '
        'GambarPictureEdit
        '
        Me.GambarPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.GambarPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JenisObatBindingSource, "Gambar", True))
        Me.GambarPictureEdit.Location = New System.Drawing.Point(53, 36)
        Me.GambarPictureEdit.Name = "GambarPictureEdit"
        Me.GambarPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.GambarPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.GambarPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.GambarPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.GambarPictureEdit.Size = New System.Drawing.Size(207, 140)
        Me.GambarPictureEdit.StyleController = Me.DataLayoutControl1
        Me.GambarPictureEdit.TabIndex = 5
        '
        'ItemForGambar
        '
        Me.ItemForGambar.Control = Me.GambarPictureEdit
        Me.ItemForGambar.Location = New System.Drawing.Point(0, 24)
        Me.ItemForGambar.Name = "ItemForGambar"
        Me.ItemForGambar.Size = New System.Drawing.Size(252, 144)
        Me.ItemForGambar.StartNewLine = True
        Me.ItemForGambar.Text = "Gambar"
        Me.ItemForGambar.TextLocation = DevExpress.Utils.Locations.Left
        Me.ItemForGambar.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.JenisObatGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(252, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(436, 452)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 168)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(252, 284)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'JenisObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 497)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.JenisObatBindingNavigator)
        Me.Name = "JenisObat"
        Me.Text = "JenisObat"
        CType(Me.DataSetObat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisObatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JenisObatBindingNavigator.ResumeLayout(False)
        Me.JenisObatBindingNavigator.PerformLayout()
        CType(Me.JenisObatGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jenisObatTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForjenisObat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GambarPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForGambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetObat As DataSetObat
    Friend WithEvents JenisObatBindingSource As BindingSource
    Friend WithEvents JenisObatTableAdapter As DataSetObatTableAdapters.jenisObatTableAdapter
    Friend WithEvents TableAdapterManager As DataSetObatTableAdapters.TableAdapterManager
    Friend WithEvents JenisObatBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents JenisObatBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents JenisObatGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents coljenisObat As XtraGrid.Columns.GridColumn
    Friend WithEvents colGambar As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents jenisObatTextEdit As TextEdit
    Friend WithEvents GambarPictureEdit As PictureEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForjenisObat As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForGambar As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As XtraLayout.EmptySpaceItem
End Class
