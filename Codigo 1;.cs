using UnityEngine;

Public class Ckretka : MonoBehaviour{
    public float detectionRange = 10f;
    public float Collision = 2f;

    {
    
        public class Arma
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Arma(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
    }
Plublic class tienda
[
    armas = new list<Arma>();
]
class program
{

        static void main(string[]args)

        Tienda tienda= new Tienda();
        tienda.armas.Add(new Arma("AK-47", 1700));
        Tienda.armas.add(new Arma("Mp4", 1100));
        Console.Writeline("Press E to open the store")

        while (true)
        {
            if(console.readyKey(true).Key = ConsoleKey.E)
            {Console.Clear();
                    tienda.MostrarArmas();
                    Console.WriteLine("Press any key to escape of the store");
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.WriteLine("Press E to open the store");
        }
{

}

}
}
}