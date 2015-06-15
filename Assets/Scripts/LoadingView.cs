using UnityEngine;
using System.Collections;

public class LoadingView : MonoBehaviour {

    public LoadingModel model;
	public Animator animator;

    bool Validation() {
        if(model == null) {
           model = GetComponent<LoadingModel>();
           if(model == null) {
              return false;
           }
        }
        if(animator == null) {
           animator = GetComponent<Animator>();
           if(model == null) {
              return false;
           }
        }
        return true;
    }

	void Update () {
        if(!Validation()) {
            return;
        }
        if(model.status == LoadingModel.Status.Loading) {
	        animator.SetBool("Loading", true);
        }else {
            animator.SetBool("Loading", false);
        }
	}

}
