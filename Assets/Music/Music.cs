using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
	AudioSource audio;
	public AudioClip mus1;
	int music = 0;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(music)
		{
			case 0:
			break;
			case 1:
			break;
		}
    }
}
