using PharmaDomain.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public class StockMediServiceImpl : IStockMediService
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(StockMediServiceImpl));
        IStockMediDao StockMediDao;
        IStockDao StockDao;
        IMedicamentDao MedicamentDao;

        public StockMediServiceImpl(IStockMediDao smdao, IStockDao sdao, IMedicamentDao mdao)
        {
            StockMediDao = smdao;
            StockDao = sdao;
            MedicamentDao = mdao;
        }
        public StockMedi AddStockMedi(StockMedi sm, User user)
        {
            if (sm != null)
            {
                if (StockDao.GetOneStockById(sm.NumStock) != null && MedicamentDao.GetOneMedicamentById(sm.CodeMedicament) != null)
                {
                    Stock s = StockDao.GetOneStockById(sm.NumStock);
                    s.QuantiteMedicament += sm.QuantiteMedicament;
                    s = StockDao.EditStock(s);
                    if (s != null)
                    {
                        StockMedi o = StockMediDao.AddStockMedi(sm);
                        if (o != null)
                        {
                            logger.Info(user.Login + " a ajouter le medicament " + MedicamentDao.GetOneMedicamentById(o.CodeMedicament).LibelleMedicament + " dans le stock " + o.NumStock);
                            return o;
                        }
                    }
                }   
            }
            return null;

        }

        public StockMedi DeleteStockMedi(StockMedi del, User user)
        {
            throw new NotImplementedException();
        }

        public StockMedi EditStockMedi(StockMedi sm, User user)
        {
            if (sm != null)
            {
                if (StockDao.GetOneStockById(sm.NumStock) != null && MedicamentDao.GetOneMedicamentById(sm.CodeMedicament) != null)
                {
                    
                    StockMedi o = StockMediDao.AddStockMedi(sm);
                    if (o != null)
                    {
                        logger.Info(user.Login + " a modifier le medicament " + MedicamentDao.GetOneMedicamentById(o.CodeMedicament).LibelleMedicament + " dans le stock " + o.NumStock);
                        return o;
                    }
                    
                }
            }
            return null;
        }

        public IEnumerable<StockMedi> GetAll()
        {
            return StockMediDao.GetAll();
        }

        public StockMedi GetOneStockMediById(int ids, int idm)
        {
            if (ids > 0 && idm > 0)
                return StockMediDao.GetOneStockMediById(ids,idm);
            return null;
        }

        public IEnumerable<StockMedi> GetStockMediByMedicament(Medicament m)
        {
            if (m != null)
                return StockMediDao.GetStockMediByMedicament(m);
            return null;
        }

        public IEnumerable<StockMedi> GetStockMediByStock(Stock s)
        {
            if (s != null)
                return StockMediDao.GetStockMediByStock(s);
            return null;
        }

        public int GetAllQuantity(Medicament m)
        {
            if (m == null)
                return 0;
            List<StockMedi> data = StockMediDao.GetStockMediByMedicament(m).ToList();
            int q = 0;
            foreach (StockMedi s in data)
            {
                q += s.QuantiteMedicament;
            }
            return q;
        }
        public int GetQuantityByStock(Medicament m,Stock s)
        {
            if (m == null || s == null)
                return 0;
            return StockMediDao.GetOneStockMediById(s.NumStock, m.CodeMedicament).QuantiteMedicament;
        }
    }
}
