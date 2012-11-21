Public Class frmScreenKeyboard

    Private Sub frmScreenKeyboard_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        gStopScreenKeyboard()
    End Sub


    Private Sub frmScreenKeyboard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utils.General.CursorButtons(Me, Cursors.Hand)
    End Sub

#Region "API fonction"
    'Public Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As Long
    'this function gets active window identify number == (8975651603260375040)
    Public Declare Function SetActiveWindow Lib "user32" Alias "SetActiveWindow" _
    (ByVal hwnd As Long) As Long

    Declare Function keybd_event Lib "user32" Alias "keybd_event" _
    (ByVal bVk As Byte, ByVal bScan _
    As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long) As Long

    Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
    (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, _
    ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

#End Region

#Region "constraints"
    Const KEYEVENTF_KEYUP = &H2 ' Release key 
    Const VK_LBUTTON = &H1 'Left mouse button. 
    Const VK_RBUTTON = &H2 'Right mouse button. 
    Const VK_CANCEL = &H3 'Used for control-break processing. 
    Const VK_MBUTTON = &H4 '''Middle mouse button (3-button mouse). 
    Const VK_BACK = &H8
    Const VK_TAB = &H9
    Const VK_CLEAR = &HC
    Const VK_PRINT = &H2A
    Const VK_RETURN = &HD   'enter
    Const VK_SHIFT = &H10
    Const VK_CONTROL = &H11
    Const VK_SCROLL = &H91
    Const VK_MENU = &H12   'Alt (either one)
    Const VK_PAUSE = &H13
    Const VK_CAPITAL = &H14
    Const VK_ESCAPE = &H1B
    Const VK_STARTKEY = &H5B 'Start Menu key
    Const VK_SPACE = &H20
    Const VK_PRIOR = &H21 'Page up. 
    Const VK_NEXT = &H22 'Page down. 
    Const VK_END = &H23
    Const VK_HOME = &H24
    Const VK_LEFT = &H25
    Const VK_UP = &H26
    Const VK_RIGHT = &H27
    Const VK_DOWN = &H28
    Const VK_SELECT = &H29
    Const VK_INSERT = &H2D
    Const VK_DELETE = &H2E
    Const VK_HELP = &H2F
    Const VK_OEM_COMMA = &HBC     ',  comma
    Const VK_NUMLOCK = &H90 '      Num Lock
    Const KEYEVENTF_EXTENDEDKEY = &H1
    Const VK_0 = &H30
    Const VK_1 = &H31
    Const VK_2 = &H32
    Const VK_3 = &H33
    Const VK_4 = &H34
    Const VK_5 = &H35
    Const VK_6 = &H36
    Const VK_7 = &H37
    Const VK_8 = &H38
    Const VK_9 = &H39
    Const VK_A = &H41
    Const VK_B = &H42
    Const VK_C = &H43
    Const VK_D = &H44
    Const VK_E = &H45
    Const VK_F = &H46
    Const VK_G = &H47
    Const VK_H = &H48
    Const VK_I = &H49
    Const VK_J = &H4A
    Const VK_K = &H4B
    Const VK_L = &H4C
    Const VK_M = &H4D
    Const VK_N = &H4E
    Const VK_O = &H4F
    Const VK_P = &H50
    Const VK_Q = &H51
    Const VK_R = &H52
    Const VK_S = &H53
    Const VK_T = &H54
    Const VK_U = &H55
    Const VK_V = &H56
    Const VK_W = &H57
    Const VK_X = &H58
    Const VK_Y = &H59
    Const VK_Z = &H5A
    Const VK_NUMPAD0 = &H60
    Const VK_NUMPAD1 = &H61
    Const VK_NUMPAD2 = &H62
    Const VK_NUMPAD3 = &H63
    Const VK_NUMPAD4 = &H64
    Const VK_NUMPAD5 = &H65
    Const VK_NUMPAD6 = &H66
    Const VK_NUMPAD7 = &H67
    Const VK_NUMPAD8 = &H68
    Const VK_NUMPAD9 = &H69
    Const VK_MULTIPLY = &H6A    '     * (keypad)
    Const VK_ADD = &H6B
    Const VK_SEPARATER = &H6C
    Const VK_SEPARATOR = &H6C
    Const VK_SUBTRACT = &H6D
    Const VK_DECIMAL = &H6E
    Const VK_DIVIDE = &H6F
    Const VK_OEM_2 = &HBF  '      /
    Const VK_OEM_PERIOD = &HBE '.
    Const VK_F1 = &H70
    Const VK_F2 = &H71
    Const VK_F3 = &H72
    Const VK_F4 = &H73
    Const VK_F5 = &H74
    Const VK_F6 = &H75
    Const VK_F7 = &H76
    Const VK_F8 = &H77
    Const VK_F9 = &H78
    Const VK_F10 = &H79
    Const VK_F11 = &H7A
    Const VK_F12 = &H7B
    Const VK_F13 = &H7C
    Const VK_F14 = &H7D
    Const VK_F15 = &H7E
    Const VK_F16 = &H7F
    Const VK_F17 = &H80
    Const VK_F18 = &H81
    Const VK_F19 = &H82
    Const VK_F20 = &H83
    Const VK_F21 = &H84
    Const VK_F22 = &H85
    Const VK_F23 = &H86
    Const VK_F24 = &H87
    '****************
    Const VK_CRSEL = &HF7
    Const VK_EREOF = &HF9
    Const VK_EXECUTE = &H2B
    Const VK_EXSEL = &HF8
    Const VK_NONAME = &HFC
    Const VK_OEM_CLEAR = &HFE
    Const VK_PA1 = &HFD
    Const VK_PROCESSKEY = &HE5
    Const CAPSLOCK_ON = &H80    '  the capslock light is on.
    '****************
    Dim lockbool, numlockbool, ctrlbool As Boolean
    Dim onoff As Boolean
#End Region

#Region "which button pushed function"
    Public Function whichbuttonpushed(ByVal _sender As String) As String
        Try
            SetActiveWindow(8975651603260375040) 'Set focus Active window
            'I found this number("8975651603260375040") via getactivewindow method.
            Select Case _sender
                Case "btna"
                    keybd_event(VK_A, 0, 0, 0)
                    keybd_event(VK_A, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnb"
                    keybd_event(VK_B, 0, 0, 0)
                    keybd_event(VK_B, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnc"
                    keybd_event(VK_C, 0, 0, 0)
                    keybd_event(VK_C, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_c"
                    keybd_event(VK_C, 0, 0, 0)
                    keybd_event(VK_C, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnd"
                    keybd_event(VK_D, 0, 0, 0)
                    keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btne"
                    keybd_event(VK_E, 0, 0, 0)
                    keybd_event(VK_E, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf"
                    keybd_event(VK_F, 0, 0, 0)
                    keybd_event(VK_F, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btng"
                    keybd_event(VK_G, 0, 0, 0)
                    keybd_event(VK_G, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_g"
                    keybd_event(VK_G, 0, 0, 0)
                    keybd_event(VK_G, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnh"
                    keybd_event(VK_H, 0, 0, 0)
                    keybd_event(VK_H, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_i"
                    keybd_event(VK_I, 0, 0, 0)
                    keybd_event(VK_I, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btni"
                    keybd_event(VK_I, 0, 0, 0)
                    keybd_event(VK_I, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnj"
                    keybd_event(VK_J, 0, 0, 0)
                    keybd_event(VK_J, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnk"
                    keybd_event(VK_K, 0, 0, 0)
                    keybd_event(VK_K, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnl"
                    keybd_event(VK_L, 0, 0, 0)
                    keybd_event(VK_L, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnm"
                    keybd_event(VK_M, 0, 0, 0)
                    keybd_event(VK_M, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnn"
                    keybd_event(VK_N, 0, 0, 0)
                    keybd_event(VK_N, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btno"
                    keybd_event(VK_O, 0, 0, 0)
                    keybd_event(VK_O, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_o"
                    keybd_event(VK_O, 0, 0, 0)
                    keybd_event(VK_O, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnp"
                    keybd_event(VK_P, 0, 0, 0)
                    keybd_event(VK_P, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnr"
                    keybd_event(VK_R, 0, 0, 0)
                    keybd_event(VK_R, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btns"
                    keybd_event(VK_S, 0, 0, 0)
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_s"
                    keybd_event(VK_S, 0, 0, 0)
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnt"
                    keybd_event(VK_T, 0, 0, 0)
                    keybd_event(VK_T, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnu"
                    keybd_event(VK_U, 0, 0, 0)
                    keybd_event(VK_U, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn_u"
                    keybd_event(VK_U, 0, 0, 0)
                    keybd_event(VK_U, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnv"
                    keybd_event(VK_V, 0, 0, 0)
                    keybd_event(VK_V, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btny"
                    keybd_event(VK_Y, 0, 0, 0)
                    keybd_event(VK_Y, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnz"
                    keybd_event(VK_Z, 0, 0, 0)
                    keybd_event(VK_Z, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnw"
                    keybd_event(VK_W, 0, 0, 0)
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnq"
                    keybd_event(VK_Q, 0, 0, 0)
                    keybd_event(VK_Q, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnx"
                    keybd_event(VK_X, 0, 0, 0)
                    keybd_event(VK_X, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                    '***************************************************************************************
                Case "btnnokta" '"."
                    keybd_event(VK_OEM_PERIOD, 0, 0, 0)
                    keybd_event(VK_OEM_PERIOD, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnesc"
                    keybd_event(VK_ESCAPE, 0, 0, 0)
                    keybd_event(VK_ESCAPE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf1"
                    keybd_event(VK_F1, 0, 0, 0)
                    keybd_event(VK_F1, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf2"
                    keybd_event(VK_F2, 0, 0, 0)
                    keybd_event(VK_F2, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf3"
                    keybd_event(VK_F3, 0, 0, 0)
                    keybd_event(VK_F3, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf4"
                    keybd_event(VK_F4, 0, 0, 0)
                    keybd_event(VK_F4, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf5"
                    keybd_event(VK_F5, 0, 0, 0)
                    keybd_event(VK_F5, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf6"
                    keybd_event(VK_F6, 0, 0, 0)
                    keybd_event(VK_F6, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf7"
                    keybd_event(VK_F7, 0, 0, 0)
                    keybd_event(VK_F7, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf8"
                    keybd_event(VK_F8, 0, 0, 0)
                    keybd_event(VK_F8, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf9"
                    keybd_event(VK_F9, 0, 0, 0)
                    keybd_event(VK_F9, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf10"
                    keybd_event(VK_F10, 0, 0, 0)
                    keybd_event(VK_F10, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf11"
                    keybd_event(VK_F11, 0, 0, 0)
                    keybd_event(VK_F11, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnf12"
                    keybd_event(VK_F12, 0, 0, 0)
                    keybd_event(VK_F12, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnpsc"  'print
                    keybd_event(VK_PRINT, 0, 0, 0)
                    keybd_event(VK_PRINT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnslk"  'scroll
                    keybd_event(VK_SCROLL, &H45S, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    keybd_event(VK_SCROLL, &H45S, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnbrk"  'pause
                    keybd_event(VK_PAUSE, 0, 0, 0)
                    keybd_event(VK_PAUSE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btncifttirnak"  '  "
                    'I used this(') mark two times. 
                    keybd_event(VK_SHIFT, 0, 0, 0)
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btntab"  'tab
                    keybd_event(VK_TAB, 0, 0, 0)
                    keybd_event(VK_TAB, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnlock"    'capslock
                    lockbool = Not lockbool
                    keybd_event(VK_CAPITAL, &H45S, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    keybd_event(VK_CAPITAL, &H45S, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
                    If lockbool = True Then
                        'btnlock.BackColor = Color.White
                    Else
                        'btnlock.BackColor = Color.FromArgb(224, 224, 224)
                    End If
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsolshift"   'left shift
                    keybd_event(VK_SHIFT, 0, 0, 0)
                    'btnsolshift.BackColor = Color.White
                    'btnsagshift.BackColor = Color.White
                    altrelease()
                    leftaltrelease()
                Case "btnsolctrl"  'left ctrl
                    ctrlbool = Not ctrlbool
                    If ctrlbool = True Then
                        keybd_event(VK_CONTROL, 0, 0, 0)
                        'btnsolctrl.BackColor = Color.White
                        'btnsagctrl.BackColor = Color.White
                    Else
                        keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0)
                        'btnsolctrl.BackColor = Color.FromArgb(224, 224, 224)
                        'btnsagctrl.BackColor = Color.FromArgb(224, 224, 224)
                    End If
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsolwindows"    'left start key
                    keybd_event(VK_STARTKEY, 0, 0, 0)
                    keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsolalt"   'left alt
                    keybd_event(VK_MENU, 0, 0, 0)
                    'btnsolalt.BackColor = Color.White
                    shiftrelease()
                    altrelease()
                Case "btnspace"   'space
                    keybd_event(VK_SPACE, 0, 0, 0)
                    keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsagaltgr"   'right altgr
                    keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    'btnsagaltgr.BackColor = Color.White
                    shiftrelease()
                    leftaltrelease()
                Case "btnsagwindows"   'right start key
                    keybd_event(VK_STARTKEY, 0, 0, 0)
                    keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsagtus"
                    keybd_event(VK_RBUTTON, 0, 0, 0)
                    keybd_event(VK_RBUTTON, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsagctrl"   'right ctrl
                    ctrlbool = Not ctrlbool
                    If ctrlbool = True Then
                        keybd_event(VK_CONTROL, 0, 0, 0)
                        'btnsolctrl.BackColor = Color.White
                        'btnsagctrl.BackColor = Color.White
                    Else
                        keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0)
                        'btnsolctrl.BackColor = Color.FromArgb(224, 224, 224)
                        'btnsagctrl.BackColor = Color.FromArgb(224, 224, 224)
                    End If
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsagshift"    'right shift 
                    keybd_event(VK_SHIFT, 0, 0, 0)
                    'btnsolshift.BackColor = Color.White
                    'btnsagshift.BackColor = Color.White
                    altrelease()
                    leftaltrelease()
                Case "btnenter"   'enter
                    keybd_event(VK_RETURN, 0, 0, 0)
                    keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnvirgul"    'comma
                    keybd_event(VK_OEM_COMMA, 0, 0, 0)
                    keybd_event(VK_OEM_COMMA, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnbackspace"   'back space
                    keybd_event(VK_BACK, 0, 0, 0)
                    keybd_event(VK_BACK, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                    '///////////////////////////////////////////////
                Case "btnins"    'insert
                    keybd_event(VK_INSERT, 0, 0, 0)
                    keybd_event(VK_INSERT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnhm"    'home
                    keybd_event(VK_HOME, 0, 0, 0)
                    keybd_event(VK_HOME, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnpup"   'page up
                    keybd_event(VK_PRIOR, 0, 0, 0)
                    keybd_event(VK_PRIOR, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btndel"    'delete
                    keybd_event(VK_DELETE, 0, 0, 0)
                    keybd_event(VK_DELETE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnend"   'end
                    keybd_event(VK_END, 0, 0, 0)
                    keybd_event(VK_END, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnpdn"    'page down
                    keybd_event(VK_NEXT, 0, 0, 0)
                    keybd_event(VK_NEXT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnyukari"   'up
                    keybd_event(VK_UP, 0, 0, 0)
                    keybd_event(VK_UP, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnasagi"   'down
                    keybd_event(VK_DOWN, 0, 0, 0)
                    keybd_event(VK_DOWN, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsol"  'left
                    keybd_event(VK_LEFT, 0, 0, 0)
                    keybd_event(VK_LEFT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnsag"   'right
                    keybd_event(VK_RIGHT, 0, 0, 0)
                    keybd_event(VK_RIGHT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                    '//////////////////////////////////////////////////////////////////////////////////
                Case "btnnumlock"    'numlock
                    numlockbool = Not numlockbool
                    keybd_event(VK_NUMLOCK, &H45S, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    keybd_event(VK_NUMLOCK, &H45S, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
                    If numlockbool = True Then
                        'btnnumlock.BackColor = Color.FromArgb(224, 224, 224)
                    Else
                        'btnnumlock.BackColor = Color.White
                    End If
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockbolu"    '   /
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockcarpi"    '   *
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockeksi"    '   -
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockarti"    '   +
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlockenter"    ' right enter
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlocknokta"   '  .
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock0"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock1"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock2"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock3"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock4"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock5"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock6"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock7"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock8"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btnnumlock9"
                    numlockfunc(_sender, numlockbool)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                    '/////////////////////////////////////////////////////////////////////////////////
                Case "btn0"
                    keybd_event(VK_0, 0, 0, 0)
                    keybd_event(VK_0, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn00"
                    keybd_event(VK_0, 0, 0, 0)
                    keybd_event(VK_0, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_0, 0, 0, 0)
                    keybd_event(VK_0, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn1"
                    keybd_event(VK_1, 0, 0, 0)
                    keybd_event(VK_1, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn2"
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn3"
                    keybd_event(VK_3, 0, 0, 0)
                    keybd_event(VK_3, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn4"
                    keybd_event(VK_4, 0, 0, 0)
                    keybd_event(VK_4, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn5"
                    keybd_event(VK_5, 0, 0, 0)
                    keybd_event(VK_5, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn6"
                    keybd_event(VK_6, 0, 0, 0)
                    keybd_event(VK_6, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn7"
                    keybd_event(VK_7, 0, 0, 0)
                    keybd_event(VK_7, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn8"
                    keybd_event(VK_8, 0, 0, 0)
                    keybd_event(VK_8, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btn9"
                    keybd_event(VK_9, 0, 0, 0)
                    keybd_event(VK_9, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btncarpi"    '    *
                    keybd_event(VK_MULTIPLY, 0, 0, 0)
                    keybd_event(VK_MULTIPLY, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
                Case "btneksi"     '    -
                    keybd_event(VK_SUBTRACT, 0, 0, 0)
                    keybd_event(VK_SUBTRACT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    altrelease()
                    leftaltrelease()
            End Select
            Exit Function
        Catch ex As Exception
            Exit Function
        End Try
    End Function
#End Region

#Region "numlock function "
    Public Function numlockfunc(ByVal numlock_tus As String, ByVal open_close As Boolean) As String
        Try
            If open_close = False Then    'numlock opened
                Select Case numlock_tus
                    Case "btnnumlockbolu"
                        keybd_event(VK_DIVIDE, 0, 0, 0)
                        keybd_event(VK_DIVIDE, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockcarpi"
                        keybd_event(VK_MULTIPLY, 0, 0, 0)
                        keybd_event(VK_MULTIPLY, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockeksi"
                        keybd_event(VK_SUBTRACT, 0, 0, 0)
                        keybd_event(VK_SUBTRACT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockarti"
                        keybd_event(VK_ADD, 0, 0, 0)
                        keybd_event(VK_ADD, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockenter"
                        keybd_event(VK_RETURN, 0, 0, 0)
                        keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlocknokta"
                        keybd_event(VK_DECIMAL, 0, 0, 0)
                        keybd_event(VK_DECIMAL, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock0"
                        keybd_event(VK_NUMPAD0, 0, 0, 0)
                        keybd_event(VK_NUMPAD0, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock1"
                        keybd_event(VK_NUMPAD1, 0, 0, 0)
                        keybd_event(VK_NUMPAD1, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock2"
                        keybd_event(VK_NUMPAD2, 0, 0, 0)
                        keybd_event(VK_NUMPAD2, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock3"
                        keybd_event(VK_NUMPAD3, 0, 0, 0)
                        keybd_event(VK_NUMPAD3, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock4"
                        keybd_event(VK_NUMPAD4, 0, 0, 0)
                        keybd_event(VK_NUMPAD4, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock5"
                        keybd_event(VK_NUMPAD5, 0, 0, 0)
                        keybd_event(VK_NUMPAD5, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock6"
                        keybd_event(VK_NUMPAD6, 0, 0, 0)
                        keybd_event(VK_NUMPAD6, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock7"
                        keybd_event(VK_NUMPAD7, 0, 0, 0)
                        keybd_event(VK_NUMPAD7, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock8"
                        keybd_event(VK_NUMPAD8, 0, 0, 0)
                        keybd_event(VK_NUMPAD8, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock9"
                        keybd_event(VK_NUMPAD9, 0, 0, 0)
                        keybd_event(VK_NUMPAD9, 0, KEYEVENTF_KEYUP, 0)
                End Select
            Else                                'numlock closed
                Select Case numlock_tus
                    Case "btnnumlockbolu"
                        keybd_event(VK_DIVIDE, 0, 0, 0)
                        keybd_event(VK_DIVIDE, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockcarpi"
                        keybd_event(VK_MULTIPLY, 0, 0, 0)
                        keybd_event(VK_MULTIPLY, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockeksi"
                        keybd_event(VK_SUBTRACT, 0, 0, 0)
                        keybd_event(VK_SUBTRACT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockarti"
                        keybd_event(VK_ADD, 0, 0, 0)
                        keybd_event(VK_ADD, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlockenter"
                        keybd_event(VK_RETURN, 0, 0, 0)
                        keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlocknokta"
                        keybd_event(VK_DELETE, 0, 0, 0)
                        keybd_event(VK_DELETE, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock0"
                        keybd_event(VK_INSERT, 0, 0, 0)
                        keybd_event(VK_INSERT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock1"
                        keybd_event(VK_END, 0, 0, 0)
                        keybd_event(VK_END, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock2"
                        keybd_event(VK_DOWN, 0, 0, 0)
                        keybd_event(VK_DOWN, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock3"
                        keybd_event(VK_NEXT, 0, 0, 0)
                        keybd_event(VK_NEXT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock4"
                        keybd_event(VK_LEFT, 0, 0, 0)
                        keybd_event(VK_LEFT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock5"
                    Case "btnnumlock6"
                        keybd_event(VK_RIGHT, 0, 0, 0)
                        keybd_event(VK_RIGHT, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock7"
                        keybd_event(VK_HOME, 0, 0, 0)
                        keybd_event(VK_HOME, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock8"
                        keybd_event(VK_UP, 0, 0, 0)
                        keybd_event(VK_UP, 0, KEYEVENTF_KEYUP, 0)
                    Case "btnnumlock9"
                        keybd_event(VK_PRIOR, 0, 0, 0)
                        keybd_event(VK_PRIOR, 0, KEYEVENTF_KEYUP, 0)
                End Select
            End If
        Catch ex As Exception
            Exit Function
        End Try
    End Function
#End Region

#Region "buttons click"
    Private Sub btnesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click, btn00.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnBackspace.Click, btneksi.Click, btnEnter.Click, btnnokta.Click
        Try
            Dim key As Button = CType(sender, Button)
            whichbuttonpushed(key.Name.ToLower)
            SetActiveWindow(8975651603260375040) 'This Line Very Impportant
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        Finally
            SetActiveWindow(8975651603260375040)
        End Try
    End Sub
#End Region

#Region "shift ,altgr and alt release sub"
    Sub shiftrelease()
        'btnsolshift.BackColor = Color.FromArgb(224, 224, 224)
        'btnsagshift.BackColor = Color.FromArgb(224, 224, 224)
        keybd_event(VK_SHIFT, 0, 2, 0)
    End Sub
    Sub altrelease()
        keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY Or 2, 0)
        'btnsagaltgr.BackColor = Color.FromArgb(224, 224, 224)
    End Sub
    Sub leftaltrelease()
        keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0)
        'btnsolalt.BackColor = Color.FromArgb(224, 224, 224)
    End Sub
#End Region

#Region "form1 finalize Overrides"
    Protected Overrides Sub Finalize()
        Try
            'release shift,alt and leftalt
            shiftrelease()
            altrelease()
            leftaltrelease()
            keybd_event(VK_CANCEL, 0, 0, 0)
            Timer1.Enabled = False
            Me.Dispose()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "toolbar button click"
    'Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
    '    Try
    '        Select Case e.Button.Tag
    '            Case "button1"
    '                process.Start("wordpad")
    '            Case "button2"
    '                process.Start("notepad")
    '            Case "button3"
    '                openwinamp()
    '            Case "button4"
    '                process.Start("outlook")
    '            Case "button5"
    '                process.Start("iexplore")
    '            Case "button6"
    '                screenshot()
    '            Case "button7"
    '                process.Start("taskmgr")
    '            Case "button8"
    '                formtopmost()
    '            Case "button9"
    '                cdromopenclose()
    '            Case "button10"
    '                'messengerstart()
    '            Case "button11"
    '                process.Start("calc")
    '            Case "button12"
    '                process.Start("explorer")
    '            Case "button13"    'press startket + (R)
    '                keybd_event(VK_STARTKEY, 0, 0, 0)
    '                keybd_event(VK_R, 0, 0, 0)
    '                keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
    '                keybd_event(VK_R, 0, KEYEVENTF_KEYUP, 0)
    '            Case "button14"  'press startket + (F)
    '                keybd_event(VK_STARTKEY, 0, 0, 0)
    '                keybd_event(VK_F, 0, 0, 0)
    '                keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
    '                keybd_event(VK_F, 0, KEYEVENTF_KEYUP, 0)
    '            Case "button15"    'press startket + (M)
    '                keybd_event(VK_STARTKEY, 0, 0, 0)
    '                keybd_event(VK_M, 0, 0, 0)
    '                keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
    '                keybd_event(VK_M, 0, KEYEVENTF_KEYUP, 0)
    '            Case "button16"   'wmp
    '                process.Start("wmplayer")
    '            Case "button17"   'open your hotmail inbox
    '                'Dim msg As New Messenger
    '                'msg.OpenInbox()
    '            Case "button18"   'information form
    '                'Dim iform As New info
    '                'iform.ShowDialog()
    '            Case "button19"  'help form
    '                'Dim hform As New help
    '                'hform.Show()
    '            Case "button20"   'system tray icon 
    '                nodi.Visible = True
    '                Me.Hide()
    '        End Select
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub
#End Region

#Region "open winamp"
    Public Sub openwinamp()
        Try
            'If File.Exists("C:\Program Files\Winamp\winamp.exe") Then
            '    process.Start("C:\Program Files\Winamp\winamp.exe")
            'Else
            '    MsgBox("This button open winamp,but you must download winamp.")
            'End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "screenshot()"
    Sub screenshot()
        Try
            Call keybd_event(System.Windows.Forms.Keys.Snapshot, 0, 0, 0)
            System.Threading.Thread.Sleep(200) ' To have time to catch the clipboard
            Static i As Integer
            Dim data As IDataObject
            data = Nothing
            data = Clipboard.GetDataObject()
            Dim bmap As Bitmap
            Dim p As New PictureBox
            If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
                p.Image = bmap
                i += 1
                p.Image.Save("C:\Documents and Settings\All Users\Desktop\Screenshot " & i.ToString & " .jpg", Imaging.ImageFormat.Jpeg)
            End If

            'If Not File.Exists("C:\Documents and Settings\All Users\Desktop\Screenshot " & i.ToString & " .jpg") Then
            '    screenshot()
            'Else
            'End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "cdrom open/close"
    Sub cdromopenclose()
        Try
            onoff = Not onoff
            If onoff Then
                mciSendString("set cdAudio door open", 0&, 0, 0)
            Else
                mciSendString("set cdAudio door Closed", 0&, 0, 0)
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "form1 load"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        nodi.Visible = False
    End Sub
#End Region

#Region "timer 1 ve 2 tick"
    Dim processes() As Process
    Dim process As New Process
    Dim processstring As String
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim mycoll As New Collection
            processes = process.GetProcesses
            For Each process In processes
                mycoll.Add(process, process.Id.ToString)
                If process.ProcessName = "winamp" Then
                    processstring = process.MainWindowTitle
                    'gets song name from winamp window's title(MainWindowTitle)
                    Exit For
                End If
            Next
            'Me.Text = "MY SCREEN KEYBOARD" & Space(55) & DateTime.Now & Space(20) & processstring
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Dim whichstate As Integer = 1
    Dim store As String
    'Dim m As New MessengerAPI.MessengerClass
    'Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
    '    Try
    '        store &= " < " & m.UnreadEmailCount(MUAFOLDER.MUAFOLDER_INBOX) & " okunmamýs e-mail." & " > "
    '        Dim cnts As IMessengerContacts
    '        Dim cnt As IMessengerContact
    '        cnts = m.MyContacts
    '        For Each cnt In cnts
    '            Select Case cnt.Status
    '                Case MISTATUS.MISTATUS_AWAY
    '                    store &= " < " & cnt.FriendlyName & " / " & "Away" & " > "
    '                Case MISTATUS.MISTATUS_BE_RIGHT_BACK
    '                    store &= " < " & cnt.FriendlyName & " / " & "Be right back" & " > "
    '                Case MISTATUS.MISTATUS_BUSY
    '                    store &= " < " & cnt.FriendlyName & " / " & "Busy" & " > "
    '                Case MISTATUS.MISTATUS_OFFLINE
    '                    store &= " < " & cnt.FriendlyName & " / " & "Offline" & " > "
    '                Case MISTATUS.MISTATUS_ON_THE_PHONE
    '                    store &= " < " & cnt.FriendlyName & " / " & "On The Phone" & " > "
    '                Case MISTATUS.MISTATUS_ONLINE
    '                    store &= " < " & cnt.FriendlyName & " / " & "Online" & " > "
    '                Case MISTATUS.MISTATUS_OUT_TO_LUNCH
    '                    store &= " < " & cnt.FriendlyName & " / " & "Out to lunch" & " > "
    '            End Select
    '        Next
    '        txtbilgi.Text = Mid(store, whichstate, 25)  'scroll the text
    '        whichstate += 1
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub
#End Region

#Region "messenger start sub"
    'Public Sub messengerstart()
    '    Try
    '        Dim m As New MessengerAPI.MessengerClass
    '        Dim l As Long = Nothing
    '        If m.MyStatus = MISTATUS.MISTATUS_OFFLINE Then
    '            m.Signin(l, "", "")
    '            Timer2.Enabled = True
    '        Else
    '            If MessageBox.Show("Allready opened session on computer.." & vbCrLf & "Do you want to close this session and then open new session?", "Screen Keyboard Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                While m.MyStatus <> MISTATUS.MISTATUS_OFFLINE
    '                    m.Signout()
    '                End While
    '                messengerstart()
    '            Else
    '                Exit Try
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub
#End Region

#Region "nodi double click"
    Private Sub nodi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles nodi.DoubleClick
        Me.Show()
        nodi.Visible = False
        nodi.Text = "Screen Keyboard still runing here!"
    End Sub
#End Region

#Region "form1 top most property"
    Public Sub formtopmost()
        'If ToolBar1.Buttons.Item(14).Pushed = True Then
        '    Me.TopMost = False
        'Else
        '    Me.TopMost = True
        'End If
    End Sub
#End Region
End Class