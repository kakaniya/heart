using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class historycard : MonoBehaviour {

    public Transform incard;
    public Transform outcard;
    public Transform card1;
    public Transform card2;
    public GameObject cardprefeb;

    private float yOffSet;

	// Use this for initialization
	void Start () {
        yOffSet = card2.position.y - card1.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            StartCoroutine(AddCard());
        }
	}

    public IEnumerator AddCard()
    {
        GameObject go = GameObject.Instantiate(cardprefeb, incard.position, Quaternion.identity) as GameObject;
        yield return 0;
        go.transform.position = incard.position;
    }
}
