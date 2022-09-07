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
    public class GenericNameManager
    {
        GenericNameRepository _genericNameRepository = new GenericNameRepository();

        public bool Add(GenericName genericName)
        {
            return _genericNameRepository.Add(genericName);
        }
        public bool Update(GenericName genericName)
        {
            return _genericNameRepository.Update(genericName);
        }
        public DataTable Search(GenericName genericName)
        {
            return _genericNameRepository.Search(genericName);
        }
        public bool UpdateIsCodeExists(GenericName genericName)
        {
            return _genericNameRepository.UpdateIsCodeExists(genericName);
        }
        public bool IsNameExists(GenericName genericName)
        {
            return _genericNameRepository.IsNameExists(genericName);
        }
        public bool UpdateIsNameExists(GenericName genericName)
        {
            return _genericNameRepository.UpdateIsNameExists(genericName);
        }
        public DataTable Display()
        {
            return _genericNameRepository.Display();
        }
        public bool IsCodeExists(GenericName genericName)
        {
            return _genericNameRepository.IsCodeExists(genericName);
        }
        public bool delete(GenericName genericName)
        {
            return true;
        }
    }
}
