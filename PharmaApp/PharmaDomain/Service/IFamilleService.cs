using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public interface IFamilleService
    {
        Famille AddFamille(Famille f,User user);
        Famille EditFamille(Famille f, User user);
        Famille DeleteFamille(Famille del,User user);
        IEnumerable<Famille> GetAll();
        Famille GetOneFamilleById(int id);
        IEnumerable<Famille> GetFamilleByMC(string mc);
        Famille GetOneFamilleByDesignation(string d);
    }
}
