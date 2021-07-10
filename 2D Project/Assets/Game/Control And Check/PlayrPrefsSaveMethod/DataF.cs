using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    public class DataF : MonoBehaviour
    {
        public bool CanLoad = false;

        public Transform AcidBoxPosition = null;
        public Transform PushBox1 = null;

        public bool Door2Open = false;
        public InteractOnTrigger2D SwitchDoor2 = null;

        public GameObject HealthParent = null;
        public List<bool> HealthPickBool = new List<bool>();

        public GameObject ColumnParent = null;
        public List<bool> ColumnDestroyBool = new List<bool>();

        public GameObject EnemiesParent = null;
        public List<bool> EnemiesBool = new List<bool>();



        private void Start()
        {
           
            ListMaker1(HealthParent,HealthPickBool);
            ListMaker1(ColumnParent,ColumnDestroyBool);
            ListMaker1(EnemiesParent,EnemiesBool);
       
            InvokeRepeating(nameof(SaveData), 5f, 5f);

            if (CanLoad == true)
            {
                LoadData();
            }

            if (Door2Open)
            {
                SwitchDoor2.OnEnter.Invoke();
            }

            ListLoaderModifierSceneOnStart(HealthParent, HealthPickBool);
            ListLoaderModifierSceneOnStart(ColumnParent, ColumnDestroyBool);
            ListLoaderModifierSceneOnStart(EnemiesParent, EnemiesBool);      
        }

        private void Update()
        {
            ListModifier1(HealthParent, HealthPickBool);
            ListModifier1(ColumnParent, ColumnDestroyBool);
            ListModifier1(EnemiesParent, EnemiesBool);
        }
        public void SaveData()
        {
            Debug.Log("Saved");
            SaveSystem.SaveData(this);
        }
        public void LoadData()
        {
            DataPrefs data = SaveSystem.LoadData();

            static void ListLoaderData(List<bool> data1, List<bool> Bool)
            {
                for (int i = 0; i < Bool.Count; i++)
                {
                    Bool[i] = data1[i];
                }
            }

            //AcidBox
            Vector3 AcidBoxposition;
            AcidBoxposition.x = data.AcidBoxposition[0];
            AcidBoxposition.y = data.AcidBoxposition[1];
            AcidBoxposition.z = data.AcidBoxposition[2];
            AcidBoxPosition.localPosition = AcidBoxposition;

            //Box1
            Vector3 Pushbox1;
            Pushbox1.x = data.Pushbox1[0];
            Pushbox1.y = data.Pushbox1[1];
            Pushbox1.z = data.Pushbox1[2];
            PushBox1.localPosition = Pushbox1;

            //Door2
            Door2Open = data.Door2open;

            //Listas Health,Column,Enemies
            ListLoaderData(data.HealthPickbool,HealthPickBool);
            ListLoaderData(data.ColumnDestroybool,ColumnDestroyBool);
            ListLoaderData(data.Enimiesbool,EnemiesBool);

        }
        public void Door2Openner()
        {
            Door2Open = true;
        }

         public void ListMaker1(GameObject Parent,List<bool> Bool)
         {
             for (int i = 0; i < Parent.transform.childCount; i++)
             {
                 Bool.Add(Parent);
             }
          }

        public void ListModifier1(GameObject Parent, List<bool> Bool)
        {
            for (int i = 0; i < Bool.Count; i++)
            {
                if (Parent.transform.GetChild(i).transform.GetChild(0).gameObject.activeInHierarchy)
                {
                    Bool[i] = true;
                }
                else
                {
                    Bool[i] = false;
                }
            }
        }
        public void ListLoaderModifierSceneOnStart(GameObject Parent, List<bool> Bool)
        {
            for (int i = 0; i < Bool.Count; i++)
            {
                if (!Bool[i])
                {
                    Parent.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }


    }
}
