using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DoAn2.Tree;

namespace DoAn2
{
    public class Tree
    {
        public node root;
        public Tree() { root = null; }
        public node taoNode(int x)
        {
            node node = new node();
            node.data = x;
            node.left = null;
            node.right = null;
            return node;
        }
        public void nhap(node node, int data)
        {
            if (root == null)
            {
                root = taoNode(data);
            }
            else
            {
                if (data < node.data)
                {
                    if (node.left != null)
                    {
                        nhap(node.left, data);
                    }
                    else
                    {
                        node.left = taoNode(data);
                    }
                }
                else
                {
                    if (node.right != null)
                    {
                        nhap(node.right, data);
                    }
                    else
                    {
                        node.right = taoNode(data);
                    }
                }
            }
        }

        public void xuat(node root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                xuat(root.left);
                xuat(root.right);
            }
        }
        public void NLR(node root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                NLR(root.left);
                NLR(root.right);
            }
        }
        public bool timkiem(node node, int t)
        {
            if (node == null)
            {
                return false;
            }
            else if (t < node.data)
            {
                return timkiem(node.left, t);
            }
            else if (t > node.data)
            {
                return timkiem(node.right, t);
            }
            else
            {
                return true;
            }
        }
        public void LNR(node root)
        {
            if (root != null)
            {
                LNR(root.left);
                Console.Write(root.data + " ");
                LNR(root.right);
            }
        }
        public void LRN(node root)
        {
            if (root != null)
            {
                LRN(root.left);
                LRN(root.right);
                Console.Write(root.data + " ");
            }
        }
        public void them(node node, int value)
        {
            if (value < node.data)
            {
                if (node.left == null)
                {
                    node.left = new node { data = value };
                }
                else
                {
                    them(node.left, value);
                }
            }
            else
            {
                if (node.right == null)
                {
                    node.right = new node { data = value };
                }
                else
                {
                    them(node.right, value);
                }
            }
        }
        public void DeleteKey(int key)
        {
            root = DeleteRec(root, key);
        }

        node DeleteRec(node root, int key)
        {
            if (root == null) return root;

            if (key < root.data)
                root.left = DeleteRec(root.left, key);
            else if (key > root.data)
                root.right = DeleteRec(root.right, key);
            else
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                root.data = MinValue(root.right);

                root.right = DeleteRec(root.right, root.data);
            }

            return root;
        }

        int MinValue(node root)
        {
            int minv = root.data;
            while (root.left != null)
            {
                minv = root.left.data;
                root = root.left;
            }
            return minv;
        }

        public class node
        {
            public int data;
            public node left;
            public node right;
        }

    }
}

