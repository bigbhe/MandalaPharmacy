Imports System.ComponentModel
Imports System.Text


Partial Public Class MainForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.Skins
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FormLogin.ShowDialog()

    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        labelDateTime.Caption = Format(Now, "HH:mm:ss") + vbCrLf + Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub menuUser_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuUser.ItemClick
        If Me.MdiChildren.Contains(FormUser) Then
            FormUser.Focus()
        Else
            FormUser.MdiParent = Me
            FormUser.Show()
        End If
    End Sub

    Private Sub menuChangePassword_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuChangePassword.ItemClick
        FormChangePassword.ShowDialog()

    End Sub

    Private Sub menuJabatan_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuJabatan.ItemClick
        If Me.MdiChildren.Contains(FormJabatan) Then
            FormJabatan.Focus()
        Else
            'FormJabatan.MdiParent = Me
            FormJabatan.ShowDialog()
        End If
    End Sub

    Private Sub menuKaryawan_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuKaryawan.ItemClick
        If Me.MdiChildren.Contains(FormKaryawan) Then
            FormKaryawan.Focus()
        Else
            FormKaryawan.MdiParent = Me
            FormKaryawan.Show()
        End If
    End Sub

    Private Sub menuMapping_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMapping.ItemClick
        If Me.MdiChildren.Contains(FormMappingKaryawanJabatan) Then
            FormMappingKaryawanJabatan.Focus()
        Else
            FormMappingKaryawanJabatan.MdiParent = Me
            FormMappingKaryawanJabatan.Show()
        End If
    End Sub

    Private Sub menuJenisObat_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuJenisObat.ItemClick
        If Me.MdiChildren.Contains(JenisObat) Then
            JenisObat.Focus()
        Else
            JenisObat.MdiParent = Me
            JenisObat.Show()
        End If
    End Sub

    Private Sub menuSatuanObat_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuSatuanObat.ItemClick
        FormSatuanObat.ShowDialog()
    End Sub

    Private Sub menuDaftarObat_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuDaftarObat.ItemClick
        If Me.MdiChildren.Contains(FormObat) Then
            FormObat.Focus()
        Else
            FormObat.MdiParent = Me
            FormObat.Show()
        End If
    End Sub

    Private Sub menuSupplier_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuSupplier.ItemClick
        If Me.MdiChildren.Contains(FormSupplier) Then
            FormSupplier.Focus()
        Else
            FormSupplier.MdiParent = Me
            FormSupplier.Show()
        End If
    End Sub

    Private Sub menuReceive_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuReceive.ItemClick
        If Me.MdiChildren.Contains(FormReceive) Then
            FormReceive.Focus()
        Else
            FormReceive.MdiParent = Me
            FormReceive.Show()
        End If
    End Sub
End Class
