using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public Text UIText;
    public float time = 00;

    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;

        UIText.text =  "Metros Avanzados: " + time.ToString("f0");
    }
}
