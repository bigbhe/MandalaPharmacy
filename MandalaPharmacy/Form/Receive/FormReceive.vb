Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FormReceive
    Private finalCode As String

    Private Sub ReceiveHeaderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReceiveHeaderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReceiveHeaderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetReceive)

    End Sub

    Private Sub FormReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetReceive.mstSupplier' table. You can move, or remove it, as needed.
        Me.MstSupplierTableAdapter.Fill(Me.DataSetReceive.mstSupplier)
        'TODO: This line of code loads data into the 'DataSetReceive.receiveHeader' table. You can move, or remove it, as needed.
        Me.ReceiveHeaderTableAdapter.Fill(Me.DataSetReceive.receiveHeader)

    End Sub

    Private Sub GetReceive()
        Dim code As String
        Dim trimmedCode As String
        code = CType(Date.Today, String)
        trimmedCode = Replace(code, "/", "")
        finalCode = String.Format("{0}/{1}", trimmedCode, GetUniqueKey(3))
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        GetReceive()

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colReceiveNumber, finalCode)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If IsDBNull(GridView1.GetFocusedRowCellValue(colReceiveNumber)) Then
            oReceive.receiveNumber = CType(0, String)
        Else
            oReceive.receiveNumber = CType(GridView1.GetFocusedRowCellValue(colReceiveNumber), String)
        End If
        buttonFill.Text = "Isi Detail Data Dari Receive Item Nomor: " & oReceive.receiveNumber
    End Sub

    Private Sub buttonFill_Click(sender As Object, e As EventArgs) Handles buttonFill.Click
        oReceive.idReceive = CInt(GridView1.GetFocusedRowCellValue(colid))
        oReceive.receiveNumber = CType(GridView1.GetFocusedRowCellValue(colReceiveNumber), String)


        Dim frm As New FormReceiveDetail
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.FormBorderStyle = FormBorderStyle.Fixed3D
        frm.FormBorderEffect = FormBorderEffect.Shadow
        frm.ShowDialog()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        DataSetReceive.EnforceConstraints = True

    End Sub
End Class