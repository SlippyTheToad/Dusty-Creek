using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class btnMainMenu : MonoBehaviour {
	private bool ShowWarning = false;
	public CanvasGroup cvsMenuButtons;
	public CanvasGroup cvsWarning;

	// Use this for initialization
	void Start () {
	}

	public void guiToggle()
	{
		if (!ShowWarning) {
			ShowWarning = true;
			cvsMenuButtons.interactable = !cvsMenuButtons.interactable;
			
			cvsWarning.interactable = true;
			cvsWarning.alpha = 1.0f;
			cvsWarning.blocksRaycasts = true;
		} else {
			ShowWarning = false;
			cvsMenuButtons.interactable = true;
			
			cvsWarning.interactable = false;
			cvsWarning.alpha = 0.0f;
			cvsWarning.blocksRaycasts = false;
		}
	}

	public void NewGame()
	{
	}

	public void ExitGame ()
	{
		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
