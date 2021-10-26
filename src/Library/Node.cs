using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node 
    {
        private Persona persona;

        private List<Node> children = new List<Node>();

        public Persona Persona {
            get
            {
                return this.persona;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int edad, string nombre)
        {
            this.persona = new Persona(nombre, edad);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visit)
        {
            visit.Visit(this);
        }
    }
}
