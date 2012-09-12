Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmNewCustomer

#Region " Variable Declarations "

    Private saving As Boolean = False
    Private FORMTITLE As String = "New Customer"

    Private objDA As New DataAccessNut
    Private objCustAcc As New DACustAccountObject

    Public pkid As Integer

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
        ClearControls()
    End Sub

    Private Sub SetEventHanlder()

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "


#End Region

#Region " Database Updating - Presentation Layer "

    Private Sub InsertCustUser()
        Dim obj As New DACustUserObject

        Try
            obj.nameFirst = txtCustName.Text.Trim
            obj.mobilePhone = txtCustContact.Text.Trim
            obj.referenceNo = txtCustIC.Text.Trim
            obj.useridEdit = gUserObj.userid
            obj.lastupdate = Now
            obj.salesman = gUserObj.userid

            pkid = objDA.InsertCustUser(obj)
            If pkid <> 0 Then
                Messenger.ShowInformation("Customer '" & pkid & "' Created!")
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- ConfirmButtonClick"
            Messenger.ShowError("Create New Customer Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub
#End Region

#Region " Controls Populating, Updating, etc "


    Private Sub ClearControls()
        ClearFields(Me)
        btnConfirm.Enabled = False
    End Sub

    Private Sub ShowConfirmButton()
        btnConfirm.Enabled = txtCustName.Text.Trim.Length > 0 AndAlso txtCustContact.Text.Trim.Length > 0
    End Sub

#End Region

#Region " Utility Procedures "

#End Region

#Region " Event Handler/Response "

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If saving Then Exit Sub
        saving = True
        InsertCustUser()
        saving = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtCustName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustName.TextChanged, txtCustContact.TextChanged
        ShowConfirmButton()
    End Sub

#End Region


End Class
