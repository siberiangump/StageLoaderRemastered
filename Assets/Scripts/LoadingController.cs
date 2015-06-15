using UnityEngine;
using System.Collections;

public class LoadingController : Singleton<LoadingController> {

    LoadingModel model;

    protected override void OnSingletonAwake() {
        if(!Validation()) {
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    bool Validation() {
        if(model==null) {
            model = GetComponent<LoadingModel>();
        }
		if(model==null) {
			model = this.gameObject.AddComponent<LoadingModel>();
		}
		if(model==null) {
			return false;
		}
        return true;
    }

    public IEnumerator LoadSceneAfterSecond(string sceneName){
        model.status=LoadingModel.Status.Loading;
        yield return new WaitForSeconds(1);
        StartCoroutine(LoadScene(sceneName));
	}
    
	private IEnumerator LoadScene(string sceneName){
		AsyncOperation loadingOperation = Application.LoadLevelAsync(sceneName);
		yield return loadingOperation;
        model.status=LoadingModel.Status.Done;
	}

}
