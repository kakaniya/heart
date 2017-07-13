
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black_bg_come : MonoBehaviour {

    public static black_bg_come blackmask;

	// Use this for initialization
	void Awake () {
        blackmask = this;
        this.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    void Hidden()
    {
        this.gameObject.SetActive(false);
    }
}
