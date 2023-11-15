using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DewDecimalTrainingApp.Data
{
    // Define a class for the Dewey Decimal tree node
    public class DeweyTreeNode
    {
        public string Category { get; set; }
        public List<DeweyTreeNode> Subcategories { get; set; }

        public DeweyTreeNode()
        {
            Subcategories = new List<DeweyTreeNode>();
        }
    }

    public class DeweyTreeStructure
    {
        public DeweyTreeNode Root { get; private set; }

        public DeweyTreeStructure()
        {
            Root = new DeweyTreeNode { Category = "Root" };
        }

        // Add a Dewey category to the tree
        public void AddCategory(string category, List<string> subcategories)
        {
            DeweyTreeNode currentNode = Root;

            foreach (string subcategory in subcategories)
            {
                // Check if the subcategory already exists
                DeweyTreeNode existingNode = currentNode.Subcategories.Find(node => node.Category == subcategory);

                if (existingNode == null)
                {
                    // If the subcategory doesn't exist, add a new node
                    DeweyTreeNode newNode = new DeweyTreeNode { Category = subcategory };
                    currentNode.Subcategories.Add(newNode);
                    currentNode = newNode;
                }
                else
                {
                    // If the subcategory already exists, move to the existing node
                    currentNode = existingNode;
                }
            }
        }

        // Print the tree (for testing and debugging)
        public void PrintTree(DeweyTreeNode node, int indent = 0)
        {
            if (node != null)
            {
                Console.WriteLine(new string(' ', indent) + node.Category);
                foreach (var subcategory in node.Subcategories)
                {
                    PrintTree(subcategory, indent + 2);
                }
            }
        }
    }
}
