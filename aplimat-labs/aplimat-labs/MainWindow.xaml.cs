<<<<<<< HEAD
﻿using aplimat_labs.Utilities;
=======
﻿using aplimat_labs.Models;
using aplimat_labs.Utilities;
>>>>>>> c79c0b298f8088a0c70a564e5dbdd0420038b0ef
using SharpGL;
using SharpGL.SceneGraph.Primitives;
using SharpGL.SceneGraph.Quadrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aplimat_labs
{
<<<<<<< HEAD
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
<<<<<<< HEAD
			//myVector = a - b;
			//Console.WriteLine(myVector.GetMagnitute());

			//while (true) Console.WriteLine(rng.Generate());
		}
		private CubeMesh mover = new CubeMesh(-25, 0, 0);
		private Vector3 acceleration = new Vector3(0.01f, 0, 0);
		private bool hasStopped;

		//private Vector3 mousePos = new Vector3();
		////private CubeMesh myCube = new CubeMesh();

		//public Randomizer COLORrng = new Randomizer(0, 1);
		//private Vector3 myVector = new Vector3();

		//private Vector3 a = new Vector3(8, 5, 0);
		//private Vector3 b = new Vector3(-7, -6, 0);


		private void OpenGLControl_OpenGLDraw(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
		{
			OpenGL gl = args.OpenGL;
			//myVector = a - b;
			// Clear The Screen And The Depth Buffer
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
			// Move Left And Into The Screen
			gl.LoadIdentity();
			gl.Translate(0.0f, 0.0f, -40.0f);
			mover.Draw(gl);
			mover.Velocity += acceleration;
			if (mover.Position.x >= 25.0f)
			{
				//mover.Position.x = 15.0f;
				mover.Position.x /= acceleration.x;
				//mover.Clamp(25)
			}
			gl.DrawText(20, 20, 1, 0, 0, "Arial", 25, mover.Velocity.x + " ");
			//mousePos.Normalizer();
			//mousePos *= 10;

			//gl.LineWidth(30.0f);
			//gl.Begin(OpenGL.GL_LINE_STRIP);
			//gl.Color(0.0, 5.0, 5.0);
			//gl.Vertex(0, 0, 0);
			//gl.Vertex(mousePos.x, mousePos.y);
			//gl.End();


			//gl.LineWidth(3.0f);
			//gl.Begin(OpenGL.GL_LINE_STRIP);
			//gl.Color(1.0f, 1.0f, 1.0f);
			//gl.Vertex(0, 0, 0);
			//gl.Vertex(mousePos.x, mousePos.y);
			//gl.End();
=======
    public partial class MainWindow : Window
    {

        private const float LINE_SMOOTHNESS = 0.02f;
        private const float GRAPH_LIMIT = 15;
        private const int TOTAL_CIRCLE_ANGLE = 360;
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);
        }

        private void OpenGLControl_OpenGLDraw(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
        {
            OpenGL gl = args.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -40.0f);
            //gl.Color(0, 1, 0);
            DrawCartesianPlane(gl); //draw cartesian plane with unit lines
            DrawPoint(gl, 1, 1); //draw a point with coordinates (1, 1)
            DrawLinearFunction(gl);
            DrawQuadraticFunction(gl);
            DrawCircle(gl);
        }
        

        private void DrawCartesianPlane(OpenGL gl)
        {

            //draw y-axis
            gl.Begin(OpenGL.GL_LINE_STRIP);

            gl.Color(1.0f, 0.0f, 1.0f);
            gl.Vertex(0, -GRAPH_LIMIT, 0);
            gl.Vertex(0, GRAPH_LIMIT, 0);
            gl.End();

            //draw x-axis
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Vertex(-GRAPH_LIMIT, 0, 0);
            gl.Vertex(GRAPH_LIMIT, 0, 0);
            gl.End();

            //draw unit lines
            for (int i = -15; i <= 15; i++)
            {
                gl.Begin(OpenGL.GL_LINE_STRIP);
                gl.Vertex(-0.2f, i, 0);
                gl.Vertex(0.2f, i, 0);
                gl.End();

                gl.Begin(OpenGL.GL_LINE_STRIP);
                gl.Vertex(i, -0.2f, 0);
                gl.Vertex(i, 0.2f, 0);
                gl.End();
            }
        }

        private void DrawPoint(OpenGL gl, float x, float y)
        {
            gl.PointSize(5.0f);
            gl.Begin(OpenGL.GL_POINTS);
            gl.Vertex(x, y);
            gl.End();
        }

        private void DrawLinearFunction(OpenGL gl)
        {
            /*
             * f(x) = x + 2;
             * Let x be 4, then y = 6 (4, 6)
             * Let x be -5, then y = -3 (-5, -3)
             * */
            gl.PointSize(2.0f);
            gl.Begin(OpenGL.GL_POINTS);
            for (float x = -(GRAPH_LIMIT - 5); x <= (GRAPH_LIMIT - 5); x+=LINE_SMOOTHNESS)
            {
                gl.Vertex(x, x + 2);
            }
            gl.End();

            DrawText(gl, "f(x) = x + 2", 500, 400);

        }


        private void DrawQuadraticFunction(OpenGL gl)
        {
            /*
             * f(x) = x^2 + 2x - 5;
             * Let x be 2, then y = 3
             * Let x be -1, then y = -6
             */

            //gl.PointSize(1.0f);
            //gl.Begin(OpenGL.GL_POINTS);
            //for (float x = -(GRAPH_LIMIT - 5); x <= (GRAPH_LIMIT - 5); x += LINE_SMOOTHNESS)
            //{
            //    gl.Vertex(x, Math.Pow(x, 2) + (2 * x) - 5);
            //}
            //gl.End();

            /*
             * f(x) = x^2
             * 
             */
            gl.PointSize(2.0f);
            gl.Begin(OpenGL.GL_POINTS);
            for (float x = -(GRAPH_LIMIT - 5); x <= (GRAPH_LIMIT - 5); x += LINE_SMOOTHNESS)
            {
                gl.Vertex(x, Math.Pow(x, 2));
            }
            gl.End();

            DrawText(gl, "f(x) = x ^ 2", 360, 380);

        }

        private void DrawCircle(OpenGL gl)
        {
            float radius = 3.0f;

            gl.PointSize(2.0f);
            gl.Begin(OpenGL.GL_POINTS);
            for (int i = 0; i <= TOTAL_CIRCLE_ANGLE; i++)
            {
                gl.Vertex(Math.Cos(i) * radius, Math.Sin(i) * radius);
            }
            gl.End();

            DrawText(gl, "(cos(x), sin(x))", 350, 200);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    break;
            }
        } 
        #region opengl init
        private void OpenGLControl_OpenGLInitialized(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
        {
            OpenGL gl = args.OpenGL;
>>>>>>> 1f967cfc9aa17c57ea4a410868240178067ed8c2

			//gl.LineWidth(3.0f);
			//gl.Begin(OpenGL.GL_LINE_STRIP);
			//gl.Color(1.0f, 1.0f, 1.0f);
			//gl.Vertex(5, 0, 0);
			//gl.Vertex(mousePos.x, mousePos.y);
			//gl.End();

			//gl.DrawText(0, 0, 1, 1, 1, "Arial", 15, "my Vector magnitude: " + myVector.GetMagnitute());

			//myCube.Draw(gl);
			//myCube.Position += velocity * speed;

			//if (myCube.Position.x >= 28.0f)
			//{
			//    velocity.x = -1;
			//}
			//else if (myCube.Position.x <= -28.0f)
			//{

<<<<<<< HEAD
			//}

			//CubeMesh myCube = new CubeMesh();
			//Randomizer rng = new Randomizer(-20, 20);
=======
			myVector = a - b;
			Console.WriteLine(myVector.GetMagnitute());

			//while (true) Console.WriteLine(rng.Generate());
		}

		//private CubeMesh myCube = new CubeMesh();

		public Randomizer COLORrng = new Randomizer(0, 1);
		//private List<CubeMesh> myCubes = new List<CubeMesh>();
		private CubeMesh myCube = new CubeMesh();
		private Vector3 velocity = new Vector3(1, 1, 0);
		private float speed = 2.0f;

		private Vector3 myVector = new Vector3();

		private Vector3 a = new Vector3(3, 5, 0);
		private Vector3 b = new Vector3(-7, -6, 0);
		private Vector3 c = new Vector3(4, 6, 0);
		private Vector3 d = new Vector3(-8, -7, 0);


		private void OpenGLControl_OpenGLDraw(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
		{
			OpenGL gl = args.OpenGL;
			myVector = a - b;
			// Clear The Screen And The Depth Buffer
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

			// Move Left And Into The Screen
			gl.LoadIdentity();
			gl.Translate(0.0f, 0.0f, -40.0f);
			//vector a
			gl.Color(5.0f, 0.0f, 1.0f);

			gl.LineWidth(500);
			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(a.x, a.y);
			gl.Vertex(b.x, b.y);
			gl.End();

			gl.LineWidth(500);
			gl.Begin(OpenGL.GL_LINE_STRIP);
			gl.Vertex(c.x, c.y);
			gl.Vertex(d.x, d.y);
			gl.End();





			gl.DrawText(0, 0, 1, 1, 1, "Arial", 15, "Force Power: " + myVector.GetMagnitute());

			


			// CubeMesh myCube = new CubeMesh();
			Randomizer rng = new Randomizer(-20, 20);


>>>>>>> c79c0b298f8088a0c70a564e5dbdd0420038b0ef
			//myCube.Position = new Vector3(Gaussian.Generate(0, 15), 0, 0);

			//myCubes.Add(myCube);
			//foreach (var cube in myCubes)
<<<<<<< HEAD
			//{
			//    myCube.Draw(gl);
			//    cube.Position += new Vector3(0, rng.GenerateDouble(), 0);
			//    gl.Color(COLORrng.GenerateDouble(), COLORrng.GenerateDouble(), COLORrng.GenerateDouble());
=======
			// {
			// myCube.Draw(gl);

			//cube.Position += new Vector3(0, rng.GenerateDouble(), 0);
			//  gl.Color(COLORrng.GenerateDouble(), COLORrng.GenerateDouble(), COLORrng.GenerateDouble());


>>>>>>> c79c0b298f8088a0c70a564e5dbdd0420038b0ef
			//}

		}

		private void OpenGLControl_OpenGLInitialized(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
		{
			OpenGL gl = args.OpenGL;

			gl.Enable(OpenGL.GL_DEPTH_TEST);

			float[] global_ambient = new float[] { 0.5f, 0.5f, 0.5f, 1.0f };
			float[] light0pos = new float[] { 0.0f, 5.0f, 10.0f, 1.0f };
			float[] light0ambient = new float[] { 0.2f, 0.2f, 0.2f, 1.0f };
			float[] light0diffuse = new float[] { 0.3f, 0.3f, 0.3f, 1.0f };
			float[] light0specular = new float[] { 0.8f, 0.8f, 0.8f, 1.0f };

			float[] lmodel_ambient = new float[] { 0.2f, 0.2f, 0.2f, 1.0f };
			gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, lmodel_ambient);

			gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, global_ambient);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, light0pos);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, light0ambient);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, light0diffuse);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, light0specular);
			gl.Disable(OpenGL.GL_LIGHTING);
			gl.Disable(OpenGL.GL_LIGHT0);

			gl.ShadeModel(OpenGL.GL_SMOOTH);
		}
<<<<<<< HEAD

		private void OpenGLControl_MouseMove(object sender, MouseEventArgs e)
		{
			var pos = e.GetPosition(this);
			//mousePos.x = (float)pos.X - (float)Width / 2.0f;
			//mousePos.y = (float)pos.Y - (float)Height / 2.0f;

			//mousePos.y = -mousePos.y;

			//Console.WriteLine("mouse x: " + mousePos.x + " y: " + mousePos.y);
		}
=======
>>>>>>> c79c0b298f8088a0c70a564e5dbdd0420038b0ef
	}
=======
            gl.ShadeModel(OpenGL.GL_SMOOTH);

        }
        #endregion

        #region draw text
        private void DrawText(OpenGL gl, string text, int x, int y)
        {
            gl.DrawText(x, y, 1, 1, 1, "Arial", 12, text);
        }
        #endregion
    }
>>>>>>> 1f967cfc9aa17c57ea4a410868240178067ed8c2
}
