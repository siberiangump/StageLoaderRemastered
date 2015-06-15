using UnityEngine;
using System.Collections;

public class LoadingModel : MonoBehaviour {

    public enum Status {Done, Loading};
	public Status status = Status.Done;
    public LevelModel tempLevelModel;

}
