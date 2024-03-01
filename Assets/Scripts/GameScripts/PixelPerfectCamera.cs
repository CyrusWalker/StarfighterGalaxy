using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PixelPerfectCamera : MonoBehaviour
{
    EdgeCollider2D edge;
    public static float pixelsToUnits = 1f;
    public static float scale = 1f;
    public static bool restarted = false;

    public Vector2 nativeResolution = new Vector2(240, 160);

    void Awake() 
    {
        CameraSetup();
        AddCollider();
        
    }

    public void CameraSetup()
    {
        var camera = GetComponent<Camera> ();

        if(camera.orthographic) {
            scale = Screen.height/nativeResolution.y;
            if (restarted == false)
            {
                restarted = true;
                pixelsToUnits *= scale;
            }
            camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
        }
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


        if(GetComponent<EdgeCollider2D>() == null) {
            edge = gameObject.AddComponent<EdgeCollider2D>();
        } else {
            edge = GetComponent<EdgeCollider2D>();
        }

        var edgePoints = new [] {bottomLeft,topLeft,topRight,bottomRight, bottomLeft};
        edge.points = edgePoints;

        edge.isTrigger = false;
    }
/*
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D collidingRB = collision.transform.GetComponent<Rigidbody2D>();
        collidingRB.velocity = -collidingRB.velocity;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Rigidbody2D colliderRB = collider.GetComponent<Rigidbody2D>();
        colliderRB.velocity = -colliderRB.velocity;
    }

    Vector2 GetClosestPoint(Vector2 position)
    {
        Vector2[] points = edge.points;
        float shortestDistance = Vector2.Distance(position, points[0]);
        Vector2 closestPoint = points[0];
        foreach(Vector2 point in points)
        {
            if(Vector2.Distance(position, point) < shortestDistance)
            {
                shortestDistance = Vector2.Distance(position, point);
                closestPoint = point;
            }
        }
        return closestPoint;
    }
    */
}
