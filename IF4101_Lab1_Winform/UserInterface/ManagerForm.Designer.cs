
namespace IF4101_Lab1_Winform
{
    partial class ManagerForm
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
            this.lb_managerTittle = new System.Windows.Forms.Label();
            this.lb_managerNameCountry = new System.Windows.Forms.Label();
            this.chbx_managerAdd = new System.Windows.Forms.CheckBox();
            this.chbx_managerDelete = new System.Windows.Forms.CheckBox();
            this.txb_managerNameContry = new System.Windows.Forms.TextBox();
            this.lb_managerCurrency = new System.Windows.Forms.Label();
            this.cmbx_managerCurrency = new System.Windows.Forms.ComboBox();
            this.btn_managerAdd = new System.Windows.Forms.Button();
            this.cmbx_managerCountries = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_managerTittle
            // 
            this.lb_managerTittle.AutoSize = true;
            this.lb_managerTittle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_managerTittle.Location = new System.Drawing.Point(310, 9);
            this.lb_managerTittle.Name = "lb_managerTittle";
            this.lb_managerTittle.Size = new System.Drawing.Size(436, 72);
            this.lb_managerTittle.TabIndex = 0;
            this.lb_managerTittle.Text = "CRUD Countries";
            this.lb_managerTittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_managerNameCountry
            // 
            this.lb_managerNameCountry.AutoSize = true;
            this.lb_managerNameCountry.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_managerNameCountry.Location = new System.Drawing.Point(104, 199);
            this.lb_managerNameCountry.Name = "lb_managerNameCountry";
            this.lb_managerNameCountry.Size = new System.Drawing.Size(101, 37);
            this.lb_managerNameCountry.TabIndex = 1;
            this.lb_managerNameCountry.Text = "Name: ";
            this.lb_managerNameCountry.Visible = false;
            // 
            // chbx_managerAdd
            // 
            this.chbx_managerAdd.AutoSize = true;
            this.chbx_managerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_managerAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbx_managerAdd.Location = new System.Drawing.Point(410, 101);
            this.chbx_managerAdd.Name = "chbx_managerAdd";
            this.chbx_managerAdd.Size = new System.Drawing.Size(86, 36);
            this.chbx_managerAdd.TabIndex = 2;
            this.chbx_managerAdd.Text = "Add ";
            this.chbx_managerAdd.UseVisualStyleBackColor = true;
            this.chbx_managerAdd.Click += new System.EventHandler(this.chbx_managerAdd_Click);
            // 
            // chbx_managerDelete
            // 
            this.chbx_managerDelete.AutoSize = true;
            this.chbx_managerDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_managerDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbx_managerDelete.Location = new System.Drawing.Point(558, 101);
            this.chbx_managerDelete.Name = "chbx_managerDelete";
            this.chbx_managerDelete.Size = new System.Drawing.Size(106, 36);
            this.chbx_managerDelete.TabIndex = 3;
            this.chbx_managerDelete.Text = "Delete";
            this.chbx_managerDelete.UseVisualStyleBackColor = true;
            this.chbx_managerDelete.Click += new System.EventHandler(this.chbx_managerDelete_Click);
            // 
            // txb_managerNameContry
            // 
            this.txb_managerNameContry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_managerNameContry.Location = new System.Drawing.Point(251, 209);
            this.txb_managerNameContry.Name = "txb_managerNameContry";
            this.txb_managerNameContry.Size = new System.Drawing.Size(276, 30);
            this.txb_managerNameContry.TabIndex = 4;
            this.txb_managerNameContry.Visible = false;
            // 
            // lb_managerCurrency
            // 
            this.lb_managerCurrency.AutoSize = true;
            this.lb_managerCurrency.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_managerCurrency.Location = new System.Drawing.Point(104, 284);
            this.lb_managerCurrency.Name = "lb_managerCurrency";
            this.lb_managerCurrency.Size = new System.Drawing.Size(134, 37);
            this.lb_managerCurrency.TabIndex = 5;
            this.lb_managerCurrency.Text = "Currency: ";
            this.lb_managerCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_managerCurrency.Visible = false;
            // 
            // cmbx_managerCurrency
            // 
            this.cmbx_managerCurrency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbx_managerCurrency.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbx_managerCurrency.FormattingEnabled = true;
            this.cmbx_managerCurrency.Location = new System.Drawing.Point(251, 293);
            this.cmbx_managerCurrency.Name = "cmbx_managerCurrency";
            this.cmbx_managerCurrency.Size = new System.Drawing.Size(276, 31);
            this.cmbx_managerCurrency.TabIndex = 6;
            this.cmbx_managerCurrency.Visible = false;
            this.cmbx_managerCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbx_managerCurrency_SelectedIndexChanged);
            this.cmbx_managerCurrency.Click += new System.EventHandler(this.cmbx_managerCurrency_Click);
            // 
            // btn_managerAdd
            // 
            this.btn_managerAdd.BackColor = System.Drawing.Color.Silver;
            this.btn_managerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_managerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_managerAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_managerAdd.Location = new System.Drawing.Point(468, 379);
            this.btn_managerAdd.Name = "btn_managerAdd";
            this.btn_managerAdd.Size = new System.Drawing.Size(123, 55);
            this.btn_managerAdd.TabIndex = 7;
            this.btn_managerAdd.Text = "Add";
            this.btn_managerAdd.UseVisualStyleBackColor = false;
            this.btn_managerAdd.Visible = false;
            this.btn_managerAdd.Click += new System.EventHandler(this.btn_managerAdd_Click);
            // 
            // cmbx_managerCountries
            // 
            this.cmbx_managerCountries.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbx_managerCountries.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbx_managerCountries.FormattingEnabled = true;
            this.cmbx_managerCountries.Location = new System.Drawing.Point(251, 208);
            this.cmbx_managerCountries.Name = "cmbx_managerCountries";
            this.cmbx_managerCountries.Size = new System.Drawing.Size(276, 31);
            this.cmbx_managerCountries.TabIndex = 8;
            this.cmbx_managerCountries.Visible = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1031, 512);
            this.Controls.Add(this.cmbx_managerCountries);
            this.Controls.Add(this.btn_managerAdd);
            this.Controls.Add(this.cmbx_managerCurrency);
            this.Controls.Add(this.lb_managerCurrency);
            this.Controls.Add(this.txb_managerNameContry);
            this.Controls.Add(this.chbx_managerDelete);
            this.Controls.Add(this.chbx_managerAdd);
            this.Controls.Add(this.lb_managerNameCountry);
            this.Controls.Add(this.lb_managerTittle);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_managerTittle;
        private System.Windows.Forms.Label lb_managerNameCountry;
        private System.Windows.Forms.CheckBox chbx_managerAdd;
        private System.Windows.Forms.CheckBox chbx_managerDelete;
        private System.Windows.Forms.TextBox txb_managerNameContry;
        private System.Windows.Forms.Label lb_managerCurrency;
        private System.Windows.Forms.ComboBox cmbx_managerCurrency;
        private System.Windows.Forms.Button btn_managerAdd;
        private System.Windows.Forms.ComboBox cmbx_managerCountries;
    }
}