using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {

            string sudoku = @"1 3 2 5 7 9 4 6 8
                              4 9 8 2 6 1 3 7 5
                              7 5 6 3 8 4 2 1 9
                              6 4 3 1 5 8 7 9 2
                              5 2 1 7 9 3 8 4 6
                              9 8 7 4 2 6 5 3 1
                              2 1 4 9 3 5 6 8 7
                              3 6 5 8 1 7 9 2 4
                              8 7 9 6 4 2 1 5 3";

            int[,] linhasSudoku = new int[9, 9];
            CriandoMatriz(sudoku, linhasSudoku);

            int contadorLinha = 0, contadorColuna = 0;
            int[] arrayLinha = new int[9];
            int[] arrayColuna = new int[9];
            int[] arrayQuadrante = new int[9];

            while (true)
            {
                if (contadorLinha == 9)
                {
                    break;
                }

                for (int x = contadorLinha; x <= contadorLinha; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        arrayLinha[y] = linhasSudoku[x, y];
                    }
                }

                if (LinhaValida(arrayLinha))
                {
                    Console.WriteLine($"Não erro na linha: {contadorLinha + 1}");
                    Console.ReadLine();
                    break;
                }

                contadorLinha++;
            }

            while (true)
            {
                if (contadorColuna == 9)
                {
                    break;
                }

                for (int x = contadorColuna; x <= contadorColuna; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        arrayColuna[y] = linhasSudoku[y, x]; //
                    }
                }

                if (ColunaValida(arrayColuna))
                {
                    Console.WriteLine($"Não erro na coluna: {contadorColuna + 1}");
                    Console.ReadLine();
                    break;
                }
                contadorColuna++;
            }

            while (true)
            {

                MontaQuadrante1(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante2(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante3(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante3(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante4(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante5(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante6(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante7(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante8(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                MontaQuadrante9(arrayQuadrante, linhasSudoku);

                if (QuadranteValida(arrayQuadrante))
                {
                    Console.WriteLine("Não");
                    break;
                }
                Console.WriteLine("SIM");
                Console.ReadLine();

            }

        }

        private static void MontaQuadrante1(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //1
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }

        }
        private static void MontaQuadrante2(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //2
            for (int x = 0; x < 3; x++)
            {
                for (int y = 3; y < 6; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }

        }
        private static void MontaQuadrante3(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //2
            for (int x = 0; x < 3; x++)
            {
                for (int y = 6; y < 9; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }

        }
        private static void MontaQuadrante4(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //2
            for (int x = 3; x < 6; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }

        }
        private static void MontaQuadrante5(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //2
            for (int x = 3; x < 6; x++)
            {
                for (int y = 3; y < 6; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }

        }
        private static void MontaQuadrante6(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //2
            for (int x = 3; x < 6; x++)
            {
                for (int y = 6; y < 9; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }

        }
        private static void MontaQuadrante7(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //2
            for (int x = 6; x < 9; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }

        }
        private static void MontaQuadrante8(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //2
            for (int x = 6; x < 9; x++)
            {
                for (int y = 3; y < 6; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }

        }
        private static void MontaQuadrante9(int[] arrayQuadrante, int[,] linhasSudoku)
        {
            int contadorQuadrante = 0;
            //2
            for (int x = 6; x < 9; x++)
            {
                for (int y = 6; y < 9; y++)
                {
                    arrayQuadrante[contadorQuadrante] = linhasSudoku[x, y];
                    contadorQuadrante++;
                }
            }
        }
        private static bool ColunaValida(int[] arrayColuna)
        {
            return arrayColuna.Length - arrayColuna.ToList().Distinct().Count() != 0;
        }
        private static bool QuadranteValida(int[] arrayGradante)
        {
            return arrayGradante.Length - arrayGradante.ToList().Distinct().Count() != 0;
        }
        private static bool LinhaValida(int[] arrayLinha)
        {
            return arrayLinha.Length - arrayLinha.ToList().Distinct().Count() != 0;
        }
        private static void CriandoMatriz(string sudoku, int[,] linhasSudoku)
        {
            using (StringReader sudokuReader = new StringReader(sudoku))
            {
                string linhaSudoku = "";


                for (int x = 0; x < 9; x++)
                {
                    linhaSudoku = sudokuReader.ReadLine();
                    string[] valores = linhaSudoku.Trim().Split();

                    for (int y = 0; y < 9; y++)
                    {
                        linhasSudoku[x, y] = Convert.ToInt32(valores[y]);
                    }
                }
            }
        }

    }
}
