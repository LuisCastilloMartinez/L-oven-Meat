using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace L_oven_Meat
{
    public partial class LOGIN : KryptonForm
    {

        Login_code user1;
        Principal Principal;
        public LOGIN()
        {
            InitializeComponent();
            user1 = new Login_code();
            Principal = new Principal();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Ingresar 

            //Ingresar
            user1.User = txtUsername.Text;
            user1.Password = txtPass.Text;
            if (user1.User == "" && user1.Password == "")
            {
                MessageBox.Show("Ingresa un caracter valido", "ERROR");
            }
            else if (user1.User != "alex" || user1.Password != "200405")
            {
                MessageBox.Show("User or password is not the correct.Please try again", "ERROR");


            }
            else
            {
                this.Hide();
                Principal.ShowDialog();
            }
        }
    }
}
