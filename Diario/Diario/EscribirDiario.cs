/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 20/11/2019
 * Hora: 09:11 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diario
{
	/// <summary>
	/// Description of EscribirDiario.
	/// </summary>
	public partial class EscribirDiario : Form
	{
		public EscribirDiario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBoxPasswordTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ButtonOKClick(object sender, EventArgs e)
		{
			
				this.DialogResult = DialogResult.OK;
			
		}
		
		void SaveClick(object sender, EventArgs e)
		{
			if(textBoxPass.Text.Length > 2 && textBoxConfirm.Text.Length > 2 && textBoxNombre.Text.Length >2){
				
				if(textBoxPass.Text == textBoxConfirm.Text){
					this.DialogResult = DialogResult.OK;
				}else{
					MessageBox.Show("Las contrasenas no coinciden");
				}
			}else{
				MessageBox.Show("Los Campos deben tener al menos 3 caracteres");
			}
		}
	}
}
