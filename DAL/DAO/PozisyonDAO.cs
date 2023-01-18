using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PozisyonDAO : PersonelDataContext
    {
        public static void DepartmanEkle(POZİSYON pz)
        {
            try
            {
                db.POZİSYONs.InsertOnSubmit(pz);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PozisyonDTO> PozisyonGetir()
        {
            try
            {
                var list = (from p in db.POZİSYONs
                            join d in db.DEPARTMANs on p.DepartmanID equals d.ID
                            select new
                            {
                                pozisyonID = p.ID,
                                pozisyonAd = p.PozisyonAd,
                                departmanID = p.DepartmanID,
                                departmanAd = d.DepartmanAd

                            }).OrderBy(x => x.pozisyonID).ToList();

                List<PozisyonDTO> liste = new List<PozisyonDTO>() ;

                foreach (var item in list)
                {
                    PozisyonDTO pzt = new PozisyonDTO();
                    pzt.ID = item.pozisyonID;
                    pzt.PozisyonAd = item.pozisyonAd;
                    pzt.DepartmanID = item.departmanID;
                    pzt.DepartmanAd = item.departmanAd;
                    liste.Add(pzt);
                }
                return liste;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void PozisyonGuncelle(PozisyonDetayDTO detay)
        {
            POZİSYON pz = db.POZİSYONs.First(x => x.ID == detay.ID);
            pz.PozisyonAd = detay.PozisyonAD;
            pz.DepartmanID = detay.DepartmanID;
            db.SubmitChanges();
        }
    }
}
