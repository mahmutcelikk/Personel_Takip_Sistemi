using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class PozisyonBLL
    {
        public static void PozisyonEkle(POZİSYON pz)
        {
            PozisyonDAO.DepartmanEkle(pz);
        }


        public static List<PozisyonDTO> PozisyonGetir(POZİSYON pz)
        {
            return PozisyonDAO.PozisyonGetir();
        }
    }
}
