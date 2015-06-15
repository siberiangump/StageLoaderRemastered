﻿using UnityEngine;
using System.Collections;

public class LevelModel : MonoBehaviour {

	public string levelName;
	public Object scene;
	public GameObject character;
	public Color32 backColor;

	public void CloneModel(LevelModel from){
		if(from==null){
			return;
		}
		levelName = from.levelName;
		scene = from.scene;
		character = from.character;
		backColor = from.backColor;
	} 
}
