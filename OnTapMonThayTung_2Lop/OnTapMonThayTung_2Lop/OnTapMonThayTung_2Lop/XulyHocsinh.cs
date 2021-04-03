using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OnTapMonThayTung_2Lop
{
    class XulyHocsinh
    {
        private List<HocSinh> dsHS;

        public XulyHocsinh()
        {
            dsHS = new List<HocSinh>();
        }

        public List<HocSinh> getDSHocSinh()
        {
            return dsHS;
        }

        public HocSinh tim(string mshs)
        {
            foreach(HocSinh a in dsHS)
            {
                if(a.MaHS == mshs)
                {
                    return a;
                }
            }
            return null;
        }

         public void them(HocSinh hs)
        {
            dsHS.Add(hs);
        }

        public void xoa(string mshs)
        {
            HocSinh a = tim(mshs);
            if (a != null) 
            {
                dsHS.Remove(a);
            }
        }

        public void sua(HocSinh hs)
        {
            HocSinh a = tim(hs.MaHS);
            if (a != null)
            {
                a.HoTen = hs.HoTen;
                a.NgaySinh = hs.NgaySinh;
                a.GT = hs.GT;
                a.DiaChi = hs.DiaChi;
            }
        }

        public bool ghiFile(string tenfile)
        {
            FileStream f = new FileStream(tenfile, FileMode.Create);
            if (f == null)
            {
                return false;
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dsHS);
                f.Close();
                return true;
            }
        }

        public bool docFile(string tenfile)
        {
            FileStream f = new FileStream("hocsinh.dat", FileMode.Open);
            if (f == null)
            {
                return false;
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                dsHS = bf.Deserialize(f) as List<HocSinh>;
                f.Close();
                return true;
            }
        }
    }
}
