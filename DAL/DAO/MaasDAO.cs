using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL.DAO
{
    public class MaasDAO : PersonelDataContext
    {
        public static List<AYLAR> AylarGetir()
        {
            return db.AYLARs.ToList();
        }

        public static void MaasEkle(MAA maas)
        {
            try
            {
                db.MAAs.InsertOnSubmit(maas);
                db.SubmitChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<MaasDetayDTO> MaasGetir()
        {
            List<MaasDetayDTO> liste = new List<MaasDetayDTO>();
            var list = (from m in db.MAAs
                         join p in db.PERSONELs on m.PersonelID equals p.ID
                         join ay in db.AYLARs on m.Ay_ID equals ay.ID
                         select new
                         {
                             userno = p.UserNo,
                             ad = p.Ad,
                             soyad = p.Soyad,
                             maas = m.Miktar,
                             maasID = m.ID,
                             maasAy = ay.Ay,
                             maasYil = m.YIL,
                             maasAyID = m.Ay_ID,
                             eskiMaas = m.Miktar,
                             personelID = p.ID,
                             departmanID = p.DepartmanID,
                             pozisyonID = p.PozisyonID,
                         }).OrderBy(x => x.maasYil).ToList();
            foreach (var item in list)
            {
                MaasDetayDTO dto = new MaasDetayDTO();
                dto.UserNo = item.userno ;
                dto.Ad = item.ad;
                dto.Soyad = item.soyad;
                dto.MaasMiktar = item.maas;
                dto.MaasID = item.maasID;
                dto.MaasAy = item.maasAy;
                dto.MaasYil = item.maasYil;
                dto.MaasAyID = item.maasAyID;
                dto.PersonelID = item.personelID;
                dto.DepartmanID = item.departmanID;
                dto.PozisyonID = item.pozisyonID;
                liste.Add(dto);
            }

            return liste;
        }
    }
}
