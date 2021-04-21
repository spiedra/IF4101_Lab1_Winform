
namespace IF4101_Lab1_Winform
{
    partial class CalculatorForm
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
            this.lb_calculatorTittle = new System.Windows.Forms.Label();
            this.lb_calculatorAmount = new System.Windows.Forms.Label();
            this.tbx_calculatorAmount = new System.Windows.Forms.TextBox();
            this.lb_calculatorFrom = new System.Windows.Forms.Label();
            this.cbx_calculatorFrom = new System.Windows.Forms.ComboBox();
            this.lb_calculatorTo = new System.Windows.Forms.Label();
            this.cbx_calculatorTo = new System.Windows.Forms.ComboBox();
            this.btn_calculatorCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_calculatorTittle
            // 
            this.lb_calculatorTittle.AutoSize = true;
            this.lb_calculatorTittle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_calculatorTittle.Location = new System.Drawing.Point(404, 27);
            this.lb_calculatorTittle.Name = "lb_calculatorTittle";
            this.lb_calculatorTittle.Size = new System.Drawing.Size(527, 72);
            this.lb_calculatorTittle.TabIndex = 0;
            this.lb_calculatorTittle.Text = "Currency Calculator";
            // 
            // lb_calculatorAmount
            // 
            this.lb_calculatorAmount.AutoSize = true;
            this.lb_calculatorAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_calculatorAmount.Location = new System.Drawing.Point(70, 231);
            this.lb_calculatorAmount.Name = "lb_calculatorAmount";
            this.lb_calculatorAmount.Size = new System.Drawing.Size(125, 41);
            this.lb_calculatorAmount.TabIndex = 2;
            this.lb_calculatorAmount.Text = "Amount";
            this.lb_calculatorAmount.Click += new System.EventHandler(this.lb_calculatorAmount_Click);
            // 
            // tbx_calculatorAmount
            // 
            this.tbx_calculatorAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_calculatorAmount.Location = new System.Drawing.Point(70, 290);
            this.tbx_calculatorAmount.Name = "tbx_calculatorAmount";
            this.tbx_calculatorAmount.Size = new System.Drawing.Size(270, 39);
            this.tbx_calculatorAmount.TabIndex = 3;
            this.tbx_calculatorAmount.TextChanged += new System.EventHandler(this.tbx_calculatorAmount_TextChanged);
            // 
            // lb_calculatorFrom
            // 
            this.lb_calculatorFrom.AutoSize = true;
            this.lb_calculatorFrom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_calculatorFrom.Location = new System.Drawing.Point(503, 231);
            this.lb_calculatorFrom.Name = "lb_calculatorFrom";
            this.lb_calculatorFrom.Size = new System.Drawing.Size(87, 41);
            this.lb_calculatorFrom.TabIndex = 4;
            this.lb_calculatorFrom.Text = "From";
            // 
            // cbx_calculatorFrom
            // 
            this.cbx_calculatorFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_calculatorFrom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_calculatorFrom.FormattingEnabled = true;
            this.cbx_calculatorFrom.Location = new System.Drawing.Point(503, 290);
            this.cbx_calculatorFrom.Name = "cbx_calculatorFrom";
            this.cbx_calculatorFrom.Size = new System.Drawing.Size(318, 39);
            this.cbx_calculatorFrom.TabIndex = 5;
            // 
            // lb_calculatorTo
            // 
            this.lb_calculatorTo.AutoSize = true;
            this.lb_calculatorTo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_calculatorTo.Location = new System.Drawing.Point(944, 231);
            this.lb_calculatorTo.Name = "lb_calculatorTo";
            this.lb_calculatorTo.Size = new System.Drawing.Size(49, 41);
            this.lb_calculatorTo.TabIndex = 7;
            this.lb_calculatorTo.Text = "To";
            this.lb_calculatorTo.Click += new System.EventHandler(this.lb_calculatorTo_Click);
            // 
            // cbx_calculatorTo
            // 
            this.cbx_calculatorTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_calculatorTo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_calculatorTo.FormattingEnabled = true;
            this.cbx_calculatorTo.Location = new System.Drawing.Point(944, 290);
            this.cbx_calculatorTo.Name = "cbx_calculatorTo";
            this.cbx_calculatorTo.Size = new System.Drawing.Size(318, 39);
            this.cbx_calculatorTo.TabIndex = 8;
            this.cbx_calculatorTo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_calculatorCalculate
            // 
            this.btn_calculatorCalculate.BackColor = System.Drawing.Color.Silver;
            this.btn_calculatorCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_calculatorCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calculatorCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_calculatorCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_calculatorCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calculatorCalculate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calculatorCalculate.Location = new System.Drawing.Point(570, 428);
            this.btn_calculatorCalculate.Name = "btn_calculatorCalculate";
            this.btn_calculatorCalculate.Size = new System.Drawing.Size(218, 52);
            this.btn_calculatorCalculate.TabIndex = 9;
            this.btn_calculatorCalculate.Text = "Calculate";
            this.btn_calculatorCalculate.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1341, 547);
            this.Controls.Add(this.btn_calculatorCalculate);
            this.Controls.Add(this.cbx_calculatorTo);
            this.Controls.Add(this.lb_calculatorTo);
            this.Controls.Add(this.cbx_calculatorFrom);
            this.Controls.Add(this.lb_calculatorFrom);
            this.Controls.Add(this.tbx_calculatorAmount);
            this.Controls.Add(this.lb_calculatorAmount);
            this.Controls.Add(this.lb_calculatorTittle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CalculatorWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_calculatorTittle;
        private System.Windows.Forms.Label lb_calculatorAmount;
        private System.Windows.Forms.TextBox tbx_calculatorAmount;
        private System.Windows.Forms.Label lb_calculatorFrom;
        private System.Windows.Forms.ComboBox cbx_calculatorFrom;
        private System.Windows.Forms.Label lb_calculatorTo;
        private System.Windows.Forms.ComboBox cbx_calculatorTo;
        private System.Windows.Forms.Button btn_calculatorCalculate;
    }
}