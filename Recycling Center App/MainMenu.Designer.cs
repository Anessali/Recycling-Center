namespace Recycling_Center_App
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnBillLading = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBillLading
            // 
            this.btnBillLading.Location = new System.Drawing.Point(55, 55);
            this.btnBillLading.Name = "btnBillLading";
            this.btnBillLading.Size = new System.Drawing.Size(96, 40);
            this.btnBillLading.TabIndex = 0;
            this.btnBillLading.Text = "Bill of Lading";
            this.btnBillLading.UseVisualStyleBackColor = true;
            this.btnBillLading.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.Location = new System.Drawing.Point(219, 55);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(96, 40);
            this.btnMaterials.TabIndex = 1;
            this.btnMaterials.Text = "Materials label";
            this.btnMaterials.UseVisualStyleBackColor = true;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(365, 55);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(96, 40);
            this.btnDatabase.TabIndex = 3;
            this.btnDatabase.Text = "Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 272);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMaterials);
            this.Controls.Add(this.btnBillLading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBillLading;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDatabase;
    }
}

