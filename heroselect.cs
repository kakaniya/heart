using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroselect : MonoBehaviour {

    private string[] charanames =
    {
        "chara1",
        "chara2",
        "chara3",
        "chara4",
        "chara5",
        "chara6",
        "chara7",
        "chara8",
        "chara9"
    };

    private UISprite heroimg;
    private UILabel herolabname;

	// Use this for initialization
	void Start () {
        heroimg = this.transform.parent.Find("hero0").GetComponent<UISprite>();
        herolabname = this.transform.parent.Find("hero_name").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClick ()
    {
        string heroname = this.gameObject.name;//获取当前点击hero的类名
        heroimg.spriteName = heroname;//将类名赋予hero0的sprite参数
        string herocharname = heroname[heroname.Length - 1].ToString();//获取当前点击hero的类名的最后一个字符并转换成string
        int heroindex = int.Parse(herocharname);//string转int
        herolabname.text = charanames[heroindex - 1];//显示类名
    }
}
