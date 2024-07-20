using UnityEngine;
// Script Planet.cs digunakan untuk merotasi game object planet
public class Planet : MonoBehaviour
{
    // speed dapat diset di game object yg terpasang script,
    // namun secara default bernilai 1 float
    public float speed = 1f;

    // Update is called once per frame
    // pada void Update, kita memanggil void Rotation
    void Update()
    {
        Rotation();
    }

    // pada void Rotation, melalukan proses Rotate secepat var speed
    public void Rotation() { 
        transform.Rotate(Vector3.up * speed);
    }

}
