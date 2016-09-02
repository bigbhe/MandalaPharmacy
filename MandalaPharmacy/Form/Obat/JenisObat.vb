Public Class JenisObat
    Private Sub JenisObatBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JenisObatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JenisObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetObat)

    End Sub

    Private Sub JenisObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetObat.jenisObat' table. You can move, or remove it, as needed.
        Me.JenisObatTableAdapter.Fill(Me.DataSetObat.jenisObat)

    End Sub
End Class