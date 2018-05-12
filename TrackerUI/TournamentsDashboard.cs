using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentsDashboard : Form
    {
        // 
        List<TournamentModel> tournaments = GlobalConfig.Connections.GetTournament_All();

        public TournamentsDashboard()
        {
            InitializeComponent();
        }
    }
}
