using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEdge : MonoBehaviour
{
    private Vector2 screenBounds;
    [SerializeField] private int edgeOffset = 8;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPosition = transform.position;

        if(viewPosition.x < ((-screenBounds.x)) + edgeOffset|| viewPosition.x > screenBounds.x - edgeOffset)
        {
            viewPosition.x = Mathf.Clamp(viewPosition.x, screenBounds.x * (-1) + edgeOffset, screenBounds.x - edgeOffset);
        }
        
        if(viewPosition.y < ((-screenBounds.y)) + edgeOffset|| viewPosition.y > screenBounds.y - edgeOffset)
        {
            viewPosition.y = Mathf.Clamp(viewPosition.y, screenBounds.y * (-1) + edgeOffset, screenBounds.y - edgeOffset);
        }
        
        transform.position = viewPosition;
    }
}
