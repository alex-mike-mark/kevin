using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // On collision, send the RoomController something about changing the room.

    private void OnTriggerEnter2D(Collider2D other) {
        if ( other.gameObject.tag == "Player" ){
            Debug.Log("Player hit111!");
        }
    }
}
 