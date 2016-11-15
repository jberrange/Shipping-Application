namespace Shipping
{
    partial class frmCostCalculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblShippingCost = new System.Windows.Forms.Label();
            this.lblPackageSize = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.MaskedTextBox();
            this.txtWidth = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPackageSizeLabel = new System.Windows.Forms.Label();
            this.lblShippingCostLabel = new System.Windows.Forms.Label();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(197, 22);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate package cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblShippingCost
            // 
            this.lblShippingCost.AutoSize = true;
            this.lblShippingCost.Location = new System.Drawing.Point(311, 75);
            this.lblShippingCost.Name = "lblShippingCost";
            this.lblShippingCost.Size = new System.Drawing.Size(71, 13);
            this.lblShippingCost.TabIndex = 1;
            this.lblShippingCost.Text = "Shipping cost";
            // 
            // lblPackageSize
            // 
            this.lblPackageSize.AutoSize = true;
            this.lblPackageSize.Location = new System.Drawing.Point(311, 58);
            this.lblPackageSize.Name = "lblPackageSize";
            this.lblPackageSize.Size = new System.Drawing.Size(71, 13);
            this.lblPackageSize.TabIndex = 2;
            this.lblPackageSize.Text = "Package size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(63, 51);
            this.txtLength.Name = "txtLength";
            this.txtLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 5;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(63, 77);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(63, 103);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(63, 129);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(100, 20);
            this.txtMass.TabIndex = 11;
            this.txtMass.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mass";
            // 
            // lblPackageSizeLabel
            // 
            this.lblPackageSizeLabel.AutoSize = true;
            this.lblPackageSizeLabel.Location = new System.Drawing.Point(194, 58);
            this.lblPackageSizeLabel.Name = "lblPackageSizeLabel";
            this.lblPackageSizeLabel.Size = new System.Drawing.Size(111, 13);
            this.lblPackageSizeLabel.TabIndex = 12;
            this.lblPackageSizeLabel.Text = "Your package size is: ";
            // 
            // lblShippingCostLabel
            // 
            this.lblShippingCostLabel.AutoSize = true;
            this.lblShippingCostLabel.Location = new System.Drawing.Point(194, 75);
            this.lblShippingCostLabel.Name = "lblShippingCostLabel";
            this.lblShippingCostLabel.Size = new System.Drawing.Size(110, 13);
            this.lblShippingCostLabel.TabIndex = 13;
            this.lblShippingCostLabel.Text = "Your shipping cost is: ";
            // 
            // lblErrorStatus
            // 
            this.lblErrorStatus.AutoSize = true;
            this.lblErrorStatus.Location = new System.Drawing.Point(12, 179);
            this.lblErrorStatus.Name = "lblErrorStatus";
            this.lblErrorStatus.Size = new System.Drawing.Size(69, 13);
            this.lblErrorStatus.TabIndex = 18;
            this.lblErrorStatus.Text = "lblErrorStatus";
            this.lblErrorStatus.Visible = false;
            // 
            // lblErrorText
            // 
            this.lblErrorText.Location = new System.Drawing.Point(12, 203);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(439, 25);
            this.lblErrorText.TabIndex = 19;
            this.lblErrorText.Text = "label5";
            this.lblErrorText.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 153);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your parcel dimensions";
            // 
            // frmCostCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 227);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.lblErrorStatus);
            this.Controls.Add(this.lblShippingCostLabel);
            this.Controls.Add(this.lblPackageSizeLabel);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPackageSize);
            this.Controls.Add(this.lblShippingCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCostCalculator";
            this.Text = "Shipping Cost Calculator";
            this.Load += new System.EventHandler(this.frmCostCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblShippingCost;
        private System.Windows.Forms.Label lblPackageSize;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtLength;
        private System.Windows.Forms.MaskedTextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtMass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPackageSizeLabel;
        private System.Windows.Forms.Label lblShippingCostLabel;
        private System.Windows.Forms.Label lblErrorStatus;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

