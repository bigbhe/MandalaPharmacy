<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReceiveDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReceiveDetail))
        Me.DataSetReceive = New MandalaPharmacy.DataSetReceive()
        Me.ReceiveDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveDetailTableAdapter = New MandalaPharmacy.DataSetReceiveTableAdapters.receiveDetailTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetReceiveTableAdapters.TableAdapterManager()
        Me.ReceiveDetailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReceiveDetailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ReceiveDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidReceiveHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidObat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.coljumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MstObatTableAdapter = New MandalaPharmacy.DataSetReceiveTableAdapters.mstObatTableAdapter()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idReceiveHeaderTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.idObatLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.jumlahTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForidReceiveHeader = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidObat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForjumlah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ReceiveDetailTableAdapter1 = New MandalaPharmacy.DataSetReceiveTableAdapters.receiveDetailTableAdapter()
        Me.ReceiveDetailTableAdapter2 = New MandalaPharmacy.DataSetReceiveTableAdapters.receiveDetailTableAdapter()
        CType(Me.DataSetReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveDetailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceiveDetailBindingNavigator.SuspendLayout()
        CType(Me.ReceiveDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idReceiveHeaderTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idObatLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jumlahTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidReceiveHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidObat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForjumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetReceive
        '
        Me.DataSetReceive.DataSetName = "DataSetReceive"
        Me.DataSetReceive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiveDetailBindingSource
        '
        Me.ReceiveDetailBindingSource.DataMember = "receiveDetail"
        Me.ReceiveDetailBindingSource.DataSource = Me.DataSetReceive
        '
        'ReceiveDetailTableAdapter
        '
        Me.ReceiveDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.receiveDetailTableAdapter = Me.ReceiveDetailTableAdapter
        Me.TableAdapterManager.receiveHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetReceiveTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReceiveDetailBindingNavigator
        '
        Me.ReceiveDetailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReceiveDetailBindingNavigator.BindingSource = Me.ReceiveDetailBindingSource
        Me.ReceiveDetailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReceiveDetailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReceiveDetailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReceiveDetailBindingNavigatorSaveItem})
        Me.ReceiveDetailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReceiveDetailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReceiveDetailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReceiveDetailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReceiveDetailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReceiveDetailBindingNavigator.Name = "ReceiveDetailBindingNavigator"
        Me.ReceiveDetailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReceiveDetailBindingNavigator.Size = New System.Drawing.Size(715, 25)
        Me.ReceiveDetailBindingNavigator.TabIndex = 0
        Me.ReceiveDetailBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ReceiveDetailBindingNavigatorSaveItem
        '
        Me.ReceiveDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReceiveDetailBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReceiveDetailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReceiveDetailBindingNavigatorSaveItem.Name = "ReceiveDetailBindingNavigatorSaveItem"
        Me.ReceiveDetailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReceiveDetailBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ReceiveDetailGridControl
        '
        Me.ReceiveDetailGridControl.DataSource = Me.ReceiveDetailBindingSource
        Me.ReceiveDetailGridControl.Location = New System.Drawing.Point(24, 148)
        Me.ReceiveDetailGridControl.MainView = Me.GridView1
        Me.ReceiveDetailGridControl.Name = "ReceiveDetailGridControl"
        Me.ReceiveDetailGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.ReceiveDetailGridControl.Size = New System.Drawing.Size(667, 377)
        Me.ReceiveDetailGridControl.TabIndex = 4
        Me.ReceiveDetailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidReceiveHeader, Me.colidObat, Me.coljumlah})
        Me.GridView1.GridControl = Me.ReceiveDetailGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidReceiveHeader
        '
        Me.colidReceiveHeader.FieldName = "idReceiveHeader"
        Me.colidReceiveHeader.Name = "colidReceiveHeader"
        Me.colidReceiveHeader.Visible = True
        Me.colidReceiveHeader.VisibleIndex = 0
        '
        'colidObat
        '
        Me.colidObat.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidObat.FieldName = "idObat"
        Me.colidObat.Name = "colidObat"
        Me.colidObat.Visible = True
        Me.colidObat.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstObatBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Nama"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'MstObatBindingSource
        '
        Me.MstObatBindingSource.DataMember = "mstObat"
        Me.MstObatBindingSource.DataSource = Me.DataSetReceive
        '
        'coljumlah
        '
        Me.coljumlah.FieldName = "jumlah"
        Me.coljumlah.Name = "coljumlah"
        Me.coljumlah.Visible = True
        Me.coljumlah.VisibleIndex = 2
        '
        'MstObatTableAdapter
        '
        Me.MstObatTableAdapter.ClearBeforeFill = True
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.ReceiveDetailGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idReceiveHeaderTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idObatLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.jumlahTextEdit)
        Me.DataLayoutControl1.DataSource = Me.ReceiveDetailBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidReceiveHeader})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(715, 549)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idReceiveHeaderTextEdit
        '
        Me.idReceiveHeaderTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveDetailBindingSource, "idReceiveHeader", True))
        Me.idReceiveHeaderTextEdit.Location = New System.Drawing.Point(115, 42)
        Me.idReceiveHeaderTextEdit.Name = "idReceiveHeaderTextEdit"
        Me.idReceiveHeaderTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idReceiveHeaderTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idReceiveHeaderTextEdit.Properties.Mask.EditMask = "N0"
        Me.idReceiveHeaderTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idReceiveHeaderTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idReceiveHeaderTextEdit.Size = New System.Drawing.Size(576, 20)
        Me.idReceiveHeaderTextEdit.StyleController = Me.DataLayoutControl1
        Me.idReceiveHeaderTextEdit.TabIndex = 0
        '
        'idObatLookUpEdit
        '
        Me.idObatLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveDetailBindingSource, "idObat", True))
        Me.idObatLookUpEdit.Location = New System.Drawing.Point(110, 42)
        Me.idObatLookUpEdit.Name = "idObatLookUpEdit"
        Me.idObatLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idObatLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idObatLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idObatLookUpEdit.Properties.DataSource = Me.MstObatBindingSource
        Me.idObatLookUpEdit.Properties.DisplayMember = "Nama"
        Me.idObatLookUpEdit.Properties.NullText = ""
        Me.idObatLookUpEdit.Properties.ValueMember = "id"
        Me.idObatLookUpEdit.Size = New System.Drawing.Size(581, 20)
        Me.idObatLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idObatLookUpEdit.TabIndex = 2
        '
        'jumlahTextEdit
        '
        Me.jumlahTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveDetailBindingSource, "jumlah", True))
        Me.jumlahTextEdit.Location = New System.Drawing.Point(110, 66)
        Me.jumlahTextEdit.Name = "jumlahTextEdit"
        Me.jumlahTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.jumlahTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jumlahTextEdit.Properties.Mask.EditMask = "N0"
        Me.jumlahTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.jumlahTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.jumlahTextEdit.Size = New System.Drawing.Size(581, 20)
        Me.jumlahTextEdit.StyleController = Me.DataLayoutControl1
        Me.jumlahTextEdit.TabIndex = 3
        '
        'ItemForidReceiveHeader
        '
        Me.ItemForidReceiveHeader.Control = Me.idReceiveHeaderTextEdit
        Me.ItemForidReceiveHeader.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidReceiveHeader.Name = "ItemForidReceiveHeader"
        Me.ItemForidReceiveHeader.Size = New System.Drawing.Size(671, 24)
        Me.ItemForidReceiveHeader.Text = "id Receive Header"
        Me.ItemForidReceiveHeader.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(715, 549)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(695, 529)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidObat, Me.ItemForjumlah})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(695, 90)
        Me.LayoutControlGroup3.Text = "Detail Obat Masuk"
        '
        'ItemForidObat
        '
        Me.ItemForidObat.Control = Me.idObatLookUpEdit
        Me.ItemForidObat.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidObat.Name = "ItemForidObat"
        Me.ItemForidObat.Size = New System.Drawing.Size(671, 24)
        Me.ItemForidObat.Text = "id Obat"
        Me.ItemForidObat.TextSize = New System.Drawing.Size(83, 13)
        '
        'ItemForjumlah
        '
        Me.ItemForjumlah.Control = Me.jumlahTextEdit
        Me.ItemForjumlah.Location = New System.Drawing.Point(0, 24)
        Me.ItemForjumlah.Name = "ItemForjumlah"
        Me.ItemForjumlah.Size = New System.Drawing.Size(671, 24)
        Me.ItemForjumlah.Text = "jumlah"
        Me.ItemForjumlah.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(695, 439)
        Me.LayoutControlGroup4.Text = "-"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ReceiveDetailGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(671, 397)
        Me.LayoutControlItem1.Text = "Data Obat Masuk"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(83, 13)
        '
        'ReceiveDetailTableAdapter1
        '
        Me.ReceiveDetailTableAdapter1.ClearBeforeFill = True
        '
        'ReceiveDetailTableAdapter2
        '
        Me.ReceiveDetailTableAdapter2.ClearBeforeFill = True
        '
        'FormReceiveDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 574)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.ReceiveDetailBindingNavigator)
        Me.Name = "FormReceiveDetail"
        Me.Text = "FormReceiveDetail"
        CType(Me.DataSetReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveDetailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceiveDetailBindingNavigator.ResumeLayout(False)
        Me.ReceiveDetailBindingNavigator.PerformLayout()
        CType(Me.ReceiveDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idReceiveHeaderTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idObatLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jumlahTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidReceiveHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidObat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForjumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetReceive As DataSetReceive
    Friend WithEvents ReceiveDetailBindingSource As BindingSource
    Friend WithEvents ReceiveDetailTableAdapter As DataSetReceiveTableAdapters.receiveDetailTableAdapter
    Friend WithEvents TableAdapterManager As DataSetReceiveTableAdapters.TableAdapterManager
    Friend WithEvents ReceiveDetailBindingNavigator As BindingNavigator
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
    Friend WithEvents ReceiveDetailBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ReceiveDetailGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidReceiveHeader As XtraGrid.Columns.GridColumn
    Friend WithEvents colidObat As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents coljumlah As XtraGrid.Columns.GridColumn
    Friend WithEvents MstObatBindingSource As BindingSource
    Friend WithEvents MstObatTableAdapter As DataSetReceiveTableAdapters.mstObatTableAdapter
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idReceiveHeaderTextEdit As TextEdit
    Friend WithEvents idObatLookUpEdit As LookUpEdit
    Friend WithEvents jumlahTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidReceiveHeader As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidObat As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForjumlah As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents ReceiveDetailTableAdapter1 As DataSetReceiveTableAdapters.receiveDetailTableAdapter
    Friend WithEvents ReceiveDetailTableAdapter2 As DataSetReceiveTableAdapters.receiveDetailTableAdapter
End Class
