Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptHeader

    Private Sub rptHeader_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        'Picture1.Image = Nothing
        'gLoadPicture(gAppConfig.Logo, Picture1)

        txtRegNo.Text = ""
        txtBranchName.Text = gBranchObj.name
        txtAdd1.Text = gBranchObj.addr1
        txtAdd2.Text = gBranchObj.addr2

        If gBranchObj.addr3 <> "" Then
            txtAdd2.Text &= " " & gBranchObj.addr3
        End If
        If gBranchObj.state <> "" Then
            txtAdd2.Text &= " " & gBranchObj.state
        End If
        If gBranchObj.zip <> "" Then
            txtAdd2.Text &= " " & gBranchObj.zip
        End If
        If gBranchObj.taxRegNumber <> "" Then
            txtRegNo.Text = "GST Reg No.: " & gBranchObj.taxRegNumber
        End If

        txtTel.Text = "Tel:" & gBranchObj.phoneNo
    End Sub
End Class
