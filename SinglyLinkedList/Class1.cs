using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class SinglyLinkedList<T>
    {
        private class Node
        {
            public Node()
            {

            }
            public Node nextNode;
            public T value;
        }
        private Node topNode;

        public SinglyLinkedList()
        {
            topNode = null;
        }

        public void PushBack(T value)
        {
            if (topNode == null)
            {
                Node firstTop= new Node();
                firstTop.value = value;

                firstTop.nextNode = null;
                topNode = firstTop;

                return;
            }
            Node newTop = new Node();
            newTop.value = value;

            newTop.nextNode= topNode;
            topNode = newTop;
        }
        public void PopElement(T value)
        {
            Node currentNode = topNode;

            if (currentNode.value.Equals(value))
            {
                topNode = currentNode.nextNode;
                return;
            }

            while (currentNode.nextNode != null)
            {
                if (currentNode.nextNode.value.Equals(value))
                {
                    if (currentNode.nextNode != null)
                    {
                        currentNode.nextNode= currentNode.nextNode.nextNode;
                        return;
                    }
                }
                currentNode = currentNode.nextNode;
            }
        }
        public bool Find(T value)
        {
            Node currentNode = topNode;

            while (currentNode.nextNode != null)
            {
                if (currentNode.value.Equals(value))
                {
                    return true;
                }
                currentNode = currentNode.nextNode;
            }
            if (currentNode.value.Equals(value))
                return true;
            return false;
        }
        public T GetFrontElement()
        {
            Node currentElement = topNode;

            while (currentElement.nextNode != null)
            {
                currentElement = currentElement.nextNode;
            }
            return currentElement.value;
        }

        public void PrintList()
        {
            if (topNode == null)
            {
                string message = "Its empty\n";
                throw new ArgumentNullException(message);
            }
            Node current_element = topNode;

            while (current_element != null)
            {
                Console.WriteLine(current_element.value + " ");
                current_element = current_element.nextNode;
            }
            Console.WriteLine();
        }

    }
}
