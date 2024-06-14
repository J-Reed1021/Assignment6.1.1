namespace Assignment6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList houseList = CreateHouseList();

        }

        static internal SingleLinkedList CreateHouseList()
        {
            //Initial linked list
            var houseList = new SingleLinkedList();
            return houseList;

        }
    }

    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    internal class SingleLinkedList
    {
        internal Node head;

        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;

        }
    }


    internal class House
    {
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string HouseType { get; set; }


        House()
        {
            House house = new House();
            Console.WriteLine("Enter the house number: ");
            this.HouseNumber = Console.ReadLine();
            Console.WriteLine("Enter the street name: ");
            this.StreetName = Console.ReadLine();
            Console.WriteLine("Enter the house type: ");
            this.HouseType = Console.ReadLine();
           

        }
    }
}