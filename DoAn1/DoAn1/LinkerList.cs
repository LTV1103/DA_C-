namespace DoAn1
{
    public class LinkerList
    {
        Node head;
        Node tail;
        public void ThemDau(int data)
        {
            Node newnode = new Node();
            newnode.data = data;
            newnode.next = head;
            newnode.prev = null;
            if (head != null)
                head.prev = newnode;
            head = newnode;

        }

        public Node DuyetNode()
        {
            Node temp = head;
            while (temp.next != null)
                temp = temp.next;
            return temp;
        }
        public void ThemCuoi(int data)
        {
            Node newnode = new Node();
            newnode.data = data;
            if (head == null)
            {
                newnode.prev = null;
                head = newnode;
                return;
            }
            Node lastNode = DuyetNode();
            lastNode.next = newnode;
            newnode.prev = lastNode;
        }
        public void ThemsauX(Node prevNode, int X)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Node truoc do khong the la NULL");
                return;
            }
            Node newnode = new Node();
            newnode.data = X;
            newnode.next = prevNode.next;
            prevNode.next = newnode;
            newnode.prev = prevNode;
            if (newnode.next != null)
                newnode.next.prev = newnode;
        }

        public void Xoadau()
        {
            if (head == null) 
                return;
            if (head.next == null)
            {
                head = null;
                return;
            }
            Node second = head.next;
            head.next = null;
            second.prev = null;
            head = second;
        }
        public void XoaCuoi()
        {
            if (head == null)
                if (head.next == null)
                {
                    head = null;
                    return;
                }
            Node second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;

            second_last.next = null;
        }
        public void XoaGiua(Node del)
        {
            if (head == null || del == null)
                return;
            if (head == del)
                head = del.next;
            if (del.next != null)
                del.next.prev = del.prev;
            if (del.prev != null)
                del.prev.next = del.next;
        }
        public Node timkiem(int key)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == key)
                    return temp;
                temp = temp.next;
            }
            return null;
        }
            public void Nhap()
        {
            int n, data;
            
            Console.Write("Nhap so luong phan tu trong DS: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu " + (i + 1) + ":");
                data = Convert.ToInt32(Console.ReadLine());
                this.ThemCuoi(data);
            }
        }
        public void Xuat()
        {
            Console.Write("Danh Sach Node: ");
            Node node = head;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }


}

