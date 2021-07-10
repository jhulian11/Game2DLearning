using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gamekit2D
{
    public class BoxDamge : MonoBehaviour
    {
       
        public PlayerCharacter playerCharacter;
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name == "Ellen")
            {
                Texto("Sexo");
                playerCharacter.hurtJumpSpeed = 20;

                
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            Texto("SexoN");
            playerCharacter.hurtJumpSpeed = 8;
        }
        public void Texto(string texto)
        {
            Debug.Log(texto);
          
        }

        
    }
}
