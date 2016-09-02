Public Class FormMappingKaryawanJabatan
    Private Sub MappingEmployeeJabatanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MappingEmployeeJabatanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MappingEmployeeJabatanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetEmployee)

    End Sub

    Private Sub FormMappingKaryawanJabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetEmployee.mstJabatan' table. You can move, or remove it, as needed.
        Me.MstJabatanTableAdapter.Fill(Me.DataSetEmployee.mstJabatan)
        'TODO: This line of code loads data into the 'DataSetEmployee.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.DataSetEmployee.Employee)
        'TODO: This line of code loads data into the 'DataSetEmployee.mappingEmployeeJabatan' table. You can move, or remove it, as needed.
        Me.MappingEmployeeJabatanTableAdapter.Fill(Me.DataSetEmployee.mappingEmployeeJabatan)

    End Sub
End Class