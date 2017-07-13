using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour {

    public MovieTexture movtexture;

    private bool isplay = true;
    private bool onetouch = false;

    public TweenScale logostart;

    private bool isCanShowSelectRole = false;//是否可以显示角色选择界面

    public TweenPosition selectRoleTween;

    public UISprite hero1;

	// Use this for initialization
	void Start () {
        movtexture.loop = false;
        movtexture.Play();
        logostart.AddOnFinished(this.OnLogoTweenFinished);
	}
	
	// Update is called once per frame
	void Update () {
        if (isplay)
        {
            if (Input.GetMouseButtonDown(0) && onetouch == false)
            {
                onetouch = true;
            }
            else if (Input.GetMouseButtonDown(0) && onetouch == true)
            {
                StopMov();
            }
        }

        if (isplay != movtexture.isPlaying)
        {
            StopMov();
        }

        if (isCanShowSelectRole == true && Input.GetMouseButtonDown(0))
        {
            //显示角色选择界面
            selectRoleTween.PlayForward();
            isCanShowSelectRole = false;

        }
	}

    private void OnGUI()
    {
        if (isplay)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), movtexture);
            if (onetouch)
            {
                GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 40), "touch screen again to stop");
            }
        }
    }

    private void StopMov()
    {
        movtexture.Stop();
        isplay = false;
        logostart.PlayForward();
    }

    private void OnLogoTweenFinished()
    {
        isCanShowSelectRole = true;
    }

    public void OnPlayButtonClick()
    {
        black_bg_come.blackmask.Show();
        vs_go.vsgo.Show(hero1.spriteName, "hero" + Random.Range(1, 10));
        StartCoroutine(LoadPlayScene());
    }

    IEnumerator LoadPlayScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
}
