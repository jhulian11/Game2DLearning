using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Check : MonoBehaviour
{ 
    public BoolCheck Door2Prefab = null;
    public GameObject Door2 = null;
    // Start is called before the first frame update
    void Start()
    {
        if (Door2Prefab.isDoorOpen2)
        {
            Door2.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IsDoorOpenTrue()
    {
        Door2Prefab.isDoorOpen2 = true;
    }
}
