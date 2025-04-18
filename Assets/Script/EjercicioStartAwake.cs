using UnityEngine;

public class EjercicioStartAwake : MonoBehaviour {
    private void Awake() {
        Debug.Log("Awake: va primero que el start cuando se estancia el script");
    }
    private void Start() {
        Debug.Log("Start: mensaje que se imprime al inicio del juego ");
    }
}