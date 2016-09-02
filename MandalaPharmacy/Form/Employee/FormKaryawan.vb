Public Class FormKaryawan
    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetEmployee)

    End Sub

    Private Sub FormKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetEmployee.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.DataSetEmployee.Employee)

    End Sub
End Class