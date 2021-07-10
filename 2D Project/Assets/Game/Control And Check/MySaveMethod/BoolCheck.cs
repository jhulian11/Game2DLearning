using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BoolCheck : MonoBehaviour
{

    public bool isDoorOpen1 = false;
    public bool isDoorOpen2 = false;
    public bool isBoxOnAcid = false;

    public Vector3 BoxAcidPosition = new Vector3();

    // Start is called before the first frame update
  
    void OnPlayModeChange()
    {
       
        if (EditorApplication.isPaused)
        {
            Debug.Log("gg");
            isBoxOnAcid = false;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    

}
