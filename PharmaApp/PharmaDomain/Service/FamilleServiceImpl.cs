using Microsoft.Practices.Unity;
using PharmaDomain.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public class FamilleServiceImpl : IFamilleService
    {
        
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(FamilleServiceImpl));
        IFamilleDao FamilleDao;
        IMedicamentDao MedicamentDao;
        public FamilleServiceImpl(IFamilleDao dao,IMedicamentDao mdao)
        {
            
            FamilleDao = dao;
            MedicamentDao = mdao;
        }
        public Famille AddFamille(Famille f, User user)
        {
            if (f != null)
            {
                if (FamilleDao.GetOneFamilleByDesignation(f.Designation) == null)
                {
                    Famille o =  FamilleDao.AddFamille(f);
                    if (o != null)
                    {
                        logger.Info(user.Login +" a ajouter la famille "+o.Designation);
                        return o;
                    }

                }    
            }
            
            return null;
        }

        public Famille DeleteFamille(Famille del, User user)
        {
            if (del != null)
            {
                List<Medicament> list = MedicamentDao.GetMedicamentByFamille(del).ToList();
                if(list.Count == 0 )
                {

                    Famille f =  FamilleDao.DeleteFamille(del);
                    if (f == null)
                    {
                        logger.Info(user.Login + " a supprime la famille " + del.Designation);
                        return null;
                    }
                }
            }
            return del;
        }

        public Famille EditFamille(Famille f, User user)
        {
            if (f != null)
            {
                if (FamilleDao.GetOneFamilleByDesignation(f.Designation) == null)
                {
                    Famille o = FamilleDao.EditFamille(f);
                    if (o != null)
                    {
                        logger.Info(user.Login + " a Modifier la famille " + f.Designation+" a "+ o.Designation);
                        return o;
                    }
                }
            }
                
            return null;
        }

        public IEnumerable<Famille> GetAll()
        {
            return FamilleDao.GetAll();
        }

        public IEnumerable<Famille> GetFamilleByMC(string mc)
        {
            if (!mc.Equals(""))
                return FamilleDao.GetFamilleByMC(mc);
            return null;
        }

        public Famille GetOneFamilleById(int id)
        {
            if (id > 0)
                return FamilleDao.GetOneFamilleById(id);
            return null;
        }

        public Famille GetOneFamilleByDesignation(string d)
        {
            if (!d.Equals(""))
                return FamilleDao.GetOneFamilleByDesignation(d);
            return null;
        }
    }
}
