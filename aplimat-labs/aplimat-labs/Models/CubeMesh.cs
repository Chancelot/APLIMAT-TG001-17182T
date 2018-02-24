<<<<<<< HEAD
﻿using aplimat_labs.Models;
using SharpGL;
=======
﻿using SharpGL;
>>>>>>> c79c0b298f8088a0c70a564e5dbdd0420038b0ef
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

namespace aplimat_labs
{
    public class CubeMesh : Movable
    {
        public Vector3 Position;

        public CubeMesh()
        {
            this.Position = new Vector3();
        }

        public CubeMesh(float x, float y, float z)
        {
            this.Position = new Vector3(x, y, z);
        }

        public CubeMesh(Vector3 newPos)
        {
            this.Position = newPos;
        }
        
        public void Draw(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
            gl.Color(1.0,0.0,0.0);
            //Front face
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
           
            //Right face
            gl.Vertex(this.Position.x + 0.5f, this.Position.y + 0.5f, this.Position.z - 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y - 0.5f, this.Position.z - 0.5f);
            //Back face
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z - 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z - 0.5f);
            //Left face
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.End();
            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
            gl.Color(1.0, 0.0, 0.0);
            //Top face
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z - 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y + 0.5f, this.Position.z - 0.5f);
            gl.End();
            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
            gl.Color(1.0, 0.0, 0.0);
            //Bottom face
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z - 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y - 0.5f, this.Position.z - 0.5f);
            gl.End();

			ApplyVelocity();
        }

		private void ApplyVelocity()
		{
			this.Position += Velocity;
		}
    }
=======
namespace aplimat_labs.Models
{
	class CubeMesh
	{
		public Vector3 Position;

		public CubeMesh()
		{
			this.Position = new Vector3();
		}

		public CubeMesh(Vector3 initPos)
		{
			this.Position = initPos;
		}

		public CubeMesh(float x, float y, float z)
		{
			this.Position = new Vector3(x, y, z);
		}

		public void Draw(OpenGL gl)
		{
			gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
			//front face
			gl.Vertex(this.Position.x - 0.5, this.Position.y + 0.5f, this.Position.z + 0.5f);
			gl.Vertex(this.Position.x - 0.5, this.Position.y - 0.5f, this.Position.z + 0.5f);
			gl.Vertex(this.Position.x + 0.5, this.Position.y + 0.5f, this.Position.z + 0.5f);
			gl.Vertex(this.Position.x - 0.5, this.Position.y - 0.5f, this.Position.z + 0.5f);
			

			//Right face
			gl.Vertex(this.Position.x + 0.5, this.Position.y + 0.5f, this.Position.z - 0.5f);
			gl.Vertex(this.Position.x + 0.5, this.Position.y - 0.5f, this.Position.z - 0.5f);
			

			//Left face
			gl.Vertex(this.Position.x - 0.5, this.Position.y + 0.5f, this.Position.z + 0.5f);
			gl.Vertex(this.Position.x - 0.5, this.Position.y - 0.5f, this.Position.z + 0.5f);
			gl.End();

			//Top face
			gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
			gl.Vertex(this.Position.x - 0.5, this.Position.y + 0.5f, this.Position.z + 0.5f);
			gl.Vertex(this.Position.x + 0.5, this.Position.y + 0.5f, this.Position.z + 0.5f);
			gl.Vertex(this.Position.x - 0.5, this.Position.y + 0.5f, this.Position.z - 0.5f);
			gl.Vertex(this.Position.x + 0.5, this.Position.y + 0.5f, this.Position.z - 0.5f);
            gl.End();


			//Bottom face
			gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
			gl.Vertex(this.Position.x - 0.5, this.Position.y - 0.5f, this.Position.z + 0.5f);
			gl.Vertex(this.Position.x + 0.5, this.Position.y - 0.5f, this.Position.z + 0.5f);
			gl.Vertex(this.Position.x - 0.5, this.Position.y - 0.5f, this.Position.z - 0.5f);
			gl.Vertex(this.Position.x + 0.5, this.Position.y - 0.5f, this.Position.z - 0.5f);
			gl.End();
		}
	}
>>>>>>> c79c0b298f8088a0c70a564e5dbdd0420038b0ef
}
