﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17929
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class _Global
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("JimmyPos.Global", GetType(_Global).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Auto Synchronize exist!.
        '''</summary>
        Friend Shared ReadOnly Property msg_auto_sync() As String
            Get
                Return ResourceManager.GetString("msg_auto_sync", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please check the current date and time!.
        '''</summary>
        Friend Shared ReadOnly Property msg_check_current_date() As String
            Get
                Return ResourceManager.GetString("msg_check_current_date", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please enter the remarks!.
        '''</summary>
        Friend Shared ReadOnly Property msg_enter_remakrs() As String
            Get
                Return ResourceManager.GetString("msg_enter_remakrs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The exchanged item&apos;s price needs to be equal or less than of this transaction&apos;s.
        '''</summary>
        Friend Shared ReadOnly Property msg_exchange_item() As String
            Get
                Return ResourceManager.GetString("msg_exchange_item", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Export successfully!.
        '''</summary>
        Friend Shared ReadOnly Property msg_export_successfully() As String
            Get
                Return ResourceManager.GetString("msg_export_successfully", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Held items detected!.
        '''</summary>
        Friend Shared ReadOnly Property msg_held_items_detected() As String
            Get
                Return ResourceManager.GetString("msg_held_items_detected", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Import successfully!.
        '''</summary>
        Friend Shared ReadOnly Property msg_import_successfully() As String
            Get
                Return ResourceManager.GetString("msg_import_successfully", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Item not found or below qty!.
        '''</summary>
        Friend Shared ReadOnly Property msg_item_not_found() As String
            Get
                Return ResourceManager.GetString("msg_item_not_found", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You could not be authenticated!.
        '''</summary>
        Friend Shared ReadOnly Property msg_login_not_succed() As String
            Get
                Return ResourceManager.GetString("msg_login_not_succed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure to Logout the system?.
        '''</summary>
        Friend Shared ReadOnly Property msg_logout() As String
            Get
                Return ResourceManager.GetString("msg_logout", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to All transactions has been exported, there&apos;s no more transactions pending export!.
        '''</summary>
        Friend Shared ReadOnly Property msg_no_export_transaction() As String
            Get
                Return ResourceManager.GetString("msg_no_export_transaction", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Do you want to refund?.
        '''</summary>
        Friend Shared ReadOnly Property msg_refund() As String
            Get
                Return ResourceManager.GetString("msg_refund", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure to remove selected records?.
        '''</summary>
        Friend Shared ReadOnly Property msg_remove_deposit() As String
            Get
                Return ResourceManager.GetString("msg_remove_deposit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Transaction exist!.
        '''</summary>
        Friend Shared ReadOnly Property msg_transaction_exist() As String
            Get
                Return ResourceManager.GetString("msg_transaction_exist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No Transaction exist!.
        '''</summary>
        Friend Shared ReadOnly Property msg_transaction_not_exist() As String
            Get
                Return ResourceManager.GetString("msg_transaction_not_exist", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
