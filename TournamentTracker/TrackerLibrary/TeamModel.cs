using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        //props
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); //Initialize the List of Person (versus making a ctor)
        public string TeamName { get; set; } 
    }
}
