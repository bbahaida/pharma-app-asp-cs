using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public interface IVenteMediService
    {
        VenteMedi AddVenteMedi(VenteMedi vm,Stock s, User user);
        VenteMedi EditVenteMedi(VenteMedi vm, User user);
        VenteMedi DeleteVenteMedi(VenteMedi del, User user);
        IEnumerable<VenteMedi> GetAll();
        VenteMedi GetOneVenteMediById(int idv, int idm);
    }
}
