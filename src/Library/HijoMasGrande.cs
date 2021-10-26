using System;

namespace Library
{
    public class HijoMasGrande: Visitor
    {
        public static string NombreMasGrande = "";
        public static int EdadMasGrande = 0;
        public override void Visit(Node nodo)
        {
            if (nodo.Persona.Edad > EdadMasGrande)
            {
                EdadMasGrande = nodo.Persona.Edad;
                NombreMasGrande = nodo.Persona.Nombre;
            }
            foreach (Node hijo in nodo.Children)
            {
                hijo.Accept(this);
            }
        }
    }
}