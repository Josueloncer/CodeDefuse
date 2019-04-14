using System.Collections;
using System.Collections.Generic;

public class RevisionOnline
{
    public bool Foco_1;
    public bool Foco_2;
    public bool Foco_3;
    public bool Foco_4;
    public bool Foco_5;
    public bool Foco_6;
    public bool Foco_7;
    public bool Foco_8;
    public bool Foco_9;
    public bool Foco_10;

    public bool RevisionResultado(int TapFinal, int NumeroLista, int NumeroDeFocosPrendidos)
    {
        if (TapFinal == NumeroLista)
        {
                    switch (NumeroDeFocosPrendidos)
                        {
                            case 0:
                                Foco_1 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 1:
                                Foco_2 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 2:
                                Foco_3 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 3:
                                Foco_4 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 4:
                                Foco_5 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 5:
                                Foco_6 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 6:
                                Foco_7 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 7:
                                Foco_8 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 8:
                                Foco_9 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                            case 9:
                                Foco_10 = true;
                                LogicaOnline.Numero_De_Focos_Prendidos++;
                    break;

                                }

                    return true;

        }

        else
        {
            LogicaOnline.Numero_De_Focos_Prendidos = 0;
            return false;
        }

    }

}
