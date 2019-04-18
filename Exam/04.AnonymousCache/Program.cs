namespace _04.AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<DataSet> dataSets = new List<DataSet>();
            List<DataSet> cache = new List<DataSet>();
            string input;
            while ((input = Console.ReadLine()) != "thetinggoesskrra")
            {
                string[] inputArgs = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.None);
                if (inputArgs.Length == 1)
                {
                    string name = inputArgs[0];
                    if (!dataSets.Any(x => x.Name == name))
                    {
                        dataSets.Add(DataSet.ReadDataSet(name));
                    }

                    if (cache.Any(x => x.Name == name) && dataSets.Any(x => x.Name == name))
                    {
                        int indexOfdataSetMatch = dataSets.FindIndex(x => x.Name == name);
                        int indexOfExCache = cache.FindIndex(x => x.Name == name);
                        foreach (var item in cache[indexOfExCache].DataKeysSize)
                        {
                            dataSets[indexOfdataSetMatch].DataKeysSize.Add(item.Key, item.Value);
                        }
                        cache.RemoveAt(indexOfExCache);
                    }
                }
                else if (inputArgs.Length == 3)
                {
                    string dataKey = inputArgs[0];
                    long dataSize = long.Parse(inputArgs[1]);
                    string dataSet = inputArgs[2];

                    if (!dataSets.Any(x => x.Name == dataSet))
                    {
                        if (!cache.Any(x => x.Name == dataSet))
                        {
                            DataSet currentDataSet = DataSet.ReadDataSet(dataSet);
                            currentDataSet.DataKeysSize.Add(dataKey, dataSize);
                            cache.Add(currentDataSet);
                        }
                        else if (cache.Any(x => x.Name == dataSet))
                        {
                            int indexOfExCache = cache.FindIndex(x => x.Name == dataSet);
                            cache[indexOfExCache].DataKeysSize.Add(dataKey, dataSize);
                        }
                    }
                    else
                    {
                        int indexOfExDataSet = dataSets.FindIndex(x => x.Name == dataSet);
                        dataSets[indexOfExDataSet].DataKeysSize.Add(dataKey, dataSize);
                    }


                    if (cache.Any(x => x.Name == dataSet) && dataSets.Any(x => x.Name == dataSet))
                    {
                        int indexOfdataSetMatch = dataSets.FindIndex(x => x.Name == dataSet);
                        int indexOfExCache = cache.FindIndex(x => x.Name == dataSet);
                        foreach (var item in cache[indexOfExCache].DataKeysSize)
                        {
                            dataSets[indexOfdataSetMatch].DataKeysSize.Add(item.Key, item.Value);
                        }
                        cache.RemoveAt(indexOfExCache);
                    }
                }
            }
            foreach (DataSet ds in dataSets.OrderByDescending(x => x.DataKeysSize.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {ds.Name}, Total Size: {ds.DataKeysSize.Values.Sum()} ");
                foreach (var dataKey in ds.DataKeysSize)
                {
                    Console.WriteLine($"$.{dataKey.Key}");
                }
                return;
            }

        }
    }

    public class DataSet
    {
        public string Name { get; set; }
        public Dictionary<string, long> DataKeysSize { get; set; }

        public static DataSet ReadDataSet(string name)
        {
            return new DataSet
            {
                Name = name,
                DataKeysSize = new Dictionary<string, long>()
            };
        }
    }
}