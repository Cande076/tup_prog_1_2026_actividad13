using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad13
{
    public partial class FormPrincipal : Form
    {
        NumericService service= new NumericService();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            FormDatos fdatos= new FormDatos();

            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                int lu = Convert.ToInt32(fdatos.tbLU.Text);
                string nombre = fdatos.tbNombre.Text;
                double nota = Convert.ToDouble(fdatos.tbNota.Text);
                service.RegistrarAlumno(lu, nombre, nota);
            }
        }

        private void btnBuscarYVerAlumno_Click(object sender, EventArgs e)
        {
            int idx = -1;
            int lu = Convert.ToInt32(tbLU.Text);
            if (rbSecuencial.Checked)
            {
                idx = service.BuscarPorLUSecuencial(lu);
            }
            else if (rbBinaria.Checked)
            {
                idx = service.BuscarPorLUBinario(lu);
            }
            string resultado = "No se encontro";

            if (idx != -1)
            {
                Alumno a= service.VerAlumno(idx);
                resultado = $"Nombre: {a.Nombre}(LU:{a.LU}, Nota:{a.Nota})";
            }
            FormSalidas fSalidas = new FormSalidas();

            fSalidas.lsbListado.Items.Add(resultado);
            fSalidas.ShowDialog();
        }

        private void btnMostrarListadoOrdenado_Click(object sender, EventArgs e)
        {
            //primero evaluo cual metodo debo llamar:
            if (rbBurbuja.Checked)
            {
                service.OrdenarPorLUBurbuja();
            }
            else if (rbQuickSort.Checked)
            {
                service.OrdenarPorLUQuickSort(0, service.contador - 1);
            }
            else { MessageBox.Show("selecciona un metodo para completar esta accion"); }

            //creo la ventana modal a utilizar:
            FormSalidas formSalidas = new FormSalidas();

            //utilizo un bucle for para mostrar mi vector:
            for (int i = 0; i < service.contador; i++)
            {
                Alumno alumnodelvector = service.VerAlumno(i);//aca sacamos toda la informacion que tiene la clase 1 creada del vector de clases la cual contiene la informacion del primer alumno.
                string textoInformacion = $"LU: {alumnodelvector.LU} - Nombre: {alumnodelvector.Nombre} - Nota: {alumnodelvector.Nota}";//creo el texto con todos los datos que extraigo de la clase del alumno
                formSalidas.lsbListado.Items.Add(textoInformacion);//mandamos el texto al list box agregandolo con add.
            }
            formSalidas.ShowDialog();//disparamos la ventana como modal!
        }

        private void btnMayoresAlPromedio_Click(object sender, EventArgs e)
        {
            //utilizacion del out: 
            //1.Creamos la variable vacia que se envia al metodo
            int superan;
            //2.llamamos al metodo y le enviamos la variable vacia y nos devuelve el nuevo vector el cual tenemos que asignar es el "Filtrados"
            Alumno[] Filtrados = service.AlumnosQueSuperanElPromedio(out superan);
            //3.mostramos lo que devuelve nuestro metodo
            //creamos la ventana que usaremos para mostrar los datos:
            FormSalidas formSalidas = new FormSalidas();

            //creamos un for para sacar todos los datos del vector y utilizamos la variable creada que se modifico en el metodo para el for:
            for (int i = 0; i < superan; i++)
            {
                Alumno alumnoVector = Filtrados[i];
                //ingresamos los datos del alumno del vector directamente en el listado:
                formSalidas.lsbListado.Items.Add($"LU:{alumnoVector.LU} - Nombre: {alumnoVector.Nombre} - Nota: {alumnoVector.Nota}");
            }
            //disparamos la ventana:
            formSalidas.ShowDialog();
        }
    }
}
