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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Name");
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.product_name_field = new MaterialSkin.Controls.MaterialTextBox();
            this.product_add_btn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.materialListView1.Location = new System.Drawing.Point(106, 145);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(272, 117);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // product_name_field
            // 
            this.product_name_field.AnimateReadOnly = false;
            this.product_name_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_name_field.Depth = 0;
            this.product_name_field.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.product_name_field.LeadingIcon = null;
            this.product_name_field.Location = new System.Drawing.Point(106, 89);
            this.product_name_field.MaxLength = 50;
            this.product_name_field.MouseState = MaterialSkin.MouseState.OUT;
            this.product_name_field.Multiline = false;
            this.product_name_field.Name = "product_name_field";
            this.product_name_field.Size = new System.Drawing.Size(171, 50);
            this.product_name_field.TabIndex = 1;
            this.product_name_field.Text = "Product name";
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
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.product_add_btn);
            this.Controls.Add(this.product_name_field);
            this.Controls.Add(this.materialListView1);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(541, 318);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialTextBox product_name_field;
        private MaterialSkin.Controls.MaterialButton product_add_btn;
    }
}
