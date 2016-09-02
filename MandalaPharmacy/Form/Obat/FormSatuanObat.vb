Public Class FormSatuanObat
    Private Sub MstSatuanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstSatuanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstSatuanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetObat)

    End Sub

    Private Sub FormSatuanObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetObat.mstSatuan' table. You can move, or remove it, as needed.
        Me.MstSatuanTableAdapter.Fill(Me.DataSetObat.mstSatuan)

    End Sub
End Class