namespace WindowsFormsApplication1
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.autorBox = new System.Windows.Forms.TextBox();
            this.idlab = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(58, 511);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 35);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(74, 275);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(148, 26);
            this.idBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(74, 311);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(148, 26);
            this.nameBox.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(180, 511);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(302, 511);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(684, 55);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 35);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(579, 511);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(440, 511);
            this.btnConf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(112, 35);
            this.btnConf.TabIndex = 10;
            this.btnConf.Text = "Confirm";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(74, 393);
            this.priceBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(148, 26);
            this.priceBox.TabIndex = 11;
            this.priceBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // autorBox
            // 
            this.autorBox.Location = new System.Drawing.Point(74, 357);
            this.autorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autorBox.Name = "autorBox";
            this.autorBox.Size = new System.Drawing.Size(148, 26);
            this.autorBox.TabIndex = 12;
            // 
            // idlab
            // 
            this.idlab.AutoSize = true;
            this.idlab.Location = new System.Drawing.Point(21, 281);
            this.idlab.Name = "idlab";
            this.idlab.Size = new System.Drawing.Size(26, 20);
            this.idlab.TabIndex = 13;
            this.idlab.Text = "ID";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(16, 399);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(43, 20);
            this.price.TabIndex = 14;
            this.price.Text = "price";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(16, 363);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(46, 20);
            this.autor.TabIndex = 15;
            this.autor.Text = "autor";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(16, 317);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 20);
            this.name.TabIndex = 16;
            this.name.Text = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 585);
            this.Controls.Add(this.name);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.price);
            this.Controls.Add(this.idlab);
            this.Controls.Add(this.autorBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.btnInsert);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox autorBox;
        private System.Windows.Forms.Label idlab;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label name;
    }
}

