<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSatuanObat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSatuanObat))
        Me.DataSetObat = New MandalaPharmacy.DataSetObat()
        Me.MstSatuanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstSatuanTableAdapter = New MandalaPharmacy.DataSetObatTableAdapters.mstSatuanTableAdapter()
        Me.TableAdapterManager = New MandalaPharmacy.DataSetObatTableAdapters.TableAdapterManager()
        Me.MstSatuanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstSatuanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstSatuanGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetObat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSatuanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSatuanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstSatuanBindingNavigator.SuspendLayout()
        CType(Me.MstSatuanGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetObat
        '
        Me.DataSetObat.DataSetName = "DataSetObat"
        Me.DataSetObat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.jenisObatTableAdapter = Nothing
        Me.TableAdapterManager.mstObatTableAdapter = Nothing
        Me.TableAdapterManager.mstSatuanTableAdapter = Me.MstSatuanTableAdapter
        Me.TableAdapterManager.UpdateOrder = MandalaPharmacy.DataSetObatTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstSatuanBindingNavigator
        '
        Me.MstSatuanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstSatuanBindingNavigator.BindingSource = Me.MstSatuanBindingSource
        Me.MstSatuanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstSatuanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstSatuanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstSatuanBindingNavigatorSaveItem})
        Me.MstSatuanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstSatuanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstSatuanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstSatuanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstSatuanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstSatuanBindingNavigator.Name = "MstSatuanBindingNavigator"
        Me.MstSatuanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstSatuanBindingNavigator.Size = New System.Drawing.Size(300, 25)
        Me.MstSatuanBindingNavigator.TabIndex = 0
        Me.MstSatuanBindingNavigator.Text = "BindingNavigator1"
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
        'MstSatuanBindingNavigatorSaveItem
        '
        Me.MstSatuanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstSatuanBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstSatuanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstSatuanBindingNavigatorSaveItem.Name = "MstSatuanBindingNavigatorSaveItem"
        Me.MstSatuanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MstSatuanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstSatuanGridControl
        '
        Me.MstSatuanGridControl.DataSource = Me.MstSatuanBindingSource
        Me.MstSatuanGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstSatuanGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstSatuanGridControl.MainView = Me.GridView1
        Me.MstSatuanGridControl.Name = "MstSatuanGridControl"
        Me.MstSatuanGridControl.Size = New System.Drawing.Size(300, 510)
        Me.MstSatuanGridControl.TabIndex = 1
        Me.MstSatuanGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colSatuan})
        Me.GridView1.GridControl = Me.MstSatuanGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colSatuan
        '
        Me.colSatuan.FieldName = "Satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 0
        '
        'FormSatuanObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 535)
        Me.Controls.Add(Me.MstSatuanGridControl)
        Me.Controls.Add(Me.MstSatuanBindingNavigator)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormSatuanObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSatuanObat"
        CType(Me.DataSetObat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSatuanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSatuanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstSatuanBindingNavigator.ResumeLayout(False)
        Me.MstSatuanBindingNavigator.PerformLayout()
        CType(Me.MstSatuanGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetObat As DataSetObat
    Friend WithEvents MstSatuanBindingSource As BindingSource
    Friend WithEvents MstSatuanTableAdapter As DataSetObatTableAdapters.mstSatuanTableAdapter
    Friend WithEvents TableAdapterManager As DataSetObatTableAdapters.TableAdapterManager
    Friend WithEvents MstSatuanBindingNavigator As BindingNavigator
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
    Friend WithEvents MstSatuanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstSatuanGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As XtraGrid.Columns.GridColumn
End Class
