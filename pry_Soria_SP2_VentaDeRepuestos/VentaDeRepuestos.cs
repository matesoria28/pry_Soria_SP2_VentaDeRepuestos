namespace pry_Soria_SP2_VentaDeRepuestos
{
    public partial class VentaDeRepuestos : Form
    {
        public VentaDeRepuestos()
        {
            InitializeComponent();
        }

        string[,] matRespuesto = new string[100, 5];

        int indiceGrabar = 0;

 private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
                matRespuesto[indiceGrabar, 0] = "marca";
                matRespuesto[indiceGrabar, 1] = "origen";
                matRespuesto[indiceGrabar, 2] = "numero";
                matRespuesto[indiceGrabar, 3] = "precio";
                matRespuesto[indiceGrabar, 4] = "descripcion";

                indiceGrabar++;

            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> origenes = new List<string>();
            List<string> listaMarcas = new List<string>();

            for (int filas = 0; filas < matRespuesto.GetLength(0); filas++)
            {
                dgvDatos.Rows.Add(matRespuesto[filas, 0],
                    matRespuesto[filas, 1],
                    matRespuesto[filas, 2],
                    matRespuesto[filas, 3],
                    matRespuesto[filas, 4]);

                if (!listaMarcas.Contains(matRespuesto[filas, 0]))
                {
                    listaMarcas.Add(matRespuesto[filas, 0]);
                }

                if (!origenes.Contains(matRespuesto[filas, 1]))
                {
                    origenes.Add(matRespuesto[filas, 1]);
                }
            }

            cboMarcaFiltro.DataSource = listaMarcas;
            cmbOrigenFiltro.DataSource = origenes;

        }

       
    }
}
