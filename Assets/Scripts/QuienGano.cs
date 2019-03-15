using System.Collections;
using System.Collections.Generic;

public class QuienGano{

    public int Gano(int Ganador)
    {
        if (Ganador == 1)
        {
            return 1;
        }
        if (Ganador == 2)
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }
}
