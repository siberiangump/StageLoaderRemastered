using UnityEngine;
using System.Collections;

//just GameObject to store components through scenes
public class LevelDataTransferSingleton : Singleton<LevelDataTransferSingleton> {

	protected override void OnSingletonAwake (){
		DontDestroyOnLoad(this.gameObject);
	}

	public void DontNeedThisAnymore(){
		Destroy(this.gameObject);
	}
}
