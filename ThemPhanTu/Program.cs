using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemPhanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = new int[10];
            value[0] = 10;
            value[1] = 4;
            value[2] = 6;
            value[3] = 7;
            value[4] = 8;
            int[] index = new int[10];
            for(int i = 0; i < index.Length; i++)
            {
                index[i] = i;
            }
            int[] newValue = new int[index.Length];
            newValue = value;
            for (int i = 0; i < newValue.Length; i++)
            {
                Console.WriteLine(newValue[i]);
            }
            
            Console.WriteLine("o vi tri");
            int vt = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri muon them vao");
            int gt = Int32.Parse(Console.ReadLine());
            if(vt <=1 || vt >= index.Length-1)
            {
                Console.WriteLine("Khong nhap duoc");
            }
            else
            {
                for(int i = 0; i <= index.Length; i++)
                {
                    int them = vt;
                    while(them == index.Length) { 
                    newValue[them + 1] = newValue[them] ;
                    }
                    newValue[vt] = gt;
                }
            }
            for (int i = 0; i < newValue.Length; i++)
            {
                Console.WriteLine(newValue[i]);
            }

            Console.ReadLine();
        }
    }
}
