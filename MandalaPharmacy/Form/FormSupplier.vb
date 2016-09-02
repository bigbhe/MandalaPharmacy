Public Class FormSupplier
    Private Sub MstSupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstSupplierBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstSupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSupplier)

    End Sub

    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSupplier.mstSupplier' table. You can move, or remove it, as needed.
        Me.MstSupplierTableAdapter.Fill(Me.DataSetSupplier.mstSupplier)

    End Sub
End Class