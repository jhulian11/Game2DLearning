using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    public class BoxAcidCheck : MonoBehaviour
    {
        public BoolCheck BoxAcidPrefab = null;
        public GameObject BoxAcid = null;
        public WaterArea AcidSound = null;
        public Vector3 BoxAcidStartPosition = new Vector3();

        

        
        void Start()
        {
            IEnumerator AcidActiveWait()
            {
                yield return new WaitForSeconds(2);
                AcidSound.enabled = true;
                
            }
            StartCoroutine(AcidActiveWait());

            BoxAcidStartPosition = BoxAcid.transform.localPosition;

            if (BoxAcidPrefab.isBoxOnAcid)
            {
                BoxAcid.transform.localPosition = BoxAcidPrefab.BoxAcidPosition;
            }
           
        }

        // Update is called once per frame
        void Update()
        {
            BoxAcidPrefab.BoxAcidPosition = BoxAcid.transform.localPosition;

            if(BoxAcidStartPosition != BoxAcid.transform.localPosition)
            {
                BoxAcidPrefab.isBoxOnAcid = true;
            }

        }              
    }
}
