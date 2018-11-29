namespace Recycling_Center_App
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.btnSql = new System.Windows.Forms.Button();
            this.txtSql = new System.Windows.Forms.TextBox();
            this._CIS260_recycleDataSet1 = new Recycling_Center_App._CIS260_recycleDataSet1();
            this.allDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataTableAdapter = new Recycling_Center_App._CIS260_recycleDataSet1TableAdapters.AllDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._CIS260_recycleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSql
            // 
            this.btnSql.Location = new System.Drawing.Point(12, 203);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(75, 23);
            this.btnSql.TabIndex = 0;
            this.btnSql.Text = "Change";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(93, 205);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(357, 20);
            this.txtSql.TabIndex = 1;
            this.txtSql.Text = "Enter new Connection String";
            // 
            // _CIS260_recycleDataSet1
            // 
            this._CIS260_recycleDataSet1.DataSetName = "_CIS260_recycleDataSet1";
            this._CIS260_recycleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allDataBindingSource
            // 
            this.allDataBindingSource.DataMember = "AllData";
            this.allDataBindingSource.DataSource = this._CIS260_recycleDataSet1;
            // 
            // allDataTableAdapter
            // 
            this.allDataTableAdapter.ClearBeforeFill = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.btnSql);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this._CIS260_recycleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.TextBox txtSql;
        private _CIS260_recycleDataSet1 _CIS260_recycleDataSet1;
        private System.Windows.Forms.BindingSource allDataBindingSource;
        private _CIS260_recycleDataSet1TableAdapters.AllDataTableAdapter allDataTableAdapter;
    }
}