using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1TextTriggerScript : MonoBehaviour
{
    public GameObject textBox = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ellen")
        {
            textBox.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Ellen")
        {
            textBox.SetActive(false);
        }
    }
}
