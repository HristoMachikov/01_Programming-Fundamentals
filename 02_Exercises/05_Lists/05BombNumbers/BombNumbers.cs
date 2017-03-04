namespace _05BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BombNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var specialNumbs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bomb = specialNumbs[0];
            int power = specialNumbs[1];
            int sum = 0;

            if (input.Contains(bomb))
            {
                for (int i = 0; i < input.Count; i++)
                {
                    int current = input[i];
                    if (current == bomb)
                    {
                        if ((input.Count - 1) - (i + power) >= 0 && i - power >= 0)
                        {
                            for (int j = i - power; j <= i + power; j++)
                            {
                                input[j] = 0;
                            }

                            input.Sum();
                            sum = input.Sum();
                        }
                        else if ((input.Count - 1) - (i + power) < 0 && i - power >= 0)
                        {
                            for (int j = i - power; j < input.Count; j++)
                            {
                                input[j] = 0;
                            }

                            input.Sum();
                            sum = input.Sum();
                        }
                        else if ((input.Count - 1) - (i + power) >= 0 && i - power < 0)
                        {
                            for (int j = 0; j <= i + power; j++)
                            {
                                input[j] = 0;
                            }

                            input.Sum();
                            sum = input.Sum();
                        }
                        else
                        {
                            Console.WriteLine(0);
                            return;
                        }
                    }
                }
            }
            else
            {
                sum = input.Sum();
            }

            Console.WriteLine(sum);
        }
    }
}