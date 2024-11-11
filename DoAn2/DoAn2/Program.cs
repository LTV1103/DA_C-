using DoAn2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DoAn2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            int value, chon;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("1.Nhap gia tri cho cay nhi phan");
                Console.WriteLine("2.Xuat gia tri cho cay nhi phan");
                Console.WriteLine("3.Duyet cay nhi phan theo NLR");
                Console.WriteLine("4.Duyet cay nhi phan theo LRN");
                Console.WriteLine("5.Duyet cay nhi phan theo LNR");
                Console.WriteLine("6.Tim kiem gia tri trong cay");
                Console.WriteLine("7.Them phan tu vao cay");
                Console.WriteLine("8.Xoa phan tu khoi cay nhi phan");
                Console.WriteLine("9.Dung chuong trinh! ");
                Console.WriteLine("==================================");
                Console.Write("Vui long chon chuc nang: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        do
                        {
                            Console.Write("Nhap gia tri (-99 de dung): ");
                            value = Convert.ToInt32(Console.ReadLine());
                            if (value == -99)
                                break;
                            tree.nhap(tree.root, value);
                        } while (true);
                        break;

                    case 2:
                        Console.WriteLine("Cay");
                        tree.xuat(tree.root);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Duyet cay theo NLR: ");
                        tree.NLR(tree.root);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Duyet cay theo LRN: ");
                        tree.LRN(tree.root);
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("Duyet cay theo LNR: ");
                        tree.LNR(tree.root);
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Nhap gia tri ma ban can tim: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        if (tree.timkiem(tree.root, value))
                        {
                            Console.WriteLine("Co gia tri " + value + " trong cay!");
                        }
                        else
                        {
                            Console.WriteLine("Khong co gia tri " + value + " trong cay!");
                        }
                        break;

                    case 7:
                        int n;
                        Console.Write("Nhap gia tri muon them vao cay: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        tree.them(tree.root, n);
                        tree.xuat(tree.root);
                        Console.WriteLine();
                        break;

                    case 8:
                        int key;
                        Console.WriteLine("Nhap gia tri can xoa: ");
                        key = Convert.ToInt32(Console.ReadLine());
                        tree.DeleteKey(key);
                        tree.xuat(tree.root);
                        Console.WriteLine();
                        break;

                    case 9:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Lua chon sai vui long chon lai.");
                        break;


                }
            }
        }
    }
}
