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

        public bool door1IsOpen = false;
        public GameObject door1 = null;

        public bool door3IsOpen = false;
        public GameObject door3 = null;
        public GameObject door3Trigger = null;

        public GameObject HealthParent = null;
        public List<bool> HealthPickBool = new List<bool>();

        public GameObject ColumnParent = null;
        public List<bool> ColumnDestroyBool = new List<bool>();

        public GameObject EnemiesParent = null;
        public List<bool> EnemiesBool = new List<bool>();



        private void Start()
        {
           
            SaveFunctionUtility.ListMaker1(HealthParent,HealthPickBool);
            SaveFunctionUtility.ListMaker1(ColumnParent,ColumnDestroyBool);
            SaveFunctionUtility.ListMaker1(EnemiesParent,EnemiesBool);
       
            InvokeRepeating(nameof(SaveData), 5f, 5f);
            
            if (CanLoad == true)
            {
                LoadData();
            }            

            if (Door2Open)
            {
                SwitchDoor2.OnEnter.Invoke();
            }

            SaveFunctionUtility.ListLoaderModifierSceneOnStart(HealthParent, HealthPickBool);
            SaveFunctionUtility.ListLoaderModifierSceneOnStart(ColumnParent, ColumnDestroyBool);
            SaveFunctionUtility.ListLoaderModifierSceneOnStart(EnemiesParent, EnemiesBool);

            StartCoroutine(Delay(0.01f));

        }

        private void Update()
        {
            if (!door3Trigger.activeInHierarchy)
                door3IsOpen = true;

            SaveFunctionUtility.ListModifier1(HealthParent, HealthPickBool);
            SaveFunctionUtility.ListModifier1(ColumnParent, ColumnDestroyBool);
            SaveFunctionUtility.ListModifier1(EnemiesParent, EnemiesBool);


        }
        public void SaveData()
        {
            Debug.Log("Saved");
            SaveSystem.SaveData(this);
        }
        public void LoadData()
        {
            DataPrefs data = SaveSystem.LoadData();
            
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

            //Door1
            door1IsOpen = data.door1Isopen;

            //Door3
            door3IsOpen = data.door3Isopen;

            //Listas Health,Column,Enemies
            SaveFunctionUtility.ListLoaderData(data.HealthPickbool,HealthPickBool);
            SaveFunctionUtility.ListLoaderData(data.ColumnDestroybool,ColumnDestroyBool);
            SaveFunctionUtility.ListLoaderData(data.Enimiesbool,EnemiesBool);

        }
        public void Door2Openner()
        {
            Door2Open = true;
        }

        public void door1IsOpenChanger()
        {            
          door1IsOpen = true;         
        }
        IEnumerator Delay(float time)
        {
            yield return new WaitForSeconds(time);

            SaveFunctionUtility.Door1SetDesactive(door1IsOpen, door1);
            SaveFunctionUtility.Door3SetDesactive(door3IsOpen, door3);
        }
    }
}
