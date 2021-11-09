using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ARPlaceOnPlane : MonoBehaviour
{

    public ARRaycastManager arRaycastManager;
    public GameObject placeObject;
    public GameObject spawnObject;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //UpdateCenterObject();
        //PlaceObjectByTouchable();
    }

    private void PlaceObjectByTouchable()
    {
        if (Input.touchCount > 0) //touchCount => 스마트폰 스크린에 터치를 몇 개 했는 지 => 검지 엄지 동시 => 2개
        {
            Touch touch = Input.GetTouch(0);

            List<ARRaycastHit> hits = new List<ARRaycastHit>();

            if (arRaycastManager.Raycast(touch.position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes)) {
                Pose hitPose = hits[0].pose;

                if (!spawnObject)
                {
                    spawnObject = Instantiate(placeObject, hitPose.position, hitPose.rotation);
                }
                else
                {
                    spawnObject.transform.position = hitPose.position;
                    spawnObject.transform.rotation = hitPose.rotation;
                }

            }

        }
    }

    private void UpdateCenterObject()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));


        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycastManager.Raycast(screenCenter, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;

            placeObject.SetActive(true);
            placeObject.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        } else {
            placeObject.SetActive(false);
        }

    }
}
