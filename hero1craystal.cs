using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero1craystal : MonoBehaviour {

    public int useableNumber = 1;
    public int totalNumber = 1;
    public int MaxNumber;
    public UISprite[] crystals;
    private UILabel label;

    private void Awake()
    {
        MaxNumber = crystals.Length;
        label = this.GetComponent<UILabel>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UpdateShow();
	}

    void UpdateShow()
    {
        for (int i = totalNumber; i < MaxNumber; i++)
        {
            crystals[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < totalNumber; i++)
        {
            crystals[i].gameObject.SetActive(true);
        }

        for (int i = useableNumber; i < totalNumber; i++)
        {
            crystals[i].spriteName = "TextInlineImages_normal";
        }
        
        for (int i = 0; i < useableNumber; i++)
        {
            if (i == 9)
            {
                crystals[i].spriteName = "TextInlineImages_" + (1 + i);
            }
            else
            {
                crystals[i].spriteName = "TextInlineImages_0" + (1 + i);
            }
        }

        label.text = useableNumber + "/" + totalNumber;
    }
}
