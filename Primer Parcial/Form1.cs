using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Primer_Parcial
{
    public partial class Form1 : Form
    {
        List<Alumnos> alumnos = new List<Alumnos>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarEmpleado()
        {
            FileStream stream = new FileStream("Alumnos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)

            {
                Alumnos alumno = new Alumnos();
                alumno.carne = Convert.ToInt16(reader.ReadLine());
                alumno.nombre = reader.ReadLine();
                

                alumnos.Add(alumno);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
