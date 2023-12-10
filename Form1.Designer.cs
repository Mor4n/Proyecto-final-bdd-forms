namespace WindowsFormsApp1
{
    partial class Form1
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFormResizeIcon1 = new Bunifu.UI.WinForms.BunifuFormResizeIcon();
            this.bunifuColorTransition1 = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
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
            this.bunifuFormResizeIcon1.Location = new System.Drawing.Point(782, 432);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuFormResizeIcon1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuFormResizeIcon bunifuFormResizeIcon1;
        private Bunifu.UI.WinForms.BunifuColorTransition bunifuColorTransition1;
    }
}

