using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Player player;

    private void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;
        if (InputMoveRight())
        {
            direction += Vector3.right;
        }
        if (InputMoveLeft())
        {
            direction += Vector3.left;
        }
        if (InputMoveUp())
        {
            direction += Vector3.up;
        }
        if (InputMoveDown())
        {
            direction += Vector3.down;
        }
        player.Move(direction);

        if (InputShoot() && player.weapon)
        {
            player.weapon.Attack(player.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), player.faction);
        }
    }

    private bool InputMoveRight()
    {
        return Input.GetKey(KeyCode.D);
    }

    private bool InputMoveLeft()
    {
        return Input.GetKey(KeyCode.A);
    }

    private bool InputMoveUp()
    {
        return Input.GetKey(KeyCode.W);
    }

    private bool InputMoveDown()
    {
        return Input.GetKey(KeyCode.S);
    }

    private bool InputShoot()
    {
        return Input.GetMouseButton(0);
    }
}
