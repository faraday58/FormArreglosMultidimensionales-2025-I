using System;



namespace FormArreglosMultidimensionales_2025_I
{
    internal class Multidimensional:Matriz
    {
        private float[,] A;

        /// <summary>
        /// Constructor que define el tamaño de la Matriz
        /// </summary>
        /// <param name="M">Número de Renglones</param>
        /// <param name="N">Número de Columnas </param>
        public Multidimensional(int M, int N  )
        {
            this.M = M;
            this.N = N;
            A = new float[M, N];
        }

        public static Multidimensional Read(string A)
        {
            // 1 2 3
            // 4 5 6

            //El usuario introduce la siguiente sintaxis
            //1,2,3;4,5,6
            string[] rows = A.Split(';');
            string[] columns = rows[0].Split(',');

            Multidimensional matrix = 
                new Multidimensional(rows.Length, columns.Length  );

            for( int i =0;  i < matrix.M; i++)
            {
                columns = rows[i].Split(',');

                for( int j=0; j < matrix.N; j++)
                {
                    matrix.A[i, j] = float.Parse(columns[j]);
                }
            }
            return matrix;
        }

        public override string ToString()
        {
            //1 2 3
            //4 5 6
            string A = "";
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A = A + " " + this.A[i, j].ToString();
                }
                A = A + "\n";
            }


            return A; 
        }


        public static Multidimensional operator +(Multidimensional m1, 
            Multidimensional m2)
        {
            Multidimensional m3 = new Multidimensional(m1.M,m2.N);

            for( int i =0; i < m1.M; i++)
            {
                for(int j=0; j< m2.N; j++)
                {
                    m3.A[i,j] = m1.A[i,j] +m2.A[i,j];
                }
            }
            return m3;
        }




    }
}
