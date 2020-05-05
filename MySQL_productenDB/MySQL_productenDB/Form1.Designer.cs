namespace MySQL_productenDB
{
    partial class MySQLApp
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
            this.TabPages = new System.Windows.Forms.TabControl();
            this.VerbindingTesten = new System.Windows.Forms.TabPage();
            this.btnSluitMySql = new System.Windows.Forms.Button();
            this.btnOpenMySql = new System.Windows.Forms.Button();
            this.ComboBoxSQLConnecties = new System.Windows.Forms.ComboBox();
            this.UitlezenTabelOrders = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnConnectAndClose = new System.Windows.Forms.Button();
            this.ToevoegenProduct = new System.Windows.Forms.TabPage();
            this.ProductStockTextBox = new System.Windows.Forms.TextBox();
            this.ProductNaamTextBox = new System.Windows.Forms.TextBox();
            this.VoegProductToe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VerwijderProductBtn = new System.Windows.Forms.Button();
            this.LeesTabelProducten = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.ProductIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNaamCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStockCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPages.SuspendLayout();
            this.VerbindingTesten.SuspendLayout();
            this.UitlezenTabelOrders.SuspendLayout();
            this.ToevoegenProduct.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPages
            // 
            this.TabPages.Controls.Add(this.VerbindingTesten);
            this.TabPages.Controls.Add(this.UitlezenTabelOrders);
            this.TabPages.Controls.Add(this.ToevoegenProduct);
            this.TabPages.Controls.Add(this.tabPage1);
            this.TabPages.Location = new System.Drawing.Point(13, 13);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedIndex = 0;
            this.TabPages.Size = new System.Drawing.Size(775, 319);
            this.TabPages.TabIndex = 0;
            // 
            // VerbindingTesten
            // 
            this.VerbindingTesten.Controls.Add(this.btnSluitMySql);
            this.VerbindingTesten.Controls.Add(this.btnOpenMySql);
            this.VerbindingTesten.Controls.Add(this.ComboBoxSQLConnecties);
            this.VerbindingTesten.Location = new System.Drawing.Point(4, 22);
            this.VerbindingTesten.Name = "VerbindingTesten";
            this.VerbindingTesten.Padding = new System.Windows.Forms.Padding(3);
            this.VerbindingTesten.Size = new System.Drawing.Size(767, 293);
            this.VerbindingTesten.TabIndex = 0;
            this.VerbindingTesten.Text = "VerbindingTesten";
            this.VerbindingTesten.UseVisualStyleBackColor = true;
            // 
            // btnSluitMySql
            // 
            this.btnSluitMySql.Location = new System.Drawing.Point(286, 172);
            this.btnSluitMySql.Name = "btnSluitMySql";
            this.btnSluitMySql.Size = new System.Drawing.Size(195, 47);
            this.btnSluitMySql.TabIndex = 2;
            this.btnSluitMySql.Text = "Sluit MySQL Verbinding";
            this.btnSluitMySql.UseVisualStyleBackColor = true;
            this.btnSluitMySql.Click += new System.EventHandler(this.BtnSluitMySql_Click);
            // 
            // btnOpenMySql
            // 
            this.btnOpenMySql.Location = new System.Drawing.Point(286, 119);
            this.btnOpenMySql.Name = "btnOpenMySql";
            this.btnOpenMySql.Size = new System.Drawing.Size(195, 47);
            this.btnOpenMySql.TabIndex = 1;
            this.btnOpenMySql.Text = "Open MySQL Verbinding";
            this.btnOpenMySql.UseVisualStyleBackColor = true;
            this.btnOpenMySql.Click += new System.EventHandler(this.BtnOpenMySql_Click);
            // 
            // ComboBoxSQLConnecties
            // 
            this.ComboBoxSQLConnecties.DisplayMember = "(none)";
            this.ComboBoxSQLConnecties.FormattingEnabled = true;
            this.ComboBoxSQLConnecties.Location = new System.Drawing.Point(260, 92);
            this.ComboBoxSQLConnecties.Name = "ComboBoxSQLConnecties";
            this.ComboBoxSQLConnecties.Size = new System.Drawing.Size(247, 21);
            this.ComboBoxSQLConnecties.TabIndex = 0;
            this.ComboBoxSQLConnecties.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSQLConnecties_SelectedIndexChanged);
            // 
            // UitlezenTabelOrders
            // 
            this.UitlezenTabelOrders.Controls.Add(this.textBox1);
            this.UitlezenTabelOrders.Controls.Add(this.BtnConnectAndClose);
            this.UitlezenTabelOrders.Location = new System.Drawing.Point(4, 22);
            this.UitlezenTabelOrders.Name = "UitlezenTabelOrders";
            this.UitlezenTabelOrders.Padding = new System.Windows.Forms.Padding(3);
            this.UitlezenTabelOrders.Size = new System.Drawing.Size(767, 293);
            this.UitlezenTabelOrders.TabIndex = 1;
            this.UitlezenTabelOrders.Text = "Uitlezen Tabel Orders";
            this.UitlezenTabelOrders.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(543, 153);
            this.textBox1.TabIndex = 3;
            // 
            // BtnConnectAndClose
            // 
            this.BtnConnectAndClose.Location = new System.Drawing.Point(6, 240);
            this.BtnConnectAndClose.Name = "BtnConnectAndClose";
            this.BtnConnectAndClose.Size = new System.Drawing.Size(195, 47);
            this.BtnConnectAndClose.TabIndex = 2;
            this.BtnConnectAndClose.Text = "Laad Bestellingslijst";
            this.BtnConnectAndClose.UseVisualStyleBackColor = true;
            this.BtnConnectAndClose.Click += new System.EventHandler(this.LaadBestellingen_click);
            // 
            // ToevoegenProduct
            // 
            this.ToevoegenProduct.Controls.Add(this.ProductStockTextBox);
            this.ToevoegenProduct.Controls.Add(this.ProductNaamTextBox);
            this.ToevoegenProduct.Controls.Add(this.VoegProductToe);
            this.ToevoegenProduct.Controls.Add(this.label2);
            this.ToevoegenProduct.Controls.Add(this.label1);
            this.ToevoegenProduct.Location = new System.Drawing.Point(4, 22);
            this.ToevoegenProduct.Name = "ToevoegenProduct";
            this.ToevoegenProduct.Size = new System.Drawing.Size(767, 293);
            this.ToevoegenProduct.TabIndex = 2;
            this.ToevoegenProduct.Text = "Toevoegen  Product";
            this.ToevoegenProduct.UseVisualStyleBackColor = true;
            // 
            // ProductStockTextBox
            // 
            this.ProductStockTextBox.Location = new System.Drawing.Point(302, 115);
            this.ProductStockTextBox.Name = "ProductStockTextBox";
            this.ProductStockTextBox.Size = new System.Drawing.Size(257, 20);
            this.ProductStockTextBox.TabIndex = 4;
            // 
            // ProductNaamTextBox
            // 
            this.ProductNaamTextBox.Location = new System.Drawing.Point(302, 77);
            this.ProductNaamTextBox.Name = "ProductNaamTextBox";
            this.ProductNaamTextBox.Size = new System.Drawing.Size(257, 20);
            this.ProductNaamTextBox.TabIndex = 3;
            // 
            // VoegProductToe
            // 
            this.VoegProductToe.Location = new System.Drawing.Point(335, 151);
            this.VoegProductToe.Name = "VoegProductToe";
            this.VoegProductToe.Size = new System.Drawing.Size(192, 49);
            this.VoegProductToe.TabIndex = 2;
            this.VoegProductToe.Text = "Voeg Product Toe";
            this.VoegProductToe.UseVisualStyleBackColor = true;
            this.VoegProductToe.Click += new System.EventHandler(this.VoegProductToe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Productstock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productnaam:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.VerwijderProductBtn);
            this.tabPage1.Controls.Add(this.LeesTabelProducten);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(767, 293);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Beheer Tabel Producten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDCol,
            this.ProductNaamCol,
            this.ProductStockCol,
            this.ProductAvailable});
            this.dataGridView1.Location = new System.Drawing.Point(173, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(441, 211);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // VerwijderProductBtn
            // 
            this.VerwijderProductBtn.Location = new System.Drawing.Point(390, 243);
            this.VerwijderProductBtn.Name = "VerwijderProductBtn";
            this.VerwijderProductBtn.Size = new System.Drawing.Size(374, 47);
            this.VerwijderProductBtn.TabIndex = 1;
            this.VerwijderProductBtn.Text = "Verwijder Product";
            this.VerwijderProductBtn.UseVisualStyleBackColor = true;
            this.VerwijderProductBtn.Click += new System.EventHandler(this.VerwijderProductBtn_Click);
            // 
            // LeesTabelProducten
            // 
            this.LeesTabelProducten.Location = new System.Drawing.Point(3, 243);
            this.LeesTabelProducten.Name = "LeesTabelProducten";
            this.LeesTabelProducten.Size = new System.Drawing.Size(381, 47);
            this.LeesTabelProducten.TabIndex = 0;
            this.LeesTabelProducten.Text = "Lees Tabel Producten";
            this.LeesTabelProducten.UseVisualStyleBackColor = true;
            this.LeesTabelProducten.Click += new System.EventHandler(this.LeesTabelProducten_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConnectionStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(13, 339);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(771, 24);
            this.ConnectionStatusLabel.TabIndex = 1;
            this.ConnectionStatusLabel.Text = "CONNECTION STATUS:";
            this.ConnectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductIDCol
            // 
            this.ProductIDCol.HeaderText = "ProductID";
            this.ProductIDCol.Name = "ProductIDCol";
            this.ProductIDCol.ReadOnly = true;
            // 
            // ProductNaamCol
            // 
            this.ProductNaamCol.HeaderText = "ProductNaam";
            this.ProductNaamCol.Name = "ProductNaamCol";
            this.ProductNaamCol.ReadOnly = true;
            // 
            // ProductStockCol
            // 
            this.ProductStockCol.HeaderText = "ProductStock";
            this.ProductStockCol.Name = "ProductStockCol";
            this.ProductStockCol.ReadOnly = true;
            // 
            // ProductAvailable
            // 
            this.ProductAvailable.HeaderText = "ProductAvailable";
            this.ProductAvailable.Name = "ProductAvailable";
            this.ProductAvailable.ReadOnly = true;
            // 
            // MySQLApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.TabPages);
            this.Name = "MySQLApp";
            this.Text = "MySQLApplication";
            this.TabPages.ResumeLayout(false);
            this.VerbindingTesten.ResumeLayout(false);
            this.UitlezenTabelOrders.ResumeLayout(false);
            this.UitlezenTabelOrders.PerformLayout();
            this.ToevoegenProduct.ResumeLayout(false);
            this.ToevoegenProduct.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPages;
        private System.Windows.Forms.TabPage VerbindingTesten;
        private System.Windows.Forms.Button btnOpenMySql;
        private System.Windows.Forms.ComboBox ComboBoxSQLConnecties;
        private System.Windows.Forms.TabPage UitlezenTabelOrders;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Button btnSluitMySql;
        private System.Windows.Forms.Button BtnConnectAndClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage ToevoegenProduct;
        private System.Windows.Forms.TextBox ProductStockTextBox;
        private System.Windows.Forms.TextBox ProductNaamTextBox;
        private System.Windows.Forms.Button VoegProductToe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button VerwijderProductBtn;
        private System.Windows.Forms.Button LeesTabelProducten;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNaamCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductStockCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAvailable;
    }
}

