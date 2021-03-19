using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1Progra3
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Libros> libros1 = new List<Libros>();
        List<Prestamo> prestamos = new List<Prestamo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardaralquiler(string fileName, int carnet, string codigo, string FechaPres, string FechaDev)
        {
            FileStream stream = new FileStream("Prestamos.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(carnet);
            writer.WriteLine(codigo);
            writer.WriteLine(FechaPres);
            writer.WriteLine(FechaDev);

            writer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Estudiantes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Estudiante estudiante = new Estudiante();
                estudiante.Carnet = Convert.ToInt32(reader.ReadLine());
                estudiante.Nombre = reader.ReadLine();
                estudiante.Direccion = reader.ReadLine();

                estudiantes.Add(estudiante);

            }
            reader.Close();

            FileStream stream2 = new FileStream("Libros.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);

            while (reader2.Peek() > -1)
            {
                Libros libros = new Libros();
                libros.Codigo = reader2.ReadLine();
                libros.Titulo = reader2.ReadLine();
                libros.Autor = reader2.ReadLine();
                libros.Publicacion = reader2.ReadLine();

                libros1.Add(libros);

            }
            reader2.Close();


            comboBoxCarnet.DisplayMember = "Carnet";
            comboBoxCarnet.ValueMember = "Carnet";
            comboBoxCarnet.DataSource = null;
            comboBoxCarnet.DataSource = estudiantes;

            comboBoxCodigo.DisplayMember = "Codigo";
            comboBoxCodigo.ValueMember = "Codigo";
            comboBoxCodigo.DataSource = null;
            comboBoxCodigo.DataSource = libros1;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (comboBoxCarnet.Text == "" && comboBoxCodigo.Text == "")
            {
                labelRPrestamo.Text = "Error en ingreso de Datos";
            }
            else
            {
                int a = Convert.ToInt32(comboBoxCarnet.Text);
                Guardaralquiler("Prestamos.txt", a, comboBoxCodigo.Text, DTPprestamo.Value.ToString(), DTPdevolucion.Value.ToString());
                labelRPrestamo.Text = "Datos Ingresados con Exito";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string finalFech = "";
            int count = 0;
            FileStream stream = new FileStream("Prestamos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Prestamo prestamo = new Prestamo();
                prestamo.Carnet = Convert.ToInt32(reader.ReadLine());
                prestamo.Codigo = reader.ReadLine();
                prestamo.FechaPre1 = Convert.ToDateTime(reader.ReadLine());
                prestamo.FechaDev1 = Convert.ToDateTime(reader.ReadLine());

                prestamos.Add(prestamo);

            }
            reader.Close();

            DGWprestamos.DataSource = null;
            DGWprestamos.DataSource = prestamos;
           

            for (int a =0; a<prestamos.Count;a++)
            {
               // prestamos[a].FechaDev1 = finalFech;
                count++;
            }

            //DateTime inicio = DateTime.Now;
            //DateTime final = Convert.ToDateTime(finalFech).Date;
            
            //if(final>inicio)
            //{
            //    labelRDev.Text = count.ToString();
            //}
        }
    }
}
