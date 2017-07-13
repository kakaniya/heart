using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vs_go : MonoBehaviour {

    public static vs_go vsgo;

    public TweenScale vsTween;
    public TweenPosition hero1Tween;
    public TweenPosition hero2Tween;

    // Use this for initialization
    void Awake () {
        vsgo = this;
        this.gameObject.SetActive(false);
	}

    private void Start()
    {
        //Show("hero1", "hero4");
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Show(string hero1Name, string hero2Name)
    {
        PlayerPrefs.SetString("hero1", hero1Name);
        PlayerPrefs.SetString("hero2", hero2Name);

        this.gameObject.SetActive(true);
        black_bg_come.blackmask.Show();

        hero1Tween.GetComponent<UISprite>().spriteName = hero1Name;
        hero2Tween.GetComponent<UISprite>().spriteName = hero2Name;

        vsTween.PlayForward();
        hero1Tween.PlayForward();
        hero2Tween.PlayForward();
    }
}
