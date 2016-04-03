using System;

using MathNet.Numerics.LinearAlgebra.Double;

namespace lstm_tuto
{
    public class Program
    {
        #region Fields

        private static readonly Random random = new Random();

        #endregion

        #region Methods

        private static void Main(string[] args)
        {
            var A = DenseMatrix.OfArray(new double[,]
            {
                {
                    0, 0, 1
                }, 
                {
                    0, 1, 1
                }, 
                {
                    1, 0, 1
                }, 
                {
                    1, 1, 1
                }
            });

            var weights = DenseMatrix.OfArray(new[,]
            {
                {
                    2 * random.NextDouble() - 1
                }, 
                {
                    2 * random.NextDouble() - 1
                }, 
                {
                    2 * random.NextDouble() - 1
                }, 
            });



            var One = DenseMatrix.Build.Dense(4, 3, 1);
            var sub = One.Subtract(A);
            var result = A.Multiply(sub);
            Console.WriteLine(result.ToString());

            /*
            var inputDataset = new float[,]
            {
                {
                    0, 0, 1
                }, 
                {
                    0, 1, 1
                }, 
                {
                    1, 0, 1
                }, 
                {
                    1, 1, 1
                }
            };

            var outputDataset = new float[,]
            {
                {
                    0
                }, 
                {
                    0
                }, 
                {
                    1
                }, 
                {
                    1
                }
            };

            var layer1Weight = new[,]
            {
                {
                    2 * NextFloat(random) - 1
                }, 
                {
                    2 * NextFloat(random) - 1
                }, 
                {
                    2 * NextFloat(random) - 1
                }, 
            };

            var inputMatrix = new Matrix(inputDataset);
            var outputMatrix = new Matrix(outputDataset);
            var layerOneWeightMatrix = new Matrix(layer1Weight);

            var layerTwoWeightMatrix = inputMatrix.Multiply(layerOneWeightMatrix);*/

            // Console.WriteLine(layerTwoWeightMatrix.ToString());
            for (var i = 0; i < 10000; i++)
            {
            }

            // Console.WriteLine(string.Join(", ", layer1Weight.Cast<float>().ToList()));
            Console.Read();
        }

        private static float NextFloat(Random random)
        {
            /*double mantissa = (random.NextDouble() * 2.0) - 1.0;
            double exponent = Math.Pow(2.0, random.Next(-126, 128));
            return (float)(mantissa * exponent);*/
            return (float)random.NextDouble();
        }

        #endregion
    }

    /*  public class Matrix
    {
        #region Fields

        private readonly float[,] matrix;
        private readonly int RowSize;
        private readonly int ColSize;

        #endregion

        #region Constructors

        public Matrix(float[,] matrix)
        {
            this.matrix = matrix;
            this.RowSize = this.matrix.GetLength(0);
            this.ColSize = this.matrix.GetLength(1);
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            var builder = new StringBuilder();

            for (var i = 0; i < this.RowSize; i++)
            {
                var row = new float[this.ColSize];
                for (var j = 0; j < this.ColSize; j++)
                {
                    row[j] = this.matrix[i, j];
                }

                builder.Append(string.Join(", ", row)).Append("\n");
            }

            return builder.ToString();
        }

        public float[,] GetMatrix()
        {
            return this.matrix;
        }

        public Matrix Substract(Matrix matrix2)
        {
            var matrix2Value = matrix2.GetMatrix();
            var subtractedMatrix = new float[this.RowSize, this.ColSize];
            for (int i = 0; i < this.RowSize; i++)
            {
                for (int j = 0; j < this.ColSize; j++)
                {
                    subtractedMatrix[i,j] = this.matrix[i, j] - matrix2Value[i, j];
                }
            }

            return new Matrix(subtractedMatrix);
        }

        public Matrix Multiply(Matrix m2)
        {
            var matrix2 = m2.GetMatrix();

            var dotX = this.RowSize;
            var dotY = m2.ColSize;
            var vectorSize = this.matrix.GetLength(1);

            var dotResult = new float[dotX, dotY];
            for (var x = 0; x < dotX; x++)
            {
                for (var y = 0; y < dotY; y++)
                {
                    dotResult[x, y] = this.VectorDotProduct(matrix2, x, y, vectorSize);
                }
            }

            return new Matrix(dotResult);
        }

        private float VectorDotProduct(float[,] m2, int row, int col, int vectorSize)
        {
            float result = 0;

            for (int i = 0; i < vectorSize; i++)
            {
                result += this.matrix[row, i] * m2[i, col];
            }

            return result;
        }

        #endregion
    }

    public class Vector
    {
        #region Fields

        private readonly float[] vector;

        #endregion

        #region Constructors

        public Vector(float[] vector)
        {
            this.vector = vector;
        }

        #endregion

        #region Methods

        public float DotProduct(Vector v2)
        {
            var vector2 = v2.GetValue();
            var result = 0.0f;
            for (var i = 0; i < this.vector.Length; i++)
            {
                result += this.vector[i] * vector2[i];
            }

            return result;
        }

        public float[] GetValue()
        {
            return this.vector;
        }

        #endregion
    }*/
}