using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public interface IFamilleDao
    {
        Famille AddFamille(Famille f);
        Famille EditFamille(Famille f);
        Famille DeleteFamille(Famille del);
        IEnumerable<Famille> GetAll();
        Famille GetOneFamilleById(int id);
        Famille GetOneFamilleByDesignation(string d);
        IEnumerable<Famille> GetFamilleByMC(string mc);
    }
}
