using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrecioVentaCalculator : MonoBehaviour
{
    //variables
    public float utilidad, CIF, materiaPrima, manoObra;
    public float valorCorrectoCostoTotal, valorCorrectoUtilidadEsperada, valorCorrectoPrecioVenta;
    //input fields donde agragamos los valores
    [SerializeField] InputField costoTotalInput;
    [SerializeField] InputField utilidadEsperadainput;
    [SerializeField] InputField precioventaInput;
    // texto del resultado 
    public TextMeshProUGUI textoResultado1, textoResultado2, textoResultado3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        materiaPrima = Random.Range(100000f, 500000f);
        manoObra = Random.Range(100000f, 500000f);
        CIF = Random.Range(100000f, 500000f);
        utilidad = Random.Range(50f, 120f);
        // Operaciones 
        valorCorrectoCostoTotal = materiaPrima + manoObra + CIF;
        valorCorrectoUtilidadEsperada = (utilidad * valorCorrectoCostoTotal) / 100;
        valorCorrectoPrecioVenta = valorCorrectoCostoTotal + valorCorrectoUtilidadEsperada;
    }
    private bool AreAlmostEqual(float a, float b, float epsilon = 0.1f)
    {
        return Mathf.Abs(a - b) < epsilon;
    }

    // Update is called once per frame
    public void ResetValores()
    {
        //randomizar valores
        materiaPrima = Random.Range(100000f, 500000f);
        manoObra = Random.Range(100000f, 500000f);
        CIF = Random.Range(100000f, 500000f);
        utilidad = Random.Range(50f, 120f);
        // Operaciones 
        valorCorrectoCostoTotal = materiaPrima + manoObra + CIF;
        valorCorrectoUtilidadEsperada = (utilidad * valorCorrectoCostoTotal) / 100;
        valorCorrectoPrecioVenta = valorCorrectoCostoTotal + valorCorrectoUtilidadEsperada;
    }
    public void Comprobar()
    {
        //reset de textos anteriores
        textoResultado1.text = "";
        textoResultado2.text = "";
        textoResultado3.text = "";
        //Validar dato ingresado
        if (!float.TryParse(costoTotalInput.text, out float costoTotalIngresado))
        {
            textoResultado1.text = "Entrada no válida.";
            textoResultado1.color = Color.red;
            return; // Salir del método si la entrada no es válida
        }
        if (!float.TryParse(costoTotalInput.text, out float utilidadEsperadaingresado))
        {
            textoResultado1.text = "Entrada no válida.";
            textoResultado1.color = Color.red;
            return; // Salir del método si la entrada no es válida
        }
        if (!float.TryParse(costoTotalInput.text, out float precioventaIngresado))
        {
            textoResultado1.text = "Entrada no válida.";
            textoResultado1.color = Color.red;
            return; // Salir del método si la entrada no es válida
        }
        // comprobar valores
        if (AreAlmostEqual(costoTotalIngresado, valorCorrectoCostoTotal))
        {
            textoResultado1.text += "Costo total \n";
            textoResultado1.color = Color.green;
        }
        else
        {
            textoResultado1.text += $"Costo total incorrecto. el valor es : {valorCorrectoCostoTotal}\n";
            textoResultado1.color = Color.red;
        }

        if (AreAlmostEqual(utilidadEsperadaingresado, valorCorrectoUtilidadEsperada))
        {
            textoResultado2.text += "Costo total correcto.\n";
            textoResultado2.color = Color.green;
        }
        else
        {
            textoResultado2.text += $"Costo correcto {valorCorrectoUtilidadEsperada}\n";
            textoResultado2.color = Color.red;
        }

        if (AreAlmostEqual(precioventaIngresado, valorCorrectoPrecioVenta))
        {
            textoResultado3.text += "Precio de venta correcto. \n";
            textoResultado3.color = Color.green;
        }
        else
        {
            textoResultado3.text += $"Precio correcto: {valorCorrectoPrecioVenta}\n";
            textoResultado3.color = Color.red;
        }
    }
}
