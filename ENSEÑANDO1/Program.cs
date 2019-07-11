using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ENSEÑANDO1
{

    class randy {

        private int x { get; set; }
        private int y { get; set; }
        public void setValores(int xdsf,int ydsf) {
            this.x = xdsf;
            this.y = ydsf;
        }


        public int  sumar() {
            return this.x + this.y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertar los valores");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());



            randy c = new randy();
            c.setValores(x,y);

            int resultado = c.sumar();

            Console.WriteLine(resultado);
            Console.ReadKey();
           
        }
    }
}
