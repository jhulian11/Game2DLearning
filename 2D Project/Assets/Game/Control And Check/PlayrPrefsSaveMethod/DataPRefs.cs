using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    [System.Serializable]
    public class DataPrefs
    {
        public float[] AcidBoxposition;
        public float[] Pushbox1;
        public bool Door2open;
        public bool door1Isopen;
        public List<bool> HealthPickbool = new List<bool>();
        public List<bool> ColumnDestroybool = new List<bool>();
        public List<bool> Enimiesbool = new List<bool>();


        public DataPrefs(DataF data)
        {
            AcidBoxposition = new float[3];
            AcidBoxposition[0] = data.AcidBoxPosition.localPosition.x;
            AcidBoxposition[1] = data.AcidBoxPosition.localPosition.y;
            AcidBoxposition[2] = data.AcidBoxPosition.localPosition.z;

            Pushbox1 = new float[3];
            Pushbox1[0] = data.PushBox1.localPosition.x;
            Pushbox1[1] = data.PushBox1.localPosition.y;
            Pushbox1[2] = data.PushBox1.localPosition.z;

            Door2open = data.Door2Open;

            door1Isopen = data.door1IsOpen;

            for (int i = 0; i < data.HealthPickBool.Count; i++)
            {
                HealthPickbool.Add(data.HealthPickBool[i]);
            }

            for (int i = 0; i < data.ColumnDestroyBool.Count; i++)
            {
                ColumnDestroybool.Add(data.ColumnDestroyBool[i]);
            }

            for (int i = 0; i < data.EnemiesBool.Count; i++)
            {
                Enimiesbool.Add(data.EnemiesBool[i]);
            }


        }
    }
}
