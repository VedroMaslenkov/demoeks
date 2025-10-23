namespace PartnerManagementSystem
{
    partial class PartnerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboPartnerType;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtINN;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblINN;
        private System.Windows.Forms.Label lblRating;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboPartnerType = new System.Windows.Forms.ComboBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblINN = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // PartnerForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            // this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление партнера";

            // Labels
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 70);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(150, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Тип партнера:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(30, 110);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(150, 20);
            this.lblDirector.TabIndex = 2;
            this.lblDirector.Text = "Руководитель:";
            this.lblDirector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 190);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(150, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Телефон:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(30, 230);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(150, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Адрес:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblINN.AutoSize = true;
            this.lblINN.Location = new System.Drawing.Point(30, 270);
            this.lblINN.Name = "lblINN";
            this.lblINN.Size = new System.Drawing.Size(150, 20);
            this.lblINN.TabIndex = 6;
            this.lblINN.Text = "ИНН:";
            this.lblINN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(30, 310);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(150, 20);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Рейтинг:";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // TextBoxes
            this.txtName.Location = new System.Drawing.Point(190, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 25);
            this.txtName.TabIndex = 8;

            this.comboPartnerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPartnerType.FormattingEnabled = true;
            this.comboPartnerType.Location = new System.Drawing.Point(190, 67);
            this.comboPartnerType.Name = "comboPartnerType";
            this.comboPartnerType.Size = new System.Drawing.Size(250, 28);
            this.comboPartnerType.TabIndex = 9;

            this.txtDirector.Location = new System.Drawing.Point(190, 107);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(250, 25);
            this.txtDirector.TabIndex = 10;

            this.txtEmail.Location = new System.Drawing.Point(190, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.TabIndex = 11;

            this.txtPhone.Location = new System.Drawing.Point(190, 187);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 25);
            this.txtPhone.TabIndex = 12;

            this.txtAddress.Location = new System.Drawing.Point(190, 227);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 25);
            this.txtAddress.TabIndex = 13;

            this.txtINN.Location = new System.Drawing.Point(190, 267);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(250, 25);
            this.txtINN.TabIndex = 14;

            this.txtRating.Location = new System.Drawing.Point(190, 307);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(250, 25);
            this.txtRating.TabIndex = 15;
            this.txtRating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRating_KeyPress);

            // Buttons
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 206, 209);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(190, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(300, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.btnViewHistory.BackColor = System.Drawing.Color.FromArgb(0, 206, 209);
            this.btnViewHistory.FlatAppearance.BorderSize = 0;
            this.btnViewHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHistory.ForeColor = System.Drawing.Color.White;
            this.btnViewHistory.Location = new System.Drawing.Point(80, 350);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(100, 35);
            this.btnViewHistory.TabIndex = 18;
            this.btnViewHistory.Text = "История услуг";
            this.btnViewHistory.UseVisualStyleBackColor = false;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            this.btnViewHistory.Visible = false;

            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtINN);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.comboPartnerType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblINN);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}