<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJabatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJabatan))
        Me.DataSetEmployee = New MandalaPharmacy.DataSetEmployee()
        Me.MstJabatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstJabatanTableAdapter = New MandalaPharmacy.DataSetEmployeeTableAdapters.mstJabatanTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetEmployeeTableAdapters.TableAdapterManager()
        Me.MstJabatanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstJabatanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstJabatanGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJabatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.JabatanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForJabatan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstJabatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstJabatanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstJabatanBindingNavigator.SuspendLayout()
        CType(Me.MstJabatanGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.JabatanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetEmployee
        '
        Me.DataSetEmployee.DataSetName = "DataSetEmployee"
        Me.DataSetEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.mappingEmployeeJabatanTableAdapter = Nothing
        Me.TableAdapterManager.mstJabatanTableAdapter = Me.MstJabatanTableAdapter
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetEmployeeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstJabatanBindingNavigator
        '
        Me.MstJabatanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstJabatanBindingNavigator.BindingSource = Me.MstJabatanBindingSource
        Me.MstJabatanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstJabatanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstJabatanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstJabatanBindingNavigatorSaveItem})
        Me.MstJabatanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstJabatanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstJabatanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstJabatanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstJabatanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstJabatanBindingNavigator.Name = "MstJabatanBindingNavigator"
        Me.MstJabatanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstJabatanBindingNavigator.Size = New System.Drawing.Size(504, 25)
        Me.MstJabatanBindingNavigator.TabIndex = 0
        Me.MstJabatanBindingNavigator.Text = "BindingNavigator1"
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
        'MstJabatanBindingNavigatorSaveItem
        '
        Me.MstJabatanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstJabatanBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstJabatanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstJabatanBindingNavigatorSaveItem.Name = "MstJabatanBindingNavigatorSaveItem"
        Me.MstJabatanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstJabatanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstJabatanGridControl
        '
        Me.MstJabatanGridControl.DataSource = Me.MstJabatanBindingSource
        Me.MstJabatanGridControl.Location = New System.Drawing.Point(12, 36)
        Me.MstJabatanGridControl.MainView = Me.GridView1
        Me.MstJabatanGridControl.Name = "MstJabatanGridControl"
        Me.MstJabatanGridControl.Size = New System.Drawing.Size(480, 524)
        Me.MstJabatanGridControl.TabIndex = 1
        Me.MstJabatanGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colJabatan})
        Me.GridView1.GridControl = Me.MstJabatanGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colJabatan
        '
        Me.colJabatan.FieldName = "Jabatan"
        Me.colJabatan.Name = "colJabatan"
        Me.colJabatan.Visible = True
        Me.colJabatan.VisibleIndex = 0
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.MstJabatanGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.JabatanTextEdit)
        Me.DataLayoutControl1.DataSource = Me.MstJabatanBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(504, 572)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'JabatanTextEdit
        '
        Me.JabatanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstJabatanBindingSource, "Jabatan", True))
        Me.JabatanTextEdit.Location = New System.Drawing.Point(54, 12)
        Me.JabatanTextEdit.Name = "JabatanTextEdit"
        Me.JabatanTextEdit.Size = New System.Drawing.Size(438, 20)
        Me.JabatanTextEdit.StyleController = Me.DataLayoutControl1
        Me.JabatanTextEdit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(504, 572)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForJabatan, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(484, 552)
        '
        'ItemForJabatan
        '
        Me.ItemForJabatan.Control = Me.JabatanTextEdit
        Me.ItemForJabatan.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJabatan.Name = "ItemForJabatan"
        Me.ItemForJabatan.Size = New System.Drawing.Size(484, 24)
        Me.ItemForJabatan.Text = "Jabatan"
        Me.ItemForJabatan.TextSize = New System.Drawing.Size(39, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MstJabatanGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(484, 528)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 597)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MstJabatanBindingNavigator)
        Me.Name = "FormJabatan"
        Me.Text = "FormJabatan"
        CType(Me.DataSetEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstJabatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstJabatanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstJabatanBindingNavigator.ResumeLayout(False)
        Me.MstJabatanBindingNavigator.PerformLayout()
        CType(Me.MstJabatanGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.JabatanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJabatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetEmployee As DataSetEmployee
    Friend WithEvents MstJabatanBindingSource As BindingSource
    Friend WithEvents MstJabatanTableAdapter As DataSetEmployeeTableAdapters.mstJabatanTableAdapter
    Friend WithEvents TableAdapterManager As DataSetEmployeeTableAdapters.TableAdapterManager
    Friend WithEvents MstJabatanBindingNavigator As BindingNavigator
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
    Friend WithEvents MstJabatanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstJabatanGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents JabatanTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForJabatan As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colJabatan As XtraGrid.Columns.GridColumn
End Class
