using System.Collections;
using System.Collections.Generic;

public class Tiempo {
    

    public float TiempoJuego(float _tiempoRestante)
    {
        if (_tiempoRestante > 0)        //LO QUE SUCEDE MIENTRAS AUN HAY TIEMPO
        {
            _tiempoRestante -= _tiempoRestante;
        }
        return _tiempoRestante;
    }
}
