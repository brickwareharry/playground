// Coding Challenges
//      Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//      You give that each input have exactly one solution.
//
// Solutions are below.
//
// Command for running the result in powershell: ...\two_sum> dotnet run

namespace two_sum;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = [2, 7, 11, 15];//user gives nums
        int target = 9;//user gives target

        // Solution 1
        int[] result = new int[2];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }

        //Solution 2 (not sure if it works or not in case of that two keys of the dictionary are the same)        
        // int[] result = new int[2];
        // Dictionary<int, int> myHashMap = new Dictionary<int, int>();
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     int complement = target - nums[i];
        //     if (myHashMap.ContainsKey(complement))
        //     {
        //         result[1] = i;
        //         result[0] = myHashMap[complement];
        //     }
        //     myHashMap.Add(nums[i], i);
        // };

        Console.WriteLine("[{0}]", string.Join(", ", result));
    }

}
