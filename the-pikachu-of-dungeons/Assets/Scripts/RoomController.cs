using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomController : MonoBehaviour
{
    // public whatever narration we're throwing in there
    // public whatever ending narratio

    void Start()
    {
        // play opening narration
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Changes the room to another one. Nice.
    public void ChangeRoom(string scene){
        // freeze scene
        // play ending narrations
        SceneManager.LoadSceneAsync(scene);
    }
}
