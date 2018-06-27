using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public interface IMedicamentDao
    {
        Medicament AddMedicament(Medicament m);
        Medicament EditMedicament(Medicament m);
        Medicament DeleteMedicament(Medicament del);
        IEnumerable<Medicament> GetAll();
        Medicament GetOneMedicamentById(int id);
        IEnumerable<Medicament> GetMedicamentByFamille(Famille f);
        IEnumerable<Medicament> GetMedicamentByMC(string mc);
        Medicament GetMedicamentByLibelle(string l);
    }
}
