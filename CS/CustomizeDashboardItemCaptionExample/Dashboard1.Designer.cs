﻿namespace CustomizeDashboardItemCaption_Viewer_Example
{
    partial class SampleDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridDeltaColumn gridDeltaColumn1 = new DevExpress.DashboardCommon.GridDeltaColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleDashboard));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ValueMap valueMap1 = new DevExpress.DashboardCommon.ValueMap();
            DevExpress.DashboardCommon.UniformScale uniformScale1 = new DevExpress.DashboardCommon.UniformScale();
            DevExpress.DashboardCommon.DeltaMap deltaMap1 = new DevExpress.DashboardCommon.DeltaMap();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
            this.dashboardExcelDataSource1 = new DevExpress.DashboardCommon.DashboardExcelDataSource();
            this.choroplethMapDashboardItem1 = new DevExpress.DashboardCommon.ChoroplethMapDashboardItem();
            this.listBoxDashboardItem1 = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExcelDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choroplethMapDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // gridDashboardItem1
            // 
            dimension1.DataMember = "Product";
            gridDimensionColumn1.Weight = 78.333333333333329D;
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension1);
            measure1.DataMember = "UnitsSoldYTD (Sum)";
            measure2.DataMember = "UnitsSoldYTDTarget (Sum)";
            gridDeltaColumn1.Name = "UnitsSold YTD vs Target";
            gridDeltaColumn1.Weight = 71.666666666666671D;
            gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDeltaColumn1.AddDataItem("ActualValue", measure1);
            gridDeltaColumn1.AddDataItem("TargetValue", measure2);
            this.gridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1,
            gridDeltaColumn1});
            this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
            this.gridDashboardItem1.DataItemRepository.Clear();
            this.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.gridDashboardItem1.DataItemRepository.Add(measure2, "DataItem2");
            this.gridDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            this.gridDashboardItem1.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.Manual;
            this.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridDashboardItem1.Name = "Product Units Sold";
            this.gridDashboardItem1.ShowCaption = true;
            // 
            // dashboardExcelDataSource1
            // 
            this.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1";
            this.dashboardExcelDataSource1.FileName = "|DataDirectory|\\Data\\Sales.xlsx";
            this.dashboardExcelDataSource1.Name = "Excel Data Source 1";
            this.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "Category";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "Product";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "State";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "UnitsSoldYTD (Sum)";
            fieldInfo4.Type = typeof(double);
            fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)";
            fieldInfo5.Type = typeof(double);
            fieldInfo6.Name = "RevenueQTD (Sum)";
            fieldInfo6.Type = typeof(double);
            fieldInfo7.Name = "RevenueQTDTarget (Sum)";
            fieldInfo7.Type = typeof(double);
            fieldInfo8.Name = "RevenueYTD (Sum)";
            fieldInfo8.Type = typeof(double);
            fieldInfo9.Name = "RevenueYTDTarget (Sum)";
            fieldInfo9.Type = typeof(double);
            this.dashboardExcelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Sheet1";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // choroplethMapDashboardItem1
            // 
            this.choroplethMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.USA;
            dimension2.DataMember = "State";
            this.choroplethMapDashboardItem1.AttributeDimension = dimension2;
            this.choroplethMapDashboardItem1.AttributeName = "NAME";
            this.choroplethMapDashboardItem1.ComponentName = "choroplethMapDashboardItem1";
            measure3.DataMember = "RevenueYTD (Sum)";
            measure4.DataMember = "RevenueYTD (Sum)";
            measure5.DataMember = "RevenueYTDTarget (Sum)";
            this.choroplethMapDashboardItem1.DataItemRepository.Clear();
            this.choroplethMapDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure3, "DataItem1");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure4, "DataItem2");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure5, "DataItem3");
            this.choroplethMapDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            this.choroplethMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.choroplethMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            valueMap1.Name = "Revenue YTD";
            valueMap1.Scale = uniformScale1;
            valueMap1.ValueName = "Revenue";
            valueMap1.AddDataItem("Value", measure3);
            deltaMap1.ActualValueName = "Revenue";
            deltaMap1.DeltaName = "vs Target";
            deltaMap1.Name = "Revenue YTD vs Target";
            deltaMap1.AddDataItem("ActualValue", measure4);
            deltaMap1.AddDataItem("TargetValue", measure5);
            this.choroplethMapDashboardItem1.Maps.AddRange(new DevExpress.DashboardCommon.ChoroplethMap[] {
            valueMap1,
            deltaMap1});
            this.choroplethMapDashboardItem1.Name = "Sales by State";
            this.choroplethMapDashboardItem1.ShapeTitleAttributeName = "ABBREV";
            this.choroplethMapDashboardItem1.ShowCaption = true;
            this.choroplethMapDashboardItem1.Viewport.BottomLatitude = 22.722765208057595D;
            this.choroplethMapDashboardItem1.Viewport.CenterPointLatitude = 37.208247632673633D;
            this.choroplethMapDashboardItem1.Viewport.CenterPointLongitude = -95.848499902568008D;
            this.choroplethMapDashboardItem1.Viewport.LeftLongitude = -124.70997774915153D;
            this.choroplethMapDashboardItem1.Viewport.RightLongitude = -66.987022055984482D;
            this.choroplethMapDashboardItem1.Viewport.TopLatitude = 49.369672064487254D;
            // 
            // listBoxDashboardItem1
            // 
            this.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1";
            dimension3.DataMember = "Category";
            this.listBoxDashboardItem1.DataItemRepository.Clear();
            this.listBoxDashboardItem1.DataItemRepository.Add(dimension3, "DataItem0");
            this.listBoxDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            this.listBoxDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxDashboardItem1.Name = "Categories";
            this.listBoxDashboardItem1.ShowCaption = true;
            // 
            // SampleDashboard
            // 
            this.CurrencyCultureName = null;
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardExcelDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.choroplethMapDashboardItem1,
            this.gridDashboardItem1,
            this.listBoxDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.gridDashboardItem1;
            dashboardLayoutItem1.Weight = 33.675799086757991D;
            dashboardLayoutItem2.DashboardItem = this.choroplethMapDashboardItem1;
            dashboardLayoutItem2.Weight = 70.714285714285708D;
            dashboardLayoutItem3.DashboardItem = this.listBoxDashboardItem1;
            dashboardLayoutItem3.Weight = 29.285714285714285D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem2,
            dashboardLayoutItem3});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 66.324200913242009D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutGroup2});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Sample Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExcelDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choroplethMapDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChoroplethMapDashboardItem choroplethMapDashboardItem1;
        private DevExpress.DashboardCommon.DashboardExcelDataSource dashboardExcelDataSource1;
        private DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
        private DevExpress.DashboardCommon.ListBoxDashboardItem listBoxDashboardItem1;
    }
}
