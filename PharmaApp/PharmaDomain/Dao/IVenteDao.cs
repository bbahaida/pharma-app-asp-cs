using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public interface IVenteDao
    {
        Vente AddVente(Vente v);
        Vente EditVente(Vente v);
        Vente DeleteVente(Vente del);
        IEnumerable<Vente> GetAll();
        Vente GetOneVenteById(int id);
        IEnumerable<Vente> GetVenteByDate(DateTime date);
    }
}
