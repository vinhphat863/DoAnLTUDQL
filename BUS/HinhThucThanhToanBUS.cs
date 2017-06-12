﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HinhThucThanhToanBUS
    {
        public static List<HinhThucThanhToan> DanhSach()
        {
            return HinhThucThanhToanDAO.DanhSach();
        }
    }
}
