namespace OrderToevoegenToepassing
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
            this.OrderFormulierLabel = new System.Windows.Forms.Label();
            this.KlantenComboBox = new System.Windows.Forms.ComboBox();
            this.KlantLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductenComboBox = new System.Windows.Forms.ComboBox();
            this.AantalLabel = new System.Windows.Forms.Label();
            this.AantalNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.VoegOrderToeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AantalNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormulierLabel
            // 
            this.OrderFormulierLabel.AutoSize = true;
            this.OrderFormulierLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormulierLabel.Location = new System.Drawing.Point(77, 22);
            this.OrderFormulierLabel.Name = "OrderFormulierLabel";
            this.OrderFormulierLabel.Size = new System.Drawing.Size(166, 18);
            this.OrderFormulierLabel.TabIndex = 0;
            this.OrderFormulierLabel.Text = "ORDER FORMULIER";
            // 
            // KlantenComboBox
            // 
            this.KlantenComboBox.FormattingEnabled = true;
            this.KlantenComboBox.Location = new System.Drawing.Point(102, 65);
            this.KlantenComboBox.Name = "KlantenComboBox";
            this.KlantenComboBox.Size = new System.Drawing.Size(199, 21);
            this.KlantenComboBox.TabIndex = 1;
            this.KlantenComboBox.SelectedIndexChanged += new System.EventHandler(this.KlantenComboBox_SelectedIndexChanged);
            // 
            // KlantLabel
            // 
            this.KlantLabel.AutoSize = true;
            this.KlantLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KlantLabel.Location = new System.Drawing.Point(23, 66);
            this.KlantLabel.Name = "KlantLabel";
            this.KlantLabel.Size = new System.Drawing.Size(52, 18);
            this.KlantLabel.TabIndex = 2;
            this.KlantLabel.Text = "Klant:";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(23, 111);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(72, 18);
            this.ProductLabel.TabIndex = 3;
            this.ProductLabel.Text = "Product:";
            // 
            // ProductenComboBox
            // 
            this.ProductenComboBox.FormattingEnabled = true;
            this.ProductenComboBox.Location = new System.Drawing.Point(102, 110);
            this.ProductenComboBox.Name = "ProductenComboBox";
            this.ProductenComboBox.Size = new System.Drawing.Size(199, 21);
            this.ProductenComboBox.TabIndex = 4;
            this.ProductenComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductenComboBox_SelectedIndexChanged);
            // 
            // AantalLabel
            // 
            this.AantalLabel.AutoSize = true;
            this.AantalLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AantalLabel.Location = new System.Drawing.Point(23, 159);
            this.AantalLabel.Name = "AantalLabel";
            this.AantalLabel.Size = new System.Drawing.Size(61, 18);
            this.AantalLabel.TabIndex = 5;
            this.AantalLabel.Text = "Aantal:";
            // 
            // AantalNumUpDown
            // 
            this.AantalNumUpDown.Location = new System.Drawing.Point(102, 158);
            this.AantalNumUpDown.Name = "AantalNumUpDown";
            this.AantalNumUpDown.Size = new System.Drawing.Size(72, 20);
            this.AantalNumUpDown.TabIndex = 6;
            this.AantalNumUpDown.ValueChanged += new System.EventHandler(this.AantalNumUpDown_ValueChanged);
            // 
            // VoegOrderToeBtn
            // 
            this.VoegOrderToeBtn.Location = new System.Drawing.Point(26, 202);
            this.VoegOrderToeBtn.Name = "VoegOrderToeBtn";
            this.VoegOrderToeBtn.Size = new System.Drawing.Size(275, 38);
            this.VoegOrderToeBtn.TabIndex = 7;
            this.VoegOrderToeBtn.Text = "Voeg Order Toe";
            this.VoegOrderToeBtn.UseVisualStyleBackColor = true;
            this.VoegOrderToeBtn.Click += new System.EventHandler(this.VoegOrderToeBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 248);
            this.Controls.Add(this.VoegOrderToeBtn);
            this.Controls.Add(this.AantalNumUpDown);
            this.Controls.Add(this.AantalLabel);
            this.Controls.Add(this.ProductenComboBox);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.KlantLabel);
            this.Controls.Add(this.KlantenComboBox);
            this.Controls.Add(this.OrderFormulierLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.AantalNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderFormulierLabel;
        private System.Windows.Forms.ComboBox KlantenComboBox;
        private System.Windows.Forms.Label KlantLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.ComboBox ProductenComboBox;
        private System.Windows.Forms.Label AantalLabel;
        private System.Windows.Forms.NumericUpDown AantalNumUpDown;
        private System.Windows.Forms.Button VoegOrderToeBtn;
    }
}