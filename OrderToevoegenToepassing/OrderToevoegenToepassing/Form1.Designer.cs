namespace OrderToevoegenToepassing
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
            this.OrderToevoegenBtn = new System.Windows.Forms.Button();
            this.DatabasesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OrderToevoegenBtn
            // 
            this.OrderToevoegenBtn.Location = new System.Drawing.Point(32, 41);
            this.OrderToevoegenBtn.Name = "OrderToevoegenBtn";
            this.OrderToevoegenBtn.Size = new System.Drawing.Size(244, 110);
            this.OrderToevoegenBtn.TabIndex = 0;
            this.OrderToevoegenBtn.Text = "ORDER TOEVOEGEN";
            this.OrderToevoegenBtn.UseVisualStyleBackColor = true;
            this.OrderToevoegenBtn.Click += new System.EventHandler(this.OrderToevoegenBtn_Click);
            // 
            // DatabasesComboBox
            // 
            this.DatabasesComboBox.FormattingEnabled = true;
            this.DatabasesComboBox.Location = new System.Drawing.Point(32, 13);
            this.DatabasesComboBox.Name = "DatabasesComboBox";
            this.DatabasesComboBox.Size = new System.Drawing.Size(244, 21);
            this.DatabasesComboBox.TabIndex = 1;
            this.DatabasesComboBox.SelectedIndexChanged += new System.EventHandler(this.DatabasesComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 163);
            this.Controls.Add(this.DatabasesComboBox);
            this.Controls.Add(this.OrderToevoegenBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrderToevoegenBtn;
        private System.Windows.Forms.ComboBox DatabasesComboBox;
    }
}

