using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelView : MonoBehaviour {

	public LevelModel levelModel;
	public Text levelNameText;

	// Use this for initialization
	void Start () {
		levelModel = LevelController.Instance.model;
		if(!Validation()){
			return;
		}
		Grab ();
	}

	bool Validation(){
		if(levelNameText == null || levelModel == null){
			Debug.Log("check parametrs",this.gameObject);
			return false;
		}
		return true;
	}

	void Grab () {
		if(!Validation()){
			return;
		}
		levelNameText.text = levelModel.levelName;  
		Camera.main.backgroundColor = levelModel.backColor;
	}
}
