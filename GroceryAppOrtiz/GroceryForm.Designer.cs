namespace GroceryAppOrtiz
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtGrocery = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.LIstGroceries = new System.Windows.Forms.ListBox();
            this.btnViewSaved = new System.Windows.Forms.Button();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.ForeColor = System.Drawing.Color.Black;
            this.lblPrompt.Location = new System.Drawing.Point(331, 153);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(168, 21);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter Grocery item >";
            this.lblPrompt.Click += new System.EventHandler(this.lblPrompt_Click);
            // 
            // txtGrocery
            // 
            this.txtGrocery.BackColor = System.Drawing.Color.White;
            this.txtGrocery.ForeColor = System.Drawing.Color.Black;
            this.txtGrocery.Location = new System.Drawing.Point(506, 153);
            this.txtGrocery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrocery.Name = "txtGrocery";
            this.txtGrocery.Size = new System.Drawing.Size(116, 25);
            this.txtGrocery.TabIndex = 1;
            this.txtGrocery.TextChanged += new System.EventHandler(this.txtGrocery_TextChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.Location = new System.Drawing.Point(364, 196);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(107, 30);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            this.btnAddItem.MouseEnter += new System.EventHandler(this.btnAddItem_MouseEnter);
            this.btnAddItem.MouseLeave += new System.EventHandler(this.btnAddItem_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(364, 389);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save To JSON";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LIstGroceries
            // 
            this.LIstGroceries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LIstGroceries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LIstGroceries.ForeColor = System.Drawing.Color.Black;
            this.LIstGroceries.FormattingEnabled = true;
            this.LIstGroceries.ItemHeight = 17;
            this.LIstGroceries.Location = new System.Drawing.Point(284, 243);
            this.LIstGroceries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LIstGroceries.Name = "LIstGroceries";
            this.LIstGroceries.Size = new System.Drawing.Size(250, 138);
            this.LIstGroceries.TabIndex = 4;
            this.LIstGroceries.SelectedIndexChanged += new System.EventHandler(this.lstGroceries_SelectedIndexChanged);
            // 
            // btnViewSaved
            // 
            this.btnViewSaved.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewSaved.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSaved.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSaved.ForeColor = System.Drawing.Color.Black;
            this.btnViewSaved.Location = new System.Drawing.Point(542, 295);
            this.btnViewSaved.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewSaved.Name = "btnViewSaved";
            this.btnViewSaved.Size = new System.Drawing.Size(121, 30);
            this.btnViewSaved.TabIndex = 5;
            this.btnViewSaved.Text = "View Saved List";
            this.btnViewSaved.UseVisualStyleBackColor = false;
            this.btnViewSaved.Click += new System.EventHandler(this.btnViewSaved_Click);
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = global::GroceryAppOrtiz.Properties.Resources.shopping_cart_icon_515;
            this.PictureLogo.Location = new System.Drawing.Point(12, 12);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(50, 42);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogo.TabIndex = 6;
            this.PictureLogo.TabStop = false;
            this.PictureLogo.Click += new System.EventHandler(this.PictureLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grocery List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureLogo);
            this.Controls.Add(this.btnViewSaved);
            this.Controls.Add(this.LIstGroceries);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtGrocery);
            this.Controls.Add(this.lblPrompt);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Grocery List ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtGrocery;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox LIstGroceries;
        private System.Windows.Forms.Button btnViewSaved;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Label label1;
    }
}

