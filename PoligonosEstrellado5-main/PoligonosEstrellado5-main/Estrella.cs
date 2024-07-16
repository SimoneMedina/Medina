using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligonoEstrellado5
{
    internal class Estrella
    {
        public const float SF = 15.0f;
        private Graphics mGraph;
        private Pen mPen;
        public List<PointF> Puntos { get; private set; }
        public float Radio { get; private set; }
        public PointF Centro { get; private set; }

        public Estrella()
        {
            Puntos = new List<PointF>();
        }

        public void EstablecerGraphics(Graphics graph) { mGraph = graph; }
        public void EstablecerPen(Pen pen) { mPen = pen; }
        public List<PointF> CalcularVertices(float radio, PointF centro)
        {
            Radio = radio * SF;
            Centro = centro;
            Puntos.Clear();

            double anguloInicial = Math.PI / 2;
            for (int i = 0; i < 5; i++)
            {
                double angulo = anguloInicial + i * 2.0 * Math.PI / 5.0;
                float x = (float)(Centro.X + Radio * Math.Cos(angulo));
                float y = (float)(Centro.Y + Radio * Math.Sin(angulo));
                Puntos.Add(new PointF(x, y));
            }

            return Puntos;
        }

        public void Dibujar()
        {
            if (mGraph == null || mPen == null || Puntos.Count != 5)
                return;

            // Dibujar círculo
            mGraph.DrawEllipse(mPen, Centro.X - Radio, Centro.Y - Radio, 2 * Radio, 2 * Radio);

            // Dibujar círculo interno con la mitad del radio
            float radioInterno = Radio / 2;
            mGraph.DrawEllipse(mPen, Centro.X - radioInterno, Centro.Y - radioInterno, 2 * radioInterno, 2 * radioInterno);
            // Dibujar círculo interno con la mitad del radio
            float radioInterno1 = 5 * Radio /4;

            mGraph.DrawEllipse(mPen, Centro.X - radioInterno1, Centro.Y - radioInterno1, 2 * radioInterno1, 2 * radioInterno1);


            // Dibujar pentágono
            mGraph.DrawPolygon(mPen, Puntos.ToArray());

            // Dibujar pentágono dentro del círculo interno
            List<PointF> puntosInternos = new List<PointF>();
            double anguloInicialInterno = Math.PI / 2;
            for (int i = 0; i < 5; i++)
            {
                double angulo = anguloInicialInterno + i * 2.0 * Math.PI / 5.0;
                float x = (float)(Centro.X + radioInterno * Math.Cos(angulo));
                float y = (float)(Centro.Y + radioInterno * Math.Sin(angulo));
                puntosInternos.Add(new PointF(x, y));
            }
            mGraph.DrawPolygon(mPen, puntosInternos.ToArray());
            List<PointF> puntosInternos2 = new List<PointF>();
            double anguloInicialInterno2 = Math.PI / 4;
            for (int i = 0; i < 5; i++)
            {
                double angulo = anguloInicialInterno2 + i * 2.0 * Math.PI / 5.0;
                float x = (float)(Centro.X + radioInterno1 * Math.Cos(angulo));
                float y = (float)(Centro.Y + radioInterno1 * Math.Sin(angulo));
                puntosInternos2.Add(new PointF(x, y));
            }
            mGraph.DrawPolygon(mPen, puntosInternos2.ToArray());

            // Dibujar estrella
            List<Line> lineas = new List<Line>();
            for (int i = 0; i < 5; i++)
            {
                Line linea = new Line(Puntos[i], Puntos[(i + 2) % 5]);
                lineas.Add(linea);
                mGraph.DrawLine(mPen, linea.Start, linea.End);
            }
            // Dibujar líneas desde los puntos del pentágono interno al siguiente punto en sentido horario en el pentágono grande
            for (int i = 0; i < 5; i++)
            {
                PointF puntoInterno = puntosInternos[i];

                // Encuentra el punto más cercano en el pentágono grande
                PointF puntoCercano = Puntos[0];
                float distanciaMinima = CalcularDistancia(puntoInterno, Puntos[0]);
                int indicePuntoCercano = 0;

                for (int j = 1; j < 5; j++)
                {
                    float distancia = CalcularDistancia(puntoInterno, Puntos[j]);
                    if (distancia < distanciaMinima)
                    {
                        distanciaMinima = distancia;
                        puntoCercano = Puntos[j];
                        indicePuntoCercano = j;
                    }
                }

                // Encuentra la siguiente punta en sentido horario
                int indiceSiguiente = (indicePuntoCercano + 1) % 5;
                PointF puntoSiguiente = Puntos[indiceSiguiente];

                // Dibuja la línea
                mGraph.DrawLine(new Pen(Color.Blue, 2), puntoInterno, puntoSiguiente);
            }
            // Dibujar líneas desde los puntos del pentágono interno al punto más cercano en sentido antihorario en el pentágono grande
            for (int i = 0; i < 5; i++)
            {
                PointF puntoInterno = puntosInternos[i];

                // Encuentra el punto más cercano en el pentágono grande
                PointF puntoCercano = Puntos[0];
                float distanciaMinima = CalcularDistancia(puntoInterno, Puntos[0]);
                int indicePuntoCercano = 0;

                for (int j = 1; j < 5; j++)
                {
                    float distancia = CalcularDistancia(puntoInterno, Puntos[j]);
                    if (distancia < distanciaMinima)
                    {
                        distanciaMinima = distancia;
                        puntoCercano = Puntos[j];
                        indicePuntoCercano = j;
                    }
                }

                // Encuentra la punta anterior en sentido antihorario
                int indiceAnterior = (indicePuntoCercano - 1 + 5) % 5;
                PointF puntoAnterior = Puntos[indiceAnterior];

                // Dibuja la línea
                mGraph.DrawLine(new Pen(Color.Blue, 2), puntoInterno, puntoAnterior);
            }

            // Calcular los puntos medios de los lados del pentágono dentro del círculo más grande
            List<PointF> puntosMediosInternos2 = new List<PointF>();
            for (int i = 0; i < 5; i++)
            {
                PointF punto1 = puntosInternos2[i];
                PointF punto2 = puntosInternos2[(i + 1) % 5];
                PointF puntoMedio = new PointF(
                    (punto1.X + punto2.X) / 2,
                    (punto1.Y + punto2.Y) / 2
                );
                puntosMediosInternos2.Add(puntoMedio);
            }

            // Dibujar líneas verdes desde cada vértice del pentágono interno al punto medio del lado opuesto en sentido antihorario en el pentágono grande
            Pen verdePen = new Pen(Color.Green, 2);

            for (int i = 0; i < 5; i++)
            {
                PointF puntoInterno = puntosInternos[i];

                // Encuentra el índice del lado opuesto en sentido antihorario en el pentágono dentro del círculo más grande
                int indiceOpuesto = (i + 3) % 5;

                // Dibuja una línea verde al punto medio del lado opuesto
                mGraph.DrawLine(verdePen, puntoInterno, puntosMediosInternos2[indiceOpuesto]);
            }






            List<PointF> intersecciones = new List<PointF>();
            for (int i = 0; i < lineas.Count; i++)
            {
                for (int j = i + 1; j < lineas.Count; j++)
                {
                    PointF? interseccion = lineas[i].GetIntersection(lineas[j]);
                    if (interseccion.HasValue)
                    {
                        intersecciones.Add(interseccion.Value);
                    }
                }
            }

            foreach (PointF punto in intersecciones)
            {
                mGraph.FillEllipse(Brushes.Blue, punto.X - 2, punto.Y - 2, 4, 4);
            }

            int[] indices = { 0, 7, 3, 4, 9, 0 };
            for (int i = 0; i < indices.Length - 1; i++)
            {
                mGraph.DrawLine(new Pen(Color.Red), intersecciones[indices[i]], intersecciones[indices[i + 1]]);
            }
        }


        public struct Line
        {
            public PointF Start;
            public PointF End;

            public Line(PointF start, PointF end)
            {
                Start = start;
                End = end;
            }

            public PointF GetMidpoint()
            {
                float midX = (Start.X + End.X) / 2;
                float midY = (Start.Y + End.Y) / 2;
                return new PointF(midX, midY);
            }

            public PointF? GetIntersection(Line other)
            {
                float A1 = End.Y - Start.Y;
                float B1 = Start.X - End.X;
                float C1 = A1 * Start.X + B1 * Start.Y;
                float A2 = other.End.Y - other.Start.Y;
                float B2 = other.Start.X - other.End.X;
                float C2 = A2 * other.Start.X + B2 * other.Start.Y;
                float delta = A1 * B2 - A2 * B1;
                if (delta == 0)
                {
                    return null; // No hay intersección
                }
                float x = (B2 * C1 - B1 * C2) / delta;
                float y = (A1 * C2 - A2 * C1) / delta;
                return new PointF(x, y);
            }
        }

        private float CalcularDistancia(PointF punto1, PointF punto2)
        {
            float distancia = (float)Math.Sqrt(Math.Pow(punto2.X - punto1.X, 2) + Math.Pow(punto2.Y - punto1.Y, 2));
            return distancia;
        }
    }
}