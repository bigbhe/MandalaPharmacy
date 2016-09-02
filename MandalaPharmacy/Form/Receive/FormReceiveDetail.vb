Imports DevExpress.XtraGrid.Views.Grid

Public Class FormReceiveDetail
    Private Sub ReceiveDetailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReceiveDetailBindingNavigatorSaveItem.Click
        'DataSetReceive.EnforceConstraints = False

        Me.Validate()
        Me.ReceiveDetailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetReceive)

    End Sub
    Sub LoadData()
        Try
            'DataSetReceive.EnforceConstraints = False
            Me.ReceiveDetailTableAdapter.Fill(Me.DataSetReceive.receiveDetail, CType(oReceive.idReceive, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormReceiveDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSetReceive.mstObat' table. You can move, or remove it, as needed.
        Me.MstObatTableAdapter.Fill(Me.DataSetReceive.mstObat)
        LoadData()
        LayoutControlGroup3.Text = "Detail Obat Masuk Receive Item: " & oReceive.receiveNumber
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidReceiveHeader, oReceive.idReceive)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        DataSetReceive.EnforceConstraints = True
    End Sub
End Class