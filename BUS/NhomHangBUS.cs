﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhomHangBUS
    {
        public static List<NhomHang> DanhSach()
        {
            return NhomHangDAO.DanhSach();
        }
    }
}
