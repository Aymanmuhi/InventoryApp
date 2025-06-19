using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MaterialSkin;
using MaterialSkin.Controls;
using InventoryApp.UI;

namespace InventoryApp
{
    public partial class MainLayout : MaterialForm
    {
        public MainLayout(){
            InitializeComponent();
            InitializeMaterialSkin();

            Products productsDesign = new Products();
            Products_MenuBtn.Controls.Add(productsDesign);

        }
        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // or DARK

            // Optional: Custom color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan600,
                Primary.Cyan700,
                Primary.Cyan200,
                Accent.Cyan700,
                TextShade.WHITE
                );
        }
        private void ThemeChanger()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

  


        // end -------
    }
}
