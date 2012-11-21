<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCCNo = New System.Windows.Forms.TextBox
        Me.txtCCName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCCAppCode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtCash = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCC = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboCCType = New System.Windows.Forms.ComboBox
        Me.txtCCBank = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCheque = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtChequeNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPDChequeNo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPDCheque = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtOther = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.dtpPDChequeDate = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblTotalAmt = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotal.Location = New System.Drawing.Point(135, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(238, 39)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "RM   0.00        "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CC Number"
        '
        'txtCCNo
        '
        Me.txtCCNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCNo.Location = New System.Drawing.Point(242, 124)
        Me.txtCCNo.Name = "txtCCNo"
        Me.txtCCNo.Size = New System.Drawing.Size(123, 20)
        Me.txtCCNo.TabIndex = 4
        '
        'txtCCName
        '
        Me.txtCCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCName.Location = New System.Drawing.Point(140, 176)
        Me.txtCCName.Name = "txtCCName"
        Me.txtCCName.Size = New System.Drawing.Size(225, 20)
        Me.txtCCName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CC Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CC Expiry"
        '
        'txtCCAppCode
        '
        Me.txtCCAppCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCAppCode.Location = New System.Drawing.Point(140, 229)
        Me.txtCCAppCode.Name = "txtCCAppCode"
        Me.txtCCAppCode.Size = New System.Drawing.Size(109, 20)
        Me.txtCCAppCode.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = " CC Approval Code"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cboYear.Location = New System.Drawing.Point(140, 202)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(109, 21)
        Me.cboYear.TabIndex = 7
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboMonth.Location = New System.Drawing.Point(255, 202)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(110, 21)
        Me.cboMonth.TabIndex = 8
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(211, 457)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 18
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(292, 457)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtCash
        '
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCash.Location = New System.Drawing.Point(140, 61)
        Me.txtCash.MaxLength = 12
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(62, 20)
        Me.txtCash.TabIndex = 1
        Me.txtCash.Text = "0"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cash"
        '
        'txtCC
        '
        Me.txtCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCC.Location = New System.Drawing.Point(140, 97)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(62, 20)
        Me.txtCC.TabIndex = 2
        Me.txtCC.Text = "0"
        Me.txtCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Credit Card"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'cboCCType
        '
        Me.cboCCType.FormattingEnabled = True
        Me.cboCCType.Items.AddRange(New Object() {"VISA", "MASTER", "AMEX", "DINERS", "OTHER"})
        Me.cboCCType.Location = New System.Drawing.Point(140, 123)
        Me.cboCCType.Name = "cboCCType"
        Me.cboCCType.Size = New System.Drawing.Size(96, 21)
        Me.cboCCType.TabIndex = 3
        '
        'txtCCBank
        '
        Me.txtCCBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCBank.Location = New System.Drawing.Point(140, 150)
        Me.txtCCBank.Name = "txtCCBank"
        Me.txtCCBank.Size = New System.Drawing.Size(225, 20)
        Me.txtCCBank.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "CC Bank"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(13, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'txtCheque
        '
        Me.txtCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCheque.Location = New System.Drawing.Point(140, 267)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(62, 20)
        Me.txtCheque.TabIndex = 11
        Me.txtCheque.Text = "0"
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Cheque"
        '
        'txtChequeNo
        '
        Me.txtChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChequeNo.Location = New System.Drawing.Point(298, 267)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(68, 20)
        Me.txtChequeNo.TabIndex = 12
        Me.txtChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(208, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Cheque No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Cheque Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(13, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'txtPDChequeNo
        '
        Me.txtPDChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPDChequeNo.Location = New System.Drawing.Point(298, 332)
        Me.txtPDChequeNo.Name = "txtPDChequeNo"
        Me.txtPDChequeNo.Size = New System.Drawing.Size(68, 20)
        Me.txtPDChequeNo.TabIndex = 15
        Me.txtPDChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(208, 336)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "PD Cheque No."
        '
        'txtPDCheque
        '
        Me.txtPDCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPDCheque.Location = New System.Drawing.Point(140, 332)
        Me.txtPDCheque.Name = "txtPDCheque"
        Me.txtPDCheque.Size = New System.Drawing.Size(62, 20)
        Me.txtPDCheque.TabIndex = 14
        Me.txtPDCheque.Text = "0"
        Me.txtPDCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 336)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "PD Cheque"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "PD Cheque Date"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(15, 382)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'txtOther
        '
        Me.txtOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOther.Location = New System.Drawing.Point(140, 394)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(62, 20)
        Me.txtOther.TabIndex = 17
        Me.txtOther.Text = "0"
        Me.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 398)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Other / Contra"
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(140, 294)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(81, 20)
        Me.dtpChequeDate.TabIndex = 13
        '
        'dtpPDChequeDate
        '
        Me.dtpPDChequeDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpPDChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPDChequeDate.Location = New System.Drawing.Point(140, 360)
        Me.dtpPDChequeDate.Name = "dtpPDChequeDate"
        Me.dtpPDChequeDate.Size = New System.Drawing.Size(81, 20)
        Me.dtpPDChequeDate.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 431)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Total Amount"
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(13, 420)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTotalAmt.Location = New System.Drawing.Point(137, 431)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalAmt.TabIndex = 42
        Me.lblTotalAmt.Text = "0"
        '
        'frmMultiPayment
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(378, 488)
        Me.Controls.Add(Me.lblTotalAmt)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpPDChequeDate)
        Me.Controls.Add(Me.dtpChequeDate)
        Me.Controls.Add(Me.txtOther)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPDChequeNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPDCheque)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtChequeNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCCBank)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboCCType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.txtCCAppCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCCName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCCNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMultiPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCCNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCCName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCCAppCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCCType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCCBank As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPDChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPDCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPDChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalAmt As System.Windows.Forms.Label
End Class
