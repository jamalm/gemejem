using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubButton : MonoBehaviour {

    private Button button;
    public Button menu;
    private MenuButton menuButton;

    public GameObject playerState;
    private PlayerState stateScript;

    // Use this for initialization
    void Start()
    {
        button = GetComponentInParent<Button>();
        button.onClick.AddListener(PressButton);
        menuButton = menu.GetComponentInChildren<MenuButton>();
        stateScript = playerState.GetComponentInChildren<PlayerState>();
    }

    private void PressButton()
    {
        menuButton.FlipExpanded();
        stateScript.flipItemSelected();
        stateScript.placeObject();
    }
}
