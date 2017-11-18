using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class MainForm : Form
    {
        private readonly AgendaService _agendaService;
        public MainForm()
        {
            InitializeComponent();
            string myServerCredentials = "Server=192.168.9.219;Database=Agenda;User Id=corso;Password=corso;";
            _agendaService = new AgendaService(myServerCredentials);


        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            //DataGridView 
            gvPeople.DataSource =
                //getPersonModel
                //lista de person model...

        //caricamento delle persone GetPeople()
    }

    private void btnNewPerson_Click(object sender, EventArgs e)
        {
            //apertura form dedicato all'inserimento/modifica della persona
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            //apertura form dedicato all'inserimento/modifica della persona
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            //cancellazione (previa conferma) della persona
        }
    }
}
