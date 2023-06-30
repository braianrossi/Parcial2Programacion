using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//CURSO – LEGAJO – APELLIDO – NOMBRE

namespace ABMMascotas
{
    public partial class frmMascota : Form
    {
        private accesoDatos oBD;
        private List<Mascota> lMascota;
       
        public frmMascota()
        {
            InitializeComponent();
            oBD = new accesoDatos();
            lMascota = new List<Mascota>();
        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
            this.cargarCombo();
            this.cargarLista();
            this.cargarGrilla();
            this.habilitar(true);
        }

        private void habilitar(bool v)
        {
            txtCodigo.Enabled = !v;
            txtNombre.Enabled = !v;
            btnNuevo.Enabled = v;
            cboEspecie.Enabled = !v;
            btnBorrar.Enabled = v;
            dtpFechaNacimiento.Enabled = !v;
            btnSalir.Enabled = v;
            btnEditar.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
        }

        private void cargarGrilla()
        {
            DataTable tabla = oBD.consultarBD("SELECT m.nombre, e.nombreEspecie, s.sexo, m.fechaNacimiento from Mascotas m join Especies e on e.idEspecie = m.especie join Sexos s on s.id = m.sexo");
            dgvMascota.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvMascota.Rows.Add(tabla.Rows[i]["nombre"], tabla.Rows[i]["nombreEspecie"], tabla.Rows[i]["sexo"], tabla.Rows[i]["fechaNacimiento"]);
            }
        }

        private void cargarLista()
        {
            lMascota.Clear();
            lstMascotas.Items.Clear();
            DataTable tabla = oBD.consultarBD("SELECT * FROM Mascotas");
            foreach (DataRow fila in tabla.Rows)
            {
                Mascota m = new Mascota();
                m.Codigo = Convert.ToInt32(fila["codigo"]);
                m.Nombre = Convert.ToString(fila["nombre"]);
                m.Especie = Convert.ToInt32(fila["especie"]);
                m.Sexo = Convert.ToInt32(fila["sexo"]);
                m.FechaNacimiento = Convert.ToDateTime(fila["fechaNacimiento"]);
                lMascota.Add(m);
                lstMascotas.Items.Add(m);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de salir del formulario?"
                 , "SALIENDO"
                 , MessageBoxButtons.YesNo
                 , MessageBoxIcon.Question
                 , MessageBoxDefaultButton.Button2)
                 == DialogResult.Yes)
                Close();
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //valida datos...
               //crear objeto  
                    //insert usando parámetros
        }

        private void cargarCombo()
        {
            DataTable tabla = oBD.consultarBD("SELECT * FROM Especies order by 2");
            cboEspecie.DataSource = tabla;
            cboEspecie.DisplayMember = tabla.Columns[1].ColumnName; //"nombreEspecie" ;
            cboEspecie.ValueMember = tabla.Columns[0].ColumnName; // "idEspecie";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(false);
            limpiar();
            txtCodigo.Focus();            
        }

        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cboEspecie.SelectedIndex = -1;
            rbtHembra.Checked = false;
            rbtMacho.Checked = false;
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstMascotas.SelectedIndex);
        }

        private void cargarCampos(int i)
        {
            txtCodigo.Text = lMascota[i].Codigo.ToString();
            txtNombre.Text = lMascota[i].Nombre;
            cboEspecie.SelectedValue = lMascota[i].Especie;
            dtpFechaNacimiento.Value = lMascota[i].FechaNacimiento;
        }

        private void cboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            this.txtCodigo.Enabled = false;
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //ValidarDatos()
            if (ValidarDatos())
            {
                //Crear objeto
                Mascota m = new Mascota();
                m.Codigo = int.Parse(txtCodigo.Text);
                m.Nombre = txtNombre.Text;
                m.Especie = (int)cboEspecie.SelectedValue;
                m.FechaNacimiento = dtpFechaNacimiento.Value;
                if (rbtHembra.Checked)
                    m.Sexo = 2;
                else
                    m.Sexo = 1;

                if (!existe(m))
                {
                    //insert usando parametros 
                    string insertSQL = " INSERT INTO Mascotas values(@codigo,@nombre,@especie,@sexo,@fechaNacimiento)";

                    List<Parametro> lParametros = new List<Parametro>();
                    lParametros.Add(new Parametro("@codigo", m.Codigo));
                    lParametros.Add(new Parametro("@nombre", m.Nombre));
                    lParametros.Add(new Parametro("@especie", m.Especie));
                    lParametros.Add(new Parametro("@sexo", m.Sexo));
                    lParametros.Add(new Parametro("@FechaNacimiento", m.FechaNacimiento));

                    if(oBD.actualizarBD(insertSQL, lParametros)>0)
                    {
                        MessageBox.Show("Se insertó con éxito una nueva mascota!!!");
                        cargarLista();
                    }

                }
                else
                {

                    MessageBox.Show("La mascota ya existe!!!");

                    //update
                    string updateSQL = "UPDATE Mascotas SET nombre=@nombre, especie=@especie, sexo=@sexo, fechaNacimiento=@fechaNacimiento WHERE codigo=@codigo";
                    List<Parametro> lParametros = new List<Parametro>();
                    lParametros.Add(new Parametro("@codigo", m.Codigo));
                    lParametros.Add(new Parametro("@nombre", m.Nombre));
                    lParametros.Add(new Parametro("@especie", m.Especie));
                    lParametros.Add(new Parametro("@sexo", m.Sexo));
                    lParametros.Add(new Parametro("@FechaNacimiento", m.FechaNacimiento));

                    if(oBD.actualizarBD(updateSQL, lParametros) > 0)
                    {
                        MessageBox.Show("Se modificó con éxito la mascota!!!");
                        cargarLista();
                    }
                }      
            }
        }

        private bool existe(Mascota nueva)
        {
            for (int i = 0; i < lMascota.Count; i++)
            {
                if (lMascota[i].Codigo == nueva.Codigo)
                    return true;
            }
            return false;
        }

        public bool ValidarDatos()
        {
            bool v = true;
            if (string.IsNullOrEmpty(txtCodigo.Text))
                v = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
                v = false;
            if (cboEspecie.SelectedIndex == -1)
                v = false;
            if (!rbtHembra.Checked && !rbtMacho.Checked)
                v = false;

            return v;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
