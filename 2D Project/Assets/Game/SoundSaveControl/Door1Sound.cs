using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Sound : MonoBehaviour
{
    public AudioSource PressPlateAudio = null;
    public AudioSource DoorAudio = null;
    public AudioSource Door2Audio = null;
    public AudioSource SwitchAudio = null;

    public AudioSource Door3Audio = null;

    // Start is called before the first frame update
    void Start()
    {
        PressPlateAudio.enabled = false;
        DoorAudio.enabled = false;
        Door2Audio.enabled = false;
        SwitchAudio.enabled = false;

        Door3Audio.enabled = false;

        IEnumerator AudioON()
        {
            yield return new WaitForSeconds(1);
            PressPlateAudio.enabled = true;
            DoorAudio.enabled = true;
            Door2Audio.enabled = true;
            SwitchAudio.enabled = true;

            Door3Audio.enabled = true;


        }

        StartCoroutine(AudioON());
    }

    
  
}
