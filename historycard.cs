using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class historycard : MonoBehaviour {

    public Transform incard;
    public Transform outcard;
    public Transform card1;
    public Transform card2;
    public GameObject cardprefeb;

    private List<GameObject> cardList = new List<GameObject>();
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
        iTween.MoveTo(go, card1.position, 1f);
        cardList.Add(go);
        if (cardList.Count > 6)
        {
            iTween.MoveTo(cardList[0], outcard.position, 0.5f);
            Destroy(cardList[0], 2);
            cardList.RemoveAt(0);
        }

        for (int i = 0; i < cardList.Count - 1; i++)
        {
            iTween.MoveTo(cardList[i], cardList[i].transform.position + new Vector3(0, yOffSet,0), 0.5f);
        }
    }
}
