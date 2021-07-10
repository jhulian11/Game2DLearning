using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDataScript : MonoBehaviour
{
    public Transform BoxAcidPostion = null;
    public MyDataOUT DataOUT;

    private void Start()
    {
        InvokeRepeating("SaveData",5f,5f);

    }

    public void SaveData()
    {
        MySaveMethod.MySaveData(this);
        Debug.Log("Save2");
    }

    private void Update()
    {
        
    }
}
