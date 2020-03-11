/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 20/11/2019
 * Hora: 09:10 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Diario
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String str, llave ;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			
		}
		public void EscribirDatos(){
			String cadena = "";
			
			for (int i = 0; i < listBoxHistorial.Items.Count; i++) {
				cadena += listBoxHistorial.Items[i].ToString()+"\n";
				
			}
			File.WriteAllText(@"historial.txt", cadena);
			
		}
		public void MostrarHistorial(){
			listBoxHistorial.Text = "";
			try {
				
				if(File.Exists(@"historial.txt")){
					StreamReader leer = new StreamReader(@"historial.txt"); //leemos el archivo historial.txt
					string datos = leer.ReadLine();
					
					while(datos!=null){
						listBoxHistorial.Items.Add(datos);
						datos = leer.ReadLine();
					}
					leer.Close();
				}else{
					StreamWriter leer = File.CreateText(@"historial.txt");
					leer.Close();
				}
				
				
				
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				
			}
		}
		
		public string Encriptar(string Texto, string Llave, bool Mode)
		{
			//Si Mode es falso, encripta, si es verdadero, desencripta
			Int32 p = 0;
			Int32 j = 0;
			Int32 NuChr;

			char letraTexto;
			char letraLlave;
			string Salida = "";


			for (j = 0; j <Texto.Length; j++) {
				letraTexto = Texto[j];
				if (p == llave.Length - 1) {
					p = 0;
				}
				letraLlave = Llave[p];
				
				//si es falso, encripta, si es verdadero, desencripta
				if (Mode == false) {
					NuChr = (int)letraTexto + (int)(letraLlave);
					if (NuChr > 255) {
						NuChr = NuChr - 255;
					}
				} else {
					NuChr =(int)letraTexto - (int)letraLlave;
					if (NuChr < 0) {
						NuChr = NuChr + 255;
					}
				}
				p += 1;
				Salida += (char)NuChr;
			}

			return Salida;
		}

		void GuardarClick(object sender, EventArgs e)
		{
			StreamWriter sw = File.AppendText(@"historial.txt");
			String fecha = labelFecha.Text;
			try {
				
				
				EscribirDiario ventana = new EscribirDiario();
				ventana.buttonOK.Visible = false;
				if(ventana.ShowDialog() == DialogResult.OK){
					String nombreArchivo = ventana.textBoxNombre.Text+" A "+fecha.Substring(0, 2)+" DE "+fecha.Substring(3,2 )+" DEL "+fecha.Substring(6,4 )+".txt";

					
					String ruta = @"Documentos\" + nombreArchivo;
					
					str= textBoxDiario.Text;
					llave = ventana.textBoxConfirm.Text;
					str = Encriptar(str, llave, false);
					
					
					
					
					System.IO.File.WriteAllText(ruta, str);
					
					textBoxDiario.Text = "";
					//
					
					sw.WriteLine(Path.GetFileName(ruta));
					listBoxHistorial.Items.Add(Path.GetFileName(ruta));
					
					MessageBox.Show("Se guardo correctamente","", MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
				}

				
				
			} catch (Exception) {
				
				
			}
			sw.Close();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			textBoxDiario.Select();
			
			//fecha actual
			DateTime fecha = DateTime.Now;
			labelFecha.Text = fecha.ToString();
			
			
			MostrarHistorial();
			
		}
		
		void SalirClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Desea cerrar la ventana? ", "Salir?", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK){
				this.Close();
			}
		}
		
		void ButtonAbrirClick(object sender, EventArgs e)
		{
			try {
				DialogResult resultado;
				resultado = openFileDialog1.ShowDialog();
				EscribirDiario ventana = new EscribirDiario();
				
				
				if(resultado == DialogResult.OK){
					
					
					ventana = new EscribirDiario();
					ventana.save.Visible = false;
					ventana.textBoxConfirm.Visible=false;
					ventana.label1.Visible = false;
					ventana.textBoxNombre.Visible = false;
					ventana.labelNoimbre.Visible = false;
					
					if(ventana.ShowDialog() == DialogResult.OK ){
						String ruta;
						
						ruta = openFileDialog1.FileName;
						str = System.IO.File.ReadAllText(ruta);
						llave = ventana.textBoxPass.Text;

						str = Encriptar(str, llave, true);
						textBoxDiario.Text = str;

						
					}
				}
				
				
			} catch (Exception) {
				
				
			}
		}
		

		


		
		void MostrsrToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				
				if (listBoxHistorial.SelectedItems.Count !=0) {
					EscribirDiario ventana = new EscribirDiario();
					
					ventana = new EscribirDiario();
					ventana.save.Visible = false;
					ventana.textBoxConfirm.Visible=false;
					ventana.label1.Visible = false;
					ventana.textBoxNombre.Visible = false;
					ventana.labelNoimbre.Visible = false;
					
					if(ventana.ShowDialog() == DialogResult.OK ){
						String ruta;
						
						ruta = @"Documentos\"+listBoxHistorial.Text;
						str = System.IO.File.ReadAllText(ruta);
						llave = ventana.textBoxPass.Text;

						str = Encriptar(str, llave, true);
						textBoxDiario.Text = str;

					}
					

					
				}else{
					MessageBox.Show("Debe seleccionar un item","", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
				}
				
				
			} catch (Exception) {
				
				
			}
		}
		
		void ListBoxHistorialDoubleClick(object sender, EventArgs e)
		{
			try {
				
				EscribirDiario ventana = new EscribirDiario();
				
				ventana = new EscribirDiario();
				ventana.save.Visible = false;
				ventana.textBoxConfirm.Visible=false;
				ventana.label1.Visible = false;
				ventana.textBoxNombre.Visible = false;
				ventana.labelNoimbre.Visible = false;
				
				if(ventana.ShowDialog() == DialogResult.OK ){
					String ruta;
					
					ruta = @"Documentos\"+listBoxHistorial.Text;
					str = System.IO.File.ReadAllText(ruta);
					llave = ventana.textBoxPass.Text;

					str = Encriptar(str, llave, true);
					textBoxDiario.Text = str;

					
					
				}
				
				
			} catch (Exception) {
				
				
			}
		}
		
		void BorrarDeRecientesToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listBoxHistorial.SelectedItems.Count !=0) {
				if(MessageBox.Show("Desea eliminar de recientes? ", "Eliminar?", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK){
					//					eliminar de el listbox
					listBoxHistorial.Items.RemoveAt(listBoxHistorial.SelectedIndex);
					EscribirDatos();
					MessageBox.Show("Se elimino correctamente","Eliminar de recientes", MessageBoxButtons.OK ,MessageBoxIcon.Hand);
					
				}
				
			}else{
				MessageBox.Show("Debe seleccionar un item","", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
			}
		}
		
		void BorrarTodoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listBoxHistorial.SelectedItems.Count !=0) {
				
				if(MessageBox.Show("Desea eliminar totalmente? ", "Eliminar?", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK){

					
//					eliminar el archivo txt
					String ruta = @"Documentos\" + listBoxHistorial.SelectedItem.ToString();
					File.Delete(ruta);
					//					eliminar de el listbox
					listBoxHistorial.Items.RemoveAt(listBoxHistorial.SelectedIndex);
					EscribirDatos();
					MessageBox.Show("Se elimino correctamente","Eliminar todo", MessageBoxButtons.OK ,MessageBoxIcon.Hand);
					
				}
			}else{
				MessageBox.Show("Debe seleccionar un item","", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
			}
			
			
		}
	}
}
