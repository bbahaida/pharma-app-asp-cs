using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public interface IVenteMediDao
    {
        VenteMedi AddVenteMedi(VenteMedi vm);
        VenteMedi EditVenteMedi(VenteMedi vm);
        VenteMedi DeleteVenteMedi(VenteMedi del);
        IEnumerable<VenteMedi> GetAll();
        IEnumerable<VenteMedi> GetVenteMediByMedicament(Medicament m);
        IEnumerable<VenteMedi> GetVenteMediByVente(Vente v);
        VenteMedi GetOneVenteMediById(int idv,int idm);
    }
}
