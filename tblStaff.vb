'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblStaff
    Public Property staffid As Integer
    Public Property firstname As String
    Public Property lastname As String
    Public Property staffclassification As Nullable(Of Integer)
    Public Property base_rate As Nullable(Of Decimal)
    Public Property branch As Nullable(Of Integer)
    Public Property active As Nullable(Of Boolean)

    Public Overridable Property tblStaffClassification As tblStaffClassification
    Public Overridable Property tblStaffRates As ICollection(Of tblStaffRate) = New HashSet(Of tblStaffRate)

End Class
