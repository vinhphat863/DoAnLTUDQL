using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.BUS
{
    class XuLyChuoi
    {
        public static string LayChuoi(string Ma)
        {
            string kq = "";
            string KyHieu;
            string temp;
            int SoMoi;
            int vitri = Ma.IndexOf("V") + 1;
            KyHieu = Ma.Substring(0, vitri);
            temp = Ma.Substring(vitri, 4);
            int.TryParse(temp, out SoMoi);
            SoMoi = SoMoi + 1;
            if (SoMoi < 10)
            {
                kq = KyHieu + "000" + SoMoi;
            }
            if (SoMoi >= 10 && SoMoi < 100)
            {
                kq = KyHieu + "00" + SoMoi;
            }
            if (SoMoi >= 100 && SoMoi <= 1000)
            {
                kq = KyHieu + "000" + SoMoi;
            }
            return kq;
        }
    }
}
