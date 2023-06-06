using System;

namespace DataStructuresAndAlgorithms.BigO
{
    public class O_n_2_
    { 

        public void loopThrough()
        {
            string[] boxes = { "a", "b", "c", "d", "e" };

            foreach (var box1 in boxes)
            {
                foreach (var box2 in boxes)
                {
                    Console.WriteLine($"{box1} {box2}");
                }
            }
        }
    }
}