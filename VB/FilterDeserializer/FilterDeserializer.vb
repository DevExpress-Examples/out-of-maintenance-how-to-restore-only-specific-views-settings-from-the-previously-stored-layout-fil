Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Serializing
Imports DevExpress.Utils.Serializing.Helpers
Imports System.IO

Namespace FilterDeserializer
	Public Class FilterDeserializer
		Inherits XmlXtraSerializer
		Private Shared instance_Renamed As FilterDeserializer = Nothing
		Public Shared ReadOnly Property Instance() As FilterDeserializer
			Get
				If instance_Renamed Is Nothing Then
					instance_Renamed = New FilterDeserializer()
				End If
				Return instance_Renamed
			End Get
		End Property
		Public Shared Sub LoadFilter(ByVal view As ColumnView, ByVal file As String)
			Dim collection As IXtraPropertyCollection = Instance.Deserialize(file, "View", Nothing)
			Instance.DeserializeObject(view, GetFilterCollection(view, collection), view.OptionsLayout)
		End Sub
		Private Shared Function GetFilterCollection(ByVal view As ColumnView, ByVal collection As IXtraPropertyCollection) As IXtraPropertyCollection
			Dim filterNames As String = "|ActiveFilterEnabled|ActiveFilterString|MRUFilters|"
			Dim ret As IXtraPropertyCollection
			Using ms As Stream = New MemoryStream()
				view.SaveLayoutToStream(ms, view.OptionsLayout)
				ms.Position = 0
				ret = Instance.Deserialize(ms, "View", Nothing)
				For Each pi As XtraPropertyInfo In collection
					If filterNames.Contains(String.Format("|{0}|", pi.Name)) Then
						ret.Add(pi)
					End If
				Next pi
			End Using
			Return ret
		End Function
	End Class
End Namespace
