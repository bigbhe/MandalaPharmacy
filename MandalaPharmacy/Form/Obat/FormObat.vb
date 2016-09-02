Public Class FormObat
    Private Sub MstObatBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstObatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetObat)

    End Sub

    Private Sub FormObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetObat.mstSatuan' table. You can move, or remove it, as needed.
        Me.MstSatuanTableAdapter.Fill(Me.DataSetObat.mstSatuan)
        'TODO: This line of code loads data into the 'DataSetObat.jenisObat' table. You can move, or remove it, as needed.
        Me.JenisObatTableAdapter.Fill(Me.DataSetObat.jenisObat)
        'TODO: This line of code loads data into the 'DataSetObat.mstObat' table. You can move, or remove it, as needed.
        Me.MstObatTableAdapter.Fill(Me.DataSetObat.mstObat)

    End Sub
End Class