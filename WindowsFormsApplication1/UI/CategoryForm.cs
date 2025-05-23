using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using InventoryApp.Models;
using InventoryApp.Services;

namespace InventoryApp.UI
{
    public partial class CategoryForm : MaterialForm
    {
        private MaterialTextBox txtName;
        private MaterialTextBox txtDesc;
        private MaterialButton btnAdd;
        private MaterialButton btnUpdate;
        private MaterialButton btnDelete;
        private DataGridView dgvCategories;

        private CategoryService _service = new CategoryService();
        private Category selectedCategory = null;

        public CategoryForm()
        {
            InitializeComponent();

            // Material Design theming
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );

            // Initialize UI controls
            SetupControls();

            // Events
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvCategories.CellClick += DgvCategories_CellClick;

            // Load data
            LoadCategories();
        }

        private void SetupControls()
        {
            txtName = new MaterialTextBox
            {
                Hint = "Category Name",
                Location = new System.Drawing.Point(20, 80),
                Width = 250
            };

            txtDesc = new MaterialTextBox
            {
                Hint = "Description",
                Location = new System.Drawing.Point(20, 150),
                Width = 250
            };

            btnAdd = new MaterialButton
            {
                Text = "Add",
                Location = new System.Drawing.Point(20, 220)
            };

            btnUpdate = new MaterialButton
            {
                Text = "Update",
                Location = new System.Drawing.Point(100, 220)
            };

            btnDelete = new MaterialButton
            {
                Text = "Delete",
                Location = new System.Drawing.Point(200, 220)
            };

            dgvCategories = new DataGridView
            {
                Location = new System.Drawing.Point(20, 230),
                Width = 500,
                Height = 200,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            this.Controls.Add(txtName);
            this.Controls.Add(txtDesc);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(dgvCategories);
        }

        private void LoadCategories()
        {
            dgvCategories.DataSource = _service.GetAll();
            dgvCategories.ClearSelection();
            selectedCategory = null;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var cat = new Category
            {
                Name = txtName.Text.Trim(),
                Desc = txtDesc.Text.Trim()
            };

            _service.Add(cat);
            LoadCategories();
            txtName.Text = txtDesc.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null) return;

            selectedCategory.Name = txtName.Text.Trim();
            selectedCategory.Desc = txtDesc.Text.Trim();
            _service.Update(selectedCategory);
            LoadCategories();
            txtName.Text = txtDesc.Text = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null) return;

            _service.Delete(selectedCategory.Id);
            LoadCategories();
            txtName.Text = txtDesc.Text = "";
        }

        private void DgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCategory = (Category)dgvCategories.Rows[e.RowIndex].DataBoundItem;
                txtName.Text = selectedCategory.Name;
                txtDesc.Text = selectedCategory.Desc;
            }
        }
    }
}
