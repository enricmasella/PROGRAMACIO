using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Llistes
{
    public class MetodesLlistes
    {
        public static void Main()
        {
        }

        // --- LLISTES ---
        /// <summary>
        /// Exercici 01
        /// Retorna una llista amb els n primers números naturals.
        /// Exemple: n=3 -> [1, 2, 3]
        /// </summary>
        public static List<int> OmpleNaturals(int n)
        {
            List<int> resultat = new List<int>();
            for (int i = 1; i <= n; i++)
                resultat.Add(i);
            return resultat;
        }

        /// <summary>
        /// Exercici 02
        /// Retorna una llista amb n números enters aleatoris entre -100 i 100.
        /// </summary>
        public static List<int> GeneraLlista(int n, int llavor)
        {
            List<int> resultat = new List<int>();
            Random rnd = new Random(llavor);

            for (int i = 0; i < n; i++)
                resultat.Add(rnd.Next(-100, 101));

            return resultat;
        }

        /// <summary>
        /// /// Exercici 03
        /// Retorna la suma de tots els elements de la llista.
        /// </summary>
        public static int SumaLlista(List<int> llista)
        {
            int suma = 0;
            for (int i = 0; i < llista.Count; i++)
                suma += llista[i];
            return suma;
        }

        /// <summary>
        /// /// Exercici 04
        /// Retorna el valor més petit de la llista.
        /// </summary>
        public static int MinimLlista(List<int> llista)
        {
            int min = llista[0];
            for (int i = 1; i < llista.Count; i++)
                if (llista[i] < min) min = llista[i];
            return min;
        }

        /// /// Exercici 05
        /// Retorna l'índex (posició) del valor més petit de la llista.
        /// Si hi ha empats,
        /// /// </summary>
        public static int PosicioMinimLlista(List<int> llista)
        {
            int min = llista[0];
            int pos = 0;

            for (int i = 1; i < llista.Count; i++)
            {
                if (llista[i] < min)
                {
                    min = llista[i];
                    pos = i;
                }
            }
            return pos;
        }

        /// <summary>
        /// /// Exercici 06
        /// Retorna el valor més gran de la llista.
        /// </summary>
        public static int MaximLlista(List<int> llista)
        {
            int max = llista[0];
            for (int i = 1; i < llista.Count; i++)
                if (llista[i] > max) max = llista[i];
            return max;
        }

        /// <summary>
        /// /// Exercici 07
        /// Retorna el promig de tots els elements de la llista.
        /// </summary>
        public static double MitjanaLlista(List<int> llista)
        {
            return (double)SumaLlista(llista) / llista.Count;
        }

        /// <summary>
        /// /// Exercici 08
        /// MODIFICA la llista original, invertint l'ordre dels seus elements.
        /// (El primer element passa a ser l'últim, el segon el penúltim, etc.)
        /// </summary>
        public static void CapgiraLlista(List<int> llista)
        {
            int esquerra = 0;
            int dreta = llista.Count - 1;

            while (esquerra < dreta)
            {
                int tmp = llista[esquerra];
                llista[esquerra] = llista[dreta];
                llista[dreta] = tmp;

                esquerra++;
                dreta--;
            }
        }

        /// <summary>
        /// /// Exercici 09
        /// Retorna la primera posició (índex) on apareix 'valor' a la llista.
        /// Si 'valor' no apareix, retorna -1.
        /// </summary>
        public static int PosicioDe(List<int> llista, int valor)
        {
            for (int i = 0; i < llista.Count; i++)
                if (llista[i] == valor) return i;
            return -1;
        }

        /// <summary>
        /// /// Exercici 10
        /// Retorna 'true' si 'valor' apareix dins la llista, cridant a 'PosicioDe'.
        /// </summary>
        public static bool Conte(List<int> llista, int valor)
        {
            if (PosicioDe(llista, valor) != -1) return true;
            else return false;
        }

        /// <summary>
        /// /// Exercici 11
        /// Retorna 'true' si 'valor' apareix a la llista dins l'interval
        /// d'índexs [indexDesDe, indexFinsA] (ambdós inclosos).
        /// </summary>
        public static bool ConteEnRang(List<int> llista, int valor, int indexDesDe, int indexFinsA)
        {
            for (int i = indexDesDe; i <= indexFinsA; i++)
                if (llista[i] == valor) return true;
            return false;
        }

        /// <summary>
        /// /// Exercici 12
        /// Retorna un string amb el contingut de la llista, formatat.
        /// Exemple: per a {10, 20} ha de retornar "Index 0: 10\nIndex 1: 20"
        /// </summary>
        public static string LlistaAString(List<int> llista)
        {
            string resultat = "";
            for (int i = 0; i < llista.Count; i++)
            {
                resultat += "Index " + i + ": " + llista[i];
                if (i < llista.Count - 1) resultat += "\n";
            }
            return resultat;
        }

        /// <summary>
        /// /// Exercici 13
        /// Donades dues llistes ordenades i sense elements repetits, retorna una nova llista amb els elements COMUNS.
        /// </summary>
        public static List<int> ComunsOrdenades(List<int> llista1, List<int> llista2)
        {
            List<int> resultat = new List<int>();
            int i = 0, j = 0;

            while (i < llista1.Count && j < llista2.Count)
            {
                if (llista1[i] == llista2[j])
                {
                    resultat.Add(llista1[i]);
                    i++;
                    j++;
                }
                else if (llista1[i] < llista2[j]) i++;
                else j++;
            }

            return resultat;
        }

        /// <summary>
        /// /// Exercici 14
        /// Donades dues llistes ordenades i sense elements repetits, retorna una nova llista amb els elements NO COMUNS
        /// (elements que estan a llista1 però no a llista2, i elements de llista2 que no estan a llista1).
        /// </summary>
        public static List<int> NoComunsOrdenades(List<int> llista1, List<int> llista2)
        {
            List<int> res = new List<int>();
            int i = 0, j = 0;

            while (i < llista1.Count && j < llista2.Count)
            {
                if (llista1[i] == llista2[j])
                {
                    i++;
                    j++;
                }
                else if (llista1[i] < llista2[j])
                {
                    res.Add(llista1[i]);
                    i++;
                }
                else
                {
                    res.Add(llista2[j]);
                    j++;
                }
            }

            while (i < llista1.Count)
            {
                res.Add(llista1[i]);
                i++;
            }

            while (j < llista2.Count)
            {
                res.Add(llista2[j]);
                j++;
            }

            return res;
        }

        /// <summary>
        /// /// Exercici 15
        /// Donades dues llistes ordenades i sense elements repetits, retorna una nova llista (ordenada)
        /// que és la FUSIÓ de les dues, però sense elements repetits
        /// </summary>
        public static List<int> FusioOrdenades(List<int> llista1, List<int> llista2)
        {
            List<int> res = new List<int>();
            int i = 0, j = 0;

            while (i < llista1.Count && j < llista2.Count)
            {
                int valor;

                if (llista1[i] < llista2[j])
                {
                    valor = llista1[i];
                    i++;
                }
                else if (llista1[i] > llista2[j])
                {
                    valor = llista2[j];
                    j++;
                }
                else
                {
                    valor = llista1[i];
                    i++;
                    j++;
                }

                if (res.Count == 0 || res[res.Count - 1] != valor)
                {
                    res.Add(valor);
                }
            }

            while (i < llista1.Count)
            {
                int valor = llista1[i];
                if (res.Count == 0 || res[res.Count - 1] != valor)
                    res.Add(valor);
                i++;
            }

            while (j < llista2.Count)
            {
                int valor = llista2[j];
                if (res.Count == 0 || res[res.Count - 1] != valor)
                    res.Add(valor);
                j++;
            }

            return res;
        }

        // --- LLISTES DE LLISTES (MATRIUS) ---
        /// <summary>
        /// Exercici 16
        /// Retorna una matriu NxM plena per files.
        /// Exemple (nFiles=3, nColumnes=2):
        /// {{1, 1}
        /// {2, 2}
        /// {3, 3}}
        public static List<List<int>> OmpleMatriuPerFiles(int nFiles, int nColumnes)
        {
            List<List<int>> matriu = new List<List<int>>();

            for (int f = 0; f < nFiles; f++)
            {
                List<int> fila = new List<int>();
                for (int c = 0; c < nColumnes; c++)
                    fila.Add(f + 1);
                matriu.Add(fila);
            }
            return matriu;
        }

        /// <summary>
        /// Exercici 17
        /// Retorna una matriu NxM plena per columnes.
        /// Exemple (nFiles=3, nColumnes=2):
        /// {{1, 2}
        /// {1, 2}
        /// {1, 2}}
        /// </summary>
        public static List<List<int>> OmpleMatriuPerColumnes(int nFiles, int nColumnes)
        {
            List<List<int>> matriu = new List<List<int>>();

            for (int f = 0; f < nFiles; f++)
            {
                List<int> fila = new List<int>();
                for (int c = 0; c < nColumnes; c++)
                    fila.Add(c + 1);
                matriu.Add(fila);
            }
            return matriu;
        }

        /// <summary>
        /// Exercici 18
        /// Retorna una matriu NxM plena amb números naturals consecutius (començant per 1).
        /// Exemple (nFiles=2, nColumnes=3):
        /// {{1, 2, 3}
        /// {4, 5, 6}}
        /// </summary>
        public static List<List<int>> OmpleMatriuConsecutius(int nFiles, int nColumnes)
        {
            List<List<int>> matriu = new List<List<int>>();
            int valor = 1;

            for (int f = 0; f < nFiles; f++)
            {
                List<int> fila = new List<int>();
                for (int c = 0; c < nColumnes; c++)
                {
                    fila.Add(valor);
                    valor++;
                }
                matriu.Add(fila);
            }

            return matriu;
        }

        /// <summary>
        /// Exercici 19
        /// Retorna una matriu NxM plena amb números naturals consecutius en ordre invers.
        /// Exemple (nFiles=2, nColumnes=3) -> Total 6 elements:
        /// {{6, 5, 4}
        /// {3, 2, 1}}
        /// </summary>
        public static List<List<int>> OmpleMatriuConsecutiusInvers(int nFiles, int nColumnes)
        {
            List<List<int>> matriu = new List<List<int>>();
            int total = nFiles * nColumnes;

            for (int f = 0; f < nFiles; f++)
            {
                List<int> fila = new List<int>();
                for (int c = 0; c < nColumnes; c++)
                {
                    fila.Add(total);
                    total--;
                }
                matriu.Add(fila);
            }
            return matriu;
        }

        /// <summary>
        /// Exercici 20
        /// Retorna una matriu quadrada NxN que és la matriu identitat.
        /// (1 a la diagonal, 0 a la resta).
        /// </summary>
        public static List<List<int>> OmpleMatriuIdentitat(int nFiles)
        {
            List<List<int>> matriu = new List<List<int>>();

            for (int f = 0; f < nFiles; f++)
            {
                List<int> fila = new List<int>();
                for (int c = 0; c < nFiles; c++)
                {
                    if (f == c) fila.Add(1);
                    else fila.Add(0);
                }
                matriu.Add(fila);
            }
            return matriu;
        }

        /// <summary>
        /// Exercici 21
        /// Retorna el valor més petit dins de la 'matriu'.
        /// </summary>
        public static int MinimMatriu(List<List<int>> matriu)
        {
            int min = matriu[0][0];

            for (int f = 0; f < matriu.Count; f++)
            {
                for (int c = 0; c < matriu[f].Count; c++)
                {
                    if (matriu[f][c] < min)
                        min = matriu[f][c];
                }
            }

            return min;
        }

        /// <summary>
        /// Exercici 22
        /// Retorna una llista de 2 enters {fila, columna} amb la posició
        /// del valor més petit de la 'matriu'.
        /// </summary>
        public static int[] PosicioMinimMatriu(List<List<int>> matriu)
        {
            int min = matriu[0][0];
            int[] pos = new int[2] { 0, 0 };

            for (int f = 0; f < matriu.Count; f++)
            {
                for (int c = 0; c < matriu[f].Count; c++)
                {
                    if (matriu[f][c] < min)
                    {
                        min = matriu[f][c];
                        pos[0] = f;
                        pos[1] = c;
                    }
                }
            }

            return pos;
        }
    }
}
