using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PharmacyMS.Model;
using PharmacyMS.Repositopry;

namespace PharmacyMS.BLL
{
    public class DoseManager
    {
        DoseRepository _doseRepository = new DoseRepository();
        public bool Add(Dose dose)
        {
            return _doseRepository.Add(dose);
        }
        public DataTable Display()
        {
            return _doseRepository.Display();
        }
        public bool Update(Dose dose)
        {
            return _doseRepository.Update(dose);
        }
        public bool IsNameExists(Dose dose)
        {
            return _doseRepository.IsNameExists(dose);
        }
        public bool UpdateIsNameExists(Dose dose)
        {
            return _doseRepository.UpdateIsNameExists(dose);
        }
        public DataTable Search(Dose dose)
        {
            return _doseRepository.Search(dose);
        }

    }
}
