using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeleportSFX : MonoBehaviour
{
    public UnityEvent TeleportSoundOn;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Ellen")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                TeleportSoundOn.Invoke();
            }
        }
    }
}
