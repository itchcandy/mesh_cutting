using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform aim;
    RaycastHit hit;
    Ray ray;
    Camera cam;
    bool aiming;

    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        var v = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(v.origin, v.direction, out hit, 10, 1<<8)) {
            if(!aiming) {
                aim.gameObject.SetActive(true);
                aiming = true;
            }
            aim.LookAt(hit.point, Vector3.up);
        } else if(aiming) {
            aim.gameObject.SetActive(false);
            aiming = false;
        }
        Debug.DrawRay(v.origin, v.direction*10, Color.red, 0.1f);
    }

    void OnMouseDown()
    {
        Debug.Log("Cut!!");
    }
}
