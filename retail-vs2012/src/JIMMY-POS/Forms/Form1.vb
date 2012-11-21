#Region "imports"
Imports WMPLib
Imports MessengerAPI
Imports MessengerAPI.MessengerClass
Imports System.IO
#End Region
Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnesc As System.Windows.Forms.Button
    Friend WithEvents btnf1 As System.Windows.Forms.Button
    Friend WithEvents btnf2 As System.Windows.Forms.Button
    Friend WithEvents btnf3 As System.Windows.Forms.Button
    Friend WithEvents btnf4 As System.Windows.Forms.Button
    Friend WithEvents btnf5 As System.Windows.Forms.Button
    Friend WithEvents btnf6 As System.Windows.Forms.Button
    Friend WithEvents btnf7 As System.Windows.Forms.Button
    Friend WithEvents btnf8 As System.Windows.Forms.Button
    Friend WithEvents btnf9 As System.Windows.Forms.Button
    Friend WithEvents btnf10 As System.Windows.Forms.Button
    Friend WithEvents btnf11 As System.Windows.Forms.Button
    Friend WithEvents btnf12 As System.Windows.Forms.Button
    Friend WithEvents btnpsc As System.Windows.Forms.Button
    Friend WithEvents btnslk As System.Windows.Forms.Button
    Friend WithEvents btnbrk As System.Windows.Forms.Button
    Friend WithEvents btncifttirnak As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btncarpi As System.Windows.Forms.Button
    Friend WithEvents btneksi As System.Windows.Forms.Button
    Friend WithEvents btnbackspace As System.Windows.Forms.Button
    Friend WithEvents btnins As System.Windows.Forms.Button
    Friend WithEvents btnhm As System.Windows.Forms.Button
    Friend WithEvents btnpup As System.Windows.Forms.Button
    Friend WithEvents btntab As System.Windows.Forms.Button
    Friend WithEvents btnq As System.Windows.Forms.Button
    Friend WithEvents btnw As System.Windows.Forms.Button
    Friend WithEvents btne As System.Windows.Forms.Button
    Friend WithEvents btnr As System.Windows.Forms.Button
    Friend WithEvents btnt As System.Windows.Forms.Button
    Friend WithEvents btny As System.Windows.Forms.Button
    Friend WithEvents btnu As System.Windows.Forms.Button
    Friend WithEvents btn_i As System.Windows.Forms.Button
    Friend WithEvents btno As System.Windows.Forms.Button
    Friend WithEvents btnp As System.Windows.Forms.Button
    Friend WithEvents btn_g As System.Windows.Forms.Button
    Friend WithEvents btn_u As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnend As System.Windows.Forms.Button
    Friend WithEvents btnpdn As System.Windows.Forms.Button
    Friend WithEvents btnlock As System.Windows.Forms.Button
    Friend WithEvents btna As System.Windows.Forms.Button
    Friend WithEvents btns As System.Windows.Forms.Button
    Friend WithEvents btnd As System.Windows.Forms.Button
    Friend WithEvents btnf As System.Windows.Forms.Button
    Friend WithEvents btng As System.Windows.Forms.Button
    Friend WithEvents btnh As System.Windows.Forms.Button
    Friend WithEvents btnj As System.Windows.Forms.Button
    Friend WithEvents btnk As System.Windows.Forms.Button
    Friend WithEvents btnl As System.Windows.Forms.Button
    Friend WithEvents btn_s As System.Windows.Forms.Button
    Friend WithEvents btni As System.Windows.Forms.Button
    Friend WithEvents btnenter As System.Windows.Forms.Button
    Friend WithEvents btnsolshift As System.Windows.Forms.Button
    Friend WithEvents btnz As System.Windows.Forms.Button
    Friend WithEvents btnx As System.Windows.Forms.Button
    Friend WithEvents btnc As System.Windows.Forms.Button
    Friend WithEvents btnv As System.Windows.Forms.Button
    Friend WithEvents btnb As System.Windows.Forms.Button
    Friend WithEvents btnn As System.Windows.Forms.Button
    Friend WithEvents btnm As System.Windows.Forms.Button
    Friend WithEvents btn_o As System.Windows.Forms.Button
    Friend WithEvents btn_c As System.Windows.Forms.Button
    Friend WithEvents btnnokta As System.Windows.Forms.Button
    Friend WithEvents btnsagshift As System.Windows.Forms.Button
    Friend WithEvents btnyukari As System.Windows.Forms.Button
    Friend WithEvents btnsolctrl As System.Windows.Forms.Button
    Friend WithEvents btnsolwindows As System.Windows.Forms.Button
    Friend WithEvents btnsolalt As System.Windows.Forms.Button
    Friend WithEvents btnspace As System.Windows.Forms.Button
    Friend WithEvents btnsagaltgr As System.Windows.Forms.Button
    Friend WithEvents btnsagwindows As System.Windows.Forms.Button
    Friend WithEvents btnsagtus As System.Windows.Forms.Button
    Friend WithEvents btnsagctrl As System.Windows.Forms.Button
    Friend WithEvents btnasagi As System.Windows.Forms.Button
    Friend WithEvents btnsol As System.Windows.Forms.Button
    Friend WithEvents btnsag As System.Windows.Forms.Button
    Friend WithEvents btnnumlock As System.Windows.Forms.Button
    Friend WithEvents btnnumlockbolu As System.Windows.Forms.Button
    Friend WithEvents btnnumlockcarpi As System.Windows.Forms.Button
    Friend WithEvents btnnumlockeksi As System.Windows.Forms.Button
    Friend WithEvents btnnumlockarti As System.Windows.Forms.Button
    Friend WithEvents btnnumlock9 As System.Windows.Forms.Button
    Friend WithEvents btnnumlock8 As System.Windows.Forms.Button
    Friend WithEvents btnnumlock7 As System.Windows.Forms.Button
    Friend WithEvents btnnumlock6 As System.Windows.Forms.Button
    Friend WithEvents btnnumlock5 As System.Windows.Forms.Button
    Friend WithEvents btnnumlock4 As System.Windows.Forms.Button
    Friend WithEvents btnnumlockenter As System.Windows.Forms.Button
    Friend WithEvents btnnumlock3 As System.Windows.Forms.Button
    Friend WithEvents btnnumlock2 As System.Windows.Forms.Button
    Friend WithEvents btnnumlock1 As System.Windows.Forms.Button
    Friend WithEvents btnnumlock0 As System.Windows.Forms.Button
    Friend WithEvents btnnumlocknokta As System.Windows.Forms.Button
    Friend WithEvents btnvirgul As System.Windows.Forms.Button
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton14 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton15 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton16 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton17 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton18 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton19 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton20 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txtbilgi As System.Windows.Forms.TextBox
    Friend WithEvents nodi As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolBarButton21 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton22 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton23 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton24 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton25 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton26 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton27 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton28 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton29 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton30 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton31 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton32 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton33 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton34 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton35 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton36 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton37 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton38 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton39 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.btnesc = New System.Windows.Forms.Button
        Me.btnf1 = New System.Windows.Forms.Button
        Me.btnf2 = New System.Windows.Forms.Button
        Me.btnf3 = New System.Windows.Forms.Button
        Me.btnf4 = New System.Windows.Forms.Button
        Me.btnf5 = New System.Windows.Forms.Button
        Me.btnf6 = New System.Windows.Forms.Button
        Me.btnf7 = New System.Windows.Forms.Button
        Me.btnf8 = New System.Windows.Forms.Button
        Me.btnf9 = New System.Windows.Forms.Button
        Me.btnf10 = New System.Windows.Forms.Button
        Me.btnf11 = New System.Windows.Forms.Button
        Me.btnf12 = New System.Windows.Forms.Button
        Me.btnpsc = New System.Windows.Forms.Button
        Me.btnslk = New System.Windows.Forms.Button
        Me.btnbrk = New System.Windows.Forms.Button
        Me.btncifttirnak = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn6 = New System.Windows.Forms.Button
        Me.btn7 = New System.Windows.Forms.Button
        Me.btn8 = New System.Windows.Forms.Button
        Me.btn9 = New System.Windows.Forms.Button
        Me.btn0 = New System.Windows.Forms.Button
        Me.btncarpi = New System.Windows.Forms.Button
        Me.btneksi = New System.Windows.Forms.Button
        Me.btnbackspace = New System.Windows.Forms.Button
        Me.btnins = New System.Windows.Forms.Button
        Me.btnhm = New System.Windows.Forms.Button
        Me.btnpup = New System.Windows.Forms.Button
        Me.btntab = New System.Windows.Forms.Button
        Me.btnq = New System.Windows.Forms.Button
        Me.btnw = New System.Windows.Forms.Button
        Me.btne = New System.Windows.Forms.Button
        Me.btnr = New System.Windows.Forms.Button
        Me.btnt = New System.Windows.Forms.Button
        Me.btny = New System.Windows.Forms.Button
        Me.btnu = New System.Windows.Forms.Button
        Me.btn_i = New System.Windows.Forms.Button
        Me.btno = New System.Windows.Forms.Button
        Me.btnp = New System.Windows.Forms.Button
        Me.btn_g = New System.Windows.Forms.Button
        Me.btn_u = New System.Windows.Forms.Button
        Me.btnvirgul = New System.Windows.Forms.Button
        Me.btndel = New System.Windows.Forms.Button
        Me.btnend = New System.Windows.Forms.Button
        Me.btnpdn = New System.Windows.Forms.Button
        Me.btnlock = New System.Windows.Forms.Button
        Me.btna = New System.Windows.Forms.Button
        Me.btns = New System.Windows.Forms.Button
        Me.btnd = New System.Windows.Forms.Button
        Me.btnf = New System.Windows.Forms.Button
        Me.btng = New System.Windows.Forms.Button
        Me.btnh = New System.Windows.Forms.Button
        Me.btnj = New System.Windows.Forms.Button
        Me.btnk = New System.Windows.Forms.Button
        Me.btnl = New System.Windows.Forms.Button
        Me.btn_s = New System.Windows.Forms.Button
        Me.btni = New System.Windows.Forms.Button
        Me.btnenter = New System.Windows.Forms.Button
        Me.btnsolshift = New System.Windows.Forms.Button
        Me.btnz = New System.Windows.Forms.Button
        Me.btnx = New System.Windows.Forms.Button
        Me.btnc = New System.Windows.Forms.Button
        Me.btnv = New System.Windows.Forms.Button
        Me.btnb = New System.Windows.Forms.Button
        Me.btnn = New System.Windows.Forms.Button
        Me.btnm = New System.Windows.Forms.Button
        Me.btn_o = New System.Windows.Forms.Button
        Me.btn_c = New System.Windows.Forms.Button
        Me.btnnokta = New System.Windows.Forms.Button
        Me.btnsagshift = New System.Windows.Forms.Button
        Me.btnyukari = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnsolctrl = New System.Windows.Forms.Button
        Me.btnsolwindows = New System.Windows.Forms.Button
        Me.btnsolalt = New System.Windows.Forms.Button
        Me.btnspace = New System.Windows.Forms.Button
        Me.btnsagaltgr = New System.Windows.Forms.Button
        Me.btnsagwindows = New System.Windows.Forms.Button
        Me.btnsagtus = New System.Windows.Forms.Button
        Me.btnsagctrl = New System.Windows.Forms.Button
        Me.btnasagi = New System.Windows.Forms.Button
        Me.btnsol = New System.Windows.Forms.Button
        Me.btnsag = New System.Windows.Forms.Button
        Me.btnnumlock = New System.Windows.Forms.Button
        Me.btnnumlockbolu = New System.Windows.Forms.Button
        Me.btnnumlockcarpi = New System.Windows.Forms.Button
        Me.btnnumlockeksi = New System.Windows.Forms.Button
        Me.btnnumlockarti = New System.Windows.Forms.Button
        Me.btnnumlock9 = New System.Windows.Forms.Button
        Me.btnnumlock8 = New System.Windows.Forms.Button
        Me.btnnumlock7 = New System.Windows.Forms.Button
        Me.btnnumlock6 = New System.Windows.Forms.Button
        Me.btnnumlock5 = New System.Windows.Forms.Button
        Me.btnnumlock4 = New System.Windows.Forms.Button
        Me.btnnumlockenter = New System.Windows.Forms.Button
        Me.btnnumlock3 = New System.Windows.Forms.Button
        Me.btnnumlock2 = New System.Windows.Forms.Button
        Me.btnnumlock1 = New System.Windows.Forms.Button
        Me.btnnumlock0 = New System.Windows.Forms.Button
        Me.btnnumlocknokta = New System.Windows.Forms.Button
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton21 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton22 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton23 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton24 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton25 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton26 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton27 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton28 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton29 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton30 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton31 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton32 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton33 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton14 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton34 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton15 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton35 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton16 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton36 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton17 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton37 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton18 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton38 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton19 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton39 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton20 = New System.Windows.Forms.ToolBarButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtbilgi = New System.Windows.Forms.TextBox
        Me.nodi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'btnesc
        '
        Me.btnesc.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnesc.Location = New System.Drawing.Point(8, 32)
        Me.btnesc.Name = "btnesc"
        Me.btnesc.Size = New System.Drawing.Size(32, 24)
        Me.btnesc.TabIndex = 0
        Me.btnesc.Text = "esc"
        '
        'btnf1
        '
        Me.btnf1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf1.Location = New System.Drawing.Point(72, 32)
        Me.btnf1.Name = "btnf1"
        Me.btnf1.Size = New System.Drawing.Size(32, 24)
        Me.btnf1.TabIndex = 1
        Me.btnf1.Text = "F1"
        '
        'btnf2
        '
        Me.btnf2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf2.Location = New System.Drawing.Point(104, 32)
        Me.btnf2.Name = "btnf2"
        Me.btnf2.Size = New System.Drawing.Size(32, 24)
        Me.btnf2.TabIndex = 2
        Me.btnf2.Text = "F2"
        '
        'btnf3
        '
        Me.btnf3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf3.Location = New System.Drawing.Point(136, 32)
        Me.btnf3.Name = "btnf3"
        Me.btnf3.Size = New System.Drawing.Size(32, 24)
        Me.btnf3.TabIndex = 3
        Me.btnf3.Text = "F3"
        '
        'btnf4
        '
        Me.btnf4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf4.Location = New System.Drawing.Point(168, 32)
        Me.btnf4.Name = "btnf4"
        Me.btnf4.Size = New System.Drawing.Size(32, 24)
        Me.btnf4.TabIndex = 4
        Me.btnf4.Text = "F4"
        '
        'btnf5
        '
        Me.btnf5.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf5.Location = New System.Drawing.Point(224, 32)
        Me.btnf5.Name = "btnf5"
        Me.btnf5.Size = New System.Drawing.Size(32, 24)
        Me.btnf5.TabIndex = 5
        Me.btnf5.Text = "F5"
        '
        'btnf6
        '
        Me.btnf6.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf6.Location = New System.Drawing.Point(256, 32)
        Me.btnf6.Name = "btnf6"
        Me.btnf6.Size = New System.Drawing.Size(32, 24)
        Me.btnf6.TabIndex = 6
        Me.btnf6.Text = "F6"
        '
        'btnf7
        '
        Me.btnf7.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf7.Location = New System.Drawing.Point(288, 32)
        Me.btnf7.Name = "btnf7"
        Me.btnf7.Size = New System.Drawing.Size(32, 24)
        Me.btnf7.TabIndex = 7
        Me.btnf7.Text = "F7"
        '
        'btnf8
        '
        Me.btnf8.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf8.Location = New System.Drawing.Point(320, 32)
        Me.btnf8.Name = "btnf8"
        Me.btnf8.Size = New System.Drawing.Size(32, 24)
        Me.btnf8.TabIndex = 8
        Me.btnf8.Text = "F8"
        '
        'btnf9
        '
        Me.btnf9.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf9.Location = New System.Drawing.Point(376, 32)
        Me.btnf9.Name = "btnf9"
        Me.btnf9.Size = New System.Drawing.Size(32, 24)
        Me.btnf9.TabIndex = 9
        Me.btnf9.Text = "F9"
        '
        'btnf10
        '
        Me.btnf10.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf10.Location = New System.Drawing.Point(408, 32)
        Me.btnf10.Name = "btnf10"
        Me.btnf10.Size = New System.Drawing.Size(32, 24)
        Me.btnf10.TabIndex = 10
        Me.btnf10.Text = "F10"
        '
        'btnf11
        '
        Me.btnf11.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf11.Location = New System.Drawing.Point(440, 32)
        Me.btnf11.Name = "btnf11"
        Me.btnf11.Size = New System.Drawing.Size(32, 24)
        Me.btnf11.TabIndex = 11
        Me.btnf11.Text = "F11"
        '
        'btnf12
        '
        Me.btnf12.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf12.Location = New System.Drawing.Point(472, 32)
        Me.btnf12.Name = "btnf12"
        Me.btnf12.Size = New System.Drawing.Size(32, 24)
        Me.btnf12.TabIndex = 12
        Me.btnf12.Text = "F12"
        '
        'btnpsc
        '
        Me.btnpsc.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnpsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnpsc.Location = New System.Drawing.Point(512, 32)
        Me.btnpsc.Name = "btnpsc"
        Me.btnpsc.Size = New System.Drawing.Size(32, 24)
        Me.btnpsc.TabIndex = 13
        Me.btnpsc.Text = "psc"
        '
        'btnslk
        '
        Me.btnslk.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnslk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnslk.Location = New System.Drawing.Point(544, 32)
        Me.btnslk.Name = "btnslk"
        Me.btnslk.Size = New System.Drawing.Size(32, 24)
        Me.btnslk.TabIndex = 14
        Me.btnslk.Text = "slk"
        '
        'btnbrk
        '
        Me.btnbrk.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnbrk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnbrk.Location = New System.Drawing.Point(576, 32)
        Me.btnbrk.Name = "btnbrk"
        Me.btnbrk.Size = New System.Drawing.Size(32, 24)
        Me.btnbrk.TabIndex = 15
        Me.btnbrk.Text = "brk"
        '
        'btncifttirnak
        '
        Me.btncifttirnak.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btncifttirnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btncifttirnak.Location = New System.Drawing.Point(8, 64)
        Me.btncifttirnak.Name = "btncifttirnak"
        Me.btncifttirnak.Size = New System.Drawing.Size(32, 24)
        Me.btncifttirnak.TabIndex = 16
        Me.btncifttirnak.Text = """"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn1.Location = New System.Drawing.Point(40, 64)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(32, 24)
        Me.btn1.TabIndex = 17
        Me.btn1.Text = "1"
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn2.Location = New System.Drawing.Point(72, 64)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(32, 24)
        Me.btn2.TabIndex = 18
        Me.btn2.Text = "2"
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn3.Location = New System.Drawing.Point(104, 64)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(32, 24)
        Me.btn3.TabIndex = 19
        Me.btn3.Text = "3"
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn4.Location = New System.Drawing.Point(136, 64)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(32, 24)
        Me.btn4.TabIndex = 20
        Me.btn4.Text = "4"
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn5.Location = New System.Drawing.Point(168, 64)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(32, 24)
        Me.btn5.TabIndex = 21
        Me.btn5.Text = "5"
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn6.Location = New System.Drawing.Point(200, 64)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(32, 24)
        Me.btn6.TabIndex = 22
        Me.btn6.Text = "6"
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn7.Location = New System.Drawing.Point(232, 64)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(32, 24)
        Me.btn7.TabIndex = 23
        Me.btn7.Text = "7"
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn8.Location = New System.Drawing.Point(264, 64)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(32, 24)
        Me.btn8.TabIndex = 24
        Me.btn8.Text = "8"
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn9.Location = New System.Drawing.Point(296, 64)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(32, 24)
        Me.btn9.TabIndex = 25
        Me.btn9.Text = "9"
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn0.Location = New System.Drawing.Point(328, 64)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(32, 24)
        Me.btn0.TabIndex = 26
        Me.btn0.Text = "0"
        '
        'btncarpi
        '
        Me.btncarpi.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btncarpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btncarpi.Location = New System.Drawing.Point(360, 64)
        Me.btncarpi.Name = "btncarpi"
        Me.btncarpi.Size = New System.Drawing.Size(32, 24)
        Me.btncarpi.TabIndex = 27
        Me.btncarpi.Text = "*"
        '
        'btneksi
        '
        Me.btneksi.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btneksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btneksi.Location = New System.Drawing.Point(392, 64)
        Me.btneksi.Name = "btneksi"
        Me.btneksi.Size = New System.Drawing.Size(32, 24)
        Me.btneksi.TabIndex = 28
        Me.btneksi.Text = "-"
        '
        'btnbackspace
        '
        Me.btnbackspace.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnbackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnbackspace.Location = New System.Drawing.Point(424, 64)
        Me.btnbackspace.Name = "btnbackspace"
        Me.btnbackspace.Size = New System.Drawing.Size(80, 24)
        Me.btnbackspace.TabIndex = 29
        Me.btnbackspace.Text = "bksp"
        '
        'btnins
        '
        Me.btnins.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnins.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnins.Location = New System.Drawing.Point(512, 64)
        Me.btnins.Name = "btnins"
        Me.btnins.Size = New System.Drawing.Size(32, 24)
        Me.btnins.TabIndex = 30
        Me.btnins.Text = "ins"
        '
        'btnhm
        '
        Me.btnhm.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnhm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnhm.Location = New System.Drawing.Point(544, 64)
        Me.btnhm.Name = "btnhm"
        Me.btnhm.Size = New System.Drawing.Size(32, 24)
        Me.btnhm.TabIndex = 31
        Me.btnhm.Text = "hm"
        '
        'btnpup
        '
        Me.btnpup.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnpup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnpup.Location = New System.Drawing.Point(576, 64)
        Me.btnpup.Name = "btnpup"
        Me.btnpup.Size = New System.Drawing.Size(32, 24)
        Me.btnpup.TabIndex = 32
        Me.btnpup.Text = "pup"
        '
        'btntab
        '
        Me.btntab.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btntab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btntab.Location = New System.Drawing.Point(8, 88)
        Me.btntab.Name = "btntab"
        Me.btntab.Size = New System.Drawing.Size(48, 24)
        Me.btntab.TabIndex = 33
        Me.btntab.Text = "tab"
        '
        'btnq
        '
        Me.btnq.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnq.Location = New System.Drawing.Point(56, 88)
        Me.btnq.Name = "btnq"
        Me.btnq.Size = New System.Drawing.Size(32, 24)
        Me.btnq.TabIndex = 34
        Me.btnq.Text = "Q"
        '
        'btnw
        '
        Me.btnw.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnw.Location = New System.Drawing.Point(88, 88)
        Me.btnw.Name = "btnw"
        Me.btnw.Size = New System.Drawing.Size(32, 24)
        Me.btnw.TabIndex = 35
        Me.btnw.Text = "W"
        '
        'btne
        '
        Me.btne.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btne.Location = New System.Drawing.Point(120, 88)
        Me.btne.Name = "btne"
        Me.btne.Size = New System.Drawing.Size(32, 24)
        Me.btne.TabIndex = 36
        Me.btne.Text = "E"
        '
        'btnr
        '
        Me.btnr.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnr.Location = New System.Drawing.Point(152, 88)
        Me.btnr.Name = "btnr"
        Me.btnr.Size = New System.Drawing.Size(32, 24)
        Me.btnr.TabIndex = 37
        Me.btnr.Text = "R"
        '
        'btnt
        '
        Me.btnt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnt.Location = New System.Drawing.Point(184, 88)
        Me.btnt.Name = "btnt"
        Me.btnt.Size = New System.Drawing.Size(32, 24)
        Me.btnt.TabIndex = 38
        Me.btnt.Text = "T"
        '
        'btny
        '
        Me.btny.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btny.Location = New System.Drawing.Point(216, 88)
        Me.btny.Name = "btny"
        Me.btny.Size = New System.Drawing.Size(32, 24)
        Me.btny.TabIndex = 39
        Me.btny.Text = "Y"
        '
        'btnu
        '
        Me.btnu.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnu.Location = New System.Drawing.Point(248, 88)
        Me.btnu.Name = "btnu"
        Me.btnu.Size = New System.Drawing.Size(32, 24)
        Me.btnu.TabIndex = 40
        Me.btnu.Text = "U"
        '
        'btn_i
        '
        Me.btn_i.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_i.Location = New System.Drawing.Point(280, 88)
        Me.btn_i.Name = "btn_i"
        Me.btn_i.Size = New System.Drawing.Size(32, 24)
        Me.btn_i.TabIndex = 41
        Me.btn_i.Text = "I"
        '
        'btno
        '
        Me.btno.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btno.Location = New System.Drawing.Point(312, 88)
        Me.btno.Name = "btno"
        Me.btno.Size = New System.Drawing.Size(32, 24)
        Me.btno.TabIndex = 42
        Me.btno.Text = "O"
        '
        'btnp
        '
        Me.btnp.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnp.Location = New System.Drawing.Point(344, 88)
        Me.btnp.Name = "btnp"
        Me.btnp.Size = New System.Drawing.Size(32, 24)
        Me.btnp.TabIndex = 43
        Me.btnp.Text = "P"
        '
        'btn_g
        '
        Me.btn_g.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_g.Location = New System.Drawing.Point(376, 88)
        Me.btn_g.Name = "btn_g"
        Me.btn_g.Size = New System.Drawing.Size(32, 24)
        Me.btn_g.TabIndex = 44
        Me.btn_g.Text = "Ð"
        '
        'btn_u
        '
        Me.btn_u.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn_u.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_u.Location = New System.Drawing.Point(408, 88)
        Me.btn_u.Name = "btn_u"
        Me.btn_u.Size = New System.Drawing.Size(32, 24)
        Me.btn_u.TabIndex = 45
        Me.btn_u.Text = "Ü"
        '
        'btnvirgul
        '
        Me.btnvirgul.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnvirgul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnvirgul.Location = New System.Drawing.Point(440, 88)
        Me.btnvirgul.Name = "btnvirgul"
        Me.btnvirgul.Size = New System.Drawing.Size(64, 24)
        Me.btnvirgul.TabIndex = 46
        Me.btnvirgul.Text = ","
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btndel.Location = New System.Drawing.Point(512, 88)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(32, 24)
        Me.btndel.TabIndex = 47
        Me.btndel.Text = "del"
        '
        'btnend
        '
        Me.btnend.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnend.Location = New System.Drawing.Point(544, 88)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(32, 24)
        Me.btnend.TabIndex = 48
        Me.btnend.Text = "end"
        '
        'btnpdn
        '
        Me.btnpdn.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnpdn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnpdn.Location = New System.Drawing.Point(576, 88)
        Me.btnpdn.Name = "btnpdn"
        Me.btnpdn.Size = New System.Drawing.Size(32, 24)
        Me.btnpdn.TabIndex = 49
        Me.btnpdn.Text = "pdn"
        '
        'btnlock
        '
        Me.btnlock.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnlock.Location = New System.Drawing.Point(8, 112)
        Me.btnlock.Name = "btnlock"
        Me.btnlock.Size = New System.Drawing.Size(64, 24)
        Me.btnlock.TabIndex = 50
        Me.btnlock.Text = "lock"
        '
        'btna
        '
        Me.btna.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btna.Location = New System.Drawing.Point(72, 112)
        Me.btna.Name = "btna"
        Me.btna.Size = New System.Drawing.Size(32, 24)
        Me.btna.TabIndex = 51
        Me.btna.Text = "A"
        '
        'btns
        '
        Me.btns.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btns.Location = New System.Drawing.Point(104, 112)
        Me.btns.Name = "btns"
        Me.btns.Size = New System.Drawing.Size(32, 24)
        Me.btns.TabIndex = 52
        Me.btns.Text = "S"
        '
        'btnd
        '
        Me.btnd.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnd.Location = New System.Drawing.Point(136, 112)
        Me.btnd.Name = "btnd"
        Me.btnd.Size = New System.Drawing.Size(32, 24)
        Me.btnd.TabIndex = 53
        Me.btnd.Text = "D"
        '
        'btnf
        '
        Me.btnf.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf.Location = New System.Drawing.Point(168, 112)
        Me.btnf.Name = "btnf"
        Me.btnf.Size = New System.Drawing.Size(32, 24)
        Me.btnf.TabIndex = 54
        Me.btnf.Text = "F"
        '
        'btng
        '
        Me.btng.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btng.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btng.Location = New System.Drawing.Point(200, 112)
        Me.btng.Name = "btng"
        Me.btng.Size = New System.Drawing.Size(32, 24)
        Me.btng.TabIndex = 55
        Me.btng.Text = "G"
        '
        'btnh
        '
        Me.btnh.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnh.Location = New System.Drawing.Point(232, 112)
        Me.btnh.Name = "btnh"
        Me.btnh.Size = New System.Drawing.Size(32, 24)
        Me.btnh.TabIndex = 56
        Me.btnh.Text = "H"
        '
        'btnj
        '
        Me.btnj.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnj.Location = New System.Drawing.Point(264, 112)
        Me.btnj.Name = "btnj"
        Me.btnj.Size = New System.Drawing.Size(32, 24)
        Me.btnj.TabIndex = 57
        Me.btnj.Text = "J"
        '
        'btnk
        '
        Me.btnk.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnk.Location = New System.Drawing.Point(296, 112)
        Me.btnk.Name = "btnk"
        Me.btnk.Size = New System.Drawing.Size(32, 24)
        Me.btnk.TabIndex = 58
        Me.btnk.Text = "K"
        '
        'btnl
        '
        Me.btnl.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnl.Location = New System.Drawing.Point(328, 112)
        Me.btnl.Name = "btnl"
        Me.btnl.Size = New System.Drawing.Size(32, 24)
        Me.btnl.TabIndex = 59
        Me.btnl.Text = "L"
        '
        'btn_s
        '
        Me.btn_s.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_s.Location = New System.Drawing.Point(360, 112)
        Me.btn_s.Name = "btn_s"
        Me.btn_s.Size = New System.Drawing.Size(32, 24)
        Me.btn_s.TabIndex = 60
        Me.btn_s.Text = "Þ"
        '
        'btni
        '
        Me.btni.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btni.Location = New System.Drawing.Point(392, 112)
        Me.btni.Name = "btni"
        Me.btni.Size = New System.Drawing.Size(32, 24)
        Me.btni.TabIndex = 61
        Me.btni.Text = "Ý"
        '
        'btnenter
        '
        Me.btnenter.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnenter.Location = New System.Drawing.Point(424, 112)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(80, 24)
        Me.btnenter.TabIndex = 62
        Me.btnenter.Text = "ent"
        '
        'btnsolshift
        '
        Me.btnsolshift.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsolshift.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsolshift.Location = New System.Drawing.Point(8, 136)
        Me.btnsolshift.Name = "btnsolshift"
        Me.btnsolshift.Size = New System.Drawing.Size(80, 24)
        Me.btnsolshift.TabIndex = 63
        Me.btnsolshift.Text = "shift"
        '
        'btnz
        '
        Me.btnz.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnz.Location = New System.Drawing.Point(88, 136)
        Me.btnz.Name = "btnz"
        Me.btnz.Size = New System.Drawing.Size(32, 24)
        Me.btnz.TabIndex = 64
        Me.btnz.Text = "Z"
        '
        'btnx
        '
        Me.btnx.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnx.Location = New System.Drawing.Point(120, 136)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(32, 24)
        Me.btnx.TabIndex = 65
        Me.btnx.Text = "X"
        '
        'btnc
        '
        Me.btnc.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnc.Location = New System.Drawing.Point(152, 136)
        Me.btnc.Name = "btnc"
        Me.btnc.Size = New System.Drawing.Size(32, 24)
        Me.btnc.TabIndex = 66
        Me.btnc.Text = "C"
        '
        'btnv
        '
        Me.btnv.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnv.Location = New System.Drawing.Point(184, 136)
        Me.btnv.Name = "btnv"
        Me.btnv.Size = New System.Drawing.Size(32, 24)
        Me.btnv.TabIndex = 67
        Me.btnv.Text = "V"
        '
        'btnb
        '
        Me.btnb.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnb.Location = New System.Drawing.Point(216, 136)
        Me.btnb.Name = "btnb"
        Me.btnb.Size = New System.Drawing.Size(32, 24)
        Me.btnb.TabIndex = 68
        Me.btnb.Text = "B"
        '
        'btnn
        '
        Me.btnn.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnn.Location = New System.Drawing.Point(248, 136)
        Me.btnn.Name = "btnn"
        Me.btnn.Size = New System.Drawing.Size(32, 24)
        Me.btnn.TabIndex = 69
        Me.btnn.Text = "N"
        '
        'btnm
        '
        Me.btnm.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnm.Location = New System.Drawing.Point(280, 136)
        Me.btnm.Name = "btnm"
        Me.btnm.Size = New System.Drawing.Size(32, 24)
        Me.btnm.TabIndex = 70
        Me.btnm.Text = "M"
        '
        'btn_o
        '
        Me.btn_o.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn_o.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_o.Location = New System.Drawing.Point(312, 136)
        Me.btn_o.Name = "btn_o"
        Me.btn_o.Size = New System.Drawing.Size(32, 24)
        Me.btn_o.TabIndex = 71
        Me.btn_o.Text = "Ö"
        '
        'btn_c
        '
        Me.btn_c.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_c.Location = New System.Drawing.Point(344, 136)
        Me.btn_c.Name = "btn_c"
        Me.btn_c.Size = New System.Drawing.Size(32, 24)
        Me.btn_c.TabIndex = 72
        Me.btn_c.Text = "Ç"
        '
        'btnnokta
        '
        Me.btnnokta.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnokta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnokta.Location = New System.Drawing.Point(376, 136)
        Me.btnnokta.Name = "btnnokta"
        Me.btnnokta.Size = New System.Drawing.Size(32, 24)
        Me.btnnokta.TabIndex = 73
        Me.btnnokta.Text = "."
        '
        'btnsagshift
        '
        Me.btnsagshift.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsagshift.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsagshift.Location = New System.Drawing.Point(408, 136)
        Me.btnsagshift.Name = "btnsagshift"
        Me.btnsagshift.Size = New System.Drawing.Size(96, 24)
        Me.btnsagshift.TabIndex = 74
        Me.btnsagshift.Text = "shift"
        '
        'btnyukari
        '
        Me.btnyukari.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnyukari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnyukari.ImageIndex = 9
        Me.btnyukari.ImageList = Me.ImageList1
        Me.btnyukari.Location = New System.Drawing.Point(544, 136)
        Me.btnyukari.Name = "btnyukari"
        Me.btnyukari.Size = New System.Drawing.Size(32, 24)
        Me.btnyukari.TabIndex = 75
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnsolctrl
        '
        Me.btnsolctrl.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsolctrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsolctrl.Location = New System.Drawing.Point(8, 160)
        Me.btnsolctrl.Name = "btnsolctrl"
        Me.btnsolctrl.Size = New System.Drawing.Size(48, 24)
        Me.btnsolctrl.TabIndex = 76
        Me.btnsolctrl.Text = "ctrl"
        '
        'btnsolwindows
        '
        Me.btnsolwindows.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsolwindows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsolwindows.Location = New System.Drawing.Point(56, 160)
        Me.btnsolwindows.Name = "btnsolwindows"
        Me.btnsolwindows.Size = New System.Drawing.Size(32, 24)
        Me.btnsolwindows.TabIndex = 77
        Me.btnsolwindows.Text = "win"
        '
        'btnsolalt
        '
        Me.btnsolalt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsolalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsolalt.Location = New System.Drawing.Point(88, 160)
        Me.btnsolalt.Name = "btnsolalt"
        Me.btnsolalt.Size = New System.Drawing.Size(48, 24)
        Me.btnsolalt.TabIndex = 78
        Me.btnsolalt.Text = "alt"
        '
        'btnspace
        '
        Me.btnspace.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnspace.Location = New System.Drawing.Point(136, 160)
        Me.btnspace.Name = "btnspace"
        Me.btnspace.Size = New System.Drawing.Size(192, 24)
        Me.btnspace.TabIndex = 79
        '
        'btnsagaltgr
        '
        Me.btnsagaltgr.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsagaltgr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsagaltgr.Location = New System.Drawing.Point(328, 160)
        Me.btnsagaltgr.Name = "btnsagaltgr"
        Me.btnsagaltgr.Size = New System.Drawing.Size(48, 24)
        Me.btnsagaltgr.TabIndex = 80
        Me.btnsagaltgr.Text = "alt"
        '
        'btnsagwindows
        '
        Me.btnsagwindows.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsagwindows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsagwindows.Location = New System.Drawing.Point(376, 160)
        Me.btnsagwindows.Name = "btnsagwindows"
        Me.btnsagwindows.Size = New System.Drawing.Size(32, 24)
        Me.btnsagwindows.TabIndex = 81
        Me.btnsagwindows.Text = "win"
        '
        'btnsagtus
        '
        Me.btnsagtus.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsagtus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsagtus.Location = New System.Drawing.Point(408, 160)
        Me.btnsagtus.Name = "btnsagtus"
        Me.btnsagtus.Size = New System.Drawing.Size(32, 24)
        Me.btnsagtus.TabIndex = 82
        Me.btnsagtus.Text = "st"
        '
        'btnsagctrl
        '
        Me.btnsagctrl.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsagctrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsagctrl.Location = New System.Drawing.Point(440, 160)
        Me.btnsagctrl.Name = "btnsagctrl"
        Me.btnsagctrl.Size = New System.Drawing.Size(64, 24)
        Me.btnsagctrl.TabIndex = 83
        Me.btnsagctrl.Text = "ctrl"
        '
        'btnasagi
        '
        Me.btnasagi.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnasagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnasagi.ImageIndex = 6
        Me.btnasagi.ImageList = Me.ImageList1
        Me.btnasagi.Location = New System.Drawing.Point(544, 160)
        Me.btnasagi.Name = "btnasagi"
        Me.btnasagi.Size = New System.Drawing.Size(32, 24)
        Me.btnasagi.TabIndex = 84
        '
        'btnsol
        '
        Me.btnsol.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsol.ImageIndex = 8
        Me.btnsol.ImageList = Me.ImageList1
        Me.btnsol.Location = New System.Drawing.Point(512, 160)
        Me.btnsol.Name = "btnsol"
        Me.btnsol.Size = New System.Drawing.Size(32, 24)
        Me.btnsol.TabIndex = 85
        '
        'btnsag
        '
        Me.btnsag.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsag.ImageIndex = 7
        Me.btnsag.ImageList = Me.ImageList1
        Me.btnsag.Location = New System.Drawing.Point(576, 160)
        Me.btnsag.Name = "btnsag"
        Me.btnsag.Size = New System.Drawing.Size(32, 24)
        Me.btnsag.TabIndex = 86
        '
        'btnnumlock
        '
        Me.btnnumlock.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock.Location = New System.Drawing.Point(616, 64)
        Me.btnnumlock.Name = "btnnumlock"
        Me.btnnumlock.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock.TabIndex = 87
        Me.btnnumlock.Text = "nlk"
        '
        'btnnumlockbolu
        '
        Me.btnnumlockbolu.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlockbolu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlockbolu.Location = New System.Drawing.Point(648, 64)
        Me.btnnumlockbolu.Name = "btnnumlockbolu"
        Me.btnnumlockbolu.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlockbolu.TabIndex = 88
        Me.btnnumlockbolu.Text = "/"
        '
        'btnnumlockcarpi
        '
        Me.btnnumlockcarpi.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlockcarpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlockcarpi.Location = New System.Drawing.Point(680, 64)
        Me.btnnumlockcarpi.Name = "btnnumlockcarpi"
        Me.btnnumlockcarpi.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlockcarpi.TabIndex = 89
        Me.btnnumlockcarpi.Text = "*"
        '
        'btnnumlockeksi
        '
        Me.btnnumlockeksi.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlockeksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlockeksi.Location = New System.Drawing.Point(712, 64)
        Me.btnnumlockeksi.Name = "btnnumlockeksi"
        Me.btnnumlockeksi.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlockeksi.TabIndex = 90
        Me.btnnumlockeksi.Text = "-"
        '
        'btnnumlockarti
        '
        Me.btnnumlockarti.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlockarti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlockarti.Location = New System.Drawing.Point(712, 88)
        Me.btnnumlockarti.Name = "btnnumlockarti"
        Me.btnnumlockarti.Size = New System.Drawing.Size(32, 48)
        Me.btnnumlockarti.TabIndex = 94
        Me.btnnumlockarti.Text = "+"
        '
        'btnnumlock9
        '
        Me.btnnumlock9.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock9.Location = New System.Drawing.Point(680, 88)
        Me.btnnumlock9.Name = "btnnumlock9"
        Me.btnnumlock9.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock9.TabIndex = 93
        Me.btnnumlock9.Text = "9"
        '
        'btnnumlock8
        '
        Me.btnnumlock8.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock8.Location = New System.Drawing.Point(648, 88)
        Me.btnnumlock8.Name = "btnnumlock8"
        Me.btnnumlock8.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock8.TabIndex = 92
        Me.btnnumlock8.Text = "8"
        '
        'btnnumlock7
        '
        Me.btnnumlock7.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock7.Location = New System.Drawing.Point(616, 88)
        Me.btnnumlock7.Name = "btnnumlock7"
        Me.btnnumlock7.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock7.TabIndex = 91
        Me.btnnumlock7.Text = "7"
        '
        'btnnumlock6
        '
        Me.btnnumlock6.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock6.Location = New System.Drawing.Point(680, 112)
        Me.btnnumlock6.Name = "btnnumlock6"
        Me.btnnumlock6.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock6.TabIndex = 97
        Me.btnnumlock6.Text = "6"
        '
        'btnnumlock5
        '
        Me.btnnumlock5.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock5.Location = New System.Drawing.Point(648, 112)
        Me.btnnumlock5.Name = "btnnumlock5"
        Me.btnnumlock5.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock5.TabIndex = 96
        Me.btnnumlock5.Text = "5"
        '
        'btnnumlock4
        '
        Me.btnnumlock4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock4.Location = New System.Drawing.Point(616, 112)
        Me.btnnumlock4.Name = "btnnumlock4"
        Me.btnnumlock4.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock4.TabIndex = 95
        Me.btnnumlock4.Text = "4"
        '
        'btnnumlockenter
        '
        Me.btnnumlockenter.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlockenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlockenter.Location = New System.Drawing.Point(712, 136)
        Me.btnnumlockenter.Name = "btnnumlockenter"
        Me.btnnumlockenter.Size = New System.Drawing.Size(32, 48)
        Me.btnnumlockenter.TabIndex = 101
        Me.btnnumlockenter.Text = "enr"
        '
        'btnnumlock3
        '
        Me.btnnumlock3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock3.Location = New System.Drawing.Point(680, 136)
        Me.btnnumlock3.Name = "btnnumlock3"
        Me.btnnumlock3.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock3.TabIndex = 100
        Me.btnnumlock3.Text = "3"
        '
        'btnnumlock2
        '
        Me.btnnumlock2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock2.Location = New System.Drawing.Point(648, 136)
        Me.btnnumlock2.Name = "btnnumlock2"
        Me.btnnumlock2.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock2.TabIndex = 99
        Me.btnnumlock2.Text = "2"
        '
        'btnnumlock1
        '
        Me.btnnumlock1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock1.Location = New System.Drawing.Point(616, 136)
        Me.btnnumlock1.Name = "btnnumlock1"
        Me.btnnumlock1.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlock1.TabIndex = 98
        Me.btnnumlock1.Text = "1"
        '
        'btnnumlock0
        '
        Me.btnnumlock0.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlock0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlock0.Location = New System.Drawing.Point(616, 160)
        Me.btnnumlock0.Name = "btnnumlock0"
        Me.btnnumlock0.Size = New System.Drawing.Size(64, 24)
        Me.btnnumlock0.TabIndex = 102
        Me.btnnumlock0.Text = "0"
        '
        'btnnumlocknokta
        '
        Me.btnnumlocknokta.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnumlocknokta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnumlocknokta.Location = New System.Drawing.Point(680, 160)
        Me.btnnumlocknokta.Name = "btnnumlocknokta"
        Me.btnnumlocknokta.Size = New System.Drawing.Size(32, 24)
        Me.btnnumlocknokta.TabIndex = 103
        Me.btnnumlocknokta.Text = ","
        '
        'ToolBar1
        '
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton21, Me.ToolBarButton2, Me.ToolBarButton22, Me.ToolBarButton3, Me.ToolBarButton23, Me.ToolBarButton4, Me.ToolBarButton24, Me.ToolBarButton5, Me.ToolBarButton25, Me.ToolBarButton6, Me.ToolBarButton26, Me.ToolBarButton7, Me.ToolBarButton27, Me.ToolBarButton8, Me.ToolBarButton28, Me.ToolBarButton9, Me.ToolBarButton29, Me.ToolBarButton10, Me.ToolBarButton30, Me.ToolBarButton11, Me.ToolBarButton31, Me.ToolBarButton12, Me.ToolBarButton32, Me.ToolBarButton13, Me.ToolBarButton33, Me.ToolBarButton14, Me.ToolBarButton34, Me.ToolBarButton15, Me.ToolBarButton35, Me.ToolBarButton16, Me.ToolBarButton36, Me.ToolBarButton17, Me.ToolBarButton37, Me.ToolBarButton18, Me.ToolBarButton38, Me.ToolBarButton19, Me.ToolBarButton39, Me.ToolBarButton20})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(752, 29)
        Me.ToolBar1.TabIndex = 104
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 25
        Me.ToolBarButton1.Tag = "button1"
        '
        'ToolBarButton21
        '
        Me.ToolBarButton21.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 23
        Me.ToolBarButton2.Tag = "button2"
        '
        'ToolBarButton22
        '
        Me.ToolBarButton22.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        Me.ToolBarButton3.Tag = "button3"
        '
        'ToolBarButton23
        '
        Me.ToolBarButton23.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 21
        Me.ToolBarButton4.Tag = "button4"
        '
        'ToolBarButton24
        '
        Me.ToolBarButton24.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 22
        Me.ToolBarButton5.Tag = "button5"
        '
        'ToolBarButton25
        '
        Me.ToolBarButton25.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 15
        Me.ToolBarButton6.Tag = "button6"
        '
        'ToolBarButton26
        '
        Me.ToolBarButton26.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 28
        Me.ToolBarButton7.Tag = "button7"
        '
        'ToolBarButton27
        '
        Me.ToolBarButton27.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 0
        Me.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me.ToolBarButton8.Tag = "button8"
        '
        'ToolBarButton28
        '
        Me.ToolBarButton28.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 10
        Me.ToolBarButton9.Tag = "button9"
        '
        'ToolBarButton29
        '
        Me.ToolBarButton29.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.ImageIndex = 11
        Me.ToolBarButton10.Tag = "button10"
        '
        'ToolBarButton30
        '
        Me.ToolBarButton30.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.ImageIndex = 18
        Me.ToolBarButton11.Tag = "button11"
        '
        'ToolBarButton31
        '
        Me.ToolBarButton31.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.ImageIndex = 1
        Me.ToolBarButton12.Tag = "button12"
        '
        'ToolBarButton32
        '
        Me.ToolBarButton32.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton13
        '
        Me.ToolBarButton13.ImageIndex = 26
        Me.ToolBarButton13.Tag = "button13"
        '
        'ToolBarButton33
        '
        Me.ToolBarButton33.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton14
        '
        Me.ToolBarButton14.ImageIndex = 27
        Me.ToolBarButton14.Tag = "button14"
        '
        'ToolBarButton34
        '
        Me.ToolBarButton34.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton15
        '
        Me.ToolBarButton15.ImageIndex = 29
        Me.ToolBarButton15.Tag = "button15"
        '
        'ToolBarButton35
        '
        Me.ToolBarButton35.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton16
        '
        Me.ToolBarButton16.ImageIndex = 32
        Me.ToolBarButton16.Tag = "button16"
        '
        'ToolBarButton36
        '
        Me.ToolBarButton36.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton17
        '
        Me.ToolBarButton17.ImageIndex = 33
        Me.ToolBarButton17.Tag = "button17"
        '
        'ToolBarButton37
        '
        Me.ToolBarButton37.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton18
        '
        Me.ToolBarButton18.ImageIndex = 4
        Me.ToolBarButton18.Tag = "button18"
        '
        'ToolBarButton38
        '
        Me.ToolBarButton38.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton19
        '
        Me.ToolBarButton19.ImageIndex = 3
        Me.ToolBarButton19.Tag = "button19"
        '
        'ToolBarButton39
        '
        Me.ToolBarButton39.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton20
        '
        Me.ToolBarButton20.ImageIndex = 17
        Me.ToolBarButton20.Tag = "button20"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'txtbilgi
        '
        Me.txtbilgi.BackColor = System.Drawing.Color.White
        Me.txtbilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbilgi.Location = New System.Drawing.Point(616, 32)
        Me.txtbilgi.Name = "txtbilgi"
        Me.txtbilgi.Size = New System.Drawing.Size(124, 20)
        Me.txtbilgi.TabIndex = 105
        Me.txtbilgi.Text = ""
        '
        'nodi
        '
        Me.nodi.Icon = CType(resources.GetObject("nodi.Icon"), System.Drawing.Icon)
        Me.nodi.Text = "KEYBOARD"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(752, 194)
        Me.Controls.Add(Me.txtbilgi)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.btnnumlocknokta)
        Me.Controls.Add(Me.btnnumlock0)
        Me.Controls.Add(Me.btnnumlockenter)
        Me.Controls.Add(Me.btnnumlock3)
        Me.Controls.Add(Me.btnnumlock2)
        Me.Controls.Add(Me.btnnumlock1)
        Me.Controls.Add(Me.btnnumlock6)
        Me.Controls.Add(Me.btnnumlock5)
        Me.Controls.Add(Me.btnnumlock4)
        Me.Controls.Add(Me.btnnumlockarti)
        Me.Controls.Add(Me.btnnumlock9)
        Me.Controls.Add(Me.btnnumlock8)
        Me.Controls.Add(Me.btnnumlock7)
        Me.Controls.Add(Me.btnnumlockeksi)
        Me.Controls.Add(Me.btnnumlockcarpi)
        Me.Controls.Add(Me.btnnumlockbolu)
        Me.Controls.Add(Me.btnnumlock)
        Me.Controls.Add(Me.btnsag)
        Me.Controls.Add(Me.btnsol)
        Me.Controls.Add(Me.btnasagi)
        Me.Controls.Add(Me.btnsagctrl)
        Me.Controls.Add(Me.btnsagtus)
        Me.Controls.Add(Me.btnsagwindows)
        Me.Controls.Add(Me.btnsagaltgr)
        Me.Controls.Add(Me.btnspace)
        Me.Controls.Add(Me.btnsolalt)
        Me.Controls.Add(Me.btnsolwindows)
        Me.Controls.Add(Me.btnsolctrl)
        Me.Controls.Add(Me.btnyukari)
        Me.Controls.Add(Me.btnsagshift)
        Me.Controls.Add(Me.btnnokta)
        Me.Controls.Add(Me.btn_c)
        Me.Controls.Add(Me.btn_o)
        Me.Controls.Add(Me.btnm)
        Me.Controls.Add(Me.btnn)
        Me.Controls.Add(Me.btnb)
        Me.Controls.Add(Me.btnv)
        Me.Controls.Add(Me.btnc)
        Me.Controls.Add(Me.btnx)
        Me.Controls.Add(Me.btnz)
        Me.Controls.Add(Me.btnsolshift)
        Me.Controls.Add(Me.btnenter)
        Me.Controls.Add(Me.btni)
        Me.Controls.Add(Me.btn_s)
        Me.Controls.Add(Me.btnl)
        Me.Controls.Add(Me.btnk)
        Me.Controls.Add(Me.btnj)
        Me.Controls.Add(Me.btnh)
        Me.Controls.Add(Me.btng)
        Me.Controls.Add(Me.btnf)
        Me.Controls.Add(Me.btnd)
        Me.Controls.Add(Me.btns)
        Me.Controls.Add(Me.btna)
        Me.Controls.Add(Me.btnlock)
        Me.Controls.Add(Me.btnpdn)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnvirgul)
        Me.Controls.Add(Me.btn_u)
        Me.Controls.Add(Me.btn_g)
        Me.Controls.Add(Me.btnp)
        Me.Controls.Add(Me.btno)
        Me.Controls.Add(Me.btn_i)
        Me.Controls.Add(Me.btnu)
        Me.Controls.Add(Me.btny)
        Me.Controls.Add(Me.btnt)
        Me.Controls.Add(Me.btnr)
        Me.Controls.Add(Me.btne)
        Me.Controls.Add(Me.btnw)
        Me.Controls.Add(Me.btnq)
        Me.Controls.Add(Me.btntab)
        Me.Controls.Add(Me.btnpup)
        Me.Controls.Add(Me.btnhm)
        Me.Controls.Add(Me.btnins)
        Me.Controls.Add(Me.btnbackspace)
        Me.Controls.Add(Me.btneksi)
        Me.Controls.Add(Me.btncarpi)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btncifttirnak)
        Me.Controls.Add(Me.btnbrk)
        Me.Controls.Add(Me.btnslk)
        Me.Controls.Add(Me.btnpsc)
        Me.Controls.Add(Me.btnf12)
        Me.Controls.Add(Me.btnf11)
        Me.Controls.Add(Me.btnf10)
        Me.Controls.Add(Me.btnf9)
        Me.Controls.Add(Me.btnf8)
        Me.Controls.Add(Me.btnf7)
        Me.Controls.Add(Me.btnf6)
        Me.Controls.Add(Me.btnf5)
        Me.Controls.Add(Me.btnf4)
        Me.Controls.Add(Me.btnf3)
        Me.Controls.Add(Me.btnf2)
        Me.Controls.Add(Me.btnf1)
        Me.Controls.Add(Me.btnesc)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(758, 216)
        Me.MinimumSize = New System.Drawing.Size(758, 216)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "keyboard"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "API fonction"
    'Public Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As Long
    'this function gets active window identify number == (8975651603260375040)
    Public Declare Function SetActiveWindow Lib "user32" Alias "SetActiveWindow" _
    (ByVal hwnd As Long) As Long

    Declare Function keybd_event Lib "user32" Alias "keybd_event" _
    (ByVal bVk As Byte, ByVal bScan _
    As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long) As Long

    Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
    (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, _
    ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

#End Region

#Region "constraints"
    Const KEYEVENTF_KEYUP = &H2 ' Release key 
    Const VK_LBUTTON = &H1 'Left mouse button. 
    Const VK_RBUTTON = &H2 'Right mouse button. 
    Const VK_CANCEL = &H3 'Used for control-break processing. 
    Const VK_MBUTTON = &H4 '''Middle mouse button (3-button mouse). 
    Const VK_BACK = &H8
    Const VK_TAB = &H9
    Const VK_CLEAR = &HC
    Const VK_PRINT = &H2A
    Const VK_RETURN = &HD   'enter
    Const VK_SHIFT = &H10
    Const VK_CONTROL = &H11
    Const VK_SCROLL = &H91
    Const VK_MENU = &H12   'Alt (either one)
    Const VK_PAUSE = &H13
    Const VK_CAPITAL = &H14
    Const VK_ESCAPE = &H1B
    Const VK_STARTKEY = &H5B 'Start Menu key
    Const VK_SPACE = &H20
    Const VK_PRIOR = &H21 'Page up. 
    Const VK_NEXT = &H22 'Page down. 
    Const VK_END = &H23
    Const VK_HOME = &H24
    Const VK_LEFT = &H25
    Const VK_UP = &H26
    Const VK_RIGHT = &H27
    Const VK_DOWN = &H28
    Const VK_SELECT = &H29
    Const VK_INSERT = &H2D
    Const VK_DELETE = &H2E
    Const VK_HELP = &H2F
    Const VK_OEM_COMMA = &HBC     ',  comma
    Const VK_NUMLOCK = &H90 '      Num Lock
    Const KEYEVENTF_EXTENDEDKEY = &H1
    Const VK_0 = &H30
    Const VK_1 = &H31
    Const VK_2 = &H32
    Const VK_3 = &H33
    Const VK_4 = &H34
    Const VK_5 = &H35
    Const VK_6 = &H36
    Const VK_7 = &H37
    Const VK_8 = &H38
    Const VK_9 = &H39
    Const VK_A = &H41
    Const VK_B = &H42
    Const VK_C = &H43
    Const VK_D = &H44
    Const VK_E = &H45
    Const VK_F = &H46
    Const VK_G = &H47
    Const VK_H = &H48
    Const VK_I = &H49
    Const VK_J = &H4A
    Const VK_K = &H4B
    Const VK_L = &H4C
    Const VK_M = &H4D
    Const VK_N = &H4E
    Const VK_O = &H4F
    Const VK_P = &H50
    Const VK_Q = &H51
    Const VK_R = &H52
    Const VK_S = &H53
    Const VK_T = &H54
    Const VK_U = &H55
    Const VK_V = &H56
    Const VK_W = &H57
    Const VK_X = &H58
    Const VK_Y = &H59
    Const VK_Z = &H5A
    Const VK_NUMPAD0 = &H60
    Const VK_NUMPAD1 = &H61
    Const VK_NUMPAD2 = &H62
    Const VK_NUMPAD3 = &H63
    Const VK_NUMPAD4 = &H64
    Const VK_NUMPAD5 = &H65
    Const VK_NUMPAD6 = &H66
    Const VK_NUMPAD7 = &H67
    Const VK_NUMPAD8 = &H68
    Const VK_NUMPAD9 = &H69
    Const VK_MULTIPLY = &H6A    '     * (keypad)
    Const VK_ADD = &H6B
    Const VK_SEPARATER = &H6C
    Const VK_SEPARATOR = &H6C
    Const VK_SUBTRACT = &H6D
    Const VK_DECIMAL = &H6E
    Const VK_DIVIDE = &H6F
    Const VK_OEM_2 = &HBF  '      /
    Const VK_OEM_PERIOD = &HBE '.
    Const VK_F1 = &H70
    Const VK_F2 = &H71
    Const VK_F3 = &H72
    Const VK_F4 = &H73
    Const VK_F5 = &H74
    Const VK_F6 = &H75
    Const VK_F7 = &H76
    Const VK_F8 = &H77
    Const VK_F9 = &H78
    Const VK_F10 = &H79
    Const VK_F11 = &H7A
    Const VK_F12 = &H7B
    Const VK_F13 = &H7C
    Const VK_F14 = &H7D
    Const VK_F15 = &H7E
    Const VK_F16 = &H7F
    Const VK_F17 = &H80
    Const VK_F18 = &H81
    Const VK_F19 = &H82
    Const VK_F20 = &H83
    Const VK_F21 = &H84
    Const VK_F22 = &H85
    Const VK_F23 = &H86
    Const VK_F24 = &H87
    '****************
    Const VK_CRSEL = &HF7
    Const VK_EREOF = &HF9
    Const VK_EXECUTE = &H2B
    Const VK_EXSEL = &HF8
    Const VK_NONAME = &HFC
    Const VK_OEM_CLEAR = &HFE
    Const VK_PA1 = &HFD
    Const VK_PROCESSKEY = &HE5
    Const CAPSLOCK_ON = &H80    '  the capslock light is on.
    '****************
    Dim lockbool, numlockbool, ctrlbool As Boolean
    Dim onoff As Boolean
#End Region

#Region "which button pushed function"
    Public Function whichbuttonpushed(ByVal _sender As String) As String
        Try
            SetActiveWindow(8975651603260375040) 'Set focus Active window
            'I found this number("8975651603260375040") via getactivewindow method.
            Select Case _sender
                Case "btna"
                    keybd_event(VK_A, 0, 0, 0)
                    keybd_event(VK_A, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnb"
                    keybd_event(VK_B, 0, 0, 0)
                    keybd_event(VK_B, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnc"
                    keybd_event(VK_C, 0, 0, 0)
                    keybd_event(VK_C, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_c"
                    keybd_event(VK_C, 0, 0, 0)
                    keybd_event(VK_C, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnd"
                    keybd_event(VK_D, 0, 0, 0)
                    keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btne"
                    keybd_event(VK_E, 0, 0, 0)
                    keybd_event(VK_E, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf"
                    keybd_event(VK_F, 0, 0, 0)
                    keybd_event(VK_F, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btng"
                    keybd_event(VK_G, 0, 0, 0)
                    keybd_event(VK_G, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_g"
                    keybd_event(VK_G, 0, 0, 0)
                    keybd_event(VK_G, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnh"
                    keybd_event(VK_H, 0, 0, 0)
                    keybd_event(VK_H, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_i"
                    keybd_event(VK_I, 0, 0, 0)
                    keybd_event(VK_I, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btni"
                    keybd_event(VK_I, 0, 0, 0)
                    keybd_event(VK_I, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnj"
                    keybd_event(VK_J, 0, 0, 0)
                    keybd_event(VK_J, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnk"
                    keybd_event(VK_K, 0, 0, 0)
                    keybd_event(VK_K, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnl"
                    keybd_event(VK_L, 0, 0, 0)
                    keybd_event(VK_L, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnm"
                    keybd_event(VK_M, 0, 0, 0)
                    keybd_event(VK_M, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnn"
                    keybd_event(VK_N, 0, 0, 0)
                    keybd_event(VK_N, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btno"
                    keybd_event(VK_O, 0, 0, 0)
                    keybd_event(VK_O, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_o"
                    keybd_event(VK_O, 0, 0, 0)
                    keybd_event(VK_O, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnp"
                    keybd_event(VK_P, 0, 0, 0)
                    keybd_event(VK_P, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnr"
                    keybd_event(VK_R, 0, 0, 0)
                    keybd_event(VK_R, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btns"
                    keybd_event(VK_S, 0, 0, 0)
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_s"
                    keybd_event(VK_S, 0, 0, 0)
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnt"
                    keybd_event(VK_T, 0, 0, 0)
                    keybd_event(VK_T, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnu"
                    keybd_event(VK_U, 0, 0, 0)
                    keybd_event(VK_U, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_u"
                    keybd_event(VK_U, 0, 0, 0)
                    keybd_event(VK_U, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnv"
                    keybd_event(VK_V, 0, 0, 0)
                    keybd_event(VK_V, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btny"
                    keybd_event(VK_Y, 0, 0, 0)
                    keybd_event(VK_Y, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnz"
                    keybd_event(VK_Z, 0, 0, 0)
                    keybd_event(VK_Z, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnw"
                    keybd_event(VK_W, 0, 0, 0)
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnq"
                    keybd_event(VK_Q, 0, 0, 0)
                    keybd_event(VK_Q, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnx"
                    keybd_event(VK_X, 0, 0, 0)
                    keybd_event(VK_X, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                    '***************************************************************************************
                Case "btnnokta" '"."
                    keybd_event(VK_OEM_PERIOD, 0, 0, 0)
                    keybd_event(VK_OEM_PERIOD, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnesc"
                    keybd_event(VK_ESCAPE, 0, 0, 0)
                    keybd_event(VK_ESCAPE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf1"
                    keybd_event(VK_F1, 0, 0, 0)
                    keybd_event(VK_F1, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf2"
                    keybd_event(VK_F2, 0, 0, 0)
                    keybd_event(VK_F2, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf3"
                    keybd_event(VK_F3, 0, 0, 0)
                    keybd_event(VK_F3, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf4"
                    keybd_event(VK_F4, 0, 0, 0)
                    keybd_event(VK_F4, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf5"
                    keybd_event(VK_F5, 0, 0, 0)
                    keybd_event(VK_F5, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf6"
                    keybd_event(VK_F6, 0, 0, 0)
                    keybd_event(VK_F6, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf7"
                    keybd_event(VK_F7, 0, 0, 0)
                    keybd_event(VK_F7, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf8"
                    keybd_event(VK_F8, 0, 0, 0)
                    keybd_event(VK_F8, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf9"
                    keybd_event(VK_F9, 0, 0, 0)
                    keybd_event(VK_F9, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf10"
                    keybd_event(VK_F10, 0, 0, 0)
                    keybd_event(VK_F10, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf11"
                    keybd_event(VK_F11, 0, 0, 0)
                    keybd_event(VK_F11, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf12"
                    keybd_event(VK_F12, 0, 0, 0)
                    keybd_event(VK_F12, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnpsc"  'print
                    keybd_event(VK_PRINT, 0, 0, 0)
                    keybd_event(VK_PRINT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnslk"  'scroll
                    keybd_event(VK_SCROLL, &H45S, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    keybd_event(VK_SCROLL, &H45S, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnbrk"  'pause
                    keybd_event(VK_PAUSE, 0, 0, 0)
                    keybd_event(VK_PAUSE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btncifttirnak"  '  "
                    'I used this(') mark two times. 
                    keybd_event(VK_SHIFT, 0, 0, 0)
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btntab"  'tab
                    keybd_event(VK_TAB, 0, 0, 0)
                    keybd_event(VK_TAB, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnlock"    'capslock
                    lockbool = Not lockbool
                    keybd_event(VK_CAPITAL, &H45S, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    keybd_event(VK_CAPITAL, &H45S, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
                    If lockbool = True Then
                        btnlock.BackColor = Color.White
                    Else
                        btnlock.BackColor = Color.FromArgb(224, 224, 224)
                    End If
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsolshift"   'left shift
                    keybd_event(VK_SHIFT, 0, 0, 0)
                    btnsolshift.BackColor = Color.White
                    btnsagshift.BackColor = Color.White
                    altrelease()
                    leftaltrelease()
                Case "btnsolctrl"  'left ctrl
                    ctrlbool = Not ctrlbool
                    If ctrlbool = True Then
                        keybd_event(VK_CONTROL, 0, 0, 0)
                        btnsolctrl.BackColor = Color.White
                        btnsagctrl.BackColor = Color.White
                    Else
                        keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0)
                        btnsolctrl.BackColor = Color.FromArgb(224, 224, 224)
                        btnsagctrl.BackColor = Color.FromArgb(224, 224, 224)
                    End If
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsolwindows"    'left start key
                    keybd_event(VK_STARTKEY, 0, 0, 0)
                    keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsolalt"   'left alt
                    keybd_event(VK_MENU, 0, 0, 0)
                    btnsolalt.BackColor = Color.White
                    shiftrelease()
                    altrelease()
                Case "btnspace"   'space
                    keybd_event(VK_SPACE, 0, 0, 0)
                    keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsagaltgr"   'right altgr
                    keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    btnsagaltgr.BackColor = Color.White
                    shiftrelease()
                    leftaltrelease()
                Case "btnsagwindows"   'right start key
                    keybd_event(VK_STARTKEY, 0, 0, 0)
                    keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsagtus"
                    keybd_event(VK_RBUTTON, 0, 0, 0)
                    keybd_event(VK_RBUTTON, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsagctrl"   'right ctrl
                    ctrlbool = Not ctrlbool
                    If ctrlbool = True Then
                        keybd_event(VK_CONTROL, 0, 0, 0)
                        btnsolctrl.BackColor = Color.White
                        btnsagctrl.BackColor = Color.White
                    Else
                        keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0)
                        btnsolctrl.BackColor = Color.FromArgb(224, 224, 224)
                        btnsagctrl.BackColor = Color.FromArgb(224, 224, 224)
                    End If
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsagshift"    'right shift 
                    keybd_event(VK_SHIFT, 0, 0, 0)
                    btnsolshift.BackColor = Color.White
                    btnsagshift.BackColor = Color.White
                    altrelease()
                    leftaltrelease()
                Case "btnenter"   'enter
                    keybd_event(VK_RETURN, 0, 0, 0)
                    keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnvirgul"    'comma
                    keybd_event(VK_OEM_COMMA, 0, 0, 0)
                    keybd_event(VK_OEM_COMMA, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnbackspace"   'back space
                    keybd_event(VK_BACK, 0, 0, 0)
                    keybd_event(VK_BACK, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                    '///////////////////////////////////////////////
                Case "btnins"    'insert
                    keybd_event(VK_INSERT, 0, 0, 0)
                    keybd_event(VK_INSERT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnhm"    'home
                    keybd_event(VK_HOME, 0, 0, 0)
                    keybd_event(VK_HOME, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnpup"   'page up
                    keybd_event(VK_PRIOR, 0, 0, 0)
                    keybd_event(VK_PRIOR, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btndel"    'delete
                    keybd_event(VK_DELETE, 0, 0, 0)
                    keybd_event(VK_DELETE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnend"   'end
                    keybd_event(VK_END, 0, 0, 0)
                    keybd_event(VK_END, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnpdn"    'page down
                    keybd_event(VK_NEXT, 0, 0, 0)
                    keybd_event(VK_NEXT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnyukari"   'up
                    keybd_event(VK_UP, 0, 0, 0)
                    keybd_event(VK_UP, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnasagi"   'down
                    keybd_event(VK_DOWN, 0, 0, 0)
                    keybd_event(VK_DOWN, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsol"  'left
                    keybd_event(VK_LEFT, 0, 0, 0)
                    keybd_event(VK_LEFT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsag"   'right
                    keybd_event(VK_RIGHT, 0, 0, 0)
                    keybd_event(VK_RIGHT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                    '//////////////////////////////////////////////////////////////////////////////////
                Case "btnnumlock"    'numlock
                    numlockbool = Not numlockbool
                    keybd_event(VK_NUMLOCK, &H45S, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    keybd_event(VK_NUMLOCK, &H45S, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
                    If numlockbool = True Then
                        btnnumlock.BackColor = Color.FromArgb(224, 224, 224)
                    Else
                        btnnumlock.BackColor = Color.White
                    End If
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockbolu"    '   /
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockcarpi"    '   *
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockeksi"    '   -
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockarti"    '   +
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockenter"    ' right enter
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlocknokta"   '  .
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock0"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock1"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock2"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock3"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock4"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock5"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock6"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock7"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock8"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock9"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                    '/////////////////////////////////////////////////////////////////////////////////
                Case "btn0"
                    keybd_event(VK_0, 0, 0, 0)
                    keybd_event(VK_0, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn1"
                    keybd_event(VK_1, 0, 0, 0)
                    keybd_event(VK_1, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn2"
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn3"
                    keybd_event(VK_3, 0, 0, 0)
                    keybd_event(VK_3, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn4"
                    keybd_event(VK_4, 0, 0, 0)
                    keybd_event(VK_4, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn5"
                    keybd_event(VK_5, 0, 0, 0)
                    keybd_event(VK_5, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn6"
                    keybd_event(VK_6, 0, 0, 0)
                    keybd_event(VK_6, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn7"
                    keybd_event(VK_7, 0, 0, 0)
                    keybd_event(VK_7, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn8"
                    keybd_event(VK_8, 0, 0, 0)
                    keybd_event(VK_8, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn9"
                    keybd_event(VK_9, 0, 0, 0)
                    keybd_event(VK_9, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btncarpi"    '    *
                    keybd_event(VK_MULTIPLY, 0, 0, 0)
                    keybd_event(VK_MULTIPLY, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btneksi"     '    -
                    keybd_event(VK_SUBTRACT, 0, 0, 0)
                    keybd_event(VK_SUBTRACT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
            End Select
            Exit Function
        Catch ex As Exception
            Exit Function
        End Try
    End Function
#End Region

#Region "numlock function "
    Public Function numlockfunc(ByVal numlock_tus As String, ByVal open_close As Boolean) As String
        Try
            If open_close = False Then    'numlock opened
                Select Case numlock_tus
                    Case "btnnumlockbolu"
                        keybd_event(VK_DIVIDE, 0, 0, 0)
                        keybd_event(VK_DIVIDE, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockcarpi"
                        keybd_event(VK_MULTIPLY, 0, 0, 0)
                        keybd_event(VK_MULTIPLY, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockeksi"
                        keybd_event(VK_SUBTRACT, 0, 0, 0)
                        keybd_event(VK_SUBTRACT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockarti"
                        keybd_event(VK_ADD, 0, 0, 0)
                        keybd_event(VK_ADD, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockenter"
                        keybd_event(VK_RETURN, 0, 0, 0)
                        keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlocknokta"
                        keybd_event(VK_DECIMAL, 0, 0, 0)
                        keybd_event(VK_DECIMAL, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock0"
                        keybd_event(VK_NUMPAD0, 0, 0, 0)
                        keybd_event(VK_NUMPAD0, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock1"
                        keybd_event(VK_NUMPAD1, 0, 0, 0)
                        keybd_event(VK_NUMPAD1, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock2"
                        keybd_event(VK_NUMPAD2, 0, 0, 0)
                        keybd_event(VK_NUMPAD2, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock3"
                        keybd_event(VK_NUMPAD3, 0, 0, 0)
                        keybd_event(VK_NUMPAD3, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock4"
                        keybd_event(VK_NUMPAD4, 0, 0, 0)
                        keybd_event(VK_NUMPAD4, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock5"
                        keybd_event(VK_NUMPAD5, 0, 0, 0)
                        keybd_event(VK_NUMPAD5, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock6"
                        keybd_event(VK_NUMPAD6, 0, 0, 0)
                        keybd_event(VK_NUMPAD6, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock7"
                        keybd_event(VK_NUMPAD7, 0, 0, 0)
                        keybd_event(VK_NUMPAD7, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock8"
                        keybd_event(VK_NUMPAD8, 0, 0, 0)
                        keybd_event(VK_NUMPAD8, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock9"
                        keybd_event(VK_NUMPAD9, 0, 0, 0)
                        keybd_event(VK_NUMPAD9, 0, KEYEVENTF_KEYUP, 0)
                End Select
            Else                                'numlock closed
                Select Case numlock_tus
                    Case "btnnumlockbolu"
                        keybd_event(VK_DIVIDE, 0, 0, 0)
                        keybd_event(VK_DIVIDE, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockcarpi"
                        keybd_event(VK_MULTIPLY, 0, 0, 0)
                        keybd_event(VK_MULTIPLY, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockeksi"
                        keybd_event(VK_SUBTRACT, 0, 0, 0)
                        keybd_event(VK_SUBTRACT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockarti"
                        keybd_event(VK_ADD, 0, 0, 0)
                        keybd_event(VK_ADD, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockenter"
                        keybd_event(VK_RETURN, 0, 0, 0)
                        keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlocknokta"
                        keybd_event(VK_DELETE, 0, 0, 0)
                        keybd_event(VK_DELETE, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock0"
                        keybd_event(VK_INSERT, 0, 0, 0)
                        keybd_event(VK_INSERT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock1"
                        keybd_event(VK_END, 0, 0, 0)
                        keybd_event(VK_END, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock2"
                        keybd_event(VK_DOWN, 0, 0, 0)
                        keybd_event(VK_DOWN, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock3"
                        keybd_event(VK_NEXT, 0, 0, 0)
                        keybd_event(VK_NEXT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock4"
                        keybd_event(VK_LEFT, 0, 0, 0)
                        keybd_event(VK_LEFT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock5"
                    Case "btnnumlock6"
                        keybd_event(VK_RIGHT, 0, 0, 0)
                        keybd_event(VK_RIGHT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock7"
                        keybd_event(VK_HOME, 0, 0, 0)
                        keybd_event(VK_HOME, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock8"
                        keybd_event(VK_UP, 0, 0, 0)
                        keybd_event(VK_UP, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock9"
                        keybd_event(VK_PRIOR, 0, 0, 0)
                        keybd_event(VK_PRIOR, 0, KEYEVENTF_KEYUP, 0)
                End Select
            End If
        Catch ex As Exception
            Exit Function
        End Try
    End Function
#End Region

#Region "buttons click"
    Private Sub btnesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnesc.Click, btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn_c.Click, btn_g.Click, btn_i.Click, btn_o.Click, btn_s.Click, btn_u.Click, btna.Click, btnasagi.Click, btnb.Click, btnbackspace.Click, btnbrk.Click, btnc.Click, btncarpi.Click, btncifttirnak.Click, btnd.Click, btndel.Click, btne.Click, btneksi.Click, btnend.Click, btnenter.Click, btnf.Click, btnf1.Click, btnf10.Click, btnf11.Click, btnf12.Click, btnf2.Click, btnf3.Click, btnf4.Click, btnf5.Click, btnf6.Click, btnf7.Click, btnf8.Click, btnf9.Click, btng.Click, btnh.Click, btnhm.Click, btni.Click, btnins.Click, btnj.Click, btnk.Click, btnl.Click, btnlock.Click, btnm.Click, btnn.Click, btnnokta.Click, btnnumlock.Click, btnnumlock0.Click, btnnumlock1.Click, btnnumlock2.Click, btnnumlock3.Click, btnnumlock4.Click, btnnumlock5.Click, btnnumlock6.Click, btnnumlock7.Click, btnnumlock8.Click, btnnumlock9.Click, btnnumlockarti.Click, btnnumlockbolu.Click, btnnumlockcarpi.Click, btnnumlockeksi.Click, btnnumlockenter.Click, btnnumlocknokta.Click, btno.Click, btnp.Click, btnpdn.Click, btnpsc.Click, btnpup.Click, btnq.Click, btnr.Click, btns.Click, btnsag.Click, btnsagaltgr.Click, btnsagctrl.Click, btnsagshift.Click, btnsagtus.Click, btnsagwindows.Click, btnslk.Click, btnsol.Click, btnsolalt.Click, btnsolctrl.Click, btnsolshift.Click, btnsolwindows.Click, btnspace.Click, btnt.Click, btntab.Click, btnu.Click, btnv.Click, btnw.Click, btnx.Click, btny.Click, btnyukari.Click, btnz.Click, btnvirgul.Click
        Try
            Dim key As Button = CType(sender, Button)
            whichbuttonpushed(key.Name)
            SetActiveWindow(8975651603260375040) 'This Line Very Impportant
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        Finally
            SetActiveWindow(8975651603260375040)
        End Try
    End Sub
#End Region

#Region "shift ,altgr and alt release sub"
    Sub shiftrelease()
        btnsolshift.BackColor = Color.FromArgb(224, 224, 224)
        btnsagshift.BackColor = Color.FromArgb(224, 224, 224)
        keybd_event(VK_SHIFT, 0, 2, 0)
    End Sub
    Sub altrelease()
        keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY Or 2, 0)
        btnsagaltgr.BackColor = Color.FromArgb(224, 224, 224)
    End Sub
    Sub leftaltrelease()
        keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0)
        btnsolalt.BackColor = Color.FromArgb(224, 224, 224)
    End Sub
#End Region

#Region "form1 finalize Overrides"
    Protected Overrides Sub Finalize()
        Try
            'release shift,alt and leftalt
            shiftrelease()
            altrelease()
            leftaltrelease()
            keybd_event(VK_CANCEL, 0, 0, 0)
            Timer1.Enabled = False
            Me.Dispose()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "toolbar button click"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Select Case e.Button.Tag
                Case "button1"
                    process.Start("wordpad")
                Case "button2"
                    process.Start("notepad")
                Case "button3"
                    openwinamp()
                Case "button4"
                    process.Start("outlook")
                Case "button5"
                    process.Start("iexplore")
                Case "button6"
                    screenshot()
                Case "button7"
                    process.Start("taskmgr")
                Case "button8"
                    formtopmost()
                Case "button9"
                    cdromopenclose()
                Case "button10"
                    'messengerstart()
                Case "button11"
                    process.Start("calc")
                Case "button12"
                    process.Start("explorer")
                Case "button13"    'press startket + (R)
                    keybd_event(VK_STARTKEY, 0, 0, 0)
                    keybd_event(VK_R, 0, 0, 0)
                    keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_R, 0, KEYEVENTF_KEYUP, 0)
                Case "button14"  'press startket + (F)
                    keybd_event(VK_STARTKEY, 0, 0, 0)
                    keybd_event(VK_F, 0, 0, 0)
                    keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_F, 0, KEYEVENTF_KEYUP, 0)
                Case "button15"    'press startket + (M)
                    keybd_event(VK_STARTKEY, 0, 0, 0)
                    keybd_event(VK_M, 0, 0, 0)
                    keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_M, 0, KEYEVENTF_KEYUP, 0)
                Case "button16"   'wmp
                    process.Start("wmplayer")
                Case "button17"   'open your hotmail inbox
                    'Dim msg As New Messenger
                    'msg.OpenInbox()
                Case "button18"   'information form
                    'Dim iform As New info
                    'iform.ShowDialog()
                Case "button19"  'help form
                    'Dim hform As New help
                    'hform.Show()
                Case "button20"   'system tray icon 
                    nodi.Visible = True
                    Me.Hide()
            End Select
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "open winamp"
    Public Sub openwinamp()
        Try
            If File.Exists("C:\Program Files\Winamp\winamp.exe") Then
                process.Start("C:\Program Files\Winamp\winamp.exe")
            Else
                MsgBox("This button open winamp,but you must download winamp.")
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "screenshot()"
    Sub screenshot()
        Try
            Call keybd_event(System.Windows.Forms.Keys.Snapshot, 0, 0, 0)
            System.Threading.Thread.Sleep(200) ' To have time to catch the clipboard
            Static i As Integer
            Dim data As IDataObject
            data = Nothing
            data = Clipboard.GetDataObject()
            Dim bmap As Bitmap
            Dim p As New PictureBox
            If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
                p.Image = bmap
                i += 1
                p.Image.Save("C:\Documents and Settings\All Users\Desktop\Screenshot " & i.ToString & " .jpg", Imaging.ImageFormat.Jpeg)
            End If

            If Not File.Exists("C:\Documents and Settings\All Users\Desktop\Screenshot " & i.ToString & " .jpg") Then
                screenshot()
            Else
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "cdrom open/close"
    Sub cdromopenclose()
        Try
            onoff = Not onoff
            If onoff Then
                mciSendString("set cdAudio door open", 0&, 0, 0)
            Else
                mciSendString("set cdAudio door Closed", 0&, 0, 0)
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "form1 load"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        nodi.Visible = False
    End Sub
#End Region

#Region "timer 1 ve 2 tick"
    Dim processes() As process
    Dim process As New process
    Dim processstring As String
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim mycoll As New Collection
            processes = process.GetProcesses
            For Each process In processes
                mycoll.Add(process, process.Id.ToString)
                If process.ProcessName = "winamp" Then
                    processstring = process.MainWindowTitle
                    'gets song name from winamp window's title(MainWindowTitle)
                    Exit For
                End If
            Next
            Me.Text = "MY SCREEN KEYBOARD" & Space(55) & DateTime.Now & Space(20) & processstring
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Dim whichstate As Integer = 1
    Dim store As String
    'Dim m As New MessengerAPI.MessengerClass
    'Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
    '    Try
    '        store &= " < " & m.UnreadEmailCount(MUAFOLDER.MUAFOLDER_INBOX) & " okunmamýs e-mail." & " > "
    '        Dim cnts As IMessengerContacts
    '        Dim cnt As IMessengerContact
    '        cnts = m.MyContacts
    '        For Each cnt In cnts
    '            Select Case cnt.Status
    '                Case MISTATUS.MISTATUS_AWAY
    '                    store &= " < " & cnt.FriendlyName & " / " & "Away" & " > "
    '                Case MISTATUS.MISTATUS_BE_RIGHT_BACK
    '                    store &= " < " & cnt.FriendlyName & " / " & "Be right back" & " > "
    '                Case MISTATUS.MISTATUS_BUSY
    '                    store &= " < " & cnt.FriendlyName & " / " & "Busy" & " > "
    '                Case MISTATUS.MISTATUS_OFFLINE
    '                    store &= " < " & cnt.FriendlyName & " / " & "Offline" & " > "
    '                Case MISTATUS.MISTATUS_ON_THE_PHONE
    '                    store &= " < " & cnt.FriendlyName & " / " & "On The Phone" & " > "
    '                Case MISTATUS.MISTATUS_ONLINE
    '                    store &= " < " & cnt.FriendlyName & " / " & "Online" & " > "
    '                Case MISTATUS.MISTATUS_OUT_TO_LUNCH
    '                    store &= " < " & cnt.FriendlyName & " / " & "Out to lunch" & " > "
    '            End Select
    '        Next
    '        txtbilgi.Text = Mid(store, whichstate, 25)  'scroll the text
    '        whichstate += 1
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub
#End Region

#Region "messenger start sub"
    'Public Sub messengerstart()
    '    Try
    '        Dim m As New MessengerAPI.MessengerClass
    '        Dim l As Long = Nothing
    '        If m.MyStatus = MISTATUS.MISTATUS_OFFLINE Then
    '            m.Signin(l, "", "")
    '            Timer2.Enabled = True
    '        Else
    '            If MessageBox.Show("Allready opened session on computer.." & vbCrLf & "Do you want to close this session and then open new session?", "Screen Keyboard Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                While m.MyStatus <> MISTATUS.MISTATUS_OFFLINE
    '                    m.Signout()
    '                End While
    '                messengerstart()
    '            Else
    '                Exit Try
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub
#End Region

#Region "nodi double click"
    Private Sub nodi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles nodi.DoubleClick
        Me.Show()
        nodi.Visible = False
        nodi.Text = "Screen Keyboard still runing here!"
    End Sub
#End Region

#Region "form1 top most property"
    Public Sub formtopmost()
        If ToolBar1.Buttons.Item(14).Pushed = True Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
    End Sub
#End Region

End Class
