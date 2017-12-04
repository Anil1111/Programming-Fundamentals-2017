using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double significance = double.Parse(Console.ReadLine());
        double curretnPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            curretnPrice = double.Parse(Console.ReadLine());
            double difference = Proc(curretnPrice, significance);
            bool isSignificantDifference = CalculateDifference(difference, significance);
            string message = Get(curretnPrice, curretnPrice, difference, isSignificantDifference);
            Console.WriteLine(message);
            curretnPrice = curretnPrice;
        }
    }

    private static string Get(double c, double last, double razlika, bool etherTrueOrFalse)

     {
        string to = "";
        if (razlika == 0)
        {
            to = string.Format("NO CHANGE: {0}", c);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        else if (etherTrueOrFalse && (razlika < 0))
        {
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        return to;
    }
    private static bool CalculateDifference(double numberOfPrices, double difference)
    {
        if (Math.Abs(numberOfPrices) >= difference)
          {
                return true;
          }
        return false;
    }

    private static double Proc(double significance, double currentPrice)
    {
        double difference = (currentPrice - significance) / significance;
        return difference;
    }
}

