namespace WindowsFormsApp1
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFormResizeIcon1 = new Bunifu.UI.WinForms.BunifuFormResizeIcon();
            this.bunifuColorTransition1 = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTienda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLibreria = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblNombreJuego = new System.Windows.Forms.Label();
            this.pbImagenJuego = new System.Windows.Forms.PictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.dataJuegos = new System.Windows.Forms.DataGridView();
            this.lblDinero = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuFormResizeIcon1
            // 
            this.bunifuFormResizeIcon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFormResizeIcon1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormResizeIcon1.ForeColor = System.Drawing.Color.Black;
            this.bunifuFormResizeIcon1.IconSize = 16;
            this.bunifuFormResizeIcon1.Location = new System.Drawing.Point(907, 442);
            this.bunifuFormResizeIcon1.Name = "bunifuFormResizeIcon1";
            this.bunifuFormResizeIcon1.Size = new System.Drawing.Size(21, 21);
            this.bunifuFormResizeIcon1.TabIndex = 2;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.AutoTransition = false;
            this.bunifuColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Purple,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.Orange};
            this.bunifuColorTransition1.EndColor = System.Drawing.Color.White;
            this.bunifuColorTransition1.Interval = 10;
            this.bunifuColorTransition1.ProgessValue = 0;
            this.bunifuColorTransition1.StartColor = System.Drawing.Color.White;
            this.bunifuColorTransition1.TransitionControl = null;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.btnLibreria);
            this.menu.Controls.Add(this.btnAdministrar);
            this.menu.Controls.Add(this.btnAuditoria);
            this.menu.Controls.Add(this.btnReporte);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MaximumSize = new System.Drawing.Size(200, 460);
            this.menu.MinimumSize = new System.Drawing.Size(41, 460);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 460);
            this.menu.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 100);
            this.panel1.TabIndex = 4;
            // 
            // btnTienda
            // 
            this.btnTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTienda.Image = ((System.Drawing.Image)(resources.GetObject("btnTienda.Image")));
            this.btnTienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienda.Location = new System.Drawing.Point(1, 0);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(196, 57);
            this.btnTienda.TabIndex = 4;
            this.btnTienda.Text = "       Tienda";
            this.btnTienda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.btnTienda_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTienda);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 57);
            this.panel2.TabIndex = 5;
            // 
            // btnLibreria
            // 
            this.btnLibreria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibreria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibreria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLibreria.Image = ((System.Drawing.Image)(resources.GetObject("btnLibreria.Image")));
            this.btnLibreria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibreria.Location = new System.Drawing.Point(3, 172);
            this.btnLibreria.Name = "btnLibreria";
            this.btnLibreria.Size = new System.Drawing.Size(196, 57);
            this.btnLibreria.TabIndex = 5;
            this.btnLibreria.Text = "       Librería";
            this.btnLibreria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibreria.UseVisualStyleBackColor = true;
            this.btnLibreria.Click += new System.EventHandler(this.btnLibreria_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdministrar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrar.Image")));
            this.btnAdministrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.Location = new System.Drawing.Point(3, 235);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(196, 57);
            this.btnAdministrar.TabIndex = 6;
            this.btnAdministrar.Text = "       Administrar tienda";
            this.btnAdministrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAuditoria.Image = ((System.Drawing.Image)(resources.GetObject("btnAuditoria.Image")));
            this.btnAuditoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditoria.Location = new System.Drawing.Point(3, 298);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(196, 57);
            this.btnAuditoria.TabIndex = 7;
            this.btnAuditoria.Text = "       Auditoría";
            this.btnAuditoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditoria.UseVisualStyleBackColor = true;
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú";
            // 
            // btnReporte
            // 
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(3, 361);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(196, 57);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "       Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblNombreJuego
            // 
            this.lblNombreJuego.AutoSize = true;
            this.lblNombreJuego.Location = new System.Drawing.Point(788, 84);
            this.lblNombreJuego.MaximumSize = new System.Drawing.Size(100, 60);
            this.lblNombreJuego.Name = "lblNombreJuego";
            this.lblNombreJuego.Size = new System.Drawing.Size(44, 13);
            this.lblNombreJuego.TabIndex = 5;
            this.lblNombreJuego.Text = "Nombre";
            // 
            // pbImagenJuego
            // 
            this.pbImagenJuego.Location = new System.Drawing.Point(765, 115);
            this.pbImagenJuego.Name = "pbImagenJuego";
            this.pbImagenJuego.Size = new System.Drawing.Size(138, 177);
            this.pbImagenJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenJuego.TabIndex = 6;
            this.pbImagenJuego.TabStop = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(811, 377);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(788, 307);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(100, 60);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 60);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
    "AAA";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(791, 414);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(85, 34);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // dataJuegos
            // 
            this.dataJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJuegos.Location = new System.Drawing.Point(297, 46);
            this.dataJuegos.Name = "dataJuegos";
            this.dataJuegos.RowHeadersVisible = false;
            this.dataJuegos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataJuegos.Size = new System.Drawing.Size(376, 358);
            this.dataJuegos.TabIndex = 10;
            this.dataJuegos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJuegos_CellClick);
            this.dataJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJuegos_CellContentClick);
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.ForeColor = System.Drawing.Color.Gray;
            this.lblDinero.Location = new System.Drawing.Point(785, 9);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(27, 32);
            this.lblDinero.TabIndex = 11;
            this.lblDinero.Text = "$";
            this.lblDinero.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 460);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.dataJuegos);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.pbImagenJuego);
            this.Controls.Add(this.lblNombreJuego);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.bunifuFormResizeIcon1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataJuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuFormResizeIcon bunifuFormResizeIcon1;
        private Bunifu.UI.WinForms.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLibreria;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblNombreJuego;
        private System.Windows.Forms.PictureBox pbImagenJuego;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridView dataJuegos;
        private System.Windows.Forms.Label lblDinero;
    }
}

