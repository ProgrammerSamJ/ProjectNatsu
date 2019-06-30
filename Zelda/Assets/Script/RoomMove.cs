using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomMove : MonoBehaviour
{
    public Vector2 CameraChange;
    public Vector2 MapChange;
    public Vector3 PlayerChange;
    private CameraMovement cam;

    public bool needText;
    public string PlaceName;
    public GameObject Text;
    public Text PlaceText;
    // Start is called before the first frame update
    void Start()
    {
            cam = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other){
            if (other.CompareTag("Player")){
                      cam.maxPosition = cam.maxPosition + CameraChange + MapChange;
                      cam.minPosition = cam.minPosition + CameraChange + MapChange;
                    
                      other.transform.position += PlayerChange;
            }
    }
}
