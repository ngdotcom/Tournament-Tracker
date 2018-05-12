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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connections.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";

            tournamentTeamsListbox.DataSource = null;
            tournamentTeamsListbox.DataSource = selectedTeams;
            tournamentTeamsListbox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropdown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void createPrizeBtn_Click(object sender, EventArgs e)
        {
            // Call CreatePrizeForm 
            // 'this' keyboard represents specific instance
            CreatePrize frm = new CreatePrize(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the form a PrizeModel

            // Take the PrizeModel and put it into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Creat frm = CreateTournammentFrom(this);
            CreateTeamFrom frm =  new CreateTeamFrom(this);
            frm.Show();
        }

        private void removeSelectedPlayersbtn_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListbox.SelectedItem;

            if(t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void removeSelectedPrizesBtn_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void createTournamentBtn_Click(object sender, EventArgs e)
        {
            // Validate data 
            decimal fee = 0; 

            bool feeAcceptable = decimal.TryParse(entryFeeText.Text, out fee);

            if(!feeAcceptable)
            {
                MessageBox.Show("Need to enter valid entry fee", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Create tournal model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameText.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO - Wireup matchups
            TournamentLogic.CreateRounds(tm);

            // Create tournament entry 
            // Create all of the prizes entries 
            // Create all of the team entries
            GlobalConfig.Connections.CreateTournament(tm);

        }
    }
}
