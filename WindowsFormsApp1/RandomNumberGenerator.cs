using System;

namespace WindowsFormsApp1
{
    public class RandomNumberGenerator
    {
        public string myStringValue { get; set; }
        public int[] randomNumber = new int[10];
        public string RandomTelephoneGenerator()
        {
            
            
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                randomNumber[i] = random.Next(0, 10);

            }
           // cacavaloare = string.Join(" ", Convert.ToString(randomNumber);

            foreach (var valoareIndividuala in randomNumber)
            {
               myStringValue =  myStringValue + String.Join(" ", Convert.ToString(valoareIndividuala));
            }
            return myStringValue;
        }
    }
}
