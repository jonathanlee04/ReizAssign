using System;
using System.Collections.Generic;

class Branch
{
    public List<Branch> branches = new List<Branch>();
}

class Program
{
    static int CalculateDepth(Branch branch)
    {
        if (branch.branches.Count == 0) //set counter
        {
            return 1;
        }
        else
        {
            int maxDepth = 0; //initialize variable for maximun depth
            foreach (Branch subBranch in branch.branches)
            {
                int subDepth = CalculateDepth(subBranch); //recursive method
                if (subDepth > maxDepth)
                {
                    maxDepth = subDepth;
                }
            }
            return maxDepth + 1;
        }
    }

    static void Main(string[] args)
    {
        Branch root = new Branch();
        root.branches.Add(new Branch()); //depth 1 with 2 branches
        root.branches.Add(new Branch()); 
        root.branches[0].branches.Add(new Branch()); //root.branch1 with 1 branch
        root.branches[1].branches.Add(new Branch()); //root.branch2 with 3 branches
        root.branches[1].branches.Add(new Branch());
        root.branches[1].branches.Add(new Branch());
        root.branches[1].branches[0].branches.Add(new Branch()); //root.branch2.branch1 with 1 branch
        root.branches[1].branches[1].branches.Add(new Branch()); //root.branch2.branch2 with 2 branches
        root.branches[1].branches[1].branches.Add(new Branch());
        root.branches[1].branches[1].branches[0].branches.Add(new Branch()); //root.branch2.branch2.branch1 with 1 branch

        //the expected output of depth should be 5

        int depth = CalculateDepth(root); //a recursive method that calculates the depth of a given branch
        Console.WriteLine("Depth: " + depth);

        Console.ReadKey();
    }
}