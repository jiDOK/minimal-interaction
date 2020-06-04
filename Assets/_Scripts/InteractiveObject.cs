using UnityEngine;

public class InteractiveObject : MonoBehaviour, Interactable
{
    public Animation OpenAnim;

    public void Interact(Player player)
    {
        Debug.Log("Doing Something!");
        OpenAnim.Play();
        // die nächste Zeile falls das Interaktive Objekt nur einmal reagieren soll
        //Destroy(this);
    }
}
