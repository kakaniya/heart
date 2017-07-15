using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endbutton : MonoBehaviour {

    private UILabel endlable;

	// Use this for initialization
	void Start () {
        endlable = GameObject.Find("endbuttonlable").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickEndButton() {
        endlable.text = "敌方回合";
    }
}
