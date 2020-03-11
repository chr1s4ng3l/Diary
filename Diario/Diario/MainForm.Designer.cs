/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 20/11/2019
 * Hora: 09:10 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Diario
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Salir = new System.Windows.Forms.Button();
			this.Guardar = new System.Windows.Forms.Button();
			this.buttonAbrir = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mostrsrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.borrarDeRecientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.borrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBoxHistorial = new System.Windows.Forms.ListBox();
			this.labelFecha = new System.Windows.Forms.Label();
			this.textBoxDiario = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Salir
			// 
			this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Salir.AutoSize = true;
			this.Salir.BackColor = System.Drawing.Color.Transparent;
			this.Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Salir.Location = new System.Drawing.Point(570, 448);
			this.Salir.Name = "Salir";
			this.Salir.Size = new System.Drawing.Size(94, 32);
			this.Salir.TabIndex = 17;
			this.Salir.Text = "Exit";
			this.Salir.UseVisualStyleBackColor = false;
			this.Salir.Click += new System.EventHandler(this.SalirClick);
			// 
			// Guardar
			// 
			this.Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Guardar.AutoSize = true;
			this.Guardar.BackColor = System.Drawing.Color.Transparent;
			this.Guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
			this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Guardar.Location = new System.Drawing.Point(2, 448);
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(87, 32);
			this.Guardar.TabIndex = 15;
			this.Guardar.Text = "Save";
			this.Guardar.UseVisualStyleBackColor = false;
			this.Guardar.Click += new System.EventHandler(this.GuardarClick);
			// 
			// buttonAbrir
			// 
			this.buttonAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonAbrir.AutoSize = true;
			this.buttonAbrir.BackColor = System.Drawing.Color.Transparent;
			this.buttonAbrir.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.buttonAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAbrir.Location = new System.Drawing.Point(314, 448);
			this.buttonAbrir.Name = "buttonAbrir";
			this.buttonAbrir.Size = new System.Drawing.Size(87, 32);
			this.buttonAbrir.TabIndex = 18;
			this.buttonAbrir.Text = "Open";
			this.buttonAbrir.UseVisualStyleBackColor = false;
			this.buttonAbrir.Click += new System.EventHandler(this.ButtonAbrirClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Archivo txt|*.txt";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Recent";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mostrsrToolStripMenuItem,
									this.borrarToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(116, 48);
			// 
			// mostrsrToolStripMenuItem
			// 
			this.mostrsrToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrsrToolStripMenuItem.Image")));
			this.mostrsrToolStripMenuItem.Name = "mostrsrToolStripMenuItem";
			this.mostrsrToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.mostrsrToolStripMenuItem.Text = "Mostrar";
			this.mostrsrToolStripMenuItem.Click += new System.EventHandler(this.MostrsrToolStripMenuItemClick);
			// 
			// borrarToolStripMenuItem
			// 
			this.borrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.borrarDeRecientesToolStripMenuItem,
									this.borrarTodoToolStripMenuItem});
			this.borrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem.Image")));
			this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
			this.borrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.borrarToolStripMenuItem.Text = "Borrar";
			// 
			// borrarDeRecientesToolStripMenuItem
			// 
			this.borrarDeRecientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrarDeRecientesToolStripMenuItem.Image")));
			this.borrarDeRecientesToolStripMenuItem.Name = "borrarDeRecientesToolStripMenuItem";
			this.borrarDeRecientesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.borrarDeRecientesToolStripMenuItem.Text = "Borrar de recientes";
			this.borrarDeRecientesToolStripMenuItem.Click += new System.EventHandler(this.BorrarDeRecientesToolStripMenuItemClick);
			// 
			// borrarTodoToolStripMenuItem
			// 
			this.borrarTodoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrarTodoToolStripMenuItem.Image")));
			this.borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
			this.borrarTodoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.borrarTodoToolStripMenuItem.Text = "Borrar todo";
			this.borrarTodoToolStripMenuItem.Click += new System.EventHandler(this.BorrarTodoToolStripMenuItemClick);
			// 
			// listBoxHistorial
			// 
			this.listBoxHistorial.ContextMenuStrip = this.contextMenuStrip1;
			this.listBoxHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxHistorial.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxHistorial.FormattingEnabled = true;
			this.listBoxHistorial.ItemHeight = 18;
			this.listBoxHistorial.Location = new System.Drawing.Point(0, 16);
			this.listBoxHistorial.Name = "listBoxHistorial";
			this.listBoxHistorial.Size = new System.Drawing.Size(258, 420);
			this.listBoxHistorial.TabIndex = 23;
			this.listBoxHistorial.DoubleClick += new System.EventHandler(this.ListBoxHistorialDoubleClick);
			// 
			// labelFecha
			// 
			this.labelFecha.AutoSize = true;
			this.labelFecha.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFecha.Location = new System.Drawing.Point(0, 0);
			this.labelFecha.Name = "labelFecha";
			this.labelFecha.Size = new System.Drawing.Size(51, 16);
			this.labelFecha.TabIndex = 20;
			this.labelFecha.Text = "label2";
			// 
			// textBoxDiario
			// 
			this.textBoxDiario.AllowDrop = true;
			this.textBoxDiario.BackColor = System.Drawing.Color.White;
			this.textBoxDiario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDiario.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxDiario.Location = new System.Drawing.Point(0, 16);
			this.textBoxDiario.Multiline = true;
			this.textBoxDiario.Name = "textBoxDiario";
			this.textBoxDiario.Size = new System.Drawing.Size(407, 420);
			this.textBoxDiario.TabIndex = 16;
			this.textBoxDiario.Tag = "";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(2, 6);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.textBoxDiario);
			this.splitContainer1.Panel1.Controls.Add(this.labelFecha);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listBoxHistorial);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(669, 436);
			this.splitContainer1.SplitterDistance = 407;
			this.splitContainer1.TabIndex = 24;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(676, 482);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.buttonAbrir);
			this.Controls.Add(this.Salir);
			this.Controls.Add(this.Guardar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Diary";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.contextMenuStrip1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem borrarTodoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem borrarDeRecientesToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBoxHistorial;
		private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mostrsrToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelFecha;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonAbrir;
		private System.Windows.Forms.Button Guardar;
		private System.Windows.Forms.TextBox textBoxDiario;
		private System.Windows.Forms.Button Salir;
	}
}
