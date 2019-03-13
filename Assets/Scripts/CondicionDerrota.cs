using System.Collections;
using System.Collections.Generic;

public class CondicionDerrota{

    public bool RevisarTiempo(float TiempoActual)
    {
        if (TiempoActual <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
