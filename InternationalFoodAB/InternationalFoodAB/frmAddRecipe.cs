using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalFoodAB
{
    public partial class frmAddRecipe : Form
    {
        public Recipe NewRecipe { get; set; }
        public frmAddRecipe()
        {
            InitializeComponent();
        }
    }
}
