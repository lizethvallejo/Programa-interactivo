namespace GraphAlgorithms
{
    partial class FrmSutherlandHodgman
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
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.btnRecortar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(31, 668);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(79, 36);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRecortar
            // 
            this.btnRecortar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecortar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRecortar.Depth = 0;
            this.btnRecortar.HighEmphasis = true;
            this.btnRecortar.Icon = null;
            this.btnRecortar.Location = new System.Drawing.Point(166, 668);
            this.btnRecortar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecortar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRecortar.Size = new System.Drawing.Size(96, 36);
            this.btnRecortar.TabIndex = 17;
            this.btnRecortar.Text = "Recortar";
            this.btnRecortar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRecortar.UseAccentColor = false;
            this.btnRecortar.UseVisualStyleBackColor = true;
            this.btnRecortar.Click += new System.EventHandler(this.btnRecortar_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.picCanvas);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(31, 48);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1121, 600);
            this.materialCard2.TabIndex = 16;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(20, 37);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1084, 546);
            this.picCanvas.TabIndex = 13;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Visualizacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 684);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(463, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Haga clic con el mouse para dibujar los vertices del poligono";
            // 
            // FrmSutherlandHodgman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRecortar);
            this.Controls.Add(this.materialCard2);
            this.Name = "FrmSutherlandHodgman";
            this.Text = "FrmSutherlandHodgman";
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnRecortar;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox picCanvas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label6;
    }
}