Partial Public Class MainForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Dim GalleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
        Dim GalleryItem2 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
        Dim GalleryItem3 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
        Dim GalleryItem4 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.labelDateTime = New DevExpress.XtraBars.BarStaticItem()
        Me.BarDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
        Me.labelFullName = New DevExpress.XtraBars.BarStaticItem()
        Me.menuUser = New DevExpress.XtraBars.BarButtonItem()
        Me.menuChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.menuJabatan = New DevExpress.XtraBars.BarButtonItem()
        Me.menuKaryawan = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMapping = New DevExpress.XtraBars.BarButtonItem()
        Me.menuJenisObat = New DevExpress.XtraBars.BarButtonItem()
        Me.menuSatuanObat = New DevExpress.XtraBars.BarButtonItem()
        Me.menuDaftarObat = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.menuSupplier = New DevExpress.XtraBars.BarButtonItem()
        Me.menuReceive = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpSettings = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.Controller = Me.BarAndDockingController1
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.labelDateTime, Me.BarDockingMenuItem1, Me.labelFullName, Me.menuUser, Me.menuChangePassword, Me.menuJabatan, Me.menuKaryawan, Me.menuMapping, Me.menuJenisObat, Me.menuSatuanObat, Me.menuDaftarObat, Me.RibbonGalleryBarItem1, Me.menuSupplier, Me.menuReceive})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 15
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.RibbonPage2, Me.rpSettings})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(758, 146)
        Me.ribbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 1
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'labelDateTime
        '
        Me.labelDateTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.labelDateTime.Caption = "lblDate"
        Me.labelDateTime.Id = 1
        Me.labelDateTime.Name = "labelDateTime"
        Me.labelDateTime.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarDockingMenuItem1
        '
        Me.BarDockingMenuItem1.Caption = "BarDockingMenuItem1"
        Me.BarDockingMenuItem1.Id = 2
        Me.BarDockingMenuItem1.Name = "BarDockingMenuItem1"
        '
        'labelFullName
        '
        Me.labelFullName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.labelFullName.Caption = "BarStaticItem2"
        Me.labelFullName.Id = 3
        Me.labelFullName.Name = "labelFullName"
        Me.labelFullName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'menuUser
        '
        Me.menuUser.Caption = "User"
        Me.menuUser.Glyph = CType(resources.GetObject("menuUser.Glyph"), System.Drawing.Image)
        Me.menuUser.Id = 4
        Me.menuUser.LargeGlyph = CType(resources.GetObject("menuUser.LargeGlyph"), System.Drawing.Image)
        Me.menuUser.Name = "menuUser"
        '
        'menuChangePassword
        '
        Me.menuChangePassword.Caption = "Change Password"
        Me.menuChangePassword.Glyph = Global.MandalaPharmacy.My.Resources.Resources.pin_code__1_
        Me.menuChangePassword.Id = 5
        Me.menuChangePassword.LargeGlyph = Global.MandalaPharmacy.My.Resources.Resources.pin_code__1_
        Me.menuChangePassword.Name = "menuChangePassword"
        '
        'menuJabatan
        '
        Me.menuJabatan.Caption = "Jabatan"
        Me.menuJabatan.Glyph = Global.MandalaPharmacy.My.Resources.Resources.business_links_between_businessmen
        Me.menuJabatan.Id = 6
        Me.menuJabatan.Name = "menuJabatan"
        Me.menuJabatan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuKaryawan
        '
        Me.menuKaryawan.Caption = "Karyawan"
        Me.menuKaryawan.Glyph = Global.MandalaPharmacy.My.Resources.Resources.businessman
        Me.menuKaryawan.Id = 7
        Me.menuKaryawan.Name = "menuKaryawan"
        Me.menuKaryawan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuMapping
        '
        Me.menuMapping.Caption = "Mapping Jabatan Karyawan"
        Me.menuMapping.Glyph = Global.MandalaPharmacy.My.Resources.Resources.connected_databases
        Me.menuMapping.Id = 8
        Me.menuMapping.Name = "menuMapping"
        Me.menuMapping.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuJenisObat
        '
        Me.menuJenisObat.Caption = "Jenis Obat"
        Me.menuJenisObat.Glyph = Global.MandalaPharmacy.My.Resources.Resources.emergency_kit
        Me.menuJenisObat.Id = 9
        Me.menuJenisObat.Name = "menuJenisObat"
        Me.menuJenisObat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuSatuanObat
        '
        Me.menuSatuanObat.Caption = "Satuan Obat"
        Me.menuSatuanObat.Glyph = Global.MandalaPharmacy.My.Resources.Resources.speedometer
        Me.menuSatuanObat.Id = 10
        Me.menuSatuanObat.Name = "menuSatuanObat"
        Me.menuSatuanObat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuDaftarObat
        '
        Me.menuDaftarObat.Caption = "Daftar Obat"
        Me.menuDaftarObat.Glyph = Global.MandalaPharmacy.My.Resources.Resources.medicine
        Me.menuDaftarObat.Id = 11
        Me.menuDaftarObat.Name = "menuDaftarObat"
        Me.menuDaftarObat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "RibbonGalleryBarItem1"
        '
        '
        '
        Me.RibbonGalleryBarItem1.Gallery.AllowHoverImages = True
        GalleryItemGroup1.Caption = "Group1"
        GalleryItem1.Caption = "Item1"
        GalleryItem1.Image = CType(resources.GetObject("GalleryItem1.Image"), System.Drawing.Image)
        GalleryItem2.Caption = "Item2"
        GalleryItem2.Image = CType(resources.GetObject("GalleryItem2.Image"), System.Drawing.Image)
        GalleryItem3.Caption = "Item3"
        GalleryItem3.Image = CType(resources.GetObject("GalleryItem3.Image"), System.Drawing.Image)
        GalleryItem4.Caption = "Item4"
        GalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {GalleryItem1, GalleryItem2, GalleryItem3, GalleryItem4})
        Me.RibbonGalleryBarItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.RibbonGalleryBarItem1.Gallery.HoverImageSize = New System.Drawing.Size(54, 54)
        Me.RibbonGalleryBarItem1.Id = 12
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'menuSupplier
        '
        Me.menuSupplier.Caption = "Supplier"
        Me.menuSupplier.Glyph = Global.MandalaPharmacy.My.Resources.Resources.shopping_cart
        Me.menuSupplier.Id = 13
        Me.menuSupplier.Name = "menuSupplier"
        Me.menuSupplier.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuReceive
        '
        Me.menuReceive.Caption = "Terima Barang"
        Me.menuReceive.Glyph = Global.MandalaPharmacy.My.Resources.Resources.hospital_supplies
        Me.menuReceive.Id = 14
        Me.menuReceive.Name = "menuReceive"
        Me.menuReceive.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup5, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.ribbonPage1.KeyTip = "R"
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Data"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.menuUser)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.menuChangePassword)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "User"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.menuSupplier)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Supplier"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuJabatan)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuKaryawan)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuMapping)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Karyawan"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuJenisObat)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuSatuanObat)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuDaftarObat)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Medicine"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Activity"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.menuReceive)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Terima"
        '
        'rpSettings
        '
        Me.rpSettings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.rpSettings.Image = CType(resources.GetObject("rpSettings.Image"), System.Drawing.Image)
        Me.rpSettings.KeyTip = "S"
        Me.rpSettings.Name = "rpSettings"
        Me.rpSettings.Text = "Settings"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.labelFullName)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.labelDateTime)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 329)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(758, 31)
        '
        'mdiManager
        '
        Me.mdiManager.Controller = Me.BarAndDockingController1
        Me.mdiManager.MdiParent = Me
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        '
        'MainForm
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 360)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Ribbon = Me.ribbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents rpSettings As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents labelDateTime As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemTextEdit1 As Repository.RepositoryItemTextEdit
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents mdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents tmrMain As Timer
    Friend WithEvents BarDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
    Public WithEvents labelFullName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents menuUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuChangePassword As XtraBars.BarButtonItem
    Friend WithEvents menuJabatan As XtraBars.BarButtonItem
    Friend WithEvents menuKaryawan As XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuMapping As XtraBars.BarButtonItem
    Friend WithEvents menuJenisObat As XtraBars.BarButtonItem
    Friend WithEvents menuSatuanObat As XtraBars.BarButtonItem
    Friend WithEvents menuDaftarObat As XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonGalleryBarItem1 As XtraBars.RibbonGalleryBarItem
    Friend WithEvents menuSupplier As XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuReceive As XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As XtraBars.Ribbon.RibbonPageGroup
End Class
