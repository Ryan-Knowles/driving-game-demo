using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] public GameObject followObject;
    [SerializeField] public float startZoom = 40;
    [SerializeField] public float currentZoom = 40;
    [SerializeField] public float zoomIncrement = 1.5f;
    [SerializeField] public float maxZoom = 120;
    [SerializeField] public float minZoom = 10;

    private void Start()
    {
        this.followObject = GameObject.Find("Scoot McToot");
    }

    private void Update()
    {
        float zoomAmount = Input.GetAxis("Mouse ScrollWheel");
        //Debug.Log($"{zoomAmount}");
        if (zoomAmount > 0)
        {
            //Zoom out
            float newZoom = this.currentZoom + this.zoomIncrement * Mathf.Abs(currentZoom/startZoom);
            if (newZoom > this.maxZoom)
            {
                newZoom = this.maxZoom;
            }
            this.currentZoom = newZoom;
        }
        else if (zoomAmount < 0)
        {
            //Zoom in
            float newZoom = this.currentZoom - this.zoomIncrement;
            if (newZoom < this.minZoom)
            {
                newZoom = this.minZoom;
            }
            this.currentZoom = newZoom;
        }
        //Debug.Log($"New zoom: {this.currentZoom}");
    }

    private void LateUpdate()
    {
        if (this.followObject is not null)
        {
            transform.position = this.followObject.transform.position - new Vector3(0, 0, this.currentZoom);
        }
    }
}
