using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5
{
    class Node
    {
        public string nama;
        public Node next;
    }

    class Queue
    {
        Node Denune, Kaisar;

        public Queue()
        {
            Denune = null;
            Kaisar = null;
        }

        public void insert(string nm)
        {
            Console.Write("\nMasukkan nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.nama = nm;
            nodeBaru.next = null;

            if (Kaisar == null)
            {
                Denune = nodeBaru;
                Kaisar = nodeBaru;
                return;
            }
            Kaisar.next = nodeBaru;
            Kaisar = nodeBaru;
        }

        
    }
}
