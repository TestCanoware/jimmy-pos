<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptReceipt_itKakimotor001
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptReceipt_itKakimotor001))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtBranchName = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd1 = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd2 = New DataDynamics.ActiveReports.TextBox
        Me.txtTel = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.txtReceiptID = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtDesc = New DataDynamics.ActiveReports.TextBox
        Me.txtCode = New DataDynamics.ActiveReports.TextBox
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtPrice = New DataDynamics.ActiveReports.TextBox
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.txtNetTotal = New DataDynamics.ActiveReports.TextBox
        Me.txtCash = New DataDynamics.ActiveReports.TextBox
        Me.txtTendered = New DataDynamics.ActiveReports.TextBox
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
        Me.txtChange = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg1 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg2 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg3 = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.txtSalesman = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.txtPosMsg4 = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd4 = New DataDynamics.ActiveReports.TextBox
        Me.txtBranchDesc = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiptID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTendered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBranchDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtBranchName, Me.txtAdd1, Me.txtAdd2, Me.txtTel, Me.txtTime, Me.txtReceiptID, Me.TextBox7, Me.txtUser, Me.Line2, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.txtAdd3, Me.TextBox3, Me.txtSalesman, Me.txtAdd4, Me.txtBranchDesc})
        Me.PageHeader1.Height = 2.479167!
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
        Me.txtBranchName.Style = "text-align: center; font-size: 8pt; "
        Me.txtBranchName.Text = "txtBranchName"
        Me.txtBranchName.Top = 0.0625!
        Me.txtBranchName.Width = 2.5!
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
        Me.txtAdd1.Style = "text-align: center; font-size: 8pt; "
        Me.txtAdd1.Text = "txtAdd1"
        Me.txtAdd1.Top = 0.4375!
        Me.txtAdd1.Width = 2.5!
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
        Me.txtAdd2.Style = "text-align: center; font-size: 8pt; "
        Me.txtAdd2.Text = "txtAdd2"
        Me.txtAdd2.Top = 0.625!
        Me.txtAdd2.Width = 2.5!
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
        Me.txtTel.Style = "text-align: center; font-size: 8pt; "
        Me.txtTel.Text = "txtTel"
        Me.txtTel.Top = 1.25!
        Me.txtTel.Width = 2.5!
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
        Me.txtTime.Left = 0.0!
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Style = "text-align: left; font-size: 8pt; "
        Me.txtTime.Text = "txtTime"
        Me.txtTime.Top = 1.5!
        Me.txtTime.Width = 2.5!
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
        Me.txtReceiptID.Left = 1.8125!
        Me.txtReceiptID.Name = "txtReceiptID"
        Me.txtReceiptID.Style = "text-align: left; font-size: 8pt; "
        Me.txtReceiptID.Top = 1.75!
        Me.txtReceiptID.Width = 0.6875!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 0.0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox7.Text = "Cashier:"
        Me.TextBox7.Top = 1.75!
        Me.TextBox7.Width = 0.5!
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
        Me.txtUser.Left = 0.5625!
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "text-align: left; font-size: 8pt; "
        Me.txtUser.Top = 1.75!
        Me.txtUser.Width = 1.0!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 3.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.4375!
        Me.Line2.Width = 2.5!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 2.5!
        Me.Line2.Y1 = 2.4375!
        Me.Line2.Y2 = 2.4375!
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
        Me.TextBox10.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox10.Text = "Desc & Code"
        Me.TextBox10.Top = 2.25!
        Me.TextBox10.Width = 1.0625!
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
        Me.TextBox11.Left = 1.0625!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "text-align: right; font-size: 8pt; "
        Me.TextBox11.Text = "Qty"
        Me.TextBox11.Top = 2.25!
        Me.TextBox11.Width = 0.3125!
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
        Me.TextBox12.Left = 1.375!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "text-align: right; font-size: 8pt; "
        Me.TextBox12.Text = "Price"
        Me.TextBox12.Top = 2.25!
        Me.TextBox12.Width = 0.5625!
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
        Me.TextBox13.Left = 1.9375!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "text-align: right; font-size: 8pt; "
        Me.TextBox13.Text = "Amt"
        Me.TextBox13.Top = 2.25!
        Me.TextBox13.Width = 0.5625!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDesc, Me.txtCode, Me.txtQty, Me.txtPrice, Me.txtTotal})
        Me.Detail1.Height = 0.5!
        Me.Detail1.Name = "Detail1"
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
        Me.txtDesc.Style = "text-align: left; font-size: 8pt; "
        Me.txtDesc.Text = Nothing
        Me.txtDesc.Top = 0.0!
        Me.txtDesc.Width = 2.5!
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
        Me.txtCode.Style = "text-align: left; font-size: 8pt; "
        Me.txtCode.Text = Nothing
        Me.txtCode.Top = 0.25!
        Me.txtCode.Width = 1.0625!
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
        Me.txtQty.Left = 1.0625!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.OutputFormat = resources.GetString("txtQty.OutputFormat")
        Me.txtQty.Style = "text-align: right; font-size: 8pt; "
        Me.txtQty.Text = "0"
        Me.txtQty.Top = 0.25!
        Me.txtQty.Width = 0.3125!
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
        Me.txtPrice.Left = 1.375!
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.OutputFormat = resources.GetString("txtPrice.OutputFormat")
        Me.txtPrice.Style = "text-align: right; font-size: 8pt; "
        Me.txtPrice.Text = "0.00"
        Me.txtPrice.Top = 0.25!
        Me.txtPrice.Width = 0.5625!
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
        Me.txtTotal.DataField = "total"
        Me.txtTotal.Height = 0.1875!
        Me.txtTotal.Left = 1.9375!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
        Me.txtTotal.Style = "text-align: right; font-size: 8pt; "
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.Top = 0.25!
        Me.txtTotal.Width = 0.5625!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox22, Me.txtNetTotal, Me.txtCash, Me.txtTendered, Me.TextBox27, Me.txtChange, Me.txtPosMsg1, Me.txtPosMsg2, Me.txtPosMsg3, Me.Line1, Me.txtPosMsg4})
        Me.ReportFooter1.Height = 1.479167!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.TextBox22.Style = "text-align: left; font-weight: bold; font-size: 8pt; "
        Me.TextBox22.Text = "TOTAL AMT"
        Me.TextBox22.Top = 0.0!
        Me.TextBox22.Width = 1.375!
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
        Me.txtNetTotal.DataField = "total"
        Me.txtNetTotal.Height = 0.1875!
        Me.txtNetTotal.Left = 1.9375!
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.OutputFormat = resources.GetString("txtNetTotal.OutputFormat")
        Me.txtNetTotal.Style = "text-align: right; font-weight: bold; font-size: 8pt; "
        Me.txtNetTotal.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtNetTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtNetTotal.Text = "0.00"
        Me.txtNetTotal.Top = 0.0!
        Me.txtNetTotal.Width = 0.5625!
        '
        'txtCash
        '
        Me.txtCash.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCash.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCash.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCash.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCash.Border.RightColor = System.Drawing.Color.Black
        Me.txtCash.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCash.Border.TopColor = System.Drawing.Color.Black
        Me.txtCash.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCash.Height = 0.1875!
        Me.txtCash.Left = 0.0!
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Style = "text-align: left; font-weight: bold; font-size: 8pt; "
        Me.txtCash.Text = "CASH"
        Me.txtCash.Top = 0.1875!
        Me.txtCash.Width = 1.375!
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
        Me.txtTendered.Left = 2.0!
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.Style = "text-align: right; font-weight: bold; font-size: 8pt; "
        Me.txtTendered.Text = "0.00"
        Me.txtTendered.Top = 0.1875!
        Me.txtTendered.Width = 0.5!
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
        Me.TextBox27.Style = "text-align: left; font-weight: bold; font-size: 8pt; "
        Me.TextBox27.Text = "CHANGE"
        Me.TextBox27.Top = 0.375!
        Me.TextBox27.Width = 1.375!
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
        Me.txtChange.Left = 2.0!
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Style = "text-align: right; font-weight: bold; font-size: 8pt; "
        Me.txtChange.Text = "0.00"
        Me.txtChange.Top = 0.375!
        Me.txtChange.Width = 0.5!
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
        Me.txtPosMsg1.Style = "text-align: center; font-size: 8pt; "
        Me.txtPosMsg1.Text = "txtPosMsg1"
        Me.txtPosMsg1.Top = 0.625!
        Me.txtPosMsg1.Width = 2.5!
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
        Me.txtPosMsg2.Style = "text-align: center; font-size: 8pt; "
        Me.txtPosMsg2.Tag = " "
        Me.txtPosMsg2.Text = "txtPosMsg2"
        Me.txtPosMsg2.Top = 0.8125!
        Me.txtPosMsg2.Width = 2.5!
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
        Me.txtPosMsg3.Style = "text-align: center; font-size: 8pt; "
        Me.txtPosMsg3.Tag = " "
        Me.txtPosMsg3.Text = "txtPosMsg3"
        Me.txtPosMsg3.Top = 1.0!
        Me.txtPosMsg3.Width = 2.5!
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
        Me.txtAdd3.Style = "text-align: center; font-size: 8pt; "
        Me.txtAdd3.Text = "txtAdd3"
        Me.txtAdd3.Top = 0.8125!
        Me.txtAdd3.Width = 2.5!
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
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox3.Text = "Salesman:"
        Me.TextBox3.Top = 1.9375!
        Me.TextBox3.Width = 0.5625!
        '
        'txtSalesman
        '
        Me.txtSalesman.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSalesman.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSalesman.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSalesman.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSalesman.Border.RightColor = System.Drawing.Color.Black
        Me.txtSalesman.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSalesman.Border.TopColor = System.Drawing.Color.Black
        Me.txtSalesman.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSalesman.Height = 0.1875!
        Me.txtSalesman.Left = 0.5625!
        Me.txtSalesman.Name = "txtSalesman"
        Me.txtSalesman.Style = "text-align: left; font-size: 8pt; "
        Me.txtSalesman.Top = 1.9375!
        Me.txtSalesman.Width = 1.0!
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
        Me.Line1.LineWeight = 3.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 2.5!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 2.5!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
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
        Me.txtPosMsg4.Style = "text-align: center; font-size: 8pt; "
        Me.txtPosMsg4.Tag = " "
        Me.txtPosMsg4.Text = "txtPosMsg4"
        Me.txtPosMsg4.Top = 1.1875!
        Me.txtPosMsg4.Width = 2.5!
        '
        'txtAdd4
        '
        Me.txtAdd4.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAdd4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd4.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAdd4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd4.Border.RightColor = System.Drawing.Color.Black
        Me.txtAdd4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd4.Border.TopColor = System.Drawing.Color.Black
        Me.txtAdd4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd4.Height = 0.1875!
        Me.txtAdd4.Left = 0.0!
        Me.txtAdd4.Name = "txtAdd4"
        Me.txtAdd4.Style = "text-align: center; font-size: 8pt; "
        Me.txtAdd4.Text = "txtAdd4"
        Me.txtAdd4.Top = 1.0!
        Me.txtAdd4.Width = 2.5!
        '
        'txtBranchDesc
        '
        Me.txtBranchDesc.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBranchDesc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchDesc.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBranchDesc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchDesc.Border.RightColor = System.Drawing.Color.Black
        Me.txtBranchDesc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchDesc.Border.TopColor = System.Drawing.Color.Black
        Me.txtBranchDesc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchDesc.Height = 0.1875!
        Me.txtBranchDesc.Left = 0.0!
        Me.txtBranchDesc.Name = "txtBranchDesc"
        Me.txtBranchDesc.Style = "text-align: center; font-size: 8pt; "
        Me.txtBranchDesc.Text = "txtBranchDesc"
        Me.txtBranchDesc.Top = 0.25!
        Me.txtBranchDesc.Width = 2.5!
        '
        'rptReceipt_itKakimotor001
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.5625!
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
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiptID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTendered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBranchDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtBranchName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTel As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReceiptID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDesc As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCode As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNetTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCash As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTendered As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtChange As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSalesman As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtPosMsg4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBranchDesc As DataDynamics.ActiveReports.TextBox
End Class
