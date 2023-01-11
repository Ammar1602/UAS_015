using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_015
{
    class Node
    {
        public string info;
        public Node id_barang;
        public Node nama_barang;
        public Node jenis_barang;
        public Node harga_barang;
        public Node next;

        public Node(string i, Node idb, Node nb, Node jb, Node hb, Node n)
        {
            info = i;
            id_barang = idb;
            nama_barang = nb;
            jenis_barang = jb;
            harga_barang = hb;
            next = n;
        }
    }

    class Toko_Elektronik
    {
        
        public Node ROOT;
        public Toko_Elektronik()
        {
            ROOT = null;
        }

        bool empty()
        {
            if (ROOT == null)
                return (true);
            else
                return(false);
        }
        public void Id_Barang(int element)
        {
            Console.WriteLine();
        }
        public void Nama_Barang(string element)
        {
            Console.WriteLine();
        }
        public void Jenis_Barang(string element)
        {
            Console.WriteLine();
        }
        public void Harga_Barang(int element)
        {
            Console.WriteLine();
        }
        public void Display()
        {
            Node tmp;
            if(empty())
                Console.WriteLine("\nList Empty");
            else
            {
                for (tmp = ROOT; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Toko_Elektronik te = new Toko_Elektronik();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. ID Barang");
                Console.WriteLine("2. Nama Barang");
                Console.WriteLine("3. Jenis Barang");
                Console.WriteLine("4. Harga Barang");
                Console.WriteLine("5. Display");
                Console.WriteLine("\nEnter Your Choice (1-5) :");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.Write("\nEnter Id Barang: ");
                            int num = Convert.ToInt32(System.Console.ReadLine());
                            Console.WriteLine();
                            te.Id_Barang(num);
                        }
                        break;
                    case '2':
                        {
                            Console.Write("\nEnter Nama Barang: ");
                            string word = Console.ReadLine();
                            te.Nama_Barang(word);
                        }
                        break ;
                    case '3':
                        {
                            Console.Write("\nEnter Jenis Barang: ");
                            string word = Console.ReadLine();
                            te.Jenis_Barang(word);
                        }
                        break;
                    case '4':
                        {
                            Console.Write("\nEnter Harga Barang: ");
                            int num = Convert.ToInt32(System.Console.ReadLine());
                            Console.WriteLine();
                            te.Harga_Barang(num);
                        }
                        break;
                    case '5':
                        te.Display();
                        break;
                }
            }
        }

    }
}

/*2. menggunakan algoritma stack dan linked list */
/*3. front, rear, atau rear, front*/
/*4A. kedalaman 5*/
/*4B. Post Order Traversal*/