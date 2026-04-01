using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Modul5_103022400081
{
    class SimpleDataBase<T>
    {
        private List<T> StoredData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            StoredData = new List <T>();
            inputDates = new List<DateTime>();
        }
        public void addNewData(T data)
        {
            StoredData.Add(data);
            DateTime D1 = DateTime.Now; 
            inputDates.Add(D1);
        }
        public void printAllData()
        {
            for (int i = 0; i < StoredData.Count; i++)
            {
                Console.WriteLine($"data {i + 1} berisi = {StoredData[i]} yang disimpan pada waktu UTC = {inputDates[i]}");
            }
        }
    }
}
