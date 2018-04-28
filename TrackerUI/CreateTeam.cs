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
    public partial class CreateTeam : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeam()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName  = "Nick", LastName = "Gonzalez" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Time", LastName = "Corey" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Brown" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Mary", LastName = "Jane" });
        }
        private void WireUpLists()
        {
            selectTeamMemberDropdown.DataSource = null;

            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMemListbox.DataSource = null; 

            teamMemListbox.DataSource = selectedTeamMembers;
            teamMemListbox.DisplayMember = "FullName";
        }

        private void createMemBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                //captures back the id 
                p = GlobalConfig.Connections.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("Fill in all required fields");
            }
        }
        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;

            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true; 
        }
        private void addTeamMemBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropdown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void removeMemBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemListbox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void createTemBtn_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameText.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connections.CreateTeam(t);

            // TODO - If we arent;y this form after creation, reset the form 
        }
    }
}
