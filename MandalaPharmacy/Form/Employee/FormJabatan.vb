Public Class FormJabatan
    Private Sub MstJabatanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstJabatanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstJabatanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetEmployee)

    End Sub

    Private Sub FormJabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetEmployee.mstJabatan' table. You can move, or remove it, as needed.
        Me.MstJabatanTableAdapter.Fill(Me.DataSetEmployee.mstJabatan)

    End Sub
End Class