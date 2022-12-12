﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CourseWork3Sem
{
    class WorkingWithDB: WorkingWithFile
    {
        public static bool IsAdmin;
        public void SaveToDB<T>(Object obj)
        {
            List<T> allCurrenObjects = ReadAllFromDB<T>();

            allCurrenObjects.Add((T)obj);
 
            string serializedObject = JsonConvert.SerializeObject(allCurrenObjects);
            File.WriteAllText(DBFilepath, serializedObject);
        }

        public void SaveToDB<T>(List<T> obj)
        {
            List<T> allCurrenObjects = ReadAllFromDB<T>();

            allCurrenObjects.AddRange(obj);

            string serializedObject = JsonConvert.SerializeObject(allCurrenObjects);

            File.WriteAllText(DBFilepath, serializedObject);
        }

        public bool DeletFromDB<T>(int id)
        {
            List<T> allCurrenObjects = ReadAllFromDB<T>();

            try
            {
                allCurrenObjects.RemoveAt(id);
                SaveToDB<T>(allCurrenObjects);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<T> ReadAllFromDB<T>()
        {
            string json = File.ReadAllText(DBFilepath);
            List<T> currentObjects = JsonConvert.DeserializeObject<List<T>>(json);
            currentObjects.Sort();
            return currentObjects ?? new List<T>();
        }

    }
}