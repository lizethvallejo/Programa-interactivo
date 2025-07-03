namespace GraphAlgorithms
{
    partial class FrmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rasterizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamCircularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamElipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cohenSutherlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sutherlandHodgmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelContenedor.Controls.Add(this.picCover);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1182, 753);
            this.panelContenedor.TabIndex = 2;
            // 
            // picCover
            // 
            this.picCover.Image = global::GraphAlgorithms.Properties.Resources.COMPUTACION_GRAFICA;
            this.picCover.Location = new System.Drawing.Point(9, 56);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(1170, 592);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 0;
            this.picCover.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rasterizacionToolStripMenuItem,
            this.rellenoToolStripMenuItem,
            this.recorteToolStripMenuItem,
            this.curvasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // rasterizacionToolStripMenuItem
            // 
            this.rasterizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDDAToolStripMenuItem,
            this.bresenhamToolStripMenuItem,
            this.bresenhamCircularToolStripMenuItem,
            this.bresenhamElipsesToolStripMenuItem});
            this.rasterizacionToolStripMenuItem.Name = "rasterizacionToolStripMenuItem";
            this.rasterizacionToolStripMenuItem.Size = new System.Drawing.Size(124, 27);
            this.rasterizacionToolStripMenuItem.Text = "Rasterizacion";
            // 
            // algoritmoDDAToolStripMenuItem
            // 
            this.algoritmoDDAToolStripMenuItem.Name = "algoritmoDDAToolStripMenuItem";
            this.algoritmoDDAToolStripMenuItem.Size = new System.Drawing.Size(300, 28);
            this.algoritmoDDAToolStripMenuItem.Text = "Algoritmo DDA";
            this.algoritmoDDAToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDDAToolStripMenuItem_Click);
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(300, 28);
            this.bresenhamToolStripMenuItem.Text = "Bresenham Lineas";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // bresenhamCircularToolStripMenuItem
            // 
            this.bresenhamCircularToolStripMenuItem.Name = "bresenhamCircularToolStripMenuItem";
            this.bresenhamCircularToolStripMenuItem.Size = new System.Drawing.Size(300, 28);
            this.bresenhamCircularToolStripMenuItem.Text = "Bresenham Circunferencias";
            this.bresenhamCircularToolStripMenuItem.Click += new System.EventHandler(this.bresenhamCircularToolStripMenuItem_Click);
            // 
            // bresenhamElipsesToolStripMenuItem
            // 
            this.bresenhamElipsesToolStripMenuItem.Name = "bresenhamElipsesToolStripMenuItem";
            this.bresenhamElipsesToolStripMenuItem.Size = new System.Drawing.Size(300, 28);
            this.bresenhamElipsesToolStripMenuItem.Text = "Bresenham Elipses";
            this.bresenhamElipsesToolStripMenuItem.Click += new System.EventHandler(this.bresenhamElipsesToolStripMenuItem_Click);
            // 
            // rellenoToolStripMenuItem
            // 
            this.rellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floodFillToolStripMenuItem,
            this.scanlineToolStripMenuItem});
            this.rellenoToolStripMenuItem.Name = "rellenoToolStripMenuItem";
            this.rellenoToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.rellenoToolStripMenuItem.Text = "Relleno";
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(161, 28);
            this.floodFillToolStripMenuItem.Text = "Flood Fill";
            this.floodFillToolStripMenuItem.Click += new System.EventHandler(this.floodFillToolStripMenuItem_Click);
            // 
            // scanlineToolStripMenuItem
            // 
            this.scanlineToolStripMenuItem.Name = "scanlineToolStripMenuItem";
            this.scanlineToolStripMenuItem.Size = new System.Drawing.Size(161, 28);
            this.scanlineToolStripMenuItem.Text = "Scanline";
            this.scanlineToolStripMenuItem.Click += new System.EventHandler(this.scanlineToolStripMenuItem_Click);
            // 
            // recorteToolStripMenuItem
            // 
            this.recorteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cohenSutherlandToolStripMenuItem,
            this.sutherlandHodgmanToolStripMenuItem});
            this.recorteToolStripMenuItem.Name = "recorteToolStripMenuItem";
            this.recorteToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.recorteToolStripMenuItem.Text = "Recorte";
            // 
            // cohenSutherlandToolStripMenuItem
            // 
            this.cohenSutherlandToolStripMenuItem.Name = "cohenSutherlandToolStripMenuItem";
            this.cohenSutherlandToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.cohenSutherlandToolStripMenuItem.Text = "Cohen-Sutherland";
            this.cohenSutherlandToolStripMenuItem.Click += new System.EventHandler(this.cohenSutherlandToolStripMenuItem_Click);
            // 
            // sutherlandHodgmanToolStripMenuItem
            // 
            this.sutherlandHodgmanToolStripMenuItem.Name = "sutherlandHodgmanToolStripMenuItem";
            this.sutherlandHodgmanToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.sutherlandHodgmanToolStripMenuItem.Text = "Sutherland-Hodgman";
            this.sutherlandHodgmanToolStripMenuItem.Click += new System.EventHandler(this.sutherlandHodgmanToolStripMenuItem_Click);
            // 
            // curvasToolStripMenuItem
            // 
            this.curvasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bezierToolStripMenuItem,
            this.bSplineToolStripMenuItem});
            this.curvasToolStripMenuItem.Name = "curvasToolStripMenuItem";
            this.curvasToolStripMenuItem.Size = new System.Drawing.Size(75, 27);
            this.curvasToolStripMenuItem.Text = "Curvas";
            // 
            // bezierToolStripMenuItem
            // 
            this.bezierToolStripMenuItem.Name = "bezierToolStripMenuItem";
            this.bezierToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.bezierToolStripMenuItem.Text = "Bezier";
            this.bezierToolStripMenuItem.Click += new System.EventHandler(this.bezierToolStripMenuItem_Click);
            // 
            // bSplineToolStripMenuItem
            // 
            this.bSplineToolStripMenuItem.Name = "bSplineToolStripMenuItem";
            this.bSplineToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.bSplineToolStripMenuItem.Text = "B-Spline";
            this.bSplineToolStripMenuItem.Click += new System.EventHandler(this.bSplineToolStripMenuItem_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmIndex";
            this.Text = "Inicio";
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rasterizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamCircularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamElipsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cohenSutherlandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sutherlandHodgmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSplineToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCover;
    }
}