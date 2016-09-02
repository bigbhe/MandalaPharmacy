<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKaryawan))
        Me.DataSetEmployee = New MandalaPharmacy.DataSetEmployee()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New MandalaPharmacy.DataSetEmployeeTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetEmployeeTableAdapters.TableAdapterManager()
        Me.EmployeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmployeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmployeeGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.employeeCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForemployeeCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.addressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForaddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dateOfBirthDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ItemFordateOfBirth = New DevExpress.XtraLayout.LayoutControlItem()
        Me.photoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.ItemForphoto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.DataSetEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeBindingNavigator.SuspendLayout()
        CType(Me.EmployeeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForemployeeCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForaddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfBirthDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFordateOfBirth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetEmployee
        '
        Me.DataSetEmployee.DataSetName = "DataSetEmployee"
        Me.DataSetEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.mappingEmployeeJabatanTableAdapter = Nothing
        Me.TableAdapterManager.mstJabatanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetEmployeeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeBindingNavigator
        '
        Me.EmployeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeBindingNavigator.BindingSource = Me.EmployeeBindingSource
        Me.EmployeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeBindingNavigatorSaveItem})
        Me.EmployeeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeeBindingNavigator.Name = "EmployeeBindingNavigator"
        Me.EmployeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeeBindingNavigator.Size = New System.Drawing.Size(801, 25)
        Me.EmployeeBindingNavigator.TabIndex = 0
        Me.EmployeeBindingNavigator.Text = "BindingNavigator1"
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
        'EmployeeBindingNavigatorSaveItem
        '
        Me.EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeBindingNavigatorSaveItem.Name = "EmployeeBindingNavigatorSaveItem"
        Me.EmployeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EmployeeGridControl
        '
        Me.EmployeeGridControl.DataSource = Me.EmployeeBindingSource
        Me.EmployeeGridControl.Location = New System.Drawing.Point(24, 252)
        Me.EmployeeGridControl.MainView = Me.GridView1
        Me.EmployeeGridControl.Name = "EmployeeGridControl"
        Me.EmployeeGridControl.Size = New System.Drawing.Size(753, 431)
        Me.EmployeeGridControl.TabIndex = 1
        Me.EmployeeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.EmployeeGridControl
        Me.GridView1.Name = "GridView1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.EmployeeGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.employeeCodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.addressTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.dateOfBirthDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.photoPictureEdit)
        Me.DataLayoutControl1.DataSource = Me.EmployeeBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(479, 380, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(801, 707)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(801, 707)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup5, Me.LayoutControlGroup4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(781, 687)
        '
        'employeeCodeTextEdit
        '
        Me.employeeCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeeBindingSource, "employeeCode", True))
        Me.employeeCodeTextEdit.Location = New System.Drawing.Point(102, 42)
        Me.employeeCodeTextEdit.Name = "employeeCodeTextEdit"
        Me.employeeCodeTextEdit.Properties.Mask.EditMask = "[a-z0-9]{0,10}"
        Me.employeeCodeTextEdit.Properties.Mask.IgnoreMaskBlank = False
        Me.employeeCodeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.employeeCodeTextEdit.Properties.Mask.SaveLiteral = False
        Me.employeeCodeTextEdit.Size = New System.Drawing.Size(524, 20)
        Me.employeeCodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.employeeCodeTextEdit.TabIndex = 4
        '
        'ItemForemployeeCode
        '
        Me.ItemForemployeeCode.Control = Me.employeeCodeTextEdit
        Me.ItemForemployeeCode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForemployeeCode.Name = "ItemForemployeeCode"
        Me.ItemForemployeeCode.Size = New System.Drawing.Size(606, 24)
        Me.ItemForemployeeCode.Text = "employee Code"
        Me.ItemForemployeeCode.TextSize = New System.Drawing.Size(74, 13)
        '
        'NameTextEdit
        '
        Me.NameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeeBindingSource, "Name", True))
        Me.NameTextEdit.Location = New System.Drawing.Point(102, 66)
        Me.NameTextEdit.Name = "NameTextEdit"
        Me.NameTextEdit.Size = New System.Drawing.Size(524, 20)
        Me.NameTextEdit.StyleController = Me.DataLayoutControl1
        Me.NameTextEdit.TabIndex = 5
        '
        'ItemForName
        '
        Me.ItemForName.Control = Me.NameTextEdit
        Me.ItemForName.Location = New System.Drawing.Point(0, 24)
        Me.ItemForName.Name = "ItemForName"
        Me.ItemForName.Size = New System.Drawing.Size(606, 24)
        Me.ItemForName.Text = "Name"
        Me.ItemForName.TextSize = New System.Drawing.Size(74, 13)
        '
        'addressTextEdit
        '
        Me.addressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeeBindingSource, "address", True))
        Me.addressTextEdit.Location = New System.Drawing.Point(102, 90)
        Me.addressTextEdit.Name = "addressTextEdit"
        Me.addressTextEdit.Size = New System.Drawing.Size(524, 20)
        Me.addressTextEdit.StyleController = Me.DataLayoutControl1
        Me.addressTextEdit.TabIndex = 6
        '
        'ItemForaddress
        '
        Me.ItemForaddress.Control = Me.addressTextEdit
        Me.ItemForaddress.Location = New System.Drawing.Point(0, 48)
        Me.ItemForaddress.Name = "ItemForaddress"
        Me.ItemForaddress.Size = New System.Drawing.Size(606, 24)
        Me.ItemForaddress.Text = "address"
        Me.ItemForaddress.TextSize = New System.Drawing.Size(74, 13)
        '
        'dateOfBirthDateEdit
        '
        Me.dateOfBirthDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeeBindingSource, "dateOfBirth", True))
        Me.dateOfBirthDateEdit.EditValue = Nothing
        Me.dateOfBirthDateEdit.Location = New System.Drawing.Point(102, 114)
        Me.dateOfBirthDateEdit.Name = "dateOfBirthDateEdit"
        Me.dateOfBirthDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfBirthDateEdit.Size = New System.Drawing.Size(524, 20)
        Me.dateOfBirthDateEdit.StyleController = Me.DataLayoutControl1
        Me.dateOfBirthDateEdit.TabIndex = 7
        '
        'ItemFordateOfBirth
        '
        Me.ItemFordateOfBirth.Control = Me.dateOfBirthDateEdit
        Me.ItemFordateOfBirth.Location = New System.Drawing.Point(0, 72)
        Me.ItemFordateOfBirth.Name = "ItemFordateOfBirth"
        Me.ItemFordateOfBirth.Size = New System.Drawing.Size(606, 96)
        Me.ItemFordateOfBirth.Text = "date Of Birth"
        Me.ItemFordateOfBirth.TextSize = New System.Drawing.Size(74, 13)
        '
        'photoPictureEdit
        '
        Me.photoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.photoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmployeeBindingSource, "photo", True))
        Me.photoPictureEdit.Location = New System.Drawing.Point(654, 42)
        Me.photoPictureEdit.Name = "photoPictureEdit"
        Me.photoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.photoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.photoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.photoPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.photoPictureEdit.Size = New System.Drawing.Size(123, 164)
        Me.photoPictureEdit.StyleController = Me.DataLayoutControl1
        Me.photoPictureEdit.TabIndex = 8
        '
        'ItemForphoto
        '
        Me.ItemForphoto.Control = Me.photoPictureEdit
        Me.ItemForphoto.Location = New System.Drawing.Point(0, 0)
        Me.ItemForphoto.MaxSize = New System.Drawing.Size(127, 168)
        Me.ItemForphoto.MinSize = New System.Drawing.Size(127, 168)
        Me.ItemForphoto.Name = "ItemForphoto"
        Me.ItemForphoto.Size = New System.Drawing.Size(127, 168)
        Me.ItemForphoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForphoto.StartNewLine = True
        Me.ItemForphoto.Text = "photo"
        Me.ItemForphoto.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForphoto.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForemployeeCode, Me.ItemForName, Me.ItemForaddress, Me.ItemFordateOfBirth})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(630, 210)
        Me.LayoutControlGroup3.Text = "Detail Karyawan"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForphoto})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(630, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(151, 210)
        Me.LayoutControlGroup4.Text = "Foto"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.EmployeeGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(757, 435)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(781, 477)
        Me.LayoutControlGroup5.Text = "Daftar Karyawan"
        '
        'FormKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 732)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.EmployeeBindingNavigator)
        Me.Name = "FormKaryawan"
        Me.Text = "FormKaryawan"
        CType(Me.DataSetEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeBindingNavigator.ResumeLayout(False)
        Me.EmployeeBindingNavigator.PerformLayout()
        CType(Me.EmployeeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForemployeeCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForaddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfBirthDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFordateOfBirth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetEmployee As DataSetEmployee
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As DataSetEmployeeTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As DataSetEmployeeTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeBindingNavigator As BindingNavigator
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
    Friend WithEvents EmployeeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmployeeGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents employeeCodeTextEdit As TextEdit
    Friend WithEvents NameTextEdit As TextEdit
    Friend WithEvents addressTextEdit As TextEdit
    Friend WithEvents dateOfBirthDateEdit As DateEdit
    Friend WithEvents photoPictureEdit As PictureEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForemployeeCode As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForName As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForaddress As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFordateOfBirth As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForphoto As XtraLayout.LayoutControlItem
End Class
