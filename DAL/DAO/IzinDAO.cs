using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DAO
{
    public class IzinDAO : PersonelDataContext
    {
        public static void IzinEkle(IZIN iz)
        {
            try
            {
                db.IZINs.InsertOnSubmit(iz);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<IZINDURUM> DurumGetir()
        {
            return db.IZINDURUMs.ToList();
        }

        public static List<IzinDetayDTO> IzinGetir()
        {
            List<IzinDetayDTO> liste = new List<IzinDetayDTO>();
            var list = (from i in db.IZINs
                        join p in db.PERSONELs on i.PersonelID equals p.ID
                        join d in db.IZINDURUMs on i.IzinDurumID equals d.ID
                        select new
                        {
                            userno = p.UserNo,
                            ad = p.Ad,
                            soyad = p.Soyad,
                            durumAd = d.IzinDurumAd,
                            durumID = i.IzinDurumID,
                            baslamaTarihi = i.IzinBaslamaTarihi,
                            bitisTarihi = i.IzinBitisTarihi,
                            personelID = i.PersonelID,
                            izinID = i.ID,
                            aciklama = i.Aciklama,
                            sure = i.Sure,
                            departmanID = p.DepartmanID,
                            pozisyonID = p.PozisyonID,
                            
                        }).OrderBy(x => x.baslamaTarihi).ToList();

            foreach (var item in list)
            {
                IzinDetayDTO dto = new IzinDetayDTO();
                dto.UserNo = item.userno;
                dto.Ad = item.ad;
                dto.Soyad = item.soyad;
                dto.IzinDurumAd = item.durumAd;
                dto.IzinDurumID = item.izinID;
                dto.BaslamaTarihi = item.baslamaTarihi;
                dto.BitisTarihi = item.bitisTarihi;
                dto.PersonelID = item.personelID;
                dto.IzinID = item.izinID;
                dto.Aciklama = item.aciklama;
                dto.Sure = item.sure;
                dto.DepartmanID = item.departmanID;
                dto.PozisyonID = item.pozisyonID;
                liste.Add(dto);

            }
            return liste;
        }

        public static void IzinSil(int izinID)
        {
            try
            {
                IZIN iz = db.IZINs.First(x => x.ID == izinID);
                db.IZINs.DeleteOnSubmit(iz);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void IzinGuncellemesii(int izinID, int onayla)
        {
            try
            {
                IZIN iz = db.IZINs.First(x => x.ID == izinID);
                iz.IzinDurumID = onayla;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void IzinGuncelle(IzinDetayDTO detayDTO)
        {
            try
            {
                IZIN iz = db.IZINs.First(x => x.ID == detayDTO.IzinID);
                iz.Aciklama = detayDTO.Aciklama;
                iz.IzinBaslamaTarihi = detayDTO.BaslamaTarihi;
                iz.IzinBitisTarihi = detayDTO.BitisTarihi;
                iz.Sure = detayDTO.Sure;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
