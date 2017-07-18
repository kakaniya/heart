using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontral : MonoBehaviour {

    public Transform gamecard1;
    public Transform gamecard2;
    public string[] cardNames;
    public GameObject cardpre;
    public float tranformTime;// = Random.Range(0,2.0f);
    public int transformSpeed = 30;

    private UISprite nowGenerateCard;
    private float timer = 0;
    private bool isTransforming = false;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            RandomGenerateCard();
        }

        if (isTransforming) {
            tranformTime = Random.Range(1.0f, 2.0f);
            timer += Time.deltaTime;
            int index = (int)(timer / (1f / transformSpeed));
            index %= cardNames.Length;
            nowGenerateCard.spriteName = cardNames[index];

            if (timer > tranformTime) {
                timer = 0;
                isTransforming = false;
            }
        }
	}

    void RandomGenerateCard() {
        GameObject go = NGUITools.AddChild(this.gameObject, cardpre);
        go.transform.position = gamecard1.position;
        nowGenerateCard = go.GetComponent<UISprite>();
        iTween.MoveTo(go, gamecard2.position,1f);
        isTransforming = true;
    }
}
