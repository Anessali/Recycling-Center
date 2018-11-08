namespace Recycling_Center_App
{
    partial class frmDatabase
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabase));
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIS260recycleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CIS260_recycleDataSet = new Recycling_Center_App._CIS260_recycleDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new Recycling_Center_App._CIS260_recycleDataSetTableAdapters.CategoriesTableAdapter();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Recycling_Center_App._CIS260_recycleDataSetTableAdapters.MaterialsTableAdapter();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusesTableAdapter = new Recycling_Center_App._CIS260_recycleDataSetTableAdapters.StatusesTableAdapter();
            this.subcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subcategoriesTableAdapter = new Recycling_Center_App._CIS260_recycleDataSetTableAdapters.SubcategoriesTableAdapter();
            this.vendorsTableAdapter = new Recycling_Center_App._CIS260_recycleDataSetTableAdapters.VendorsTableAdapter();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.vendorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddress1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddress2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddress1DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddress2DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datView = new System.Windows.Forms.DataGridView();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddress2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS260recycleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CIS260_recycleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.cIS260recycleDataSetBindingSource;
            // 
            // cIS260recycleDataSetBindingSource
            // 
            this.cIS260recycleDataSetBindingSource.DataSource = this._CIS260_recycleDataSet;
            this.cIS260recycleDataSetBindingSource.Position = 0;
            // 
            // _CIS260_recycleDataSet
            // 
            this._CIS260_recycleDataSet.DataSetName = "_CIS260_recycleDataSet";
            this._CIS260_recycleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.cIS260recycleDataSetBindingSource;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.cIS260recycleDataSetBindingSource;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.cIS260recycleDataSetBindingSource;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "Statuses";
            this.statusesBindingSource.DataSource = this.cIS260recycleDataSetBindingSource;
            // 
            // statusesTableAdapter
            // 
            this.statusesTableAdapter.ClearBeforeFill = true;
            // 
            // subcategoriesBindingSource
            // 
            this.subcategoriesBindingSource.DataMember = "Subcategories";
            this.subcategoriesBindingSource.DataSource = this.cIS260recycleDataSetBindingSource;
            // 
            // subcategoriesTableAdapter
            // 
            this.subcategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(944, 379);
            // 
            // vendorIDDataGridViewTextBoxColumn1
            // 
            this.vendorIDDataGridViewTextBoxColumn1.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn1.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn1.Name = "vendorIDDataGridViewTextBoxColumn1";
            // 
            // vendorNameDataGridViewTextBoxColumn1
            // 
            this.vendorNameDataGridViewTextBoxColumn1.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn1.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn1.Name = "vendorNameDataGridViewTextBoxColumn1";
            // 
            // streetAddress1DataGridViewTextBoxColumn1
            // 
            this.streetAddress1DataGridViewTextBoxColumn1.DataPropertyName = "StreetAddress1";
            this.streetAddress1DataGridViewTextBoxColumn1.HeaderText = "StreetAddress1";
            this.streetAddress1DataGridViewTextBoxColumn1.Name = "streetAddress1DataGridViewTextBoxColumn1";
            // 
            // streetAddress2DataGridViewTextBoxColumn1
            // 
            this.streetAddress2DataGridViewTextBoxColumn1.DataPropertyName = "StreetAddress2";
            this.streetAddress2DataGridViewTextBoxColumn1.HeaderText = "StreetAddress2";
            this.streetAddress2DataGridViewTextBoxColumn1.Name = "streetAddress2DataGridViewTextBoxColumn1";
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            this.stateDataGridViewTextBoxColumn1.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn1.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            // 
            // zipDataGridViewTextBoxColumn1
            // 
            this.zipDataGridViewTextBoxColumn1.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn1.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn1.Name = "zipDataGridViewTextBoxColumn1";
            // 
            // countryDataGridViewTextBoxColumn1
            // 
            this.countryDataGridViewTextBoxColumn1.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn1.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn1.Name = "countryDataGridViewTextBoxColumn1";
            // 
            // vendorIDDataGridViewTextBoxColumn2
            // 
            this.vendorIDDataGridViewTextBoxColumn2.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn2.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn2.Name = "vendorIDDataGridViewTextBoxColumn2";
            // 
            // vendorNameDataGridViewTextBoxColumn2
            // 
            this.vendorNameDataGridViewTextBoxColumn2.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn2.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn2.Name = "vendorNameDataGridViewTextBoxColumn2";
            // 
            // streetAddress1DataGridViewTextBoxColumn2
            // 
            this.streetAddress1DataGridViewTextBoxColumn2.DataPropertyName = "StreetAddress1";
            this.streetAddress1DataGridViewTextBoxColumn2.HeaderText = "StreetAddress1";
            this.streetAddress1DataGridViewTextBoxColumn2.Name = "streetAddress1DataGridViewTextBoxColumn2";
            // 
            // streetAddress2DataGridViewTextBoxColumn2
            // 
            this.streetAddress2DataGridViewTextBoxColumn2.DataPropertyName = "StreetAddress2";
            this.streetAddress2DataGridViewTextBoxColumn2.HeaderText = "StreetAddress2";
            this.streetAddress2DataGridViewTextBoxColumn2.Name = "streetAddress2DataGridViewTextBoxColumn2";
            // 
            // cityDataGridViewTextBoxColumn2
            // 
            this.cityDataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn2.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn2.Name = "cityDataGridViewTextBoxColumn2";
            // 
            // stateDataGridViewTextBoxColumn2
            // 
            this.stateDataGridViewTextBoxColumn2.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn2.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn2.Name = "stateDataGridViewTextBoxColumn2";
            // 
            // zipDataGridViewTextBoxColumn2
            // 
            this.zipDataGridViewTextBoxColumn2.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn2.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn2.Name = "zipDataGridViewTextBoxColumn2";
            // 
            // countryDataGridViewTextBoxColumn2
            // 
            this.countryDataGridViewTextBoxColumn2.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn2.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn2.Name = "countryDataGridViewTextBoxColumn2";
            // 
            // datView
            // 
            this.datView.AutoGenerateColumns = false;
            this.datView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialID,
            this.MaterialName,
            this.vendorIDDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.streetAddress1DataGridViewTextBoxColumn,
            this.streetAddress2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.datView.DataSource = this.vendorsBindingSource;
            this.datView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datView.Location = new System.Drawing.Point(0, 0);
            this.datView.Name = "datView";
            this.datView.Size = new System.Drawing.Size(1149, 446);
            this.datView.TabIndex = 1;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "MaterialID";
            this.MaterialID.Name = "MaterialID";
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "MaterialName";
            this.MaterialName.Name = "MaterialName";
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            // 
            // streetAddress1DataGridViewTextBoxColumn
            // 
            this.streetAddress1DataGridViewTextBoxColumn.DataPropertyName = "StreetAddress1";
            this.streetAddress1DataGridViewTextBoxColumn.HeaderText = "StreetAddress1";
            this.streetAddress1DataGridViewTextBoxColumn.Name = "streetAddress1DataGridViewTextBoxColumn";
            // 
            // streetAddress2DataGridViewTextBoxColumn
            // 
            this.streetAddress2DataGridViewTextBoxColumn.DataPropertyName = "StreetAddress2";
            this.streetAddress2DataGridViewTextBoxColumn.HeaderText = "StreetAddress2";
            this.streetAddress2DataGridViewTextBoxColumn.Name = "streetAddress2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 446);
            this.Controls.Add(this.datView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatabase";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS260recycleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CIS260_recycleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cIS260recycleDataSetBindingSource;
        private _CIS260_recycleDataSet _CIS260_recycleDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private _CIS260_recycleDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private _CIS260_recycleDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private _CIS260_recycleDataSetTableAdapters.StatusesTableAdapter statusesTableAdapter;
        private System.Windows.Forms.BindingSource subcategoriesBindingSource;
        private _CIS260_recycleDataSetTableAdapters.SubcategoriesTableAdapter subcategoriesTableAdapter;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private _CIS260_recycleDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddress1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddress2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddress1DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddress2DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView datView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddress2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
    }
}