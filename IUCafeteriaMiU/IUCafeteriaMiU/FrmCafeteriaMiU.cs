using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OPCafeteriaMiU;

namespace IUCafeteriaMiU
{
    public partial class FrmCafeteriaMiU : Form
    {
        public FrmCafeteriaMiU()
        {
            InitializeComponent();
        }

        private void Mensaje(string Texto)
        {
            this.msjError.Text = Texto;
        }

        private void llenarcombo()
        {
            this.selecDia.Items.Add("Seleccione un día");
            this.selecDia.Items.Add("Dia Normal");
            this.selecDia.Items.Add("Dia de Quincena");
            this.selecDia.Items.Add("Dia Festivo");
            this.selecDia.SelectedIndex = 0;
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCafeteriaMiU_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            float adi = 0;
            int tipoDia;
            try
            {
                tipoDia = this.selecDia.SelectedIndex;
                if(tipoDia <= 0)
                {
                    Mensaje("Tipo De Estudiante No valido");
                    this.selecDia.Focus();
                    return;
                }
                clsOPCafeteriaMiU obj = new clsOPCafeteriaMiU();
                obj.Dia = tipoDia;
                if(! obj.hallarPago())
                {
                    Mensaje(obj.Error);
                    obj = null;
                    return;
                }
                adi = obj.CantidadLibraF + obj.CantidadLibraQ;
                this.cantAdici.Text = adi.ToString();
                this.cantiTotal.Text = obj.CantidadTotal.ToString();
                this.tApagar.Text = obj.ValorTotalApagar.ToString();
                obj = null;

            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }

    }
}
