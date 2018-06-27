using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public interface IVenteService
    {
        Vente AddVente(Vente v, User user);
        Vente EditVente(Vente v, User user);
        Vente DeleteVente(Vente del, User user);
        IEnumerable<Vente> GetAll();
        Vente GetOneVenteById(int id);
        IEnumerable<Vente> GetVenteByDate(DateTime date);
        Dictionary<string, decimal> GetMontantPerDate();
    }
}
