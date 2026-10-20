//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace vidu_array_list
//{
//    public interface HinhHoc
//    {
//        double dientich();
//        double chuvi();
//        void inra();

//    }
//    public class Vuong : HinhHoc
//    {
//        public double c {  get; set; }
//        public double dientich()
//        {
//            return c*c;
//        }
//        public double chuvi()
//        {
//            return c*4;
//        }
//        public void inra()
//        {
//            Console.WriteLine("V: {0}",c);
//        }
//    }
//    public class ChuNhat : HinhHoc
//    {
//        public double cd { get; set; }
//        public double cr { get; set; }
//        public double chuvi()
//        {
//            return (cd + cr) * 2;
//        }
//        public double dientich()
//        {
//            return cd * cr;
//        }
//        public void inra()
//        {
//            Console.WriteLine("CN: {0} - {1}", cd, cr);
//        }
//    }


//    internal class Program
//    {
//        static bool hamxd1(HinhHoc h)
//        {
//            return h.dientich() >= 20;
//        }
//        static bool hamxd2(HinhHoc h)
//        {
//            return h.chuvi() <= 20;
//        }
//        static void Main(string[] args)
//        {
//            List<HinhHoc> ds = new List<HinhHoc>();
//            ds.Add(new ChuNhat() { cd = 4, cr = 3 });
//            ds.Add(new Vuong() { c = 6 });
//            ds.Add(new ChuNhat() { cd = 5, cr = 5 });
//            foreach (HinhHoc pt in ds)
//                if (pt.dientich() >= 20)
//                    pt.inra();

//            HinhHoc h = ds.Find(hamxd1);
//            h.inra();

               
//        }
//    }
//}
