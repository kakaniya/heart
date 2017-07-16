using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontral : MonoBehaviour {

    public Transform gamecard1;
    public Transform gamecard2;

    public GameObject cardpre;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            RandomGenerateCard();
        }
	}

    void RandomGenerateCard() {
        GameObject go = NGUITools.AddChild(this.gameObject, cardpre);
        go.transform.position = gamecard1.position;
        iTween.MoveTo(go, gamecard2.position,1f);
    }
}
