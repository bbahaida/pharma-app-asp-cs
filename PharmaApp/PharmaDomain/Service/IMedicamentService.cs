using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public interface IMedicamentService
    {
        Medicament AddMedicament(Medicament m, User user);
        Medicament EditMedicament(Medicament m, User user);
        Medicament DeleteMedicament(Medicament del,User user);
        IEnumerable<Medicament> GetAll();
        Medicament GetOneMedicamentById(int id);
        IEnumerable<Medicament> GetMedicamentByFamille(Famille f);
        Medicament GetMedicamentByLibelle(string l);
        IEnumerable<Medicament> GetMedicamentByMC(string mc);
    }
}
