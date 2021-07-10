using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Gamekit2D
{
    public class AcidBoxSound : MonoBehaviour
    {
        public WaterArea AcidSound = null;
        // Start is called before the first frame update
        void Start()
        {
            IEnumerator AcidActiveWait()
            {
                yield return new WaitForSeconds(2);
                AcidSound.enabled = true;

            }
            StartCoroutine(AcidActiveWait());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
