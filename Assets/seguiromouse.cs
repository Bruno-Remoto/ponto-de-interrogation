using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguiromouse : MonoBehaviour
{
  public float veloc = 10f;

    void Update()
    {
        float hori = Input.GetAxis("Horizontal") * Time.deltaTime * veloc;
        float vert = Input.GetAxis("Vertical") * Time.deltaTime * veloc;

        transform.Translate(hori,0,vert);
    }
}
