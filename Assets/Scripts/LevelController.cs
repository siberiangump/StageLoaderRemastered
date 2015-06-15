
using UnityEngine;
using System.Collections;

public class LevelController : Singleton<LevelController> {

	public LevelModel model;

	void Awake(){
		Init ();
	}

    [ContextMenu ("Init level")]
	public void Init () { 
		if(!Validation()){
			return;
		}
		//clone level model from menu
		model.CloneModel(LevelDataTransferSingleton.Instance.GetComponent<LevelModel>());
		LevelDataTransferSingleton.Instance.DontNeedThisAnymore();

		if(model.character==null){
			return;
		}
		Instantiate(model.character,
		            GameObject.FindGameObjectWithTag("Respawn").transform.position,
		            Quaternion.identity);
	}
	
	bool Validation(){
		if(model==null){
			model = GetComponent<LevelModel>();
		}
		if(model==null){
			model = this.gameObject.AddComponent<LevelModel>();
		}
        return true;
	}

}
