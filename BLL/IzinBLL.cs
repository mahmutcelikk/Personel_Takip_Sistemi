using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class IzinBLL
    {
        public static void IzinEkle(IZIN iz)
        {
            IzinDAO.IzinEkle(iz);
        }

        public static IzinDTO GetAll()
        {
            IzinDTO dto = new IzinDTO();
            dto.Departmanlar = DepartmanDAO.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            dto.IzinDurumlari = IzinDAO.DurumGetir();
            dto.Izinler = IzinDAO.IzinGetir();
            return dto;
        }

        public static void IzinGuncelle(IzinDetayDTO detayDTO)
        {
            IzinDAO.IzinGuncelle(detayDTO);
        }

        public static void IzinGuncellemesi(int izinID, int onayla)
        {
            IzinDAO.IzinGuncellemesii(izinID,onayla);
        }
    }
}
