using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerUI playerUI;
    Camera cam;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
        playerUI = GetComponent<PlayerUI>();
    }

    private void Update()
    {
        playerUI.ChangeReticle(Color.black);
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, 30f))
        {
            Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                playerUI.ChangeReticle(Color.green);
                if(Input.GetMouseButtonDown(0))
                {
                    interactable.Interact(this);
                }
            }
        }
    }
}
