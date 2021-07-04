using UnityEngine;

public class CharacterShooting : MonoBehaviour
{
    public gun gun;

    public int shootButton;
    public KeyCode reloadKey;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            gun.Shoot();
        }

        if (Input.GetKeyDown(reloadKey))
        {
            gun.Reload();
        }
    }
}