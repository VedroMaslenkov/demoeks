namespace PartnerManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPartners;
        private System.Windows.Forms.Button btnAddPartner;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewServiceHistory;
        private System.Windows.Forms.Button btnCalculateCost;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewPartners = new System.Windows.Forms.DataGridView();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnViewServiceHistory = new System.Windows.Forms.Button();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartners)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPartners
            // 
            this.dataGridViewPartners.AllowUserToAddRows = false;
            this.dataGridViewPartners.AllowUserToDeleteRows = false;
            this.dataGridViewPartners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPartners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPartners.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartners.Location = new System.Drawing.Point(12, 301);
            this.dataGridViewPartners.Name = "dataGridViewPartners";
            this.dataGridViewPartners.ReadOnly = true;
            this.dataGridViewPartners.RowHeadersWidth = 51;
            this.dataGridViewPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPartners.Size = new System.Drawing.Size(960, 237);
            this.dataGridViewPartners.TabIndex = 0;
            this.dataGridViewPartners.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartners_CellDoubleClick);
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.btnAddPartner.FlatAppearance.BorderSize = 0;
            this.btnAddPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartner.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPartner.ForeColor = System.Drawing.Color.White;
            this.btnAddPartner.Location = new System.Drawing.Point(17, 261);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(150, 34);
            this.btnAddPartner.TabIndex = 1;
            this.btnAddPartner.Text = "Добавить партнера";
            this.btnAddPartner.UseVisualStyleBackColor = false;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(204, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 255);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Партнеры компании";
            // 
            // btnViewServiceHistory
            // 
            this.btnViewServiceHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.btnViewServiceHistory.FlatAppearance.BorderSize = 0;
            this.btnViewServiceHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewServiceHistory.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewServiceHistory.ForeColor = System.Drawing.Color.White;
            this.btnViewServiceHistory.Location = new System.Drawing.Point(331, 261);
            this.btnViewServiceHistory.Name = "btnViewServiceHistory";
            this.btnViewServiceHistory.Size = new System.Drawing.Size(150, 34);
            this.btnViewServiceHistory.TabIndex = 4;
            this.btnViewServiceHistory.Text = "История услуг";
            this.btnViewServiceHistory.UseVisualStyleBackColor = false;
            this.btnViewServiceHistory.Click += new System.EventHandler(this.btnViewServiceHistory_Click);
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.btnCalculateCost.FlatAppearance.BorderSize = 0;
            this.btnCalculateCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateCost.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateCost.ForeColor = System.Drawing.Color.White;
            this.btnCalculateCost.Location = new System.Drawing.Point(498, 261);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(150, 34);
            this.btnCalculateCost.TabIndex = 5;
            this.btnCalculateCost.Text = "Расчет стоимости";
            this.btnCalculateCost.UseVisualStyleBackColor = false;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Рисунок1;
            this.pictureBox1.Location = new System.Drawing.Point(663, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 252);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 558);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.btnViewServiceHistory);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.dataGridViewPartners);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(1000, 597);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления партнерами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartners)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}