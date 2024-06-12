using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informacion_personal_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Boton Llenar datos
        private void btnllenar_Click(object sender, EventArgs e)
        {
            //Try/catch para evitar que hayan errores en el programa
            try//Si no hay errores 
            {

                //Declaracion de variables
                //La info de los txt, cmb, dtp o rb se almacenaran en variables
                String ID = txtid.Text; //Identidad como cadena
                String Nombres = txtnombres.Text; //Nombres como cadena
                String Apellidos = txtapellidos.Text; //Apellidos como cadena
                String Fecha = dtpfechaNa.Text; //Fecha como cadena
                String Email = txtemail.Text; //Email como cadena
                String Telefono = txttelefono.Text; //Telefono comocadena
                String Departamento = cmbdepart.Text;//Departamento como cadena
                String EstadoCivil = ""; //Variable estado civil como cadena

                //Condicion Si alguno de los campos esta vacio
                if (ID == "")//Si el campo "Identidad" esta vacio, se pedira que llene el campo
                {
                    MessageBox.Show("Porfavor agregar su identidad", "Datos personales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Nombres == "")//Si el campo "Nombres" esta vacio, se pedira que llene el campo
                {
                    MessageBox.Show("Porfavor agregar sus nombres", "Datos personales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Apellidos == "")//Si el campo "Apellidos" esta vacio, se pedira que llene el campo
                {
                    MessageBox.Show("Porfavor agregar sus apellidos", "Datos personales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Email == "")//Si el campo "Email" esta vacio, se pedira que llene el campo
                {
                    MessageBox.Show("Porfavor agregar su email", "Datos personales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Telefono == "")//Si el campo "Telefono" esta vacio, se pedira que llene el campo
                {
                    MessageBox.Show("Porfavor agregar su numero de telefono", "Datos personales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Departamento == "")//Si el campo "Departamento" esta vacio, se pedira que llene el campo
                {
                    MessageBox.Show("Porfavor agregar su departamento", "Datos personales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //Condicion Si un radio button es seleccionado
                else if (rbcasado.Checked) //Si se selecciono casado
                {
                    EstadoCivil = "Casado/a";//Se almacenara el texto Casado/a en la variable

                    //Se almacenara en la caja de lista la informacion que se lleno en los campos
                    ltmostrardatos.Text = "Identidad: \n" + ID + "\n Nombres: \n" + Nombres + "\n Apellidos: \n" +
                        Apellidos + "\n Fecha: \n" + Fecha + "\n Email: \n" + Email + "\n Telefono: \n" +
                        Telefono + "\n Departamento: \n" + Departamento + "\n Estado Civil: \n" + EstadoCivil;
                    MensajeLlenardatos();
                }
                else if (rbsoltero.Checked) //Si se selecciono soltero
                {
                    EstadoCivil = "Soltero/a";//Se almacenara el texto Soltero/a en la variable

                    //Se almacenara en la caja de lista la informacion que se lleno en los campos
                    ltmostrardatos.Text = "Identidad: \n" + ID + "\n Nombres: \n" + Nombres + "\n Apellidos: \n" +
                        Apellidos + "\n Fecha: \n" + Fecha + "\n Email: \n" + Email + "\n Telefono: \n" +
                        Telefono + "\n Departamento: \n" + Departamento + "\n Estado Civil: \n" + EstadoCivil;
                    MensajeLlenardatos();
                }
                else if (rbdivorciado.Checked) //Si se selecciono divorciado
                {
                    EstadoCivil = "Divorciado/a";//Se almacenara el texto Divorciado/a en la variable

                    //Se almacenara en la caja de lista la informacion que se lleno en los campos
                    ltmostrardatos.Text = "Identidad: \n" + ID + "\n Nombres: \n" + Nombres + "\n Apellidos: \n" +
                        Apellidos + "\n Fecha: \n" + Fecha + "\n Email: \n" + Email + "\n Telefono: \n" +
                        Telefono + "\n Departamento: \n" + Departamento + "\n Estado Civil: \n" + EstadoCivil;
                    MensajeLlenardatos();
                }
                else if (rbviudo.Checked) //Si se selecciono viudo
                {
                    EstadoCivil = "Viudo/a";//Se almacenara el texto Viudo/a en la variable

                    //Se almacenara en la caja de lista la informacion que se lleno en los campos
                    ltmostrardatos.Text = "Identidad: \n" + ID + "\n Nombres: \n" + Nombres + "\n Apellidos: \n" +
                        Apellidos + "\n Fecha: \n" + Fecha + "\n Email: \n" + Email + "\n Telefono: \n" +
                        Telefono + "\n Departamento: \n" + Departamento + "\n Estado Civil: \n" + EstadoCivil;
                    MensajeLlenardatos();


                }
                else//Si no esta seleccionado
                {

                    //Enviara un mensaje en el cual el usuario debe seleccionar el usuario
                    MessageBox.Show("Porfavor seleccionar su estado civil", "Datos personales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            catch(Exception ex)//Si hay errores al correr el programa
            {
                //Se le notifica al usuario que no puede correr el programa
                MessageBox.Show("Error al correr el programa!","Datos Personales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
                



        }

        //Metodo para validar que solo numeros se ingresen a un campo
        private void ValidacionNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Metodo para validar que solo letras y espacios se ingresen a un campo
        private void ValidacionLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombres_TextChanged(object sender, EventArgs e)
        {

        }


        //Validaciones en los campos-------------------------------------------
        //Validacion campo Identidad
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e);//Llama el metodo solo numeros
        }

        //Validacion campo Nombres
        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionLetras(e); //Llama el metodo solo letras
        }

        //Validacion campo Apellidos
        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionLetras(e); //Llama el metodo solo letras
        }

        //Campo Email
        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No hay validacion en este campo
        }

        //Validacion campo Telefono
        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e); //Llama el metodo solo numeros
        }

        //Boton borrar
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtemail.Text = "";
            txttelefono.Text = "";
            cmbdepart.Text = null;
            rbcasado.Checked = false;
            rbdivorciado.Checked = false;
            rbsoltero.Checked = false;
            rbviudo.Checked = false;
            ltmostrardatos.Text = "";
            //Mensaje al borrar los datos de los campos
            MessageBox.Show("Se han borrado los campos!", "Datos Personales", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Metodo notificacion despues de llenar los datos
        private void MensajeLlenardatos()
        {
            //Mensaje al agregar los datos
            MessageBox.Show("Se han agregado los datos correctamente!", "Datos Personales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
