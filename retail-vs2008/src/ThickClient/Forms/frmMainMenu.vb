Imports Utils
Imports Utils.General

Public Class frmMainMenu

#Region " Variable Declarations "

    Private FORMTITLE As String = My.Application.Info.Title

    Private MODULE_POS As String = "Point Of Sales"
    Private MODULE_JOBSHEET As String = "Create Jobsheet"
    Private MODULE_JOBSHEET_EDIT As String = "Edit Jobsheet"
    Private MODULE_DEPOSIT As String = "Deposit"
    Private MODULE_DEPOSIT_REFUND As String = "Deposit Refund"
    Private MODULE_REPORT As String = "Reports"
    Private MODULE_CONFIG As String = "Configuration"
    Private MODULE_ABOUT As String = "About"
    Private MODULE_EXIT As String = "Logout"

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
        Me.Text &= " " & My.Application.Info.Version.ToString(3)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        AssignValue(gGetLocale(Me.Name, "modPOS"), MODULE_POS)
        AssignValue(gGetLocale(Me.Name, "modJobsheet"), MODULE_JOBSHEET)
        AssignValue(gGetLocale(Me.Name, "modJobsheetEdit"), MODULE_JOBSHEET_EDIT)
        AssignValue(gGetLocale(Me.Name, "modDeposit"), MODULE_DEPOSIT)
        AssignValue(gGetLocale(Me.Name, "modDepositRefund"), MODULE_DEPOSIT_REFUND)
        AssignValue(gGetLocale(Me.Name, "modReport"), MODULE_REPORT)
        AssignValue(gGetLocale(Me.Name, "modConfig"), MODULE_CONFIG)
        AssignValue(gGetLocale(Me.Name, "modAbout"), MODULE_ABOUT)
        AssignValue(gGetLocale(Me.Name, "modExit"), MODULE_EXIT)

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
            .Items(3).Text = MODULE_DEPOSIT_REFUND
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

            Case MODULE_DEPOSIT_REFUND
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