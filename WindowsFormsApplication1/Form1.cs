using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuaInterface;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Lua lua = new Lua();

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form = new Form1();
                lua.RegisterFunction("cout", form, form.GetType().GetMethod("cout"));
                lua.RegisterFunction("agregar", form, form.GetType().GetMethod("agregar"));
                lua.DoString(txtBox.Text);
            }
            catch (Exception ex)
            {

            }
        }

        public void cout (string cadena){
            MessageBox.Show(cadena);
        }

        public string agregar(string nombre, string edad) {
            int numvalue;
            string rtn = "";
            try
            {
                if(nombre.Length <= 0)
                {
                    rtn = "Error. El campo nombre no fue llenado";
                    throw new Exception();
                }
                if (edad.Length <= 0)
                {
                    rtn = "Error. El campo edad no fue llenado";
                    throw new Exception();
                }
                rtn = "Error. Ingreso letras u otras cosas en ves de numeros en edad";
                numvalue = Int32.Parse(edad);
                rtn = nombre + " tiene " + edad + " años";
                return rtn;
            }
            catch
            {
                return rtn;
            }
        }
    }
}
