namespace InventoryApp.UI
{
    partial class Products
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.products_table = new MaterialSkin.Controls.MaterialListView();
            this.product_name_field = new MaterialSkin.Controls.MaterialTextBox();
            this.product_add_btn = new MaterialSkin.Controls.MaterialButton();
            this.product_name_label = new MaterialSkin.Controls.MaterialLabel();
            this.columnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // products_table
            // 
            this.products_table.AutoSizeTable = false;
            this.products_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.products_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.products_table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPID,
            this.columnPName});
            this.products_table.Depth = 0;
            this.products_table.FullRowSelect = true;
            this.products_table.Location = new System.Drawing.Point(106, 145);
            this.products_table.MinimumSize = new System.Drawing.Size(200, 100);
            this.products_table.MouseLocation = new System.Drawing.Point(-1, -1);
            this.products_table.MouseState = MaterialSkin.MouseState.OUT;
            this.products_table.Name = "products_table";
            this.products_table.OwnerDraw = true;
            this.products_table.Size = new System.Drawing.Size(377, 119);
            this.products_table.TabIndex = 0;
            this.products_table.UseCompatibleStateImageBehavior = false;
            this.products_table.View = System.Windows.Forms.View.Details;
            // 
            // product_name_field
            // 
            this.product_name_field.AnimateReadOnly = false;
            this.product_name_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_name_field.Depth = 0;
            this.product_name_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.product_name_field.LeadingIcon = null;
            this.product_name_field.Location = new System.Drawing.Point(106, 89);
            this.product_name_field.MaxLength = 50;
            this.product_name_field.MouseState = MaterialSkin.MouseState.OUT;
            this.product_name_field.Multiline = false;
            this.product_name_field.Name = "product_name_field";
            this.product_name_field.Size = new System.Drawing.Size(171, 50);
            this.product_name_field.TabIndex = 1;
            this.product_name_field.Text = "";
            this.product_name_field.TrailingIcon = null;
            // 
            // product_add_btn
            // 
            this.product_add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.product_add_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.product_add_btn.Depth = 0;
            this.product_add_btn.HighEmphasis = true;
            this.product_add_btn.Icon = null;
            this.product_add_btn.Location = new System.Drawing.Point(314, 100);
            this.product_add_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.product_add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.product_add_btn.Name = "product_add_btn";
            this.product_add_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.product_add_btn.Size = new System.Drawing.Size(64, 36);
            this.product_add_btn.TabIndex = 2;
            this.product_add_btn.Text = "add";
            this.product_add_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.product_add_btn.UseAccentColor = false;
            this.product_add_btn.UseVisualStyleBackColor = true;
            this.product_add_btn.Click += new System.EventHandler(this.product_add_btn_Click);
            // 
            // product_name_label
            // 
            this.product_name_label.AutoSize = true;
            this.product_name_label.Depth = 0;
            this.product_name_label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.product_name_label.Location = new System.Drawing.Point(103, 67);
            this.product_name_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.product_name_label.Name = "product_name_label";
            this.product_name_label.Size = new System.Drawing.Size(100, 19);
            this.product_name_label.TabIndex = 3;
            this.product_name_label.Text = "Product name";
            // 
            // columnPID
            // 
            this.columnPID.Text = "ID";
            // 
            // columnPName
            // 
            this.columnPName.Text = "Name";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.product_name_label);
            this.Controls.Add(this.product_add_btn);
            this.Controls.Add(this.product_name_field);
            this.Controls.Add(this.products_table);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(541, 318);
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView products_table;
        private MaterialSkin.Controls.MaterialTextBox product_name_field;
        private MaterialSkin.Controls.MaterialButton product_add_btn;
        private MaterialSkin.Controls.MaterialLabel product_name_label;
        private System.Windows.Forms.ColumnHeader columnPID;
        private System.Windows.Forms.ColumnHeader columnPName;
    }
}
