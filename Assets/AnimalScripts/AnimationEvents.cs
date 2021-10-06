using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource source;
    public AudioClip voice;
    private void Start()
    {
      source = GetComponent<AudioSource>();
    }
    public void AnimalSound()
    {

    }
    public void Step()
    {
        source.PlayOneShot(voice);
    }
  
}
