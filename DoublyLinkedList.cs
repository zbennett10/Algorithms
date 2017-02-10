//Implement a doubly linked list
        public class Node
        {
            public bool IsRoot { get; set; }
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            public Node(int value)
            {
                this.Value = value;
            }

            public Node(bool isRoot)
            {
                this.IsRoot = isRoot;
                this.Next = null;
                this.Prev = null;
            }

            public Node(bool isRoot, int value)
            {
                this.IsRoot = isRoot;
                this.Value = value;
                this.Next = null;
                this.Prev = null;
            }

            public Node(bool isRoot, int value, Node next, Node prev)
            {
                this.IsRoot = isRoot;
                this.Value = value;
                this.Next = next;
                this.Prev = prev;
            }

            public void updatePrev(int value)
            {
                this.Prev.Value = value;
            }

            public void updateNext(int value)
            {
                this.Next.Value = value;
            }
        }

        public class DoublyLinkedList
        {
            public Node Root = new Node(true);

            public DoublyLinkedList(int rootValue)
            {
                this.Root.Value = rootValue;
            }

            public DoublyLinkedList(int rootValue, List<Node> nodes)
            {
                this.Root.Value = rootValue;
                this.Root.Next = nodes[0];
                nodes[0].Prev = this.Root;
                for(int i = 0; i < nodes.Count - 1; i++)
                {
                    nodes[i].Next = nodes[i + 1];
                }
                for(int i = 1; i < nodes.Count; i++)
                {
                    nodes[i].Prev = nodes[i - 1];
                }
            }

            public DoublyLinkedList(List<int> nodeValues)
            {
                List<Node> nodeList = new List<Node>();

                this.Root.Value = nodeValues[0];
                for(int i = 1; i < nodeValues.Count; i++)
                {
                    nodeList.Add(new Node(nodeValues[i]));
                }
                for(int i = 0; i < nodeList.Count - 1; i++)
                {
                    nodeList[i].Next = nodeList[i + 1];
                    if (i == 0) nodeList[i].Prev = this.Root;
                    else nodeList[i].Prev = nodeList[i - 1];
                }
                this.Root.Next = nodeList[0];
                nodeList[nodeList.Count - 1].Prev = nodeList[nodeList.Count - 2];
            }

       
        }
