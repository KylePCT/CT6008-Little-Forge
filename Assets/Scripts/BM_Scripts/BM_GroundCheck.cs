using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BM_GroundCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Ground") {
            BM_CharacterController.isGrounded = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Ground") {
            BM_CharacterController.isGrounded = false;
        }
    }
}
