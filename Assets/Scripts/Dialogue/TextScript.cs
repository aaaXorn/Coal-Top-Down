using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
	public Text text1;//parte de cima do texto
	public Text text2;//parte de baixo do texto
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void TextBoxAppear()
	{
		gameObject.active = true;
	}
	public void TextBoxDisappear()
	{
		gameObject.active = false;
	}
}
