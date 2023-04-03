using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PixelPerfectCamera : MonoBehaviour
{
    public static float pixelsToUnits = 1f;
    public static float scale = 1f;

    public Vector2 nativeResolution = new Vector2(240, 160);

    void Awake() {
        var camera = GetComponent<Camera> ();

        if(camera.orthographic) {
            scale = Screen.height/nativeResolution.y;
            pixelsToUnits *= scale;
            camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
        }
        AddCollider();
    }
    public void AddCollider() {
        if (Camera.main==null) {
            Debug.LogError("Camera.main not found, failed to create edge colliders"); return;
        }
    
        var mainCamera = Camera.main;

        if (!mainCamera.orthographic) {
                Debug.LogError("Camera.main is not Orthographic, failed to create edge colliders"); return;
        }

        var bottomLeft = (Vector2)mainCamera.ScreenToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
        var topLeft = (Vector2)mainCamera.ScreenToWorldPoint(new Vector3(0, mainCamera.pixelHeight, mainCamera.nearClipPlane));
        var topRight = (Vector2)mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth, mainCamera.pixelHeight, mainCamera.nearClipPlane));
        var bottomRight = (Vector2)mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth, 0, mainCamera.nearClipPlane));

            // add or use existing EdgeCollider2D
        var edge = GetComponent<EdgeCollider2D>() == null ? gameObject.AddComponent<EdgeCollider2D>() : GetComponent<EdgeCollider2D>();

        var edgePoints = new [] {bottomLeft,topLeft,topRight,bottomRight, bottomLeft};
        edge.points = edgePoints;

        edge.isTrigger = false;
    }
    
}
