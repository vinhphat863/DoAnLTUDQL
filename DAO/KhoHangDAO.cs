﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhoHangDAO
    {
        public static List<KhoHang> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.KhoHangs.ToList();
        }
    }
}
