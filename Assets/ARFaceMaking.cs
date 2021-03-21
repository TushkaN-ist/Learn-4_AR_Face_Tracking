using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARFaceMaking : MonoBehaviour
{
    public ARFaceManager arFaceManager;
    public GameObject lazerEye;

    // Start is called before the first frame update
    void Start()
    {
        arFaceManager.facesChanged += ArFaceManager_facesChanged;
    }

	private void ArFaceManager_facesChanged(ARFacesChangedEventArgs obj)
	{
        GameObject go;
        foreach(ARFace item in obj.added)
        {
            go = Instantiate(lazerEye, item.leftEye, false);
            go = Instantiate(lazerEye, item.rightEye, false);
        }
	}
}
