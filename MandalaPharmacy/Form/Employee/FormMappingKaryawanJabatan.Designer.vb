<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMappingKaryawanJabatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMappingKaryawanJabatan))
        Me.DataSetEmployee = New MandalaPharmacy.DataSetEmployee()
        Me.MappingEmployeeJabatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MappingEmployeeJabatanTableAdapter = New MandalaPharmacy.DataSetEmployeeTableAdapters.mappingEmployeeJabatanTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetEmployeeTableAdapters.TableAdapterManager()
        Me.MappingEmployeeJabatanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MappingEmployeeJabatanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MappingEmployeeJabatanGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidEmployee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidJabatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New MandalaPharmacy.DataSetEmployeeTableAdapters.EmployeeTableAdapter()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstJabatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstJabatanTableAdapter = New MandalaPharmacy.DataSetEmployeeTableAdapters.mstJabatanTableAdapter()
        CType(Me.DataSetEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MappingEmployeeJabatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MappingEmployeeJabatanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MappingEmployeeJabatanBindingNavigator.SuspendLayout()
        CType(Me.MappingEmployeeJabatanGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstJabatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetEmployee
        '
        Me.DataSetEmployee.DataSetName = "DataSetEmployee"
        Me.DataSetEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MappingEmployeeJabatanBindingSource
        '
        Me.MappingEmployeeJabatanBindingSource.DataMember = "mappingEmployeeJabatan"
        Me.MappingEmployeeJabatanBindingSource.DataSource = Me.DataSetEmployee
        '
        'MappingEmployeeJabatanTableAdapter
        '
        Me.MappingEmployeeJabatanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.mappingEmployeeJabatanTableAdapter = Me.MappingEmployeeJabatanTableAdapter
        Me.TableAdapterManager.mstJabatanTableAdapter = Me.MstJabatanTableAdapter
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetEmployeeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MappingEmployeeJabatanBindingNavigator
        '
        Me.MappingEmployeeJabatanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MappingEmployeeJabatanBindingNavigator.BindingSource = Me.MappingEmployeeJabatanBindingSource
        Me.MappingEmployeeJabatanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MappingEmployeeJabatanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MappingEmployeeJabatanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MappingEmployeeJabatanBindingNavigatorSaveItem})
        Me.MappingEmployeeJabatanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MappingEmployeeJabatanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MappingEmployeeJabatanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MappingEmployeeJabatanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MappingEmployeeJabatanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MappingEmployeeJabatanBindingNavigator.Name = "MappingEmployeeJabatanBindingNavigator"
        Me.MappingEmployeeJabatanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MappingEmployeeJabatanBindingNavigator.Size = New System.Drawing.Size(700, 25)
        Me.MappingEmployeeJabatanBindingNavigator.TabIndex = 0
        Me.MappingEmployeeJabatanBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MappingEmployeeJabatanBindingNavigatorSaveItem
        '
        Me.MappingEmployeeJabatanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MappingEmployeeJabatanBindingNavigatorSaveItem.Image = CType(resources.GetObject("MappingEmployeeJabatanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MappingEmployeeJabatanBindingNavigatorSaveItem.Name = "MappingEmployeeJabatanBindingNavigatorSaveItem"
        Me.MappingEmployeeJabatanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MappingEmployeeJabatanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MappingEmployeeJabatanGridControl
        '
        Me.MappingEmployeeJabatanGridControl.DataSource = Me.MappingEmployeeJabatanBindingSource
        Me.MappingEmployeeJabatanGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MappingEmployeeJabatanGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MappingEmployeeJabatanGridControl.MainView = Me.GridView1
        Me.MappingEmployeeJabatanGridControl.Name = "MappingEmployeeJabatanGridControl"
        Me.MappingEmployeeJabatanGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.MappingEmployeeJabatanGridControl.Size = New System.Drawing.Size(700, 498)
        Me.MappingEmployeeJabatanGridControl.TabIndex = 1
        Me.MappingEmployeeJabatanGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidEmployee, Me.colidJabatan})
        Me.GridView1.GridControl = Me.MappingEmployeeJabatanGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidEmployee
        '
        Me.colidEmployee.Caption = "Karyawan"
        Me.colidEmployee.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidEmployee.FieldName = "idEmployee"
        Me.colidEmployee.Name = "colidEmployee"
        Me.colidEmployee.Visible = True
        Me.colidEmployee.VisibleIndex = 0
        '
        'colidJabatan
        '
        Me.colidJabatan.Caption = "Jabatan"
        Me.colidJabatan.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidJabatan.FieldName = "idJabatan"
        Me.colidJabatan.Name = "colidJabatan"
        Me.colidJabatan.Visible = True
        Me.colidJabatan.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.EmployeeBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.DataSetEmployee
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.MstJabatanBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Jabatan"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
        '
        'MstJabatanBindingSource
        '
        Me.MstJabatanBindingSource.DataMember = "mstJabatan"
        Me.MstJabatanBindingSource.DataSource = Me.DataSetEmployee
        '
        'MstJabatanTableAdapter
        '
        Me.MstJabatanTableAdapter.ClearBeforeFill = True
        '
        'FormMappingKaryawanJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 523)
        Me.Controls.Add(Me.MappingEmployeeJabatanGridControl)
        Me.Controls.Add(Me.MappingEmployeeJabatanBindingNavigator)
        Me.Name = "FormMappingKaryawanJabatan"
        Me.Text = "FormMappingKaryawanJabatan"
        CType(Me.DataSetEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MappingEmployeeJabatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MappingEmployeeJabatanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MappingEmployeeJabatanBindingNavigator.ResumeLayout(False)
        Me.MappingEmployeeJabatanBindingNavigator.PerformLayout()
        CType(Me.MappingEmployeeJabatanGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstJabatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetEmployee As DataSetEmployee
    Friend WithEvents MappingEmployeeJabatanBindingSource As BindingSource
    Friend WithEvents MappingEmployeeJabatanTableAdapter As DataSetEmployeeTableAdapters.mappingEmployeeJabatanTableAdapter
    Friend WithEvents TableAdapterManager As DataSetEmployeeTableAdapters.TableAdapterManager
    Friend WithEvents MappingEmployeeJabatanBindingNavigator As BindingNavigator
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
    Friend WithEvents MappingEmployeeJabatanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmployeeTableAdapter As DataSetEmployeeTableAdapters.EmployeeTableAdapter
    Friend WithEvents MappingEmployeeJabatanGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidEmployee As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents colidJabatan As XtraGrid.Columns.GridColumn
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents MstJabatanTableAdapter As DataSetEmployeeTableAdapters.mstJabatanTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents MstJabatanBindingSource As BindingSource
End Class
