using System.Collections;
using System.Collections.Generic;

public class DeltaTime
{
    public float restarTiempo(float TiempoDeJuego, float El_DeltaTime)
    {
        TiempoDeJuego -= El_DeltaTime * 1;
        return TiempoDeJuego;
    }
}
