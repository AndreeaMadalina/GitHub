using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizer.BO
{
    public class Event
    {
        public int IdEvent { get; set; }
        public string Period { get; set; }
        public string Department { get; set; }
        public string Task { get; set; }
        public string Remarks { get; set; }
        public int Event_Type_ID { get; set; }


    }
}
