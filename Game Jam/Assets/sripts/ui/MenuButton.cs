using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

    private Button button;
    private bool expanded = false;
    public List<GameObject> subButtons;

	// Use this for initialization
	void Start () {
        button = GetComponentInParent<Button>();
        button.onClick.AddListener(FlipExpanded);
        expandButtons();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void FlipExpanded()
    {
        expanded = !expanded;
        expandButtons();
    }

    private void expandButtons()
    {
        foreach (GameObject butt in subButtons)
        {
            butt.SetActive(expanded);
        }
    }
}
