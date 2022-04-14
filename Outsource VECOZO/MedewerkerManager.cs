using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Outsource_VECOZO
{
    public partial class MedewerkerManager : Form
    {
        public string Name;
        public string Functie;
        public string Vaardigheid;

        MedewerkerContainer medewerkerContainer;
        public MedewerkerManager()
        {
            InitializeComponent();

            //datagridview opmaak.
            dgvMedewerkers.ColumnCount = 9;
            dgvMedewerkers.Columns[0].Name = "Id";
            dgvMedewerkers.Columns[0].Visible = false;
            dgvMedewerkers.Columns[1].Name = "Voornaam";
            dgvMedewerkers.Columns[2].Name = "Achternaam";
            dgvMedewerkers.Columns[3].Name = "Email";
            dgvMedewerkers.Columns[4].Name = "Gebruikersnaam";
            dgvMedewerkers.Columns[5].Name = "Wachtwoord";
            dgvMedewerkers.Columns[6].Name = "FunctieId";
            dgvMedewerkers.Columns[6].Visible = false;
            dgvMedewerkers.Columns[7].Name = "DatumLogin";
            dgvMedewerkers.Columns[8].Name = "IsManager";
            dgvMedewerkers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            medewerkerContainer = new MedewerkerContainer();

            FillGridView();
        }

        public void FillGridView()
        {
            dgvMedewerkers.Rows.Clear();
            dgvMedewerkers.Refresh();

            //datagridview vullen.
            foreach (Medewerker medewerker in medewerkerContainer.GetAllMedewerkers())
            {
                dgvMedewerkers.Rows.Add(medewerker.Id, medewerker.Voornaam, medewerker.Achternaam, medewerker.Email, medewerker.Gebruikersnaam, medewerker.Wachtwoord, medewerker.FunctieId, medewerker.DatumLogin, medewerker.IsManager);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functie = cbFunctie.Text;
            Vaardigheid = cbVaardigheid.Text;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
