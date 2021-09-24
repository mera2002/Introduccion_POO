using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduccion_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // CREAMOS LA INSTANCIA DE LA CLASE AUTOBUS 
            Autobus autobus = new Autobus();



            //creamos un objeto 
            autobus.setCod(1);
            autobus.setName("Milagrito ");
            autobus.setNumber(304);
            autobus.setAmount(120);

            autobus._Color = "rojo y negro ";

            //mostrar los datos de autobus 
         /*   MessageBox.Show(

                "\nCOD: " + autobus.getCod() +
                "\nNombre " + autobus.getName() +
                "\nNumero de ruta " + autobus.getNumber() +
                "\nAsientos disponible" + autobus.getAmount()+
                "\nColor " + autobus.Color
                );*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // utilizando contructor vacio 
            Autobus autobus = new Autobus();
            autobus.setCod(Convert.ToInt32(txtCod.Text)); 
            autobus.setName(txtName.Text);
            autobus.setNumber(Convert.ToInt32(txtNumber.Text));
            autobus.setAmount(Convert.ToInt32(txtcanti.Text));
            autobus._Color = txtcolor.Text;

            // agregar los datos a lisbox 
            
            listAutobusInfo.Items.Add("Mediante conturctor vacio: " + autobus.getAutobusInfo());
         








        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
