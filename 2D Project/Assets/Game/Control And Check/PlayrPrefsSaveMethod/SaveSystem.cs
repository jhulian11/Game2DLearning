using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gamekit2D
{
    public static class SaveSystem
    {
        public static void SaveData(DataF data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/Data.fuckyou";
            FileStream stream = new FileStream(path, FileMode.Create);

            DataPrefs data1 = new DataPrefs(data);

            formatter.Serialize(stream, data1);
            stream.Close();
        }

        public static DataPrefs LoadData()
        {
            string path = Application.persistentDataPath + "/Data.fuckyou";
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                DataPrefs data = formatter.Deserialize(stream) as DataPrefs;
                stream.Close();

                return data;



            }
            else
            {
                Debug.LogError("Save file not found in " + path);
                return null;
            }


        }
    }
}
