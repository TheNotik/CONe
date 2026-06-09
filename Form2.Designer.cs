namespace Consumer.App
{
    partial class Form2
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
            this.txtNewName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNewBirth = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNewPin = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnPhoto = new MaterialSkin.Controls.MaterialButton();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewName
            // 
            this.txtNewName.AnimateReadOnly = false;
            this.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewName.Depth = 0;
            this.txtNewName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewName.Hint = "ФИО";
            this.txtNewName.LeadingIcon = null;
            this.txtNewName.Location = new System.Drawing.Point(283, 105);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewName.MaxLength = 50;
            this.txtNewName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewName.Multiline = false;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(283, 50);
            this.txtNewName.TabIndex = 20;
            this.txtNewName.Text = "";
            this.txtNewName.TrailingIcon = null;
            // 
            // txtNewBirth
            // 
            this.txtNewBirth.AnimateReadOnly = false;
            this.txtNewBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewBirth.Depth = 0;
            this.txtNewBirth.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewBirth.Hint = "Дата рождения (2000-01-31)";
            this.txtNewBirth.LeadingIcon = null;
            this.txtNewBirth.Location = new System.Drawing.Point(281, 217);
            this.txtNewBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewBirth.MaxLength = 50;
            this.txtNewBirth.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewBirth.Multiline = false;
            this.txtNewBirth.Name = "txtNewBirth";
            this.txtNewBirth.Size = new System.Drawing.Size(283, 50);
            this.txtNewBirth.TabIndex = 19;
            this.txtNewBirth.Text = "";
            this.txtNewBirth.TrailingIcon = null;
            // 
            // txtNewPin
            // 
            this.txtNewPin.AnimateReadOnly = false;
            this.txtNewPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPin.Depth = 0;
            this.txtNewPin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewPin.Hint = "PIN нового человека";
            this.txtNewPin.LeadingIcon = null;
            this.txtNewPin.Location = new System.Drawing.Point(281, 163);
            this.txtNewPin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPin.MaxLength = 50;
            this.txtNewPin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewPin.Multiline = false;
            this.txtNewPin.Name = "txtNewPin";
            this.txtNewPin.Size = new System.Drawing.Size(283, 50);
            this.txtNewPin.TabIndex = 18;
            this.txtNewPin.Text = "";
            this.txtNewPin.TrailingIcon = null;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(484, 308);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(82, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(387, 308);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(91, 36);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(281, 308);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPhoto.Depth = 0;
            this.btnPhoto.HighEmphasis = true;
            this.btnPhoto.Icon = null;
            this.btnPhoto.Location = new System.Drawing.Point(77, 351);
            this.btnPhoto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPhoto.Size = new System.Drawing.Size(134, 36);
            this.btnPhoto.TabIndex = 14;
            this.btnPhoto.Text = "Выбрать фото";
            this.btnPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnPhoto.UseAccentColor = false;
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(34, 105);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(224, 239);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 22;
            this.picPhoto.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(682, 547);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(210, 36);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Предыдущая страница";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 602);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtNewBirth);
            this.Controls.Add(this.txtNewPin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPhoto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNewName;
        private MaterialSkin.Controls.MaterialTextBox txtNewBirth;
        private MaterialSkin.Controls.MaterialTextBox txtNewPin;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnPhoto;
        
        private System.Windows.Forms.PictureBox picPhoto;
        private MaterialSkin.Controls.MaterialButton btnBack;
    }
}