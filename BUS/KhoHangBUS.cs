﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhoHangBUS
    {
        public static List<KhoHang> DanhSach()
        {
            return KhoHangDAO.DanhSach();
        }
    }
}
