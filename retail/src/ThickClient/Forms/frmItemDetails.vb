Imports Utils.General
Imports Utils
Imports DataAccess

Public Class frmItemDetails

#Region " Variable Declarations "

    Private FORMTITLE As String = "Item Details"
    Private objDA As New DataAccessNut
    Public objDocRow As DocRow

#End Region

#Region " Initialisation "

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
        LockFields(txtItemCode, True)
        LockFields(txtTaxType, True)
        Load_cboTaxCode()

        txtItemCode.Text = objDocRow.itemCode
        txtName.Text = objDocRow.itemName
        txtRemarks.Text = objDocRow.remarks
        cboTaxCode.Text = objDocRow.taxCode
        txtTaxType.Text = objDocRow.taxType
        txtTaxRate.Text = FormatCurrency(objDocRow.taxRate * 100)

        If Not objDocRow.taxEnabled Then
            LockFields(cboTaxCode, True)
            LockFields(txtTaxRate, True)
        End If

    End Sub

    Private Sub SetEventHanlder()

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

    Private Sub Load_cboTaxCode()

        Dim ds As DataSet

        Try
            ds = objDA.GetAllTaxConfig
            PopulateComboBoxWithDataset(ds, DATaxConfig.TAX_CODE, DATaxConfig.PKID, cboTaxCode)

            cboTaxCode.SelectedValue = gUserObj.userid

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "-" & "Load_cboTaxCode"
            Messenger.ShowError("Load Tax Code Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

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

    Private Sub cboTaxCode_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTaxCode.SelectionChangeCommitted
        Dim obj As New DATaxConfigObject
        obj = objDA.GetTaxConfig(cboTaxCode.SelectedValue)

        txtTaxType.Text = obj.taxType
        txtTaxRate.Text = FormatCurrency(obj.taxRate * 100)
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtTaxRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTaxRate.KeyPress
        e.Handled = General.KeyPressDecimal(sender, e)
    End Sub

#End Region


End Class