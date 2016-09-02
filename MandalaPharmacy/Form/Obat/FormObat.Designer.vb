<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormObat))
        Me.DataSetObat = New MandalaPharmacy.DataSetObat()
        Me.MstObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstObatTableAdapter = New MandalaPharmacy.DataSetObatTableAdapters.mstObatTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetObatTableAdapters.TableAdapterManager()
        Me.MstObatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstObatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstObatGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidJenis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.idJenisLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForidJenis = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForNama = New DevExpress.XtraLayout.LayoutControlItem()
        Me.idSatuanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForidSatuan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.JenisObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JenisObatTableAdapter = New MandalaPharmacy.DataSetObatTableAdapters.jenisObatTableAdapter()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstSatuanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstSatuanTableAdapter = New MandalaPharmacy.DataSetObatTableAdapters.mstSatuanTableAdapter()
        CType(Me.DataSetObat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstObatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstObatBindingNavigator.SuspendLayout()
        CType(Me.MstObatGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idJenisLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idSatuanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSatuanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetObat
        '
        Me.DataSetObat.DataSetName = "DataSetObat"
        Me.DataSetObat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstObatBindingSource
        '
        Me.MstObatBindingSource.DataMember = "mstObat"
        Me.MstObatBindingSource.DataSource = Me.DataSetObat
        '
        'MstObatTableAdapter
        '
        Me.MstObatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.jenisObatTableAdapter = Me.JenisObatTableAdapter
        Me.TableAdapterManager.mstObatTableAdapter = Me.MstObatTableAdapter
        Me.TableAdapterManager.mstSatuanTableAdapter = Me.MstSatuanTableAdapter
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetObatTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstObatBindingNavigator
        '
        Me.MstObatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstObatBindingNavigator.BindingSource = Me.MstObatBindingSource
        Me.MstObatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstObatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstObatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstObatBindingNavigatorSaveItem})
        Me.MstObatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstObatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstObatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstObatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstObatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstObatBindingNavigator.Name = "MstObatBindingNavigator"
        Me.MstObatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstObatBindingNavigator.Size = New System.Drawing.Size(697, 25)
        Me.MstObatBindingNavigator.TabIndex = 0
        Me.MstObatBindingNavigator.Text = "BindingNavigator1"
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
        'MstObatBindingNavigatorSaveItem
        '
        Me.MstObatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstObatBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstObatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstObatBindingNavigatorSaveItem.Name = "MstObatBindingNavigatorSaveItem"
        Me.MstObatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstObatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstObatGridControl
        '
        Me.MstObatGridControl.DataSource = Me.MstObatBindingSource
        Me.MstObatGridControl.Location = New System.Drawing.Point(300, 12)
        Me.MstObatGridControl.MainView = Me.GridView1
        Me.MstObatGridControl.Name = "MstObatGridControl"
        Me.MstObatGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.MstObatGridControl.Size = New System.Drawing.Size(385, 410)
        Me.MstObatGridControl.TabIndex = 1
        Me.MstObatGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidJenis, Me.colNama, Me.colidSatuan})
        Me.GridView1.GridControl = Me.MstObatGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidJenis
        '
        Me.colidJenis.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidJenis.FieldName = "idJenis"
        Me.colidJenis.Name = "colidJenis"
        Me.colidJenis.Visible = True
        Me.colidJenis.VisibleIndex = 0
        '
        'colNama
        '
        Me.colNama.FieldName = "Nama"
        Me.colNama.Name = "colNama"
        Me.colNama.Visible = True
        Me.colNama.VisibleIndex = 1
        '
        'colidSatuan
        '
        Me.colidSatuan.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidSatuan.FieldName = "idSatuan"
        Me.colidSatuan.Name = "colidSatuan"
        Me.colidSatuan.Visible = True
        Me.colidSatuan.VisibleIndex = 2
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.MstObatGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idJenisLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NamaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idSatuanLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.MstObatBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(697, 434)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(697, 434)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidJenis, Me.ItemForNama, Me.ItemForidSatuan, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(677, 414)
        '
        'idJenisLookUpEdit
        '
        Me.idJenisLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstObatBindingSource, "idJenis", True))
        Me.idJenisLookUpEdit.Location = New System.Drawing.Point(61, 12)
        Me.idJenisLookUpEdit.Name = "idJenisLookUpEdit"
        Me.idJenisLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idJenisLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idJenisLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idJenisLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jenisObat", "jenis Obat", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Gambar", "Gambar", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.idJenisLookUpEdit.Properties.DataSource = Me.JenisObatBindingSource
        Me.idJenisLookUpEdit.Properties.DisplayMember = "jenisObat"
        Me.idJenisLookUpEdit.Properties.NullText = ""
        Me.idJenisLookUpEdit.Properties.ValueMember = "id"
        Me.idJenisLookUpEdit.Size = New System.Drawing.Size(235, 20)
        Me.idJenisLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idJenisLookUpEdit.TabIndex = 4
        '
        'ItemForidJenis
        '
        Me.ItemForidJenis.Control = Me.idJenisLookUpEdit
        Me.ItemForidJenis.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidJenis.Name = "ItemForidJenis"
        Me.ItemForidJenis.Size = New System.Drawing.Size(288, 24)
        Me.ItemForidJenis.Text = "id Jenis"
        Me.ItemForidJenis.TextSize = New System.Drawing.Size(45, 13)
        '
        'NamaTextEdit
        '
        Me.NamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstObatBindingSource, "Nama", True))
        Me.NamaTextEdit.Location = New System.Drawing.Point(61, 36)
        Me.NamaTextEdit.Name = "NamaTextEdit"
        Me.NamaTextEdit.Size = New System.Drawing.Size(235, 20)
        Me.NamaTextEdit.StyleController = Me.DataLayoutControl1
        Me.NamaTextEdit.TabIndex = 5
        '
        'ItemForNama
        '
        Me.ItemForNama.Control = Me.NamaTextEdit
        Me.ItemForNama.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNama.Name = "ItemForNama"
        Me.ItemForNama.Size = New System.Drawing.Size(288, 24)
        Me.ItemForNama.Text = "Nama"
        Me.ItemForNama.TextSize = New System.Drawing.Size(45, 13)
        '
        'idSatuanLookUpEdit
        '
        Me.idSatuanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstObatBindingSource, "idSatuan", True))
        Me.idSatuanLookUpEdit.Location = New System.Drawing.Point(61, 60)
        Me.idSatuanLookUpEdit.Name = "idSatuanLookUpEdit"
        Me.idSatuanLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSatuanLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSatuanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSatuanLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Satuan", "Satuan", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.idSatuanLookUpEdit.Properties.DataSource = Me.MstSatuanBindingSource
        Me.idSatuanLookUpEdit.Properties.DisplayMember = "Satuan"
        Me.idSatuanLookUpEdit.Properties.NullText = ""
        Me.idSatuanLookUpEdit.Properties.ValueMember = "id"
        Me.idSatuanLookUpEdit.Size = New System.Drawing.Size(235, 20)
        Me.idSatuanLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idSatuanLookUpEdit.TabIndex = 6
        '
        'ItemForidSatuan
        '
        Me.ItemForidSatuan.Control = Me.idSatuanLookUpEdit
        Me.ItemForidSatuan.Location = New System.Drawing.Point(0, 48)
        Me.ItemForidSatuan.Name = "ItemForidSatuan"
        Me.ItemForidSatuan.Size = New System.Drawing.Size(288, 366)
        Me.ItemForidSatuan.Text = "id Satuan"
        Me.ItemForidSatuan.TextSize = New System.Drawing.Size(45, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MstObatGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(288, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(389, 414)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.JenisObatBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "jenisObat"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
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
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.MstSatuanBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Satuan"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
        '
        'MstSatuanBindingSource
        '
        Me.MstSatuanBindingSource.DataMember = "mstSatuan"
        Me.MstSatuanBindingSource.DataSource = Me.DataSetObat
        '
        'MstSatuanTableAdapter
        '
        Me.MstSatuanTableAdapter.ClearBeforeFill = True
        '
        'FormObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 459)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MstObatBindingNavigator)
        Me.Name = "FormObat"
        Me.Text = "FormObat"
        CType(Me.DataSetObat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstObatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstObatBindingNavigator.ResumeLayout(False)
        Me.MstObatBindingNavigator.PerformLayout()
        CType(Me.MstObatGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idJenisLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idSatuanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSatuanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetObat As DataSetObat
    Friend WithEvents MstObatBindingSource As BindingSource
    Friend WithEvents MstObatTableAdapter As DataSetObatTableAdapters.mstObatTableAdapter
    Friend WithEvents TableAdapterManager As DataSetObatTableAdapters.TableAdapterManager
    Friend WithEvents MstObatBindingNavigator As BindingNavigator
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
    Friend WithEvents MstObatBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents JenisObatTableAdapter As DataSetObatTableAdapters.jenisObatTableAdapter
    Friend WithEvents MstObatGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidJenis As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents colNama As XtraGrid.Columns.GridColumn
    Friend WithEvents colidSatuan As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idJenisLookUpEdit As LookUpEdit
    Friend WithEvents NamaTextEdit As TextEdit
    Friend WithEvents idSatuanLookUpEdit As LookUpEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidJenis As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNama As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidSatuan As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents JenisObatBindingSource As BindingSource
    Friend WithEvents MstSatuanTableAdapter As DataSetObatTableAdapters.mstSatuanTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents MstSatuanBindingSource As BindingSource
End Class
