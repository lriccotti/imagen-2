/*
 * Created by SharpDevelop.
 * User: VaCkensi
 * Date: 18/11/2021
 * Time: 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Imagenv2_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		string[] nombre_imagenes;
		string  ubicacion_imagenes;
		Random  valor_r;
		int pic_mostrar;
		
		
		public MainForm()
		{
			
			
			
			InitializeComponent();
			
			
		}
		
		void Btn1Click(object sender, EventArgs e)
		{
			valor_r=new Random();
			pic_mostrar= valor_r.Next(0,5);
			
			pic1.Image= Image.FromFile(nombre_imagenes[pic_mostrar]);
				
			
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			nombre_imagenes =new string[5];
			ubicacion_imagenes="C:\\Users\\VaCkensi\\Pictures\\Tp_imagenesv2\\";
			nombre_imagenes[0]=ubicacion_imagenes+"1.jpg";
			nombre_imagenes[1]=ubicacion_imagenes+"2.jpg";
			nombre_imagenes[2]=ubicacion_imagenes+"3.jpg";
			nombre_imagenes[3]=ubicacion_imagenes+"4.jpg";
			nombre_imagenes[4]=ubicacion_imagenes+"5.jpg";	

			
			
			
						
		}
		
		
	}
}
