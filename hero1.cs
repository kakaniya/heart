using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero1 : Hero {

    private void Start()
    {
        string heroName = PlayerPrefs.GetString("hero1");
        sprite.spriteName = heroName;
    }
}
