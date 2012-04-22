Imports Utils
Imports Utils.General

Public Class frmFOCItem

#Region " Variable Declarations "

    Private FORMTITLE As String = "FOC Item"

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
       
        txtQty.Text = "1"
        txtRemarks.Text = "F.O.C"

        txtItem.Focus()
    End Sub

    Private Sub SetEventHanlder()
        AddHandler txtItem.KeyPress, AddressOf TextKeyPress
        AddHandler txtQty.KeyPress, AddressOf TextIntegerKeyPress
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

#End Region

#Region " Event Handler/Response "

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub picKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picKeyboard.Click
        gShowScreenKeyboard()
    End Sub

    Private Sub TextKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       
    End Sub

    Private Sub TextIntegerKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Utils.General.KeyPressInteger(sender, e)
    End Sub

#End Region


End Class
