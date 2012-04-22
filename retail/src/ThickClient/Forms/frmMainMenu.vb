Imports Utils
Imports Utils.General

Public Class frmMainMenu

#Region " Variable Declarations "

    Private FORMTITLE As String = My.Application.Info.Title

    Private Const MODULE_POS = "Point Of Sales"
    Private Const MODULE_JOBSHEET = "Create Jobsheet"
    Private Const MODULE_JOBSHEET_EDIT = "Edit Jobsheet"
    Private Const MODULE_DEPOSIT = "Deposit"
    Private Const MODULE_PAYMENT_VOUCHER = "Deposit Refund"
    Private Const MODULE_REPORT = "Reports"
    Private Const MODULE_CONFIG = "Configuration"
    Private Const MODULE_ABOUT = "About"
    Private Const MODULE_EXIT = "Logout"

    Private running As Boolean = False

    Private objDA As New DataAccessNut

#End Region

#Region " Initialisation "

    'disables close
    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        Const CS_NOCLOSE As Integer = &H200
    '        cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
    '        Return cp
    '    End Get
    'End Property

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        General.DisableCloseButton(Me.Handle)
        Initialise()
    End Sub

    Private Sub Initialise()
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Me.Text &= " " & My.Application.Info.Version.ToString
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        General.CursorButtons(Me, Cursors.Hand)

        SetupDefaultControls()

        SetEventHanlder()
    End Sub

    Private Sub SetupDefaultControls()

        Load_lvwApplication()

        stReady.Text = "Ready"
        stUser.Text = gUserObj.username
        stTime.Text = General.GetNow

    End Sub

    Private Sub SetEventHanlder()

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

    Private Sub Load_lvwApplication()

        With lvwApplication
            .Items(0).Text = MODULE_POS
            .Items(1).Text = MODULE_JOBSHEET
            .Items(2).Text = MODULE_JOBSHEET_EDIT
            '.Items(3).Text = MODULE_DEPOSIT
            .Items(3).Text = MODULE_PAYMENT_VOUCHER
            '.Items(5).Text = MODULE_REPORT
            .Items(4).Text = MODULE_CONFIG
            .Items(5).Text = MODULE_ABOUT
            .Items(6).Text = MODULE_EXIT

            .Items(0).Selected = True
            .Focus()
        End With

    End Sub


#End Region

#Region " Database Updating - Presentation Layer "


#End Region

#Region " Controls Populating, Updating, etc "


    Private Sub ClearControls()

    End Sub


#End Region

#Region " Utility Procedures "

    Private Sub RunModule()
        If lvwApplication.SelectedItems.Count = 0 Then Exit Sub

        If running = True Then Exit Sub
        running = True

        Select Case lvwApplication.SelectedItems(0).Text
            Case MODULE_POS
                RunForm(New frmMainThickClient)

            Case MODULE_JOBSHEET
                RunForm(New frmJobsheet(frmJobsheet.FormMode.JOBSHEET))

            Case MODULE_JOBSHEET_EDIT
                RunForm(New frmJobsheet(frmJobsheet.FormMode.JOBSHEET_EDIT))

            Case MODULE_DEPOSIT
                RunForm(New frmDepositList)

            Case MODULE_PAYMENT_VOUCHER
                RunForm(New frmPaymentVoucher)

            Case MODULE_REPORT


            Case MODULE_CONFIG
                If Not gLoadPermission(Permission.Config) Then
                    running = False
                    Exit Sub
                End If
                RunForm(New frmConfig)

            Case MODULE_ABOUT
                RunForm(New frmAbout)

            Case MODULE_EXIT
                Messenger.Caption = Me.Text
                If Messenger.ShowQuestion(gMSG_LOGOUT, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    running = False
                    Exit Sub
                End If

                'Checking the current time
                If Not gCheckCurrentDateTime() Then Exit Sub

                PrintingFormat.PrintDailySalesReport(gUserObj.userid, gPosEndDayClosingObj.timeStart, Now, gSysConfig.PosId, "")

                objDA.UpdatePosLogin(gPosLoginObj)

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

        End Select

        running = False

    End Sub

    Private Sub RunForm(ByVal frm As Form)
        frm.ShowDialog()
    End Sub

#End Region

#Region " Event Handler/Response "

    Private Sub lvwApplication_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwApplication.DoubleClick
        RunModule()
    End Sub

    Private Sub lvwApplication_ItemMouseHover(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemMouseHoverEventArgs) Handles lvwApplication.ItemMouseHover
        stReady.Text = e.Item.Text
    End Sub

    Private Sub lvwApplication_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvwApplication.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            RunModule()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        stTime.Text = General.GetNow
    End Sub

#End Region

End Class