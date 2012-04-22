
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmOtherPayments


#Region " Variable Declarations "

    Private FORMTITLE As String = "Other Payments"
    
    Public total As Decimal = 0

    Private amtCash As Decimal = 0
    Private amtCard As Decimal = 0
    Private amtCheque As Decimal = 0
    Private amtPDCheque As Decimal = 0
    Private amtCoupon As Decimal = 0
    Private amtOther As Decimal = 0
    Private amtTotal As Decimal = 0

    Public objReceipt As DAOfficialReceiptObject

    Public Enum FormMode
        MAIN
        DEPOSIT
    End Enum

    Public frmMode As FormMode

#End Region

#Region " Initialisation "

    Private Sub frmOtherPayments_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        gStopScreenKeyboard()
    End Sub

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialise()
    End Sub

    Private Sub Initialise()
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        General.CursorButtons(Me, Cursors.Hand)

        SetupDefaultControls()

        SetEventHanlder()

        If objReceipt Is Nothing Then objReceipt = New DAOfficialReceiptObject
    End Sub

    Private Sub SetupDefaultControls()
        ClearFields(Me)

        lblTotalAmount.Text = gBranchObj.currency & " " & FormatCurrency(total)
        lblTotalAmtShow.Text = gBranchObj.currency & " " & FormatCurrency(amtTotal)

        txtCash.Text = "0.00"
        txtCard.Text = "0.00"
        txtCheque.Text = "0.00"
        txtPDCheque.Text = "0.00"
        txtCoupon.Text = "0.00"
        txtOther.Text = "0.00"

        btnConfirm.Enabled = False

        Load_cboMonth()
        Load_cboYear()
    End Sub

    Private Sub SetEventHanlder()

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

    Private Sub Load_cboYear()
        cboYear.Items.Clear()
        For i As Integer = 0 To 9
            cboYear.Items.Add(Now.AddYears(i).Year)
        Next
    End Sub

    Private Sub Load_cboMonth()
        cboMonth.Items.Clear()
        For i As Integer = 1 To 12
            cboMonth.Items.Add(MonthName(i))
        Next
    End Sub

#End Region

#Region " Database Updating - Presentation Layer "


#End Region

#Region " Controls Populating, Updating, etc "


    Private Sub ClearControls()

    End Sub


#End Region

#Region " Utility Procedures "

    Public Function isMain() As Boolean
        Return frmMode = FormMode.MAIN
    End Function

    Public Function GetDecimal(ByVal txt As TextBox) As Decimal
        Dim dec As Decimal = 0
        If txt.TextLength > 0 Then
            dec = Convert.ToDecimal(txt.Text)
        End If

        Return dec
    End Function
#End Region

#Region " Event Handler/Response "

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If isMain() Then
            If Not gShowMsgTxnConfirm() Then Exit Sub
        End If

        'Update Receipt Object
        With objReceipt
            .amount = amtTotal
            .amountCash = amtCash
            .amountCard = amtCard
            .amountCheque = amtCheque
            .amountPDCheque = amtPDCheque
            .amountCoupon = amtCoupon
            .amountCoupon = amtOther

            If .amountCard > 0 Then
                .cardType = cboCCType.SelectedText
                .cardName = txtCCName.Text.Trim
                .cardBank = txtCCBank.Text.Trim
                .cardNumber = txtCCNo.Text.Trim
                If cboYear.Text.Length > 0 AndAlso cboMonth.Text.Length > 0 Then
                    .cardValidThru = GetLastDayInMonth(cboYear.Text, cboMonth.Text)
                End If
                .cardApprovalCode = txtCCAppCode.Text.Trim
            End If

            ' TODO: Need add card payment config charge
            '.cardPctCharges = 
            '.cardSurcharge()
            '.cardId = cardpaymentconfig;

        End With

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress, txtCard.KeyPress, _
                                                                                txtCheque.KeyPress, txtPDCheque.KeyPress, txtCoupon.KeyPress, txtOther.KeyPress
        e.Handled = Utils.General.KeyPressDecimal(sender, e)
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged, txtCard.TextChanged, _
                                                            txtCheque.TextChanged, txtPDCheque.TextChanged, txtCoupon.TextChanged, txtOther.TextChanged

        amtCash = GetDecimal(txtCash)
        amtCard = GetDecimal(txtCard)
        amtCheque = GetDecimal(txtCheque)
        amtPDCheque = GetDecimal(txtPDCheque)
        amtCoupon = GetDecimal(txtCoupon)
        amtOther = GetDecimal(txtOther)

        amtTotal = amtCash + amtCard + amtCheque + amtPDCheque + amtCoupon + amtOther

        lblTotalAmtShow.Text = gBranchObj.currency & " " & FormatCurrency(amtTotal)

        If frmMode = FormMode.MAIN Then
            btnConfirm.Enabled = (amtTotal = total)
        Else
            btnConfirm.Enabled = amtTotal > 0
        End If

    End Sub

    Private Sub picKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picKeyboard.Click
        gShowScreenKeyboard()
    End Sub

#End Region


    Private Sub txtCCNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCCNo.Leave
        If txtCCNo.TextLength > 55 Then
            Dim cc As New Utils.CreditCard(txtCCNo.Text.Trim)
            txtCCNo.Text = cc.No
            txtCCName.Text = cc.Name
            cboMonth.Text = MonthName(cc.ExpiryMonth)
            cboYear.Text = cc.ExpiryYear
        End If
    End Sub

End Class
