﻿Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.DashboardWin
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace CustomizeDashboardItemCaption_Viewer_Example
	Partial Public Class ViewerForm1
		Inherits DevExpress.XtraEditors.XtraForm

		Private Shared allowExport As Boolean = False

		Public Sub New()
			InitializeComponent()
			dashboardViewer.AllowPrintDashboardItems = True

			AddHandler dashboardViewer.CustomizeDashboardTitle, AddressOf DashboardViewer_CustomizeDashboardTitle
			AddHandler dashboardViewer.CustomizeDashboardItemCaption, AddressOf DashboardViewer_CustomizeDashboardItemCaption

			AddHandler dashboardViewer.PopupMenuShowing, AddressOf DashboardViewer_PopupMenuShowing
			AddHandler dashboardViewer.MasterFilterSet, AddressOf DashboardViewer_MasterFilterSet

			dashboardViewer.UpdateDashboardTitle()
			UpdateDashboardItemCaptions()
		End Sub

		Private Sub DashboardViewer_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
			Dim viewer As DashboardViewer = DirectCast(sender, DashboardViewer)

			' Display a string of master filter values.
			Dim filterText As String = String.Empty
			For Each item In viewer.Dashboard.Items
				If viewer.CanSetMasterFilter(item.ComponentName) Then
					Dim filterValues = viewer.GetCurrentFilterValues(item.ComponentName)
					filterText &= GetFilterText(filterValues)
				End If
			Next item
			Dim toolbarItem As New DashboardToolbarItem()
			toolbarItem.Caption = "Filter: " & filterText
			e.Items.Insert(0, toolbarItem)


			' Remove the Export button depending on the static variable.
			If Not allowExport Then
				RemoveExportButton(e.Items)
			End If

			' Add drop-down menu to show/hide dashboard item captions.
			Dim toolbarItemRoot As New DashboardToolbarItem()
			toolbarItemRoot.Caption = "Show/Hide Dashboard Item Captions"
			toolbarItemRoot.SvgImage = svgImageCollection1("title")
			For Each item In viewer.Dashboard.Items
				Dim menuItem As DashboardToolbarMenuItem = New DashboardToolbarMenuItem(item.ShowCaption, item.Name, New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
					item.ShowCaption = Not item.ShowCaption
				End Sub))
				menuItem.ImageOptions.SvgImage = svgImageCollection1("title")
				toolbarItemRoot.MenuItems.Add(menuItem)
			Next item
			e.Items.Insert(0, toolbarItemRoot)


			' Add a button with an image to navigate to this example online.
			Dim infoLinkItem As DashboardToolbarItem = New DashboardToolbarItem("", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
				System.Diagnostics.Process.Start("https://www.devexpress.com/Support/Center/Example/Details/T630210/")
			End Sub))
			' Note that a raster image is proportionally resized to 24 px height when displayed in the Title area.
			infoLinkItem.SvgImage = svgImageCollection1("support")
			e.Items.Add(infoLinkItem)
		End Sub

		Private Sub DashboardViewer_CustomizeDashboardItemCaption(ByVal sender As Object, ByVal e As CustomizeDashboardItemCaptionEventArgs)
			' Remove the Export button depending on the static variable.
			If Not allowExport Then
				If Not e.DashboardItemName.Contains("Map") Then
					RemoveExportButton(e.Items)
				End If
			End If

			' Display filter values.
			Dim viewer As DashboardViewer = DirectCast(sender, DashboardViewer)
			Dim filterValues = viewer.GetCurrentFilterValues(e.DashboardItemName)
			If filterValues IsNot Nothing Then
				If filterValues.Count > 0 Then
					e.FilterText = String.Format(" ( Filter: {0})", String.Concat(filterValues.Select(Function(axp) String.Format("{0} ", axp.GetAxisPoint(axp.AvailableAxisNames(0)).DisplayText)).ToArray()))
				End If
			End If

		End Sub

		Private Sub DashboardViewer_PopupMenuShowing(ByVal sender As Object, ByVal e As DashboardPopupMenuShowingEventArgs)
			' Hide popup menu everywhere except the dashboard title, to hide commands related to the export actions. 
			If e.DashboardArea = DashboardArea.DashboardItem Then
				e.Allow = False
			End If
		End Sub
		Private Sub DashboardViewer_MasterFilterSet(ByVal sender As Object, ByVal e As MasterFilterSetEventArgs)
			If e.DashboardItemName = "listBoxDashboardItem1" Then
				allowExport = If(e.SelectedValues.Select(Function(value) value(0).ToString()).Contains("Bikes"), False, True)
			End If
			UpdateDashboardItemCaptions()
			dashboardViewer.UpdateDashboardTitle()
		End Sub
		Private Function GetFilterText(ByVal filterValues As IList(Of AxisPointTuple)) As String
			Dim filterText As String = String.Empty
			If filterValues.Count > 0 Then
				Dim dimensionName As String = String.Concat(filterValues.Select(Function(axp) String.Format("{0} ", axp.GetAxisPoint(axp.AvailableAxisNames(0)).Dimension.Name)).Distinct())
				filterText = String.Format(" ({0}:{1})", dimensionName, String.Join(",", filterValues.Select(Function(axp) String.Format(" {0}", axp.GetAxisPoint(axp.AvailableAxisNames(0)).DisplayText)).ToArray()))
			End If
			Return filterText
		End Function
		Private Sub UpdateDashboardItemCaptions()
			For Each i As DashboardItem In dashboardViewer.Dashboard.Items
				dashboardViewer.UpdateDashboardItemCaption(i.ComponentName)
			Next i
		End Sub
		Private Sub RemoveExportButton(ByVal items As IList(Of DashboardToolbarItem))
			Dim exportItem = items.FirstOrDefault(Function(i) i.ButtonType = DashboardButtonType.Export)
			If exportItem IsNot Nothing Then
				items.Remove(exportItem)
			End If
		End Sub
	End Class
End Namespace
