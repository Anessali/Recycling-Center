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
            this._CIS260_recycleDataSet1 = new Recycling_Center_App._CIS260_recycleDataSet1();
            this.allDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataTableAdapter = new Recycling_Center_App._CIS260_recycleDataSet1TableAdapters.AllDataTableAdapter();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._CIS260_recycleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(18, 40);
            this.btnVendors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(160, 85);
            this.btnVendors.TabIndex = 0;
            this.btnVendors.Text = "Edit Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(186, 40);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(160, 85);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 283);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnVendors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this._CIS260_recycleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _CIS260_recycleDataSet1 _CIS260_recycleDataSet1;
        private System.Windows.Forms.BindingSource allDataBindingSource;
        private _CIS260_recycleDataSet1TableAdapters.AllDataTableAdapter allDataTableAdapter;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnChangePassword;
    }
}