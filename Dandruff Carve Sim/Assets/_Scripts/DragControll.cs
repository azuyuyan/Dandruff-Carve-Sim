using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation.Examples;


public class DragControll : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    PathFollower pathFollower;

    private void Start()
    {
        pathFollower = FindObjectOfType<PathFollower>();
        
    }
    private void Update()
    {
        UpDownControll();
        SideControll();
    }
    public void UpDownControll()
    {
        float newZ = 0;
        float touchZDelta = 0;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchZDelta = Input.GetTouch(0).deltaPosition.y / Screen.width;

        }
        newZ = this.transform.localPosition.y + 100 * touchZDelta * Time.deltaTime;
       
        Vector3 newPosition = new Vector3(0, newZ, this.transform.position.z);
        this.transform.localPosition = newPosition;

    }
    public void SideControll()
    {
        float newX = 0;
        float touchXDelta = 0;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.height;

        }
        pathFollower.speed = touchXDelta*500;

    }
    //void OnMouseDown()
    //{
    //    mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    //    mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    //}
    //private Vector3 GetMouseAsWorldPoint()
    //{
    //    Vector3 mousePoint = Input.mousePosition;
    //    mousePoint.z = mZCoord;
    //    return Camera.main.ScreenToWorldPoint(mousePoint);
    //}

    //void OnMouseDrag()
    //{
    //    transform.position = GetMouseAsWorldPoint() + mOffset;
    //}
}