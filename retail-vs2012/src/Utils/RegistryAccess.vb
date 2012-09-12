Imports Microsoft.Win32

''' <summary>
''' Summary description for clsRegistry.
''' </summary>
Public Class RegistryAccess
	Private Const SOFTWARE_KEY As String = "SOFTWARE"
    Private Const COMPANY_NAME As String = "WAVELET SOLUTION"
    Private Const APPLICATION_NAME As String = "THICK CLIENT"

	' Method for retrieving a Registry Value.
	Public Shared Function GetStringRegistryValue(key As String, defaultValue As String) As String
		Dim rkCompany As RegistryKey
		Dim rkApplication As RegistryKey

		rkCompany = Registry.CurrentUser.OpenSubKey(SOFTWARE_KEY, False).OpenSubKey(COMPANY_NAME, False)
		If rkCompany IsNot Nothing Then
			rkApplication = rkCompany.OpenSubKey(APPLICATION_NAME, True)
			If rkApplication IsNot Nothing Then
				For Each sKey As String In rkApplication.GetValueNames()
					If sKey = key Then
						Return DirectCast(rkApplication.GetValue(sKey), String)
					End If
				Next
			End If
		End If
		Return defaultValue
	End Function

	' Method for storing a Registry Value.
	Public Shared Sub SetStringRegistryValue(key As String, stringValue As String)
		Dim rkSoftware As RegistryKey
		Dim rkCompany As RegistryKey
		Dim rkApplication As RegistryKey

		rkSoftware = Registry.CurrentUser.OpenSubKey(SOFTWARE_KEY, True)
		rkCompany = rkSoftware.CreateSubKey(COMPANY_NAME)
		If rkCompany IsNot Nothing Then
			rkApplication = rkCompany.CreateSubKey(APPLICATION_NAME)
			If rkApplication IsNot Nothing Then
				rkApplication.SetValue(key, stringValue)
			End If
		End If
	End Sub
End Class
