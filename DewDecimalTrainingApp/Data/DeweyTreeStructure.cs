using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DewDecimalTrainingApp.Data
{
    // Define a class for the Dewey Decimal tree node
    public class DeweyTreeNode
    {
        public string Name { get; set; }
        public Dictionary<string, DeweyTreeNode> Subcategories { get; set; }

        public DeweyTreeNode()
        {
            Subcategories = new Dictionary<string, DeweyTreeNode>();
        }
    }

    public class DeweyTreeStructure
    {
        public DeweyTreeNode Root { get; private set; }

        public DeweyTreeStructure()
        {
            Root = new DeweyTreeNode { Name = "Root" };

            // Call the method with the root of the tree
            ThirdLevelNodes = GetThirdLevelNodes(Root);
        }

        // Add a Dewey category to the tree
        public void AddCategory(string category, List<string> subcategories)
        {
            DeweyTreeNode currentNode = Root;

            foreach (string subcategory in subcategories)
            {
                // Check if the subcategory already exists
                if (!currentNode.Subcategories.TryGetValue(subcategory, out DeweyTreeNode existingNode))
                {
                    // If the subcategory doesn't exist, add a new node
                    DeweyTreeNode newNode = new DeweyTreeNode { Name = subcategory };
                    currentNode.Subcategories[subcategory] = newNode;
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
        // Inside DeweyTreeStructure class
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            PrintTree(Root, 0, stringBuilder);
            return stringBuilder.ToString();
        }

        // Modify the PrintTree method to append to the StringBuilder
        public void PrintTree(DeweyTreeNode node, int indent, StringBuilder stringBuilder)
        {
            if (node != null)
            {
                stringBuilder.AppendLine(new string(' ', indent) + node.Name);
                foreach (var subcategory in node.Subcategories)
                {
                    PrintTree(subcategory.Value, indent + 2, stringBuilder);
                }
            }
        }

        public List<DeweyTreeNode> GetThirdLevelNodes(DeweyTreeNode node, int currentLevel = 1)
        {
            List<DeweyTreeNode> thirdLevelNodes = new List<DeweyTreeNode>();

            if (currentLevel == 3)
            {
                // If the current level is 3, add the current node
                thirdLevelNodes.Add(node);
            }
            else
            {
                // If the current level is less than 3, recursively traverse subcategories
                foreach (var subcategory in node.Subcategories)
                {
                    thirdLevelNodes.AddRange(GetThirdLevelNodes(subcategory.Value, currentLevel + 1));
                }
            }

            return thirdLevelNodes;
        }

        // Property to store third-level nodes for later use
        public List<DeweyTreeNode> ThirdLevelNodes { get; private set; }

        // New method to get top-level nodes
        public List<DeweyTreeNode> GetTopLevelNodes()
        {
            return Root.Subcategories.Values.ToList();
        }
    }
}
