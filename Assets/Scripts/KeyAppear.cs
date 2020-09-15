using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAppear : MonoBehaviour
{
	public PlayerControl PC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PC.keyGet==true)
		{
			gameObject.active = true;
		}
    }
}
