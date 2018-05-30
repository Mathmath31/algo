using System;
using System.Diagnostics;

namespace algo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création de l'arbre
            Node root = null;
            Arbre bst = new Arbre();
            int[] liste = new int[] { 21, 9, 12, 34, 36, 35, 5, 8, 1, 25 };

            for (int i = 0; i < liste.Length; i++)
            {
                root = bst.insert(root, liste[i]);
            }
            Console.WriteLine("Parcours Prefixe");
            parcoursPréfixe(root);
            Console.WriteLine("Parcours Infixe");
            parcoursInfixe(root);
            Console.WriteLine("Parcours PostFixe");
            parcoursPostfixe(root);
            Console.ReadLine();
            
        }

        static void parcoursPréfixe(Node a)
        {
            if (a == null)
                return;
            Console.WriteLine(a.value + " " );
            parcoursPréfixe(a.right);
            parcoursPréfixe(a.left);
        }

        static void parcoursInfixe(Node a)
        {
            if (a == null)
                return;
            Console.WriteLine(a.value + " ");
            parcoursInfixe(a.left);
            parcoursInfixe(a.right);
        }

        static void parcoursPostfixe(Node a)
        {
            if (a == null)
                return;
            Console.WriteLine(a.value + " ");
            parcoursPostfixe(a.left);
            parcoursPostfixe(a.right);
            
        }

    }

    class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    class Arbre
    {
        public Node insert(Node root, int v)
        {
            if (root == null)
            {
                root = new Node();
                root.value = v;
            }
            else if (v < root.value)
            {
                root.left = insert(root.left, v);
            }
            else
            {
                root.right = insert(root.right, v);
            }

            return root;
        }

        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            traverse(root.left);
            traverse(root.right);
        }
    }
}

