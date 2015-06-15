using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BackButtonController : MonoBehaviour {

    public Button button; 

    void Start() {
        if(!Validation()) {
            return;
        }
        button.onClick.AddListener(LoadMainMenu);
    }

	bool Validation(){
        if(button == null) { 
            button = this.GetComponent<Button>();
        }
        if(button == null) {
            button = transform.GetComponentInChildren<Button>();
        }
        if(button == null) {
            return false;
        }
        return true;
	}

    public void LoadMainMenu(){
		StartCoroutine(LoadingController.Instance.LoadSceneAfterSecond("Menu"));
	}
}
