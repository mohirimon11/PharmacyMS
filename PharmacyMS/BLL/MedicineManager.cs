using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyMS.Model;
using PharmacyMS.Repositopry;
using System.Data;

namespace PharmacyMS.BLL
{
    public class MedicineManager
    {
        MedicineRepository _medicineRepository = new MedicineRepository();
        public DataTable LoadCatagory()
        {
            return _medicineRepository.LoadCatagory();
        }
        public DataTable LoadCompany()
        {
            return _medicineRepository.LoadCompany();
        }
        public DataTable LoadGenericName()
        {
            return _medicineRepository.LoadGenericName();
        }
        public DataTable LoadDose()
        {
            return _medicineRepository.LoadDose();
        }
        public DataTable Display()
        {
            return _medicineRepository.Display();
        }
        public DataTable allMedicineDisplay()
        {
            return _medicineRepository.allMedicineDisplay();
        }
        public int addMedicine(Medicine medicine)
        {
            return _medicineRepository.addMedicine(medicine);
        }
        public bool IsCodeExists(Medicine medicine)
        {
            return _medicineRepository.IsCodeExists(medicine);
        }
        public DataTable Search(Medicine medicine)
        {
            return _medicineRepository.Search(medicine);
        }
        public bool UpdateIsCodeExists(Medicine medicine)
        {
            return _medicineRepository.UpdateIsCodeExists(medicine);
        }
        public bool UpdateIsNameExists(Medicine medicine)
        {
            return _medicineRepository.UpdateIsNameExists(medicine);
        }
        public bool Update(Medicine medicine)
        {
            return _medicineRepository.Update(medicine);
        }

    }
}
