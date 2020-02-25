using UnityEngine;

public class CurveSystem : MonoBehaviour
{
    public GameObject ballLine;
    public GameObject ball;

    public Transform weapon;

    private void Update()
    {
        RotateWeapon();
        CreateBall();
    }

    private void RotateWeapon()
    {
        //weapon.Rotate(Time.deltaTime, 0, 0);
    }

    private void CreateBall()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject temp = Instantiate(ballLine, weapon.position, weapon.rotation);
            temp.GetComponent<Rigidbody>().AddForce(-weapon.forward * 500);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject temp = Instantiate(ball, weapon.position, weapon.rotation);
            temp.GetComponent<Rigidbody>().AddForce(-weapon.forward * 500);
        }
    }
}
