using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelButtonController : MonoBehaviour {

	public LevelModel levelModel;
    public Button button;

    void Start() {
       if(!Validation()) {
            return;
       }
       button.onClick.AddListener(LoadMainMenu);
    }

	bool Validation(){
		if(levelModel == null) {
			levelModel = this.GetComponent<LevelModel>();
		}
        if(levelModel == null) {
            return false;
        }
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
		LevelDataTransferSingleton.Instance.gameObject.AddComponent<LevelModel>().CloneModel(levelModel);
        StartCoroutine(LoadingController.Instance.LoadSceneAfterSecond(levelModel.scene.name));
	}

}
