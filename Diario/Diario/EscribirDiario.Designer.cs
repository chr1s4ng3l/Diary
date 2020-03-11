/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 20/11/2019
 * Hora: 09:11 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Diario
{
	partial class EscribirDiario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscribirDiario));
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxConfirm = new System.Windows.Forms.TextBox();
			this.Cancelar = new System.Windows.Forms.Button();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.save = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.labelNoimbre = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Password:";
			// 
			// textBoxConfirm
			// 
			this.textBoxConfirm.AllowDrop = true;
			this.textBoxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxConfirm.Location = new System.Drawing.Point(159, 217);
			this.textBoxConfirm.Name = "textBoxConfirm";
			this.textBoxConfirm.PasswordChar = '■';
			this.textBoxConfirm.Size = new System.Drawing.Size(214, 22);
			this.textBoxConfirm.TabIndex = 18;
			this.textBoxConfirm.TextChanged += new System.EventHandler(this.TextBoxPasswordTextChanged);
			// 
			// Cancelar
			// 
			this.Cancelar.AutoSize = true;
			this.Cancelar.BackColor = System.Drawing.Color.Transparent;
			this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancelar.Location = new System.Drawing.Point(281, 255);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(92, 32);
			this.Cancelar.TabIndex = 17;
			this.Cancelar.Text = "Cancel";
			this.Cancelar.UseVisualStyleBackColor = false;
			// 
			// textBoxPass
			// 
			this.textBoxPass.AllowDrop = true;
			this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPass.Location = new System.Drawing.Point(159, 179);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.PasswordChar = '■';
			this.textBoxPass.Size = new System.Drawing.Size(214, 22);
			this.textBoxPass.TabIndex = 16;
			// 
			// save
			// 
			this.save.AutoSize = true;
			this.save.BackColor = System.Drawing.Color.Transparent;
			this.save.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
			this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.save.Location = new System.Drawing.Point(159, 255);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(83, 32);
			this.save.TabIndex = 15;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = false;
			this.save.Click += new System.EventHandler(this.SaveClick);
			// 
			// label3
			// 
			this.label3.AllowDrop = true;
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label3.Location = new System.Drawing.Point(47, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(382, 106);
			this.label3.TabIndex = 20;
			this.label3.Text = "Mi Diario";
			// 
			// label1
			// 
			this.label1.AllowDrop = true;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 217);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "Confirm:";
			// 
			// buttonOK
			// 
			this.buttonOK.AutoSize = true;
			this.buttonOK.BackColor = System.Drawing.Color.Transparent;
			this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
			this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOK.Location = new System.Drawing.Point(159, 255);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(83, 32);
			this.buttonOK.TabIndex = 22;
			this.buttonOK.Text = "Ok";
			this.buttonOK.UseVisualStyleBackColor = false;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.AllowDrop = true;
			this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(159, 141);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(214, 22);
			this.textBoxNombre.TabIndex = 23;
			// 
			// labelNoimbre
			// 
			this.labelNoimbre.AllowDrop = true;
			this.labelNoimbre.AutoSize = true;
			this.labelNoimbre.BackColor = System.Drawing.Color.Transparent;
			this.labelNoimbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNoimbre.Location = new System.Drawing.Point(93, 143);
			this.labelNoimbre.Name = "labelNoimbre";
			this.labelNoimbre.Size = new System.Drawing.Size(60, 20);
			this.labelNoimbre.TabIndex = 24;
			this.labelNoimbre.Text = "Name:";
			// 
			// EscribirDiario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(421, 326);
			this.Controls.Add(this.labelNoimbre);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxConfirm);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.save);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EscribirDiario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MyDiary";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Label labelNoimbre;
		public System.Windows.Forms.TextBox textBoxNombre;
		public System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button save;
		public System.Windows.Forms.TextBox textBoxPass;
		public System.Windows.Forms.Button Cancelar;
		public System.Windows.Forms.TextBox textBoxConfirm;
		private System.Windows.Forms.Label label2;
	}
}
