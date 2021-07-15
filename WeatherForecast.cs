using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Church_Membership_Backend
{
   public class Members
    {
        public string Name { get; set; }

        public string MaillingAddress { get; set; }

        public string PhysicalAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }

        public int CellPhone { get; set; }

        public int HomePhone { get; set; }

        [ForeignKey("Status")]

        public string CurrentStatus { get; set; }

        public Status Status  { get; set; }
        
    }

    public class Status
    {
        public string CurrentStatus { get; set; }
    }
}
