using System;
using System.Collections.Generic;

class FitnessCenter
{
    static void Main()
    {
        List<int[]> clientsData = new List<int[]>();

        clientsData.Add(new int[] { 2021, 1, 2, 1 });
        clientsData.Add(new int[] { 2021, 1, 3, 2 });
        clientsData.Add(new int[] { 2021, 2, 1, 3 });
        clientsData.Add(new int[] { 2022, 1, 4, 4 });
        clientsData.Add(new int[] { 2022, 1, 2, 5 });
        clientsData.Add(new int[] { 2022, 2, 3, 6 });
        clientsData.Add(new int[] { 2023, 2, 4, 7 });
        clientsData.Add(new int[] { 2023, 2, 2, 8 });
        clientsData.Add(new int[] { 2023, 2, 3, 9 });
        clientsData.Add(new int[] { 2023, 2, 1, 10 });
        clientsData.Add(new int[] { 2024, 2, 2, 11 });
        clientsData.Add(new int[] { 2024, 2, 4, 12 });
        clientsData.Add(new int[] { 2024, 2, 1, 13 });
        clientsData.Add(new int[] { 2024, 2, 3, 14 });


        Dictionary<int, int> totalDurationByYear = new Dictionary<int, int>();

        foreach (int[] clientData in clientsData)
        {
            int year = clientData[0];
            int duration = clientData[2];

            if (totalDurationByYear.ContainsKey(year))
            {
                totalDurationByYear[year] += duration;
            }
            else
            {
                totalDurationByYear[year] = duration;
            }
        }

        int maxDuration = 0;
        int maxYear = int.MaxValue;

        foreach (KeyValuePair<int, int> entry in totalDurationByYear)
        {
            int year = entry.Key;
            int duration = entry.Value;

            if (duration > maxDuration || (duration == maxDuration && year < maxYear))
            {
                maxDuration = duration;
                maxYear = year;
            }
        }

        Console.WriteLine("Год с наибольшей суммарной продолжительностью занятий: " + maxYear);
        Console.WriteLine("Наибольшая суммарная продолжительность: " + maxDuration + " часов");
    }
}