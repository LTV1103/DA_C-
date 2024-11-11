using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DoAn1
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkerList list = new LinkerList();


            while (true)
            {
                Console.WriteLine("===============");
                Console.WriteLine("0. thoat");
                Console.WriteLine("1. Nhap");
                Console.WriteLine("2. xuat");
                Console.WriteLine("3. them Dau");
                Console.WriteLine("4. them Cuoi");
                Console.WriteLine("5. Them Giua");
                Console.WriteLine("6. xoa Dau");
                Console.WriteLine("7. Xoa Cuoi");
                Console.WriteLine("8. xoa Giua");
                Console.WriteLine("9. tim Kiem");


                int chon, value, item;

                Console.Write("\nVui long chon chuc nang: ");
                chon = Convert.ToInt32(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        list.Nhap();
                        break;
                    case 2:
                        list.Xuat();
                        break;
                    case 3:
                        Console.Write("Nhap gia tri them dau: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.ThemDau(value);
                        list.Xuat();
                        break;

                    case 4:
                        Console.Write("Nhap gia tri them cuoi: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.ThemCuoi(value);
                        list.Xuat();
                        break;

                    case 5:
                        Console.Write("Nhap gia tri mun them: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Node node_n = list.DuyetNode();
                        if (node_n != null)
                            list.ThemsauX(node_n, value);
                        break; 

                    case 6:
                        Node firstNode = list.DuyetNode();
                        list.Xoadau();
                        list.Xuat();
                        break;

                    case 7:
                        Node lastNode = list.DuyetNode();
                        list.XoaCuoi();
                        list.Xuat();
                        break;

                    case 8:
                        Console.Write("Nhap gia tri ban muon xoa: ");
                        item = Convert.ToInt32(Console.ReadLine());
                        Node delNode_n = list.DuyetNode();
                        if (delNode_n != null && delNode_n.data == item)
                            list.XoaGiua(delNode_n);
                        list.Xuat();
                        break;

                    case 9:
                        Console.Write("Nhap gia tri ban muon tim: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Node node = list.DuyetNode();
                        if (node != null && node.data == value)
                            Console.WriteLine("Co " + value +  " trong danh sach");
                        else Console.WriteLine("Khong co " + value + " trong danh sach");
                        break;



                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("chon sai vui long chon lai !");
                        break;
                }
            }
        }
    }
}

