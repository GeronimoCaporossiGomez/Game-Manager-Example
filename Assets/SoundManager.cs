using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource sourceSFX;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;

        }
        DontDestroyOnLoad(this);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlaySound(AudioClip clip)
    {
        sourceSFX.PlayOneShot(clip);
    }
}
