using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraScript : MonoBehaviour
{
    [SerializeField] private Camera camera;

    private Vector3 dragOrigin;

    [SerializeField] private float zoom;
    [SerializeField] private float zoomMultiplier =40f;
    [SerializeField] private float minZoom = 50f;
    [SerializeField] private float maxZoom = 400f;
    [SerializeField] private float veloCity = 100f;
    [SerializeField] private float smoothTime = 0.25f;


    [SerializeField] private SpriteRenderer mapRenderer;

    private float mapMinX, mapMaxX, mapMinY, mapMaxY;


    private void Awake() {
        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;

        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;


        zoom = camera.orthographicSize;

    }

    private void Update() {
        PanCamera();

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoom -= scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        camera.orthographicSize = Mathf.SmoothDamp(camera.orthographicSize, zoom, ref veloCity, smoothTime);
        
    }

    private void PanCamera() {

        if(Input.GetMouseButtonDown(0)) {
            dragOrigin = camera.ScreenToWorldPoint(Input.mousePosition);
        }

        if(Input.GetMouseButton(0)) {
            Vector3 difference = dragOrigin - camera.ScreenToWorldPoint(Input.mousePosition);

            camera.transform.position = ClampCamera(camera.transform.position + difference);
        }

    }

    private Vector3 ClampCamera(Vector3 targetPositon){
        float cameraHeight = camera.orthographicSize;
        float cameraWidth = cameraHeight * camera.aspect;

        float minX = mapMinX + cameraWidth;
        float maxX = mapMaxX - cameraWidth;

        float minY = mapMinY + cameraHeight;
        float maxY = mapMaxY - cameraHeight;

        float x = Mathf.Clamp(targetPositon.x, minX, maxX);
        float y = Mathf.Clamp(targetPositon.y, minY, maxY);

        return new Vector3(x, y, targetPositon.z);
    }

    



}
