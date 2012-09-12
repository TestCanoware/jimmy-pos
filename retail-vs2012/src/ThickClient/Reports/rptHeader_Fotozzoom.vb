Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptHeader_Fotozzoom

    Private Sub rptHeader_Fotozzoom_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        'txtBranchCode.Text = gBranchObj.code
        'txtAdd1.Text = gBranchObj.addr1
        'txtAdd2.Text = gBranchObj.addr2
        'txtAdd3.Text = gBranchObj.addr3
        'txtZip.Text = gBranchObj.zip
        'txtState.Text = gBranchObj.state
        txtBranchName.Text = gBranchObj.name & " (" & gBranchObj.code & ")"
        txtTel.Text = "Tel: " & gBranchObj.phoneNo

    End Sub

End Class
