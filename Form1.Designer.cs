namespace Consumer.App
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPin = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblGender = new MaterialSkin.Controls.MaterialLabel();
            this.lblBirthDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblResult = new MaterialSkin.Controls.MaterialLabel();
            this.btnSupport = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPin
            // 
            this.txtPin.AnimateReadOnly = false;
            this.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPin.Depth = 0;
            this.txtPin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPin.Hint = "Введите PIN";
            this.txtPin.LeadingIcon = null;
            this.txtPin.Location = new System.Drawing.Point(266, 155);
            this.txtPin.Margin = new System.Windows.Forms.Padding(2);
            this.txtPin.MaxLength = 50;
            this.txtPin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPin.Multiline = false;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(290, 50);
            this.txtPin.TabIndex = 0;
            this.txtPin.Text = "";
            this.txtPin.TrailingIcon = null;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(561, 162);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(71, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Найти";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(15, 27);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "ФИО:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Depth = 0;
            this.lblGender.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGender.Location = new System.Drawing.Point(15, 74);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(34, 19);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Пол:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthDate.Depth = 0;
            this.lblBirthDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBirthDate.Location = new System.Drawing.Point(15, 125);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(122, 19);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Дата рождения:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Depth = 0;
            this.lblResult.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblResult.Location = new System.Drawing.Point(14, 216);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(1, 0);
            this.lblResult.TabIndex = 5;
            // 
            // btnSupport
            // 
            this.btnSupport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSupport.Depth = 0;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.HighEmphasis = true;
            this.btnSupport.Icon = null;
            this.btnSupport.Location = new System.Drawing.Point(49, 548);
            this.btnSupport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSupport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSupport.Size = new System.Drawing.Size(115, 36);
            this.btnSupport.TabIndex = 6;
            this.btnSupport.Text = "Поддержка";
            this.btnSupport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSupport.UseAccentColor = false;
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.White;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(714, 548);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(187, 36);
            this.materialButton1.TabIndex = 14;
            this.materialButton1.Text = "Следущая страница ";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblBirthDate);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Location = new System.Drawing.Point(266, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 214);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(906, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtPin;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblGender;
        private MaterialSkin.Controls.MaterialLabel lblBirthDate;
        private MaterialSkin.Controls.MaterialLabel lblResult;
        private MaterialSkin.Controls.MaterialButton btnSupport;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Panel panel1;
    }
}

