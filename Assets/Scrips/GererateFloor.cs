using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GererateFloor : MonoBehaviour
{
    float avanceDelantero = 10f;
    public GameObject suelo;

    void Update()
    {

        movimientoPiso();

        generacionDeMundo();



    }

    void movimientoPiso()
    {
        this.transform.position = this.transform.position + new Vector3(0, 0, -avanceDelantero * Time.deltaTime);
    }
    void generacionDeMundo()
    {
        if (Mathf.Round(transform.position.z) == (-78))
        {
            Instantiate(suelo, new Vector3(0, 0, 156), Quaternion.identity);
            Destroy(suelo);
        }
    }
}
