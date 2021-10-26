using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, "juan");
            Node n2 = new Node(2, "juancho");
            Node n3 = new Node(3, "juancito");
            Node n4 = new Node(4, "juanco");
            Node n5 = new Node(5, "juanpe");
            Node n6 = new Node(6, "juanma");
            Node n7 = new Node(7, "juanlu");
            Node n8 = new Node(8, "juanse");

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            Visitor visitor = new Visitar();
            Visitor masGrande = new HijoMasGrande();
            Visitor nombreMasLargo = new NombreMasLargo();
            n1.Accept(visitor);
            n1.Accept(masGrande);
            n1.Accept(nombreMasLargo);
            Console.WriteLine($"Suma edades: {Visitar.edades}");
            Console.WriteLine($"Hijo más grande: {HijoMasGrande.NombreMasGrande}");
            Console.WriteLine($"Nombre más largo: {NombreMasLargo.nombreMasLargo}");
            
        }
    }
}
