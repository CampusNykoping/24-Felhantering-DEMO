using System.Runtime.Serialization;

namespace _05_Kasta_undantag
{
    class Program
    {
        public static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Roten ur negativa tal är inte definierat");
            }

            return Math.Sqrt(value);
        }

        static int rakna(int a, int b, int c)
        {
            if (b > c)
            {
                throw new TankException("Bränslet räcker inte ända fram");
                //throw new TankException();
            }
            var res1 = c / b;
            var res2 = c % b;
            Console.WriteLine($"{c} / {a} = {res1} \n{c} % {b} = {res2}");
            return res1 + res2;
        }

        static void Main(string[] args)
        {
            try
            {
                var result = rakna(5, 5, 3);
                Console.WriteLine("Result = {0}", result);

                Sqrt(-1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Error.WriteLine("Fel: " + e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"Något annat gick fel: {e.Message}");
            }
        }
    }

    /// <summary>
    /// Exception to throw when the fuel calculations indicate insufficient fuel in the vehicle
    /// </summary>
    [Serializable]
    internal class TankException : Exception
    {
        public TankException()
        {
        }

        public TankException(string? message) : base(message)
        {
        }

        public TankException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TankException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
