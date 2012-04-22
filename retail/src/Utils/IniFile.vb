Imports System.IO
Imports System.Text.RegularExpressions

'INIFile class used to read and write ini files by loading the file into memory
Public Class INIFile
    'List of INISection objects keeps track of all the sections in the INI file
    Private m_sections As List(Of IniSection)

    'Public constructor
    Public Sub New()
        m_sections = New List(Of IniSection)
    End Sub

    'Returns an array of the INISections in the inifile
    Public ReadOnly Property sections() As IniSection()
        Get
            Return m_sections.ToArray()
        End Get
    End Property


    'Load INIFile object with existing INI Data
    Public Sub LoadINI(ByVal sFileName As String)
        RemoveAllSections() ' Clear the object... 
        Dim tempsection As IniSection = Nothing
        Dim oReader As New StreamReader(sFileName)
        'Old... "\[([^\[\s].*[^\s\]])\]"

        Dim regexsection As New Regex("^[\s]*?\[([^\[\s].*[^\s\]])\]", RegexOptions.Singleline Or RegexOptions.IgnoreCase)
        Dim regexkey As New Regex("^\s*([^=\s]*)[^=]*=\s*(.*\S|)", RegexOptions.Singleline Or RegexOptions.IgnoreCase)
        While Not oReader.EndOfStream
            Dim line As String = oReader.ReadLine()
            line = line.Trim()
            If line <> "" Then
                Dim m As Match = Nothing
                If regexsection.Match(line).Success Then
                    m = regexsection.Match(line)
                    'Trace.WriteLine(String.Format("Adding section [{0}]", m.Groups(1).Value.Trim()))
                    tempsection = AddSection(m.Groups(1).Value.Trim())
                ElseIf regexkey.Match(line).Success And Not tempsection Is Nothing Then
                    m = regexkey.Match(line)
                    'Trace.WriteLine(String.Format("Adding Key [{0}]=[{1}]", m.Groups(1).Value.Trim(), m.Groups(2).Value.Trim()))
                    tempsection.AddKey(m.Groups(1).Value.Trim()).value = m.Groups(2).Value.Trim()
                Else
                    'Trace.WriteLine(String.Format("Skipping unknown type of data: {0}", line))
                End If
            End If
        End While
        oReader.Close()
    End Sub

    'Allows you to do a save the INIFile resident in memory to file
    Public Sub SaveINI(ByVal sFileName As String)
        Dim oWriter As New StreamWriter(sFileName, False)
        Dim s As IniSection
        Dim k As IniFile.IniSection.IniKey
        For Each s In sections
            'Trace.WriteLine(String.Format("Writing Section: [{0}]", s.name))
            oWriter.WriteLine(String.Format("[{0}]", s.name))
            For Each k In s.keys
                'Trace.WriteLine(String.Format("Writing Key: {0}={1}", k.name, k.value))
                oWriter.WriteLine(String.Format("{0}={1}", k.name, k.value))
            Next
        Next
        oWriter.Close()
    End Sub

    'Returns the INISection object associated with a section name
    Public Function GetSection(ByVal sSection As String) As IniSection
        sSection = sSection.Trim 'Trim spaces
        If sSection.Length <> 0 Then
            For Each s As IniSection In m_sections
                If String.Compare(s.name, sSection, True) = 0 Then
                    Return s
                End If
            Next
        End If
        Return Nothing
    End Function

    ' Adds a section to the INIFile object, returns a IniSection object
    Public Function AddSection(ByVal sSection As String) As IniSection
        sSection = sSection.Trim()
        If sSection.Length <> 0 Then
            Dim s As IniSection = GetSection(sSection)
            If s Is Nothing Then
                s = New IniSection(Me)
                s.SetSectionName(sSection)
                m_sections.Add(s)
            End If
            Return s
        End If
        Return Nothing
    End Function

    ' Removes all existing sections (clears the object)
    Public Sub RemoveAllSections()
        m_sections.Clear()
    End Sub

    ' Removes all existing sections (same as RemoveAllSections just more obvious)
    Public Sub Empty()
        RemoveAllSections()
    End Sub

    'Removes a section based on an INISection, return true on success
    Public Function RemoveSection(ByVal Section As IniSection) As Boolean
        If Not Section Is Nothing Then Return m_sections.Remove(Section)
        Return False
    End Function

    'Removes a section based on the section name, return true on success
    Public Function RemoveSection(ByVal sSection As String) As Boolean
        Return RemoveSection(GetSection(sSection))
    End Function

    'INISECTION Class 
    Public Class INISection
        ' INIFile IniFile object instance
        Private m_IniFile As INIFile
        ' Name of the section
        Private m_sSectionName As String
        ' List of IniKeys in the section
        Private m_listKeys As List(Of IniKey)

        'Friend constuctor so objects are internally managed
        Friend Sub New(ByVal parent As INIFile)
            m_IniFile = parent
            m_listKeys = New List(Of IniKey)
        End Sub

        'Set the section name
        'Returns true on success, False if key already exists in the section
        Public Function SetSectionName(ByVal sSection As String) As Boolean
            sSection = sSection.Trim()
            If sSection.Length <> 0 Then
                Dim s As INISection = m_IniFile.GetSection(sSection)
                If Not s Is Me And Not s Is Nothing Then Return False
                m_sSectionName = sSection
                Return True
            End If
            Return False
        End Function

        'Returns and array of keys associated with the section
        Public ReadOnly Property keys() As IniKey()
            Get
                Return m_listKeys.ToArray()
            End Get
        End Property

        'Returns the section name
        Public ReadOnly Property name() As String
            Get
                Return m_sSectionName
            End Get
        End Property

        'Adds a key to the INISection object
        'Returns Nothing on failure
        Public Function AddKey(ByVal sKey As String) As IniKey
            sKey = sKey.Trim()
            If sKey.Length <> 0 Then
                Dim k As IniKey = GetKey(sKey)
                If k Is Nothing Then
                    k = New IniKey(Me)
                    k.SetKeyName(sKey)
                    m_listKeys.Add(k)
                End If
                Return k
            End If
            Return Nothing
        End Function

        'Returns a INIKey
        'Returns Nothing on failure 
        Public Function GetKey(ByVal sKey As String) As IniKey
            sKey = sKey.Trim()
            If sKey.Length <> 0 Then
                For Each k As INIKey In m_listKeys
                    If String.Compare(k.name, sKey, True) = 0 Then
                        Return k
                    End If
                Next
            End If
            Return Nothing
        End Function

        'Removes all the keys in the section
        Public Sub RemoveAllKeys()
            m_listKeys.Clear()
        End Sub

        'Removes a single key by INIKey object
        Public Function RemoveKey(ByVal Key As INIKey) As Boolean
            If Not Key Is Nothing Then m_listKeys.Remove(Key)
            Return False
        End Function

        ' Removes a single key by string
        Public Function RemoveKey(ByVal sKey As String) As Boolean
            Return m_listKeys.Remove(GetKey(sKey))
        End Function

        'INIKEY CLASS
        Public Class INIKey
            ' Name of the Key
            Private m_sKeyName As String
            ' Value associated
            Private m_sValue As String
            ' Pointer to the parent CIniSection
            Private m_Section As INISection

            'Friend constuctor so objects are internally managed
            Friend Sub New(ByVal parent As INISection)
                m_Section = parent
            End Sub

            'Returns the key's parent INISection
            Public ReadOnly Property parent() As INISection
                Get
                    Return m_Section
                End Get
            End Property

            'Returns the name of the Key
            Public ReadOnly Property name()
                Get
                    Return m_sKeyName
                End Get
            End Property

            'Gets\Sets the value associated with the Key
            Public Property value() As String
                Get
                    Return m_sValue
                End Get
                Set(ByVal value As String)
                    m_sValue = value.Trim()
                End Set
            End Property

            'Sets the key name
            'Returns true on success, fails if the section name sKeyName already exists
            Public Function SetKeyName(ByVal sKey As String) As Boolean
                sKey = sKey.Trim()
                If sKey.Length <> 0 Then
                    Dim s As INIKey = m_Section.GetKey(sKey)
                    If Not s Is Me And Not s Is Nothing Then Return False
                    m_sKeyName = sKey
                    Return True
                End If
                Return False
            End Function
        End Class
    End Class  ' End of IniSection
End Class