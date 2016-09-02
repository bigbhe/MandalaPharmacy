Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Module ModuleDescription
    Public crypt As New CryptText("MandalaPharmacy")
    Public rConfig As New ReadConfig
    Public aUser As New ClassActiveUser
    Public oReceive As New ClassReceive
    Public sqlCnn As SqlConnection
    Public sqlCmd As SqlCommand
    Public sqlDta As SqlDataAdapter
    Public sqlDtr As SqlDataReader
    Public sqlTra As SqlTransaction

    Public Enum FormOpenMode
        OpenRead
        OpenEdit
    End Enum

    Public Function dbOpen() As Boolean
        If sqlCnn.State <> ConnectionState.Open Then
            Try
                sqlCnn.Open()
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function

    Public Function dbClose() As Boolean
        If sqlCnn.State = ConnectionState.Open Then
            Try
                sqlCnn.Close()
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function

#Region "Dialog"
    Public Sub alertDialogSuccess(frm As Form, condition As String)
        Dim e As New AlertControl
        e.Show(frm, "Success", condition)
    End Sub

    Public Sub alertDialogFail(frm As Form, condition As String)
        Dim e As New AlertControl
        Beep()
        e.Show(frm, "Attention", condition)
    End Sub
#End Region

#Region "Form Clear"
    Public Sub EmptyTxt(ByVal Frm As Form)
        Dim Ctl As Control
        For Each Ctl In Frm.Controls
            If TypeOf Ctl Is TextEdit Then CType(Ctl, TextEdit).EditValue = ""
            If TypeOf Ctl Is GroupControl Then
                Dim Ctl1 As Control
                For Each Ctl1 In Ctl.Controls
                    If TypeOf Ctl1 Is TextEdit Then
                        Ctl1.Text = ""
                    End If
                Next
            End If



            If TypeOf Ctl Is DevExpress.XtraLayout.LayoutControl Then
                Dim Ctl1 As Control
                For Each Ctl1 In Ctl.Controls
                    If TypeOf Ctl1 Is TextEdit Then
                        Ctl1.Text = ""
                    End If
                    If TypeOf Ctl1 Is SpinEdit Then
                        Ctl1.Text = ""
                    End If
                    If TypeOf Ctl1 Is LookUpEdit Then
                        Ctl1.Text = ""
                    End If
                Next
            End If
        Next
    End Sub
#End Region

#Region "Random Keys"
    Public Function GetUniqueKey(ByVal MaxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(MaxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(MaxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
#End Region
End Module
