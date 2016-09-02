<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSupplier))
        Me.DataSetSupplier = New MandalaPharmacy.DataSetSupplier()
        Me.MstSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstSupplierTableAdapter = New MandalaPharmacy.DataSetSupplierTableAdapters.mstSupplierTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetSupplierTableAdapters.TableAdapterManager()
        Me.MstSupplierBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstSupplierBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstSupplierGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoneNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.nameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForname = New DevExpress.XtraLayout.LayoutControlItem()
        Me.AddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForAddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.emailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForemail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.phoneNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForphoneNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSupplierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstSupplierBindingNavigator.SuspendLayout()
        CType(Me.MstSupplierGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForemail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phoneNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphoneNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetSupplier
        '
        Me.DataSetSupplier.DataSetName = "DataSetSupplier"
        Me.DataSetSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstSupplierBindingSource
        '
        Me.MstSupplierBindingSource.DataMember = "mstSupplier"
        Me.MstSupplierBindingSource.DataSource = Me.DataSetSupplier
        '
        'MstSupplierTableAdapter
        '
        Me.MstSupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstSupplierTableAdapter = Me.MstSupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetSupplierTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstSupplierBindingNavigator
        '
        Me.MstSupplierBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstSupplierBindingNavigator.BindingSource = Me.MstSupplierBindingSource
        Me.MstSupplierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstSupplierBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstSupplierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstSupplierBindingNavigatorSaveItem})
        Me.MstSupplierBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstSupplierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstSupplierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstSupplierBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstSupplierBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstSupplierBindingNavigator.Name = "MstSupplierBindingNavigator"
        Me.MstSupplierBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstSupplierBindingNavigator.Size = New System.Drawing.Size(762, 25)
        Me.MstSupplierBindingNavigator.TabIndex = 0
        Me.MstSupplierBindingNavigator.Text = "BindingNavigator1"
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
        'MstSupplierBindingNavigatorSaveItem
        '
        Me.MstSupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstSupplierBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstSupplierBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstSupplierBindingNavigatorSaveItem.Name = "MstSupplierBindingNavigatorSaveItem"
        Me.MstSupplierBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstSupplierBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstSupplierGridControl
        '
        Me.MstSupplierGridControl.DataSource = Me.MstSupplierBindingSource
        Me.MstSupplierGridControl.Location = New System.Drawing.Point(320, 12)
        Me.MstSupplierGridControl.MainView = Me.GridView1
        Me.MstSupplierGridControl.Name = "MstSupplierGridControl"
        Me.MstSupplierGridControl.Size = New System.Drawing.Size(430, 479)
        Me.MstSupplierGridControl.TabIndex = 1
        Me.MstSupplierGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colname, Me.colAddress, Me.colemail, Me.colphoneNumber})
        Me.GridView1.GridControl = Me.MstSupplierGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 1
        '
        'colemail
        '
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        Me.colemail.Visible = True
        Me.colemail.VisibleIndex = 2
        '
        'colphoneNumber
        '
        Me.colphoneNumber.FieldName = "phoneNumber"
        Me.colphoneNumber.Name = "colphoneNumber"
        Me.colphoneNumber.Visible = True
        Me.colphoneNumber.VisibleIndex = 3
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.MstSupplierGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.nameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AddressTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.emailTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.phoneNumberTextEdit)
        Me.DataLayoutControl1.DataSource = Me.MstSupplierBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(762, 503)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(762, 503)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForname, Me.ItemForAddress, Me.ItemForemail, Me.ItemForphoneNumber, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(742, 483)
        '
        'nameTextEdit
        '
        Me.nameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstSupplierBindingSource, "name", True))
        Me.nameTextEdit.Location = New System.Drawing.Point(86, 12)
        Me.nameTextEdit.Name = "nameTextEdit"
        Me.nameTextEdit.Size = New System.Drawing.Size(230, 20)
        Me.nameTextEdit.StyleController = Me.DataLayoutControl1
        Me.nameTextEdit.TabIndex = 4
        '
        'ItemForname
        '
        Me.ItemForname.Control = Me.nameTextEdit
        Me.ItemForname.Location = New System.Drawing.Point(0, 0)
        Me.ItemForname.Name = "ItemForname"
        Me.ItemForname.Size = New System.Drawing.Size(308, 24)
        Me.ItemForname.Text = "name"
        Me.ItemForname.TextSize = New System.Drawing.Size(70, 13)
        '
        'AddressTextEdit
        '
        Me.AddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstSupplierBindingSource, "Address", True))
        Me.AddressTextEdit.Location = New System.Drawing.Point(86, 36)
        Me.AddressTextEdit.Name = "AddressTextEdit"
        Me.AddressTextEdit.Size = New System.Drawing.Size(230, 20)
        Me.AddressTextEdit.StyleController = Me.DataLayoutControl1
        Me.AddressTextEdit.TabIndex = 5
        '
        'ItemForAddress
        '
        Me.ItemForAddress.Control = Me.AddressTextEdit
        Me.ItemForAddress.Location = New System.Drawing.Point(0, 24)
        Me.ItemForAddress.Name = "ItemForAddress"
        Me.ItemForAddress.Size = New System.Drawing.Size(308, 24)
        Me.ItemForAddress.Text = "Address"
        Me.ItemForAddress.TextSize = New System.Drawing.Size(70, 13)
        '
        'emailTextEdit
        '
        Me.emailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstSupplierBindingSource, "email", True))
        Me.emailTextEdit.Location = New System.Drawing.Point(86, 60)
        Me.emailTextEdit.Name = "emailTextEdit"
        Me.emailTextEdit.Size = New System.Drawing.Size(230, 20)
        Me.emailTextEdit.StyleController = Me.DataLayoutControl1
        Me.emailTextEdit.TabIndex = 6
        '
        'ItemForemail
        '
        Me.ItemForemail.Control = Me.emailTextEdit
        Me.ItemForemail.Location = New System.Drawing.Point(0, 48)
        Me.ItemForemail.Name = "ItemForemail"
        Me.ItemForemail.Size = New System.Drawing.Size(308, 24)
        Me.ItemForemail.Text = "email"
        Me.ItemForemail.TextSize = New System.Drawing.Size(70, 13)
        '
        'phoneNumberTextEdit
        '
        Me.phoneNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstSupplierBindingSource, "phoneNumber", True))
        Me.phoneNumberTextEdit.Location = New System.Drawing.Point(86, 84)
        Me.phoneNumberTextEdit.Name = "phoneNumberTextEdit"
        Me.phoneNumberTextEdit.Size = New System.Drawing.Size(230, 20)
        Me.phoneNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.phoneNumberTextEdit.TabIndex = 7
        '
        'ItemForphoneNumber
        '
        Me.ItemForphoneNumber.Control = Me.phoneNumberTextEdit
        Me.ItemForphoneNumber.Location = New System.Drawing.Point(0, 72)
        Me.ItemForphoneNumber.Name = "ItemForphoneNumber"
        Me.ItemForphoneNumber.Size = New System.Drawing.Size(308, 411)
        Me.ItemForphoneNumber.Text = "phone Number"
        Me.ItemForphoneNumber.TextSize = New System.Drawing.Size(70, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MstSupplierGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(308, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(434, 483)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 528)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MstSupplierBindingNavigator)
        Me.Name = "FormSupplier"
        Me.Text = "FormSupplier"
        CType(Me.DataSetSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSupplierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstSupplierBindingNavigator.ResumeLayout(False)
        Me.MstSupplierBindingNavigator.PerformLayout()
        CType(Me.MstSupplierGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForemail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phoneNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphoneNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetSupplier As DataSetSupplier
    Friend WithEvents MstSupplierBindingSource As BindingSource
    Friend WithEvents MstSupplierTableAdapter As DataSetSupplierTableAdapters.mstSupplierTableAdapter
    Friend WithEvents TableAdapterManager As DataSetSupplierTableAdapters.TableAdapterManager
    Friend WithEvents MstSupplierBindingNavigator As BindingNavigator
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
    Friend WithEvents MstSupplierBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstSupplierGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colname As XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As XtraGrid.Columns.GridColumn
    Friend WithEvents colphoneNumber As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents nameTextEdit As TextEdit
    Friend WithEvents AddressTextEdit As TextEdit
    Friend WithEvents emailTextEdit As TextEdit
    Friend WithEvents phoneNumberTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForname As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAddress As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForemail As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForphoneNumber As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
End Class
