using System;

namespace aplicacion_display
{
    class Program
    {
        static void Main(string[] args)
        {
            string datosIngresados = "";
            do
            {
                pedirDatos(ref datosIngresados);
            } while (datosIngresados != "0,0");

            Console.WriteLine("fin de programa");
            Console.ReadLine();
        }

        private static void pedirDatos(ref string datosIngresados)
        {
            try
            {
                string[,] matriz = new string[200, 2000];
                int posFila = 0, posColumna = 0;
                //Dejamos la matriz con espacios
                for (int i = 0; i < 200; i++)
                {
                    for (int j = 0; j < 2000; j++)
                    {
                        matriz[i, j]=" ";
                    }
                }
                Console.Clear();
                Console.WriteLine(" PANTALLA DISPLAY \n \n ");
                Console.WriteLine(" Para salir digite 0,0 ");
                Console.WriteLine(" digite la secuencia ");
                datosIngresados = Console.ReadLine();
                string[] vectorDividido = datosIngresados.Split(",");
                int size = Convert.ToInt32(vectorDividido[0]);
                int altoFilas = size * 2 + 3;
                int anchoColumnas = size + 2;
                if (size >= 1 && size <= 10)
                {
                    foreach(char numero in vectorDividido[1])
                    {
                        switch (numero)
                        {   
                            case '0':
                                for(int i=1; i <= size; i++ )
                                {
                                    matriz[posFila + i, posColumna] = "|";
                                    matriz[posFila + i, posColumna + anchoColumnas -1] = "|";
                                    matriz[posFila + 1 + size + i, posColumna] = "|";
                                    matriz[posFila + 1 + size + i, posColumna + anchoColumnas-1] = "|";
                                    matriz[posFila, posColumna + i ] = "-";
                                    matriz[posFila + altoFilas -1, posColumna + i] = "-";
                                }
                                break;
                            case '1':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila + i, posColumna + size -1 ] = "|";
                                    matriz[posFila + 1 + size + i, posColumna + size - 1] = "|";
                                }
                                break;
                            case '2':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila + 1 + size + i, posColumna] = "|";
                                    matriz[posFila, posColumna + i] = "-";
                                    matriz[posFila + altoFilas - 1, posColumna + i] = "-";
                                    matriz[posFila + size + 1, posColumna + i] = "-";
                                }
                                break;
                            case '3':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila + 1 + size + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila, posColumna + i] = "-";
                                    matriz[posFila + altoFilas - 1, posColumna + i] = "-";
                                    matriz[posFila + size + 1, posColumna + i] = "-";
                                }
                                break;
                            case '4':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila + i, posColumna] = "|";
                                    matriz[posFila + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila + size + 1, posColumna + i] = "-";
                                    matriz[posFila + 1 + size + i, posColumna + anchoColumnas - 1] = "|";

                                }
                                break;
                            case '5':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila + i, posColumna] = "|";
                                    matriz[posFila + 1 + size + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila, posColumna + i] = "-";
                                    matriz[posFila + altoFilas - 1, posColumna + i] = "-";
                                    matriz[posFila + size + 1, posColumna + i] = "-";
                                }
                                break;
                            case '6':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila + i, posColumna] = "|";
                                    matriz[posFila + 1 + size + i, posColumna] = "|";
                                    matriz[posFila + 1 + size + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila, posColumna + i] = "-";
                                    matriz[posFila + altoFilas - 1, posColumna + i] = "-";
                                    matriz[posFila + size + 1, posColumna + i] = "-";
                                }
                                break;
                            case '7':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila, posColumna + i] = "-";
                                    matriz[posFila + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila + 1 + size + i, posColumna + anchoColumnas - 1] = "|";
                                }
                                break;
                            case '8':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila + i, posColumna] = "|";
                                    matriz[posFila + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila + 1 + size + i, posColumna] = "|";
                                    matriz[posFila + 1 + size + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila, posColumna + i] = "-";
                                    matriz[posFila + altoFilas - 1, posColumna + i] = "-";
                                    matriz[posFila + size + 1, posColumna + i] = "-";
                                }
                                break;
                            case '9':
                                for (int i = 1; i <= size; i++)
                                {
                                    matriz[posFila + i, posColumna] = "|";
                                    matriz[posFila + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila + 1 + size + i, posColumna + anchoColumnas - 1] = "|";
                                    matriz[posFila, posColumna + i] = "-";
                                    matriz[posFila + altoFilas - 1, posColumna + i] = "-";
                                    matriz[posFila + size + 1, posColumna + i] = "-";
                                }
                                break;
                            default:
                            break;
                        }
                        posColumna = posColumna + anchoColumnas +1 ;

                    }

                    //Despues de recorrer imprimimos la matriz
                    for(int i =0; i< altoFilas;i++)
                    {
                        string cad = "";
                        for (int j = 0; j < posColumna; j++)
                        {
                            cad = cad + matriz[i, j];
                        }
                        Console.WriteLine(cad);
                    }
                }
                else
                {
                    Console.WriteLine("la secuencia no es valida ");
                }
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("se produjo error :" + ex.Message);
                Console.ReadLine();

            }
            
        }
    }
}
