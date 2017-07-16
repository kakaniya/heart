using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero2craystal : MonoBehaviour {

    public int useableNumber = 1;
    public int totalNumber = 1;
    private UILabel label;

    // Use this for initialization
    void Awake () {
        label = this.GetComponent<UILabel>();

    }
	
	// Update is called once per frame
	void Update () {
        UpdateShow();
    }

    void UpdateShow() {
        label.text = useableNumber + "/" + totalNumber;
    }
}
