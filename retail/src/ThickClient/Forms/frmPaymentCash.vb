Imports Utils
Imports Utils.General

Public Class frmPaymentCash

#Region " Variable Declarations "

    Private FORMTITLE As String = "Payment Cash"

    Public total As Decimal
    Public change As Decimal

    Public Enum FormMode
        MAIN
        DEPOSIT
    End Enum

    Public frmMode As FormMode

#End Region

#Region " Initialisation "

    Private Sub frmPaymentCash_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
    End Sub

    Private Sub SetupDefaultControls()
        ClearFields(Me)
        LockFields(txtTotal, True)
        LockFields(txtChange, True)

        txtTender.Focus()
        
        txtTotal.Text = FormatCurrency(total)
        txtTender.Text = FormatCurrency(total)
        change = total - Convert.ToDecimal(txtTender.Text)
        txtChange.Text = FormatCurrency(change)

        lblTotalCcy.Text = gBranchObj.currency
        lblTenderCcy.Text = gBranchObj.currency
        lblChangeCcy.Text = gBranchObj.currency

        btnConfirm.Enabled = change <= 0

    End Sub

    Private Sub SetEventHanlder()

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

   
#End Region

#Region " Database Updating - Presentation Layer "


#End Region

#Region " Controls Populating, Updating, etc "


    Private Sub ClearControls()

    End Sub


#End Region

#Region " Utility Procedures "

    Public Function isMain() As Boolean
        Return frmMode = FormMode.Main
    End Function

#End Region

#Region " Event Handler/Response "

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If isMain() Then
            If Not gShowMsgTxnConfirm() Then Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = KeyPressDecimal(sender, e)
    End Sub

    Private Sub txtTender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTender.KeyPress
        e.Handled = KeyPressDecimal(sender, e)
    End Sub

    Private Sub txtTender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTender.TextChanged

        Try
            Dim value As Decimal = 0
            change = total - Convert.ToDecimal(txtTender.Text)
            If change <= 0 Then
                value = Decimal.Negate(change)
                txtChange.Text = FormatCurrency(value)
            End If

        Catch ex As Exception
            txtChange.Text = FormatCurrency(Decimal.Negate(total))
        End Try

        btnConfirm.Enabled = change <= 0
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picKeyboard.Click
        gShowScreenKeyboard()
    End Sub

#End Region


End Class
