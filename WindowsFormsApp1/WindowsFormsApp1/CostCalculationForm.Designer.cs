namespace PartnerManagementSystem
{
    partial class CostCalculationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.Label lblCostResult;
        private System.Windows.Forms.Label lblMaterialSection;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnCalculateMaterial;
        private System.Windows.Forms.Label lblMaterialResult;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent(string partnerName)
        {
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.lblCostResult = new System.Windows.Forms.Label();
            this.lblMaterialSection = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnCalculateMaterial = new System.Windows.Forms.Button();
            this.lblMaterialResult = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToDeleteRows = false;
            this.dataGridViewServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServices.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.ReadOnly = true;
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new System.Drawing.Size(760, 200);
            this.dataGridViewServices.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 206, 209);
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = $"Расчет стоимости услуг: {partnerName}";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(224, 255, 255);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.BackColor = System.Drawing.Color.FromArgb(0, 206, 209);
            this.btnCalculateCost.FlatAppearance.BorderSize = 0;
            this.btnCalculateCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateCost.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.btnCalculateCost.ForeColor = System.Drawing.Color.White;
            this.btnCalculateCost.Location = new System.Drawing.Point(12, 290);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(200, 35);
            this.btnCalculateCost.TabIndex = 3;
            this.btnCalculateCost.Text = "Рассчитать себестоимость";
            this.btnCalculateCost.UseVisualStyleBackColor = false;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // lblCostResult
            // 
            this.lblCostResult.AutoSize = true;
            this.lblCostResult.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblCostResult.Location = new System.Drawing.Point(220, 297);
            this.lblCostResult.Name = "lblCostResult";
            this.lblCostResult.Size = new System.Drawing.Size(200, 20);
            this.lblCostResult.TabIndex = 4;
            this.lblCostResult.Text = "Выберите услугу для расчета";
            // 
            // lblMaterialSection
            // 
            this.lblMaterialSection.AutoSize = true;
            this.lblMaterialSection.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaterialSection.ForeColor = System.Drawing.Color.FromArgb(0, 206, 209);
            this.lblMaterialSection.Location = new System.Drawing.Point(12, 340);
            this.lblMaterialSection.Name = "lblMaterialSection";
            this.lblMaterialSection.Size = new System.Drawing.Size(200, 21);
            this.lblMaterialSection.TabIndex = 5;
            this.lblMaterialSection.Text = "Расчет необходимого материала";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.txtWeight.Location = new System.Drawing.Point(60, 380);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 25);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.lblWeight.Location = new System.Drawing.Point(12, 383);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(42, 20);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "Вес:";
            // 
            // btnCalculateMaterial
            // 
            this.btnCalculateMaterial.BackColor = System.Drawing.Color.FromArgb(0, 206, 209);
            this.btnCalculateMaterial.FlatAppearance.BorderSize = 0;
            this.btnCalculateMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateMaterial.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.btnCalculateMaterial.ForeColor = System.Drawing.Color.White;
            this.btnCalculateMaterial.Location = new System.Drawing.Point(180, 375);
            this.btnCalculateMaterial.Name = "btnCalculateMaterial";
            this.btnCalculateMaterial.Size = new System.Drawing.Size(200, 35);
            this.btnCalculateMaterial.TabIndex = 8;
            this.btnCalculateMaterial.Text = "Рассчитать материал";
            this.btnCalculateMaterial.UseVisualStyleBackColor = false;
            this.btnCalculateMaterial.Click += new System.EventHandler(this.btnCalculateMaterial_Click);
            // 
            // lblMaterialResult
            // 
            this.lblMaterialResult.AutoSize = true;
            this.lblMaterialResult.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaterialResult.Location = new System.Drawing.Point(12, 420);
            this.lblMaterialResult.Name = "lblMaterialResult";
            this.lblMaterialResult.Size = new System.Drawing.Size(250, 20);
            this.lblMaterialResult.TabIndex = 9;
            this.lblMaterialResult.Text = "Выберите услугу и введите вес";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(0, 206, 209);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(652, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CostCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 532);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMaterialResult);
            this.Controls.Add(this.btnCalculateMaterial);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblMaterialSection);
            this.Controls.Add(this.lblCostResult);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dataGridViewServices);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 579);
            this.Name = "CostCalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расчет стоимости";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}