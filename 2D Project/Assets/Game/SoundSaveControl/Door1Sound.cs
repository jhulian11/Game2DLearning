using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Sound : MonoBehaviour
{
    public AudioSource PressPlateAudio = null;
    public AudioSource DoorAudio = null;
    public AudioSource Door2Audio = null;
    public AudioSource SwitchAudio = null;

    // Start is called before the first frame update
    void Start()
    {
        PressPlateAudio.enabled = false;
        DoorAudio.enabled = false;
        Door2Audio.enabled = false;
        SwitchAudio.enabled = false;

        IEnumerator PressPlateAudioON()
        {
            yield return new WaitForSeconds(1);
            PressPlateAudio.enabled = true;
            DoorAudio.enabled = true;
            Door2Audio.enabled = true;
            SwitchAudio.enabled = true;

        }

        StartCoroutine(PressPlateAudioON());
    }

    
  
}
