<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptReceipt 
    Inherits DataDynamics.ActiveReports.ActiveReport3 

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptReceipt))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtBranchName = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd1 = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd2 = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd3 = New DataDynamics.ActiveReports.TextBox
        Me.txtZip = New DataDynamics.ActiveReports.TextBox
        Me.txtState = New DataDynamics.ActiveReports.TextBox
        Me.txtTel = New DataDynamics.ActiveReports.TextBox
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.txtCounter = New DataDynamics.ActiveReports.TextBox
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.txtReceiptId = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.txtSales = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCode = New DataDynamics.ActiveReports.TextBox
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtPrice = New DataDynamics.ActiveReports.TextBox
        Me.txtAmount = New DataDynamics.ActiveReports.TextBox
        Me.txtDesc = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
        Me.txtTendered = New DataDynamics.ActiveReports.TextBox
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
        Me.txtChange = New DataDynamics.ActiveReports.TextBox
        Me.txtRemarks = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.txtNetTotal = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg1 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg2 = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.txtPosMsg3 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.txtTax = New DataDynamics.ActiveReports.TextBox
        Me.txtDeposit = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.txtPayment = New DataDynamics.ActiveReports.TextBox
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiptId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTendered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtBranchName, Me.txtAdd1, Me.txtAdd2, Me.txtAdd3, Me.txtZip, Me.txtState, Me.txtTel, Me.txtReportName, Me.txtTime, Me.TextBox20, Me.TextBox13, Me.txtUser, Me.txtCounter, Me.Line6, Me.TextBox12, Me.TextBox1, Me.TextBox11, Me.TextBox9, Me.TextBox3, Me.Line1, Me.TextBox4, Me.txtReceiptId, Me.TextBox5, Me.txtSales})
        Me.PageHeader1.Height = 2.78125!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtBranchName
        '
        Me.txtBranchName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBranchName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBranchName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchName.Border.RightColor = System.Drawing.Color.Black
        Me.txtBranchName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchName.Border.TopColor = System.Drawing.Color.Black
        Me.txtBranchName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchName.Height = 0.1875!
        Me.txtBranchName.Left = 0.0!
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; "
        Me.txtBranchName.Text = "txtBranchName"
        Me.txtBranchName.Top = 0.0!
        Me.txtBranchName.Width = 2.4375!
        '
        'txtAdd1
        '
        Me.txtAdd1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAdd1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAdd1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd1.Border.RightColor = System.Drawing.Color.Black
        Me.txtAdd1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd1.Border.TopColor = System.Drawing.Color.Black
        Me.txtAdd1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd1.Height = 0.1875!
        Me.txtAdd1.Left = 0.0!
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; "
        Me.txtAdd1.Text = "txtAdd1"
        Me.txtAdd1.Top = 0.1875!
        Me.txtAdd1.Width = 2.4375!
        '
        'txtAdd2
        '
        Me.txtAdd2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAdd2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAdd2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd2.Border.RightColor = System.Drawing.Color.Black
        Me.txtAdd2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd2.Border.TopColor = System.Drawing.Color.Black
        Me.txtAdd2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd2.Height = 0.1875!
        Me.txtAdd2.Left = 0.0!
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; "
        Me.txtAdd2.Text = "txtAdd2"
        Me.txtAdd2.Top = 0.375!
        Me.txtAdd2.Width = 2.4375!
        '
        'txtAdd3
        '
        Me.txtAdd3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAdd3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAdd3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd3.Border.RightColor = System.Drawing.Color.Black
        Me.txtAdd3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd3.Border.TopColor = System.Drawing.Color.Black
        Me.txtAdd3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd3.Height = 0.1875!
        Me.txtAdd3.Left = 0.0!
        Me.txtAdd3.Name = "txtAdd3"
        Me.txtAdd3.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; "
        Me.txtAdd3.Text = "txtAdd3"
        Me.txtAdd3.Top = 0.5625!
        Me.txtAdd3.Width = 2.4375!
        '
        'txtZip
        '
        Me.txtZip.Border.BottomColor = System.Drawing.Color.Black
        Me.txtZip.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtZip.Border.LeftColor = System.Drawing.Color.Black
        Me.txtZip.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtZip.Border.RightColor = System.Drawing.Color.Black
        Me.txtZip.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtZip.Border.TopColor = System.Drawing.Color.Black
        Me.txtZip.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtZip.Height = 0.1875!
        Me.txtZip.Left = 0.0!
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; "
        Me.txtZip.Text = "txtZip"
        Me.txtZip.Top = 0.75!
        Me.txtZip.Width = 2.4375!
        '
        'txtState
        '
        Me.txtState.Border.BottomColor = System.Drawing.Color.Black
        Me.txtState.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtState.Border.LeftColor = System.Drawing.Color.Black
        Me.txtState.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtState.Border.RightColor = System.Drawing.Color.Black
        Me.txtState.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtState.Border.TopColor = System.Drawing.Color.Black
        Me.txtState.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtState.Height = 0.1875!
        Me.txtState.Left = 0.0!
        Me.txtState.Name = "txtState"
        Me.txtState.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; "
        Me.txtState.Text = "txtState"
        Me.txtState.Top = 0.9375!
        Me.txtState.Width = 2.4375!
        '
        'txtTel
        '
        Me.txtTel.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTel.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTel.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTel.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTel.Border.RightColor = System.Drawing.Color.Black
        Me.txtTel.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTel.Border.TopColor = System.Drawing.Color.Black
        Me.txtTel.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTel.Height = 0.1875!
        Me.txtTel.Left = 0.0!
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; "
        Me.txtTel.Text = "txtTel"
        Me.txtTel.Top = 1.125!
        Me.txtTel.Width = 2.4375!
        '
        'txtReportName
        '
        Me.txtReportName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReportName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReportName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportName.Border.RightColor = System.Drawing.Color.Black
        Me.txtReportName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportName.Border.TopColor = System.Drawing.Color.Black
        Me.txtReportName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportName.Height = 0.1875!
        Me.txtReportName.Left = 0.0!
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; "
        Me.txtReportName.Text = "txtReportName"
        Me.txtReportName.Top = 1.3125!
        Me.txtReportName.Width = 2.4375!
        '
        'txtTime
        '
        Me.txtTime.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTime.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTime.Border.RightColor = System.Drawing.Color.Black
        Me.txtTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTime.Border.TopColor = System.Drawing.Color.Black
        Me.txtTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTime.Height = 0.1875!
        Me.txtTime.Left = 0.625!
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtTime.Text = "txtTime"
        Me.txtTime.Top = 1.625!
        Me.txtTime.Width = 1.8125!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Height = 0.1875!
        Me.TextBox20.Left = 0.0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; "
        Me.TextBox20.Text = "DATE:"
        Me.TextBox20.Top = 1.625!
        Me.TextBox20.Width = 0.5625!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Height = 0.1875!
        Me.TextBox13.Left = 1.375!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox13.Text = "COUNTER: "
        Me.TextBox13.Top = 2.0!
        Me.TextBox13.Width = 0.75!
        '
        'txtUser
        '
        Me.txtUser.Border.BottomColor = System.Drawing.Color.Black
        Me.txtUser.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.LeftColor = System.Drawing.Color.Black
        Me.txtUser.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.RightColor = System.Drawing.Color.Black
        Me.txtUser.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.TopColor = System.Drawing.Color.Black
        Me.txtUser.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Height = 0.1875!
        Me.txtUser.Left = 0.625!
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtUser.Text = "txtUser"
        Me.txtUser.Top = 1.8125!
        Me.txtUser.Width = 1.8125!
        '
        'txtCounter
        '
        Me.txtCounter.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCounter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCounter.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCounter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCounter.Border.RightColor = System.Drawing.Color.Black
        Me.txtCounter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCounter.Border.TopColor = System.Drawing.Color.Black
        Me.txtCounter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCounter.Height = 0.1875!
        Me.txtCounter.Left = 2.1875!
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.OutputFormat = resources.GetString("txtCounter.OutputFormat")
        Me.txtCounter.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtCounter.Text = "txtCounter"
        Me.txtCounter.Top = 2.0!
        Me.txtCounter.Width = 0.25!
        '
        'Line6
        '
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.0!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 2.4375!
        Me.Line6.Width = 2.4375!
        Me.Line6.X1 = 0.0!
        Me.Line6.X2 = 2.4375!
        Me.Line6.Y1 = 2.4375!
        Me.Line6.Y2 = 2.4375!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 0.0!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox12.Text = "CASHIER :"
        Me.TextBox12.Top = 1.8125!
        Me.TextBox12.Width = 0.625!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox1.Text = "Code & Desc"
        Me.TextBox1.Top = 2.5!
        Me.TextBox1.Width = 1.0!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Height = 0.1875!
        Me.TextBox11.Left = 1.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox11.Text = "Qty"
        Me.TextBox11.Top = 2.5!
        Me.TextBox11.Width = 0.25!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 1.25!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox9.Text = "Price"
        Me.TextBox9.Top = 2.5!
        Me.TextBox9.Width = 0.5!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 1.75!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox3.Text = "Amount"
        Me.TextBox3.Top = 2.5!
        Me.TextBox3.Width = 0.625!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 2.75!
        Me.Line1.Width = 2.4375!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 2.4375!
        Me.Line1.Y1 = 2.75!
        Me.Line1.Y2 = 2.75!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 0.0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox4.Text = "CB# :"
        Me.TextBox4.Top = 2.0!
        Me.TextBox4.Width = 0.5625!
        '
        'txtReceiptId
        '
        Me.txtReceiptId.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReceiptId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptId.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReceiptId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptId.Border.RightColor = System.Drawing.Color.Black
        Me.txtReceiptId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptId.Border.TopColor = System.Drawing.Color.Black
        Me.txtReceiptId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptId.Height = 0.1875!
        Me.txtReceiptId.Left = 0.625!
        Me.txtReceiptId.Name = "txtReceiptId"
        Me.txtReceiptId.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtReceiptId.Text = "txtReceiptId"
        Me.txtReceiptId.Top = 2.0!
        Me.txtReceiptId.Width = 0.75!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 0.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox5.Text = "SALES :"
        Me.TextBox5.Top = 2.1875!
        Me.TextBox5.Width = 0.5625!
        '
        'txtSales
        '
        Me.txtSales.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSales.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSales.Border.RightColor = System.Drawing.Color.Black
        Me.txtSales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSales.Border.TopColor = System.Drawing.Color.Black
        Me.txtSales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSales.Height = 0.1875!
        Me.txtSales.Left = 0.625!
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtSales.Text = "txtSales"
        Me.txtSales.Top = 2.1875!
        Me.txtSales.Width = 1.75!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCode, Me.txtQty, Me.txtPrice, Me.txtAmount, Me.txtDesc})
        Me.Detail1.Height = 0.3645833!
        Me.Detail1.Name = "Detail1"
        '
        'txtCode
        '
        Me.txtCode.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCode.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCode.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCode.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCode.Border.RightColor = System.Drawing.Color.Black
        Me.txtCode.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCode.Border.TopColor = System.Drawing.Color.Black
        Me.txtCode.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCode.DataField = "item_code"
        Me.txtCode.Height = 0.1875!
        Me.txtCode.Left = 0.0!
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtCode.Text = "txtCode"
        Me.txtCode.Top = 0.1875!
        Me.txtCode.Width = 1.0!
        '
        'txtQty
        '
        Me.txtQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQty.DataField = "total_quantity"
        Me.txtQty.Height = 0.1875!
        Me.txtQty.Left = 1.0!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.OutputFormat = resources.GetString("txtQty.OutputFormat")
        Me.txtQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtQty.Text = "txtQty"
        Me.txtQty.Top = 0.1875!
        Me.txtQty.Width = 0.25!
        '
        'txtPrice
        '
        Me.txtPrice.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPrice.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrice.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPrice.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrice.Border.RightColor = System.Drawing.Color.Black
        Me.txtPrice.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrice.Border.TopColor = System.Drawing.Color.Black
        Me.txtPrice.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrice.DataField = "unit_price_quoted"
        Me.txtPrice.Height = 0.1875!
        Me.txtPrice.Left = 1.1875!
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.OutputFormat = resources.GetString("txtPrice.OutputFormat")
        Me.txtPrice.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtPrice.Text = "txtPrice"
        Me.txtPrice.Top = 0.1875!
        Me.txtPrice.Width = 0.625!
        '
        'txtAmount
        '
        Me.txtAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.DataField = "total"
        Me.txtAmount.Height = 0.1875!
        Me.txtAmount.Left = 1.8125!
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.OutputFormat = resources.GetString("txtAmount.OutputFormat")
        Me.txtAmount.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtAmount.Text = "txtAmount"
        Me.txtAmount.Top = 0.1875!
        Me.txtAmount.Width = 0.625!
        '
        'txtDesc
        '
        Me.txtDesc.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDesc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesc.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDesc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesc.Border.RightColor = System.Drawing.Color.Black
        Me.txtDesc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesc.Border.TopColor = System.Drawing.Color.Black
        Me.txtDesc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesc.DataField = "name"
        Me.txtDesc.Height = 0.1875!
        Me.txtDesc.Left = 0.0!
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtDesc.Text = "txtDesc"
        Me.txtDesc.Top = 0.0!
        Me.txtDesc.Width = 2.4375!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srptHeader})
        Me.ReportHeader1.Height = 0.25!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox25, Me.txtTendered, Me.TextBox27, Me.txtChange, Me.txtRemarks, Me.txtTotalQty, Me.txtTotal, Me.Line4, Me.TextBox21, Me.TextBox22, Me.txtNetTotal, Me.txtPosMsg1, Me.txtPosMsg2, Me.Line3, Me.txtPosMsg3, Me.txtPosMsg4, Me.TextBox2, Me.txtTax, Me.txtDeposit, Me.TextBox6, Me.txtPayment})
        Me.ReportFooter1.Height = 2.770833!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Height = 0.188!
        Me.TextBox25.Left = 0.0!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox25.Text = "TENDERED:"
        Me.TextBox25.Top = 0.9375!
        Me.TextBox25.Width = 1.0!
        '
        'txtTendered
        '
        Me.txtTendered.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTendered.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTendered.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTendered.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTendered.Border.RightColor = System.Drawing.Color.Black
        Me.txtTendered.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTendered.Border.TopColor = System.Drawing.Color.Black
        Me.txtTendered.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTendered.Height = 0.1875!
        Me.txtTendered.Left = 1.625!
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTendered.Text = "txtTendered"
        Me.txtTendered.Top = 0.9375!
        Me.txtTendered.Width = 0.8125!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Height = 0.1875!
        Me.TextBox27.Left = 0.0!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox27.Text = "CHANGE RETURNED:"
        Me.TextBox27.Top = 1.125!
        Me.TextBox27.Width = 1.25!
        '
        'txtChange
        '
        Me.txtChange.Border.BottomColor = System.Drawing.Color.Black
        Me.txtChange.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChange.Border.LeftColor = System.Drawing.Color.Black
        Me.txtChange.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChange.Border.RightColor = System.Drawing.Color.Black
        Me.txtChange.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChange.Border.TopColor = System.Drawing.Color.Black
        Me.txtChange.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChange.Height = 0.1875!
        Me.txtChange.Left = 1.625!
        Me.txtChange.Name = "txtChange"
        Me.txtChange.OutputFormat = resources.GetString("txtChange.OutputFormat")
        Me.txtChange.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtChange.Text = "txtChange"
        Me.txtChange.Top = 1.125!
        Me.txtChange.Width = 0.8125!
        '
        'txtRemarks
        '
        Me.txtRemarks.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRemarks.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRemarks.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRemarks.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRemarks.Border.RightColor = System.Drawing.Color.Black
        Me.txtRemarks.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRemarks.Border.TopColor = System.Drawing.Color.Black
        Me.txtRemarks.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRemarks.Height = 0.1875!
        Me.txtRemarks.Left = 0.0!
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtRemarks.Text = "Remarks:"
        Me.txtRemarks.Top = 1.625!
        Me.txtRemarks.Width = 2.4375!
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalQty.Height = 0.1875!
        Me.txtTotalQty.Left = 0.9375!
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.OutputFormat = resources.GetString("txtTotalQty.OutputFormat")
        Me.txtTotalQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalQty.Text = "txtTotalQty"
        Me.txtTotalQty.Top = 0.0625!
        Me.txtTotalQty.Width = 0.3125!
        '
        'txtTotal
        '
        Me.txtTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Height = 0.1875!
        Me.txtTotal.Left = 1.625!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
        Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotal.Text = "txtSubTotal"
        Me.txtTotal.Top = 0.0625!
        Me.txtTotal.Width = 0.8125!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.6875!
        Me.Line4.Width = 2.4375!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 2.4375!
        Me.Line4.Y1 = 0.6875!
        Me.Line4.Y2 = 0.6875!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Height = 0.1875!
        Me.TextBox21.Left = 0.0!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox21.Text = "TOTAL:"
        Me.TextBox21.Top = 0.0625!
        Me.TextBox21.Width = 0.8125!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Height = 0.188!
        Me.TextBox22.Left = 0.0!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox22.Text = "NET TOTAL:"
        Me.TextBox22.Top = 0.75!
        Me.TextBox22.Width = 0.75!
        '
        'txtNetTotal
        '
        Me.txtNetTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNetTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNetTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtNetTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtNetTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetTotal.Height = 0.1875!
        Me.txtNetTotal.Left = 1.625!
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.OutputFormat = resources.GetString("txtNetTotal.OutputFormat")
        Me.txtNetTotal.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtNetTotal.Text = "txtNetTotal"
        Me.txtNetTotal.Top = 0.75!
        Me.txtNetTotal.Width = 0.8125!
        '
        'txtPosMsg1
        '
        Me.txtPosMsg1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPosMsg1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPosMsg1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg1.Border.RightColor = System.Drawing.Color.Black
        Me.txtPosMsg1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg1.Border.TopColor = System.Drawing.Color.Black
        Me.txtPosMsg1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg1.Height = 0.1875!
        Me.txtPosMsg1.Left = 0.0!
        Me.txtPosMsg1.Name = "txtPosMsg1"
        Me.txtPosMsg1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtPosMsg1.Text = "txtPosMsg1"
        Me.txtPosMsg1.Top = 1.875!
        Me.txtPosMsg1.Width = 2.4375!
        '
        'txtPosMsg2
        '
        Me.txtPosMsg2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPosMsg2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPosMsg2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg2.Border.RightColor = System.Drawing.Color.Black
        Me.txtPosMsg2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg2.Border.TopColor = System.Drawing.Color.Black
        Me.txtPosMsg2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg2.Height = 0.1875!
        Me.txtPosMsg2.Left = 0.0!
        Me.txtPosMsg2.Name = "txtPosMsg2"
        Me.txtPosMsg2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtPosMsg2.Tag = " "
        Me.txtPosMsg2.Text = "txtPosMsg2"
        Me.txtPosMsg2.Top = 2.0625!
        Me.txtPosMsg2.Width = 2.4375!
        '
        'Line3
        '
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 2.4375!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 2.4375!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.0!
        '
        'txtPosMsg3
        '
        Me.txtPosMsg3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPosMsg3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPosMsg3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg3.Border.RightColor = System.Drawing.Color.Black
        Me.txtPosMsg3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg3.Border.TopColor = System.Drawing.Color.Black
        Me.txtPosMsg3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg3.Height = 0.1875!
        Me.txtPosMsg3.Left = 0.0!
        Me.txtPosMsg3.Name = "txtPosMsg3"
        Me.txtPosMsg3.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtPosMsg3.Tag = " "
        Me.txtPosMsg3.Text = "txtPosMsg3"
        Me.txtPosMsg3.Top = 2.25!
        Me.txtPosMsg3.Width = 2.4375!
        '
        'txtPosMsg4
        '
        Me.txtPosMsg4.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPosMsg4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg4.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPosMsg4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg4.Border.RightColor = System.Drawing.Color.Black
        Me.txtPosMsg4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg4.Border.TopColor = System.Drawing.Color.Black
        Me.txtPosMsg4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg4.Height = 0.1875!
        Me.txtPosMsg4.Left = 0.0!
        Me.txtPosMsg4.Name = "txtPosMsg4"
        Me.txtPosMsg4.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtPosMsg4.Tag = " "
        Me.txtPosMsg4.Text = "txtPosMsg4"
        Me.txtPosMsg4.Top = 2.4375!
        Me.txtPosMsg4.Width = 2.4375!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox2.Text = "TAX:"
        Me.TextBox2.Top = 0.25!
        Me.TextBox2.Width = 0.75!
        '
        'txtTax
        '
        Me.txtTax.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTax.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTax.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTax.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTax.Border.RightColor = System.Drawing.Color.Black
        Me.txtTax.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTax.Border.TopColor = System.Drawing.Color.Black
        Me.txtTax.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTax.Height = 0.1875!
        Me.txtTax.Left = 1.625!
        Me.txtTax.Name = "txtTax"
        Me.txtTax.OutputFormat = resources.GetString("txtTax.OutputFormat")
        Me.txtTax.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTax.Text = "txtTax"
        Me.txtTax.Top = 0.25!
        Me.txtTax.Width = 0.8125!
        '
        'txtDeposit
        '
        Me.txtDeposit.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDeposit.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDeposit.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDeposit.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDeposit.Border.RightColor = System.Drawing.Color.Black
        Me.txtDeposit.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDeposit.Border.TopColor = System.Drawing.Color.Black
        Me.txtDeposit.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDeposit.Height = 0.1875!
        Me.txtDeposit.Left = 1.625!
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.OutputFormat = resources.GetString("txtDeposit.OutputFormat")
        Me.txtDeposit.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtDeposit.Text = "txtDeposit"
        Me.txtDeposit.Top = 0.4375!
        Me.txtDeposit.Width = 0.8125!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 0.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox6.Text = "DEPOSIT:"
        Me.TextBox6.Top = 0.4375!
        Me.TextBox6.Width = 0.75!
        '
        'txtPayment
        '
        Me.txtPayment.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPayment.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPayment.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPayment.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPayment.Border.RightColor = System.Drawing.Color.Black
        Me.txtPayment.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPayment.Border.TopColor = System.Drawing.Color.Black
        Me.txtPayment.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPayment.Height = 0.1875!
        Me.txtPayment.Left = 0.0!
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtPayment.Text = "Remarks:"
        Me.txtPayment.Top = 1.4375!
        Me.txtPayment.Width = 2.4375!
        '
        'srptHeader
        '
        Me.srptHeader.Border.BottomColor = System.Drawing.Color.Black
        Me.srptHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptHeader.Border.LeftColor = System.Drawing.Color.Black
        Me.srptHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptHeader.Border.RightColor = System.Drawing.Color.Black
        Me.srptHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptHeader.Border.TopColor = System.Drawing.Color.Black
        Me.srptHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptHeader.CloseBorder = False
        Me.srptHeader.Height = 0.25!
        Me.srptHeader.Left = 0.0!
        Me.srptHeader.Name = "srptHeader"
        Me.srptHeader.Report = Nothing
        Me.srptHeader.ReportName = "SubReport1"
        Me.srptHeader.Top = 0.0!
        Me.srptHeader.Width = 2.625!
        '
        'rptReceipt
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.5!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiptId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTendered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTendered As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtChange As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRemarks As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBranchName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtZip As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtState As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTel As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCounter As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReceiptId As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCode As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDesc As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNetTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtPosMsg3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTax As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDeposit As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPayment As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
End Class
