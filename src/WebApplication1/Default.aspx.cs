using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        private PersonRepository personRepository = new PersonRepository();
        private List<Guid> guids = new List<Guid>();
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var person in personRepository.GetAll())
            {
                ListPerson.Items.Add(person.FirstName + " " + person.LastName);
                guids.Add(person.PersonId);
            }
        }

        protected void ListPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ListPerson.SelectedIndex;
            if (index == -1)
                return;
            var person = personRepository.Get(guids[index]);
            LabelDetail.Text = person.FirstName + " " + person.LastName + " " + person.Age.ToString() + " ans";
        }
    }
}