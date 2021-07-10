using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheck : MonoBehaviour
{
    public GameObject Door1 = null;
    public BoolCheck DoorCheckPrefab = null;
    public bool UpdateControl = false;
    public GameObject Box1 = null;
    public AudioSource PressPlateAudio = null;
    public Animator DoorClosing = null;
    // Start is called before the first frame update

    void Start()
    {

        PressPlateAudio.enabled = false;

        IEnumerator PressPlateAudioON()
        {
            yield return new WaitForSeconds(1);
            PressPlateAudio.enabled = true;
        }

        StartCoroutine(PressPlateAudioON());

        if (DoorCheckPrefab.isDoorOpen1)
        {        
            UpdateControl = true;
            Box1.transform.localPosition = new Vector2((29.38f), (18.77f));
        }        
    }

    private void Update()
    {
        
        if (UpdateControl)
        {
            Door1.SetActive(false);         
        }

    }

    
    public void  isDoorOpenT()
    {
        DoorCheckPrefab.isDoorOpen1 = true;
    }
    public void isDoorOpenF()
    {
        DoorCheckPrefab.isDoorOpen1 = false;
    }

    public void DoorResurge()
    {
        if(!Door1.activeSelf)
        {
            UpdateControl = false;
            Door1.SetActive(true);
            DoorClosing.Play("DoorClosing");
        }
    }

}
