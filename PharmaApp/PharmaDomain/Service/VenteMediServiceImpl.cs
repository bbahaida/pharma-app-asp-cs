using PharmaDomain.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public class VenteMediServiceImpl : IVenteMediService
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(VenteMediServiceImpl));
        IVenteMediDao VenteMediDao;
        IStockMediDao StockMediDao;
        IStockDao StockDao;
        IVenteDao VenteDao;
        IMedicamentDao MedicamentDao;

        public VenteMediServiceImpl(IVenteMediDao vmdao, IVenteDao vdao, IMedicamentDao mdao, IStockMediDao smdao,IStockDao sdao)
        {
            VenteMediDao = vmdao;
            VenteDao = vdao;
            MedicamentDao = mdao;
            StockMediDao = smdao;
            StockDao = sdao;
        }
        public VenteMedi AddVenteMedi(VenteMedi vm, Stock s, User user)
        {
            if (vm != null )
            {
                if (VenteDao.GetOneVenteById(vm.NumVente) != null && MedicamentDao.GetOneMedicamentById(vm.CodeMedicament) != null)
                {
                    
                    
                    VenteMedi o = VenteMediDao.AddVenteMedi(vm);
                    if (o != null)
                    {
                        s.QuantiteMedicament -= vm.QuantiteMedicament;
                        StockDao.EditStock(s);
                        StockMediDao.GetOneStockMediById(s.NumStock, vm.CodeMedicament).QuantiteMedicament -= vm.QuantiteMedicament;
                        StockMediDao.EditStockMedi(StockMediDao.GetOneStockMediById(s.NumStock, vm.CodeMedicament));
                        logger.Info(user.Login + " a ajouter le medicament " + MedicamentDao.GetOneMedicamentById(o.CodeMedicament).LibelleMedicament + " dans le stock " + o.NumVente);
                        return o;
                    }
                }
            }
            return null;
        }

        public VenteMedi DeleteVenteMedi(VenteMedi del, User user)
        {
            throw new NotImplementedException();
        }

        public VenteMedi EditVenteMedi(VenteMedi vm, User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VenteMedi> GetAll()
        {
            return VenteMediDao.GetAll();
        }

        public VenteMedi GetOneVenteMediById(int idv, int idm)
        {
            if (idv > 0 && idm > 0)
                return VenteMediDao.GetOneVenteMediById(idv, idm);
            return null;
        }
    }
}
