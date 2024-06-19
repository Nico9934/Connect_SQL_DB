namespace Connect_SQL_DB
{
	partial class Frm_principal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_connect = new System.Windows.Forms.Button();
			this.btn_disconnect = new System.Windows.Forms.Button();
			this.btn_load_data = new System.Windows.Forms.Button();
			this.dgv_data = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_connect
			// 
			this.btn_connect.Location = new System.Drawing.Point(46, 75);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(192, 43);
			this.btn_connect.TabIndex = 0;
			this.btn_connect.Text = "Conectar DB";
			this.btn_connect.UseVisualStyleBackColor = true;
			this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
			// 
			// btn_disconnect
			// 
			this.btn_disconnect.Location = new System.Drawing.Point(485, 77);
			this.btn_disconnect.Name = "btn_disconnect";
			this.btn_disconnect.Size = new System.Drawing.Size(192, 41);
			this.btn_disconnect.TabIndex = 1;
			this.btn_disconnect.Text = "Desconectar DB";
			this.btn_disconnect.UseVisualStyleBackColor = true;
			this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
			// 
			// btn_load_data
			// 
			this.btn_load_data.Location = new System.Drawing.Point(286, 75);
			this.btn_load_data.Name = "btn_load_data";
			this.btn_load_data.Size = new System.Drawing.Size(142, 43);
			this.btn_load_data.TabIndex = 2;
			this.btn_load_data.Text = "Cargar Grilla";
			this.btn_load_data.UseVisualStyleBackColor = true;
			this.btn_load_data.Click += new System.EventHandler(this.btn_load_data_Click);
			// 
			// dgv_data
			// 
			this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_data.Location = new System.Drawing.Point(46, 170);
			this.dgv_data.Name = "dgv_data";
			this.dgv_data.RowHeadersWidth = 62;
			this.dgv_data.RowTemplate.Height = 28;
			this.dgv_data.Size = new System.Drawing.Size(631, 215);
			this.dgv_data.TabIndex = 3;
			// 
			// Frm_principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgv_data);
			this.Controls.Add(this.btn_load_data);
			this.Controls.Add(this.btn_disconnect);
			this.Controls.Add(this.btn_connect);
			this.Name = "Frm_principal";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_connect;
		private System.Windows.Forms.Button btn_disconnect;
		private System.Windows.Forms.Button btn_load_data;
		private System.Windows.Forms.DataGridView dgv_data;
	}
}

