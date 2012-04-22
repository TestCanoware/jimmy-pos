<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDeposit
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptDeposit))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.txtAmount = New DataDynamics.ActiveReports.TextBox
        Me.txtPaymentDetails = New DataDynamics.ActiveReports.TextBox
        Me.txtRemarks = New DataDynamics.ActiveReports.TextBox
        Me.txtReceived = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtReceiptID = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtDate = New DataDynamics.ActiveReports.TextBox
        Me.txtAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtSales = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaymentDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiptID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox10, Me.TextBox21, Me.TextBox2, Me.TextBox22, Me.txtAmount, Me.txtPaymentDetails, Me.txtRemarks, Me.txtReceived, Me.TextBox11, Me.TextBox14, Me.Line3, Me.TextBox12, Me.Line1, Me.txtReportName, Me.txtReceiptID, Me.txtUser, Me.txtTime})
        Me.PageHeader1.Height = 1.875!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 0.0!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox10.Text = "RECEIVED FROM"
        Me.TextBox10.Top = 0.8125!
        Me.TextBox10.Width = 1.0!
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
        Me.TextBox21.Text = "PAYMENT DETAILS"
        Me.TextBox21.Top = 1.1875!
        Me.TextBox21.Width = 1.125!
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
        Me.TextBox2.Text = "REMARKS"
        Me.TextBox2.Top = 1.375!
        Me.TextBox2.Width = 1.0!
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
        Me.TextBox22.Height = 0.1875!
        Me.TextBox22.Left = 0.0!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox22.Text = "AMOUNT"
        Me.TextBox22.Top = 1.0!
        Me.TextBox22.Width = 1.0!
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
        Me.txtAmount.Height = 0.1875!
        Me.txtAmount.Left = 1.0625!
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtAmount.Text = Nothing
        Me.txtAmount.Top = 1.0!
        Me.txtAmount.Width = 1.375!
        '
        'txtPaymentDetails
        '
        Me.txtPaymentDetails.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPaymentDetails.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentDetails.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPaymentDetails.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentDetails.Border.RightColor = System.Drawing.Color.Black
        Me.txtPaymentDetails.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentDetails.Border.TopColor = System.Drawing.Color.Black
        Me.txtPaymentDetails.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentDetails.Height = 0.1875!
        Me.txtPaymentDetails.Left = 1.0625!
        Me.txtPaymentDetails.Name = "txtPaymentDetails"
        Me.txtPaymentDetails.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtPaymentDetails.Text = Nothing
        Me.txtPaymentDetails.Top = 1.1875!
        Me.txtPaymentDetails.Width = 1.375!
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
        Me.txtRemarks.Left = 1.0625!
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtRemarks.Text = Nothing
        Me.txtRemarks.Top = 1.375!
        Me.txtRemarks.Width = 1.375!
        '
        'txtReceived
        '
        Me.txtReceived.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReceived.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceived.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReceived.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceived.Border.RightColor = System.Drawing.Color.Black
        Me.txtReceived.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceived.Border.TopColor = System.Drawing.Color.Black
        Me.txtReceived.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceived.Height = 0.1875!
        Me.txtReceived.Left = 1.0625!
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtReceived.Text = Nothing
        Me.txtReceived.Top = 0.8125!
        Me.txtReceived.Width = 1.375!
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
        Me.TextBox11.Left = 0.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "text-decoration: underline; ddo-char-set: 0; text-align: left; font-size: 8.25pt;" & _
            " font-family: Arial; "
        Me.TextBox11.Text = "Date"
        Me.TextBox11.Top = 1.6875!
        Me.TextBox11.Width = 0.8125!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 0.9375!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; font-family: Arial; "
        Me.TextBox14.Text = "Amt"
        Me.TextBox14.Top = 1.6875!
        Me.TextBox14.Width = 0.5625!
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
        Me.Line3.Top = 1.625!
        Me.Line3.Width = 2.4375!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 2.4375!
        Me.Line3.Y1 = 1.625!
        Me.Line3.Y2 = 1.625!
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
        Me.TextBox12.Left = 1.625!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "text-decoration: underline; ddo-char-set: 0; text-align: left; font-size: 8.25pt;" & _
            " font-family: Arial; "
        Me.TextBox12.Text = "Sales Person"
        Me.TextBox12.Top = 1.6875!
        Me.TextBox12.Width = 0.8125!
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
        Me.Line1.Top = 0.75!
        Me.Line1.Width = 2.4375!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 2.4375!
        Me.Line1.Y1 = 0.75!
        Me.Line1.Y2 = 0.75!
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
        Me.txtReportName.Top = 0.0!
        Me.txtReportName.Width = 2.4375!
        '
        'txtReceiptID
        '
        Me.txtReceiptID.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReceiptID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptID.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReceiptID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptID.Border.RightColor = System.Drawing.Color.Black
        Me.txtReceiptID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptID.Border.TopColor = System.Drawing.Color.Black
        Me.txtReceiptID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptID.Height = 0.1875!
        Me.txtReceiptID.Left = 0.0!
        Me.txtReceiptID.Name = "txtReceiptID"
        Me.txtReceiptID.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtReceiptID.Text = "txtReceiptID"
        Me.txtReceiptID.Top = 0.3125!
        Me.txtReceiptID.Width = 0.625!
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
        Me.txtUser.Left = 0.0!
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtUser.Text = "txtUser"
        Me.txtUser.Top = 0.5!
        Me.txtUser.Width = 2.4375!
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
        Me.txtTime.Left = 0.6875!
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtTime.Text = "txtTime"
        Me.txtTime.Top = 0.3125!
        Me.txtTime.Width = 1.75!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDate, Me.txtAmt, Me.txtSales})
        Me.Detail1.Height = 0.1875!
        Me.Detail1.Name = "Detail1"
        '
        'txtDate
        '
        Me.txtDate.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.RightColor = System.Drawing.Color.Black
        Me.txtDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.TopColor = System.Drawing.Color.Black
        Me.txtDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Height = 0.1875!
        Me.txtDate.Left = 0.0!
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; font-f" & _
            "amily: Arial; "
        Me.txtDate.Text = Nothing
        Me.txtDate.Top = 0.0!
        Me.txtDate.Width = 0.8125!
        '
        'txtAmt
        '
        Me.txtAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmt.Height = 0.1875!
        Me.txtAmt.Left = 0.9375!
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; font-f" & _
            "amily: Arial; "
        Me.txtAmt.Text = Nothing
        Me.txtAmt.Top = 0.0!
        Me.txtAmt.Width = 0.5625!
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
        Me.txtSales.Left = 1.625!
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; font-f" & _
            "amily: Arial; "
        Me.txtSales.Text = Nothing
        Me.txtSales.Top = 0.0!
        Me.txtSales.Width = 0.8125!
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
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line4, Me.TextBox3})
        Me.ReportFooter1.Height = 0.8125!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Line4.Top = 0.5625!
        Me.Line4.Width = 1.375!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 1.375!
        Me.Line4.Y1 = 0.5625!
        Me.Line4.Y2 = 0.5625!
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
        Me.TextBox3.Left = 0.0625!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox3.Text = "(Authorized Signature) "
        Me.TextBox3.Top = 0.625!
        Me.TextBox3.Width = 1.25!
        '
        'rptDeposit
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.47!
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
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaymentDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiptID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPaymentDetails As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRemarks As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReceived As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReceiptID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
End Class
