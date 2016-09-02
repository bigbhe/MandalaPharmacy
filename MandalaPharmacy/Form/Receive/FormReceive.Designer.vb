<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReceive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReceive))
        Me.DataSetReceive = New MandalaPharmacy.DataSetReceive()
        Me.ReceiveHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveHeaderTableAdapter = New MandalaPharmacy.DataSetReceiveTableAdapters.receiveHeaderTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetReceiveTableAdapters.TableAdapterManager()
        Me.ReceiveHeaderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ReceiveHeaderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.buttonFill = New System.Windows.Forms.ToolStripButton()
        Me.ReceiveHeaderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstSupplierTableAdapter = New MandalaPharmacy.DataSetReceiveTableAdapters.mstSupplierTableAdapter()
        CType(Me.DataSetReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceiveHeaderBindingNavigator.SuspendLayout()
        CType(Me.ReceiveHeaderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetReceive
        '
        Me.DataSetReceive.DataSetName = "DataSetReceive"
        Me.DataSetReceive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiveHeaderBindingSource
        '
        Me.ReceiveHeaderBindingSource.DataMember = "receiveHeader"
        Me.ReceiveHeaderBindingSource.DataSource = Me.DataSetReceive
        '
        'ReceiveHeaderTableAdapter
        '
        Me.ReceiveHeaderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.receiveDetailTableAdapter = Nothing
        Me.TableAdapterManager.receiveHeaderTableAdapter = Me.ReceiveHeaderTableAdapter
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetReceiveTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReceiveHeaderBindingNavigator
        '
        Me.ReceiveHeaderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReceiveHeaderBindingNavigator.BindingSource = Me.ReceiveHeaderBindingSource
        Me.ReceiveHeaderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReceiveHeaderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReceiveHeaderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReceiveHeaderBindingNavigatorSaveItem, Me.buttonFill})
        Me.ReceiveHeaderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReceiveHeaderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReceiveHeaderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReceiveHeaderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReceiveHeaderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReceiveHeaderBindingNavigator.Name = "ReceiveHeaderBindingNavigator"
        Me.ReceiveHeaderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReceiveHeaderBindingNavigator.Size = New System.Drawing.Size(779, 25)
        Me.ReceiveHeaderBindingNavigator.TabIndex = 0
        Me.ReceiveHeaderBindingNavigator.Text = "BindingNavigator1"
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
        'ReceiveHeaderBindingNavigatorSaveItem
        '
        Me.ReceiveHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReceiveHeaderBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReceiveHeaderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReceiveHeaderBindingNavigatorSaveItem.Name = "ReceiveHeaderBindingNavigatorSaveItem"
        Me.ReceiveHeaderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReceiveHeaderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'buttonFill
        '
        Me.buttonFill.Image = Global.MandalaPharmacy.My.Resources.Resources.note
        Me.buttonFill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFill.Name = "buttonFill"
        Me.buttonFill.Size = New System.Drawing.Size(116, 22)
        Me.buttonFill.Text = "ToolStripButton1"
        '
        'ReceiveHeaderGridControl
        '
        Me.ReceiveHeaderGridControl.DataSource = Me.ReceiveHeaderBindingSource
        Me.ReceiveHeaderGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiveHeaderGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ReceiveHeaderGridControl.MainView = Me.GridView1
        Me.ReceiveHeaderGridControl.Name = "ReceiveHeaderGridControl"
        Me.ReceiveHeaderGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.ReceiveHeaderGridControl.Size = New System.Drawing.Size(779, 590)
        Me.ReceiveHeaderGridControl.TabIndex = 1
        Me.ReceiveHeaderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colReceiveNumber, Me.colidSupplier})
        Me.GridView1.GridControl = Me.ReceiveHeaderGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colReceiveNumber
        '
        Me.colReceiveNumber.FieldName = "ReceiveNumber"
        Me.colReceiveNumber.Name = "colReceiveNumber"
        Me.colReceiveNumber.Visible = True
        Me.colReceiveNumber.VisibleIndex = 0
        '
        'colidSupplier
        '
        Me.colidSupplier.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidSupplier.FieldName = "idSupplier"
        Me.colidSupplier.Name = "colidSupplier"
        Me.colidSupplier.Visible = True
        Me.colidSupplier.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstSupplierBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'MstSupplierBindingSource
        '
        Me.MstSupplierBindingSource.DataMember = "mstSupplier"
        Me.MstSupplierBindingSource.DataSource = Me.DataSetReceive
        '
        'MstSupplierTableAdapter
        '
        Me.MstSupplierTableAdapter.ClearBeforeFill = True
        '
        'FormReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 615)
        Me.Controls.Add(Me.ReceiveHeaderGridControl)
        Me.Controls.Add(Me.ReceiveHeaderBindingNavigator)
        Me.Name = "FormReceive"
        Me.Text = "FormReceive"
        CType(Me.DataSetReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceiveHeaderBindingNavigator.ResumeLayout(False)
        Me.ReceiveHeaderBindingNavigator.PerformLayout()
        CType(Me.ReceiveHeaderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetReceive As DataSetReceive
    Friend WithEvents ReceiveHeaderBindingSource As BindingSource
    Friend WithEvents ReceiveHeaderTableAdapter As DataSetReceiveTableAdapters.receiveHeaderTableAdapter
    Friend WithEvents TableAdapterManager As DataSetReceiveTableAdapters.TableAdapterManager
    Friend WithEvents ReceiveHeaderBindingNavigator As BindingNavigator
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
    Friend WithEvents ReceiveHeaderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ReceiveHeaderGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveNumber As XtraGrid.Columns.GridColumn
    Friend WithEvents colidSupplier As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents MstSupplierBindingSource As BindingSource
    Friend WithEvents MstSupplierTableAdapter As DataSetReceiveTableAdapters.mstSupplierTableAdapter
    Friend WithEvents buttonFill As ToolStripButton
End Class
