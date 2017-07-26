using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public int maxHp = 30;
    public int minHp = 0;

    protected UISprite sprite;
    private UILabel hpLable;
    private int hpCount = 30;

    private void Awake()
    {
        sprite = this.GetComponent<UISprite>();
        //string heroName = PlayerPrefs.GetString("hero1");
        //sprite.spriteName = heroName;
        hpLable = this.transform.Find("hp").GetComponent<UILabel>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            TakeDamage(Random.Range(0, 5));
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            PlusHp(Random.Range(0, 5));
        }
    }

    public void TakeDamage(int damage)
    {
        hpCount -= damage;
        hpLable.text = hpCount + "";

        if (hpCount <= minHp)
        {
            //gameover
        }
    }

    public void PlusHp(int hp)
    {
        hpCount += hp;
        if (hpCount >= maxHp)
        {
            hpCount = maxHp;
        }
        hpLable.text = hpCount + "";
    }
}
