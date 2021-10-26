using System;

namespace Library
{
    public class NombreMasLargo: Visitor
    {
        public static string nombreMasLargo = "";
        public override void Visit(Node nodo)
        {
            if (nodo.Persona.Nombre.Length > nombreMasLargo.Length)
            {
                nombreMasLargo = nodo.Persona.Nombre;
            }
            foreach (Node hijo in nodo.Children)
            {
                hijo.Accept(this);
            }
        }
    }
}