namespace oop_6115261014_w09
{
    partial class Form1
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblTex = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnTaxCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(30, 56);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(42, 13);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "น้ำหนัก";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(130, 49);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(297, 71);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 37);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "คำนวณ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(30, 113);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "ส่วนสูง";
            this.lblHeight.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(130, 110);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(30, 171);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(67, 13);
            this.lblBMI.TabIndex = 5;
            this.lblBMI.Text = "ดัชนีมวลกาย";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 209);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ชื่อ-นามสกุล";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(30, 245);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(51, 13);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "เงินเดือน";
            // 
            // lblTex
            // 
            this.lblTex.AutoSize = true;
            this.lblTex.Location = new System.Drawing.Point(30, 282);
            this.lblTex.Name = "lblTex";
            this.lblTex.Size = new System.Drawing.Size(27, 13);
            this.lblTex.TabIndex = 8;
            this.lblTex.Text = "ภาษี";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 206);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(130, 245);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 10;
            // 
            // btnTaxCalculate
            // 
            this.btnTaxCalculate.Location = new System.Drawing.Point(297, 221);
            this.btnTaxCalculate.Name = "btnTaxCalculate";
            this.btnTaxCalculate.Size = new System.Drawing.Size(105, 37);
            this.btnTaxCalculate.TabIndex = 11;
            this.btnTaxCalculate.Text = "คำนวณภาษี";
            this.btnTaxCalculate.UseVisualStyleBackColor = true;
            this.btnTaxCalculate.Click += new System.EventHandler(this.btnTaxCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 367);
            this.Controls.Add(this.btnTaxCalculate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTex);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblTex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnTaxCalculate;
    }
}

