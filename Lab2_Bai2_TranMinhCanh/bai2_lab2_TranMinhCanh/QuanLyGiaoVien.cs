
using System;
using System.Collections.Generic;
using System.Text;

namespace bai2_lab2_TranMinhCanh
{
    public class QuanLyGiaoVien
    {
        public List<GiaoVien> giaoViens { get; set; }
        public QuanLyGiaoVien() 
        {
            giaoViens = new List<GiaoVien>();

        }
        public GiaoVien this[int index]
        {
            get { return giaoViens[index]; }
            set { giaoViens[index] = value; }
        }
        public bool Them(GiaoVien giaoVien)
        {
            var exists = giaoViens.Exists(gv => gv.MaSo == giaoVien.MaSo);
            if(exists)
            {
                return false;
            }
            giaoViens.Add(giaoVien);
            return true;
        }
        public enum KieuTim
        {
            TheoMa,
            TheoHoTen,
            TheoSDT
        }
        public GiaoVien Tim(string characters, KieuTim kieu)
        {
            GiaoVien giaoVien = null;
            switch (kieu)
            {
                case KieuTim.TheoMa:
                    giaoVien = giaoViens.Find(gv => gv.MaSo.Trim() == characters.Trim());
                    break;
                case KieuTim.TheoHoTen:
                    giaoVien = giaoViens.Find(gv => gv.HoTen.Trim() == characters.Trim());
                    break;
                case KieuTim.TheoSDT:
                    giaoVien = giaoViens.Find(gv => gv.SoDT.Trim() == characters.Trim());
                    break;
                default:
                    break;
            }
            return giaoVien;
        }
        public bool xoa(GiaoVien giaoVien)
        {
            var exists = giaoViens.Exists(gv => gv.MaSo == giaoVien.MaSo);
            if (exists)
            {
                return false;
            }
            giaoViens.Remove(giaoVien);
            return true;
        }

    }
}
