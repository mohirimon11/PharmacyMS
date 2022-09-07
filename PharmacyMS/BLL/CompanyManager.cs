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
    public class CompanyManager
    {
        CompanyRepository _companyRepository = new CompanyRepository();
        public bool Add(Company company)
        {
            return _companyRepository.Add(company);
        }
        public bool Update(Company company)
        {
            return _companyRepository.Update(company);
        }
        public DataTable Search(Company company)
        {
            return _companyRepository.Search(company);
        }
        public bool UpdateIsCodeExists(Company company)
        {
            return _companyRepository.UpdateIsCodeExists(company);
        }
        public bool IsNameExists(Company company)
        {
            return _companyRepository.IsNameExists(company);
        }
        public bool UpdateIsNameExists(Company company)
        {
            return _companyRepository.UpdateIsNameExists(company);
        }
        public DataTable Display()
        {
            return _companyRepository.Display();
        }
        public bool IsCodeExists(Company company)
        {
            return _companyRepository.IsCodeExists(company);
        }
    }
}
