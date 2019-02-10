using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // On collision, send the RoomController something about changing the room.
    public string nextScene;
    public RoomController rc;

    private void Start() { 
        if( nextScene == "" ){ // because I don't want to deal w/ deleting extra doors in RoomBasics. :D
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if ( other.gameObject.tag == "Player" ){
            rc.ChangeRoom(nextScene);
        }
    }
}
 