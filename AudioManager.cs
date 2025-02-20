using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public bool DESTROY;

    public static AudioManager Instance;
    void Awake()
    {

        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

       

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    
    public void Play(string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }

    void Start()
    {
       
    }

    private void Update()
    {
       if(DESTROY == true)
        {

        }
       else if (DESTROY == false)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}