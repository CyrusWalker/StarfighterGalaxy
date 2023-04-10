using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PixelPerfectCamera : MonoBehaviour
{
    public static float pixelsToUnits = 1f;
    public static float scale = 1f;
    public static bool restarted = false;

    public Vector2 nativeResolution = new Vector2(240, 160);

    void Awake() 
    {
        CameraSetup();
        if (restarted == false)
        {
            AddCollider();
            restarted = true;
            Debug.Log("Awake Called");
        }
        
    }

    public void CameraSetup()
    {
        var camera = GetComponent<Camera> ();

        if(camera.orthographic) {
            scale = Screen.height/nativeResolution.y;
            if (restarted == false)
                pixelsToUnits *= scale;
            
            camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
        }
    }

    public void AddCollider() {
        if (Camera.main==null) {
            Debug.LogError("Camera.main not found, failed to create edge colliders"); return;
        }
    
        var cam = Camera.main;

        if (!cam.orthographic) {
                Debug.LogError("Camera.main is not Orthographic, failed to create edge colliders"); return;
        }

        var bottomLeft = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
        var topLeft = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, cam.pixelHeight, cam.nearClipPlane));
        var topRight = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, cam.nearClipPlane));
        var bottomRight = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0, cam.nearClipPlane));
        
        // Debug.Log(bottomLeft);
        // Debug.Log(topLeft);
        // Debug.Log(topRight);
        // Debug.Log(bottomRight);


        EdgeCollider2D edge;
        if(GetComponent<EdgeCollider2D>() == null) {
            edge = gameObject.AddComponent<EdgeCollider2D>();
        } else {
            edge = GetComponent<EdgeCollider2D>();
        }

        var edgePoints = new [] {bottomLeft,topLeft,topRight,bottomRight, bottomLeft};
        edge.points = edgePoints;

        edge.isTrigger = false;
    }
    
}
