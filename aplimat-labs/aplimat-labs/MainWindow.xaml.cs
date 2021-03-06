﻿using aplimat_labs.Models;
using aplimat_labs.Utilities;
using SharpGL;
using SharpGL.SceneGraph.Primitives;
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
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
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


			//myCube.Position = new Vector3(Gaussian.Generate(0, 15), 0, 0);

			//myCubes.Add(myCube);
			//foreach (var cube in myCubes)
			// {
			// myCube.Draw(gl);

			//cube.Position += new Vector3(0, rng.GenerateDouble(), 0);
			//  gl.Color(COLORrng.GenerateDouble(), COLORrng.GenerateDouble(), COLORrng.GenerateDouble());


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
	}
}
