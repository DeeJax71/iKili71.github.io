using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Ward_Infinity.Models
{
    public class WardInfinitySupport
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string CharacterName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Button SubmitTicket { get; set; }
        public Button GoBack { get; set; }
       

    }
}