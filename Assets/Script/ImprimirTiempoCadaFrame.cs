using UnityEngine;

public class ImprimirTiempocadaFrame : MonoBehaviour
{

    // private void Update() {
    // float time = Time.deltaTime;

    // Debug.Log("el tiempo es"+time);    
    // }
    public int count=0;
    private void Update()
    {
        count++;
        if (count % 100 == 0)
        {
            float timePast = Time.realtimeSinceStartup;
            Debug.Log(" Tiempo cada 100 forogramas "+ timePast);
        }
    }
}