using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public List<Sound> Sounds;
    public static AudioManager Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        foreach (Sound s in Sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clip;
            s.Source.volume = s.Volume;
            s.Source.pitch = s.Pitch;
            s.Source.loop = s.Loop;
        }
    }

    private void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        Sound s = Sounds.Find(s => s.Name == name);
        if (s == null)
        {
            Debug.LogWarning($"Sound {name} could not be found");
            return;
        }
        s.Source.Play();
    }

    public bool IsPlaying(string name)
    {
        Sound s = Sounds.Find(s => s.Name == name);
        return s.Source.isPlaying;
    }

    public void Stop(string name)
    {
        Sound s = Sounds.Find(s => s.Name == name);
        if (s == null)
        {
            Debug.LogWarning($"Sound {name} could not be found");
            return;
        }
        s.Source.Stop();
    }
}
