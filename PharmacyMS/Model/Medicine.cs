using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyMS.Model
{
    public class Medicine
    {
        public int ID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int CategoryId { set; get; }
        public int CompanyId { set; get; }
        public int GenericNameId { set; get; }
        public int DoseId { set; get; }
        public int ReorderLavel { set; get; }
        public string AgeLimite { set; get; }
        public string Country { set; get; }
        public string Detail { set; get; }
        public string Instruction { set; get; }


    }
}
