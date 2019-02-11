using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private static MusicController instance = null;
    private AudioSource music;
    public static MusicController Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void Start()
    {
        music = GetComponent<AudioSource>();
        StartCoroutine(PlayMusic());
    }
    IEnumerator PlayMusic()
    {
        yield return new WaitForSeconds(10);
        music.Play();
    }
}
