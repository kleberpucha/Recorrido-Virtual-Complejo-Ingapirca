using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioRandomScena : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioMixerGroup output;
    
    // Start is called before the first frame update
    void Start()
    {
            PlaySound();
    }
    void PlaySound() {
        
        int random = Random.Range(0, clips.Length);
        print(random);
        AudioSource sourse = gameObject.AddComponent<AudioSource>();
        sourse.clip = clips[random];
        sourse.outputAudioMixerGroup = output;
        sourse.Play();
        Destroy(sourse, clips[random].length);
    }
}
